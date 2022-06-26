using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using SerialWombat;


namespace SerialWombatWindowsFormsLibrary
{
    public partial class DebounceForm : Form
    {
        public SerialWombatDebouncedInput DebouncedInput;
        SerialWombatChip _serialWombat;
        byte _pin;
        UInt16 LastTransitions = 0;
        UInt16 LastStableTime = 0;
        SerialWombatPinStates LastState = SerialWombatPinStates.SW_INPUT;
     
        private delegate void SafeCallDelegate();
        public DebounceForm(SerialWombatChip serialWombat, byte pin)
        {
            InitializeComponent();
            _serialWombat = serialWombat;
            _pin = pin;
            Text = $"Debounce on pin {pin}, {_serialWombat}";


        }

        private void bConfigure_Click(object sender, EventArgs e)
        {
            try
            {
                DebouncedInput = new SerialWombatDebouncedInput(_serialWombat);
                DebouncedInput.begin( _pin, Convert.ToByte(textBox1.Text), ckbInvert.Checked ,ckbPullUp.Checked );
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UpdateForm()
        {
            if (lActive.InvokeRequired)
            {
                var d = new SafeCallDelegate(UpdateForm);
                lActive.Invoke(d, new object[] { });
            }
            else
            {
                lActive.Text = LastState.ToString();
                lStableTime.Text = LastStableTime.ToString() + " mS";
                lTransitions.Text = LastTransitions.ToString();
            }
        }

        void refresh()
        {
            DebouncedInput.readTransitionsState();
            LastState = DebouncedInput.digitalRead() ? SerialWombatPinStates.SW_HIGH:SerialWombatPinStates.SW_LOW;
            if (LastState == SerialWombatPinStates.SW_HIGH)
            {
                LastStableTime = DebouncedInput.readDurationInTrueState_mS();
            }
            else
            {
                LastStableTime = DebouncedInput.readDurationInFalseState_mS();
            }
            
            LastTransitions = DebouncedInput.transitions;
            UpdateForm();
        }

        void refreshThread()
        {
            while (ckbAuto.Checked)
            {
                refresh();
                Thread.Sleep(100);
            }
        }
        private void bRefresh_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void ckbAuto_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbAuto.Checked)
            {
                Thread t = new Thread(refreshThread);
                t.Start();
                bRefresh.Enabled = false;
            }
            else 
            { 
                bRefresh.Enabled = true; 
            }
        }

        private void DebounceForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ckbAuto.Checked = false;
        }
    }
}
