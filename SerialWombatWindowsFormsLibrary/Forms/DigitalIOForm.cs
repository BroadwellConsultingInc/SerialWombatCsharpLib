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
    public partial class DigitalIOForm : Form
    {
        public byte Pin = 0;
        public SerialWombatChip SerialWombatChip;
        public SerialWombatAbstractScaledOutput scaledOutput;
        public ScaledOutputControl scaledOutputControl;
        public SerialWombatAbstractProcessedInput processedInput;
        public ProcessedInputControl processedInputControl;
        public DigitalIOForm(SerialWombatChip serialWombatChip, byte pin)
        {
            InitializeComponent();
            Pin = pin;
            SerialWombatChip = serialWombatChip;
            this.Text = $"Digital IO on pin {pin} on {serialWombatChip.description}";

            if (SerialWombatChip.isSW08() || SerialWombatChip.isSW18())
            {

                this.AutoSize = true;
                scaledOutput = new SerialWombatAbstractScaledOutput(SerialWombatChip);
                scaledOutput.biDirectional = true;
                scaledOutput.begin(pin, SerialWombatPinModes.PIN_MODE_DIGITALIO);
                scaledOutputControl = new ScaledOutputControl(scaledOutput);
                scaledOutputControl.Left = digitalioControl1.Right + 10;
                this.Controls.Add(scaledOutputControl);
                ckbOutputScalingVisible.Checked = false;
                scaledOutputControl.Visible = false;
                scaledOutputControl.SetPinName($"Pin{Pin}DigitalIO");

                processedInput = new SerialWombatAbstractProcessedInput(SerialWombatChip);
                processedInput.begin(pin, SerialWombatPinModes.PIN_MODE_DIGITALIO);
                processedInputControl = new ProcessedInputControl(processedInput);
                processedInputControl.Left = digitalioControl1.Right + 10;
                this.Controls.Add(processedInputControl);
                ckbInputProcessingVisible.Checked = false;
                processedInputControl.Visible = false;
                this.Refresh();
            }
            digitalioControl1.begin(SerialWombatChip, Pin);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PublicDataMonitorForm pdmf = new PublicDataMonitorForm(SerialWombatChip, Pin);
            pdmf.Show();
        }

        private void ckbOutputScalingVisible_CheckedChanged(object sender, EventArgs e)
        {
            scaledOutputControl.Visible = ckbOutputScalingVisible.Checked;

        }

        private void ckbInputProcessingVisible_CheckedChanged(object sender, EventArgs e)
        {
            processedInputControl.Visible = ckbInputProcessingVisible.Checked;
        }
    }
}
