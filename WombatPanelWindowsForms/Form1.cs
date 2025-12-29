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
using SerialWombatSW18ABBootloader;
using SerialWombatSW08BBootloader;
using IntelHex;
using System.Diagnostics;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Net.Sockets;

namespace WombatPanelWindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //Add menu item onClick.  These don't seem to be supported by the designer at this point.
            portOpenTCPMenuItem.Click += PortOpenTCPMenuItem_Click;
            portOpenI2CBridgeMenuItem.Click += PortOpenI2CBridgeMenuItem_Click;
            portCloseMenuItem.Click += PortCloseMenuItem_Click;
            tsmiDownloadNewHexFile.Click += tsmiDownloadNewHexFile_Click_1;
            tsmiReadRam.Click += TsmiReadRam_Click;

            int gbHeight = 0;
            for (int i = 0; i < 5; ++i)
            {

                GroupBox gb = createManualEntryBox(20, 100 + i * gbHeight);
                ManualEntryBoxes.Add(gb);
                this.Controls.Add(gb);
                gbHeight = gb.Height + 2;
            }


        }




        private void PortOpenI2CBridgeMenuItem_Click(object sender, EventArgs e)
        {
            SerialPortSelector sps = new SerialPortSelector();
            sps.ShowDialog(FindForm());
            if (sps.SelectedPort != null)
            {
                {
                    SerialWombatChip sw = new SerialWombatChip();
                    SerialWombatChip.SendDelegate LogDataDelegate = new SerialWombatChip.SendDelegate(LogData);
                    sw.SendDelegates.Add(LogDataDelegate);
                    //TODO sw.OpenI2CBridge(sps.SelectedPort,0x6C);  //TODO - make I2C variable
                    //TODO add check to see that there's a wombat there.
                    ChipDictionary.Add(sw.i2cAddress, sw);
                    CurrentSerialWombatChip = sw;
                }


                foreach (GroupBox gb in ManualEntryBoxes)
                {
                    ComboBox cb = (ComboBox)gb.Controls[1];
                    int previousIndex = cb.SelectedIndex;
                    cb.Items.Clear();

                }

                graphicPinSelectorControl1.SerialWombatChip = CurrentSerialWombatChip;
                graphicPinSelectorControl1.Model = CurrentSerialWombatChip.ModelEnum;
                Text = CurrentSerialWombatChip.ToString() + $" On Serial Port {sps.SelectedPort}";


            }
        }

        private void PortCloseMenuItem_Click(object sender, EventArgs e)
        {
            if (CurrentSerialWombatChip != null)
            {

                CurrentSerialWombatChip.Serial.Port.Close();

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

        //static public List<SerialWombatChip> ChipList = new List<SerialWombatChip>();
        static public Dictionary<int, SerialWombatChip> ChipDictionary = new Dictionary<int, SerialWombatChip>();
        static SerialWombatChip CurrentSerialWombatChip = null;

        private List<GroupBox> ManualEntryBoxes = new List<GroupBox>();
        private List<string> ManualEntryStrings = new List<string>();


        private GroupBox createManualEntryBox(int x, int y)
        {
            GroupBox gb = new GroupBox() { Left = x, Top = y, Width = 700, Height = 50 };
            ComboBox cbString = new ComboBox() { Width = 500 };
            gb.Controls.Add(cbString);  // Must be first

            Button bSend = new Button() { Text = "Send", Left = cbString.Right + 20 };
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
              
                SerialWombatPacket wp = new SerialWombatPacket(cbString.Text);
                wp = wp.TypedPacket();
                if (!ManualEntryStrings.Contains(cbString.Text))
                {
                    ManualEntryStrings.Add(cbString.Text);
                }
                var response = CurrentSerialWombatChip.sendPacket(wp);
            }
            foreach (GroupBox gb in ManualEntryBoxes)
            {
                ComboBox cb = (ComboBox)gb.Controls[0];
                int previousIndex = cb.SelectedIndex;
                cb.Items.Clear();
                foreach (string s in ManualEntryStrings)
                {
                    cb.Items.Add(s);
                }
                cb.SelectedIndex = previousIndex;
            }
        }

        private delegate void SafeCallDelegate(SerialWombatPacket sent, SerialWombatPacket received, byte i2CAddress);
        void LogData(SerialWombatPacket sent, SerialWombatPacket received, byte i2CAddress = 0)
        {
            if (ckbIgnoreReads.Checked && received.Data[0] == 0x81)
            {
                return;
            }
            if (tbLog.InvokeRequired)
            {
                var d = new SafeCallDelegate(LogData);
                tbLog.Invoke(d, new object[] { sent, received,i2CAddress });
            }
            else
            {


                string sd = "";
                string rd = "";
                if (ckbDecodeMessages.Checked)
                {
                    sd = "// " + SerialWombatPacketDecoder.decode(sent.Data, false);
                    rd = "// " + SerialWombatPacketDecoder.decode(received.Data, true);
                }
                string address = "";
                if ( i2CAddress != 0)
                {
                    address = $"0x{i2CAddress:X2}: ";
                }
                tbLog.AppendText($"{address}Tx: {sent.RawString}  {sd} {Environment.NewLine}{address}Rx: {received.RawString} {rd}{Environment.NewLine}{Environment.NewLine}");
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

                    if (!sps.noAddressing)
                    {
                        try
                        {
                            sw.i2cAddress = Convert.ToByte(sps.I2CAddress, 16);

                        }
                        catch { }
                    }
                    try
                    {
                        sw.begin(sps.SelectedPort, tsmiResetSWCOnOpen.Checked, sps.SelectedPortType);
                    }
                    catch (Exception beginException)
                    {
                        MessageBox.Show($"Failed to connect.  Is port unavailable or open elsewhere (Arduino Monitor, Cura?) ?  If using a bridge app, is it set to right I2C address?  Exception: {beginException.Message} ");
                        return;
                    }
                    try
                    {
                        byte[] b = sw.readVersion();
                        ChipDictionary.Add(sw.i2cAddress, sw);
                        CurrentSerialWombatChip = sw;
                        if (sw.isSW18())
                        {
                            int ver = (b[4] - 0x30) * 100 + (b[5] - 0x30) * 10 + b[6] - 0x30;

                            if (sw.inBoot)
                            {
                                MessageBox.Show($"This Serial Wombat chip is in bootloader mode.  Upload a hex file through the tools menu.  Most Wombat Panel operations will not work.");
                            }

                            int packetTime = communicationsTest(100);
                            string swdata = "";

                            swdata += ($"Serial Wombat SW18AB on port {sps.SelectedPort} detected, firmware version {(char)b[4]}.{(char)b[5]}.{(char)b[6]} {Environment.NewLine}");
                            {
                                string s = "";
                                for (int i = 0; i < sw.uniqueIdentifierLength; ++i)
                                {
                                    s += $"0x{sw.uniqueIdentifier[i]:X2} ";
                                }
                                swdata += ($"Unique Id: {s} {Environment.NewLine}");
                            }
                            swdata += ($"Device ID: {sw.deviceIdentifier}, Revision: {sw.deviceRevision} {Environment.NewLine}");
                            swdata += ($"Source Voltage: {sw._supplyVoltagemV / 1000.0}{Environment.NewLine}");
                            swdata += ($"Temperature: {sw.readTemperature_100thsDegC() / 100.0}{Environment.NewLine}");
                            swdata += ($"Birthday: {sw.readBirthday()}{Environment.NewLine}");

                            string brand;
                            sw.readBrand(out brand);
                            swdata += ($"Brand: {brand}{Environment.NewLine}");
                            swdata += $"Packet time: {packetTime}mS per packet{Environment.NewLine}";
                            if (packetTime > 5)
                            {
                                swdata += ("mS per packet may be slow due to Serial Port Settings.  Consider seeing if latency settings can be improved in the Port's Windows Device manager Advanced Properties");

                            }
                            tbLog.AppendText(swdata);
                            graphicPinSelectorControl1.Enabled = true;
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Serial Wombat Chip did not respond to a version request.");
                    }

                    foreach (var i in cbI2CAddress.Items)
                    {
                        if ((string)i == sps.I2CAddress)
                        {
                            cbI2CAddress.SelectedItem = i;
                        }
                    }

                    graphicPinSelectorControl1.Enabled = true;

                }


                try
                {
                    graphicPinSelectorControl1.SerialWombatChip = CurrentSerialWombatChip;
                    graphicPinSelectorControl1.Model = CurrentSerialWombatChip.ModelEnum;
                    Text = CurrentSerialWombatChip.description;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


            }
        }

        private void bReset_Click(object sender, EventArgs e)
        {
            if (CurrentSerialWombatChip != null)
            {
                CurrentSerialWombatChip.hardwareReset();
            }
        }

        private void bSourceVoltage_Click(object sender, EventArgs e)
        {
            CurrentSerialWombatChip.readSupplyVoltage_mV();
        }

        private void tsmiCArray_Click_1(object sender, EventArgs e)
        {

        }

        private void bResync_Click(object sender, EventArgs e)
        {
            CurrentSerialWombatChip.sendPacket("UUUUUUUU");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tsmiReadRam_Click_1(object sender, EventArgs e)
        {
            UserBufferForm ubf = new UserBufferForm(CurrentSerialWombatChip);
            ubf.Show();

        }

        private void tsmiDownloadNewHexFile_Click_1(object sender, EventArgs e)
        {
            if (CurrentSerialWombatChip.isSW18())
            {
                SerialWombatSW18ABBootloaderClient bl =
                    new SerialWombatSW18ABBootloaderClient(CurrentSerialWombatChip);
                OpenFileDialog ofd = new OpenFileDialog();
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    Bootload blf = new Bootload(ofd.FileName, CurrentSerialWombatChip);
                    blf.alreadyInBoot = false;

                    blf.Show();
                }
            }
            if (CurrentSerialWombatChip.isSW08())
            {
                SerialWombatSW08BBootloaderClient bl =
                   new SerialWombatSW08BBootloaderClient(CurrentSerialWombatChip);
                OpenFileDialog ofd = new OpenFileDialog();
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    Bootload blf = new Bootload(ofd.FileName, CurrentSerialWombatChip);
                    blf.alreadyInBoot = false;

                    blf.Show();
                }
            }
        }

        private void tsmiResetSWCOnOpen_Click(object sender, EventArgs e)
        {
            tsmiResetSWCOnOpen.Checked = !tsmiResetSWCOnOpen.Checked;
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CurrentSerialWombatChip.StartCommandCapture();
        }

        private void cancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CurrentSerialWombatChip.StartCommandCapture();
            CurrentSerialWombatChip.StopCommandCapture();
        }

        private void stopAndStoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CurrentSerialWombatChip.StopCommandCapture();
            CurrentSerialWombatChip.StoreCommandCapture();
        }

        private void readToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StartupCommandsViewer scv = new StartupCommandsViewer(CurrentSerialWombatChip);
            scv.Show();
        }

        private void sendStayInBootToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 1000; ++i)
            {
                CurrentSerialWombatChip.sendPacketNoResponse("UUUUUUUU");
                CurrentSerialWombatChip.sendPacketNoResponse("BoOtLoAd");
                Thread.Sleep(5);
            }
        }


        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcessStartInfo processInfo = new ProcessStartInfo();
            processInfo.FileName = "https://www.serialwombat.com/docs-links";
            processInfo.UseShellExecute = true;
            Process.Start(processInfo);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ProcessStartInfo processInfo = new ProcessStartInfo();
            processInfo.FileName = "https://broadwellconsultinginc.github.io/SerialWombatArdLib/";
            processInfo.UseShellExecute = true;
            Process.Start(processInfo);
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

            ProcessStartInfo processInfo = new ProcessStartInfo();
            processInfo.FileName = " https://www.youtube.com/@serialwombat";
            processInfo.UseShellExecute = true;
            Process.Start(processInfo);
        }

        private void communicationsTestToolStripMenuItem_Click(object sender, EventArgs e)
        {


            communicationsTest(5000);


        }

        private int communicationsTest(int iterations)
        {
            int passed = 0;
            int failed = 0;
            int count = 0;
            byte[] resetSeq = { 0xB4, (byte)'R', (byte)'E', (byte)'S', (byte)'E', (byte)'T', 0x55, 0x55 };

            CurrentSerialWombatChip.sendPacket(resetSeq);
            DateTime start = DateTime.Now;
            byte seqNum = 0;
            for (int i = 0; i < iterations; ++i)
            {
                byte[] packet = new byte[8];
                packet[0] = 0xB4;

                for (int p = 1; p <= 7; ++p)
                {
                    packet[p] = seqNum;
                    ++seqNum;
                }
                byte[] rxPacket;
                CurrentSerialWombatChip.sendPacket(packet, out rxPacket);
                for (int p = 0; p < 8; ++p)
                {
                    if (packet[p] != rxPacket[p])
                    {
                        ++failed;
                    }
                    else
                    {
                        ++passed;
                    }
                }
                ++count;
            }
            DateTime end = DateTime.Now;
            int msPerPacket = (int)((end - start).TotalMilliseconds / count);
            string result = $"Communication test:  {count} packets in {(end - start).TotalMilliseconds} ms, {msPerPacket} ms Per Packet {Environment.NewLine} Pass: {passed} Fail: {failed}{Environment.NewLine}";
            tbLog.AppendText(result);
            if (msPerPacket > 5)
            {
                tbLog.AppendText("mS per packet may be slow due to Serial Port Settings.  Consider seeing if latency settings can be improved in the Port's Windows Device manager Advanced Properties");
            }
            return msPerPacket;
        }

       

        private void createSW08BCArrayFromHexToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                HexData m = SerialWombat08BHexProcessor.readAndProcess(ofd.FileName);
                string s = m.to16BitArray(0, 16384, true);

                SaveFileDialog sfd = new SaveFileDialog();
                sfd.DefaultExt = ".c";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter sw = new StreamWriter(sfd.FileName);
                    sw.Write(s);

                    sw.Close();
                    sw = new StreamWriter(sfd.FileName + ".hex");

                    sw.Write(m.toHexFileString(0, 16384));
                    sw.Close();
                }


            }
        }

        private void bClearCapture_Click(object sender, EventArgs e)
        {
            tbLog.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] l = tbLog.Lines;
            string output = "const uint8_t initializationArray[SW_INITCOUNT][8] = {" + Environment.NewLine;
            Regex r = new Regex(@"^\s*Tx:\s+(\w\w)\s+(\w\w)\s+(\w\w)\s+(\w\w)\s+(\w\w)\s+(\w\w)\s+(\w\w)\s+(\w\w)");
            int initCount = 0;
            foreach (string s in l)
            {
                Match m = r.Match(s);
                if (m.Success)
                {
                    ++initCount;
                    output += "{";
                    for (int i = 1; i <= 8; ++i)
                    {
                        output += $" 0x{m.Groups[i].Value}, ";
                    }
                    output += "}," + Environment.NewLine;

                }
            }
            output += "};";
            output = $"#define SW_INITCOUNT {initCount}" + Environment.NewLine + output;
            Clipboard.SetText(output);
        }

        private void portOpenTCPMenuItem_Click_1(object sender, EventArgs e)
        {
            TCPPortSelector tCPPortSelector = new TCPPortSelector();
            tCPPortSelector.ShowDialog();
            TcpClient client = new TcpClient(tCPPortSelector.host, tCPPortSelector.port);
            client.ReceiveTimeout = 500;

            NetworkStream stream = client.GetStream();

            {
                {
                    SerialWombatChip sw = new SerialWombatChip();
                    SerialWombatChip.SendDelegate LogDataDelegate = new SerialWombatChip.SendDelegate(LogData);
                    sw.SendDelegates.Add(LogDataDelegate);
                    try
                    {
                        sw.begin(stream, tsmiResetSWCOnOpen.Checked);
                    }
                    catch (Exception beginException)
                    {
                        MessageBox.Show($"Failed to connect.  Is port unavailable or open elsewhere (Arduino Monitor?) ?  Exception: {beginException.Message} ");
                        return;
                    }
                    try
                    {
                        byte[] b = sw.readVersion();
                        ChipDictionary.Add(0, sw); //TODO add support for multiple chips on TCP
                        CurrentSerialWombatChip = sw;
                        if (sw.isSW18())
                        {
                            int ver = (b[4] - 0x30) * 100 + (b[5] - 0x30) * 10 + b[6] - 0x30;

                            if (sw.inBoot)
                            {
                                MessageBox.Show($"This Serial Wombat chip is in bootloader mode.  Upload a hex file through the tools menu.  Most Wombat Panel operations will not work.");
                            }

                            else if (ver < 214)
                            {
                                MessageBox.Show($"This Serial Wombat chip is using firmware version {(char)b[4]}.{(char)b[5]}.{(char)b[6]}   .  Version 2.1.4 or later is required for all features to work correctly.  Choose \"Tools...Bootload Lates Firmware\" or   See https://youtu.be/q7ls-lMaL80 ");
                            }
                            int packetTime = communicationsTest(100);
                            string swdata = "";

                            swdata += ($"Serial Wombat SW18AB on {tCPPortSelector.host} detected, firmware version {(char)b[4]}.{(char)b[5]}.{(char)b[6]} {Environment.NewLine}");
                            {
                                string s = "";
                                for (int i = 0; i < sw.uniqueIdentifierLength; ++i)
                                {
                                    s += $"0x{sw.uniqueIdentifier[i]:X2} ";
                                }
                                swdata += ($"Unique Id: {s} {Environment.NewLine}");
                            }
                            swdata += ($"Device ID: {sw.deviceIdentifier}, Revision: {sw.deviceRevision} {Environment.NewLine}");
                            swdata += ($"Source Voltage: {sw._supplyVoltagemV / 1000.0}{Environment.NewLine}");
                            swdata += ($"Temperature: {sw.readTemperature_100thsDegC() / 100.0}{Environment.NewLine}");
                            swdata += ($"Birthday: {sw.readBirthday()}{Environment.NewLine}");

                            string brand;
                            sw.readBrand(out brand);
                            swdata += ($"Brand: {brand}{Environment.NewLine}");
                            swdata += $"Packet time: {packetTime}mS per packet{Environment.NewLine}";
                            if (packetTime > 5)
                            {
                                swdata += ("mS per packet may be slow due to Serial Port Settings.  Consider seeing if latency settings can be improved in the Port's Windows Device manager Advanced Properties");

                            }
                            tbLog.AppendText(swdata);
                            graphicPinSelectorControl1.Enabled = true;
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Serial Wombat Chip did not respond to a version request.");
                    }
                    graphicPinSelectorControl1.Enabled = true;

                }


                foreach (GroupBox gb in ManualEntryBoxes)
                {
                    ComboBox cb = (ComboBox)gb.Controls[1];
                    int previousIndex = cb.SelectedIndex;
                    cb.Items.Clear();

                }
                try
                {
                    graphicPinSelectorControl1.SerialWombatChip = CurrentSerialWombatChip;
                    graphicPinSelectorControl1.Model = CurrentSerialWombatChip.ModelEnum;
                    Text = CurrentSerialWombatChip.ModelEnum.ToString() + $" On TCP Host {tCPPortSelector.host}";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


            }
        }

        private void cbI2CAddress_SelectedIndexChanged(object sender, EventArgs e)
        {
            byte address = 0;
            try
            {
                address = Convert.ToByte((string)cbI2CAddress.SelectedItem, 16);
            }
            catch
            {

            }

            if (ChipDictionary.ContainsKey(address))
            {
                CurrentSerialWombatChip = ChipDictionary[address];
            }
            else
            {
                SerialWombatChip swc = new SerialWombatChip() { i2cAddress = address };
                ChipDictionary.Add(address, swc);
                SerialWombatChip.SendDelegate LogDataDelegate = new SerialWombatChip.SendDelegate(LogData);
                swc.SendDelegates.Add(LogDataDelegate);
                swc.begin(CurrentSerialWombatChip.Serial,false);
                CurrentSerialWombatChip = swc;
            }
            graphicPinSelectorControl1.SerialWombatChip = CurrentSerialWombatChip;
            graphicPinSelectorControl1.Model = CurrentSerialWombatChip.ModelEnum;
            Text = CurrentSerialWombatChip.description;
        }
    }


}
