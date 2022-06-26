using System;
using System.Collections.Generic;
using System.Text;

namespace SerialWombat
{
	public class SerialWombatServo : SerialWombatPin
	{
		
		UInt16 _position = 0;
		UInt16 _min = 544;  // Default for Arduino Servo library
		UInt16 _max = 2400; // Default for Arduino Servo Library
		bool _reverse = false;

		public SerialWombatServo(SerialWombatChip serialWombatChip):base(serialWombatChip)
		{
			_sw = serialWombatChip;
		}

		public void attach(byte pin)
		{
			_pin = pin;
			initializeServo();


		}

		public void attach(byte pin, bool reverse)
		{
			_pin = pin;
			_reverse = reverse;
			initializeServo();
		}

		public void initializeServo()
		{
			byte[] tx = { 200, _pin, (byte)SerialWombatPinModes.PIN_MODE_SERVO, _pin, (byte)(_position & 0xFF), (byte)((_position >> 8) & 0xFF), _reverse ? (byte)1 : (byte)0, 0x55 };
			byte[] rx;
			_sw.sendPacket(tx, out rx);
			byte[] tx2 = { 201, _pin, (byte)SerialWombatPinModes.PIN_MODE_SERVO, (byte)(_min & 0xFF), (byte)((_min >> 8) & 0xFF), (byte)((_max - _min) & 0xFF), (byte)(((_max - _min) >> 8) & 0xFF), 0x55 };
			_sw.sendPacket(tx2, out rx);

		}
		public void attach(byte pin, UInt16 min, UInt16 max)
		{
			_pin = pin;
			_min = min;
			_max = max;
			initializeServo();
		}

		public void attach(byte pin, UInt16 min, UInt16 max, bool reverse)
		{
			_pin = pin;
			_min = min;
			_max = max;
			_reverse = reverse;
			initializeServo();
		}
		public void write(byte angle)
		{
			if (angle < 180)
			{
				write16bit((UInt16)(65536uL * angle / 180));
			}
			else
			{
				write16bit(65535);
			}

		}
		public byte read()
		{
			UInt32 returnval = _position;
			returnval *= 180;
			return (byte)(returnval >> 16);
		}


		public void write16bit(UInt16 position)
		{
			_position = position;
			_sw.writePublicData(_pin, _position);
		}

		public byte Pin { get { return _pin; } }
	}

    public class SerialWombatServo_18AB:SerialWombatServo
    {
		public SerialWombatAbstractScaledOutput scaledOutput;
		public SerialWombatServo_18AB(SerialWombatChip serialWombatChip) : base(serialWombatChip)
		{
			scaledOutput = new SerialWombatAbstractScaledOutput(serialWombatChip);
		}

		public new void attach(byte pin, UInt16 min, UInt16 max, bool reverse)
        {
			_pin = pin;
			base.attach(_pin, min, max, reverse);
			scaledOutput.begin(_pin, _pinMode);
        }

	}
}
