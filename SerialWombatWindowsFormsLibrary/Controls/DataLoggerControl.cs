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
using System.Diagnostics;

namespace SerialWombatWindowsFormsLibrary.Controls
{
    public partial class DataLoggerControl : UserControl
    {
        SerialWombat18ABDataLogger logger;
        List<Type> dataToLog = new List<Type> { };
        int bytesPerLogEntry = 0;
        public DataLoggerControl()
        {
            InitializeComponent();

        }
        public void begin(SerialWombatChip sw)
        {

            logger = new SerialWombat18ABDataLogger(sw);
            serialWombatPinDropdown1.begin(sw, 0);

        }

        private void ckbQueueOnChange_CheckedChanged(object sender, EventArgs e)
        {
            edQueueingPeriod.Enabled = !ckbQueueOnChange.Checked;
        }

        private void bInitialize_Click(object sender, EventArgs e)
        {
            dataToLog = new List<Type>();
            if (ckbQueueFrameNumber.Checked) { dataToLog.Add(typeof(UInt16)); bytesPerLogEntry += sizeof(UInt16); }
            logger.begin(sbacAddress.Value, sbacLen.Value, ckbQueueFrameNumber.Checked, ckbQueueOnChange.Checked, (DataLoggerPeriod)edQueueingPeriod.selectedItem);
            bAddPin.Enabled = true;
        }

        private void ckbQueueing_CheckedChanged(object sender, EventArgs e)
        {
            gbInitialization.Enabled = !ckbQueueing.Checked;
            logger.enable(ckbQueueing.Checked);
        }

        private void bAddPin_Click(object sender, EventArgs e)
        {
            logger.configurePin(serialWombatPinDropdown1.Pin, ckbLowByte.Checked, ckbQueueHighByte.Checked);
            if (ckbQueueHighByte.Checked && ckbLowByte.Checked)
            {
                dataToLog.Add(typeof(UInt16));
                bytesPerLogEntry += sizeof(UInt16);
            }
            else if (ckbQueueHighByte.Checked || ckbLowByte.Checked)
            {
                dataToLog.Add(typeof(byte));
                bytesPerLogEntry += sizeof(byte);
            }
        }

        private void bReadAll_Click(object sender, EventArgs e)
        {
            byte[] data;
            logger.queue.read(65535, out data);

            string s = "";
            for (int i = 0; i < data.Length;)
            {

                foreach (Type t in dataToLog)
                {
                    if (t == typeof(UInt16))
                    {
                        int dat = data[i] + data[i + 1] * 256;
                        s += $"{dat}, ";
                        i += 2;
                    }
                    else if (t == typeof(byte))
                    {
                        s += $"{data[i]}, ";
                        i += 1;
                    }
                }
                s += Environment.NewLine;

            }
            textBox1.AppendText(s);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s =
           @$"
                //Put this line before setup()
                SerialWombat18ABDataLogger {Name}(sw); // Your serial wombat chip may be named something else than sw
                //Add this to  setup():
                                {Name}.begin(
                                    {sbacAddress.Value},  // Index in User Memory
                                    {sbacLen.Value},  // Size of Queue
                                    {ckbQueueFrameNumber.Checked},  // Queue Frame number
                                    {ckbQueueOnChange.Checked},  // Queue on Change
                                    DataLoggerPeriod::{(DataLoggerPeriod)edQueueingPeriod.selectedItem} // Queue Period
                                );
                               
";

            s = s.Replace("True", "true");
            s = s.Replace("False", "false");
            Clipboard.SetText(s);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string s =
          @$"               
               {Name}.configurePin({serialWombatPinDropdown1.Pin}, // Pin
                                {ckbLowByte.Checked}, // Queue Low Byte
                                {ckbQueueHighByte.Checked} // Queue High Byte
                                );                               
";
            s = s.Replace("True", "true");
            s = s.Replace("False", "false");
            addTextToClipboard(s);
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

       

        private void button2_Click(object sender, EventArgs e)
        {

            string s =
          @$"
                
               {Name}.enable({ckbQueueing.Checked});                               
";
            s = s.Replace("True", "true");
            s = s.Replace("False", "false");
            addTextToClipboard(s);
        }
    }
}
