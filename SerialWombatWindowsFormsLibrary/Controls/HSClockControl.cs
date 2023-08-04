using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SerialWombat;

namespace SerialWombatWindowsFormsLibrary.Controls
{
    public partial class HSClockControl : UserControl
    {
        
        public SerialWombatHSClock HSClock;
        public byte Pin = 0;
        public SerialWombatChip SerialWombatChip;
       
        public HSClockControl()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 2;

        }

        public void begin(SerialWombatChip serialWombatChip, byte pin)
        {
            Pin = pin;
            SerialWombatChip = serialWombatChip;
            HSClock = new SerialWombatHSClock(serialWombatChip);
            groupBox1.Text = $"HSClock on pin {pin}"; 
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                
                case 0:
                case 1:
                    {
                        trackBar1.Minimum = 1;
                        trackBar1.Maximum = 1000;
                        trackBar1.Value = 500;
                        label1.Text = "500";
                    }
                    break;

                case 2:
                    {
                        trackBar1.Value = 1;
                        trackBar1.Minimum = 1;
                        trackBar1.Maximum = 320;
                        trackBar1.Value = 20;
                        label1.Text = "2.0";
                    }
                    break;
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            UInt32 frequency = 0;
            switch (comboBox1.SelectedIndex)
            {

                case 0:
                    {
                        frequency = (UInt32) trackBar1.Value;
                        label1.Text = frequency.ToString();
                    }
                    break;
                case 1:
                    {
                        frequency = (UInt32)trackBar1.Value * 1000;
                        label1.Text = trackBar1.Value.ToString();
                    }
                    break;

                case 2:
                    {
                        frequency = (UInt32)trackBar1.Value * 100000;
                        label1.Text = (trackBar1.Value / 10.0).ToString();
                    }
                    break;
            }
            Int32 result = HSClock.begin(Pin, frequency);
            if (result > 0)
            {
                lActual.Text = $"Actual: {result}";
            }


        }
    }
}
