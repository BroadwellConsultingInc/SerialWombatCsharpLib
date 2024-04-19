using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Text;

namespace SerialWombat
{

public  enum QuadEncReadModes
	{
		QE_ONLOW_INT = 0,  ///< Interrupt driven, process on high to low transition
		QE_ONHIGH_INT = 1, ///< Interrupt driven, process on low to high transition
		QE_ONBOTH_INT = 2, ///< Interrupt driven, process on low to high and high to low transition
		QE_ONLOW_POLL = 4,   ///< 1mS Polling, process on high to low transition
		QE_ONHIGH_POLL = 5,  ///< 1mS Polling, process on low to high transition
		QE_ONBOTH_POLL = 6   ///< 1mS Polling, process on low to high and high to low transition
	}
	;
	/*! \brief A class that uses two Serial Wombat input pins to read quadrature encoder input

The SerialWombatQuadEnc class configures two pins on the Serial Wombat to work together to 
read quadrature encoder inputs.  

By offloading the reading of an encoder to the Serial Wombat, it makes it easy for the host
to track multiple encoders at once.  The host need only periodically retreive the net change
in rotary encoder position from the Serial Wombat rather than monitoring for every signal
change.

Video Tutorial:

\htmlonly
<iframe width="560" height="315" src="https://www.youtube.com/embed/_wO8cOada3w" frameborder="0" allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture" allowfullscreen></iframe>
\endhtmlonly

https://youtu.be/_wO8cOada3w

An instance of the SerialWombatQuadEnc class should be declared for each encoder (2 pins) 
connected to the Serial Wombat.

The quadrature encoder is capable of running in either polled or interrupt driven modes.  

Polled mode is recommended for manual inputs such as rotary encoder knobs.  It polls at 1 kHz
which is fast enough for most applications.

Interrupt driven mode is capable of correctly decoding very fast signals.  However,
the signals need to be properly filtered in order to eliminate any bouncing.

The SerialWombatQuadEnc can make use of the Serial Wombat's built in pull-up resistors
to make connecting a rotary encoder knob very simple.  Debouncing is available which prevents
additional transitions from being measured for a specified number of mS after a transition.

Rotational direction measurement can be changed by switching the "pin" and "second pin" parameters
in the begin call.

The reported position can be changed on low to high transitions of "pin", high to low transitions,
or both transitions.  This allows knobs that make and break connection on each click/detent and knobs
that either make or break connection on each detent to report one change per detent to the host.  

The default mode for simple initialization is to measure both, which will result in 2 increments per
detent for encoders that make and break connection on each detent.

\warning Care must be taken in interrupt mode when using this pinmode with high frequency ( > 5 kHz) signals or pins that may be left floating on the Serial Wombat 4A / 4B because
the Serial Wombat uses an interrupt internally to capture transitions between state machine updates.  Excessively frequent pin transitions may cause the interrupt
handler to starve the main processing loop, impacting function of all pin modes and communications.

The Serial Wombat can be queried for overflow frames.  If overflow frames are occuring, then the system is overloaded.

The Serial Wombat 4A and 4B can measure a maxium of 8 transitions per mS across all pulse input pins.  More frequent transitions than
this may result pin mode malfunction.
*/
	public class SerialWombatQuadEnc:SerialWombatPin
    {

		
		public byte SecondPin;

		/// \brief Constructor for the SerialWombatQuadEnc class
		/// \param serialWombatChip The Serial Wombat running the quadrature encoder
		public SerialWombatQuadEnc(SerialWombatChip serialWombatChip) : base(serialWombatChip)
		{
			_sw = serialWombatChip;
			_pin = 255;
			SecondPin = 255;
		}


public 		Int16  begin(byte pin, byte secondPin, UInt16 debounce_mS = 10, bool pullUpsEnabled = true, QuadEncReadModes readState = QuadEncReadModes.QE_ONBOTH_POLL)
		{
			_pin = pin;
			SecondPin = secondPin;
			byte[] tx = { 200, _pin, (byte)SerialWombatPinModes.PIN_MODE_QUADRATUREENCODER, (byte)(debounce_mS & 0xFF), (byte)((debounce_mS >> 8) & 0xFF), SecondPin, (byte)readState, pullUpsEnabled?(byte)1:(byte)0 };
			return _sw.sendPacket(tx);
		}

public 		UInt16  read()
		{
			return _sw.readPublicData(_pin);
		}

public 		UInt16  read(UInt16 replacementValue)
		{
			return _sw.writePublicData(_pin, replacementValue);
		}

public 		void  write(UInt16 value)
		{
			_sw.writePublicData(_pin, value);
		}
	}

	public class SerialWombatQuadEnc_18AB : SerialWombatQuadEnc
	{
        public SerialWombatAbstractProcessedInput processedInput;

        public SerialWombatQuadEnc_18AB(SerialWombatChip serialWombatChip) : base(serialWombatChip)
        { }

        new public void begin(byte pin, byte secondPin, UInt16 debounce_mS = 10, bool pullUpsEnabled = true, QuadEncReadModes readState = QuadEncReadModes.QE_ONBOTH_POLL)
        {
			_pin = pin;
            _pinMode = (byte)SerialWombatPinModes.PIN_MODE_QUADRATUREENCODER;
            base.begin(pin,secondPin,debounce_mS,pullUpsEnabled,readState);
            processedInput = new SerialWombatAbstractProcessedInput(_sw);
            processedInput.begin(_pin, _pinMode);
        }
        public Int16 writeMinMaxIncrementTargetPin(UInt16 min = 65535, UInt16 max = 0, UInt16 increment = 1, byte targetPin = 255)
        {

            {
                byte[] tx = { 201, _pin,(byte) SerialWombatPinModes.PIN_MODE_QUADRATUREENCODER,
                    (byte)(increment  & 0xFF),(byte)((increment>>8)  & 0xFF), 0x55, 0x55, 0x55 };
                Int16 result = _sw.sendPacket(tx);
                if (result < 0)
                {
                    return (result);
                }
            }
            {
                byte[] tx = { 202, _pin, (byte)SerialWombatPinModes.PIN_MODE_QUADRATUREENCODER,
                        (byte)(min  & 0xFF),(byte)((min>>8)  & 0xFF),
                        (byte)(max  & 0xFF),(byte)((max>>8)  & 0xFF),
                        0x55 };
                Int16 result = _sw.sendPacket(tx);
                if (result < 0)
                {
                    return (result);
                }
            }
            {
                byte[] tx = { 203, _pin, (byte)SerialWombatPinModes.PIN_MODE_QUADRATUREENCODER,
                    targetPin, 0x55, 0x55, 0x55, 0x55 };
                return _sw.sendPacket(tx);

            }
        }

        public Int16 writeFrequencyPeriodmS(UInt16 period)
        {
            byte[] tx = { 204, _pin, (byte)SerialWombatPinModes.PIN_MODE_QUADRATUREENCODER,
                (byte)(period  & 0xFF),(byte)((period>>8)  & 0xFF),
                0x55, 0x55, 0x55 };
            return _sw.sendPacket(tx);

        }

        public UInt16 readFrequency()
        {
            byte[] tx = { 205, _pin, (byte)SerialWombatPinModes.PIN_MODE_QUADRATUREENCODER, 0x55, 0x55, 0x55, 0x55, 0x55 };
            byte[] rx;
            Int16 result = _sw.sendPacket(tx,out rx);
            if (result < 0) return 0;

            return ((UInt16)(rx[3] + 256 * rx[4]));
        }
    }
}
