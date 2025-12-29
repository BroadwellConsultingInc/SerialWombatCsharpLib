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
using SerialWombatClassLibrary;

namespace SerialWombatWindowsFormsLibrary.Forms
{
    public partial class IRRxForm : Form
    {
        public IRRxForm()
        {
            InitializeComponent();
        }

        public IRRxForm(SerialWombatChip serialWombatChip, byte pin)
        {
            InitializeComponent();
            SerialWombatChip SerialWombatChip = serialWombatChip;
            Text = $"Pin {pin} IR RX {serialWombatChip.description}";
            irRxControl1.begin(SerialWombatChip, pin);
            irRxControl1.Name = $"Pin{pin}_IRRx";

        }

        private void bRename_Click(object sender, EventArgs e)
        {
            SingleLineTextEntryForm sltef = new SingleLineTextEntryForm("Name Form", "Add a name for this form:");
            sltef.ShowDialog();
            if (sltef.Success)
            {
                this.Text = $"{sltef.outputString} High Speed Counter on pin {irRxControl1.Pin}";
                irRxControl1.Name = sltef.outputString;
                
            }
        }
    }
}
