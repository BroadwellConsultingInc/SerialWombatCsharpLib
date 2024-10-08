﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SerialWombat;

namespace SerialWombatWindowsFormsLibrary.Controls
{
    public partial class QueueControl : UserControl
    {
        public SerialWombatChip SerialWombatChip;
        SerialWombatQueue _queue;
        UInt16 _length = 0;
        UInt16 _address = 0;
        public QueueControl()
        {
            InitializeComponent();
        }

       public void begin(SerialWombatChip serialWombatChip)
        {
            SerialWombatChip = serialWombatChip;
            
        }
        public void begin(SerialWombatQueue queue)
        {
            _queue = queue;
            _length = queue._size;
            _address = queue._address;
            SerialWombatChip = queue._sw;
            tbAddress.Text = $"0x{_address:X4}";
            tbLength.Text = $"0x{_length:X4}";
            groupBox1.Text = $"Queue at 0x{_address:X4}, Length ${_length}";

        }
        private void bInitialize_Click(object sender, EventArgs e)
        {
            byte[] addressArray;
            byte[] lengthArray;
            _address = 0;
            _length = 0;
            if (!StringToByteArrayParser.ParseMsg(tbAddress.Text, out addressArray))
            {
                MessageBox.Show("Couldn't parse address");
            }
            else
            {
                _address = (UInt16)(addressArray[0] + addressArray[1] * 256);
            }
            if (!StringToByteArrayParser.ParseMsg(tbLength.Text, out lengthArray))
            {
                MessageBox.Show("Couldn't parse length");
            }
            else
            {
                if (lengthArray.Length == 1)
                {
                    _length = lengthArray[0];
                }
                else
                {
                    _length = (UInt16)(lengthArray[0] + lengthArray[1] * 256);
                }
            }


            _queue = new SerialWombatQueue(SerialWombatChip);
            _queue.begin(_address, _length, SerialWombatQueueType.QUEUE_TYPE_RAM_BYTE);

            groupBox1.Text = $"Queue at 0x{_address:X4}, Length ${_length}";
        }

        private void bWrite_Click(object sender, EventArgs e)
        {
            byte[] data;
            if (StringToByteArrayParser.ParseMsg(textBox1.Text, out data))
            {
                _queue.write(data.Length, data);
            }
            else
            {
                MessageBox.Show("Couldn't parse data");
            }
        }

        private void bRead_Click(object sender, EventArgs e)
        {
            byte[] data;
            int samples = 0;
            realTimeScottPlot1.ClearData();
            int count = _queue.read(_length, out data);
            textBox1.Clear();
            if (count > 0)
            {
                if (ckb16BitReads.Checked)
                {
                    string s = "";
                    for (int i = 0; i < count; i += 2)
                    {
                        UInt16 d = (UInt16)(data[i] + data[i + 1] * 256);
                        if (ckbDecimal.Checked)
                        {
                            s += $"{d} ";
                        }
                        else 
                        { 
                            s += $"{d:X4} ";
                        }
                        realTimeScottPlot1.PlotData(d);
                        ++samples;
                    }
                    textBox1.AppendText(s);
                }
                else
                {
                    string s = "";
                   for (int i = 0; i < count; ++i)
                    {
                        if (cbAscii.Checked && data[i] >= 0x20 && data[i] <= 0x7F)
                        {
                            s += Convert.ToChar(data[i]);
                        }
                        else if (ckbDecimal.Checked)
                        {
                            s += $"{data[i]} ";

                        }
                        else
                        {
                            s += $"{data[i]:X2} ";
                        }
                        realTimeScottPlot1.PlotData(data[i]);
                        ++samples;
                    }
                    textBox1.AppendText(s);
                }
                
            }
        }

        private void ckbDecimal_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbAscii_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void realTimeScottPlot1_Load(object sender, EventArgs e)
        {

        }

        private void ckb16BitReads_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tbCopyReadAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void bCopyAndRead_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tbLength_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbAddress_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
