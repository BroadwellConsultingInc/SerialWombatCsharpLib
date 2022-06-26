using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using SerialWombat;
using ScottPlot;

namespace SerialWombatWindowsFormsLibrary
{
    public partial class UltrasonicDistanceSensorForm : Form
    {

        public byte Pin = 0;
        public SerialWombatChip SerialWombatChip;
        public double[] Raw16Data = new double[100000];
        int datacount = 0;
        public PlottableSignal signalPlot;
        SerialWombatUltrasonicDistanceSensor sensor;
        UInt16 LastResult = 0;
        private delegate void SafeCallDelegate();
        public UltrasonicDistanceSensorForm(SerialWombatChip serialWombatChip, byte pin)
        {
            InitializeComponent();
            sensor = new SerialWombatUltrasonicDistanceSensor(serialWombatChip);
            tbTriggerPin.Text = (pin + 1).ToString();
            groupBox1.Text = "";
            Text = $"Ultrasonic Distance Sensor on pin {sensor.pin}";
            Pin = pin;
            signalPlot = formsPlot1.plt.PlotSignal(Raw16Data);
        }

        public UInt16 ReadRawDataAndPlot()
        {
            try
            {
                {
                    LastResult = sensor.readPublicData();
                    Raw16Data[datacount] = LastResult;


                }
                signalPlot.maxRenderIndex = datacount;
                if (datacount > 100)
                {
                    signalPlot.minRenderIndex = datacount - 100;
                }
                formsPlot1.plt.AxisAuto();
                ++datacount;




                UpdateGraph();
                if (datacount == 99999)
                {
                    datacount = 0;
                    signalPlot.minRenderIndex = 0;
                }
                return (LastResult);
            }
            catch
            {
                //Fail silently
            }
            return (0);

        }

        public void UpdateGraph()
        {
            if (formsPlot1.InvokeRequired)
            {
                var d = new SafeCallDelegate(UpdateGraph);
                formsPlot1.Invoke(d, new object[] { });
            }
            else
            {
                
                    formsPlot1.plt.AxisAuto();
                
                formsPlot1.Render();
             
                formsPlot1.plt.YLabel("Counts / 65535");
            }
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
            while (ckbAutosample.Checked)
            {
                ReadRawDataAndPlot();
                Thread.Sleep(100);
            }
        }

        private void UltrasonicDistanceSensorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ckbAutosample.Checked = false;
        }

        private void UltrasonicDistanceSensorForm_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }

        private void bConfigure_Click(object sender, EventArgs e)
        {
            sensor.begin(Pin, UltrasonicDriver.HC_SR04, Convert.ToByte(tbTriggerPin.Text));
        }
    }
}
