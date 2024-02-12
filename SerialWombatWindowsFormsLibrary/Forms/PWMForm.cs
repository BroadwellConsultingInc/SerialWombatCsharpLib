using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using SerialWombat;

namespace SerialWombatWindowsFormsLibrary
{
    public partial class PWMForm : Form
    {
        public SerialWombatPWM Pwm;
        public byte Pin = 0;
        public SerialWombatChip serialWombatChip;
        SerialWombatAbstractScaledOutput scaledOutput;
        public PWMForm(SerialWombatChip serialWombatChip, byte pin)
        {
            InitializeComponent();
            Pin = pin;
            this.serialWombatChip = serialWombatChip;
            groupBox1.Text = "";
            Text = $"PWM on pin {pin}";
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
                this.AutoSize = true;
                scaledOutput = new SerialWombatAbstractScaledOutput(serialWombatChip);
                scaledOutput.begin(pin, SerialWombatPinModes.PIN_MODE_PWM);
                ScaledOutputControl sco = new ScaledOutputControl(scaledOutput);
                sco.Left = groupBox1.Right + 10;
                this.Controls.Add(sco);
                this.Refresh();
            }
        }

        

        private void bConfigure_Click(object sender, EventArgs e)
        {
            try
            {
                Pwm = new SerialWombatPWM(serialWombatChip);
                Pwm.begin(Pin, Convert.ToUInt16(tbPosition.Text), ckbInvertSignal.Checked


                    ); //TODO add command pin.



                trackBar1.Enabled = true;
                bSetPWM.Enabled = true;
                if (serialWombatChip.ModelEnum == SerialWombatModel.SerialWombat18AB)
                {
                    Pwm.setPeriod_SW18AB_uS(Convert.ToUInt16(tbSW18ABPeriod.Text));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bSetPosition_Click(object sender, EventArgs e)
        {
            try
            {
                
                Pwm.writeDutyCycle(Convert.ToUInt16(tbPosition.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            tbPosition.Text = trackBar1.Value.ToString();
            bSetPosition_Click(null, null);
        }

        private void cbWombat4ABFreq_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
            WombatSetPinModePWM_4AB_20 packet = new WombatSetPinModePWM_4AB_20(Pin,
                (Wombat4A_B_PWMFrequencyValues)Enum.Parse(typeof(Wombat4A_B_PWMFrequencyValues), (string)cbWombat4ABFreq.Items[cbWombat4ABFreq.SelectedIndex]));
            SerialWombatChip.Send(packet);
            */
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            lDutyCycle.Text = $"{ (double)trackBar1.Value / 65536} %";
        }

        private void bRename_Click(object sender, EventArgs e)
        {
            SingleLineTextEntryForm sltef = new SingleLineTextEntryForm("Name Form", "Add a name for this form:");
            sltef.ShowDialog();
            if (sltef.Success)
            {
                this.Text = $"{sltef.outputString} PWM on pin {Pwm.Pin}";
            }
        }
    }



}

