using SerialWombat;
using SerialWombatWindowsFormsLibrary.Controls;
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
using ScottPlot;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SerialWombatWindowsFormsLibrary
{
    public partial class PIDForm : Form
    {
        public double[] ErrorData = new double[100000];
        public double[] TargetData = new double[100000];
        public double[] InputData = new double[100000];
        public double[] EffortData = new double[100000];
        public double[] IntegratorData = new double[100000];
        public double[] IntegratorEffortData = new double[100000];
        public double[] ProportionalEffortData = new double[100000];
        public double[] DerivativeEffortData = new double[100000];


        int datacount = 0;
        public PlottableSignal signalPlotErrorData;
        public PlottableSignal signalPlotTargetData;
        public PlottableSignal signalPlotInputData;

        public PlottableSignal signalPlotEffortData;
        public PlottableSignal signalPlotIntegratorEffortData;
        public PlottableSignal signalPlotProportionalEffortData;
        public PlottableSignal signalPlotDerivativeEffortData;
        private delegate void SafeCallDelegate();

        public PIDForm()
        {
            InitializeComponent();
            signalPlotErrorData = formsPlot1.plt.PlotSignal(ErrorData);
           
            signalPlotEffortData = formsPlot2.plt.PlotSignal(EffortData);
            signalPlotProportionalEffortData = formsPlot2.plt.PlotSignal(ProportionalEffortData);
            signalPlotEffortData.color = Color.Blue;
            signalPlotProportionalEffortData.color = Color.Green;
            signalPlotIntegratorEffortData = formsPlot2.plt.PlotSignal(IntegratorEffortData);
            signalPlotIntegratorEffortData.color = Color.Yellow;
            signalPlotDerivativeEffortData = formsPlot2.plt.PlotSignal(DerivativeEffortData);
            signalPlotDerivativeEffortData.color = Color.Red;

            signalPlotTargetData = formsPlot3.plt.PlotSignal(TargetData);
            signalPlotTargetData.color = Color.Red;
            signalPlotInputData = formsPlot3.plt.PlotSignal(InputData);
            signalPlotInputData.color = Color.Blue;


        }
        public SerialWombatAbstractScaledOutput ScaledOutput;
        private void ckbAutoUpdate_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbAutoUpdate.Checked)
            {
                Thread t = new Thread(SampleThread);
                t.Start();


            }
            else
            {

            }
        }

        void SampleThread()
        {
            while (ckbAutoUpdate.Checked)
            {
                try
                {

                    if (ScaledOutput != null)
                    {
                        double error = ScaledOutput.PIDGetLastError();
                        double target = error;  //
                        double output = error;

                        double integrator = ScaledOutput.PIDGetLastIntegrator();
                        double integratorEffort = ScaledOutput.PIDGetLastIntegratorEffort();
                        double proportionalEffort = ScaledOutput.PIDGetLastProportionalEffort();
                        double derivativeEffort = ScaledOutput.PIDGetLastDerivativeEffort();
                        double Effort = ScaledOutput.PIDGetLastEffort();  //TODO when provided by SWC
                        /*
                        LastResult.PublicData = SerialWombatChip.readPublicData(AnalogInput.Pin);
                        LastResult.Averaged = AnalogInput.readAveragedCounts();
                        LastResult.Filtered = AnalogInput.readFilteredCounts();
                        LastResult.Maximum = AnalogInput.readMaximumCounts(false);
                        LastResult.Minimum = AnalogInput.readMinimumCounts(false);


                        if (ckbVolts.Checked)
                        {
                            realTimeScottPlot1.PlotData(LastResult.PublicData / 65535.0 * Vcc);
                        }
                        else
                        {
                            realTimeScottPlot1.PlotData(LastResult.PublicData);
                        }
                        */
                        PlotErrorData(error,ScaledOutput.ReadLastTarget(), Effort,ScaledOutput._sw.readPublicData(ScaledOutput.ScalingSourcePin),proportionalEffort,integratorEffort,derivativeEffort);
                    }
                }
                catch { }
                Thread.Sleep(10);


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

                formsPlot1.plt.AxisAuto();
                formsPlot1.Render();
            }
            if (formsPlot2.InvokeRequired)
            {
                var d = new SafeCallDelegate(UpdateGraph);
                formsPlot2.Invoke(d, new object[] { });
            }
            else
            {

                formsPlot2.plt.AxisAuto();
                formsPlot2.Render();
            }
            if (formsPlot3.InvokeRequired)
            {
                var d = new SafeCallDelegate(UpdateGraph);
                formsPlot3.Invoke(d, new object[] { });
            }
            else
            {

                formsPlot3.plt.AxisAuto();
                formsPlot3.Render();
            }

        }

        public void PlotErrorData(double error,double target, double effort, double input,
            double proportionalEffort, double integratorEffort,double derivativeEffort)
        {
            
            try
            {

                ErrorData[datacount] = error;
                TargetData[datacount] = target;
                EffortData[datacount] = effort;
                InputData[datacount] = input;
                ProportionalEffortData[datacount] = proportionalEffort;
                IntegratorEffortData[datacount] = integratorEffort;
                DerivativeEffortData[datacount] =   derivativeEffort;

                signalPlotErrorData.maxRenderIndex = datacount;
                signalPlotTargetData.maxRenderIndex = datacount;
                signalPlotInputData.maxRenderIndex = datacount;
                signalPlotEffortData.maxRenderIndex = datacount;
                signalPlotDerivativeEffortData.maxRenderIndex = datacount;
                signalPlotIntegratorEffortData.maxRenderIndex = datacount;
                signalPlotProportionalEffortData.maxRenderIndex = datacount;

                if (datacount > 100)
                {
                    signalPlotErrorData.minRenderIndex = datacount - 100;
                    signalPlotTargetData.minRenderIndex = datacount - 100;
                    signalPlotInputData.minRenderIndex = datacount - 100;
                    signalPlotEffortData.minRenderIndex = datacount - 100;
                    signalPlotIntegratorEffortData.minRenderIndex = datacount - 100;
                    signalPlotProportionalEffortData.minRenderIndex = datacount - 100;
                    signalPlotDerivativeEffortData.minRenderIndex = datacount - 100;
                }
                formsPlot1.plt.AxisAuto();
                ++datacount;




                UpdateGraph();
                if (datacount == 99999)
                {
                    datacount = 0;
                    signalPlotErrorData.minRenderIndex = 0;
                    signalPlotTargetData.minRenderIndex = 0;
                    signalPlotInputData.minRenderIndex = 0;
                    signalPlotEffortData.minRenderIndex = 0;
                    signalPlotDerivativeEffortData.minRenderIndex = 0;
                    signalPlotIntegratorEffortData.minRenderIndex = 0;
                    signalPlotProportionalEffortData.minRenderIndex= 0;
                }

            }
            catch
            {
                //Fail silently
            }

          
        }

        public void ClearData()
        {
            datacount = 0;
        }

        public void setScaledOutput(SerialWombatAbstractScaledOutput scaledOutput)
        {
            ScaledOutput = scaledOutput;
            pidControl1.ScaledOutput = scaledOutput;
            Text = $"PID on pin {scaledOutput.pin}";
        }
    }

}

