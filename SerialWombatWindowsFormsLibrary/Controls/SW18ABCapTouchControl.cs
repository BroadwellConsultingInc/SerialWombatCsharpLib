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
using System.Threading;

namespace SerialWombatWindowsFormsLibrary.Controls
{
    public partial class SW18ABCapTouchControl : UserControl
    {
        SerialWombatChip SerialWombatChip;
        byte Pin;
        SerialWombat18CapTouch capTouch;

        UInt16 LastPublicData = 0;
        private delegate void SafeCallDelegate();

        public SW18ABCapTouchControl()
        {
            InitializeComponent();
        }

        public void begin(SerialWombatChip serialWombatChip, byte pin)
        {
            SerialWombatChip = serialWombatChip;
            Pin = pin;
            capTouch = new SerialWombat18CapTouch(serialWombatChip);
            groupBox1.Text = "Pin {pin} CapTouch";
        }

        private void bConfigure_Click(object sender, EventArgs e)
        {
            capTouch.begin(Pin, sbsiChargeTime.value);
        }

        public void end()
        {
            ckbAutosample.Checked = false;
        }

        private void bSample_Click(object sender, EventArgs e)
        {
            LastPublicData = capTouch.readPublicData();
            realTimeScottPlot1.PlotData(LastPublicData);

        }

        private void ckbAutosample_CheckedChanged(object sender, EventArgs e)
        {

            if (ckbAutosample.Checked)
            {
                Thread t = new Thread(SampleThread);
                t.Start();
                bSample.Enabled = false;

            }
            else
            {
                bSample.Enabled = true;
            }
        }

        void SampleThread()
        {
            while (ckbAutosample.Checked)
            {
                LastPublicData = capTouch.readPublicData();
                realTimeScottPlot1.PlotData(LastPublicData);
               
                Thread.Sleep(100);


            }


        }
    }
}
