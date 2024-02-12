using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SerialWombat;

namespace SerialWombatWindowsFormsLibrary
{
    public partial class ScaledOutputControl : UserControl
    {

        public SerialWombatAbstractScaledOutput ScaledOutput;

        public ScaledOutputControl(SerialWombatAbstractScaledOutput scaledOutput)
        {
            InitializeComponent();
            ScaledOutput = scaledOutput;
            pidControl1.ScaledOutput= scaledOutput;
            swpdsInput.DataSourceValue = scaledOutput.pin;
            Name = "ChangeMe_SomeScaledOutputInstance";
       
        }

        private void ckbScaledOutputEnable_CheckedChanged(object sender, EventArgs e)
        {
            ScaledOutput.writeScalingEnabled(ckbScaledOutputEnable.Checked, (byte)swpdsInput.DataSourceValue);
        }

        private void bConfigureInputScaling_Click(object sender, EventArgs e)
        {
            ScaledOutput.writeInputScaling(sbsiInputMin.value, sbsiInputMax.value);
        }

        private void bConfigurePID_Click(object sender, EventArgs e)
        {
            ScaledOutput.writePID(sbsiKp.value, sbsiKi.value, sbsiKd.value, sbsiPIDTarget.value, (ScaledOutputPeriod)edPIDPeriod.selectedItem);
        }

        private void bConfigureHysteresis_Click(object sender, EventArgs e)
        {
            ScaledOutput.writeHysteresis(sbsiHysLowLimit.value, sbsiHysLowOutput.value, sbsiHysHighLimit.value, sbsiHysHighOutputValue.value, sbsiHysInitialOutputValue.value);
        }

        private void bConfigureTimeout_Click(object sender, EventArgs e)
        {
            ScaledOutput.writeTimeout(sbsiTimeout_mS.value, sbsiTimeoutOutputValue.value);
        }

        private void bConfigureFiltering_Click(object sender, EventArgs e)
        {
            ScaledOutput.write1stOrderFiltering((ScaledOutputPeriod)edFilteringPeriod.selectedItem, sbsiFilterConstant.value);
        }

        private void bConfigureMaximumRate_Click(object sender, EventArgs e)
        {
            ScaledOutput.writeRateControl((ScaledOutputPeriod)edFilteringPeriod.selectedItem, sbsiMaxChangeUp.value, sbsiFilterConstant2.value);

        }

        private void bConfigureOutputScaling_Click(object sender, EventArgs e)
        {
            ScaledOutput.writeOutputScaling(sbsiOutputScalingMin.value, sbsiOutputScalingMax.value);
        }

     

        private void ckbInvert_CheckedChanged(object sender, EventArgs e)
        {
            ScaledOutput.writeScalingInvertedInput(ckbInvert.Checked);
        }

