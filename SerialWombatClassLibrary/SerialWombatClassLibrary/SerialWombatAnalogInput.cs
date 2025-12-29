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

	public enum AnalogInputPublicDataOutput
	{
		Raw = 0,
		Filtered = 1,
		Averaged = 2,
		Minimum = 3,
		Maximum = 4
	};
	/*!

\brief A class to make analog measurements with the Serial Wombat.

The SerialWombatAnalogInput class is used to make measurements on a given pin.

Any analog-capable pin may be used to make a measurement.

Averaging of samples and first order IIR filtering (1 kHz sampling) of input are available

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

Declare and initialize a SerialWombatAnalogInput instance for each pin being used as an analog input.

The SW4B_ard_analogInput example included with the Arduino library shows how to use this class.


A Tutorial video is also avaialble:

\htmlonly
<iframe width="560" height="315" src="https://www.youtube.com/embed/_EKlrEVaEhg" frameborder="0" allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture" allowfullscreen></iframe>
\endhtmlonly

https://youtu.be/_EKlrEVaEhg

*/
	public class SerialWombatAnalogInput : SerialWombatPin
	{


		/// \brief Constructor for the SerialWombatAnalogInput class.
		/// 
		/// \param SerialWombat a reference to the Serial Wombat on which the Analog Input will be measured
		public SerialWombatAnalogInput(SerialWombatChip serialWombatChip,byte pin = 255) : base(serialWombatChip,pin)
		{
			
        }


		/// \brief Initialize an analog input on a given pin.
		/// 
		/// \param pin The Serial Wombat pin to set.  Valid values for SW4A: 0-3  SW4B: 1-3 
		/// \param averageSamples Number of samples to average.  Valid values for SW4A and SW4B are 0 or 64.
		/// All non-zero values will be treated as 64 on these platforms.
		/// \param filterConstant First Order IIR filter constant, expressed as 1/65536ths .
		/// Values closer to 65536 give heav
		public void begin(byte pin, UInt16 averageSamples = 64, UInt16 filterConstant = 0xFF80, AnalogInputPublicDataOutput output = AnalogInputPublicDataOutput.Raw)
		{
			_pin = pin;
			_pinMode = (byte)SerialWombatPinModes.PIN_MODE_ANALOGINPUT;
			byte[] tx = { 200, _pin, _pinMode, 0, 0, 0, 0, 0 };

			_sw.sendPacket(tx);
			byte[] tx1 = { 201, _pin, _pinMode, (byte)(averageSamples & 0xFF), (byte)((averageSamples >> 8) & 0xFF), (byte)(filterConstant & 0xFF), (byte)((filterConstant >> 8) & 0xFF), (byte)output };
			_sw.sendPacket(tx1);
		}


		/// \brief Retreive a raw A/D measurement and convert it to mV
		/// 
		/// Conversion is based on the most recent A/D conversion taken by the 
		/// Serial Wombat at the command time and the last reference measurement made on the 
		/// Serial Wombat using the SerialWombat.readSupplyVoltage_mV() method.  
		/// \return A 16 bit unsigned value indicating measurement in mV
		public UInt16 readVoltage_mV()
		{

			UInt16 reading = _sw.readPublicData(_pin);

			UInt32 x = ((UInt32)reading) * _sw._supplyVoltagemV;

			UInt16 returnval = (UInt16)(x >> 16);

			return (returnval);
		}

		/// \brief Retreive a raw A/D measurement
		/// 
		/// Conversion is based on the most recent A/D conversion taken by the 
		/// Serial Wombat at the command time.
		/// 
		/// All Serial Wombat products will return a 16-bit value.  However
		/// the SW4A and SW4B products only have 10-bit A/D converters, so
		/// the returned value moves by 64 counts at a time, except for the topmost value.
		///  For all 
		/// Serial Wombat products, the highest possible reading (0xFFC0 for the SW4A/SW4B)
		/// is changed to 0xFFFF to indicate maximum possible hardware value.
		/// 
		/// \return A 16 bit unsigned value indicating the counts of the A/D conversion
		public UInt16 readCounts()
		{
			return (_sw.readPublicData(_pin));
		}

		/// \brief Retreive a filtered A/D measurement and convert it to mV
		/// 
		/// Conversion is based on the most recent filtered A/D result taken by the 
		/// Serial Wombat at the command time and the last reference measurement made on the 
		/// Serial Wombat using the SerialWombat.readSupplyVoltage_mV() method.  
		/// \return A 16 bit unsigned value indicating measurement in mV
		public UInt16 readFiltered_mV()
		{
			UInt32 x = readFilteredCounts(); // Counts ranging from 0 to 65535
			x *= _sw._supplyVoltagemV;


			return ((UInt16)(x >> 16));
		}

		/// \brief Retreive a filtered A/D measurement
		/// 
		/// Conversion is based on the most recent filtered A/D value taken by the 
		/// Serial Wombat at the command time.
		/// 
		/// 
		/// \return A 16 bit unsigned value indicating the filtered A/D result
		public UInt16 readFilteredCounts()
		{
			byte[] tx = { 204, _pin, _pinMode, 0x55, 0x55, 0x55, 0x55, 0x55 };
			byte[] rx;

			_sw.sendPacket(tx, out rx);

			return (UInt16)(rx[5] + rx[6] * 256);
		}
		/// \brief Retreive an averaged A/D measurement and convert it to mV
		/// 
		/// Conversion is based on the most recent averaged A/D result taken by the 
		/// Serial Wombat at the command time and the last reference measurement made on the 
		/// Serial Wombat using the SerialWombat.readSupplyVoltage_mV() method.  
		/// \return A 16 bit unsigned value indicating measurement in mV
		public UInt16 readAveraged_mV()
		{
			UInt32 x = readAveragedCounts(); // Counts ranging from 0 to 65535

			x *= _sw._supplyVoltagemV;
			return ((UInt16)(x >> 16));
		}
		/// \brief Retreive an averaged A/D measurement
		/// 
		/// Conversion is based on the most recent averaged A/D value taken by the 
		/// Serial Wombat at the command time.
		/// 
		/// All Serial Wombat products will return a 16-bit value.  However
		/// the SW4A and SW4B products only have 10-bit A/D converters.  Averaging will potentially
		/// increase the effective resolution slightly for signals that have a small amount of
		/// randomly distributed noise.  
		/// 
		/// \return A 16 bit unsigned value indicating the counts of the A/D conversion
		public UInt16 readAveragedCounts()
		{
			byte[] tx = { 204, _pin, _pinMode, 0x55, 0x55, 0x55, 0x55, 0x55 };
			byte[] rx;

			_sw.sendPacket(tx, out rx);

			return (UInt16)(rx[3] + rx[4] * 256);
		}




		/// Provides a wrapper around the readSupplyVoltage_mV() method for the SerialWombat hosting this pin mode
		public UInt16 updateSupplyVoltage_mV()
		{
			return _sw.readSupplyVoltage_mV();
		}



		/// \brief Retreive the maximum single sample A/D value in counts
		///  
		/// The maximum value the Serial Wombat chip has seen on that pin since last reset of Min/Max
		///
		/// \param resetAfterRead If True, maximum value is set to 0 after read so that subsequent values become maximum.  Also resets minimum to next sample.
		/// 
		/// \return A 16 bit unsigned value indicating maximum A/D Counts
		public UInt16 readMaximumCounts(bool resetAfterRead)
		{
			byte[] tx = { 203, _pin, _pinMode, 0, 0x55, 0x55, 0x55, 0x55 };
			byte[] rx;

			if (resetAfterRead)
			{
				tx[3] = 1;
			}
			_sw.sendPacket(tx, out rx);

			return (UInt16)(rx[5] + rx[6] * 256);
		}

		/// \brief Retreive the maximum single sample A/D value in counts
		///  
		/// The maximum value the Serial Wombat chip has seen on that pin since last reset of Min/Max
		///
		/// \param resetAfterRead If True, maximum value is set to 0 after read so that subsequent values become maximum.  Also resets minimum to next sample.
		/// 
		/// \return A 16 bit unsigned value indicating maximum A/D Counts

		public UInt16 readMinimumCounts(bool resetAfterRead)
		{
			byte[] tx = { 203, _pin, _pinMode, 0, 0x55, 0x55, 0x55, 0x55 };
			byte[] rx;

			if (resetAfterRead)
			{
				tx[3] = 1;
			}
			_sw.sendPacket(tx, out rx);

			return (UInt16)(rx[3] + rx[4] * 256);
		}

		public Int16 setInputSource(byte inputSource)
		{
			byte[] tx = { 202, _pin, _pinMode, inputSource, 0x55, 0x55, 0x55, 0x55 };
			return (_sw.sendPacket(tx));

		}

		/// \brief Retreive the maximum single sample A/D value in mV
		///  
		/// The maximum value the Serial Wombat chip has seen on that pin since last reset of Min/Max
		///
		/// \param resetAfterRead If True, maximum value is set to 0 after read so that subsequent values become maximum.  Also resets minimum to next sample.
		/// 
		/// \return A 16 bit unsigned value indicating measurement in mV
		public UInt16 readMaximum_mV(bool resetAfterRead)
		{
			UInt32 x = readMaximumCounts(resetAfterRead); // Counts ranging from 0 to 65535

			x *= _sw._supplyVoltagemV;
			return ((UInt16)(x >> 16));
		}


		/// \brief Retreive the minimum single sample A/D value in mV
		///  
		/// The minimum value the Serial Wombat chip has seen on that pin since last reset of Min/Max
		///
		/// \param resetAfterRead If True, minimum value is set to 0 after read so that subsequent values become minimum.  Also resets maximum to next sample.
		/// 
		/// \return A 16 bit unsigned value indicating measurement in mV
		public UInt16 readMinimum_mV(bool resetAfterRead)
		{
			UInt32 x = readMinimumCounts(resetAfterRead); // Counts ranging from 0 to 65535

			x *= _sw._supplyVoltagemV;
			return ((UInt16)(x >> 16));
		}

		public byte Pin { get { return _pin; } }
	}



	/// \brief This class extends SerialWombatAnalogInput with SW18AB specific capabilities
	class SerialWombatAnalogInput_18AB : SerialWombatAnalogInput
	{
		public SerialWombatAbstractProcessedInput processedInput;

		SerialWombatAnalogInput_18AB(SerialWombatChip serialWombatChip) : base(serialWombatChip)
		{ }
		
		public void begin(byte pin)
        {
			_pin = pin;
			_pinMode = (byte)SerialWombatPinModes.PIN_MODE_ANALOGINPUT;
			processedInput = new SerialWombatAbstractProcessedInput(_sw);
			processedInput.begin(_pin, _pinMode);
        }


	};

}