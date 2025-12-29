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
    public partial class SW18ABCapTouchForm : Form
    {
        public byte Pin = 0;
        public SerialWombatChip SerialWombatChip;
        ProcessedInputControl ProcessedInputControl;
        public SW18ABCapTouchForm(SerialWombatChip serialWombatChip, byte pin)
        {
            InitializeComponent();
            SerialWombatChip = serialWombatChip; 
            Pin = pin;
            Text = $"Pin {pin} Cap Touch Input {serialWombatChip.description}";
            capTouch18abControl1.begin(serialWombatChip, pin);
            if (serialWombatChip.isSW18())
            {
                SerialWombatAbstractProcessedInput processedInput = new SerialWombatAbstractProcessedInput(SerialWombatChip);
                processedInput.begin(pin, SerialWombatPinModes.PIN_MODE_SW18AB_CAPTOUCH);
                ProcessedInputControl = new ProcessedInputControl(processedInput);
                ProcessedInputControl.Left = capTouch18abControl1.Right + 10;
                this.AutoSize = true;
                this.Controls.Add(ProcessedInputControl);
                ProcessedInputControl.Name = $"Pin{pin}_CapTouchInput";
                this.Refresh();

            }
        }

        private void SW18ABCapTouchForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            capTouch18abControl1.end();
        }
    }
}
