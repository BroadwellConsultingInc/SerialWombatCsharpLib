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
    public partial class QuadratureEncoderForm : Form
    {
        public SerialWombatQuadEnc QuadratureEncoder;
        
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public byte Pin { get; set; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)] 
        public SerialWombatChip SerialWombatChip { get; private set; }
      
        UInt16 LastPublicData = 0;
        private delegate void SafeCallDelegate();
        public QuadratureEncoderForm(SerialWombatChip serialWombatChip, byte pin)
        {
            InitializeComponent();
            Pin = pin;
            Text = $"QuadratureEncoder Pins {Pin}, {Pin + 1} ";
            SerialWombatChip = serialWombatChip;
            cbAction.SelectedIndex = 4;
            cbPullUpDown.SelectedIndex = 1;
            tbSecondPin.Text = (Pin + 1).ToString();

        }
        private void bConfigure_Click(object sender, EventArgs e)
        {
            try
            {
                byte secondPin = Convert.ToByte(tbSecondPin.Text);
                UInt16 lowLimit = Convert.ToUInt16(tbLowLimit.Text);
                UInt16 highLimit = Convert.ToUInt16(tbHighLimit.Text);
                byte pullUpDown =(byte) cbPullUpDown.SelectedIndex;
                byte action = (byte)cbAction.SelectedIndex;
                UInt16 debounce = Convert.ToUInt16(tbDebounce.Text);
                UInt16 increment = Convert.ToUInt16(tbIncrement.Text);
                QuadratureEncoder = new SerialWombatQuadEnc(SerialWombatChip);
                QuadratureEncoder.begin(Pin, secondPin, debounce, pullUpDown > 0, (QuadEncReadModes)action);
                SendValue();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        void SendValue()
        {
            UInt16 bufferValue = Convert.ToUInt16(tbValue.Text);
            QuadratureEncoder.write(bufferValue);
        }

        private void bRead_Click(object sender, EventArgs e)
        {
                        tbValue.Text = ReadRawDataAndPlot().ToString();
        }

        private void bWrite_Click(object sender, EventArgs e)
        {
            SendValue();
        }

        public UInt16 ReadRawDataAndPlot()
        {
            try
            {

                

                    LastPublicData = QuadratureEncoder.read();
                realTimeScottPlot1.PlotData(LastPublicData);
                  
              
            }
            catch 
            {
                //Fail silently
            }
            return (LastPublicData);

        }

       

        private void bSample_Click(object sender, EventArgs e)
        {
            ReadRawDataAndPlot();
        }



        void SampleThread()
        {
            while (ckbAutoSample.Checked)
            {
                ReadRawDataAndPlot();
                Thread.Sleep(100);
            }
        }

        private void ckbAutoSample_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbAutoSample.Checked)
            {
                Thread t = new Thread(SampleThread);
                t.Start();
                bRead.Enabled = false;
            }
            else
            {
                bRead.Enabled = true;
            }
        }

        private void bRename_Click(object sender, EventArgs e)
        {
            SingleLineTextEntryForm sltef = new SingleLineTextEntryForm("Name Form", "Add a name for this form:");
            sltef.ShowDialog();
            if (sltef.Success)
            {
 //TODO               this.Text = $"{sltef.outputString} Quad Enc on pins {QuadratureEncoder.Pin}, {QuadratureEncoder.SecondPin}";
            }
        }
    }
}
