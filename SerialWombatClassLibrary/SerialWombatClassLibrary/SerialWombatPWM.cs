using System;
using System.Collections.Generic;
using System.Text;

namespace SerialWombat
{
    public class SerialWombatPWM
    {
		SerialWombatChip _sw;
		byte _pin = 255;

		public 		 SerialWombatPWM(SerialWombatChip serialWombatChip)
{
				_sw = serialWombatChip;
}

public 	void  begin(byte pin)
	{
		begin(pin, 0, false);
	}
public 	void  begin(byte pin, UInt16 dutyCycle)
	{
		begin(pin, dutyCycle, false);
	}


public 	void  begin(byte pin, UInt16 dutyCycle, bool invert)
	{
		_pin = pin;
		byte[] tx = { (byte)SerialWombatCommands.CONFIGURE_PIN_MODE0, _pin, (byte)SerialWombatPinModes.PIN_MODE_PWM, _pin, (byte)(dutyCycle & 0xFF), (byte)(dutyCycle >> 8), invert?(byte)1:(byte)0, 0x55 };
		_sw.sendPacket(tx);
	}
public 	void   writeDutyCycle(UInt16 dutyCycle)
	{
		byte[] tx = { (byte)SerialWombatCommands.COMMAND_BINARY_SET_PIN_BUFFFER, _pin, (byte)(dutyCycle & 0xFF), (byte)(dutyCycle >> 8), 255, 0x55, 0x55 };
		_sw.sendPacket(tx);
	}



public 	void  setFrequency_SW18AB_Hz(UInt32 frequency_Hz)
	{
		UInt32 uS = (1000000 / frequency_Hz);

		byte[] tx = { 220, _pin, (byte)SerialWombatPinModes.PIN_MODE_PWM, (byte)(uS & 0xFF), (byte)((uS >> 8) & 0xFF), (byte)((uS >>16) & 0xFF), (byte) ((uS >> 24) & 0xFF), 0x55 };
		_sw.sendPacket(tx);

	}

public 	void  setPeriod_SW18AB_uS(UInt32 period_uS)
	{
		byte[] tx = { 220, _pin, (byte)SerialWombatPinModes.PIN_MODE_PWM, (byte)(period_uS & 0xFF), (byte)((period_uS >> 8) & 0xFF), (byte)((period_uS >>16) & 0xFF), (byte) ((period_uS >> 24) & 0xFF), 0x55 };
		_sw.sendPacket(tx);
	}

		public byte Pin { get { return _pin; } }
	}
}
