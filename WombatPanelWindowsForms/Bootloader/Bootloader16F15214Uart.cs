using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Text;
using IntelHex;

namespace WombatPanelWindowsForms.Bootloader
{
    class Bootloader16F15214Uart
    {
        private SerialPort _port;
       
        public void DownloadHex(string filename, SerialPort port)
        {
            string s;
            double d;
            DownloadHex(filename, port, out s, out d);
        }
        public void DownloadHex(string filename, SerialPort port, out string statusString , out double percentComplete )
        {

            try
            {
                _port = port;
                HexData data = new HexData(filename, true);
                data.Crop(0x140 * 2, 0x1000 * 2);
                data.Fill16(0x140 * 2, 0x1000 * 2, 0x3FFF);
                percentComplete = 0;

                _port.ReadTimeout = 2000;
                statusString = "Initiating...";

                InitiateDownload();
                statusString = "Erasing...";
                WaitForEraseCompletion();
                statusString = "Writing...";
                SendHex(data, 64, out percentComplete);
                statusString = "Verifying";
                Verify(data, out percentComplete);
                statusString = "Success.  Cycle Power to leave bootloader.";
            }
            catch (Exception ex)
            {
                percentComplete = 0;
                statusString = ex.Message;
            }


        }

        private bool InitiateDownload()
        {
            byte[] startSequence = { 0x52, 0xA3, 0x4D, 0xF6 };
            // byte[] startSequence = { 0x55 , 0xCC, 0x44, 0x80 };

            _port.DiscardInBuffer();
            _port.Write(startSequence, 0, 4);
            int priorTimout = _port.ReadTimeout;
            _port.ReadTimeout = 50; // 50 ms
           
                byte b = (byte)_port.ReadByte();
                _port.ReadTimeout = priorTimout;
                return (b == 'e');
           
           

        }

        private bool WaitForEraseCompletion()
        {

           
                byte b = (byte)_port.ReadByte();
                return (b == 'W');
           
                
           
        }

        private bool SendHex(HexData data, uint pagesize, out double progress)
        {
            progress = 0;
            for (uint i = data.LowestAddress; i < data.HighestAddress; i += pagesize)
            {
                _port.Write(data.Subarray(i, pagesize), 0, (int)pagesize);
               
                progress = 100 * i / (data.HighestAddress - data.LowestAddress);
               
                int b = _port.ReadByte();
                if (b != (int)'W')
                {
                    return false;
                }

            }

            return (true);
        }

        private bool Verify(HexData data, out double progress)
        {
            uint highestAddress = data.HighestAddress;
            uint lowestAddress = data.LowestAddress;
            uint length = (highestAddress - lowestAddress + 1);

            byte[] incomingdata = new byte[length];
            int count = 0;
            byte Rbyte = (byte)_port.ReadByte();
            
            while (count < length)
            {
                if (_port.BytesToRead > 0)
                {
                    incomingdata[count] = (byte)_port.ReadByte();
                    ++count;
                   
                        progress  = 100 * (count / highestAddress - lowestAddress);

                }
            }

            for (count = 0; count < length; ++count)
            {
                byte m = (byte)data.Memory[(uint)(count + lowestAddress)];
                byte ic = incomingdata[count];
                int address = (int)(count + lowestAddress) / 2;
                if (m != ic)
                {
                    progress = 0;
                    throw new Exception(
                    $"Verify failed at byte 0x{count + lowestAddress:X2}, expected 0x{m:X2}, got 0x{ic:X2}");
                }
            }

            progress = 100;
            return (true);
        }
    }
}
