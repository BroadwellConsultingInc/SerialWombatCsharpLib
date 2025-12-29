using ScottPlot;
using SerialWombat;
using SerialWombatWindowsFormsLibrary.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Windows.Forms;

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
            Text = $"Pin {pin} Pulse Timer Input {serialWombatChip.description}";
            pulseTimerControl1.begin(SerialWombatChip, pin);
            pulseTimerControl1.Name = $"Pin{pin}PulseTimer";

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

        private void ckbShowInputProcessing_CheckedChanged(object sender, EventArgs e)
        {
            ProcessedInputControl.Visible = ckbShowInputProcessing.Checked;
           
        }

        private void bRenameWindow_Click(object sender, EventArgs e)
        {
            SingleLineTextEntryForm sltef = new SingleLineTextEntryForm("Name Form", "Add a name for this form:");
            sltef.ShowDialog();
            if (sltef.Success)
            {
                this.Text = $"{sltef.outputString} Pulse Measurement on pin {pulseTimerControl1.Pin}";
                pulseTimerControl1.Name = sltef.outputString;
                if (ProcessedInputControl != null)
                {
                    ProcessedInputControl.Name = sltef.outputString;
                }
            }
        }

    }
}
