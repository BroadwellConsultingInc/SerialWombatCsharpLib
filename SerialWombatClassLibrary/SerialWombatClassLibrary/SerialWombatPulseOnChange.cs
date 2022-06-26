using System;
using System.Collections.Generic;
using System.Text;
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
    /*! \brief Monitors other pin(s) or public data in the Serial Wombat chip and generates a pin pulse on change

This class controls the Pulse on Change pin mode of the Serial Wombat Chip.  Pulse on Change is useful to generate
a pulse that can drive an interrupt on the host Arduino, or for creating user alerts such as LED pulses or buzzer tones
that acknowledge data reception or human input.

For instance, a pulse could be generated when the output value of a rotary encoder state machine on other pins changes value.
Or an LED could be pulsed to command traffic on the Serial Wombat chip by making it pulse when SW_DATA_SOURCE_PACKETS_RECEIVED 
changes.

Reference the Public Data and Pin Modes section on the main page to learn more about public data and how public data on the 
Serial Wombat chip works.

The each pin can monitor up to 8 other pins or data sources for changes.  A pulse will be generated when any of the criteria (orNotAnd == 1) or
all (simultaneously) of the criteria (orNotAnd == 0)  are met.  Criteria can be any of the following:

- Pin data or public data changed 
- Pin data or public data increased 
- Pin data or public data decreased 
- Pin data or public data equals a fixed value 
- Pin data or public data below a fixed value 
- Pin data or public data above a fixed value 
- Pin data or public data not equal to a fixed value 
- Pin data or public data crosses a fixed value
- Pin data or public data crosses (ascending) a fixed value
- Pin data or public data crosses (descending) a fixed value
- Pin data or public data equals another pin
- Pin data or public data below another pin
- Pin data or public data above another pin
- Pin data or public data not equal to another pin
- Pin data or public data is within a range
- Pin data or public data is outside a range


A video Tutorial on this pin mode is available:

\htmlonly
TODO
\endhtmlonly


TODO https://youtu.be/


*/

    class SerialWombatPulseOnChange : SerialWombatPin
    {
        public SerialWombatPulseOnChange(SerialWombatChip serialWombatChip) : base(serialWombatChip)
        {
            _pinMode =(byte) SerialWombatPinModes.PIN_MODE_PULSE_ON_CHANGE;
        }
		public Int16 begin(byte pin, SerialWombatPinStates activeMode, SerialWombatPinStates inactiveMode, UInt16 pulseOnTime, UInt16 pulseOffTime, byte orNotAnd, UInt16 PWMperiod, UInt16 PWMdutyCycle)
		{
			Int16 result;
			_pin = pin;

			{
				byte[] tx = { (byte)SerialWombatCommands.CONFIGURE_PIN_MODE0,
						_pin,
						_pinMode,
						(byte)activeMode,
						(byte)inactiveMode,
						orNotAnd,
						0x55,
						0x55
		};
				result = _sw.sendPacket(tx);
				if (result < 0) { return result; }
			}
			{
				byte[] tx = { (byte)SerialWombatCommands.CONFIGURE_PIN_MODE1,
						_pin,
						_pinMode,
						(byte)(pulseOnTime & 0xFF),(byte)(pulseOnTime >>8),
			(byte)(pulseOffTime & 0xFF),(byte)(pulseOffTime >>8),
						0x55
		};
				result = _sw.sendPacket(tx);
				if (result < 0) { return result; }
			}
			{
				byte[] tx = { (byte)SerialWombatCommands.CONFIGURE_PIN_MODE2,
						_pin,
						_pinMode,
						(byte)(PWMperiod & 0xFF),(byte)(PWMperiod >>8),
			(byte)(PWMdutyCycle & 0xFF),(byte)(PWMdutyCycle >>8),
						0x55
		};
				result = _sw.sendPacket(tx);
				if (result < 0) { return result; }
			}
			return (0);
		}

		public Int16 setEntryOnChange(byte entryID, byte sourcePin)
		{
			return setEntryMode(entryID, sourcePin, 0);
		}

		public Int16 setEntryOnIncrease(byte entryID, byte sourcePin)
		{
			return setEntryMode(entryID, sourcePin, 1);
		}

		public Int16 setEntryOnDecrease(byte entryID, byte sourcePin)
		{
			return setEntryMode(entryID, sourcePin, 2);
		}

		public Int16 setEntryOnEqualValue(byte entryID, byte sourcePin, UInt16 value)
		{
			Int16 result = setEntryParams(entryID, value, 0); if (result < 0) return result;
			return setEntryMode(entryID, sourcePin, 3);
		}

		public Int16 setEntryOnLessThanValue(byte entryID, byte sourcePin, UInt16 value)
		{
			Int16 result = setEntryParams(entryID, value, 0); if (result < 0) return result;
			return setEntryMode(entryID, sourcePin, 4);
		}

		public Int16 setEntryOnGreaterThanValue(byte entryID, byte sourcePin, UInt16 value)
		{
			Int16 result = setEntryParams(entryID, value, 0); if (result < 0) return result;
			return setEntryMode(entryID, sourcePin, 5);
		}

		public Int16 setEntryOnNotEqualValue(byte entryID, byte sourcePin, UInt16 value)
		{
			Int16 result = setEntryParams(entryID, value, 0); if (result < 0) return result;
			return setEntryMode(entryID, sourcePin, 6);
		}

		public Int16 setEntryOnPinsEqual(byte entryID, byte sourcePin, byte secondPin)
		{
			Int16 result = setEntryParams(entryID, secondPin, 0); if (result < 0) return result;
			return setEntryMode(entryID, sourcePin, 7);
		}

		public Int16 setEntryOnPinsNotEqual(byte entryID, byte sourcePin, byte secondPin)
		{
			Int16 result = setEntryParams(entryID, secondPin, 0); if (result < 0) return result;
			return setEntryMode(entryID, sourcePin, 10);
		}

		 Int16 setEntryParams(byte entryID, UInt16 firstParam, UInt16 secondParam)
		{
			{
				Int16 result;
				byte[] tx = { (byte)SerialWombatCommands.CONFIGURE_PIN_MODE3,
						_pin,
						_pinMode,
						entryID,
						(byte)(firstParam & 0xFF),(byte)(firstParam >>8),
						(byte)(secondParam & 0xFF),(byte)(secondParam >>8),
		};
				result = _sw.sendPacket(tx);
				if (result < 0) { return result; }
			}
			return 0;
		}

		 Int16 setEntryMode(byte entryID, byte pin, byte mode)
		{
			{
				Int16 result;
				byte[] tx = { (byte)SerialWombatCommands.CONFIGURE_PIN_MODE4,
						_pin,
						_pinMode,
						entryID,
						mode,
						pin,

			0x55,
			0x55
		};
				result = _sw.sendPacket(tx);
				if (result < 0) { return result; }
			}
			return 0;
		}



	}
}
