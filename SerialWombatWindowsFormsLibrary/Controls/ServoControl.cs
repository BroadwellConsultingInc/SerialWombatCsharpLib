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
            Name = $"Pin{Pin}Servo";
            sbsiPosition.trackBarValueChangedDelegates.Add(bSetPosition_Click);
        }
        public void bConfigure_Click(object sender, EventArgs e)
        {
            try
            {
                Servo.attach(Pin, Convert.ToUInt16(tbFixedTime.Text),
                    (UInt16)(Convert.ToUInt16(tbVariableTime.Text) + Convert.ToUInt16(tbFixedTime.Text)), ckbReverse.Checked);


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

                Servo.write16bit(sbsiPosition.value);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    

        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public new string Text { get { return groupBox1.Text; } set { groupBox1.Text = value; } }

        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]

        public bool ShowConfigure { get { return gbConfigure.Visible; } set { gbConfigure.Visible = value; } }

        public UInt16 Value { get { 
                return Servo.readPublicData(); } set { 
                sbsiPosition.value = value;
                try
                {
                    if (Servo != null)
                    {
                        Servo.writePublicData(value);
                    }
                }
                catch { }
            } }
        
        private void button4_Click(object sender, EventArgs e)
        {
            string servoType = "SerialWombatServo";
            if (Servo._sw.isSW18())
            {
                servoType = "SerialWombatServo_18AB";
            }
            string s =
            @$"
                //Put this line before setup()
                {servoType} {Name}(sw); // Your serial wombat chip may be named something else than sw
                //Add this line to  setup():
                  {Name}.attach({Pin},//Pin
                {Convert.ToUInt16(tbFixedTime.Text)}, //Minimum Pulse Time
     {(UInt16)(Convert.ToUInt16(tbVariableTime.Text) + Convert.ToUInt16(tbFixedTime.Text))}, //MaximumPulse time
        {ckbReverse.Checked});  //Reverse";
            s = s.Replace("True", "true");
            s = s.Replace("False", "false");
            Clipboard.SetText(s);


        }
    }
}
