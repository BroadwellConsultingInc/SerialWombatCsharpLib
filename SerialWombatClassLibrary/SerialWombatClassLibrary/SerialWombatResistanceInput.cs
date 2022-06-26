using System;
using System.Collections.Generic;
using System.Text;

namespace SerialWombat
{

	public enum ResistanceInputPublicDataOutput
	{
		Raw = 0,
		Filtered = 1,
		Average = 2,
		Minimum = 3,
		Maximum = 4
	};
	/*!

<summary> A class to make resistance measurements with the Serial Wombat.</summary>

This class is only available on the Serial Wombat 18AB chip

The SerialWombatresistanceInput class is used to make measurements on a given pin.

	Range is 0 - 65kohm in about 14 ohm increments.  Accuracy may vary.

Any analog-capable pin may be used to make a measurement.

Averaging of samples and first order IIR filtering (20 Hz sampling) of input are available

For a good explanation of 1st order FIR filter calculations, see:
https://www.monocilindro.com/2017/04/08/how-to-implement-a-1st-order-iir-filter-in-5-minutes/

Some filter cut-off (3dB down) frequency and constant values:
      - 0.5 Hz  65417
	  - 1 Hz 65298   
	  - 2 Hz 65062
	  - 5 Hz 64358
	  - 10 Hz 63202

Filtering adds lag.  The higher the filter constant value, the longer it takes for the filter to settle 
when given a steady input.

Declare and initialize a SerialWombatresistanceInput instance for each pin being used as an resistance input.


*/
	public class SerialWombatResistanceInput
	{
		SerialWombatChip _sw;

		byte _pin = 255;

		/// <summary> Constructor for the SerialWombatresistanceInput class.</summary>
		/// 
		/// <param name="SerialWombat"> a reference to the Serial Wombat on which the resistance Input will be measured</param>
		public SerialWombatResistanceInput(SerialWombatChip serialWombatChip)
		{
			_sw = serialWombatChip;
		}

		/// <summary> Initialize an resistance input on a given pin.</summary>
		/// 
		/// <param name="pin"> The Serial Wombat pin to set.  Must be an analog capable pin </param>
		public void begin(byte pin)
		{
			_pin = pin;
			byte[] tx = { 200, _pin, (byte)SerialWombatPinModes.PIN_MODE_RESISTANCEINPUT, 0, 0, 0, 0, 0 };
			byte[] rx;
			_sw.sendPacket(tx, out rx);
			byte[] tx1 = { 201, _pin, (byte)SerialWombatPinModes.PIN_MODE_RESISTANCEINPUT, 64, 0, 0xFF, 0x80, 0 };
			_sw.sendPacket(tx1, out rx);
		}

		/// <summary> Initialize an resistance input on a given pin.</summary>
		/// 
		/// <param name="pin"> The Serial Wombat pin to set.  Must be an analog capable pin </param>
		/// <param name="averageSamples"> Number of samples to average.  Valid values for SW4A and SW4B are 0 or 64.</param>
		/// All non-zero values will be treated as 64 on these platforms.
		/// <param name="filterConstant"> First Order IIR filter constant, expressed as 1/65536ths .</param>
		/// Values closer to 65536 give heav
		public void begin(byte pin, UInt16 averageSamples, UInt16 filterConstant, ResistanceInputPublicDataOutput output)
		{
			begin(pin);
			byte[] tx = { 201, _pin, (byte)SerialWombatPinModes.PIN_MODE_RESISTANCEINPUT, (byte)(averageSamples & 0xFF), (byte)((averageSamples >> 8) & 0xFF), (byte)(filterConstant & 0xFF), (byte)((filterConstant >> 8) & 0xFF), (byte)output };
			byte[] rx;
			_sw.sendPacket(tx, out rx);
		}

