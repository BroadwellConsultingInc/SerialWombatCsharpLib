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

namespace SerialWombatWindowsFormsLibrary.Forms
{
    public partial class HSClockForm : Form
    {
        SerialWombatChip SerialWombatChip;
        byte Pin;
        public HSClockForm(SerialWombatChip serialWombatChip, byte pin)
        {
            SerialWombatChip = serialWombatChip;
            Pin = pin;
            InitializeComponent();
            this.Text = $"Pin {pin} HS Clock";
        }

        private void HSClockForm_Load(object sender, EventArgs e)
        {
            hsClockControl1.begin(SerialWombatChip, Pin);
        }
    }
}
