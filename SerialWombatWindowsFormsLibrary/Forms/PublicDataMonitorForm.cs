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
      
        UInt16 LastResult = 0;

        public PublicDataMonitorForm(SerialWombatChip serialWombatChip, byte pin)
        {
            InitializeComponent();
            SerialWombatChip = serialWombatChip;
            Pin = pin;
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



        

        
        private void bSample_Click(object sender, EventArgs e)
        {
            Pin = Convert.ToByte(tbDataId.Text);
            LastResult = SerialWombatChip.readPublicData(Pin);
            realTimeScottPlot1.PlotData(LastResult);
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
                Pin = Convert.ToByte(tbDataId.Text);
                LastResult = SerialWombatChip.readPublicData(Pin);
                realTimeScottPlot1.PlotData(LastResult);
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
