using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using ScottPlot;
using SerialWombat;

namespace SerialWombatWindowsFormsLibrary
{
    public partial class PulseTimerForm : Form
    {

       
        public SerialWombatPulseTimer PulseTimer;
        public SerialWombatChip SerialWombatChip;
        public double[] Raw16Data = new double[100000];
        int datacount = 0;
        public PlottableSignal signalPlot;

        public UInt16 LastHighCounts = 0;
        public UInt16 LastLowCounts = 0;
        public UInt16 LastPulses = 0;
        public DateTime frequencyTimestamp = DateTime.Now;
        public UInt16 frequencyPulses = 0;
        public double LastFrequency = 0;
        public bool LastOverflow = false;

        private delegate void SafeCallDelegate();

        public PulseTimerForm(SerialWombatChip serialWombatChip, byte pin)
        {
            InitializeComponent();
            PulseTimer = new SerialWombatPulseTimer(serialWombatChip);
            PulseTimer.begin(pin, SerialWombatPulseTimerUnits.SW_PULSETIMER_uS,false);
            SerialWombatChip = serialWombatChip;
            groupBox1.Text = "";
            Text = $"Pulse Timer Input on pin {pin}";

            signalPlot = formsPlot1.plt.PlotSignal(Raw16Data);

            comboBox1.Enabled = serialWombatChip.isSW18();
            Array array = Enum.GetValues(typeof(SerialWombatPulseTimerPublicData));
            comboBox1.DataSource = array;
            int i = 0;
            foreach (SerialWombatDataSources s in comboBox1.Items)
            {
                if (s == ((SerialWombatDataSources)pin))
                {
                    comboBox1.SelectedIndex = i;
                    break;
                }
                ++i;
            }

       

        }
        public UInt16 ReadRawDataAndPlot()
        {
            try
            {
             
                {

                    LastHighCounts = PulseTimer.readHighCounts();
                    Raw16Data[datacount] = LastHighCounts;
                }
                signalPlot.maxRenderIndex = datacount;
                if (datacount > 100)
                {
                    signalPlot.minRenderIndex = datacount - 100;
                }
                formsPlot1.plt.AxisAuto();
                ++datacount;

               
                if (ckbAllValues.Checked)
                {
                    {
                        PulseTimer.refreshHighCountsLowCounts();
                        LastLowCounts = PulseTimer.LowCounts;
                        LastHighCounts = PulseTimer.HighCounts;
                    }
                    {
                        PulseTimer.refreshHighCountsPulses();
                        LastPulses = PulseTimer.Pulses;
                        LastOverflow = PulseTimer.MeasurementOverflowOccurred;
                        DateTime sampletime = DateTime.Now;
                        TimeSpan SampleSpan = sampletime - frequencyTimestamp;
                        if (LastPulses > frequencyPulses)
                        {
                            if (SampleSpan.TotalSeconds > 3 )
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
                    }
                }

                UpdateGraph();
                if (datacount == 99999)
                {
                    datacount = 0;
                    signalPlot.minRenderIndex = 0;
                }
                return (LastHighCounts);
            }
            catch 
            {
                //Fail silently
            }
            return (LastHighCounts);

        }

        public void UpdateGraph()
        {
            if (formsPlot1.InvokeRequired)
            {
                var d = new SafeCallDelegate(UpdateGraph);
                formsPlot1.Invoke(d, new object[] { });
            }
            else
            {
                formsPlot1.plt.AxisAuto();
                formsPlot1.Render();
               
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
                PulseTimer.begin(PulseTimer.Pin, SerialWombatPulseTimerUnits.SW_PULSETIMER_uS,false);
                if (SerialWombatChip.isSW18())
                {
                    PulseTimer.configurePublicDataOutput((SerialWombatPulseTimerPublicData)comboBox1.SelectedIndex);
                }    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PulseTimerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ckbAutosample.Checked = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            PulseTimer.configurePublicDataOutput((SerialWombatPulseTimerPublicData)comboBox1.SelectedIndex);
        }
    }
}
