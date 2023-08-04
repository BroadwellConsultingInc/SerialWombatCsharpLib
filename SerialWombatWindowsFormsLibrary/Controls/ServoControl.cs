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
        public ServoControl()
        {
            InitializeComponent();     

        }

        public void begin(SerialWombatChip serialWombatChip, byte pin)
        {
            Pin = pin;
            SerialWombatChip = serialWombatChip;
            Servo = new SerialWombatServo_18AB(serialWombatChip);
            groupBox1.Text = "";

            this.Text = $"Servo on pin {pin} on Serial Wombat Chip on {serialWombatChip.Serial.Port.PortName}";
        }
        public void bConfigure_Click(object sender, EventArgs e)
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
            if (Servo == null) return;
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

        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public new string Text { get { return groupBox1.Text; } set { groupBox1.Text = value; } }

        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]

        public bool ShowConfigure { get { return gbConfigure.Visible; } set { gbConfigure.Visible = value; } }

        public UInt16 Value { get { 
                return Servo.readPublicData(); } set { 
                trackBar1.Value = value;
                try
                {
                    if (Servo != null)
                    {
                        Servo.writePublicData(value);
                    }
                }
                catch { }
            } }

    }
}
