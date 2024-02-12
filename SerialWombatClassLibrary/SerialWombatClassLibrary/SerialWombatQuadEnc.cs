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
	public class SerialWombatQuadEnc
    {

		SerialWombatChip _sw;
		public byte Pin = 255;
		public byte SecondPin;

		/// \brief Constructor for the SerialWombatQuadEnc class
		/// \param serialWombatChip The Serial Wombat running the quadrature encoder
		public SerialWombatQuadEnc(SerialWombatChip serialWombatChip) 
		{
			_sw = serialWombatChip;
			Pin = 255;
			SecondPin = 255;
		}

		/// \brief Simple initialization for SerialWombatQuadEnc
		/// \param pin The first pin to be used as a Quadrature Encoder input. All 4 pins on the SW4A/SW4B may be used.
		/// \param secondPin The second pin to be used as a Quadrature Encoder input. All 4 pins on the SW4A/SW4B may be used, except the first specified pin.
		/// 
		/// This initialization assumes a simple Rotary Encoder knob that is connected to ground.  Polling mode is used, and both transitions generate increments.
		/// Pull ups are enabled, and 10ms of debouncing is used.
		/// Position is initialized to 0.
		public void  begin(byte pin, byte secondPin)
		{
			begin(pin, secondPin, 10, true, QuadEncReadModes.QE_ONBOTH_POLL);
		}

public 		void  begin(byte pin, byte secondPin, UInt16 debounce_mS, bool pullUpsEnabled)
		{
			begin(pin, secondPin, debounce_mS, pullUpsEnabled, QuadEncReadModes.QE_ONBOTH_POLL);
		}

public 		Int16  begin(byte pin, byte secondPin, UInt16 debounce_mS, bool pullUpsEnabled, QuadEncReadModes readState)
		{
			Pin = pin;
			SecondPin = secondPin;
			byte[] tx = { 200, Pin, (byte)SerialWombatPinModes.PIN_MODE_QUADRATUREENCODER, (byte)(debounce_mS & 0xFF), (byte)((debounce_mS >> 8) & 0xFF), SecondPin, (byte)readState, pullUpsEnabled?(byte)1:(byte)0 };
			byte[] rx;
			return _sw.sendPacket(tx, out rx);
		}

public 		UInt16  read()
		{
			return _sw.readPublicData(Pin);
		}

public 		UInt16  read(UInt16 replacementValue)
		{
			return _sw.writePublicData(Pin, replacementValue);
		}

public 		void  write(UInt16 value)
		{
			_sw.writePublicData(Pin, value);
		}
	}
}
