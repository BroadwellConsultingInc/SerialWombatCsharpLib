/*
Copyright 2021 Broadwell Consulting Inc.

Serial Wombat is a registered trademark of Broadwell Consulting Inc. in the United States.

Permission is hereby granted, free of charge, to any person obtaining a
 * copy of this software and associated documentation files (the "Software"),
 * to deal in the Software without restriction, including without limitation
 * the rights to use, copy, modify, merge, publish, distribute, sublicense,
 * and/or sell copies of the Software, and to permit persons to whom the
 * Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in
 * all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL
 * THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR
 * OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE,
 * ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
 * OTHER DEALINGS IN THE SOFTWARE.
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace SerialWombat
{
    public class SerialWombatTM1637 : SerialWombatPin
    {
        public enum SWTM1637Mode
        {
            tm1637Decimal16 = 0,  ///< Get the number to display from a pin or data source and display in decimal
            tm1637Hex16 = 1,    ///< Get the number to display from a pin or data source and display in hex
            tm1637CharArray = 2, ///< Display a string sent by the host
            tm1637RawArray = 3, ///<Display raw LED segments sent by the host
            tm1637Animation = 4, /// < Display an animation loaded by the host and clocked out by the Serial Wombat chip
        };



        public SerialWombatTM1637(SerialWombatChip sw) : base(sw)
        {
            _pinMode = (byte)SerialWombatPinModes.PIN_MODE_TM1637;
        }
        public Int16 begin(byte clkPin, byte dioPin, byte digits, SerialWombatTM1637.SWTM1637Mode mode, byte dataSourcePin, byte brightness0to7)
        {
            _pin = clkPin;
            byte[] tx_200 = {
        200, // Pin Set command
		clkPin,
        11, // TM1637
		dioPin,
        digits,
        (byte)mode,
        dataSourcePin,
        brightness0to7,
    };
            Int16 retval = _sw.sendPacket(tx_200);
            return retval;
        }


        public Int16 writeDigitOrder(byte first, byte second, byte third, byte fourth, byte fifth, byte sixth)
        {
            byte[] tx_201 = {
        201, // Pin Set command
		_pin,
        11, // TM1637
		first,
        second,
        third,
        fourth,
        fifth,
    };
            Int16 retval = _sw.sendPacket(tx_201);
            if (retval < 0)
            {
                return retval;
            }
            byte[] tx_202 = {
        202, // Pin Set command
		_pin,
        11, // TM1637
		sixth,
        0x55,
        0x55,
        0x55,
        0x55,
    };
            return _sw.sendPacket(tx_202);
        }

        public Int16 writeArray(string s)
        {
            
            while (s.Length < 6)
            {
                s = s + ' ';
            }
            return writeArray(Encoding.ASCII.GetBytes(s));

        }
        public Int16 writeArray(byte[] data)
        {
            byte[] tx_204 = {
        204, // Pin Set command
		_pin,
        11, // TM1637
		data[0],
        data[1],
        data[2],
        data[3],
        data[4],
    };
            Int16 retval = _sw.sendPacket(tx_204);
            if (retval < 0)
            {
                return retval;
            }
            byte[] tx_205 = {
        205, // Pin Set command
		_pin,
        11, // TM1637
		data[5],
        0x55,
        0x55,
        0x55,
        0x55,
    };
            return _sw.sendPacket(tx_205);
        }

        public  Int16 writeDecimalBitmap(byte decimalBitmapLSBleftDigit)
        {
            byte[] tx_206 = {
        206, // Pin Set command
		_pin,
        11, // TM1637
		decimalBitmapLSBleftDigit,
        0x55,
        0x55,
        0x55,
        0x55,
    };
            return _sw.sendPacket(tx_206);
        }

        public Int16 writeBrightness(byte brightness0to7)
        {
            byte[] tx_203 = {
        203, // Pin Set command
		_pin,
        11, // TM1637
		brightness0to7,
        0x55,
        0x55,
        0x55,
        0x55,
    };
            return _sw.sendPacket(tx_203);
        }

        public Int16 writeAnimation(UInt16 bufferIndex, UInt16 delay, byte numberOfFrames, byte[,] data)
        {
            byte[] data1dim = new byte[data.GetLength(0) * data.GetLength(1)];
            for (int x = 0; x < data.GetLength(0); ++x)
            {
                for (int y = 0; y < 6; ++y)
                {
                    data1dim[x * 6 + y] = data[x,y];
                }
            }


            Int16 result = _sw.writeUserBuffer(bufferIndex, data1dim, (UInt16)(numberOfFrames * 6));

            if (result < 0)
            {
                return result;
            }
            byte[] settings = { (byte)(bufferIndex & 0xFF), (byte)(bufferIndex >> 8), (byte)(delay & 0xFF), (byte)(delay >> 8), numberOfFrames, 0 };
            return writeArray(settings);

        }

        public Int16 suppressLeadingZeros(bool suppress)
        {
            byte[] tx_203 = {
        203, // Pin Set command
		_pin,
        11, // TM1637
		0x55, // Don't change brightness
		suppress?(byte)1:(byte)0,
        0x55,
        0x55,
        0x55,
    };
            return _sw.sendPacket(tx_203);
        }

        public Int16 writeBlinkBitmap(byte decimalBitmapLSBleftDigit)
        {
            byte[] tx_206 = {
        207, // Pin Set command
		_pin,
        11, // TM1637
		decimalBitmapLSBleftDigit,
        0x55,
        0x55,
        0x55,
        0x55,
    };
            return _sw.sendPacket(tx_206);
        }

        public int write(byte data)
        {

            byte[] tx = {
        (byte)SerialWombatCommands.CONFIGURE_PIN_MODE8, // Pin Set command
		_pin,
        _pinMode, // TM1637
		1,
        data,
        0x55,
        0x55,
        0x55,
    };
            if (_sw.sendPacket(tx) < 0)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }

        public Int16 write(byte[] buffer, Int16 size)
        {
            int bufferIndex = 0;
            Int16 initialSize = size;
            if (size > 6)
            {
                bufferIndex += size - 6;
                size = 6;
            }
            if (size > 4)
            {
                byte[] tx = {
        (byte)SerialWombatCommands.CONFIGURE_PIN_MODE8, // Pin Set command
		_pin,
        _pinMode, // TM1637
		4,
        buffer[bufferIndex + 0],
        buffer[bufferIndex + 1],
        buffer[bufferIndex + 2],
        buffer[bufferIndex + 3],
        };
                _sw.sendPacket(tx);
                size -= 4;
                bufferIndex += 4;
            }

            {
                byte[] tx = {
        (byte)SerialWombatCommands.CONFIGURE_PIN_MODE8, // Pin Set command
		_pin,
        _pinMode, // TM1637
		(byte)size,
        buffer[bufferIndex +0],
        size > 1 ? buffer[bufferIndex +1] : (byte)0x55,
        size > 2 ? buffer[bufferIndex +2] : (byte)0x55,
        size > 3 ? buffer[bufferIndex +3] : (byte)0x55,
        };
                _sw.sendPacket(tx);
            }
            return (initialSize);
        }

        public int write(string s)
        {
            byte[] b = Encoding.ASCII.GetBytes(s);

            byte[] b6 = { 0x20, 0x20, 0x20, 0x20, 0x20, 0x20 };
            for (int i = 0; i < 6 && i < b.Length; ++i)
            {
                b6[i] = b[i];
            }
            int len = s.Length;
            if (len > 6) len = 6;
            return (write(b6, (short) len));

        }
    }

}
