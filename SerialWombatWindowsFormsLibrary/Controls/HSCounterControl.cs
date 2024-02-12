using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using SerialWombat;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace SerialWombatWindowsFormsLibrary.Controls
{
    public partial class HSCounterControl : UserControl
    {
        public SerialWombatHSCounter hscounter;
        public SerialWombatChip SerialWombatChip;
        public UInt16 lastPublicData = 0;
        public byte Pin;

        private delegate void SafeCallDelegate();
        public HSCounterControl()
        {
            InitializeComponent();
        }

        public void begin(SerialWombatChip serialWombatChip, byte pin)
        {
            SerialWombatChip = serialWombatChip;
            Pin = pin;
            groupBox1.Text = $"Pulse Timer Input on pin {pin}";

            hscounter = new SerialWombatHSCounter(serialWombatChip);

            hscounter.begin(pin,(SerialWombatHSCounterPublicData) enumDropdown1.selectedItem,sbsiFramesBetweenUpdates.value,sbsiPublicDataDivisor.value);
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

                lFreq.Text = hscounter.readFrequency().ToString();
                lCounts.Text = hscounter.readCounts().ToString(); 

            }
        }
        private void bSample_Click(object sender, EventArgs e)
        {
            ReadRawDataAndPlot();
        }



        void SampleThread()
        {
            while (ckbAutosample.Checked)
            {
                ReadRawDataAndPlot();
                Thread.Sleep(100);
            }
        }

        private void AnalogInputForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ckbAutosample.Checked = false;
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

        private void bConfigure_Click_1(object sender, EventArgs e)
        {
            try
            {
                hscounter.begin(Pin, (SerialWombatHSCounterPublicData)enumDropdown1.selectedItem, sbsiFramesBetweenUpdates.value, sbsiPublicDataDivisor.value);
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void End()
        {
            ckbAutosample.Checked = false;
            hscounter.disable();
        }

        private void bGenCode_Click(object sender, EventArgs e)
        {
            
            string s =
            @$"
                //Put this line before setup()
                SerialWombatHSCounter {Name}(sw); // Your serial wombat chip may be named something else than sw
                //Add this line to  setup():
                                {Name}.begin({Pin}, //Pin Number
                                SerialWombatHSCounter::publicDataOutput::{(SerialWombatHSCounterPublicData)enumDropdown1.selectedItem}, //Public Data Output
                                {sbsiFramesBetweenUpdates.value}, //Frames Between Updates
                                {sbsiPublicDataDivisor.value});//Public data divisor";


            Clipboard.SetText(s);
        }
    }
}

