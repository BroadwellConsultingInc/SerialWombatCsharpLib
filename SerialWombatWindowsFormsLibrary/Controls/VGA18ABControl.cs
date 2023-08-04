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

namespace SerialWombatWindowsFormsLibrary.Controls
{
    public partial class VGA18ABControl : UserControl
    {
        public SerialWombat18ABVGA vga;
        public byte Pin = 0;
        public SerialWombatChip SerialWombatChip;
        public VGA18ABControl()
        {
            InitializeComponent();
        }

        public void begin(SerialWombatChip serialWombatChip, byte pin)
        {
            Pin = pin;
            SerialWombatChip = serialWombatChip;
            vga = new SerialWombat18ABVGA(serialWombatChip);
           
            groupBox1.Text = $"VGA on pin {pin}";

        }
        private void bConfig_Click(object sender, EventArgs e)
        {
            vga.begin(Pin, sixteenBitAddressControl1.Value);
        }
    }
}
