using SerialWombat;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SerialWombatWindowsFormsLibrary
{
    public partial class ServoControl : UserControl
    {
        public SerialWombatServo_18AB Servo;
        public byte Pin = 0;
        public SerialWombatChip SerialWombatChip;
        public ServoControl(SerialWombatChip serialWombatChip, byte pin)
        {
            InitializeComponent();
            Pin = pin;
            SerialWombatChip = serialWombatChip;
            Servo = new SerialWombatServo_18AB(serialWombatChip);
            groupBox1.Text = "";

                this.Text = $"Servo on pin {pin} on Serial Wombat Chip on {serialWombatChip.Serial.Port.PortName}";
            
        }

        private void bConfigure_Click(object sender, EventArgs e)
        {
            try
            {
                Servo.attach(Pin, Convert.ToUInt16(tbFixedTime.Text),
                    (UInt16)(Convert.ToUInt16(tbVariableTime.Text) + Convert.ToUInt16(tbFixedTime.Text)), ckbReverse.Checked);

              

                trackBar1.Enabled = true;
                bSetPosition.Enabled = true;

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

                Servo.write16bit(Convert.ToUInt16(tbPosition.Text));
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
    }
}
