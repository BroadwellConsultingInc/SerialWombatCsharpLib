using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace SerialWombatWindowsFormsLibrary
{
    public partial class SerialPortSelectorControl : UserControl
    {
        public string SelectedPort = null;
        public SerialWombatClassLibrary.SerialPortChipType SelectedPortType = SerialWombatClassLibrary.SerialPortChipType.GENERIC;

        delegate void portSelectDelegate();
        portSelectDelegate onPortSelect = null;
        public SerialPortSelectorControl()
        {
            InitializeComponent();
        }

        private void SerialPortSelectorControl_Load(object sender, EventArgs e)
        {
            listBox1.Items.AddRange(SerialPort.GetPortNames());
        }

        private void bSAMD21_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                SelectedPort = (string)listBox1.SelectedItem;
                SelectedPortType = (SerialWombatClassLibrary.SerialPortChipType.SEEDUINO_XIAO_SAMD21);
                if (onPortSelect != null) { onPortSelect(); }
            }
        }

        private void bUno_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                SelectedPort = (string)listBox1.SelectedItem;
                SelectedPortType = (SerialWombatClassLibrary.SerialPortChipType.GENERIC);
                if (onPortSelect != null) { onPortSelect(); }
            }
        }

        private void bGeneric_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                SelectedPort = (string)listBox1.SelectedItem;
                SelectedPortType = (SerialWombatClassLibrary.SerialPortChipType.GENERIC);
                if (onPortSelect != null) { onPortSelect(); }
            }
        }

        private void bBluetooth_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                SelectedPort = (string)listBox1.SelectedItem;
                SelectedPortType = (SerialWombatClassLibrary.SerialPortChipType.GENERIC);
                if (onPortSelect != null) { onPortSelect(); }
            }
        }

        private void bESP32_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                SelectedPort = (string)listBox1.SelectedItem;
                SelectedPortType = (SerialWombatClassLibrary.SerialPortChipType.SEEDUINO_XIAO_ESP32);
                if (onPortSelect != null) { onPortSelect(); }
            }
        }

        public String currentListItemSelection { get { if (listBox1.SelectedIndex != -1) { return (string)listBox1.SelectedItem; } else return ""; } }
        public void buttonsVisible(bool visible)
        {
            lOpen.Visible = bBluetooth.Visible = bGeneric.Visible = bESP32.Visible = bCancel.Visible = bUno.Visible = bSAMD21.Visible = visible;
        }
    }
}
