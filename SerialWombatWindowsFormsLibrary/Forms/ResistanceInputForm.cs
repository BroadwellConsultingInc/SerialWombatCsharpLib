using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using SerialWombat;
using ScottPlot;

namespace SerialWombatWindowsFormsLibrary
{
    public partial class ResistanceInputForm : Form
    {
        public SerialWombatResistanceInput ResistanceInput;
        public byte Pin = 0;
        public SerialWombatChip SerialWombatChip;
        ProcessedInputControl ProcessedInputControl;



        public ResistanceInputForm(SerialWombatChip serialWombatChip, byte pin)
        {
            InitializeComponent();
            SerialWombatChip = serialWombatChip;
            Pin = pin;

            resistanceInputControl1.begin(serialWombatChip, pin);
            this.Text = $"Pin {pin} Resistance Input";

            if (serialWombatChip.isSW18())
            {
                SerialWombatAbstractProcessedInput processedInput = new SerialWombatAbstractProcessedInput(SerialWombatChip);
                processedInput.begin(pin, SerialWombatPinModes.PIN_MODE_RESISTANCEINPUT);
                ProcessedInputControl = new ProcessedInputControl(processedInput);
                ProcessedInputControl.Left = resistanceInputControl1.Right + 10;
                this.AutoSize = true;
                this.Controls.Add(ProcessedInputControl);
                this.Refresh();

            }

        }

        private void ResistanceInputForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            resistanceInputControl1.End();
        }
    }
}
