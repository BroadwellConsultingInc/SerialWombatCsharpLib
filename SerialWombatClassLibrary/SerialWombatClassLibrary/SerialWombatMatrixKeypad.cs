using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

/*
Copyright 2022 Broadwell Consulting Inc.

"Serial Wombat" is a registered trademark of Broadwell Consulting Inc. in
the United States.  See SerialWombat.com for usage guidance.

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


namespace SerialWombat
{
	/*! \brief A class for the Serial Wombat SW18AB chips which scans matrix keypads up to 4x4



A Tutorial video is avaialble:

https://youtu.be/hxLda6lBWNg
\htmlonly
<iframe width="560" height="315" src="https://www.youtube.com/embed/hxLda6lBWNg" 
title="YouTube video player" frameborder="0" allow="accelerometer; autoplay; 
clipboard-write; encrypted-media; gyroscope; picture-in-picture" allowfullscreen></iframe>
\endhtmlonly



The class inherits from the Arduino Stream class, so queued kepad presses can be read like a
Serial port.

This class allows the user to declare up to 4 row and 4 column pins which are strobed continuously
to read up to 16 buttons.  The Serial Wombat chip's internal pull-up resistors are used so no additional
hardware is necesary.  Standard matrix keypads can be attached directly to the Serial Wombat chip pins.
All Serial Wombat 18AB chip pins can be used in any combination or order.

Results can be returned to the host as a binary 16 bit number indicating the state of 16 buttons, 
as an index indicating which button is currently pressed (0 for Col 0 Row 0,  3 for Col 3 Row 3 and
12 for Col 0 Row 3, or as ASCII values which assume a standard keypad layout.

Index mode:

    |0  1  2  3 |
    |4  5  6  7 |
    |8  9  10 11|
    |12 13 14 15|
    With 16 being used for no current press, depending on mode setting

Ascii Mode:

    |1 2 3 A|
    |4 5 6 B|
    |7 8 9 C|
    |* 0 # D|

Note that the key indexes remain the same regardless of how many rows and columns are enabled.

The Serial Wombat 18AB firmware also keeps track of button transition counts and time since last
transition for all 16 buttons.  In this way each key of the keypad can be treated equivalently to
a SerialWombatDebouncedInput class when encapsulated in a SerialWombatMatrixInput class.  See the
documentation on this class and Arduino examples for details.

The 16 Bit public data presented internally to other Serial Wombat pins and through the SerialWombatChip.readPublicData
method can be configured to present the binary state of 16 buttons, the last button index pressed, 
the last button index pressed or 16 if no button is pressed, or ASCII of last button pressed.

*/


	public class SerialWombatMatrixKeypad : SerialWombatPin
	{
		UInt32 timeout = 0x80000000;

		DateTime StartTime = DateTime.Now;

		UInt32 millis() { return ((UInt32)(DateTime.Now - StartTime).TotalMilliseconds); }
		public SerialWombatMatrixKeypad(SerialWombatChip serialWombatChip) : base(serialWombatChip)
		{
			_pinMode = (byte)SerialWombatPinModes.PIN_MODE_MATRIX_KEYPAD;

		}

		/// \brief Initalize the SerialWombatMatrixKeypad.  
		/// \param controlPin Keypad scanning transitions will occur while this pin is being serviced by the Serial Wombat executive.  Typically this will be the same as the row0 pin
		/// \param row0pin pin attached to the topmost keypad row.  On many marked keypads this row has 1,2,3 and A in it.  Enter 255 if this column is unused
		/// \param row1pin pin attached to the topcenter keypad row.  On many marked keypads this row has 4,5,6 and B in it.  Enter 255 if this row is unused
		/// \param row2pin pin attached to the topmost keypad row.  On many marked keypads this row has 7,8,9 and C in it.  Enter 255 if this row is unused
		/// \param row3pin pin attached to the topmost keypad row.  On many marked keypads this row has *,0,# and D in it.  Enter 255 if this row is unused
		/// \param column0pin pin attached to the leftmost keypad column.  On many marked keypads this column has 1,4,7 and * in it.  Enter 255 if this column is unused
		/// \param column1pin pin attached to the leftcenter keypad column.  On many marked keypads this column has 1,5,8 and 0 in it. Enter 255 if this column is unused
		/// \param column2pin pin attached to the rightcenter keypad column.  On many marked keypads this column has 3,5,9 and # in it. Enter 255 if this column is unused
		/// \param column3pin pin attached to the rightmost keypad column.  On many marked keypads this column has A,B,C and D in it. Enter 255 if this column is unused
		/// \param bufferMode 0: Public data is Binary of 16 keys (Default)  1:  Public data is last key index pressed  2:  Public data is last key pressed or 16 for no key index  3: Public data is Ascii of last key pressed 
		/// \param queueMode 0: Button presses are queued as indexes 1: Button Presses are queued as ASCII

		public Int16 begin(int controlPin, int row0pin, int row1pin, int row2pin, int row3pin, int column0pin, int column1pin, int column2pin, int column3pin, int bufferMode = 0, int queueMode = 1)
        {
			return begin((byte)controlPin, (byte)row0pin, (byte)row1pin, (byte)row2pin, (byte)row3pin, (byte)column0pin, (byte)column1pin, (byte)column2pin, (byte)column3pin, (byte)bufferMode, (byte)queueMode);

		}

		/// \brief Initalize the SerialWombatMatrixKeypad.  
		/// \param controlPin Keypad scanning transitions will occur while this pin is being serviced by the Serial Wombat executive.  Typically this will be the same as the row0 pin
		/// \param row0pin pin attached to the topmost keypad row.  On many marked keypads this row has 1,2,3 and A in it.  Enter 255 if this column is unused
		/// \param row1pin pin attached to the topcenter keypad row.  On many marked keypads this row has 4,5,6 and B in it.  Enter 255 if this row is unused
		/// \param row2pin pin attached to the topmost keypad row.  On many marked keypads this row has 7,8,9 and C in it.  Enter 255 if this row is unused
		/// \param row3pin pin attached to the topmost keypad row.  On many marked keypads this row has *,0,# and D in it.  Enter 255 if this row is unused
		/// \param column0pin pin attached to the leftmost keypad column.  On many marked keypads this column has 1,4,7 and * in it.  Enter 255 if this column is unused
		/// \param column1pin pin attached to the leftcenter keypad column.  On many marked keypads this column has 1,5,8 and 0 in it. Enter 255 if this column is unused
		/// \param column2pin pin attached to the rightcenter keypad column.  On many marked keypads this column has 3,5,9 and # in it. Enter 255 if this column is unused
		/// \param column3pin pin attached to the rightmost keypad column.  On many marked keypads this column has A,B,C and D in it. Enter 255 if this column is unused
		/// \param bufferMode 0: Public data is Binary of 16 keys (Default)  1:  Public data is last key index pressed  2:  Public data is last key pressed or 16 for no key index  3: Public data is Ascii of last key pressed 
		/// \param queueMode 0: Button presses are queued as indexes 1: Button Presses are queued as ASCII

		public Int16 begin(byte controlPin, byte row0pin, byte row1pin, byte row2pin, byte row3pin, byte column0pin, byte column1pin, byte column2pin, byte column3pin, byte bufferMode = 0, byte queueMode = 1,byte rowDelay = 5)
		{
			_pin = controlPin;

			byte[] tx = { (byte)SerialWombatCommands.CONFIGURE_PIN_MODE0,
						_pin,
						(byte)_pinMode ,
						row0pin,
						row1pin,
						row2pin,
						row3pin,
						column0pin };
			Int16 result = _sw.sendPacket(tx);
			if (result < 0)
			{
				return result;
			}

			byte[] tx5 = { (byte)SerialWombatCommands.CONFIGURE_PIN_MODE5,
						_pin,
						(byte)_pinMode ,
						column1pin,
						column2pin,
						column3pin,
						bufferMode,
						queueMode };
            result = _sw.sendPacket(tx5);
            if (result < 0)
            {
                return result;
            }

            byte[] tx8 = { (byte)SerialWombatCommands.CONFIGURE_PIN_MODE8,
                        _pin,
                        (byte)_pinMode ,
                        rowDelay,
                        0x55,
                        0x55,
                        0x55,
                        0x55 };
            result = _sw.sendPacket(tx8);
            if (result < 0)
            {
                return result;
            }


            return _sw.sendPacket(tx8);
		}

		/// \brief Set a binary mask for which keys are added to Queue
		/// 
		/// This commands allows exclusion of keys from being queued.  This
		/// can be useful if, for instance, only the numeric keys of a keypad
		/// are to be added to the queue (excluding #,*, ABCD, etc) 
		/// 
		/// \param mask  A 16 bit bitmap where a 1 allows queuing of that key index 
		/// and a 0 does not.  Index 0 is LSB.  For instance, for a typical Phone/ABCD
		/// keypad, a mask of 0x2777 would allow the numeric keys to be added to the 
		/// queue but would exclude ABCD#* .
		/// \return Returns 0 or higher if successfully set or a negative error code otherwise
		public Int16 writeQueueMask(UInt16 mask)
		{
			byte[] tx = { (byte)SerialWombatCommands.CONFIGURE_PIN_MODE7,
		_pin, (byte)_pinMode,
		(byte)(mask & 0xFF),(byte)(mask>>8),0x55,0x55,0x55 };
			return _sw.sendPacket(tx);
		}

		public Int16 writeAsciiTable(byte tableIndex, byte asciiValue)
		{
            byte[] tx = { (byte)SerialWombatCommands.CONFIGURE_PIN_MODE9,
				_pin, (byte)_pinMode,
				tableIndex,asciiValue,0x55,0x55,0x55 };
            return _sw.sendPacket(tx);
        }

		/// \brief Queries the SerialWombatMatrixKeypad for number bytes available to read
		/// \return Number of bytes available to read
		public int available()
		{
			byte[] tx = { 201, _pin, (byte)_pinMode, 0, 0x55, 0x55, 0x55, 0x55 };
			byte[] rx;
			_sw.sendPacket(tx, out rx);
			return (rx[4]);
		}
		/// \brief Reads a byte from the SerialWombatMatrixKeypad queue
		/// \return A byte from 0-255, or -1 if no bytes were avaialbl
		public int read()
		{
			byte[] tx = { 202, _pin, (byte)_pinMode, 1, 0x55, 0x55, 0x55, 0x55 };
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

		}

		public int peek()
		{
			byte[] tx = { 203, _pin, (byte)_pinMode, 0x55, 0x55, 0x55, 0x55, 0x55 };
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

		public int write(byte data)
		{

			return (1);
		}

		public int write(byte[] buffer, int size)
		{
			return (size);
		}

		public int availableForWrite()
		{
			return (0);
		}

		public void setTimeout(UInt32 timeout_mS)
		{
			if (timeout_mS == 0)
			{
				timeout = 0x80000000;
			}
			else
			{
				timeout = timeout_mS;
			}
		}



		public int readBytes(ref byte[] buffer, int length)
		{
			int index = 0;
			int bytesAvailable = 0;
			UInt32 timeoutMillis = millis() + timeout;
			while (length > 0 && timeoutMillis > millis())
			{
				int bytecount = 4;
				if (length < 4)
				{
					bytecount = length;
				}
				{

					byte[] tx = { 202, _pin, (byte)_pinMode, (byte)bytecount, 0x55, 0x55, 0x55, 0x55 };
					byte[] rx;
					_sw.sendPacket(tx, out rx);
					bytesAvailable = rx[3];

					if (bytesAvailable == 0)
					{
						continue;
					}
					else
					{
						timeoutMillis = millis() + timeout;
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
	}

	public class SerialWombatMatrixButton : SerialWombatAbstractButton
	{
		SerialWombatMatrixKeypad _keypad;
		byte _keyIndex;
		public SerialWombatMatrixButton(SerialWombatMatrixKeypad kp, byte keyIndex) : base(kp._sw)
		{
			_pinMode = kp.swPinModeNumber;
			_pin = kp.pin;
			_keypad = kp;
			_keyIndex = keyIndex;

		}

		override public bool digitalRead()
		{
			byte[] tx = { (byte)SerialWombatCommands.CONFIGURE_PIN_MODE6,
					_keypad.pin,
					_pinMode,
					0,
					_keyIndex,0x55,0x55,0x55 };
			byte[] rx;
			int result = _keypad._sw.sendPacket(tx, out rx);
			if (result >= 0)
			{
				transitions = (UInt16)(rx[4] + 256 * rx[5]);

				return (rx[3] > 0);
			}
			return (false);
		}

		override public UInt16 readDurationInFalseState_mS()
		{
			byte[] tx = { (byte)SerialWombatCommands.CONFIGURE_PIN_MODE6,
					_keypad.pin,
					_pinMode,
					0,
					_keyIndex,0x55,0x55,0x55 };
			byte[] rx;
			int result = _keypad._sw.sendPacket(tx, out rx);
			if (result >= 0)
			{
				transitions = (UInt16)(rx[4] + 256 * rx[5]);
				UInt16 time = (UInt16)(rx[6] + 256 * rx[7]);
				if (rx[3] == 0)
				{
					return (time);
				}
			}
			return (0);
		}

		override public UInt16 readDurationInTrueState_mS()
		{
			byte[] tx = { (byte)SerialWombatCommands.CONFIGURE_PIN_MODE6,
					_keypad.pin,
					_pinMode,
					0,
					_keyIndex,0x55,0x55,0x55 };
			byte[] rx;
			int result = _keypad._sw.sendPacket(tx, out rx);
			if (result >= 0)
			{
				transitions = (UInt16)(rx[4] + 256 * rx[5]);
				UInt16 time = (UInt16)(rx[6] + 256 * rx[7]);
				if (rx[3] == 1)
				{
					return (time);
				}
			}
			return (0);
		}

		override public bool readTransitionsState(bool resetTransitions = true)
		{
			return digitalRead();
		}

	}
}

