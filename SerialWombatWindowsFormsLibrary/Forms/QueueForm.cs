using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SerialWombat;

namespace SerialWombatWindowsFormsLibrary
{
    public partial class QueueForm : Form
    {
        SerialWombatChip _sw;
        SerialWombatQueue _queue;
        UInt16 _length = 0;
        UInt16 _address = 0;
        public QueueForm(SerialWombatChip serialWombatChip)
        {
            InitializeComponent();
            _sw = serialWombatChip;
            queueControl1.begin(_sw);
        }
        public QueueForm(SerialWombatQueue serialWombatQueue)
        {
            InitializeComponent();
            _queue = serialWombatQueue;
            _sw = serialWombatQueue._sw;
            _length = _queue._size;
            _address = _queue._address;

            queueControl1.begin(_queue);
        }
        /*
        private void bInitialize_Click(object sender, EventArgs e)
        {
            byte[] addressArray;
            byte[] lengthArray ;
             _address= 0;
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


            _queue = new SerialWombatQueue(_sw );
            _queue.begin(_address, _length, SerialWombatQueueType.QUEUE_TYPE_RAM_BYTE);

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
            SerialWombatQueue copy = _queue.Clone(4000);
            int count = copy.read(_length, out data);
            textBox1.Clear();
            if (count > 0)
            {
                for (int i = 0; i < count; ++ i )
                {
                    textBox1.AppendText($"{data[i]:X2} ");
                }
            }
        }
        */
    }
}
