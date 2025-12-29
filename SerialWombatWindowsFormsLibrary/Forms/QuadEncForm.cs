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
using SerialWombatWindowsFormsLibrary.Controls;

namespace SerialWombatWindowsFormsLibrary.Forms
{
    public partial class QuadEncForm : Form
    {
        public SerialWombatChip SerialWombatChip;
        ProcessedInputControl ProcessedInputControl;
        public QuadEncForm(SerialWombatChip serialWombatChip, byte pin)
        {
            InitializeComponent();
            SerialWombatChip = serialWombatChip;
            Text = $"Pin {pin} Quadrature Encoder Input {serialWombatChip.description}";
            quadEncControl1.begin(SerialWombatChip, pin);

            if (serialWombatChip.isSW18())
            {
                SerialWombatAbstractProcessedInput processedInput = new SerialWombatAbstractProcessedInput(SerialWombatChip);
                processedInput.begin(pin, SerialWombatPinModes.PIN_MODE_QUADRATUREENCODER);
                ProcessedInputControl = new ProcessedInputControl(processedInput);
                ProcessedInputControl.Left = quadEncControl1.Right + 10;
                this.AutoSize = true;
                this.Controls.Add(ProcessedInputControl);
                this.Refresh();

            }
        }

        private void QuadEncForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            quadEncControl1.End();
        }


        private void bRenameWindow_Click(object sender, EventArgs e)
        {
            SingleLineTextEntryForm sltef = new SingleLineTextEntryForm("Name Form", "Add a name for this form:");
            sltef.ShowDialog();
            if (sltef.Success)
            {
                this.Text = $"{sltef.outputString} Pulse Measurement on pin {quadEncControl1.Pin}";
                quadEncControl1.Name = sltef.outputString;
                if (ProcessedInputControl != null)
                {
                    ProcessedInputControl.Name = sltef.outputString;
                }
            }
        }

     
    }
}
