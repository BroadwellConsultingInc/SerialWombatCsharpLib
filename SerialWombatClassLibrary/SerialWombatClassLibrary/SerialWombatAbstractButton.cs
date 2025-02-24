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
		public abstract bool readTransitionsState(bool resetTransitions = true) ;
		
	}
	
	
/*! \brief A class that runs on top of SerialWombaAbstractButton to increment or decrement a variable based on a button

This class runs on top of a SerialWombaAbstractButton input.  It is passed a variable reference in its begin call.
The update() method is then called periodically.  This method will look at how many times the debounced input has
transitioned since the last call, and also if the input is currently pressed and for how long.

A high limit and low limit can be set which keeps the variable from exceeing those bounds.

Times can be specified for button hold that allows the variable to be incremented at varying rates for short, medium,
and long holds.

See the example sw4b_ard_Debounce2 distributed with the Serial Wombat Arduino Library and in the video 

https://youtu.be/_EKlrEVaEhg

for an example.


*/
	public class SerialWombatButtonCounter
    {
		public SerialWombatAbstractButton _debouncedInput;

		int _variableToIncrement;

		int _slowIncrement;
		int _slow_mS_betweenIncrements;

		int _slowToMediumTransition_mS;

		int _mediumIncrement;
		int _medium_mS_betweenIncrements;

		int _mediumToFastTransistion_mS;

		int _fastIncrement;
		int _fast_mS_betweenIncrements;

		int _lastPressDuration;

		/// \brief The variable will not increment above this limit.
		public int highLimit = int.MaxValue;
		///  \brief The variable will not decrement below this limit.
		public int lowLimit = int.MinValue;

		public SerialWombatButtonCounter(SerialWombatAbstractButton serialWombatDebouncedInput)
		{
			_debouncedInput = serialWombatDebouncedInput;
		}

		/// Initializes the SerialWombatButtonCounter
		/// 
		/// \param variableToIncrement  A pointer to a signed long integer
		/// \param slowIncrement the amount that the variable should increment (or decrement if negative) per increment
		/// \param slow_mS_betweenIncrements how often an increment should happen in slow mode
		/// \param slowToMediumTransition_mS how long to stay in slow mode before switching to medium mode
		/// \param mediumIncrement the amount that the variable should increment (or decrement if negative) per increment
		/// \param medium_mS_betweenIncrements how often an increment should happen in medium mode
		/// \param mediumToFastTransition_mS how long after the initail button press start until switching to Fast mode
		/// \param fastIncrement the amount that the variable should increment (or decrement if negative) per increment
		/// \param fast_mS_betweenIncrements how often an increment should happen in fast mode
		public void begin(ref int variableToIncrement, int slowIncrement, UInt16 slow_mS_betweenIncrements, UInt16 slowToMediumTransition_mS, int mediumIncrement, UInt16 medium_mS_betweenIncrements, UInt16 mediumToFastTransistion_mS, int fastIncrement, UInt16 fast_mS_betweenIncrements)
		{
			_variableToIncrement = variableToIncrement;

			_slowIncrement = slowIncrement;
			_slow_mS_betweenIncrements = slow_mS_betweenIncrements;

			_slowToMediumTransition_mS = slowToMediumTransition_mS;

			_mediumIncrement = mediumIncrement;
			_medium_mS_betweenIncrements = medium_mS_betweenIncrements;

			_mediumToFastTransistion_mS = mediumToFastTransistion_mS;

			_fastIncrement = fastIncrement;
			_fast_mS_betweenIncrements = fast_mS_betweenIncrements;

			_lastPressDuration = 0;

		}

		public bool update()
		{
			UInt16 pressDuration = _debouncedInput.readDurationInTrueState_mS();
			int increments = 0;
			bool incremented = false;
			bool pressed = false;
			if (pressDuration > 0)
			{
				if (_lastPressDuration >= pressDuration)
				{
					_lastPressDuration = 0;
				}

				if (pressDuration > _mediumToFastTransistion_mS)
				{
					// Increment fast
					increments = (pressDuration - _lastPressDuration) / _fast_mS_betweenIncrements;
					_variableToIncrement += _fastIncrement * increments;
					_lastPressDuration +=  _fast_mS_betweenIncrements* increments;
				}
				else if (pressDuration > _slowToMediumTransition_mS)
				{
					// Increment medium
					increments = (pressDuration - _lastPressDuration) / _medium_mS_betweenIncrements;
					_variableToIncrement += _mediumIncrement * increments;
					_lastPressDuration += _medium_mS_betweenIncrements * increments;
				}
				else
				{
					//Increment slow
					increments = (pressDuration - _lastPressDuration) / _slow_mS_betweenIncrements;
					_variableToIncrement += _slowIncrement * increments;
					_lastPressDuration += _slow_mS_betweenIncrements * increments;
					incremented = increments > 0;  // An increment happened
				}
				if (incremented)
				{
					_debouncedInput.transitions = 0;  // Get rid of false->true transition so that final release doesn't cause and increment
				}
				pressed = true;
			}
			else
			{
				// Button isn't currently pressed.  if there were other transitions, add them
				_lastPressDuration = 0;
				int presses = _debouncedInput.transitions / 2;
				_variableToIncrement += _slowIncrement * presses;
				_debouncedInput.transitions -= (UInt16)(presses * 2);
			}

			if (_variableToIncrement > highLimit)
			{
				_variableToIncrement = highLimit;
			}
			if (_variableToIncrement < lowLimit)
			{
				_variableToIncrement = lowLimit;
			}

			return (pressed);
		}

	}
}
