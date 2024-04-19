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

namespace SerialWombatWindowsFormsLibrary.Controls
{
    public partial class QueuedPulseOutputControl : UserControl
    {
        public SerialWombatChip SerialWombatChip;
        public byte Pin;
       SerialWombatQueuedPulseOutput qpo;
        public QueuedPulseOutputControl()
        {
            InitializeComponent();
        }
        public void begin(SerialWombatChip serialWombatChip, byte pin)
        {
            SerialWombatChip = serialWombatChip;
            Pin = pin;
            qpo = new SerialWombatQueuedPulseOutput(serialWombatChip);
            
            gbQueue.Text = $"Pin {Pin} Queued Pulse Output";
            Name = $"Pin{Pin}_QueuedPulseOutput";
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            tbEntries.Enabled = sbacIndex.Enabled = rbUserRam.Checked;
        }

        private void bConfigure_Click(object sender, EventArgs e)
        {
            UInt16 addr = 0xFFFF;
            if (rbUserRam.Checked)
            {
                addr = sbacIndex.Value;
            }
            qpo.begin(Pin, phliInit.Value == 1, phliIdle.Value == 1, rbms.Checked, addr);
            gbQueue.Text = $"Queued Pulse Output pin {Pin}";
            groupBox5.Enabled = true;
        }

        
        private void ckbPause_CheckedChanged(object sender, EventArgs e)
        {
            qpo.pause(ckbPause.Checked);
        }

        private void bQueue_Click(object sender, EventArgs e)
        {
            qpo.queuePulses((UInt16)(sbsi1st.value + (phli1st.Value * 32768)),
                (UInt16)(sbsi2nd.value + (phli2nd.Value * 32768)));
        }
    }
}
