using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using SerialWombat;
using static SerialWombat.SerialWombatAbstractProcessedInput;

namespace SerialWombatWindowsFormsLibrary.Controls
{
    public partial class QuadEncControl : UserControl
    {
        public SerialWombatQuadEnc_18AB quadEnc;
        public SerialWombatChip SerialWombatChip;
        public byte Pin;
        private delegate void SafeCallDelegate();
        private UInt16 lastFrequency = 0;
        public QuadEncControl()
        {
            InitializeComponent();
            eddAction.Value = 5;
        }


        public void begin(SerialWombatChip serialWombatChip, byte pin)
        {
            SerialWombatChip = serialWombatChip;
            Pin = pin;

            groupBox1.Text = $"Quad Enc on pin {pin}";
            if (serialWombatChip.ModelEnum == SerialWombatModel.SerialWombat18AB  || serialWombatChip.ModelEnum == SerialWombatModel.SerialWombat8B)
            {
                sbsiFreqPeriod.Enabled = true;
                sbsiIncrement.Enabled = true;
                sbsiHighLimit.Enabled = true;
                sbsiLowLimit.Enabled = true;
                bReadFrequency.Enabled = true;
                swpdTargetPin.Enabled = true;
                
            }
            swpdSecondPin.begin(serialWombatChip);
            swpdSecondPin.Pin = (byte)(pin + 1);
            swpdTargetPin.begin(serialWombatChip);
            swpdTargetPin.Pin = Pin;
            this.Name = $"Pin{pin}QuadEnc";

        }
        public void UpdateGraph()
        {
            if (realTimeScottPlot1.InvokeRequired)
            {
                var d = new SafeCallDelegate(UpdateGraph);
                realTimeScottPlot1.Invoke(d, new object[] { });
            }
            else
            {

                realTimeScottPlot1.PlotData(SerialWombatChip.readPublicData(Pin));
            }
        }

        void SampleThread()
        {
            while (ckbAutosample.Checked)
            {
                ReadRawDataAndPlot();
                Thread.Sleep(100);
            }
        }
        public void ReadRawDataAndPlot()
        {
            try
            {
                UpdateGraph();
            }
            catch
            {
                //Fail silently
            }


        }

        private void bSample_Click(object sender, EventArgs e)
        {
            ReadRawDataAndPlot();
        }

        private void bConfigure_Click(object sender, EventArgs e)
        {
            quadEnc = new SerialWombatQuadEnc_18AB(SerialWombatChip);
            quadEnc.begin(Pin, swpdSecondPin.Pin, sbsiDebounce.value,
                ckbPullUps.Checked,(QuadEncReadModes) eddAction.selectedItem);

            if (SerialWombatChip.isSW18()  || SerialWombatChip.isSW08())
            {
                quadEnc.writeMinMaxIncrementTargetPin(sbsiLowLimit.value,
                    sbsiHighLimit.value, sbsiIncrement.value, swpdTargetPin.Pin);
            }
        }

        private void bReadFrequency_Click(object sender, EventArgs e)
        {
            lastFrequency = quadEnc.readFrequency();
            updateFrequency();
        }
        private void updateFrequency()
        {
            if (lFrequency.InvokeRequired)
            {
                var d = new SafeCallDelegate(updateFrequency);
                realTimeScottPlot1.Invoke(d, new object[] { });
            }
            else
            {

                lFrequency.Text = lastFrequency.ToString();
            }

        }

        private void bWrite_Click(object sender, EventArgs e)
        {
            try
            {
                quadEnc.writePublicData(Convert.ToUInt16(tbValue.Text));
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bRead_Click(object sender, EventArgs e)
        {
            tbValue.Text = quadEnc.readPublicData().ToString();
        }

        public void End()
        {
            ckbAutosample.Checked = false;
        }

        private void ckbAutosample_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbAutosample.Checked)
            {
                Thread t = new Thread(SampleThread);
                t.Start();
                bRead.Enabled = false;
            }
            else
            {
                bRead.Enabled = true;
            }
        }

        private void bGenCode_Click(object sender, EventArgs e)
        {
            string type = "SerialWombatQuadEnc";
            if (quadEnc._sw.isSW18() || quadEnc._sw.isSW08())
            {
                type = "SerialWombatQuadEnc_18AB";
            }

            string s =
@$"
                //Put this line before setup()
                {type} {Name}(sw); // Your serial wombat chip may be named something else than sw
                //Add this line to  setup():
                {Name}.begin({Pin}, //1st Pin
                {swpdSecondPin.Pin}, //2nd Pin
                {sbsiDebounce.value}, //DebouceTime in mS
                {ckbPullUps.Checked}, //pull ups
                 QE_READ_MODE_t ::{eddAction.selectedItem.ToString()} //Mode
);
";
            if (quadEnc._sw.isSW18())
            {
                s += $@"
            {Name}.writeMinMaxIncrementTargetPin	(	{sbsiLowLimit.value},//Minimum, 65535 = ignore
{sbsiHighLimit.value},//Maximum, 0 = ignore
{sbsiIncrement.value}, //Increment
{swpdTargetPin.Pin} //Target Pin 
);		

{Name}.writeFrequencyPeriodmS	(	{sbsiFreqPeriod.value}	);// period in mS to count pulses to calculate frequency	

";
            }
            s = s.Replace("True", "true");
            s = s.Replace("False", "false");
            Clipboard.SetText(s);
        }
    }
}
