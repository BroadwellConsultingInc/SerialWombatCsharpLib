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
        UInt16 lastQueueAddress = 0;
        SerialWombatQueue queue;
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

        private void bInitializeQueue_Click(object sender, EventArgs e)
        {
            UInt16 length = 0;
            try
            {
                lastQueueAddress = Convert.ToUInt16(tbQueueAddress.Text);
                length = Convert.ToUInt16(tbQueueLength.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            queue = new SerialWombatQueue(ProcessedInput._sw);
            queue.begin(lastQueueAddress, length, SerialWombatQueueType.QUEUE_TYPE_RAM_BYTE);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProcessedInput.configureQueue(queue,(SerialWombatAbstractProcessedInput.Period) edQueueingPeriod.selectedItem, ckbQueueHighByte.Checked, ckbQueueLowByte.Checked);
        }

        private void bShowQueue_Click(object sender, EventArgs e)
        {
            QueueForm qf = new QueueForm(queue);
            
            qf.Show();
        }
    }
}
