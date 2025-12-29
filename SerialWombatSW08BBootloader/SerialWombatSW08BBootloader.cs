namespace SerialWombatSW08BBootloader
{
    using System.Threading;
    using SerialWombat;
    using IntelHex;
    using System.Text;

    public class SerialWombatSW08BBootloaderClient
    {
#pragma warning disable CS8605 // Unboxing a possibly null value.

        public SerialWombatChip SerialWombatChip;
        public double PercentDone = 0;
        public bool Bootloading = false;
        public string status = "Not started";
        public string result = "Not completed";
        public bool reset = true;

        uint baseAddr = 0;
        uint length = 0x4000;
        HexData hexData;
        public SerialWombatSW08BBootloaderClient(SerialWombatChip serialWombatChip)
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

            hexData = SerialWombat08BHexProcessor.readAndProcess(hexFile);
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
            if (!SerialWombatChip.inBoot && reset)
            {
                status = "Setting Jump to Boot";
                SerialWombatChip.jumpToBoot();
                Thread.Sleep(100);
                status = "Resetting...";
                SerialWombatChip.hardwareReset();
                Thread.Sleep(2000);

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

            SerialWombatChip.eraseFlashPage(0);
            Thread.Sleep(5000);
            UInt32 address;
            for (address = 0; address < (0x4000); address += 64)
            {
                byte[] page = new byte[64];

                for (int i = 0; i < 64; ++i)
                {
                    page[i] = (byte)hexData.Memory[(UInt32)(address + i)];
                }
                bool dirty = false;
                for (int i = 0; i < 64; i += 1)
                {
                    dirty |= (page[i] != 0xFF);
                }
                if (dirty)
                {
                    SerialWombatChip.writeUserBuffer(0, page, 64);
                    SerialWombatChip.writeFlashRow((UInt32)address + 0x08000000);
                    status = $"Programming address: 0x{address:X4} / 0x4000";
                    Thread.Sleep(0);
                }
                else
                {
                    status = $"Skipping blank Row  0x{address:X8}";
                }
                PercentDone = ((double)(address - baseAddr)) / length;
            }

            //Verify step
            bool mismatch = false;
            for (address = 0; address < (0x4000); address += 64)
            {
                byte[] page = new byte[64];

                for (int i = 0; i < 64; i += 4)
                {

                    byte[] tx = {161,// Read flash
                        0,0,0,0,// Address
                        0x55,0x55,0x55
                    };
                    byte[] a = BitConverter.GetBytes((UInt32)(address + i + 0x08000000));
                    status = $"Verifying Address  0x{address:X4}";
                    a.CopyTo(tx, 1);
                    byte[] rx = new byte[8];
                    SerialWombatChip.sendPacket(tx, out rx);

                    page[i] = rx[4];
                    page[i + 1] = rx[5];
                    page[i + 2] = rx[6];
                    page[i + 3] = rx[7];
                }

                for (int i = 0; i < 64; i += 1)
                {
                    byte b = (byte)hexData.Memory[(UInt32)(i + address)];
                    if (page[i] != b)
                    {
                        mismatch = true;
                    }
                }
                if (mismatch)
                {

                    status = $"Programming verify failed at: line 0x{address:X8}";
                    Thread.Sleep(0);
                }

                PercentDone = ((double)(address - baseAddr)) / length;
            }

            if (!mismatch)
            {
                byte[] tx = { 164, 4, 0, 0, 0, 0, 0, 0 }; // Set boot flag

                SerialWombatChip.sendPacket(tx);
                Thread.Sleep(100);
                SerialWombatChip.hardwareReset();
                Bootloading = false;
                status = $"Done. Success.";
            }
        }
        HexData loadFile(string hexFile)
        {
            HexData m = new HexData(hexFile, true);

            //     byte x = (byte)m.Memory[(UInt32)0x55E00];
            m.Fill32(baseAddr, baseAddr + length, 0x00FFFFFF);
            m.Crop(baseAddr, baseAddr + length);
            return m;
        }

        HexData loadFile(StreamReader reader)
        {
            HexData m = new HexData(reader, true);
            m.Fill32(baseAddr, baseAddr + length, 0x00FFFFFF);
            m.Crop(baseAddr, baseAddr + length);
            return m;
        }

        public string Status
        {
            get { return status; }
        }

    }

    public static class SerialWombat08BHexProcessor
    {
        public static HexData readAndProcess (string fileName)
        {
            HexData m = new HexData(fileName, false);

            m.Memory[(UInt32)0x3FFC] = (byte)0x11;  // Magic number to indicate boot programmed
            m.Memory[(UInt32)0x3FFD] = (byte)0x01;
            m.Memory[(UInt32)0x3FFE] = (byte)0x25;
            m.Memory[(UInt32)0x3FFF] = (byte)0x20;
            m.Fill32(0, 16384, 0xFFFFFFFF);
            m.Crop(0, 16384);
            return m;
        }

        
    }
}