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

namespace SerialWombatWindowsFormsLibrary.Controls
{
    public partial class PWMControl : UserControl
    {
        public SerialWombatPWM Pwm;
        SerialWombatChip SerialWombatChip;
        byte Pin;
       

        public PWMControl(SerialWombatChip serialWombatChip, byte pin)
        {
            InitializeComponent();
            SerialWombatChip = serialWombatChip;
            Pin = pin;

            groupBox1.Text =  $"PWM on pin {pin}";
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
            sbsiDutyCycle.trackBarValueChangedDelegates.Add( trackBar1_ValueChanged);
        }
        private void bConfigure_Click(object sender, EventArgs e)
        {
            try
            {
                Pwm = new SerialWombatPWM(SerialWombatChip);
                Pwm.begin(Pin, sbsiDutyCycle.value, ckbInvertSignal.Checked


                    ); //TODO add command pin.



                sbsiDutyCycle.Enabled = true;
                bSetPWM.Enabled = true;
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

        private void bSetDutyCycle_Click(object sender, EventArgs e)
        {
            try
            {

                Pwm.writeDutyCycle(sbsiDutyCycle.value);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
        
            bSetDutyCycle_Click(null, null);
        }
    }
}
