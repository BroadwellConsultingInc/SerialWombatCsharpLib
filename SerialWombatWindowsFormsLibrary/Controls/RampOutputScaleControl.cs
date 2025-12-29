using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SerialWombat;

namespace SerialWombatWindowsFormsLibrary
{
    public partial class RampOutputScaleControl : UserControl
    {
        public SerialWombatAbstractScaledOutput ScaledOutput;
        public string PinName = "RampControl";
        public RampOutputScaleControl(SerialWombatAbstractScaledOutput scaledOutput)
        {
            ScaledOutput = scaledOutput;
            InitializeComponent();
        }
        public RampOutputScaleControl()
        {
            InitializeComponent();
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

        private void bRampUpdateTarget_Click(object sender, EventArgs e)
        {
            ScaledOutput.writeScalingTargetValue(sbsiRampTarget.value);
        }


        private void bConfigurePID_Click(object sender, EventArgs e)
        {
            ScaledOutput.writeScalingTargetValue(sbsiRampTarget.value);
            ScaledOutput.writeRamp(sbsiSlowIncrement.value, sbsiIncrementThreshold.value, sbsiFastIncrement.value, (ScaledOutputRampMode)edRampMode.selectedItem, (ScaledOutputPeriod)edRampPeriod.selectedItem);

        }

        private void bGenRampCode_Click(object sender, EventArgs e)
        {
            addTextToClipboard(
             $@"//put this line in setup.
                    {PinName}.writeScalingTargetValue({sbsiRampTarget.value});
                    {PinName}.writeRamp({sbsiSlowIncrement.value}, //Slow Increment
                    {sbsiIncrementThreshold.value}, //Fast/slow threshold
                    {sbsiFastIncrement.value}, //Fast Increment
                    SerialWombatAbstractScaledOutput::Period::{(ScaledOutputPeriod)edRampPeriod.selectedItem},//Period
                    SerialWombatAbstractScaledOutput::RampMode::{(ScaledOutputRampMode)edRampMode.selectedItem}); // Ramp mode
");
        }
    }
}
