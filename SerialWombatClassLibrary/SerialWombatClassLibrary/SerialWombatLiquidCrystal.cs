using System;
using System.Threading;
using System.Collections.Generic;
using System.Text;

namespace SerialWombat
{
    public class SerialWombatLiquidCrystal : SerialWombatPin
    {
        byte[] _offsets = { 0, 64, 20, 84, 0, 64, 20, 84 };
        byte _rows = 2;
        byte _columns = 20;
        byte _rs;
        byte _d4;
        byte _d5;
        byte _d6;
        byte _d7;
        public SerialWombatLiquidCrystal(SerialWombatChip serialWombatChip) : base(serialWombatChip)
        {
            _sw = serialWombatChip;
            _pinMode = (byte)SerialWombatPinModes.PIN_MODE_LIQUIDCRYSTAL;
        }

        public Int16 scrollDisplayLeft()
        {
            return command(0x18); // Display Move left LCD

        }

        public Int16 scrollDisplayRight()
        {
            return command(0x1C); // Display Move right LCD
        }

        public Int16 autoscroll()
        {
            byte[] tx = { (byte)SerialWombatCommands.CONFIGURE_PIN_MODE3,
                    _pin,
                    _pinMode,
                            1, // DisplayMode
					0xFF, // And Mask
					0x01, // OR MASK
					0x55,0x55
    };
            return _sw.sendPacket(tx);
        }

        public Int16 noAutoscroll()
        {
            byte[] tx = { (byte)SerialWombatCommands.CONFIGURE_PIN_MODE3,
                _pin,
                _pinMode,
                        1, // DisplayMode
				(byte)((~0x01)&0xFF), // And Mask
				0x00, // OR MASK
				0x55,0x55
    };
            return _sw.sendPacket(tx);
        }

        public Int16 leftToRight()
        {
            byte[] tx = { (byte)SerialWombatCommands.CONFIGURE_PIN_MODE3,
                _pin,
                _pinMode,
                        1, // DisplayMode
				0xFF, // And Mask
				0x02, // OR MASK
				0x55,0x55
    };
            return _sw.sendPacket(tx);
        }

        public int write(byte data)
        {
            byte[] tx = { (byte)SerialWombatCommands.CONFIGURE_PIN_MODE4,
    _pin,
    (byte)_pinMode,
        2, // Data
		data,
        0x55,
        0x55,
        0x55
    };
            if (_sw.sendPacket(tx) >= 0)
            {
                return 1;
            }
            return 0;
        }

        public int write(string s)
        {
            byte[] b = Encoding.ASCII.GetBytes(s);

            foreach (byte bb in b) //TODO optimize to use less packets
            {
               write(bb);
            }
            return (s.Length);  //TODO check return codes
        }
        public Int16 createChar(byte index, byte[] bitmap)
        {
            if (index >= 8)
            {
                return (-1);
            }
            Int16 result = command((byte)(0x40 | (index << 3))); // Set character ram location
            if (result < 0)
            {
                return result;
            }
            for (int i = 0; i < 8; ++i)
            {
                result = (Int16)write(bitmap[i]);
                if (result < 0)
                {
                    return result;
                }
            }
            return 0;
        }
        public int write(byte[] buffer, int count)
        {
            int sent = 0;
            while (sent - count >= 5)
            {
                byte[] tx = { (byte)SerialWombatCommands.CONFIGURE_PIN_MODE5,
        _pin,
        (byte)_pinMode,
            buffer[sent],
            buffer[sent + 1],
            buffer[sent + 2],
            buffer[sent + 3],
            buffer[sent + 4],
        };
                if (_sw.sendPacket(tx) < 0)
                {
                    return sent;
                }
                sent += 5;
            }
            while (sent < count - 1)
            {
                byte[] tx = { (byte)SerialWombatCommands.CONFIGURE_PIN_MODE4,
        _pin,
        (byte)_pinMode,
            2, // Data
			buffer[sent],
            2, // Data
			buffer[sent + 1],
            0x55
        };
                if (_sw.sendPacket(tx) < 0)
                {
                    return sent;
                }
                sent += 2;
            }
            if (sent < count)
            {
                byte[] tx = { (byte)SerialWombatCommands.CONFIGURE_PIN_MODE4,
           _pin,
          _pinMode,
               2, // Data
			   buffer[sent],
              0x55,
            0x55,
            0x55
        };
                if (_sw.sendPacket(tx) >= 0)
                {
                    ++sent;
                }
            }
            return sent;
        }

        public Int16 rightToLeft()
        {
            byte[] tx = { (byte)SerialWombatCommands.CONFIGURE_PIN_MODE3,
                _pin,
                _pinMode,
                        1, // DisplayMode
				(byte)((~0x02)&0xFF), // And Mask
				0x00, // OR MASK
				0x55,0x55
    };
            return _sw.sendPacket(tx);
        }

        public Int16 setRowOffsets(byte row1, byte row2, byte row3, byte row4)
        {
            _offsets[0] = row1;
            _offsets[1] = row2;
            _offsets[2] = row3;
            _offsets[3] = row4;
            byte[] tx = { (byte)SerialWombatCommands.CONFIGURE_PIN_MODE8,
                _pin,
                _pinMode,
                    0,row1,0x55,0x55
    };
            Int16 result = _sw.sendPacket(tx); if (result < 0) { return result; };
            tx[3] = 1; tx[4] = row2;
            result = _sw.sendPacket(tx); if (result < 0) { return result; };
            tx[3] = 2; tx[4] = row3;
            result = _sw.sendPacket(tx); if (result < 0) { return result; };
            tx[3] = 3; tx[4] = row4;
            result = _sw.sendPacket(tx); if (result < 0) { return result; };
            return (0);
        }

