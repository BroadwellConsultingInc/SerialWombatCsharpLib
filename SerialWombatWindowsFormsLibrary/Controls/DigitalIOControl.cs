using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SerialWombat;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace SerialWombatWindowsFormsLibrary.Controls
{
    public partial class DigitalIOControl : UserControl
    {

        public SerialWombatDigitalIO_18AB dio;
        public byte Pin = 0;
        public SerialWombatChip SerialWombatChip;
        public DigitalIOControl()
        {
            InitializeComponent();
        }

        public void begin(SerialWombatChip serialWombatChip, byte pin)
        {
            Pin = pin;
            SerialWombatChip = serialWombatChip;
            this.Text = $"Digital IO on pin {pin} on Serial Wombat Chip on {serialWombatChip.Serial.Port.PortName}";
        }
        private void bLow_Click(object sender, EventArgs e)
        {
            dio = new SerialWombatDigitalIO_18AB(SerialWombatChip);
            dio.begin(Pin, SerialWombatPinStates.SW_LOW, ckbPullUp.Checked, ckbPullDown.Checked, ckbOpenDrain.Checked);
        }

        private void bHigh_Click(object sender, EventArgs e)
        {
            dio = new SerialWombatDigitalIO_18AB(SerialWombatChip);
            dio.begin(Pin, SerialWombatPinStates.SW_HIGH, ckbPullUp.Checked, ckbPullDown.Checked, ckbOpenDrain.Checked);
        }

        private void bInput_Click(object sender, EventArgs e)
        {
            dio = new SerialWombatDigitalIO_18AB(SerialWombatChip);
            dio.begin(Pin, SerialWombatPinStates.SW_INPUT, ckbPullUp.Checked, ckbPullDown.Checked, ckbOpenDrain.Checked);
        }
    }
}
