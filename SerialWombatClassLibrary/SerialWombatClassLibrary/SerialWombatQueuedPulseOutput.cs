using System;
using System.Collections.Generic;

namespace SerialWombat
{
   
    public class SerialWombatQueuedPulseOutput :  SerialWombatPin
    {
        

        public SerialWombatQueuedPulseOutput(SerialWombatChip serialWombatChip):base(serialWombatChip)
        {
            _pinMode = (byte)SerialWombatPinModes.PIN_MODE_QUEUED_PULSE_OUTPUT;
        }


        /*!
          /// @brief Initialize a queued pulse output mode
          /// @param  pin The pin used to output the queued output mode 
          /// @param initialState 0 to initialize low, or 1 to initialize high
          /// @param idleState 0 to go low when queue empty, 1 to go high when queue empty
          /// @param unitsMs 0 to use uS as pulse time, 1 to use mS as pulse time
          /// @param QueueIndex if set to a value other than 0xFFFF use a previously created queue in User RAM rather than the small buffer in the pin's state machine memory
          /// @return a negative number if an error occured.
           */
        public Int32 begin(byte Pin, bool initialState = false, bool idleState = false, bool unitsMs = false, UInt16 QueueIndex = 0xFFFF)
        {
            _pin = Pin;
            _pinMode = (byte)SerialWombatPinModes.PIN_MODE_QUEUED_PULSE_OUTPUT; ;
            byte[] tx = { 200, _pin, _pinMode, (byte) (initialState?1:0), (byte)(idleState ? 1 : 0), (byte)(unitsMs ? 1 : 0), 0x55,0x55};
            BitConverter.GetBytes(QueueIndex).CopyTo(tx, 6);

            byte[] rx;
            Int32 result =  _sw.sendPacket(tx,out rx);
            if (result < 0)
            {
                return result;
            }

            return (rx[3] + rx[4] * 256 + rx[5] * 65536);

        }
      
        
        
        /*!
		/// @brief Add a pulse or two pulses to the queue
		/// @param  firstPulse A number from 1 to 32767 logical ored with 0x8000 or 0x0000 to indicate a high or low pulse of a given duration (controlled by units in begin command).  0 indicates do nothing.  
		/// @param  secondPulse A number from 1 to 32767 logical ored with 0x8000 or 0x0000 to indicate a high or low pulse of a given duration (controlled by units in begin command).  0 indicates do nothing.
		/// @return number of pulses successfully queued or a negative number if an error occured.
		 */
        public Int16 queuePulses(UInt16 firstPulse, UInt16 secondPulse = 0)
        {
            byte[] tx =
            {
                201,
                _pin,
                _pinMode,
                0x55,0x55,0x55,0x55,
                0x55
            };
            BitConverter.GetBytes(firstPulse).CopyTo(tx, 3);
            BitConverter.GetBytes(secondPulse).CopyTo(tx, 5);
            byte[] rx;
            Int16 result = _sw.sendPacket(tx, out rx);
            if (result < 0)
            {
                return (result);
            }
            else
            {
                return (rx[3]);
            }
        }
        /*!
		/// @brief Pause or unpause the generation of new pulses
		/// @param  paused Whether the generation of pulses is paused or unpaused
		/// @return negative number if an error occured.
		 */
        public Int16 pause(bool paused)
        {
            byte[] tx =
            {
                202,
                _pin,
                _pinMode,
                (byte)(paused?1:0),
                0x55,0x55,0x55, 0x55
            };
            return _sw.sendPacket(tx);
        }
    }

}
