using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Management;
using System.Text;
using System.Windows.Forms;
using SerialWombat;

namespace SerialWombatWindowsFormsLibrary
{
    public partial class SerialPortSelector : Form
    {
        public SerialPortSelector()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterParent;
        }
        public string SelectedPort = null;
        public SerialWombatClassLibrary.SerialPortChipType SelectedPortType = SerialWombatClassLibrary.SerialPortChipType.GENERIC;
        private void SerialPortSelector_Load(object sender, EventArgs e)
        {
            listBox1.Items.AddRange(SerialPort.GetPortNames());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                SelectedPort = (string)listBox1.SelectedItem;
                SelectedPortType = (SerialWombatClassLibrary.SerialPortChipType.SEEDUINO_XIAO_SAMD21);
                this.Close();
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            SelectedPort = null;
            this.Close();
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                SelectedPort = (string)listBox1.SelectedItem;
                this.Close();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                SelectedPort = (string)listBox1.SelectedItem;
                SelectedPortType = (SerialWombatClassLibrary.SerialPortChipType.SEEDUINO_XIAO_ESP32);
                this.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                SelectedPort = (string)listBox1.SelectedItem;
                SelectedPortType = (SerialWombatClassLibrary.SerialPortChipType.GENERIC);
                this.Close();
            }
        }
    }

}
