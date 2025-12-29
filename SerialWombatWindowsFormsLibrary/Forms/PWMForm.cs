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
        public byte Pin = 0;
        public SerialWombatChip serialWombatChip;
        public SerialWombatAbstractScaledOutput scaledOutput;
        public ScaledOutputControl scaledOutputControl;
        public PWMForm(SerialWombatChip serialWombatChip, byte pin)
        {
            InitializeComponent();
            Pin = pin;
            this.serialWombatChip = serialWombatChip;
          
            Text = $"pin {pin} PWM {serialWombatChip.description}";
            pwmControl1.begin(serialWombatChip, pin);


            if (serialWombatChip.isSW18() || serialWombatChip.isSW08())
            {

                this.AutoSize = true;
                scaledOutput = new SerialWombatAbstractScaledOutput(serialWombatChip);
                scaledOutput.begin(pin, SerialWombatPinModes.PIN_MODE_PWM);
                scaledOutputControl = new ScaledOutputControl(scaledOutput);
                scaledOutputControl.Left = pwmControl1.Right + 10;
                this.Controls.Add(scaledOutputControl);
                ckbOutputScalingVisible.Visible = true;
                ckbOutputScalingVisible.Checked = true;
                scaledOutputControl.Name = $"Pin{Pin}PWM";
                this.Refresh();
            }

        }

        
      

       

        

        private void bRename_Click(object sender, EventArgs e)
        {
            SingleLineTextEntryForm sltef = new SingleLineTextEntryForm("Name Form", "Add a name for this form:");
            sltef.ShowDialog();
            if (sltef.Success)
            {
                this.Text = $"{sltef.outputString} PWM on pin {pwmControl1.Pwm.Pin}";
                pwmControl1.Name = sltef.outputString;
                if (scaledOutputControl != null)
                {
                    scaledOutputControl.PinName = sltef.outputString;
                }
            }
        }

        private void ckbOutputScalingVisible_CheckedChanged(object sender, EventArgs e)
        {
            scaledOutputControl.Visible = ckbOutputScalingVisible.Checked;
            this.Refresh();
        }
    }



}

