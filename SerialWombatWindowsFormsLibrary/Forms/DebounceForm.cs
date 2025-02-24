using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using SerialWombat;


namespace SerialWombatWindowsFormsLibrary
{
    public partial class DebounceForm : Form
    {
        public SerialWombatDebouncedInput DebouncedInput;
        SerialWombatChip _serialWombat;
        byte _pin;
        UInt16 LastTransitions = 0;
        UInt16 LastStableTime = 0;
        SerialWombatPinStates LastState = SerialWombatPinStates.SW_INPUT;
     
        private delegate void SafeCallDelegate();
        public DebounceForm(SerialWombatChip serialWombat, byte pin)
        {
            InitializeComponent();
            _serialWombat = serialWombat;
            _pin = pin;
            Text = $"Debounce on pin {pin}, {_serialWombat}";
            debouncedInputControl1.begin(serialWombat, _pin);

        }

       
        private void DebounceForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            debouncedInputControl1.end();
        }

        private void bRename_Click(object sender, EventArgs e)
        {
            SingleLineTextEntryForm sltef = new SingleLineTextEntryForm("Name Form", "Add a name for this form:");
            sltef.ShowDialog();
            if (sltef.Success)
            {
                this.Text = $"{sltef.outputString} Debounced Input on pin {DebouncedInput.pin}";

            }
        }
    }
}
