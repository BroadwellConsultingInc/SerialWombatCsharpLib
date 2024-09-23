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
        public const int height = 120;
        public const int width = 160;
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
            Name = $"Pin{pin}VGA";

        }
        private void bConfig_Click(object sender, EventArgs e)
        {
            vga.begin(Pin, sixteenBitAddressControl1.Value);
        }

        private void bLoad_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    vga.fillScreen(0);
                    Image i = Image.FromFile(ofd.FileName);
                    Bitmap b = (Bitmap)i;
                    for (byte y = 0; y < height; ++y)
                    {
                        for (byte x = 0; x < width; ++x)
                        {
                            float brightness = b.GetPixel(x, y).GetBrightness();
                            if (brightness > 0)
                            {
                                vga.writePixel(x, y, 1);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            vga.setLineColor((byte)trackBar1.Value,Convert.ToByte( tbFirstLine.Text),Convert.ToByte(tbLastLine.Text));
        }
    }
}
