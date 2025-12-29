using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using SerialWombat;
using ScottPlot;
using System.Windows.Forms;

namespace SerialWombatWindowsFormsLibrary
{
    public partial class PublicDataMonitorForm : Form
    {
        public byte Pin = 0;
        public SerialWombatChip SerialWombatChip;
        public List<SerialWombatDataSources> monitoredSources = new List<SerialWombatDataSources>();

        UInt16 LastResult = 0;

        public PublicDataMonitorForm(SerialWombatChip serialWombatChip, byte pin)
        {
            InitializeComponent();
            SerialWombatChip = serialWombatChip;
            Pin = pin;
            publicDataMonitorControl1.begin(serialWombatChip, pin);
            Text = serialWombatChip.description;


        }









        private void AnalogInputForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            publicDataMonitorControl1.end();
        }

        private void PublicDataMonitorForm_Resize(object sender, EventArgs e)
        {
           
        }
    }
}
