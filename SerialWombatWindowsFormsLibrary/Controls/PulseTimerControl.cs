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

namespace SerialWombatWindowsFormsLibrary.Controls
{
    public partial class PulseTimerControl : UserControl
    {
        public SerialWombatPulseTimer PulseTimer;
        public SerialWombatChip SerialWombatChip;
        public byte Pin;

        public UInt16 LastHighCounts = 0;
        public UInt16 LastLowCounts = 0;
        public UInt16 LastPulses = 0;
        public DateTime frequencyTimestamp = DateTime.Now;
        public UInt16 frequencyPulses = 0;
        public double LastFrequency = 0;
        public bool LastOverflow = false;

        private delegate void SafeCallDelegate();
        public PulseTimerControl()
        {
          
            InitializeComponent();
        
            
        }

        public void begin(SerialWombatChip serialWombatChip, byte pin)
        {
            SerialWombatChip = serialWombatChip;
            Pin = pin;
            groupBox1.Text = $"Pulse Timer Input on pin {pin}";
            enumDropdown1.Enabled = serialWombatChip.isSW18();
            if (serialWombatChip.isSW18())
            {
                PulseTimer = new SerialWombatPulseTimer_18AB(SerialWombatChip);
            }
            else
            {
                PulseTimer = new SerialWombatPulseTimer(serialWombatChip);
            }
            PulseTimer.begin(pin);
        }

        public void ReadRawDataAndPlot()
        {
            try
            {


                    LastHighCounts = PulseTimer.readHighCounts();
                    
                        PulseTimer.refreshHighCountsLowCounts();
                        LastLowCounts = PulseTimer.LowCounts;
                        LastHighCounts = PulseTimer.HighCounts;
                        PulseTimer.refreshHighCountsPulses();
                        LastPulses = PulseTimer.Pulses;
                        LastOverflow = PulseTimer.MeasurementOverflowOccurred;
                        DateTime sampletime = DateTime.Now;
                        TimeSpan SampleSpan = sampletime - frequencyTimestamp;
                        if (LastPulses > frequencyPulses)
                        {
                            if (SampleSpan.TotalSeconds > 3)
                            {
                                LastFrequency = (LastPulses - frequencyPulses) / SampleSpan.TotalSeconds;
                                frequencyPulses = LastPulses;
                                frequencyTimestamp = sampletime;
                            }
                        }
                        else
                        {
                            frequencyPulses = LastPulses;
                            frequencyTimestamp = sampletime;
                        }
              

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

                tbHighCounts.Text = LastHighCounts.ToString();
                tbLowCounts.Text = LastLowCounts.ToString();
                tbPulses.Text = LastPulses.ToString();
                if (!LastOverflow)
                {
                    lFrequency.Text = LastFrequency.ToString() + " Hz";
                }
                else
                {
                    lFrequency.Text = "Sampling Overflow";
                }
                lDutyCycle.Text = $"{LastHighCounts / ((double)LastHighCounts + LastLowCounts)} %";


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
                PulseTimer.begin(PulseTimer.Pin, ckbUseMs.Checked? SerialWombatPulseTimerUnits.SW_PULSETIMER_mS: SerialWombatPulseTimerUnits.SW_PULSETIMER_uS, ckbPullUp.Checked);
                if (SerialWombatChip.isSW18())
                {
                    ((SerialWombatPulseTimer_18AB)PulseTimer).configurePublicDataOutput((SerialWombatPulseTimerPublicData)enumDropdown1.selectedItem);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void End()
        {
            ckbAutosample.Checked = false;
        }

        private void bGenCode_Click(object sender, EventArgs e)
        {
            string pt = "SerialWombatPulseTimer";
            if (SerialWombatChip.isSW18())
            {

                pt = "SerialWombatPulseTimer_18AB";
            }
            string s = @$"
                //Put this line before setup()
                {pt} {Name}(sw); // Your serial wombat chip may be named something else than sw
                //Add this line to  setup():
                 {Name}.begin({PulseTimer.Pin},  //Pin
                            SerialWombatPulseTimerUnits.SW_PULSETIMER_uS, //Units
                            {ckbPullUp.Checked}); // Pull Up enabled
";
                if (SerialWombatChip.isSW18())
                {
                s += @$"{Name}.configurePublicDataOutput(SerialWombatPulseTimer_18AB::publicDataOutput::{(SerialWombatPulseTimerPublicData)enumDropdown1.selectedItem});
";
                }

            s = s.Replace("True", "true");
            s = s.Replace("False", "false");
            Clipboard.SetText(s);
        }
    }
}
