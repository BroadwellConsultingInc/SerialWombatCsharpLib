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
        public SerialWombatAbstractScaledOutput scaledOutput;
        public ScaledOutputControl scaledOutputControl;
        public PWMForm(SerialWombatChip serialWombatChip, byte pin)
        {
            InitializeComponent();
            Pin = pin;
            this.serialWombatChip = serialWombatChip;
          
            Text = $"PWM on pin {pin}";
            pwmControl1.begin(serialWombatChip, pin);


            if (serialWombatChip.ModelEnum == SerialWombatModel.SerialWombat18AB)
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
                this.Text = $"{sltef.outputString} PWM on pin {Pwm.Pin}";
            }
        }

        private void ckbOutputScalingVisible_CheckedChanged(object sender, EventArgs e)
        {
            scaledOutputControl.Visible = ckbOutputScalingVisible.Checked;
            this.Refresh();
        }
    }



}

