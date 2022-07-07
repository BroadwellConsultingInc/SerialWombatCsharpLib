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
                
                    LastResult = sensor.readPublicData();






                UpdateGraph();
               
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
            while (ckbAutosample.Checked)
            {
                ReadRawDataAndPlot();
                Thread.Sleep(100);
            }
        }

        public void End()
        {
            ckbAutosample.Checked = false;
        }

      

        private void bConfigure_Click(object sender, EventArgs e)
        {
            sensor.begin(Pin, UltrasonicDriver.HC_SR04, Convert.ToByte(tbTriggerPin.Text));
        }
    }
}

