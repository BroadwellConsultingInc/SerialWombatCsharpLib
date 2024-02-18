using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using SerialWombat;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SerialWombatWindowsFormsLibrary.Controls
{
    public partial class PWMControl : UserControl
    {
        public SerialWombatPWM Pwm;
        SerialWombatChip SerialWombatChip;
        byte Pin;

        public PWMControl()
        {
            InitializeComponent();
        }

       public void begin(SerialWombatChip serialWombatChip, byte pin)
        {
            SerialWombatChip = serialWombatChip;
            Pin = pin;

            groupBox1.Text = $"PWM on pin {pin}";
            if (serialWombatChip.ModelEnum == SerialWombatModel.SerialWombat4A ||
                serialWombatChip.ModelEnum == SerialWombatModel.SerialWombat4B)
            {
                cbWombat4ABFreq.Visible = true;
                List<String> freqNames = new List<string>(); //TODO Enum.GetNames(typeof(Wombat4A_B_PWMFrequencyValues)).ToList();
                freqNames.Sort(delegate (string c1, string c2)
                {
                    Regex r = new Regex("(\\d+)");
                    Match m = r.Match(c1);
                    int i1 = Convert.ToInt32(m.Groups[1].Value);
                    m = r.Match(c2);
                    int i2 = Convert.ToInt32(m.Groups[1].Value);
                    return i1.CompareTo(i2);
                });

                foreach (string s in freqNames)
                {
                    cbWombat4ABFreq.Items.Add(s);
                }
            }
            else
            {
                cbWombat4ABFreq.Visible = false;
            }
            if (serialWombatChip.ModelEnum == SerialWombatModel.SerialWombat18AB)
            {
                lPeriod.Visible = true;
                tbSW18ABPeriod.Visible = true;

            }
            sbsiDutyCycle.trackBarValueChangedDelegates.Add(trackBar1_ValueChanged);
            this.Name = $"Pin{pin}PWM";
        
        }
        private void bConfigure_Click(object sender, EventArgs e)
        {
            try
            {
                Pwm = new SerialWombatPWM(SerialWombatChip);
                Pwm.begin(Pin, sbsiDutyCycle.value, ckbInvertSignal.Checked ); 
       
                if (SerialWombatChip.ModelEnum == SerialWombatModel.SerialWombat18AB)
                {
                    Pwm.setPeriod_SW18AB_uS(Convert.ToUInt16(tbSW18ABPeriod.Text));
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

      

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
        
            if (Pwm != null)
            {
                Pwm.writeDutyCycle(sbsiDutyCycle.value);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string pwmType = "SerialWombatPWM";
            if (Pwm._sw.isSW18())
            {
                pwmType = "SerialWombatPWM_18AB";
            }
            string s =
            @$"
                //Put this line before setup()
                {pwmType} {Name}(sw); // Your serial wombat chip may be named something else than sw
                //Add this to  setup():
                                {Name}.begin({Pin}, //Pin Number
                                {sbsiDutyCycle.value}, // Duty Cycle (out of 65535)
                                {ckbInvertSignal.Checked}); // Invert (subtracts duty cycle from 65535)
                               
";
            if (Pwm._sw.isSW18())
            {
                s += $@" {Name}.writePeriod_uS({Convert.ToUInt16(tbSW18ABPeriod.Text)}); // Set period in uS
";
            }
            s = s.Replace("True", "true");
            s = s.Replace("False", "false");
            Clipboard.SetText(s);
        }
    }
}
