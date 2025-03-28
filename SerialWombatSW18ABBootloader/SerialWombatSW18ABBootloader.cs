﻿namespace SerialWombatSW18ABBootloader
{
    using System.Threading;
    using SerialWombat;
    using IntelHex;
    using System.Text;

    public class SerialWombatSW18ABBootloaderClient
    {
#pragma warning disable CS8605 // Unboxing a possibly null value.

        public SerialWombatChip SerialWombatChip;
        public double PercentDone = 0;
        public bool Bootloading = false;
        public string status = "Not started";
        public string result = "Not completed";
        public bool reset = true;

        uint baseAddr = 0x4000 * 2;
        uint length = (0x20000 - 0x4000) * 2;
        HexData hexData;
        public SerialWombatSW18ABBootloaderClient(SerialWombatChip serialWombatChip)
        {
            this.SerialWombatChip = serialWombatChip;
        }

        public void bootload(string hexFile, bool resetToBootloader = true)
        {           
            Bootloading = true;
            reset = resetToBootloader;
            PercentDone = 0;
            status = "Not started";
            result = "Not completed";

            status = "Parsing Hex File";

             hexData = loadFile(hexFile);

            Thread t = new Thread(threadfunc);
            t.Start();

        }

        public void bootload(StreamReader reader, bool resetToBootloader = true)
        {
            Bootloading = true;
            reset = resetToBootloader;
            PercentDone = 0;
            status = "Not started";
            result = "Not completed";

            status = "Parsing Hex File";

            hexData = loadFile(reader);

            Thread t = new Thread(threadfunc);
            t.Start();

        }

        void threadfunc()
        {
            Bootloading = true;
            if (reset)
            {
                status = "Erasing Programmed Marker";
                SerialWombatChip.eraseFlashPage((UInt32)(0x1F800 * 2)); // Datasheet worst case is 40.
                Thread.Sleep(50);
                status = "EnteringBootMode";
                //SerialWombatChip.sendPacketNoResponse("ReSeT!#*");
                byte[] res = Encoding.ASCII.GetBytes("UUUUUUUUReSeT!#*UUUUUUUBoOtLoAdUUUUUUUUBoOtLoAdUUUUUUUUBoOtLoAdUUUUUUUUBoOtLoAdUUUUUUUUBoOtLoAdUUUUUUUUBoOtLoAdUUUUUUUUBoOtLoAdUUUUUUUUBoOtLoAdUUUUUUUUBoOtLoAdUUUUUUUUBoOtLoAdUUUUUUUUBoOtLoAdUUUUUUUUBoOtLoAdUUUUUUUUBoOtLoAdUUUUUUUUBoOtLoAdUUUUUUUUBoOtLoAdUUUUUUUUBoOtLoAdUUUUUUUUBoOtLoAdUUUUUUUUBoOtLoAdUUUUUUUUBoOtLoAdUUUUUUUUBoOtLoAdUUUUUUUUBoOtLoAdUUUUUUUUBoOtLoAdUUUUUUUUBoOtLoAdUUUUUUUUBoOtLoAdUUUUUUUUBoOtLoAdUUUUUUUUBoOtLoAdUUUUUUUUBoOtLoAdUUUUUUUUBoOtLoAdUUUUUUUUBoOtLoAdUUUUUUUUBoOtLoAdUUUUUUUUBoOtLoAdUUUUUUUUBoOtLoAdUUUUUUUUBoOtLoAdUUUUUUUUBoOtLoAdUUUUUUUUBoOtLoAdUUUUUUUUBoOtLoAdUUUUUUUUBoOtLoAdUUUUUUUUBoOtLoAdUUUUUUUUBoOtLoAdUUUUUUUUBoOtLoAdUUUUUUUUBoOtLoAdUUUUUUUUBoOtLoAdUUUUUUUUBoOtLoAdUUUUUUUUBoOtLoAdUUUUUUUUBoOtLoAdUUUUUUUUBoOtLoAdUUUUUUUUBoOtLoAdUUUUUUUUBoOtLoAdUUUUUUUUBoOtLoAdUUUUUUUUBoOtLoAdUUUUUUUUBoOtLoAdUUUUUUUUBoOtLoAdUUUUUUUUBoOtLoAdUUUUUUUUBoOtLoAdUUUUUUUUBoOtLoAdUUUUUUUU");
                SerialWombatChip.Serial.write(res, res.Length);
                Thread.Sleep(500);
            }
            else
            {
                status = "Skipping reset...";
            }
            DateTime dateTime = DateTime.Now;
                      Thread.Sleep(100);
            while (SerialWombatChip.Serial.read() >= 0) ;
            bool inboot = false;
            for (int i = 0; i < 10 && inboot == false; ++i)
            {
                SerialWombatChip.queryVersion();

                if (SerialWombatChip.model[0] == (byte)'B')
                {
                    inboot = true;
                }
                else
                {
                    Thread.Sleep(100);
                }
            }
            if (inboot == false)
            {
                Bootloading = false;
                result = "Failed to enter Boot Mode";
                Thread.Sleep(1000);
                return;
            }
            status = "In Boot Mode";
            status = "Erasing";
            int address;

            for (address = 0x4000 * 2; address <= (0x1F800 * 2); address += 0x800 * 2)
            {

                status = $"Erasing Block address: 0x{address:X8}";
                SerialWombatChip.eraseFlashPage((UInt32)address); // Datasheet worst case is 40.
                Thread.Sleep(50);
                PercentDone = ((double)address - baseAddr) / length;
            }

            for (address = 0x4000 * 2; address < (0x20000 * 2); address += 512)
            {
                byte[] page = new byte[512];

                for (int i = 0; i < 512; ++i)
                {
                    page[i] = (byte)hexData.Memory[(UInt32)(address + i)];
                }
                bool dirty = false;
                for (int i = 0; i < 512; i += 4)
                {
                    dirty |= (page[i] != 0xFF || page[i+1] != 0xFF || page[i+2] != 0xFF);
                }
                if (dirty)
                {
                    SerialWombatChip.writeUserBuffer(0, page, 512);
                    SerialWombatChip.writeFlashRow((UInt32)address);
                    status = $"Programming address: 0x{address:X8}";
                    Thread.Sleep(4);
                }
                else
                {
                    status = $"Skipping blank Row  0x{address:X8}";
                }
                PercentDone = ((double)(address - baseAddr)) / length;
            }

            //Calculate CRC
            {
                byte[] tx = { 0xA4, 2, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55 };
                SerialWombatChip.sendPacket(tx);
                status = $"Writing Finished.  Calculating CRC.  This will take about 15 seconds.";
                Thread.Sleep(15000);
                byte[] tx3 = { 0xA4, 3, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55 };
                byte[] rx;
                SerialWombatChip.sendPacket(tx3, out rx);
                // Serial.print("Calculated CRC: ");
                //Serial.println(rx[2] + rx[3] * 256);
                // Serial.print("Expected CRC: ");
                // Serial.println(rx[4] + rx[5] * 256);
                //Serial.println();
                Thread.Sleep(1000);
                status = $"Bootload Finished.  Calculated CRC {rx[2] + rx[3] * 256}  Expected CRC: {rx[4] + rx[5] * 256}";
                SerialWombatChip.hardwareReset();
                Bootloading = false;
            }
        }
        HexData loadFile(string hexFile)
        {
            HexData m = new HexData(hexFile, true);

       //     byte x = (byte)m.Memory[(UInt32)0x55E00];
            m.Fill32(baseAddr, baseAddr + length, 0x00FFFFFF);
            m.Memory[(UInt32)(0x1F800 * 2)] = (byte)0x23;
            m.Memory[(UInt32)(0x1F800 * 2 + 1)] = (byte)0xCD; // Magic number indicating programmed.
            m.Memory[(UInt32)(0x1F800 * 2 + 2)] = (byte)0x00; // Magic number indicating programmed.
            UInt16 crc = m.Crc16citt(0x8000, 0x1F800 * 2);

            m.Memory[(UInt32)(0x1F804 * 2 + 1)] = (byte)(crc >> 8);
            m.Memory[(UInt32)(0x1F804 * 2)] = (byte)(crc & 0xFF); // CRC.
            byte b = (byte)m.Memory[(UInt32)(0x1FC04 * 2)];
            b = (byte)m.Memory[(UInt32)(0x1FC04 * 2 + 1)];
            m.Crop(baseAddr, baseAddr + length);
            return m;
        }

        HexData loadFile(StreamReader reader)
        {
            HexData m = new HexData(reader, true);

            //     byte x = (byte)m.Memory[(UInt32)0x55E00];
            m.Fill32(baseAddr, baseAddr + length, 0x00FFFFFF);
            m.Memory[(UInt32)(0x1F800 * 2)] = (byte)0x23;
            m.Memory[(UInt32)(0x1F800 * 2 + 1)] = (byte)0xCD; // Magic number indicating programmed.
            m.Memory[(UInt32)(0x1F800 * 2 + 2)] = (byte)0x00; // Magic number indicating programmed.
            UInt16 crc = m.Crc16citt(0x8000, 0x1F800 * 2);

            m.Memory[(UInt32)(0x1F804 * 2 + 1)] = (byte)(crc >> 8);
            m.Memory[(UInt32)(0x1F804 * 2)] = (byte)(crc & 0xFF); // CRC.
            byte b = (byte)m.Memory[(UInt32)(0x1FC04 * 2)];
            b = (byte)m.Memory[(UInt32)(0x1FC04 * 2 + 1)];
            m.Crop(baseAddr, baseAddr + length);
            return m;
        }

        public string Status
        {
            get { return status; }
        }
      
    }
}