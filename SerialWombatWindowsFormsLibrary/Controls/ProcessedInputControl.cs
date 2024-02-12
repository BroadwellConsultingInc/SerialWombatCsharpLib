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

        private void bIntegratorConfigure_Click(object sender, EventArgs e)
        {
            ProcessedInput.configureIntegrator(sbsiIntegratorNegMaxIndex.value,
                sbsiNegMidIndex.value,
                sbsiNegDeadZone.value,
                sbsiPosDeadZone.value,
                sbsiPosMidIndex.value,
                sbsiPosMaxIndex.value,
                sbsiMidIncrement.value,
                sbsiMaxIncrement.value,
                sbsiIntegratorInitialValue.value
                );
        }

        private void bIntegratorGenArduino_Click(object sender, EventArgs e)
        {
            addTextToClipboard(
                $@"//put this line in setup.  
                    {Name}.configureIntegrator({sbsiIntegratorNegMaxIndex.value}, //  Negative Max Index
                {sbsiNegMidIndex.value},//Negative Mid Index
                {sbsiNegDeadZone.value},//Negative Dead Zone
                {sbsiPosDeadZone.value}, //Positive Dead Zone
                {sbsiPosMidIndex.value}, // Positive Mid Index
                {sbsiPosMaxIndex.value}, //  Positve Max index
                {sbsiMidIncrement.value}, // Mid Increment
                {sbsiMaxIncrement.value}, // Max Increment
                {sbsiIntegratorInitialValue.value} // Initial Value
                );
");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            addTextToClipboard(
                $@"//put this line in setup.  
                    {Name}.writeAveragingNumberOfSamples({sbsiAveragedSamples.value});
");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            addTextToClipboard(
                $@"//put this line in setup.  
                    {Name}.writeTransformLinearMXB({(Int32)(Convert.ToDouble(tbM.Text) * 256)}, // m in 1/256ths
                {Convert.ToInt32(tbB.Text)});
"); // b
        }

        private void button4_Click(object sender, EventArgs e)
        {
            addTextToClipboard(
                $@"//put this line in setup.  
                    {Name}.writeTransformScaleRange({sbsiInputScaleMin.value}, //Min
                {sbsiInputScaleMax.value});
"); // Max
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

        private void button5_Click(object sender, EventArgs e)
        {
            string s = $@"//put this line in setup.  This should be the last of Processed Input Commands for this pin
                    {Name}.configureOutputValue((ProcessedInputOutputValue)edPublicOutput.selectedItem);
            {{Name}}.writeProcessedInputEnable(ckbEnabled.Checked);
";
            s = s.Replace("True", "true");
            s = s.Replace("False", "false");

            addTextToClipboard(s);
                 


        }

        private void bGenOutlierCode_Click(object sender, EventArgs e)
        {
            addTextToClipboard($@"//put this line in setup. 
{Name}.writeExcludeBelowAbove({sbsiExcludeBelow.value}, //Low limit
                {sbsiExcludeAbove.value});//High limit
");
        }

        private void bGenInversionCode_Click(object sender, EventArgs e)
        {
            string s = $@"//put this line in setup. 
                    {Name}.writeInverted({ckbInverted.Checked});
";
            s = s.Replace("True", "true");
            s = s.Replace("False", "false");

            addTextToClipboard(s);
        }

        private void bGenQueueCode_Click(object sender, EventArgs e)
        {
            UInt16 queueAddress;
            UInt16 length;
            try
            {
                {
                    queueAddress = Convert.ToUInt16(tbQueueAddress.Text);
                    length = Convert.ToUInt16(tbQueueLength.Text);
                }
            }
            catch (Exception ex)
            {
                {
                    MessageBox.Show(ex.Message, "Error");
                    return;
                }
            }

            string s = $@" // Put this line above setup:
                SerialWombatQueue {Name}Queue(sw);
            //put this line in setup. 
            {Name}Queue.begin({queueAddress}, //Queue Address
                {length}, // Length
                 SerialWombatQueueType::QUEUE_TYPE_RAM_BYTE);

                {Name}.configureQueue(&{Name}Queue,
                    SerialWombatAbstractProcessedInput::Period::{(SerialWombatAbstractProcessedInput.Period)edQueueingPeriod.selectedItem}, //Queueing Sample Period
                    {ckbQueueHighByte.Checked}, //Queue High Byte
                    {ckbQueueLowByte.Checked}); //Queue Low byte
";
            s = s.Replace("True", "true");
            s = s.Replace("False", "false");

            addTextToClipboard(s);

        }
    }
}
