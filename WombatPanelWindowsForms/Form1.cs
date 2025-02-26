﻿using System;
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
            tsmiDownloadNewHexFile.Click += TsmiDownloadNewHexFile_Click;
            tsmiReadRam.Click += TsmiReadRam_Click;

            int gbHeight = 0;
            for (int i = 0; i < 5; ++ i)
            {

                GroupBox gb = createManualEntryBox(20, 100 + i * gbHeight);
                ManualEntryBoxes.Add(gb);
                this.Controls.Add(gb);
                gbHeight = gb.Height + 2;
            }

            
        }

        private void codeGenerationHandler(CodeGeneratedEventArgs e)
        {
            tbCodeGeneration.AppendText(e.Code);
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
                    ChipList.Add(sw);
                }


                foreach (GroupBox gb in ManualEntryBoxes)
                {
                    ComboBox cb = (ComboBox)gb.Controls[1];
                    int previousIndex = cb.SelectedIndex;
                    cb.Items.Clear();
                    foreach (SerialWombatChip sw in ChipList)
                    {
                        cb.Items.Add(sw);
                    }
                    if (ChipList.Count == 1)
                    {
                        cb.SelectedIndex = 0;
                    }
                    else
                    {
                        cb.SelectedIndex = previousIndex;
                    }
                }

                graphicPinSelectorControl1.SerialWombatChip = ChipList.Last();
                graphicPinSelectorControl1.Model = ChipList.Last().ModelEnum;
                Text = ChipList.Last().ModelEnum.ToString() + $" On Serial Port {sps.SelectedPort}";


            }
        }

            private void PortCloseMenuItem_Click(object sender, EventArgs e)
        {
            if (ChipList.Count > 0)
            {
                SerialWombatChip sw = ChipList.Last();
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
                ChipList.RemoveAt(ChipList.Count - 1);
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

        static public List<SerialWombatChip> ChipList = new List<SerialWombatChip>();


        private List<GroupBox> ManualEntryBoxes = new List<GroupBox>();
        private List<string> ManualEntryStrings = new List<string>();

       
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
            if (ckbIgnoreReads.Checked && received.Data[0] == 0x81)
            {
                return;
            }
            if (tbLog.InvokeRequired)
            {
                var d = new SafeCallDelegate(LogData);
                tbLog.Invoke(d, new object[] { sent,received });
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
                tbLog.AppendText($"Tx: {sent.RawString}  {sd} {Environment.NewLine}Rx: {received.RawString} {rd}{Environment.NewLine}{Environment.NewLine}");
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
                    sw.begin(sps.SelectedPort,tsmiResetSWCOnOpen.Checked, sps.SelectedPortType);
                    try
                    {
                        byte[] b = sw.readVersion();
                        ChipList.Add(sw);
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
                    graphicPinSelectorControl1.Enabled = true;
                    
                } 
                    
                
                foreach (GroupBox gb in ManualEntryBoxes)
                {
                    ComboBox cb = (ComboBox)gb.Controls[1];
                    int previousIndex = cb.SelectedIndex;
                    cb.Items.Clear();
                    foreach( SerialWombatChip sw in ChipList)
                    {
                        cb.Items.Add(sw);
                    }
                    if (ChipList.Count == 1)
                    {
                        cb.SelectedIndex = 0;
                    }
                    else
                    {
                        cb.SelectedIndex = previousIndex;
                    }
                }
                try
                {
                    graphicPinSelectorControl1.SerialWombatChip = ChipList.Last();
                    graphicPinSelectorControl1.Model = ChipList.Last().ModelEnum;
                    Text = ChipList.Last().ModelEnum.ToString() + $" On Serial Port {sps.SelectedPort}";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


            }
        }

        private void bReset_Click(object sender, EventArgs e)
        {
            if (ChipList.Count > 0)
            {
                ChipList.Last().hardwareReset();
            }
        }

        private void bSourceVoltage_Click(object sender, EventArgs e)
        {
            ChipList.Last().readSupplyVoltage_mV();
        }

        private void tsmiCArray_Click_1(object sender, EventArgs e)
        {

        }

        private void bResync_Click(object sender, EventArgs e)
        {
            ChipList.Last().sendPacket("UUUUUUUU");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            graphicPinSelectorControl1.codeGeneration = codeGenerationHandler;
        }

        private void tsmiReadRam_Click_1(object sender, EventArgs e)
        {
            UserBufferForm ubf = new UserBufferForm(ChipList.Last());
            ubf.Show();

        }

        private void tsmiDownloadNewHexFile_Click_1(object sender, EventArgs e)
        {
            if (ChipList.Last().isSW18())
            {
                SerialWombatSW18ABBootloaderClient bl =
                    new SerialWombatSW18ABBootloaderClient(ChipList.Last());
                OpenFileDialog ofd = new OpenFileDialog();
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    Bootload blf = new Bootload(ofd.FileName, ChipList.Last());
                    blf.alreadyInBoot = false;

                    blf.Show();
                }
            }
            if (ChipList.Last().isSW08())
            {
                SerialWombatSW08BBootloaderClient bl =
                   new SerialWombatSW08BBootloaderClient(ChipList.Last());
                OpenFileDialog ofd = new OpenFileDialog();
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    Bootload blf = new Bootload(ofd.FileName, ChipList.Last());
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
            ChipList.Last().StartCommandCapture();
        }

        private void cancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChipList.Last().StartCommandCapture();
            ChipList.Last().StopCommandCapture();
        }

        private void stopAndStoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChipList.Last().StopCommandCapture();
            ChipList.Last().StoreCommandCapture();
        }

        private void readToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StartupCommandsViewer scv = new StartupCommandsViewer(ChipList.Last());
            scv.Show();
        }

        private void sendStayInBootToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 1000; ++i)
            {
                ChipList.Last().sendPacketNoResponse("UUUUUUUU");
                ChipList.Last().sendPacketNoResponse("BoOtLoAd");
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

            ChipList.Last().sendPacket(resetSeq);
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
                ChipList.Last().sendPacket(packet, out rxPacket);
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

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            SerialWombatSW18ABBootloaderClient bl =
               new SerialWombatSW18ABBootloaderClient(ChipList.Last());
            var currentAssembly = Assembly.GetExecutingAssembly();
            var s = currentAssembly.GetManifestResourceNames();
            var stream = currentAssembly.GetManifestResourceStream("WombatPanelWindowsForms.Resources.SW18AB_V214_CRC_6CEF_27887.hex");
            var reader = new StreamReader(stream);
                Bootload blf = new Bootload(reader, ChipList.Last());
                blf.alreadyInBoot = false;

                blf.Show();
        }

        private void createSW08BCArrayFromHexToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                HexData m = SerialWombat08BHexProcessor.readAndProcess(ofd.FileName);
                string s = m.to32BitArray(0, 16384, true);

                SaveFileDialog sfd = new SaveFileDialog();
                sfd.DefaultExt = ".c";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter sw = new StreamWriter(sfd.FileName);
                    sw.Write(s);

                    sw.Close();
                }


            }
        }
    }

   
}
