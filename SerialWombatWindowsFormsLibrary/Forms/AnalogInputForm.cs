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
    public partial class AnalogInputForm : Form
    {
       
        public byte Pin = 0;
        public SerialWombatChip SerialWombatChip;
        ProcessedInputControl ProcessedInputControl;
 
        public AnalogInputForm(SerialWombatChip serialWombatChip, byte pin)
        {
            InitializeComponent();
            Pin = pin;
            SerialWombatChip = serialWombatChip;
            
            Text = $"Pin {pin} Analog Input";
            analogInputControl1.begin(serialWombatChip, pin);

            if (serialWombatChip.isSW18())
            {
                SerialWombatAbstractProcessedInput processedInput = new SerialWombatAbstractProcessedInput(SerialWombatChip);
                processedInput.begin(pin, SerialWombatPinModes.PIN_MODE_ANALOGINPUT);
                ProcessedInputControl = new ProcessedInputControl(processedInput);
                ProcessedInputControl.Left = analogInputControl1.Right + 10;
                this.AutoSize = true;
                this.Controls.Add(ProcessedInputControl);
                this.Refresh();

            }
           


        }


        private void AnalogInputForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            analogInputControl1.end();
        }
    }

    
}
