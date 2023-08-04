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

namespace WombatPanelWindowsForms
{
    public partial class StartupCommandsViewer : Form
    {
        public SerialWombatChip sw;
        public StartupCommandsViewer(SerialWombatChip serialWombatChip)
        {
            sw = serialWombatChip;
            InitializeComponent();
        }

        private void bRead_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            for (UInt32 addr = 0x27000; addr < 0x27800;)
            {
                UInt32 data = sw.readFlashAddress(addr);
                if ((data & 0xFF) == 0x55) break;
                textBox1.AppendText($"{(data & 0xFF):X2} {((data >> 8) & 0xFF):X2} {((data >> 16) & 0xFF):X2} ");
                addr += 2;
                data = sw.readFlashAddress(addr);
                textBox1.AppendText($"{(data & 0xFF):X2} {((data >> 8) & 0xFF):X2} {((data >> 16) & 0xFF):X2} ");
                addr += 2;
                data = sw.readFlashAddress(addr);
                textBox1.AppendText($"{(data & 0xFF):X2} {((data >> 8) & 0xFF):X2} {Environment.NewLine}");
                addr += 2;

            }
        }
    }
}
