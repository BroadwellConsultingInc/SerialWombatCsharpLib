using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScottPlot;

namespace SerialWombatWindowsFormsLibrary.Controls
{
    public partial class RealTimeScottPlot : UserControl
    {
        public double[] Raw16Data = new double[100000];
        int datacount = 0;
        public PlottableSignal signalPlot;

        private delegate void SafeCallDelegate();
        public RealTimeScottPlot()
        {
            InitializeComponent();
            signalPlot = formsPlot1.plt.PlotSignal(Raw16Data);
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
                /*
                if (ckbVolts.Checked)
                {
                    formsPlot1.plt.Axis(y1: 0, y2: Vcc);
                    formsPlot1.plt.AxisAutoX();
                    formsPlot1.plt.YLabel("Volts");
                }
                else*/
                {
                    formsPlot1.plt.AxisAuto();
                }
                formsPlot1.Render();
             
                formsPlot1.plt.YLabel("Counts / 65535");
            }
        }

        public void PlotData(double data)
        {
            try
            {

                Raw16Data[datacount] = data;
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
    }
}