        private void sbsiFilterTarget_Load(object sender, EventArgs e)
        {

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
        private void button4_Click(object sender, EventArgs e)
        {
            addTextToClipboard(
                $@"//put this line in setup.  Make this the last line after other
                    // Output Scaling configurations for this pin
                    {Name}.writeScalingEnabled(true, //Enabled
                    {(byte)swpdsInput.DataSourceValue}); //DataSource
");
           
        }

        private void bGenInputScalingCode_Click(object sender, EventArgs e)
        {
            addTextToClipboard(
               $@"//put this line in setup.
                    {Name}.writeInputScaling({sbsiInputMin.value}, //Input Minimum
                    {sbsiInputMax.value}); //Input Maximum
");
        }

        private void bGenPIDCode_Click(object sender, EventArgs e)
        {
            addTextToClipboard(
                 $@"//put this line in setup.
                    {Name}.writePID({sbsiKp.value}, //Kp
                    {sbsiKi.value}, //Ki
                    {sbsiKd.value}, //Kd
                    {sbsiPIDTarget.value},  //Target Value
                    {(ScaledOutputPeriod)edPIDPeriod.selectedItem});//Period
");

        }

        private void bGenHysteresisCode_Click(object sender, EventArgs e)
        {
            addTextToClipboard(
     $@"//put this line in setup.
                    {Name}.writeHysteresis({sbsiHysLowLimit.value}, //Low Limit
                    {sbsiHysLowOutput.value}, //Low Value
                    {sbsiHysHighLimit.value}, //High Limit
                    {sbsiHysHighOutputValue.value}, //High Value
                    {sbsiHysInitialOutputValue.value}); // Initial output
");

        }

        private void bGenTimeoutCode_Click(object sender, EventArgs e)
        {
            addTextToClipboard(
     $@"//put this line in setup.
                    {Name}.writeTimeout({sbsiTimeout_mS.value}, //Timeout in mS
                    {sbsiTimeoutOutputValue.value}); //Output value if timeout
");
        }

        private void bPIDResetIntegrator_Click(object sender, EventArgs e)
        {
            ScaledOutput.PIDResetIntegrator();
        }

        private void bPIDUpdateTarget_Click(object sender, EventArgs e)
        {
            ScaledOutput.writeScalingTargetValue(sbsiPIDTarget.value);
        }

        private void bGenFilterCode_Click(object sender, EventArgs e)
        {
            addTextToClipboard(
     $@"//put this line in setup.
                    {Name}.write1stOrderFiltering(SerialWombatAbstractScaledOutput::Period::{(ScaledOutputPeriod)edFilteringPeriod.selectedItem}, //Filter Period
                    {sbsiFilterConstant.value});  //Filter constant
");
        }

        private void bGenRateLimit_Click(object sender, EventArgs e)
        {
            addTextToClipboard(
     $@"//put this line in setup.
                    {Name}.writeRateControl(SerialWombatAbstractScaledOutput::Period::{(ScaledOutputPeriod)edFilteringPeriod.selectedItem}, // Sampling Period
                    {sbsiMaxChangeUp.value}, //Maximum Increase Rate
                    {sbsiFilterConstant2.value} //Maximum Decrease Rate);
");


        }

        private void bGenOutputScalingcode_Click(object sender, EventArgs e)
        {
            addTextToClipboard(
            $@"//put this line in setup.
                    {Name}.ScaledOutput.writeOutputScaling({sbsiOutputScalingMin.value}, //Output Minimum Value
                    {sbsiOutputScalingMax.value}); //Output Maximum Value
");
        }

        private SixteenBitSliderInput[,] xyArray = new SixteenBitSliderInput[17,2];
        private void ScaledOutputControl_Load(object sender, EventArgs e)
        {
            
            for (int i = 0; i < 17; ++i)
            {
                SixteenBitSliderInput sbsi = new SixteenBitSliderInput();
                sbsi.Text = $"X{i}";
                sbsi.value = (UInt16)(i * 65535 / 16);
                if (i == 0)
                {
                    sbsi.Top= Margin.Top;
                }
                else
                {
                    sbsi.Top = xyArray[i - 1, 0].Bottom ;
                }
                sbsi.Width = (pXY.ClientSize.Width - 3 * Margin.Left) / 2;
                sbsi.trackBarValueChangedDelegates.Add(linearXYDataChange);
                pXY.Controls.Add(sbsi);
                xyArray[i,0] = sbsi;

                sbsi = new SixteenBitSliderInput();
                sbsi.Text = $"Y{i}";
                sbsi.value = (UInt16)(i * 65535 / 16);

                sbsi.Top = xyArray[i , 0].Top;
                sbsi.Left = xyArray[i, 0].Right + Margin.Horizontal;
                sbsi.Width = (pXY.ClientSize.Width - 3 * Margin.Left) / 2;
                pXY.Controls.Add(sbsi);
                xyArray[i, 1] = sbsi;
                sbsi.trackBarValueChangedDelegates.Add(linearXYDataChange);
                xyArray[0,0].Enabled = false;
            }
        }
        private void linearXYDataChange(object sender, EventArgs e)
        {
            int pointcount = 0;

            double[] x = new double[17];
            double[] y = new double[17];
            double ymax = 0;
            l2DWarning.Text = "";
            for (int i = 0; i < 17; ++i) {
                x[i] = xyArray[i, 0].value;
                y[i] = xyArray[i, 1].value;
                if (y[i] > ymax) ymax = y[i];
                if (i >0)
                {
                    if (x[i] <= x[i - 1]) { l2DWarning.Text = "ERROR: X values must be ascending"; }
                }
                if (x[i] == 65535) { 
                    pointcount = i + 1; break; 
                }
            }
            if ((int)(x[pointcount - 1]) != 65535) { l2DWarning.Text = "ERROR: X must contain a 65535 entry"; }
            x = x.Take(pointcount).ToArray();
            y = y.Take(pointcount).ToArray();   
            formsPlot1.plt.Clear();
            formsPlot1.plt.PlotScatter(x, y);
            formsPlot1.plt.Axis(0, 65535, 0, ymax + ymax / 10);
            formsPlot1.Render();

        }

        private void b2DConfigure_Click(object sender, EventArgs e)
        {
            List <byte> data = new List<byte>();
            UInt16[] x = new UInt16[17];
            UInt16[] y = new UInt16[17];
            double ymax = 0;
            int pointcount = 0;
            l2DWarning.Text = "";
            for (int i = 0; i < 17; ++i)
            {
                data.Add((byte)(xyArray[i, 0].value & 0xFF));
                data.Add((byte)(xyArray[i, 0].value >> 8));
                data.Add((byte)(xyArray[i, 1].value & 0xFF));
                data.Add((byte)(xyArray[i, 1].value >> 8));
                x[i] = xyArray[i, 0].value;
                y[i] = xyArray[i, 1].value;
                if (y[i] > ymax) ymax = y[i];
                if (i > 0)
                {
                    if (x[i] <= x[i - 1]) { l2DWarning.Text = "ERROR: X values must be ascending"; }
                }
                if (x[i] == 65535)
                {
                    pointcount = i + 1; break;
                }
            }
            if ((int)(x[pointcount - 1]) != 65535) { l2DWarning.Text = "ERROR: X must contain a 65535 entry"; }
            ScaledOutput._sw.writeUserBuffer(sbac2DIndex.Value, data.ToArray(),(UInt16)data.Count);
            ScaledOutput.Enable2DLookupOutputScaling(sbac2DIndex.Value);
        }

        private void bUpdateTargetCI_Click(object sender, EventArgs e)
        {
            ScaledOutput.PIDResetIntegrator();
            ScaledOutput.writeScalingTargetValue(sbsiPIDTarget.value);
        }
    }
}
