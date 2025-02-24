using System;
using System.Collections.Generic;
using System.Text;

namespace SerialWombat
{
	/*! \brief A pin mode class that debounces inputs

   The SerialWombatDebouncedInput class is used to debounce inputs such as switches.

   See the example sw4b_ard_Debounce1 distributed with the Serial Wombat Arduino Library for an example.

   Video Tutorial

   \htmlonly
   <iframe width="560" height="315" src="https://www.youtube.com/embed/R1KM0J2Ug-M" frameborder="0" allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture" allowfullscreen></iframe>
   \endhtmlonly

   https://youtu.be/R1KM0J2Ug-M

   One SerialWombatDebouncedInput instance should be declared per debounced input.

   The class sends commands and reads data from the Serial Wombat.  The actual switch
   debouncing algorithm runs on the Serial Wombat.

   The Serial Wombat's firmware algorithm polls the input every 1mS.  After it has 
   been different from the reported value for X consecutive mS, the reported value 
   changes to the new polled value.  The number of mS required for a change
   can be configured.  

   The Debounced Input mode keeps track of how long the debounced result has been
   in the current state (up to 65535 mS) and can report this to the host.  This
   is useful for implementing user interfaces that react based on how long a 
   button has been held.

   The Debounced Input mode keeps track of how many transitions have occured.
   This can be used to poll the Debounced Input infrequently for status, but
   still process all button presses/releases that occured since the last poll.

   The pin mode has weak pull-up circuitry availble, and the ability to report 
   inverted values.  These are both enabled when the simpliest begin() call is
   used, allowing buttons that switch the Serial Wombat pin to ground to be used without
   additional hardware.

   See also the SerialWombatButtonCounter class which can run on top of this one.

   */
	public class SerialWombatDebouncedInput: SerialWombatAbstractButton
	{


		/// \brief Constructor for the SerialWombatDebouncedInput class.
		/// 
		/// \param serialWombatChip a reference to the Serial Wombat chip on which the Debounced Input will exist
		public SerialWombatDebouncedInput(SerialWombatChip serialWombatChip):base(serialWombatChip)
		{
			_sw = serialWombatChip;
		}
public 		void  begin(byte pin)
		{
			begin(pin, 30, true, true);
		}

public 		void  begin(byte pin, UInt16 debounce_mS, bool invert, bool usePullUp)
		{
			_pin = pin;
			byte[] tx = { 200, _pin, 10, (byte)(debounce_mS & 0xFF), (byte)((debounce_mS >> 8) & 0xFF), invert?(byte)1:(byte)0, 0, usePullUp ? (byte)1 : (byte)0 };
			_sw.sendPacket(tx);
		}

		public 	override	bool  digitalRead()
		{
			return (_sw.readPublicData(_pin) > 0);
		}


public 		override UInt16  readDurationInTrueState_mS()
		{

			byte[] tx = { 201, _pin, 10, 0, 0x55, 0x55, 0x55, 0x55 };
			byte[] rx;
			_sw.sendPacket(tx, out rx);

			transitions += (UInt16)(256 * rx[5] + rx[4]);
			if (rx[3] == 0)
			{
				return (0);
			}
			else
			{
				return (UInt16)(256 * rx[7] + rx[6]);
			}
		}

public 	override	UInt16  readDurationInFalseState_mS()
		{

			byte[] tx = { 201, _pin, 10, 0, 0x55, 0x55, 0x55, 0x55 };
			byte[] rx;
			_sw.sendPacket(tx, out rx);

			transitions += (UInt16)(256 * rx[5] + rx[4]);

			if (rx[3] == 1)
			{
				return (0);
			}
			else
			{
				return (UInt16)(256 * rx[7] + rx[6]);
			}
		}

		public override bool readTransitionsState(bool resetTransitions = true)
		{
			byte[] tx = { 201, _pin, 10,resetTransitions?(byte)1:(byte)0, 0x55, 0x55, 0x55, 0x55 };
			byte[] rx;
			_sw.sendPacket(tx, out rx);
			transitions = ((ushort)(256 * rx[5] + rx[4]));
			return (rx[3] > 0);
		}
	}
}
