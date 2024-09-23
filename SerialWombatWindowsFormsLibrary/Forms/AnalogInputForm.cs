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
using SerialWombatWindowsFormsLibrary.Controls;


namespace SerialWombatWindowsFormsLibrary
{
    public partial class AnalogInputForm : Form
    {
       
        public byte Pin = 0;
        public SerialWombatChip SerialWombatChip;
        ProcessedInputControl ProcessedInputControl;
 
        public AnalogInputForm(SerialWombatChip serialWombatChip, byte pin)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterParent; 
            Pin = pin;
            SerialWombatChip = serialWombatChip;
            
            Text = $"Pin {pin} Analog Input";
            analogInputControl1.begin(serialWombatChip, pin);
            analogInputControl1.Name = $"Pin{pin}_AnalogInput";

            if (serialWombatChip.isSW18())
            {
                SerialWombatAbstractProcessedInput processedInput = new SerialWombatAbstractProcessedInput(SerialWombatChip);
                processedInput.begin(pin, SerialWombatPinModes.PIN_MODE_ANALOGINPUT);
                ProcessedInputControl = new ProcessedInputControl(processedInput);
                ProcessedInputControl.Left = analogInputControl1.Right + 10;
                this.AutoSize = true;
                this.Controls.Add(ProcessedInputControl);
                ProcessedInputControl.Name = $"Pin{pin}_AnalogInput";
                this.Refresh();

            }
           


        }


        private void AnalogInputForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            analogInputControl1.end();
        }

        private void bRename_Click(object sender, EventArgs e)
        {
            SingleLineTextEntryForm sltef = new SingleLineTextEntryForm("Name Form", "Add a name for this form:");
            sltef.ShowDialog();
            if (sltef.Success)
            {
                this.Text = $"{sltef.outputString} Analog Measurement on pin {analogInputControl1.Pin}";
                analogInputControl1.Name = sltef.outputString;
                if (ProcessedInputControl !=null)
                {
                    ProcessedInputControl.Name = sltef.outputString;
                }
            }
        }

        private void analogInputControl1_Load(object sender, EventArgs e)
        {

        }
    }

    
}
