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
    public partial class UARTForm : Form
    {

        public UARTForm(SerialWombatChip serialWombatChip, byte pin)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterParent;
            uartControl1.begin(serialWombatChip, pin);
            Text = $"Pin {pin} UART mode";
        }

        private void UARTForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            uartControl1.end();
        }
    }
}
