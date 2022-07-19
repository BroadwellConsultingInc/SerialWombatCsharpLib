using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using SerialWombat;

namespace SerialWombatWindowsFormsLibrary
{
    public partial class UARTControl : UserControl
    {
        public SerialWombatChip SerialWombatChip;
        public byte Pin;
        public SerialWombatUART SerialWombatUART;
        private delegate void SafeCallDelegate();
        string receivedString = "";
        public UARTControl()
        {
            InitializeComponent();
            cbBaudRate.Items.Add(300);
            cbBaudRate.SelectedIndex = 0;
            cbMode.SelectedIndex = 0;
        }

        int[] swbaudrates =
        {
            300,
1200,
2400,
4800,
9600,
19200,

        };

        int[] hwbaudrates =
        {
            38400,
57600,
115200,
        };

        public void begin(SerialWombatChip serialWombatChip, byte pin)
        {
            SerialWombatChip = serialWombatChip;
            Pin = pin;
        }
        
        public void end()
        {
            ckbAutosample.Checked = false;
        }
        private void cbMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbBaudRate.Items.Clear();
            cbTxPin.Items.Clear();
            cbRxPin.Items.Clear();
            foreach (int i in swbaudrates)
            {
                cbBaudRate.Items.Add(i);
            }
           switch (cbMode.SelectedIndex)
            {
                case 0:
                case 1:
                    gbSoftwareUartQueues.Enabled = false;
                    foreach (int i in hwbaudrates)
                    {
                        cbBaudRate.Items.Add(i);
                    }
                    if (SerialWombatChip != null)
                    {
                        foreach (int i in SerialWombatChip.enhancedPerformanceInputPins)
                        {
                            cbRxPin.Items.Add(i);
                        }
                        foreach (int i in SerialWombatChip.enhancedPerformanceOutputPins)
                        {
                            cbTxPin.Items.Add(i);
                        }
                    }
                    break;
               
                case 2:
                    gbSoftwareUartQueues.Enabled = true;
                    if (SerialWombatChip != null)
                    {
                        foreach (int i in SerialWombatChip.inputPins)
                        {
                            cbRxPin.Items.Add(i);
                        }
                        foreach (int i in SerialWombatChip.outputPins)
                        {
                            cbTxPin.Items.Add(i);
                        }
                    }
                    break;
            }
            cbTxPin.Items.Add(255);
            cbRxPin.Items.Add(255);
            cbBaudRate.SelectedIndex = 4;
        }

        private void bConfigure_Click(object sender, EventArgs e)
        {
            switch (cbMode.SelectedIndex)
            {
                case 0:
                case 1:
                    {
                        SerialWombatUART = new SerialWombatUART(SerialWombatChip);
                        SerialWombatUART.begin((uint)(int)cbBaudRate.SelectedItem,
                            Pin,
                            (byte)(int)cbRxPin.SelectedItem,
                            (byte)(int)cbTxPin.SelectedItem,
                            (byte)(cbMode.SelectedIndex + 1));
                    }
                    break;

                case 2:
                    {
                        SerialWombatSWUART sWUART = new SerialWombatSWUART(SerialWombatChip);
                        SerialWombatUART = sWUART;
                        sWUART.begin((uint)(int)cbBaudRate.SelectedItem,
                            Pin,
                            (byte)(int)cbRxPin.SelectedItem,
                            (byte)(int)cbTxPin.SelectedItem,
                            Convert.ToUInt16(tbQueueIndex.Text),
                            Convert.ToUInt16(tbRxSize.Text),
                            Convert.ToUInt16(tbTxSize.Text))
                            ;

                    }
                    break;
            }
            ckbAutosample.Enabled = (cbRxPin.SelectedIndex != 255);
            bTxFile.Enabled = (cbTxPin.SelectedIndex != 255);
        }

        void SampleThread()
        {
            while (ckbAutosample.Checked)
            {
                byte[] b = new byte[10000];
                int bytesRead = 0;
                SerialWombatUART.setTimeout(1);
                bytesRead = SerialWombatUART.readBytes(b, 10000);
                if (bytesRead > 0)
                {
                    b = b.Take(bytesRead).ToArray();
                     receivedString += Encoding.ASCII.GetString(b);
                    Thread thread = new Thread(updateData);
                    thread.Name = $"Pin {Pin} update Rx box";
                    thread.Start();
                }
                Thread.Sleep(0);
            }


        }

        public void updateData()
        {
            if (tbRx.InvokeRequired)
            {
                var d = new SafeCallDelegate(updateData);
                tbRx.Invoke(d, new object[] { });
            }
            else
            {
                tbRx.AppendText(receivedString);
                receivedString = "";
            }

        }

        private void ckbAutosample_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbAutosample.Checked)
            {
                Thread t = new Thread(SampleThread);
                t.Name = $"Pin {Pin} RX Thread ";
                t.Start();
            }
        }

        private void bClear_Click(object sender, EventArgs e)
        {
            receivedString = "";
            tbRx.Clear();
        }

        private void bTxFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
                if (ofd.ShowDialog() == DialogResult.OK)
            {
                byte[] buff = null;
   
                FileStream fs = new FileStream(ofd.FileName,
                                               FileMode.Open,
                                               FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                long numBytes = new FileInfo(ofd.FileName).Length;
                buff = br.ReadBytes((int)numBytes);
                fs.Close();
                Thread t = new Thread(sendData);
                t.Name = $"Pin {Pin} transmit {ofd.FileName}";
                t.Start(buff);


            }
        }

        private void sendData(object data)
        {
            int bytesActuallySent = 0;
            int totalActuallySent = 0;
            int sent = 0;
            byte[] buff = (byte[])data;
            int numBytes = buff.Length;
            while (sent < numBytes)
            {
                byte[] b = buff.Skip(sent).Take(10).ToArray();
                bytesActuallySent = SerialWombatUART.write(b, b.Count());
                totalActuallySent += bytesActuallySent;
                sent += bytesActuallySent;
                Thread.Sleep(5);
            }

        }
    }
}
