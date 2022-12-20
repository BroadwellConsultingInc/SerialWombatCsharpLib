using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SerialWombat;

namespace SerialWombatWindowsFormsLibrary
{
    public partial class ScaledOutputControl : UserControl
    {

        public SerialWombatAbstractScaledOutput ScaledOutput;

        public ScaledOutputControl(SerialWombatAbstractScaledOutput scaledOutput)
        {
            InitializeComponent();
            ScaledOutput = scaledOutput;
            swpdsInput.DataSourceValue = scaledOutput.pin;
        }

        private void ckbScaledOutputEnable_CheckedChanged(object sender, EventArgs e)
        {
            ScaledOutput.writeScalingEnabled(ckbScaledOutputEnable.Checked, (byte)swpdsInput.DataSourceValue);
        }

        private void bConfigureInputScaling_Click(object sender, EventArgs e)
        {
            ScaledOutput.writeInputScaling(sbsiInputMin.value, sbsiInputMax.value);
        }

        private void bConfigurePID_Click(object sender, EventArgs e)
        {
            ScaledOutput.writePID(sbsiKp.value, sbsiKi.value, sbsiKd.value, sbsiPIDTarget.value, (ScaledOutputPeriod)edPIDPeriod.selectedItem);
        }

        private void bConfigureHysteresis_Click(object sender, EventArgs e)
        {
            ScaledOutput.writeHysteresis(sbsiHysLowLimit.value, sbsiHysLowOutput.value, sbsiHysHighLimit.value, sbsiHysHighOutputValue.value, sbsiHysInitialOutputValue.value);
        }

        private void bConfigureTimeout_Click(object sender, EventArgs e)
        {
            ScaledOutput.writeTimeout(sbsiTimeout_mS.value, sbsiTimeoutOutputValue.value);
        }

        private void bConfigureFiltering_Click(object sender, EventArgs e)
        {
            ScaledOutput.write1stOrderFiltering((ScaledOutputPeriod)edFilteringPeriod.selectedItem, sbsiFilterConstant.value);
        }

        private void bConfigureMaximumRate_Click(object sender, EventArgs e)
        {
            ScaledOutput.writeRateControl((ScaledOutputPeriod)edFilteringPeriod.selectedItem, sbsiFilterConstant.value);

        }

        private void bConfigureOutputScaling_Click(object sender, EventArgs e)
        {
            ScaledOutput.writeOutputScaling(sbsiOutputScalingMin.value, sbsiOutputScalingMax.value);
        }

        private void bWriteTarget_Click(object sender, EventArgs e)
        {
            ScaledOutput.writeScalingTargetValue(sbsiFilterTarget.value);
        }

        private void ckbInvert_CheckedChanged(object sender, EventArgs e)
        {
            ScaledOutput.writeScalingInvertedInput(ckbInvert.Checked);
        }
    }
}
