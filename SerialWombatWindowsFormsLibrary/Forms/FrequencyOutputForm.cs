using SerialWombat;
using SerialWombatWindowsFormsLibrary.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerialWombatWindowsFormsLibrary.Forms
{
    public partial class FrequencyOutputForm : Form
    {
        public SerialWombatFrequencyOutput fo;
        public byte Pin = 0;
        public SerialWombatChip serialWombatChip;
        public SerialWombatAbstractScaledOutput scaledOutput;
        public ScaledOutputControl scaledOutputControl;
        public FrequencyOutputForm(SerialWombatChip serialWombatChip, byte pin)
        {
            InitializeComponent();
            Pin = pin;
            this.serialWombatChip = serialWombatChip;

            Text = $"Frequency Output on pin {pin}";
            frequencyOutputControl1.begin(serialWombatChip, pin);


            if (serialWombatChip.ModelEnum == SerialWombatModel.SerialWombat18AB)
            {

                this.AutoSize = true;
                scaledOutput = new SerialWombatAbstractScaledOutput(serialWombatChip);
                scaledOutput.begin(pin, SerialWombatPinModes.PIN_MODE_FREQUENCY_OUTPUT);
                scaledOutputControl = new ScaledOutputControl(scaledOutput);
                scaledOutputControl.Left = frequencyOutputControl1.Right + 10;
                this.Controls.Add(scaledOutputControl);
                ckbOutputScalingVisible.Visible = true;
                ckbOutputScalingVisible.Checked = true;
                scaledOutputControl.Name = $"Pin{Pin}FrequencyOutput";
                this.Refresh();
            }

        }

        private void bRename_Click(object sender, EventArgs e)
        {
            SingleLineTextEntryForm sltef = new SingleLineTextEntryForm("Name Form", "Add a name for this form:");
            sltef.ShowDialog();
            if (sltef.Success)
            {
                this.Text = $"{sltef.outputString} FrequencyOutput on pin {frequencyOutputControl1.fo.pin}";
                scaledOutputControl.Name = $"{sltef.Text}FrequencyOutput";
            }
        }

        private void ckbOutputScalingVisible_CheckedChanged(object sender, EventArgs e)
        {
            scaledOutputControl.Visible = ckbOutputScalingVisible.Checked;
            this.Refresh();
        }
    }
}
