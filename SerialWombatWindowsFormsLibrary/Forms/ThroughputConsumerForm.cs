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
using SerialWombat;
using SerialWombatWindowsFormsLibrary.Controls;

namespace SerialWombatWindowsFormsLibrary.Forms
{

    public partial class ThroughputConsumerForm : Form
    {
        public SerialWombatChip SerialWombatChip;
        public ThroughputConsumerForm(SerialWombatChip serialWombatChip, byte pin)
        {
            InitializeComponent();
            SerialWombatChip = serialWombatChip;
            Text = $"Throughput Consumer on Pin {pin}";
            throughputConsumerControl1.begin(SerialWombatChip, pin);
        }
    }
}
