using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using SerialWombat;
using SerialWombatWindowsFormsLibrary;
using WombatPanelWindowsForms.Bootloader;
using IntelHex;

namespace WombatPanelWindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //Add menu item onClick.  These don't seem to be supported by the designer at this point.

            portOpenSerialMenuItem.Click += PortOpenSerialMenuItem_Click;
            portOpenTCPMenuItem.Click += PortOpenTCPMenuItem_Click;
            portOpenI2CBridgeMenuItem.Click += PortOpenI2CBridgeMenuItem_Click;
            portCloseMenuItem.Click += PortCloseMenuItem_Click;
            tsmiDownloadNewHexFile.Click += TsmiDownloadNewHexFile_Click;
            tsmiCArray.Click += TsmiCArray_Click;
            tsmiReadRam.Click += TsmiReadRam_Click;

            int gbHeight = 0;
            for (int i = 0; i < 5; ++ i)
            {

                GroupBox gb = createManualEntryBox(20, 100 + i * gbHeight);
                ManualEntryBoxes.Add(gb);
                this.Controls.Add(gb);
                gbHeight = gb.Height + 2;
            }

            graphicPinSelectorForm = new GraphicPinSelector();
            graphicPinSelectGroupBox = graphicPinSelectorForm.GetGroupBox();
            graphicPinSelectGroupBox.Left = this.Width - graphicPinSelectGroupBox.Width - 30;
            graphicPinSelectGroupBox.Top = ManualEntryBoxes[0].Top;
            Controls.Add(graphicPinSelectGroupBox);

        }

        private void TsmiCArray_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                HexData data = new HexData(ofd.FileName, true);
                data.Crop(0x140 * 2, 0x1000 * 2);
                data.Fill16(0x140 * 2, 0x1000 * 2, 0x3FFF);
                StreamWriter sw = new StreamWriter(ofd.FileName + ".c");
                
                sw.WriteLine($"const uint8_t flashImage[{data.Memory.Keys.Count}] = {{");

                uint lowestAddress = data.LowestAddress;
                uint highestAddress = data.HighestAddress;
                for (uint i = lowestAddress; i < highestAddress; i += 64 )
                {
                    for (uint x = 0; x < 64; ++x)
                    {
                        uint address = i + x;
                        byte dataByte = (byte) data.Memory[address];
                        sw.Write($"0x{dataByte:X2}, ");
                    }
                    sw.Write(Environment.NewLine);
                }
                sw.Write("};");
                sw.Close();
            }
        }

        private void PortOpenI2CBridgeMenuItem_Click(object sender, EventArgs e)
        {
            SerialPortSelector sps = new SerialPortSelector();
            sps.ShowDialog();
            if (sps.SelectedPort != null)
            {
                {
                    SerialWombatChip sw = new SerialWombatChip();
                    SerialWombatChip.SendDelegate LogDataDelegate = new SerialWombatChip.SendDelegate(LogData);
                    sw.SendDelegates.Add(LogDataDelegate);
                    //TODO sw.OpenI2CBridge(sps.SelectedPort,0x6C);  //TODO - make I2C variable
                    //TODO add check to see that there's a wombat there.
                    WombatList.Add(sw);
                }


                foreach (GroupBox gb in ManualEntryBoxes)
                {
                    ComboBox cb = (ComboBox)gb.Controls[1];
                    int previousIndex = cb.SelectedIndex;
                    cb.Items.Clear();
                    foreach (SerialWombatChip sw in WombatList)
                    {
                        cb.Items.Add(sw);
                    }
                    if (WombatList.Count == 1)
                    {
                        cb.SelectedIndex = 0;
                    }
                    else
                    {
                        cb.SelectedIndex = previousIndex;
                    }
                }

                graphicPinSelectorForm.SerialWombatChip = WombatList.Last();
                graphicPinSelectorForm.Model = WombatList.Last().ModelEnum;
                Text = WombatList.Last().ModelEnum.ToString() + $" On Serial Port {sps.SelectedPort}";


            }
        }

            private void PortCloseMenuItem_Click(object sender, EventArgs e)
        {
            if (WombatList.Count > 0)
            {
                SerialWombatChip sw = WombatList.Last();
                if (sw.Serial.Port != null)
                {
                    sw.Serial.Port.Close();
                }
                /*TODO
                if (sw.TCPStream != null)
                {
                    sw.TCPStream.Close();
                }
                */
                WombatList.RemoveAt(WombatList.Count - 1);
            }
        }

        private void TsmiReadRam_Click(object sender, EventArgs e)
        {
            /*TODO
            Ram r = new Ram();
            r.ReadAll(WombatList.Last());
            tbLog.AppendText(r.ToString());
            */
        }

        private void TsmiDownloadNewHexFile_Click(object sender, EventArgs e)
        {
            /*TODO
            Bootloader16F15214Uart bl = new Bootloader16F15214Uart();
            OpenFileDialog ofd = new OpenFileDialog();
            
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                WombatPacket wp = new WombatPacket("\"BoOtLoAd\"");
                WombatList[0].Send(wp);
                Thread.Sleep(1000);
                double d;
                string s;
                bl.DownloadHex(ofd.FileName, WombatList[0].Port,out s, out d);

                tbLog.AppendText($"Bootload Result: {Environment.NewLine}{s}{Environment.NewLine}");
                
                }
          */
        }

        private void PortOpenTCPMenuItem_Click(object sender, EventArgs e)
        {
           /*
                TCPPortSelector tcpps = new TCPPortSelector();
                tcpps.ShowDialog();
                if (tcpps.ipAddress != null)
                {
                    {
                        SerialWombatChip sw = new SerialWombatChip();
                        sw.OpenTCP(tcpps.ipAddress,tcpps.port);
                        //TODO add check to see that there's a wombat there.
                        WombatList.Add(sw);
                        SerialWombat.SendDelegate LogDataDelegate = new SerialWombat.SendDelegate(LogData);
                        sw.SendDelegates.Add(LogDataDelegate);

                    }
                    foreach (GroupBox gb in ManualEntryBoxes)
                    {
                        ComboBox cb = (ComboBox)gb.Controls[1];
                        int previousIndex = cb.SelectedIndex;
                        cb.Items.Clear();
                        foreach (SerialWombatChip sw in WombatList)
                        {
                            cb.Items.Add(sw);
                        }
                        if (WombatList.Count == 1)
                        {
                            cb.SelectedIndex = 0;
                        }
                        else
                        {
                            cb.SelectedIndex = previousIndex;
                        }
                    }

                    graphicPinSelectorForm.SerialWombatChip = WombatList.Last();
                graphicPinSelectorForm.Model = WombatList.Last().Model;
                Text = WombatList.Last().Model.ToString() + $" At  {tcpps.ipAddress}:{tcpps.port}";




                }
           */
            
        }

        static public List<SerialWombatChip> WombatList = new List<SerialWombatChip>();


        private List<GroupBox> ManualEntryBoxes = new List<GroupBox>();
        private List<string> ManualEntryStrings = new List<string>();
        private GroupBox graphicPinSelectGroupBox;
        private GraphicPinSelector graphicPinSelectorForm = null;

       
        private GroupBox createManualEntryBox(int x, int y)
        {
            GroupBox gb = new GroupBox() { Left = x, Top = y, Width = 700, Height = 50 };
            ComboBox cbString = new ComboBox() { Width = 500 };
            gb.Controls.Add(cbString);  // Must be first

            ComboBox cbWombat = new ComboBox() { Width = 100, Left = cbString.Right + 20 };
            gb.Controls.Add(cbWombat);

            Button bSend = new Button() { Text = "Send", Left = cbWombat.Right + 20 };
            bSend.Click += BSend_Click;
            gb.Controls.Add(bSend);

            gb.Height = bSend.Bottom + 5;
            gb.Width = bSend.Right + 5;
            return (gb);

        }

        private void BSend_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            {
                GroupBox gb = (GroupBox)b.Parent;
                ComboBox cbString = (ComboBox)gb.Controls[0];
                ComboBox cbWombat = (ComboBox)gb.Controls[1];
                SerialWombatChip sw = (SerialWombatChip)cbWombat.SelectedItem;
                SerialWombatPacket wp = new SerialWombatPacket(cbString.Text);
                wp = wp.TypedPacket();
                if (!ManualEntryStrings.Contains(cbString.Text))
                {
                    ManualEntryStrings.Add(cbString.Text);
                }
                var response = sw.sendPacket(wp);

               
            }
            foreach (GroupBox gb in ManualEntryBoxes)
            {
                ComboBox cb = (ComboBox)gb.Controls[0];
                int previousIndex = cb.SelectedIndex;
                cb.Items.Clear();
                foreach (string  s in ManualEntryStrings)
                {
                    cb.Items.Add(s);
                }
                cb.SelectedIndex = previousIndex;
            }
        }

        private delegate void SafeCallDelegate(SerialWombatPacket sent, SerialWombatPacket received);
        void LogData(SerialWombatPacket sent, SerialWombatPacket received)
        {
            if (tbLog.InvokeRequired)
            {
                var d = new SafeCallDelegate(LogData);
                tbLog.Invoke(d, new object[] { sent,received });
            }
            else
            {
                tbLog.AppendText($"Tx: {sent.RawString};{sent.PacketDescription} {Environment.NewLine}Rx: {received.RawString};{received.PacketDescription}{Environment.NewLine}{Environment.NewLine}");
            }

           
        }

        private void PortOpenSerialMenuItem_Click(object sender, System.EventArgs e)
        {
            SerialPortSelector sps = new SerialPortSelector();
            sps.ShowDialog();
            if (sps.SelectedPort != null)
            {
                {
                    SerialWombatChip sw = new SerialWombatChip();
                    SerialWombatChip.SendDelegate LogDataDelegate = new SerialWombatChip.SendDelegate(LogData);
                    sw.SendDelegates.Add(LogDataDelegate);
                    sw.begin(sps.SelectedPort);
                    //TODO add check to see that there's a wombat there.
                    WombatList.Add(sw);
                } 
                    
                
                foreach (GroupBox gb in ManualEntryBoxes)
                {
                    ComboBox cb = (ComboBox)gb.Controls[1];
                    int previousIndex = cb.SelectedIndex;
                    cb.Items.Clear();
                    foreach( SerialWombatChip sw in WombatList)
                    {
                        cb.Items.Add(sw);
                    }
                    if (WombatList.Count == 1)
                    {
                        cb.SelectedIndex = 0;
                    }
                    else
                    {
                        cb.SelectedIndex = previousIndex;
                    }
                }

                graphicPinSelectorForm.SerialWombatChip = WombatList.Last();
                graphicPinSelectorForm.Model = WombatList.Last().ModelEnum;
                Text = WombatList.Last().ModelEnum.ToString() + $" On Serial Port {sps.SelectedPort}";


            }
        }

        private void bReset_Click(object sender, EventArgs e)
        {
            if (WombatList.Count > 0)
            {
                WombatList.Last().hardwareReset();
            }
        }

        private void bSourceVoltage_Click(object sender, EventArgs e)
        {
            WombatList.Last().readSupplyVoltage_mV();
        }

        private void tsmiCArray_Click_1(object sender, EventArgs e)
        {

        }

        private void bResync_Click(object sender, EventArgs e)
        {
            WombatList.Last().sendPacket("UUUUUUUU");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
    }
}
