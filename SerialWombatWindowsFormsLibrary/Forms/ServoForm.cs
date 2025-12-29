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
        public byte Pin = 0;
        public SerialWombatChip SerialWombatChip;
        public SerialWombatAbstractScaledOutput scaledOutput;
        public ScaledOutputControl scaledOutputControl;
        public ServoForm(SerialWombatChip serialWombatChip, byte pin)
        {
            InitializeComponent();
            Pin = pin;
            SerialWombatChip = serialWombatChip;
            this.Text = $"Pin {pin} Servo {serialWombatChip.description}";


            if (serialWombatChip.ModelEnum == SerialWombatModel.SerialWombat18AB || serialWombatChip.ModelEnum == SerialWombatModel.SerialWombat8B)
            {
             
                this.AutoSize = true;
                scaledOutput = new SerialWombatAbstractScaledOutput(serialWombatChip);
                scaledOutput.begin(pin, SerialWombatPinModes.PIN_MODE_SERVO);
                scaledOutputControl = new ScaledOutputControl(scaledOutput);
                scaledOutputControl.Left = servoControl1.Right + 10;
                this.Controls.Add(scaledOutputControl);
                ckbOutputScalingVisible.Visible = true;
                ckbOutputScalingVisible.Checked = true;
                scaledOutputControl.Name = $"Pin{Pin}Servo";
                this.Refresh();
            }
        }



        private void ServoForm_Shown(object sender, EventArgs e)
        {

        }

        private void ckbOutputScalingVisible_CheckedChanged(object sender, EventArgs e)
        {
            scaledOutputControl.Visible = ckbOutputScalingVisible.Checked;
            this.Refresh();
        }

        private void bRename_Click(object sender, EventArgs e)
        {
            SingleLineTextEntryForm sltef = new SingleLineTextEntryForm("Name Form", "Add a name for this form:");
            sltef.ShowDialog();
            if (sltef.Success)
            {
                this.Text = $"{sltef.outputString} Servo on pin {servoControl1.Servo.Pin}";
                servoControl1.Name = sltef.outputString;
                if (scaledOutputControl != null)
                {
                    scaledOutputControl.SetPinName(sltef.outputString);
                }
            }
        }

        private void ServoForm_Load(object sender, EventArgs e)
        {
            servoControl1.begin(SerialWombatChip, Pin);
        }


    }



}

