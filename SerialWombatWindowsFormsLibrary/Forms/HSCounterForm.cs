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
using SerialWombat;
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
            Text = $"Pulse Timer Input on Pin {pin}";
            hsCounterControl1.begin(SerialWombatChip, pin);

            if (serialWombatChip.isSW18())
            {
                SerialWombatAbstractProcessedInput processedInput = new SerialWombatAbstractProcessedInput(SerialWombatChip);
                processedInput.begin(pin, SerialWombatPinModes.PIN_MODE_PULSETIMER);
                ProcessedInputControl = new ProcessedInputControl(processedInput);
                ProcessedInputControl.Left = hsCounterControl1.Right + 10;
                this.AutoSize = true;
                this.Controls.Add(ProcessedInputControl);
                this.Refresh();

            }
        }

        private void HSCounterForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            hsCounterControl1.End();
        }
    }
}
