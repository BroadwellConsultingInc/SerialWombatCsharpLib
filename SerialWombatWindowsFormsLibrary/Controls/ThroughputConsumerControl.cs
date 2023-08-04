using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.Devices;
using SerialWombat;

namespace SerialWombatWindowsFormsLibrary.Controls
{
    public partial class ThroughputConsumerControl : UserControl
    {
        public SerialWombatThroughputConsumer tpConsumer;
        public byte Pin = 0;
        public SerialWombatChip SerialWombatChip;
        public ThroughputConsumerControl()
        {
            InitializeComponent();
            sixteenBitSliderInput1.trackBarValueChangedDelegates.Add(trackBar1_ValueChanged);
        }
        public void begin(SerialWombatChip serialWombatChip, byte pin)
        {
            Pin = pin;
            SerialWombatChip = serialWombatChip;
            tpConsumer = new SerialWombatThroughputConsumer(serialWombatChip);
            tpConsumer.begin(pin);
            groupBox1.Text = $"Throughput Consumer on pin {pin}";

        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
           
            tpConsumer.writeAll(sixteenBitSliderInput1.value);
        }
    }
}
