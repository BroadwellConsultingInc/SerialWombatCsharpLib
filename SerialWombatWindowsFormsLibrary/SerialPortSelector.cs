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
        public bool noAddressing = false;
        public string I2CAddress = "Default";
        public SerialWombatClassLibrary.SerialPortChipType SelectedPortType = SerialWombatClassLibrary.SerialPortChipType.GENERIC;
        private void SerialPortSelector_Load(object sender, EventArgs e)
        {
            listBox1.Items.AddRange(SerialPort.GetPortNames());
            MessageBox.Show("Starting with this version, a new bridge application with addressing is required.  It is available in Arduino Examples.  For multichip setups, select the address in the box at the bottom.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                SelectedPort = (string)listBox1.SelectedItem;
                SelectedPortType = (SerialWombatClassLibrary.SerialPortChipType.SEEDUINO_XIAO_SAMD21);
                if (!ckbNoAddressing.Checked)

                {
                    if (cbI2CAddress.SelectedIndex > 0)
                    {
                        I2CAddress = (string)cbI2CAddress.SelectedItem;
                    }
                    else
                    {
                        I2CAddress = "0xFF";
                    }
                }
                this.Close();
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            SelectedPort = null;
            this.Close();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                SelectedPort = (string)listBox1.SelectedItem;
                SelectedPortType = (SerialWombatClassLibrary.SerialPortChipType.SEEDUINO_XIAO_ESP32);
                if (!ckbNoAddressing.Checked)

                {
                    if (cbI2CAddress.SelectedIndex > 0)
                    {
                        I2CAddress = (string)cbI2CAddress.SelectedItem;
                    }
                    else
                    {
                        I2CAddress = "0xFF";
                    }
                }
                this.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                SelectedPort = (string)listBox1.SelectedItem;
                SelectedPortType = (SerialWombatClassLibrary.SerialPortChipType.GENERIC);
                if (!ckbNoAddressing.Checked)
                    
                    {
                        if (cbI2CAddress.SelectedIndex > 0)
                        {
                            I2CAddress = (string)cbI2CAddress.SelectedItem;
                        }
                        else
                        {
                            I2CAddress = "0xFF";
                        }
                    }

                this.Close();
            }
        }

        private void ckbNoAddressing_CheckedChanged(object sender, EventArgs e)
        {
            cbI2CAddress.Enabled = !ckbNoAddressing.Checked;
            noAddressing = ckbNoAddressing.Checked;
        }
    }

}
