using System;
using System.Collections.Generic;
using System.Text;

namespace SerialWombat
{

	public enum SerialWombatPulseTimerUnits
	{
		SW_PULSETIMER_uS = 0,
		SW_PULSETIMER_mS = 1
	}

	public enum SerialWombatPulseTimerPublicData
    {
		HIGH_TIME = 0,
		LOW_TIME = 1,
		PULSE_COUNT = 2,
		PERIOD_ON_LTH_TRANSITION = 3,
		PERIOD_ON_HTL_TRANSITION = 4,
		FREQUENCY_ON_LTH_TRANSITION = 5,
		FREQUENCY_ON_HTL_TRANSITION = 6,
		DUTYCYCLE_ON_LTH_TRANSITION = 7,
		DUTYCYCLE_ON_HTL_TRANSITION = 8,
		HIGH_AND_LOW_TIME = 9,
	}
    public class SerialWombatPulseTimer : SerialWombatPin
    {



	/// \brief Count in selected units of last retreived high pulse
	///  
	/// This value is updated by refresh, refreshHighCountsLowCounts, refreshHighCountsPulses, readHighCounts, readLowCounts
public	UInt16 HighCounts = 0;
	/// \brief Count in selected units of last retreived low pulse
	///  
	/// This value is updated by refresh, refreshHighCountsLowCounts, readHighCounts, readLowCounts
public UInt16 LowCounts = 0;

	/// \brief Count of last retreived pulses
	/// 
	/// This value is updated by refresh, and refreshHighCountsPulses
public UInt16 Pulses = 0;
public	bool MeasurementOverflowOccurred = false;

public 		 SerialWombatPulseTimer(SerialWombatChip serialWombatChip): base(serialWombatChip)
		{
			_sw = serialWombatChip;

		}

public 		void  begin(byte pin)
		{
			begin(pin, SerialWombatPulseTimerUnits.SW_PULSETIMER_uS, false);
		}

public 		void  begin(byte pin, SerialWombatPulseTimerUnits units, bool pullUpsEnabled)
		{
			_pin = pin;
			byte[] tx = { 200, _pin, (byte)SerialWombatPinModes.PIN_MODE_PULSETIMER, pullUpsEnabled?(byte)1:(byte)0, (byte)units, 0x55, 0x55, 0x55 };
			_sw.sendPacket(tx);
		}

public 		void  refresh()
		{
			refreshHighCountsLowCounts();
			{
				byte[] tx = { 202, _pin, (byte)SerialWombatPinModes.PIN_MODE_PULSETIMER, 0x55, 0x55, 0x55, 0x55, 0x55 };
				byte[] rx;
				_sw.sendPacket(tx, out rx);
				Pulses = (UInt16)(rx[5] + 256 * rx[6]);
				MeasurementOverflowOccurred = rx[7] > 0;
			}
		}

public 		void  refreshHighCountsLowCounts()
		{
			byte[] tx = { 201, _pin, (byte)SerialWombatPinModes.PIN_MODE_PULSETIMER, 0x55, 0x55, 0x55, 0x55, 0x55 };
			byte[] rx;
			_sw.sendPacket(tx, out rx);
			HighCounts = (UInt16)(rx[3] + 256 * rx[4]);
			LowCounts = (UInt16)(rx[5] + 256 * rx[6]);
		}

public 		void  refreshHighCountsPulses()
		{
			byte[] tx = { 202, _pin, (byte)SerialWombatPinModes.PIN_MODE_PULSETIMER, 0x55, 0x55, 0x55, 0x55, 0x55 };
			byte[] rx;
			_sw.sendPacket(tx, out rx);
			HighCounts = (UInt16)(rx[3] + 256 * rx[4]);
			Pulses = (UInt16)(rx[5] + 256 * rx[6]);
			MeasurementOverflowOccurred = rx[7] > 0;
		}

public 		UInt16  readHighCounts()
		{
			refreshHighCountsLowCounts();
			return (HighCounts);
		}

public 		UInt16  readLowCounts()
		{
			refreshHighCountsLowCounts();
			return (LowCounts);
		}

public 		UInt16  readPulses()
		{
			refreshHighCountsPulses();
			return (Pulses);
		}

		public byte Pin { get { return _pin; } }

	
	}

	public class SerialWombatPulseTimer_18AB : SerialWombatPulseTimer
    {

			public SerialWombatAbstractProcessedInput processedInput;

		public SerialWombatPulseTimer_18AB(SerialWombatChip serialWombatChip) : base(serialWombatChip)
			{ }

			new public void begin(byte pin, SerialWombatPulseTimerUnits units = SerialWombatPulseTimerUnits.SW_PULSETIMER_uS, bool pullUpsEnabled = false)
			{
				_pin = pin;
				_pinMode = (byte)SerialWombatPinModes.PIN_MODE_PULSETIMER;
				base.begin(pin, units, pullUpsEnabled);
				processedInput = new SerialWombatAbstractProcessedInput(_sw);
				processedInput.begin(_pin, _pinMode);
			}
		public void configurePublicDataOutput(SerialWombatPulseTimerPublicData data)
		{
			byte[] tx = { 203, _pin, (byte)SerialWombatPinModes.PIN_MODE_PULSETIMER, (byte)data, 0x55, 0x55, 0x55, 0x55 };

			_sw.sendPacket(tx);
		}


	}
	
}
