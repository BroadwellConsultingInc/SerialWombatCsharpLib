using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace SerialWombat
{
    public class SerialWombatAbstractSWI2C : SerialWombatPin
    {

        public SerialWombatAbstractSWI2C(SerialWombatChip serialWombatChip) : base(serialWombatChip)
        {
        }





        private protected void begin(byte pin, SerialWombatPinModes mode)
        {
            begin(pin, (byte)mode);
        }

        private protected void begin(byte pin, byte pinMode)
        {
            _pin = pin;
            _pinMode = pinMode;
        }

        private protected Int16 SWI2C_begin(byte sdaPin, byte bytesPerSWFrame, bool pullUpsEnabled)
        {

            byte[] tx = { (byte)SerialWombatCommands.CONFIGURE_PIN_SWI2C,
        _pin,
        _pinMode,
        0,
        sdaPin, bytesPerSWFrame,
        (byte)(pullUpsEnabled?1:0),
        };

            Int16 result = _sw.sendPacket(tx);

            return (result);

        }
        public Int16 SWI2C_beginTransmission(byte address)
        {

            byte[] tx = { (byte)SerialWombatCommands.CONFIGURE_PIN_SWI2C,
        _pin,
        _pinMode,
        1,
        address,0x55,0x55,0x55
        };

            Int16 result = _sw.sendPacket(tx);

            return (result);

        }
        public Int16 SWI2C_endTransmission(bool stop)
        {

            byte[] tx = { (byte)SerialWombatCommands.CONFIGURE_PIN_SWI2C,
        _pin,
        _pinMode,
        2,
        (byte)(stop?1:0),0x55,0x55,0x55
        };

            Int16 result = _sw.sendPacket(tx);

            return (result);

        }

        public Int16 SWI2C_writeByte(byte data)
        {

            byte[] tx = { (byte)SerialWombatCommands.CONFIGURE_PIN_SWI2C,
        _pin,
        _pinMode,
        3,
        data,0x55,0x55,0x55
        };

            Int16 result = _sw.sendPacket(tx);

            return (result);

        }

        public Int16 SWI2C_requestFrom(byte address, byte quanity, UInt32 iaddress, byte isize, bool stop)
        {

            byte[] tx = { (byte)SerialWombatCommands.CONFIGURE_PIN_SWI2C,
        _pin,
        _pinMode,
        4,
        address,quanity,(byte)(stop?1:0),isize
        };

            Int16 result = _sw.sendPacket(tx);
            if (result < 0)
            {
                return (result);
            }
            if (isize == 0)
            {
                return result;
            }

            byte[] tx2 = { (byte)SerialWombatCommands.CONFIGURE_PIN_SWI2C,
        _pin,
        _pinMode,
        5,
        0x00,0x00,0x00,0x00
        };
            BitConverter.GetBytes(iaddress).CopyTo(tx2, 4);
            return _sw.sendPacket(tx2);

        }


        public Int16 SWI2C_writeBusy(bool busy)
        {

            byte[] tx = { (byte)SerialWombatCommands.CONFIGURE_PIN_SWI2C,
        _pin,
        _pinMode,
        7,
        (byte)(busy?1:0),0x55,0x55,0x55
        };

            Int16 result = _sw.sendPacket(tx);

            return result;
        }

        public bool SWI2C_readBusy()
        {
            bool busy, nackResult;
            byte bytesTransmitted, bytesReceived;
            SWI2C_readStatus(out busy,out bytesTransmitted,out bytesReceived,out nackResult);
            return (busy);
        }
        public Int16 SWI2C_readStatus(out bool busy, out byte bytesTransmitted, out byte bytesReceived,out bool nackResult)
        {

            byte[] tx = { (byte)SerialWombatCommands.CONFIGURE_PIN_SWI2C,
        _pin,
        _pinMode,
        8,
        0x55,0x55,0x55,0x55
        };

            byte[] rx = new byte[8];

            Int16 result = _sw.sendPacket(tx, out rx);
            if (result < 0)
            {
                busy = false;
                bytesReceived = 0;
                bytesTransmitted = 0;
                nackResult = false;

                return result;
            }

            busy = rx[4] > 0;
            bytesTransmitted = rx[5];
            bytesReceived = rx[6];
            nackResult = rx[7] > 0;
            return result;
        }

        public Int16 SW_readRxBuffer(out byte[] data)
        {
            bool nackResult, busy;
            byte bytesReceived, bytesTransmitted;

            Int16 result = SWI2C_readStatus(out busy, out bytesTransmitted, out bytesReceived, out nackResult);
            if (result < 0)
            {
                data = new byte[0];
                return result;
            }
            if (busy || bytesReceived == 0)
            {
                data = new byte[0];
                return result;
            }
            data = new byte[bytesReceived];

            byte[] tx = { (byte)SerialWombatCommands.CONFIGURE_PIN_SWI2C,
        _pin,
        _pinMode,
        9,
        0x55,0x55,0x55,0x55
        };
            byte[] rx = new byte[8];

            result = _sw.sendPacket(tx, out rx);
            if (result < 0)
            {
                data = new byte[0];
                return result;
            }

            for (int i = 0; i < 4 && i < bytesReceived; ++i)
            {
                data[i] = rx[i + 4];
            }

            if (bytesReceived > 4)
            {
                tx[4] = 10;
                result = _sw.sendPacket(tx, out rx);
                if (result < 0)
                {
                    data = new byte[0];
                    return result;
                }

                for (int i = 0; i < 4 && i < bytesReceived; ++i)
                {
                    data[i + 4] = rx[i + 4];
                }
            }
            return result;

        }

    }




}
