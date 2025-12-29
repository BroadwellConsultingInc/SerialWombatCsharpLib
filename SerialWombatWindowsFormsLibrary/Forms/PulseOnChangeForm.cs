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

namespace SerialWombatWindowsFormsLibrary
{
    public partial class PulseOnChangeForm : Form
    {
        SerialWombatChip SerialWombatChip;
        Byte Pin;
        public PulseOnChangeForm(SerialWombatChip serialWombatChip, byte pin)
        {
            SerialWombatChip = serialWombatChip;
            Pin = pin;
            InitializeComponent();
            Text = $"Pin {pin} Pulse On Change {serialWombatChip.description}";
            pulseOnChangeControl1.begin(serialWombatChip, pin);
            pulseOnChangeControl1.Name = $"Pin{pin}_PulseOnChange";
        }

        private void bRename_Click(object sender, EventArgs e)
        {
            SingleLineTextEntryForm sltef = new SingleLineTextEntryForm("Name Form", "Add a name for this form:");
            sltef.ShowDialog();
            if (sltef.Success)
            {
                this.Text = $"{sltef.outputString} Pulse On Change on pin {pulseOnChangeControl1.Pin}";
                pulseOnChangeControl1.Name = sltef.outputString;
               
            }
        }

    }
}
