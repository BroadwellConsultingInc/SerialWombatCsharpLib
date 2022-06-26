using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using SerialWombat;
using ScottPlot;
using System.Windows.Forms;

namespace SerialWombatWindowsFormsLibrary
{
    public partial class PublicDataMonitorForm : Form
    {
        public byte Pin = 0;
        public SerialWombatChip SerialWombatChip;
        public PlottableSignal signalPlot;
        public double[] Raw16Data = new double[100000];
        UInt16 LastResult = 0;
        int datacount = 0;
        public PublicDataMonitorForm(SerialWombatChip serialWombatChip, byte pin)
        {
            InitializeComponent();
            SerialWombatChip = serialWombatChip;
            Pin = pin;
            signalPlot = formsPlot1.plt.PlotSignal(Raw16Data);
            Array array = Enum.GetValues(typeof(SerialWombatDataSources));
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


        private delegate void SafeCallDelegate();

        public void ReadRawDataAndPlot()
        {
            if (formsPlot1.InvokeRequired)
            {
                try
                {
                    var d = new SafeCallDelegate(ReadRawDataAndPlot);
                    formsPlot1.Invoke(d, new object[] { });
                }
                catch { }
            }
            try
            {
                {
                    

                    Pin = Convert.ToByte(tbDataId.Text);
                    LastResult = SerialWombatChip.readPublicData(Pin);

                }
                Raw16Data[datacount] = LastResult;
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

            }
            catch
            {
                //Fail silently
            }


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

                formsPlot1.Render();

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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = comboBox1.SelectedIndex;
            SerialWombatDataSources ds = (SerialWombatDataSources)comboBox1.Items[comboBox1.SelectedIndex];
            tbDataId.Text = ((byte)ds).ToString();
        }
    }
}
