using SerialWombat;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SerialWombatWindowsFormsLibrary.Controls;

namespace SerialWombatWindowsFormsLibrary
{
    public partial class HSCounterForm : Form
    {
        public SerialWombatChip SerialWombatChip;

        ProcessedInputControl ProcessedInputControl;
        public HSCounterForm(SerialWombatChip serialWombatChip, byte pin )
        {
            InitializeComponent();
            SerialWombatChip = serialWombatChip;
            Text = $"High Speed Counter Input on Pin {pin}";
            hsCounterControl1.begin(SerialWombatChip, pin);
            hsCounterControl1.Name = $"Pin{pin}_HSCounter";
            if (serialWombatChip.isSW18())
            {
                SerialWombatAbstractProcessedInput processedInput = new SerialWombatAbstractProcessedInput(SerialWombatChip);
                processedInput.begin(pin, SerialWombatPinModes.PIN_MODE_PULSETIMER);
                ProcessedInputControl = new ProcessedInputControl(processedInput);
                ProcessedInputControl.Left = hsCounterControl1.Right + 10;
                ProcessedInputControl.Name = $"Pin{pin}_HSCounter";
                this.AutoSize = true;
                this.Controls.Add(ProcessedInputControl);
                this.Refresh();

            }
        }

        private void HSCounterForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            hsCounterControl1.End();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SingleLineTextEntryForm sltef = new SingleLineTextEntryForm("Name Form", "Add a name for this form:");
            sltef.ShowDialog();
            if (sltef.Success)
            {
                this.Text = $"{sltef.outputString} High Speed Counter on pin {hsCounterControl1.Pin}";
                hsCounterControl1.Name = sltef.outputString;
                if (ProcessedInputControl != null)
                {
                    ProcessedInputControl.Name = sltef.outputString;
                }
            }
        }
    }
}
