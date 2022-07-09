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

namespace SerialWombatWindowsFormsLibrary
{
    public partial class PulseOnChangeForm : Form
    {
        SerialWombatChip SerialWombatChip;
        Byte Pin;
        public PulseOnChangeForm(SerialWombatChip serialWombatChip, byte pin)
        {
            SerialWombatChip = serialWombatChip;
            Pin = pin;
            InitializeComponent();
            Text = $"Pin {pin} Pulse On Change";
            pulseOnChangeControl1.begin(serialWombatChip, pin);
        }

    }
}
