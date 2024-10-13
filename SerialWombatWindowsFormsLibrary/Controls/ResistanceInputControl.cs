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
    public partial class ResistanceInputControl : UserControl
    {
        public SerialWombatResistanceInput ResistanceInput;
        public byte Pin = 0;
        public SerialWombatChip SerialWombatChip;
        AnalogInputResult LastResult = new AnalogInputResult();
        private delegate void SafeCallDelegate();
        public ResistanceInputControl()
        {
            InitializeComponent();
        }

        public void begin(SerialWombatChip serialWombatChip, byte pin)
        {
            SerialWombatChip = serialWombatChip;
            Pin = pin;

            groupBox1.Text = $"Resistance Input on Pin {pin}";
            this.Name = $"ResistanceInput{pin}";
            comboBox1.SelectedIndex = 0;
        }

        public UInt16 ReadRawDataAndPlot()
        {
            try
            {
                {
                    LastResult.PublicData = SerialWombatChip.readPublicData(ResistanceInput.Pin);
                    LastResult.Averaged = ResistanceInput.readAveragedOhms();
                    LastResult.Filtered = ResistanceInput.readFilteredOhms();
                    LastResult.Maximum = ResistanceInput.readMaximumOhms(false);
                    LastResult.Minimum = ResistanceInput.readMinimumOhms(false);
                    realTimeScottPlot1.PlotData(LastResult.PublicData);
                }
                UpdateGraph();

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
            if (tbAveraged.InvokeRequired)
            {
                var d = new SafeCallDelegate(UpdateGraph);
                tbAveraged.Invoke(d, new object[] { });
            }
            else
            {
                tbAveraged.Text = LastResult.Averaged.ToString();
                tbFiltered.Text = LastResult.Filtered.ToString();
                tbMax.Text = LastResult.Maximum.ToString();
                tbMin.Text = LastResult.Minimum.ToString();
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
              
                    try
                    {

                        if (ResistanceInput != null)
                        {
                            LastResult.PublicData = ResistanceInput.readPublicData();
                            LastResult.Averaged = ResistanceInput.readAveragedOhms();
                            LastResult.Filtered = ResistanceInput.readFilteredOhms();
                            LastResult.Maximum = ResistanceInput.readMaximumOhms(false);
                            LastResult.Minimum = ResistanceInput.readMinimumOhms(false);

                                realTimeScottPlot1.PlotData(LastResult.PublicData);

                        }
                    }
                    catch { }
                    Thread.Sleep(100);

            }
        }

        public void End()
        {
            ckbAutosample.Checked = false;
        }

        private void ResistanceInputForm_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }

        private void bConfigure_Click(object sender, EventArgs e)
        {
            try
            {
                ResistanceInput = new SerialWombatResistanceInput(SerialWombatChip);
                ResistanceInput.begin(Pin, Convert.ToUInt16(tbAverage.Text), Convert.ToUInt16(tbFilterConstant.Text), (ResistanceInputPublicDataOutput)comboBox1.SelectedIndex);
                ckbAutosample.Enabled = true;
                bGenCode.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void bGenCode_Click(object sender, EventArgs e)
        {
            string s =
            @$"
                //Put this line before setup()
                SerialWombatResistanceInput {Name}(sw); // Your serial wombat chip may be named something else than sw
                //Add this line to  setup():
                                {Name}.begin({Pin}, //Pin Number
                                {Convert.ToUInt16(tbAverage.Text)},  // Samples per Average
                                {Convert.ToUInt16(tbFilterConstant.Text)},//Filter Constant 
                                ResistanceInputPublicDataOutput::ResistanceInputPublicDataOutput_{(AnalogInputPublicDataOutput)comboBox1.SelectedIndex}); //Public data output
";


            Clipboard.SetText(s);
        }
    }
}
