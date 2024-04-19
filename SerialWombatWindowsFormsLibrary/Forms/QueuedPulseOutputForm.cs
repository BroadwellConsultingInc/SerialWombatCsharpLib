using SerialWombat;
using SerialWombatWindowsFormsLibrary.Controls;
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
    public partial class QueuedPulseOutputForm : Form
    {

        public SerialWombatHBridge_18AB hBridge_18AB;
        public byte Pin = 0;
        public SerialWombatChip SerialWombatChip;
        public SerialWombatAbstractScaledOutput scaledOutput;
        public ScaledOutputControl scaledOutputControl;
        public QueuedPulseOutputForm(SerialWombatChip serialWombatChip, byte pin)
        {
            InitializeComponent();
            Pin = pin;
            SerialWombatChip = serialWombatChip;
            this.Text = $"Queued Pulse Output on pin {pin} on Serial Wombat Chip on {serialWombatChip.Serial.Port.PortName}";
            queuedPulseOutputControl1.Name = $"Pin{pin}HBridge";
            queuedPulseOutputControl1.begin(serialWombatChip, pin);

        }
    }
}
