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
            this.Text = $"Pin {pin} Queued Pulse Output {serialWombatChip.description}";
            queuedPulseOutputControl1.Name = $"Pin{pin}QueuedPulseOutput";
            queuedPulseOutputControl1.begin(serialWombatChip, pin);

        }
    }
}
