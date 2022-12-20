using SerialWombat;
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
        public SW18ABCapTouchForm(SerialWombatChip serialWombatChip, byte pin)
        {
            InitializeComponent();
            SerialWombatChip = serialWombatChip; 
            Pin = pin;
            Text = $"Pin {pin} Analog Input";
            sW18abCapTouchControl1.begin(serialWombatChip, pin);
        }

        private void SW18ABCapTouchForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            sW18abCapTouchControl1.end();
        }
    }
}
