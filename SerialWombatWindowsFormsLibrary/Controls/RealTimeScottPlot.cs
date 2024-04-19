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
using SerialWombat;

namespace SerialWombatWindowsFormsLibrary.Controls
{
    public partial class RealTimeScottPlot : UserControl
    {
        public List<double[]> Raw16Data = new List<double[]>();

        int datacount = 0;
        public List< PlottableSignal> signalPlot = new List<PlottableSignal>();

        private delegate void SafeCallDelegate();
        public RealTimeScottPlot()
        {
            InitializeComponent();

            Raw16Data.Add( new double[100000]);
            for (int i = 0; i < 100000; ++i)
            {
                Raw16Data[0][i] = 1000;
            }
            signalPlot.Add( formsPlot1.plt.PlotSignal(Raw16Data[0]));
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
                try
                {
                    {
                    formsPlot1.plt.AxisAuto();
                    }
                
                    formsPlot1.Render();
                }
                catch { }
             
                //TODO formsPlot1.plt.YLabel("Counts / 65535");
            }
        }

        public void PlotData(double data, int index = 0)
        {
            
                if (ckbPct.Checked)
                {
                    data /= 655.36;
                }
                else
                {
                    try { data = data * Convert.ToDouble(tbM.Text) + Convert.ToDouble(tbB.Text); } 
                    catch { }
                }
                
                Raw16Data[index][datacount] = data;

                signalPlot[index].maxRenderIndex = datacount;
                if (datacount > 100)
                {
                    signalPlot[index].minRenderIndex = datacount - 100;
                }
            if (index == signalPlot.Count - 1)
            {
                ++datacount;
            }

            try
            {
                formsPlot1.plt.AxisAuto();
             



                UpdateGraph();

            }
            catch
            {
                //Fail silently
            }
                if (datacount == 99999)
                {
                    datacount = 0;
                    signalPlot[index].minRenderIndex = 0;
                }


        }

        public void ClearData()
        {
            
                datacount = 0;
        
        }

        public void addPlot()
        {
            Raw16Data.Add(new double[100000]);
            signalPlot.Add(formsPlot1.plt.PlotSignal(Raw16Data[Raw16Data.Count - 1]));
        }
    }
}