        public Int16 command (int cmd)
        {
            return (command((byte)cmd));
        }
        public Int16 command(byte cmd)
        {
            byte[] tx = { (byte)SerialWombatCommands.CONFIGURE_PIN_MODE4,
    _pin,
   _pinMode,
        1, // Command
		cmd,
        0x55,
        0x55,
        0x55
    };
            return _sw.sendPacket(tx);
        }

        public Int16 initializeBufferCopy(UInt16 bufferIndex, byte width)
        {
            if (width == 255)
            {
                width = _columns;
            }
            byte[] tx = { (byte)SerialWombatCommands.CONFIGURE_PIN_MODE6,
    _pin,
    _pinMode,
        (byte)(bufferIndex & 0xFF),
        (byte)(bufferIndex >>8),
        width,
        0x55,
        0x55,

    };
            return _sw.sendPacket(tx);
        }

        public Int16 beginE2(byte e2Pin)
        {
            byte[] tx = { (byte)SerialWombatCommands.CONFIGURE_PIN_MODE7,
    _pin,
    _pinMode,
        e2Pin,
        0x55,
        0x55,
        0x55,
        0x55,

    };
            return _sw.sendPacket(tx);
        }

        public SerialWombatLiquidCrystal(SerialWombatChip serialWombat, byte rs, byte enable, byte d4, byte d5, byte d6, byte d7) :base(serialWombat)
        {
            _pinMode = (byte)SerialWombatPinModes.PIN_MODE_LIQUIDCRYSTAL;
            _pin = enable;
            _rs = rs;
            _d4 = d4;
            _d5 = d5;
            _d6 = d6;
            _d7 = d7;

        }

        public Int16 begin(byte cols, byte rows)
        {
            byte[] tx = { (byte)SerialWombatCommands.CONFIGURE_PIN_MODE0,
                    _pin,
                    _pinMode,
                    _rs,
                    _d4,
                    _d5,
                    _d6,
                    _d7 };
            Int16 result = _sw.sendPacket(tx);
            if (result < 0)
            {
                return (result);
            }
            _rows = rows;
            _columns = cols;
            result = setRowOffsets(0, 0x40, cols,(byte)( 0x40 + cols));
            if (result < 0)
            {
                return (result);
            }

            return (0);
        }

        public Int16 clear(bool delayAfterClear)
        {
           
            if (delayAfterClear)
            {
                Thread.Sleep(2);
            }
            return command(0x01);  // Clear display
        }

        public Int16 home(bool delayAfterHome)
        {

            if (delayAfterHome)
            {
                Thread.Sleep(2);
            }
            return command(0x02);  // Clear display
        }

        public Int16 setCursor(byte col, byte row)
        {
            if (row >= _rows)
            {
                return -1;
            }

            if (col >= _columns)
            {
                return -1;
            }
            return command((byte)(0x80 + _offsets[row] + col));
        }

        public Int16 noCursor()
        {
            byte[] tx = { (byte)SerialWombatCommands.CONFIGURE_PIN_MODE3,
                    _pin,
                    _pinMode,
                    0, // DisplayControl
					(byte)((~0x02)&0xFF), // And Mask
					0, // OR MASK
					0x55,0x55
    };
            return _sw.sendPacket(tx);
        }

        public Int16 cursor()
        {
            byte[] tx = { (byte)SerialWombatCommands.CONFIGURE_PIN_MODE3,
                    _pin,
                    _pinMode,
                            0, // DisplayControl
					0xFF, // And Mask
					0x02, // OR MASK
					0x55,0x55
    };
            return _sw.sendPacket(tx);
        }

        public Int16 noBlink()
        {
            byte[] tx = { (byte)SerialWombatCommands.CONFIGURE_PIN_MODE3,
                    _pin,
                    _pinMode,
                            0, // DisplayControl

					(byte)((~0x01)& 0xFF), // And Mask
					0, // OR MASK
					0x55,0x55
    };
            return _sw.sendPacket(tx);
        }

        public Int16 display()
        {
            byte[] tx = { (byte)SerialWombatCommands.CONFIGURE_PIN_MODE3,
                        _pin,
                        _pinMode,
                            0, // DisplayControl

						0xFF, // And Mask
						0x04, // OR MASK
						0x55,0x55
    };
            return _sw.sendPacket(tx);
        }

        public Int16 noDisplay()
        {
            byte[] tx = { (byte)SerialWombatCommands.CONFIGURE_PIN_MODE3,
                    _pin,
                    _pinMode,
                            0, // DisplayControl

					(byte)((~0x04)&0xFF), // And Mask
					0, // OR MASK
					0x55,0x55
    };
            return _sw.sendPacket(tx);
        }

        public Int16 blink()
        {
            byte[] tx = { (byte)SerialWombatCommands.CONFIGURE_PIN_MODE3,
                    _pin,
                    _pinMode,
                            0, // DisplayControl

					0xFF, // And Mask
					0x01, // OR MASK
					0x55,0x55
    };
            return _sw.sendPacket(tx);
        }
    }
}
