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
    public partial class VGA18ABForm : Form
    {
        SerialWombatChip SerialWombatChip;
        byte Pin;
        public VGA18ABForm(SerialWombatChip serialWombatChip, byte pin)
        {
            this.SerialWombatChip = serialWombatChip;
            Pin = pin;
            this.Text = $"Pin {pin} VGA";
            InitializeComponent();
            if (pin != 18)
            {
                MessageBox.Show("Only Pin 18 is supported for VGA output.  18 = VSYNC, 17 = HSYNC, 16 = Red, 15 = Green, 14 = Blue");
                vgA18abControl1.Enabled = false;
            }
           
        }

        private void VGA18ABForm_Load(object sender, EventArgs e)
        {
            if (vgA18abControl1.Enabled)
            {
                vgA18abControl1.begin(SerialWombatChip, Pin);
            }
        }
    }
}