		/// <summary> Initialize an resistance input on a given pin.</summary>
		/// 
		/// <param name="pin"> The Serial Wombat pin to set.  Must be an analog capable pin </param>
		/// <param name="averageSamples"> Number of samples to average.  Valid values for SW4A and SW4B are 0 or 64.</param>
		/// All non-zero values will be treated as 64 on these platforms.
		/// <param name="filterConstant"> First Order IIR filter constant, expressed as 1/65536ths .</param>
		/// Values closer to 65536 give heav
		public void begin(byte pin, UInt16 averageSamples, UInt16 filterConstant)
		{
			begin(pin);
			byte[] tx = { 201, _pin, (byte)SerialWombatPinModes.PIN_MODE_RESISTANCEINPUT, (byte)(averageSamples & 0xFF), (byte)((averageSamples >> 16) & 0xFF), (byte)(filterConstant & 0xFF), (byte)((filterConstant >> 16) & 0xFF), 0 };
			byte[] rx;
			_sw.sendPacket(tx, out rx);
		}


		

		/// <summary> Retreive a raw Resistance measurement</summary>
		/// 
		/// Conversion is based on the most recent Resistance conversion taken by the 
		/// Serial Wombat at the command time.
		/// 
		/// 
		/// <returns> A 16 bit unsigned value indicating the Ohms of the Resistance conversion</returns>
		public UInt16 readOhms()
		{
			return (_sw.readPublicData(_pin));
		}


		/// <summary> Retreive a filtered Resistance measurement</summary>
		/// 
		/// Conversion is based on the most recent filtered Resistance value taken by the 
		/// Serial Wombat at the command time.
		/// 
		/// 
		/// <returns> A 16 bit unsigned value indicating the filtered Resistance result</returns>
		public UInt16 readFilteredCounts()
		{
			byte[] tx = { 204, _pin, (byte)SerialWombatPinModes.PIN_MODE_RESISTANCEINPUT, 0x55, 0x55, 0x55, 0x55, 0x55 };
			byte[] rx;

			_sw.sendPacket(tx, out rx);

			return (UInt16)(rx[5] + rx[6] * 256);
		}

		/// <summary> Retreive an averaged Resistance measurement</summary>
		/// 
		/// Conversion is based on the most recent averaged Resistance value taken by the 
		/// Serial Wombat at the command time.
		/// 
		/// <returns> A 16 bit unsigned value indicating the counts of the Resistance conversion</returns>
		public UInt16 readAveragedOhms()
		{
			byte[] tx = { 204, _pin, (byte)SerialWombatPinModes.PIN_MODE_RESISTANCEINPUT, 0x55, 0x55, 0x55, 0x55, 0x55 };
			byte[] rx;

			_sw.sendPacket(tx, out rx);

			return (UInt16)(rx[3] + rx[4] * 256);
		}






		/// <summary> Retreive the maximum single sample Resistance value in ohms</summary>
		///  
		/// The maximum value the Serial Wombat chip has seen on that pin since last reset of Min/Max
		///
		/// <param name="resetAfterRead"> If True, maximum value is set to 0 after read so that subsequent values become maximum.  Also resets minimum to next sample.</param>
		/// 
		/// <returns> A 16 bit unsigned value indicating maximum Resistances</returns>
		public UInt16 readMaximumOhms(bool resetAfterRead)
		{
			byte[] tx = { 203, _pin, (byte)SerialWombatPinModes.PIN_MODE_RESISTANCEINPUT, 0, 0x55, 0x55, 0x55, 0x55 };
			byte[] rx;

			if (resetAfterRead)
			{
				tx[3] = 1;
			}
			_sw.sendPacket(tx, out rx);

			return (UInt16)(rx[5] + rx[6] * 256);
		}

		/// <summary> Retreive the maximum single sample Resistance value in counts</summary>
		///  
		/// The maximum value the Serial Wombat chip has seen on that pin since last reset of Min/Max
		///
		/// <param name="resetAfterRead"> If True, maximum value is set to 0 after read so that subsequent values become maximum.  Also resets minimum to next sample.</param>
		/// 
		/// <returns> A 16 bit unsigned value indicating maximum Resistances</returns>

		public UInt16 readMinimumCounts(bool resetAfterRead)
		{
			byte[] tx = { 203, _pin, (byte)SerialWombatPinModes.PIN_MODE_RESISTANCEINPUT, 0, 0x55, 0x55, 0x55, 0x55 };
			byte[] rx;

			if (resetAfterRead)
			{
				tx[3] = 1;
			}
			_sw.sendPacket(tx, out rx);

			return (UInt16)(rx[3] + rx[4] * 256);
		}


		public byte Pin { get { return _pin; } }

	}


}
