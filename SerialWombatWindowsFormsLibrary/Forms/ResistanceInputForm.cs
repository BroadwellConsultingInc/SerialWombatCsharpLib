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
    public partial class ResistanceInputForm : Form
    {
        public SerialWombatResistanceInput ResistanceInput;
        public byte Pin = 0;
        public SerialWombatChip SerialWombatChip;
        public double[] Raw16Data = new double[100000];
        int datacount = 0;
        public PlottableSignal signalPlot;
        double Vcc = 3.3;
        AnalogInputResult LastResult = new AnalogInputResult();

        private delegate void SafeCallDelegate();
        public ResistanceInputForm(SerialWombatChip serialWombatChip, byte pin)
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
                    LastResult.PublicData = SerialWombatChip.readPublicData(ResistanceInput.Pin);
                    LastResult.Averaged = ResistanceInput.readAveragedOhms();
                    LastResult.Filtered = ResistanceInput.readFilteredCounts();
                    LastResult.Maximum = ResistanceInput.readMaximumOhms(false);
                    LastResult.Minimum = ResistanceInput.readMinimumCounts(false);


                  
                        Raw16Data[datacount] = LastResult.PublicData;
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
                formsPlot1.Invoke(d, new object[] { });
            }
            else
            {
               
                    formsPlot1.plt.AxisAuto();
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
                ResistanceInput = new SerialWombatResistanceInput(SerialWombatChip);
                ResistanceInput.begin(Pin, Convert.ToUInt16(tbAverage.Text), Convert.ToUInt16(tbFilterConstant.Text), (ResistanceInputPublicDataOutput)comboBox1.SelectedIndex);
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
}
