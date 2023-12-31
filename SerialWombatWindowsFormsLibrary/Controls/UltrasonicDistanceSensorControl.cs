using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScottPlot;
using SerialWombat;

namespace SerialWombatWindowsFormsLibrary.Controls
{
    public partial class UltrasonicDistanceSensorControl : UserControl
    {
        public byte Pin = 0;
        public SerialWombatChip SerialWombatChip;

        SerialWombatUltrasonicDistanceSensor sensor;
        UInt16 LastResult = 0;
        private delegate void SafeCallDelegate();
        public UltrasonicDistanceSensorControl()
        {
            InitializeComponent();
        }

        public void begin(SerialWombatChip serialWombatChip, byte pin)
        {
            SerialWombatChip = serialWombatChip;
            Pin = pin;
            sensor = new SerialWombatUltrasonicDistanceSensor(serialWombatChip);
            tbTriggerPin.Text = (pin + 1).ToString();
            groupBox1.Text = "";
            Text = $"Ultrasonic Distance Sensor on pin {sensor.pin}";
        }
        public void ReadRawDataAndPlot()
        {
            try
            {
                if (ckbAutosample.Checked)
                {

                    LastResult = sensor.readPublicData();
                    UpdateGraph();
                }
                if (ckbServoAutoSample.Checked)
                {
                    byte[] data = new byte[(int)nudServoPositions.Value * 2];
                    
                    double[,] distances = new double[1, (int)nudServoPositions.Value * 2];
                    SerialWombatChip.readUserBuffer(sbacMemoryIndex.Value, data, (UInt16)(nudServoPositions.Value * 2));
                    
                   
                    
                    for (int i = 0; i < nudServoPositions.Value; ++i)
                    {
                        int index = i;
                       // index = (int)(i + 6 * nudServoPositions.Value / 4);
                        
                        if (i < nudServoPositions.Value/2)
                        {
                            
                            index = i + (int)(nudServoPositions.Value * 3 / 2);
                        }
                        else
                        {
                            index = i - (int)(nudServoPositions.Value /2);
                        }
                      

                       distances[0,index] = data[i*2] + data[i*2+1]*256;
                    }

                    formsPlot1.plt.Clear();
                    formsPlot1.plt.PlotRadar(distances);
                    formsPlot1.Render();
                }
               
            }
            catch
            {
                //Fail silently
            }


        }

        public void UpdateGraph()
        {
            realTimeScottPlot1.PlotData(LastResult);
        }

        private void bSample_Click(object sender, EventArgs e)
        {
            ReadRawDataAndPlot();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbAutosample.Checked)
            {
                Thread t = new Thread(SampleThread);
                t.Start();
                bSample.Enabled = false;

            }
            else
            {
                bSample.Enabled = true;
            }
        }

        void SampleThread()
        {
            while (ckbAutosample.Checked  || ckbServoAutoSample.Checked)
            {
                ReadRawDataAndPlot();
                Thread.Sleep(100);
            }
        }

        public void End()
        {
            ckbAutosample.Checked = false;
            ckbServoAutoSample.Checked = false;
        }

      

        private void bConfigure_Click(object sender, EventArgs e)
        {
            sensor.begin(Pin, UltrasonicDriver.HC_SR04, Convert.ToByte(tbTriggerPin.Text));
           

        }

        private void bservoSweepConfigure_Click(object sender, EventArgs e)
        {
            
           
            sensor.configureServoSweep((byte)nudServoPin.Value, sbacMemoryIndex.Value, (UInt16)nudServoPositions.Value,
               (UInt16)nudServoIncrement.Value,ckbReverse.Checked, 
               (UInt16)nudMoveDelay.Value, (UInt16)nudReturnDelay.Value);
            formsPlot1.plt.Clear();
            double[,] values = { { 0,0 } };
            var radar = formsPlot1.plt.PlotRadar(values);
            formsPlot1.plt.Grid(false);
            formsPlot1.plt.Frame(false);
            formsPlot1.plt.Ticks(false, false);
            

            formsPlot1.Render();
        }

        private void ckbservoSweepEnable_CheckedChanged(object sender, EventArgs e)
        {
            sensor.enableServoSweep(ckbservoSweepEnable.Checked);
        }

        private void formsPlot1_Load(object sender, EventArgs e)
        {
           
        }

        private void ckbServoAutoSample_CheckedChanged(object sender, EventArgs e)
        {
            if (!ckbAutosample.Checked)
            {
                Thread t = new Thread(SampleThread);
                t.Start();
            }
        }

    }
}

