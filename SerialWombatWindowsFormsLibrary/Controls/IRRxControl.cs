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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace SerialWombatWindowsFormsLibrary.Controls
{
    public partial class IRRxControl : UserControl
    {
        public SerialWombatIRRx irrx;
        public SerialWombatChip SerialWombatChip;
        public byte Pin;
        public IRRxControl()
        {
            InitializeComponent();
        }

        public void begin(SerialWombatChip serialWombatChip, byte pin)
        {
            SerialWombatChip = serialWombatChip;
            Pin = pin;
            groupBox1.Text = $"IR Receive on pin {pin}";
            this.Name = $"Pin{pin}IRRx";
        }

        private void bConfigure_Click(object sender, EventArgs e)
        {
            irrx = new SerialWombatIRRx(SerialWombatChip);
            irrx.begin(Pin, 0, ckbUseRepeat.Checked, ckbActiveHigh.Checked ? SerialWombatPinStates.SW_HIGH : SerialWombatPinStates.SW_LOW,
                sbsiTimeout.value, sbsiTimeoutValue.value, ckbUseAddress.Checked, sbacAddress.Value,(SerialWombatIRRxPublicDataOutput) enumDropdown1.selectedItem);
        }

        int lineNumber = 0;
        private void bReadQueue_Click(object sender, EventArgs e)
        {
            int i = 0;

            while (i >= 0)
            {
                i = irrx.read();
                if (i >= 0)
                {
                    if (ckbLineNumbers.Checked)
                    {
                        textBox1.AppendText($"{lineNumber}: ");
                        ++lineNumber;
                    }
                    textBox1.AppendText($"0x{i:X02}{Environment.NewLine}");
                }
            }
        }

        private void bClear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            lineNumber = 0;
        }

        private void bReadAddress_Click(object sender, EventArgs e)
        {
            UInt16 a = irrx.readLastAddress();
            lAddress.Text = $"0x{a:X04}";
        }
    }
}
