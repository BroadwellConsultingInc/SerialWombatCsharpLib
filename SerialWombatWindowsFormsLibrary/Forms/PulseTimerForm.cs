using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using ScottPlot;
using SerialWombat;

namespace SerialWombatWindowsFormsLibrary
{
    public partial class PulseTimerForm : Form
    {


        public SerialWombatChip SerialWombatChip;

        ProcessedInputControl ProcessedInputControl;
        public UInt16 LastHighCounts = 0;
        public UInt16 LastLowCounts = 0;
        public UInt16 LastPulses = 0;
        public DateTime frequencyTimestamp = DateTime.Now;
        public UInt16 frequencyPulses = 0;
        public double LastFrequency = 0;
        public bool LastOverflow = false;

        private delegate void SafeCallDelegate();

        public PulseTimerForm(SerialWombatChip serialWombatChip, byte pin)
        {
            InitializeComponent();
            SerialWombatChip = serialWombatChip;
            Text = $"Pulse Timer Input on Pin {pin}";
            pulseTimerControl1.begin(SerialWombatChip, pin);

            if (serialWombatChip.isSW18())
            {
                SerialWombatAbstractProcessedInput processedInput = new SerialWombatAbstractProcessedInput(SerialWombatChip);
                processedInput.begin(pin, SerialWombatPinModes.PIN_MODE_PULSETIMER);
                ProcessedInputControl = new ProcessedInputControl(processedInput);
                ProcessedInputControl.Left = pulseTimerControl1.Right + 10;
                this.AutoSize = true;
                this.Controls.Add(ProcessedInputControl);
                this.Refresh();

            }

        }
        

       

       
        

        private void PulseTimerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            pulseTimerControl1.End();
        }

    
    }
}
