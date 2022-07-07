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
    public partial class ProcessedInputControl : UserControl
    {
        SerialWombatAbstractProcessedInput ProcessedInput;
        public ProcessedInputControl(SerialWombatAbstractProcessedInput processedInput)
        {
            InitializeComponent();
            ProcessedInput = processedInput; 
        }

        private void bExcludeBelowAbove_Click(object sender, EventArgs e)
        {
            ProcessedInput.writeExcludeBelowAbove(sbsiExcludeBelow.value, sbsiExcludeAbove.value);
        }

        private void bConfigureInverted_Click(object sender, EventArgs e)
        {
            ProcessedInput.writeInverted(ckbInverted.Checked);
        }

        private void bConfigure_Click(object sender, EventArgs e)
        {
            ProcessedInput.writeTransformScaleRange(sbsiInputScaleMin.value, sbsiInputScaleMax.value);
        }

        private void bConfigureMXB_Click(object sender, EventArgs e)
        {
            ProcessedInput.writeTransformLinearMXB((Int32)(Convert.ToDouble(tbM.Text) * 256) , Convert.ToInt32(tbB.Text));
        }

        private void ckbEnabled_CheckedChanged(object sender, EventArgs e)
        {
            ProcessedInput.configureOutputValue((ProcessedInputOutputValue) edPublicOutput.selectedItem);
            ProcessedInput.writeProcessedInputEnable(ckbEnabled.Checked);
        }

        private void bSetAveragedSamples_Click(object sender, EventArgs e)
        {
            ProcessedInput.writeAveragingNumberOfSamples(sbsiAveragedSamples.value);
        }

        private void bSetFilterConstant_Click(object sender, EventArgs e)
        {
            ProcessedInput.writeFirstOrderFilteringConstant(sbsiFilterConstant.value);
        }
            
        private void bReadMinMax_Click(object sender, EventArgs e)
        {
            UInt16 min = ProcessedInput.readMinimum(false);
            UInt16 max = ProcessedInput.readMaximum(ckbResetMinMax.Checked);

            lMaximum.Text = max.ToString();
            lMinimum.Text = min.ToString();
        }
    }
}
