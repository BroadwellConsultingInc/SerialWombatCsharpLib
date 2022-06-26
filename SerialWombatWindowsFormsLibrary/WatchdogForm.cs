using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SerialWombatLib;
using SerialWombatLib.Watchdog;

namespace SerialWombatWindowsFormsLibrary
{
    public partial class WatchdogForm : Form
    {

        public SerialWombat SerialWombat { get; private set; }
        public byte Pin { get; private set; }

        public Watchdog Watchdog;
        public WatchdogForm(byte pin, SerialWombat serialWombat)
        {
            Pin = pin; SerialWombat = serialWombat;
            InitializeComponent();
            Text = $"Watchdog on Pin {Pin}";

        }

        private void ckbOverride_CheckedChanged(object sender, EventArgs e)
        {
            gbPins.Visible = ckbOverride.Checked;
        }

        private void bConfigure_Click(object sender, EventArgs e)
        {
            try
            {
                Watchdog = new Watchdog(Pin, SerialWombat, Convert.ToUInt16(tbTimeout.Text), cbNormalState.PinState,
                    cbTimeoutState.PinState, ckbReset.Checked, Convert.ToUInt16(tbTimeoutStateDuration.Text), ckbOverride.Checked,
                    cbP0.PinState, cbP1.PinState, cbP2.PinState, cbP3.PinState);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
