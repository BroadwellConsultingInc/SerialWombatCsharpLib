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


namespace SerialWombatWindowsFormsLibrary
{
    public partial class ServoForm : Form
    {
        public SerialWombatServo Servo;
        public byte Pin = 0;
        public SerialWombatChip SerialWombatChip;
        public SerialWombatAbstractScaledOutput scaledOutput;
        public ScaledOutputControl scaledOutputControl;
        public ServoForm(SerialWombatChip serialWombatChip, byte pin)
        {
            InitializeComponent();
            Pin = pin;
            SerialWombatChip = serialWombatChip;
            groupBox1.Text = "";
            this.Text = $"Servo on pin {pin} on Serial Wombat Chip on {serialWombatChip.Serial.Port.PortName}";


            if (serialWombatChip.ModelEnum == SerialWombatModel.SerialWombat18AB)
            {
             
                this.AutoSize = true;
                scaledOutput = new SerialWombatAbstractScaledOutput(serialWombatChip);
                scaledOutput.begin(pin, SerialWombatPinModes.PIN_MODE_SERVO);
                scaledOutputControl = new ScaledOutputControl(scaledOutput);
                scaledOutputControl.Left = groupBox1.Right + 10;
                this.Controls.Add(scaledOutputControl);
                ckbOutputScalingVisible.Visible = true;
                ckbOutputScalingVisible.Checked = true;
                this.Refresh();
            }
        }

        public GroupBox GetFormGroupbox()
        {
            groupBox1.Text = $"Servo on pin {Servo.Pin}";
            Controls.Remove(groupBox1);
            return (groupBox1);
        }

        private void bConfigure_Click(object sender, EventArgs e)
        {
            try
            {
                Servo = new SerialWombatServo(SerialWombatChip);
                Servo.attach(Pin, Convert.ToUInt16(tbFixedTime.Text),
                    (UInt16)(Convert.ToUInt16(tbVariableTime.Text) + Convert.ToUInt16(tbFixedTime.Text)), ckbReverse.Checked);

                /*
                    Pin,
                    Convert.ToByte(tbCommandPin.Text), ckbReverse.Checked, ckbInvertSignal.Checked, Convert.ToUInt16(tbPosition.Text),
                    Convert.ToUInt16(tbFixedTime.Text),
                    Convert.ToUInt16(tbVariableTime.Text), Convert.ToUInt16(tbSignalPeriod.Text));
                */



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

        private void ServoForm_Shown(object sender, EventArgs e)
        {

        }

        private void ckbOutputScalingVisible_CheckedChanged(object sender, EventArgs e)
        {
            scaledOutputControl.Visible = ckbOutputScalingVisible.Checked;
            this.Refresh();
        }
    }



}

