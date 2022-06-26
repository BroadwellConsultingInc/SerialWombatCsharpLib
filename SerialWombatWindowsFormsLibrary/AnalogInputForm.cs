using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using SerialWombat;
using ScottPlot;


namespace SerialWombatWindowsFormsLibrary
{
    public partial class AnalogInputForm : Form
    {
        public SerialWombatAnalogInput AnalogInput;
        public byte Pin = 0;
        public SerialWombatChip SerialWombatChip;
        public double[] Raw16Data = new double[100000];
        int datacount = 0;
        public PlottableSignal  signalPlot;
        double Vcc = 3.3;
        AnalogInputResult LastResult = new AnalogInputResult();
        
        private delegate void SafeCallDelegate();
        public AnalogInputForm(SerialWombatChip serialWombatChip, byte pin)
        {
            InitializeComponent();
            Pin = pin;
            SerialWombatChip = serialWombatChip;
            groupBox1.Text = "";
            Text = $"Analog Input on pin {pin}";
           
            signalPlot = formsPlot1.plt.PlotSignal(Raw16Data);

        }

        public UInt16 ReadRawDataAndPlot()
        {
            try
            {
                {
                    LastResult.PublicData = SerialWombatChip.readPublicData(AnalogInput.Pin);
                    LastResult.Averaged = AnalogInput.readAveragedCounts();
                    LastResult.Filtered = AnalogInput.readFilteredCounts();
                    LastResult.Maximum = AnalogInput.readMaximumCounts(false);
                    LastResult.Minimum = AnalogInput.readMinimumCounts(false);

                  
                    if (ckbVolts.Checked)
                    {
                        Raw16Data[datacount] = LastResult.PublicData / 65535.0 * Vcc;
                    }
                    else
                    {
                        Raw16Data[datacount] = LastResult.PublicData;
                    }
                }
                signalPlot.maxRenderIndex = datacount;
                if (datacount > 100)
                {
                    signalPlot.minRenderIndex = datacount - 100;
                }
                formsPlot1.plt.AxisAuto();
                ++datacount;

                


                UpdateGraph();
                if (datacount == 99999)
                {
                    datacount = 0;
                    signalPlot.minRenderIndex = 0;
                }
                return (LastResult.PublicData);
            }
            catch
            {
                //Fail silently
            }
            return (0);
            
        }

        public void UpdateGraph()
        {
            if (formsPlot1.InvokeRequired)
            {
                var d = new SafeCallDelegate(UpdateGraph);
                formsPlot1.Invoke(d, new object[] {  });
            }
            else
            {
                if (ckbVolts.Checked)
                {
                    formsPlot1.plt.Axis(y1: 0, y2: Vcc);
                    formsPlot1.plt.AxisAutoX();
                    formsPlot1.plt.YLabel("Volts");
                }
                else
                {
                    formsPlot1.plt.AxisAuto();
                }
                formsPlot1.Render();
                tbAveraged.Text = LastResult.Averaged.ToString();
                tbFiltered.Text = LastResult.Filtered.ToString();
                tbMax.Text = LastResult.Maximum.ToString();
                tbMin.Text = LastResult.Minimum.ToString();
                formsPlot1.plt.YLabel("Counts / 65535");
            }
        }

        private void bSample_Click(object sender, EventArgs e)
        {
            ReadRawDataAndPlot();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
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

        private void AnalogInputForm_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }

        private void bConfigure_Click(object sender, EventArgs e)
        {
            try
            {
                // AnalogInput = new AnalogInput(Pin, SerialWombatChip,Pin, (AnalogInPublicDataSelection)comboBox1.SelectedIndex, Convert.ToUInt16(tbFilterConstant.Text), Convert.ToUInt16(tbAverage.Text)); 
                AnalogInput = new SerialWombatAnalogInput(SerialWombatChip);
                AnalogInput.begin(Pin, Convert.ToUInt16(tbAverage.Text), Convert.ToUInt16(tbFilterConstant.Text), (AnalogInputPublicDataOutput)comboBox1.SelectedIndex);
             }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void ckbVolts_CheckedChanged(object sender, EventArgs e)
        { /*
            if (ckbVolts.Checked)
            {
               
                WombatSupplyVoltagePacket wsvp = new WombatSupplyVoltagePacket();
                WombatSupplyVoltagePacket response = (WombatSupplyVoltagePacket)SerialWombat.Send(wsvp);
                Vcc = response.SupplyVoltage;
                ckbVolts.Text = $"Volts (Vcc = {Vcc})";
                for (int i = 0; i < Raw16Data.Length; ++ i)
                {
                    Raw16Data[i] = Raw16Data[i] / 65535.0 * Vcc;
                }
            }
            else
            {
                ckbVolts.Text = "Volts";
                for (int i = 0; i < Raw16Data.Length; ++i)
                {
                    Raw16Data[i] = Raw16Data[i] * 65535.0 / Vcc;
                }
            }
        */

        }
    }

    public class AnalogInputResult
    {
        public UInt16 Minimum;
        public UInt16 Maximum;
        public UInt16 PublicData;
        public UInt16 Filtered;
        public UInt16 Averaged;

        public AnalogInputResult() { }
        public AnalogInputResult(UInt16 minimum, UInt16 maximum, UInt16 publicdata, UInt16 filtered, UInt16 averaged)
        { Minimum = minimum; Maximum = maximum; PublicData = publicdata; Filtered = filtered; Averaged = averaged; }
    }
}
