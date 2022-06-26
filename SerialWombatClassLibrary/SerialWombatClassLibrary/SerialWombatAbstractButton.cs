using System;
using System.Collections.Generic;
using System.Text;

namespace SerialWombat
{
	/// \brief SerialWombat18CapTouch, SerialWombatDebouncedInput and SerialWombatMatrixButton inherit from this class
	///
	/// This class provides a basic set of interface for any pin mode class that has a button-like interface
	/// It allows classes like SerialWombatButtonCounter to work uniformly with any button-like class.	
	public abstract class SerialWombatAbstractButton : SerialWombatPin
	{

		/// \brief Constructor for the SerialWombatAbstractButton class.
		/// 
		/// \param serialWombatChip a reference to the Serial Wombat chip on which the Debounced Input will exist
		public SerialWombatAbstractButton(SerialWombatChip serialWombatChip) : base(serialWombatChip)
		{
		}

		/// \brief Returns the state of the input
		/// 
		/// This function reads the status of an input
		/// \return TRUE or FALSE.  Meaning depends on inversion setting
		new public abstract bool digitalRead();

	/// \brief return the number of mS that the input has been in true state
	/// 
	/// Note that this value starts incrementing after the debounce period, not after the physical pin transition.
	/// 
	/// \return returns a value in mS which saturates at 65535.  Returns 0 if currently false.
	public abstract UInt16 readDurationInTrueState_mS() ;
	/// \brief return the number of mS that the input has been in false state
	/// 
	/// Note that this value starts incrementing after any debounce period, not after the physical pin transition.
	/// 
	/// \return returns a value in mS which saturates at 65535.  Returns 0 if currently true.
	public abstract UInt16 readDurationInFalseState_mS() ;

	/// \brief Number of transitions returned by last call to readTransitionsState()
	public UInt16 transitions = 0;

		/// \brief Queries the number of transistions that have occured on the debounced input
		/// 
		/// This function queries the debounced input for current state and transitions since last call.
		/// transition count is put in the global member transitions.  The debounced input in the Serial
		/// Wombat resets its count to zero after this call.
		/// 
		/// \return TRUE or FALSE, current status of debounced input
		public abstract bool readTransitionsState() ;
		
	}
}
