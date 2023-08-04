using System;
using System.Collections.Generic;
using System.Text;

namespace SerialWombat
{

	
	public enum SerialWombatHSCounterPublicData
    {
		PULSE_COUNT = 2,		
		FREQUENCY_ON_LTH_TRANSITION = 5,		
	}
    public class SerialWombatHSCounter : SerialWombatPin
    {


        public SerialWombatAbstractProcessedInput processedInput;
        

public 		 SerialWombatHSCounter(SerialWombatChip serialWombatChip): base(serialWombatChip)
		{
			_sw = serialWombatChip;
			_pinMode = (byte)SerialWombatPinModes.PIN_MODE_HS_COUNTER;

		}

public 		Int16  begin(byte pin, SerialWombatHSCounterPublicData publicDataOutput = SerialWombatHSCounterPublicData.FREQUENCY_ON_LTH_TRANSITION, UInt16 framesBetweenUpdates = 100, UInt16 publicOutputDivisor = 1 )
		{
			_pin = pin;
            byte[] tx = { (byte)SerialWombatCommands.CONFIGURE_PIN_MODE0, _pin, _pinMode, 0x55, 0x55, 0x55, 0x55, (byte)publicDataOutput };
            BitConverter.GetBytes(framesBetweenUpdates).CopyTo(tx, 3);
            BitConverter.GetBytes(publicOutputDivisor).CopyTo(tx, 5);

            return _sw.sendPacket(tx);
		}
        public UInt32 readCounts(bool resetCounts = false)
		{
			byte[] tx = { (byte)SerialWombatCommands.CONFIGURE_PIN_MODE1, _pin, _pinMode, (byte)(resetCounts ? 1 : 0), 0x55, 0x55, 0x55, 0x55 };
			byte[] rx;
			Int16 result = _sw.sendPacket(tx, out rx);
			if (result < 0)
			{
				return 0;
			}
			else
			{
				UInt32 r = rx[3];
				r += (UInt32)rx[4] << 8;
                r += (UInt32)rx[5] << 16;
                r += (UInt32)rx[6] << 24;
				return (r);
            }
        }

        public Int32 readFrequency()
		{
            byte[] tx = { (byte)SerialWombatCommands.CONFIGURE_PIN_MODE2, _pin, _pinMode, 0x55, 0x55, 0x55, 0x55, 0x55 };
            byte[] rx;
            Int16 result = _sw.sendPacket(tx, out rx);
            if (result < 0)
            {
                return result;
            }
            else
            {
                UInt32 r = rx[3];
                r += (UInt32)rx[4] << 8;
                r += (UInt32)rx[5] << 16;
                r += (UInt32)rx[6] << 24;
                return ((Int32)r);
            }
        }

        public Int16 disable()
        {
            byte[] tx = { (byte)SerialWombatCommands.CONFIGURE_PIN_MODE_DISABLE, _pin, _pinMode, 0x55, 0x55, 0x55, 0x55, 0x55 };
            return (_sw.sendPacket(tx));

        }


    }

	

	
}
