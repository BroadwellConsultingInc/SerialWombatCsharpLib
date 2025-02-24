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

namespace SerialWombatWindowsFormsLibrary
{
    
    public partial class PIDControl : UserControl
    {
        public UInt16 lastTarget = 0;
        public SerialWombatAbstractScaledOutput ScaledOutput;
        public string PinName = "PIDControl";
        public PIDControl()
        {
            InitializeComponent();
            addConstantFloats();
            swpdcPIDTargetSource.DataSourceValue = 255;
        }

        public PIDControl(SerialWombatAbstractScaledOutput scaledOutput)
        {
            ScaledOutput = scaledOutput;
            InitializeComponent();
            addConstantFloats();
        }

        private void addConstantFloats()
        {
            sbsiKd.trackBarValueChangedDelegates.Add( (SixteenBitSliderInput.trackBarValueChangedDelegate)updateFloats);
            sbsiKi.trackBarValueChangedDelegates.Add((SixteenBitSliderInput.trackBarValueChangedDelegate)updateFloats);
            sbsiKp.trackBarValueChangedDelegates.Add((SixteenBitSliderInput.trackBarValueChangedDelegate)updateFloats);
        }
        void updateFloats(object sender, EventArgs e)
        {
            sbsiKd.Text = $"Kd {sbsiKd.value / 16384.0} ";
            sbsiKi.Text = $"Ki {sbsiKi.value / 16384.0} ";
            sbsiKp.Text = $"Kp {sbsiKp.value / 256.0} ";
        }
        private void bUpdateTargetCI_Click(object sender, EventArgs e)
        {
            ScaledOutput.writeScalingTargetValueResetIntegrator(sbsiPIDTarget.value);
            lastTarget = sbsiPIDTarget.value;
        }

        private void bPIDUpdateTarget_Click(object sender, EventArgs e)
        {
            ScaledOutput.writeScalingTargetValue(sbsiPIDTarget.value);
            lastTarget = sbsiPIDTarget.value;
        }

        private void bGenPIDCode_Click(object sender, EventArgs e)
        {
            addTextToClipboard(
               $@"//put this line in setup.
                    {PinName}.writePID({sbsiKp.value}, //Kp
                    {sbsiKi.value}, //Ki
                    {sbsiKd.value}, //Kd
                    {sbsiPIDTarget.value},  //Target Value
                    SerialWombatAbstractScaledOutput::Period::{(ScaledOutputPeriod)edPIDPeriod.selectedItem});//Period
");
        }

        private void addTextToClipboard(string text)
        {
            string s = "";
            if (Clipboard.ContainsText())
            {
                s = Clipboard.GetText();
            }
            s += text;
            Clipboard.SetText(s);
        }

        private void bConfigurePID_Click(object sender, EventArgs e)
        {
            ScaledOutput.writePID(sbsiKp.value, sbsiKi.value, sbsiKd.value, sbsiPIDTarget.value, (ScaledOutputPeriod)edPIDPeriod.selectedItem,
                swpdcPIDTargetSource.DataSourceValue, ckbBiDirectional.Checked);  
            lastTarget = sbsiPIDTarget.value;
        }

        private void bResetIntegrator_Click(object sender, EventArgs e)
        {
            ScaledOutput.PIDResetIntegrator();
        }

        private void bShowPIDGraphs_Click(object sender, EventArgs e)
        {
            PIDForm pf = new PIDForm();

            pf.setScaledOutput(ScaledOutput);
            pf.pinName = PinName;
            pf.Show();
        }
    }
}
