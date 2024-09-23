using System;
using System.Collections.Generic;
using System.Text;

namespace SerialWombat
{
	public class SerialWombatI2CController : SerialWombatAbstractSWI2C
	{

		public SerialWombatI2CController(SerialWombatChip serialWombatChip) : base(serialWombatChip)
		{
			_sw = serialWombatChip;
		}

		public Int16 begin(byte pin, byte sdaPin, byte bytesPerSWFrame = 8, bool pullUpsEnabled = false)
		{
			_pin = pin;
			base.begin(_pin, SerialWombatPinModes.PIN_MODE_I2C_CONTROLLER);
			byte[] tx = { (byte)SerialWombatCommands.CONFIGURE_PIN_MODE0,
		_pin,
		_pinMode,
		sdaPin, bytesPerSWFrame,
		(byte)(pullUpsEnabled?1:0),
		0x55
		};

			Int16 result = _sw.sendPacket(tx);

			if (result < 0)
			{
				return (result);
			}
			return SWI2C_begin(sdaPin, bytesPerSWFrame, pullUpsEnabled);
		}
	}

}
