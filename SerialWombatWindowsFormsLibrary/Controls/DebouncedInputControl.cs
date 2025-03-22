using SerialWombat;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerialWombatWindowsFormsLibrary.Controls
{
    public partial class DebouncedInputControl : UserControl
    {
        public SerialWombatDebouncedInput debouncedInput;
        public SerialWombatChip SerialWombatChip;
        public byte Pin;
        private delegate void SafeCallDelegate();
        public UInt16 timePressed = 0;
        public UInt16 PublicData = 0;
        public UInt16 transitions = 0;
        public DebouncedInputControl()
        {
            InitializeComponent();
        }
        public void begin(SerialWombatChip serialWombatChip, byte pin)
        {
            SerialWombatChip = serialWombatChip;
            Pin = pin;
            groupBox1.Text = $"Debounced Input on pin {pin}";
            Name = $"Pin{pin}DebouncedInput";

            debouncedInput = new SerialWombatDebouncedInput(serialWombatChip);

        }
        private void DebouncedInputControl_Load(object sender, EventArgs e)
        {

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
        public void End()
        {
            ckbAutosample.Checked = false;
        }



        public void ReadRawDataAndPlot()
        {
            try
            {

                PublicData = debouncedInput.readPublicData();

                if (PublicData > 0)
                {
                    timePressed = debouncedInput.readDurationInTrueState_mS();
                }
                else
                {
                    timePressed = debouncedInput.readDurationInFalseState_mS();
                }
                transitions = debouncedInput.transitions;

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

                realTimeScottPlot1.PlotData(PublicData);

                lTimePressed.Text = timePressed.ToString();
                lTransitions.Text = transitions.ToString();


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



        public void end()
        {
            ckbAutosample.Checked = false;
        }

        private void bConfigure_Click(object sender, EventArgs e)
        {
            debouncedInput.begin(Pin, sbsiDebouncePeriod.value, ckbInvert.Checked, ckbPullUp.Checked);
        }

        private void bSample_Click(object sender, EventArgs e)
        {
            ReadRawDataAndPlot();
        }

        private void bGenCode_Click(object sender, EventArgs e)
        {
            string s = @$"
                //Put this line before setup()
                SerialWombatDebouncedInput {Name}(sw); // Your serial wombat chip may be named something else than sw
                //Add this line to  setup():
                 {Name}.begin({debouncedInput.pin},  //Pin
                            {sbsiDebouncePeriod.value}, //Debounce Ms
                            {ckbInvert.Checked}, // Invert
                            {ckbPullUp.Checked}); // Pull Up enabled
";


            s = s.Replace("True", "true");
            s = s.Replace("False", "false");
            Clipboard.SetText(s);
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo processInfo = new ProcessStartInfo();
            processInfo.FileName = "https://broadwellconsultinginc.github.io/SerialWombatArdLib/class_serial_wombat_debounced_input.html";
            processInfo.UseShellExecute = true;
            Process.Start(processInfo);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo processInfo = new ProcessStartInfo();
            processInfo.FileName = "https://www.youtube.com/watch?v=R1KM0J2Ug-M";
            processInfo.UseShellExecute = true;
            Process.Start(processInfo);
        }
    }
}
