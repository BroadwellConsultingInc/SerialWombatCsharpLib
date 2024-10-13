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
        {1200,
2400,
4800,
9600,
19200,
            38400,
57600,
115200,
        };

        public void begin(SerialWombatChip serialWombatChip, byte pin)
        {
            SerialWombatChip = serialWombatChip;
            Pin = pin;
            pdTx.Pin = 255;
            pdRx.Pin = 255;
            cbMode_SelectedIndexChanged(null, null);

        }

        public void end()
        {
            ckbAutosample.Checked = false;
        }
        private void cbMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbBaudRate.Items.Clear();
            pdRx.IncludeNAPin = true;
            pdTx.IncludeNAPin = true;
            byte priorRxPin = pdRx.Pin;
            byte priorTxPin = pdTx.Pin;
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
                        if (SerialWombatChip.isSW18())
                        {
                            pdRx.PinType = SerialWombatPinType.EnhancedPerformanceInputPin;
                            pdRx.begin(SerialWombatChip);

                            pdTx.PinType = SerialWombatPinType.EnhancedPerformanceOutputPin;
                            pdTx.begin(SerialWombatChip);
                        }
                        else
                        {
                            pdRx.PinType = SerialWombatPinType.InputPin;
                            pdRx.begin(SerialWombatChip);

                            pdTx.PinType = SerialWombatPinType.OutputPin;
                            pdTx.begin(SerialWombatChip);
                        }
                    }
                    break;

                case 2:
                    gbSoftwareUartQueues.Enabled = true;
                    foreach (int i in swbaudrates)
                    {
                        cbBaudRate.Items.Add(i);
                    }
                    if (SerialWombatChip != null)
                    {
                        pdRx.PinType = SerialWombatPinType.InputPin;
                        pdRx.begin(SerialWombatChip);

                        pdTx.PinType = SerialWombatPinType.OutputPin;
                        pdTx.begin(SerialWombatChip);
                    }
                    break;
            }
            pdTx.Pin = priorTxPin; pdRx.Pin = priorRxPin;
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
                            pdRx.Pin,
                            pdTx.Pin,
                            (byte)(cbMode.SelectedIndex + 1));
                    }
                    break;

                case 2:
                    {
                        SerialWombatSWUART sWUART = new SerialWombatSWUART(SerialWombatChip);
                        SerialWombatUART = sWUART;
                        sWUART.begin((uint)(int)cbBaudRate.SelectedItem,
                            Pin,
                            pdRx.Pin,
                            pdTx.Pin,
                            sbacQueueIndex.Value,
                            Convert.ToUInt16(tbRxSize.Text),
                            Convert.ToUInt16(tbTxSize.Text))
                            ;

                    }
                    break;
            }

            ckbAutosample.Enabled = (pdRx.Pin != 255);
            bTxFile.Enabled = (pdTx.Pin != 255);
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

        private void button4_Click(object sender, EventArgs e)
        {

            string s = "";
            switch (cbMode.SelectedIndex)
            {
                case 0:
                case 1:
                    {
                        s += @$"
                //Put this line before setup()
                SerialWombatUART {Name}(sw); // Your serial wombat chip may be named something else than sw
                //Add this to  setup():
                                {Name}.begin({(uint)(int)cbBaudRate.SelectedItem}, // Baud Rate
                            {Pin}, // Pin on which the state machine runs
                            {pdRx.Pin}, // Rx Pin
                            {pdTx.Pin},  // Tx Pin
                            {(byte)(cbMode.SelectedIndex + 1)});  // Hardware Interface
                               
";
                    }
                    break;

                case 2:
                    {
                        s += @$"
                //Put this line before setup()
                SerialWombatSWUART {Name}(sw); // Your serial wombat chip may be named something else than sw
                //Add this to  setup():
                                {Name}.begin({(uint)(int)cbBaudRate.SelectedItem},  // Baud Rate
                            {Pin}, // Pin on which the state machine runs
                            {pdRx.Pin}, // Rx Pin
                            {pdTx.Pin}, // Tx Pin
                            0x{sbacQueueIndex.Value:X4},  // Queues Location Index
                            {Convert.ToUInt16(tbRxSize.Text)}, // Rx Queue Size
                            {Convert.ToUInt16(tbTxSize.Text)}) // Tx Queue Size
                            ;
                               
";


                    }
                    break;
            }
            s = s.Replace("True", "true");
            s = s.Replace("False", "false");
            Clipboard.SetText(s);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SerialWombatQueue q = new SerialWombatQueue(SerialWombatChip);
            q.begin(sbacQueueIndex.Value, Convert.ToUInt16(tbRxSize.Text));
            q.begin((UInt16)(sbacQueueIndex.Value + Convert.ToUInt16(tbRxSize.Text) + 8), Convert.ToUInt16(tbTxSize.Text));
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
