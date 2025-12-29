using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SerialWombat
{
    public class SerialWombatIRRx : SerialWombatPin
    {

        UInt32 timeout = 5000;

      

        public SerialWombatIRRx(SerialWombatChip serialWombatChip) : base(serialWombatChip)
        {
            _sw = serialWombatChip;
            _pinMode = (byte)SerialWombatPinModes.PIN_MODE_IR_RX;
        }
        public Int16 begin(byte pin, byte irMode = 0, bool useRepeat = true, SerialWombatPinStates activeState = SerialWombatPinStates.SW_LOW,
            UInt16 publicDataTimeoutPeriod_mS = 1000, UInt16 publicDataTimeoutValue = 0xFFFF, bool useAddressFilter = false, UInt16 addressFilterValue = 0x1234, 
            SerialWombatIRRxPublicDataOutput dataOutput = SerialWombatIRRxPublicDataOutput.Command)
        {
            _pin = pin;
            Int16 returnValue = 0;

            {
                byte[] tx = { 200, _pin, _pinMode, irMode,
                        useRepeat ? (byte)1 : (byte)0,
                        activeState == SerialWombatPinStates.SW_LOW ? (byte)0 : (byte)1,
                        (byte)(addressFilterValue & 0xFF), (byte)((addressFilterValue >> 8) & 0xFF), };
                byte[] rx;
                returnValue = _sw.sendPacket(tx, out rx);
                if (returnValue < 0)
                {
                    return returnValue;
                }
            }
            {
                byte[] tx = { 201, _pin, _pinMode, (byte)(publicDataTimeoutPeriod_mS & 0xFF), (byte)((publicDataTimeoutPeriod_mS >> 8) & 0xFF),
                     (byte)(publicDataTimeoutValue & 0xFF), (byte)((publicDataTimeoutValue >> 8) & 0xFF),  useAddressFilter ? (byte)1 : (byte)0
                    };

                byte[] rx;
                returnValue = _sw.sendPacket(tx, out rx);

                if (returnValue < 0)
                {
                    return returnValue;
                }

            }
            {
                byte[] tx = { 205, _pin, _pinMode, (byte)dataOutput,0x55,0x55,0x55,0x55 };

                byte[] rx;
                returnValue = _sw.sendPacket(tx, out rx);

                return returnValue;

            }


        }

        public int available()
        {
            byte[] tx = { 203, _pin, _pinMode,0x55, 0x55, 0x55, 0x55, 0x55 };
            byte[] rx;
            _sw.sendPacket(tx, out rx);
            return (rx[4]);
        }

        public int read()
        {
            byte[] tx = { 202, _pin, _pinMode, 1, 0x55, 0x55, 0x55, 0x55 };
            byte[] rx;
            if (_sw.sendPacket(tx, out rx) < 0)
            {
                return -1;
            }

            if (rx[3] != 0)
            {
                return (rx[4]);
            }
            else
            {
                return (-1);
            }
        }

        public void flush()
        {
            byte[] tx = { 202, _pin, _pinMode, 4, 0x55, 0x55, 0x55, 0x55 };
            byte[] rx;
            _sw.sendPacket(tx, out rx);  // Buffer limit is 16, so read 4 bytes 4 times
            _sw.sendPacket(tx, out rx);
            _sw.sendPacket(tx, out rx);
            _sw.sendPacket(tx, out rx);
        }

        public int peek()
        {
            byte[] tx = { 203, _pin, _pinMode, 0x55, 0x55, 0x55, 0x55, 0x55 };
            byte[] rx;
            _sw.sendPacket(tx, out rx);
            if (rx[4] > 0)
            {
                return (rx[5]);
            }
            else
            {
                return (-1);
            }
        }

       

        public void setTimeout(long timeout_mS)
        {
            if (timeout_mS == 0)
            {
                timeout = 0x80000000;
            }
            else
            {
                timeout = (UInt32)timeout_mS;
            }
        }

        public int readBytes(byte[] buffer, int length)
        {
            int index = 0;
            int bytesAvailable = 0;
            DateTime timeoutMillis = DateTime.Now + new TimeSpan(0, 0, 0, 0, (int)timeout);
            while (length > 0 && timeoutMillis > DateTime.Now)
            {
                int bytecount = 4;
                if (length < 4)
                {
                    bytecount = length;
                }
                {

                    byte[] tx = { 202, _pin, _pinMode, (byte)bytecount, 0x55, 0x55, 0x55, 0x55 };
                    byte[] rx;
                    _sw.sendPacket(tx, out rx);
                    bytesAvailable = rx[3];

                    if (bytesAvailable == 0)
                    {
                        continue;
                    }
                    else
                    {
                        timeoutMillis = DateTime.Now + new TimeSpan(0, 0, 0, 0, (int)timeout);
                    }
                    byte bytesReturned = (byte)bytecount;
                    if (rx[3] < bytecount)
                    {
                        bytesReturned = rx[3];
                    }
                    for (int i = 0; i < bytesReturned; ++i)
                    {
                        buffer[index] = rx[i + 4];
                        ++index;
                        --bytesAvailable;
                        --length;

                    }
                }
               

            }

            return (index);
       
        }

            public UInt16 readLastAddress()
        {
            byte[] tx = { 204, _pin, _pinMode, 0x55, 0x55, 0x55, 0x55, 0x55 };
            byte[] rx;
            _sw.sendPacket(tx, out rx);
            return ((UInt16)(256 * rx[4] + rx[3]));
        }
    }

    public enum SerialWombatIRRxPublicDataOutput
    {
        Command = 0,
        Address = 1,
        ReceivedDataCount = 2
    }

}
