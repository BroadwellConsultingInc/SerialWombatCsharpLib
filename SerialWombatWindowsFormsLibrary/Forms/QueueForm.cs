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
            Text = $"Queue {serialWombatChip.description}";
        }
        public QueueForm(SerialWombatQueue serialWombatQueue)
        {
            InitializeComponent();
            _queue = serialWombatQueue;
            _sw = serialWombatQueue._sw;
            _length = _queue._size;
            _address = _queue._address;

            queueControl1.begin(_queue);
            Text = $"Queue 0x{_address:X4} {serialWombatQueue._sw.description}";
        }
      
    }
}
