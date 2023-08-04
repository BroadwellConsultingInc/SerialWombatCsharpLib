using System;
using System.Collections.Generic;

namespace SerialWombat
{
    /// \brief A Class that consumes CPU time on the Serial Wombat chip in order to facilitate testing 
    ///
    /// This class is only supported on the Serial Wombat SW18AB chip.  It is not supported on the
    /// Serial Wombat 4X line.
    /// 
    /// This class provides a means to consume throughput inside of a pin in order to test different CPU loading secenarios.  
    /// 
    /// This class provides an array of 16 delays measured in uS.  When each
    /// frame runs the cumulative frame counter is taken mod 16 to determine
    /// which delay to use.  During this delay the pin goes high and waits in a 
    /// loop for approximately the specified number of uS. 
    /// 
    public class SerialWombatThroughputConsumer :  SerialWombatPin
    {

        /// \brief Constructor for SerialWombatThroughputConsumer class
        /// \param serialWombat SerialWombatChip on which the ThroughputConsumer will run
        public SerialWombatThroughputConsumer(SerialWombatChip serialWombatChip):base(serialWombatChip)
        {
            _pinMode = (byte)SerialWombatPinModes.PIN_MODE_THROUGHPUT_CONSUMER;
        }


        /// \brief Initialize an instance of the Throughput Conumer class.  All delays are set to 0.
        ///
        /// \return Returns a negative error code if initialization failed.
        public Int32 begin(byte Pin)
        {
            _pin = Pin;

            byte[] tx = { 200, _pin, _pinMode, 0x55,0x55,0x55,0x55,0x55};
  

            byte[] rx;
            Int16 result =  _sw.sendPacket(tx,out rx);
           
                return result;
   

        }
        /// \brief Set all delay times to a specified number of uS
        ///
        /// \param delay  The number of uS to delay in each frame
        /// \return Returns a negative error code if errors occur during configuration 
        /// 
        public Int16 writeAll(UInt16 delay)
        {
            byte[] tx = { 201, _pin, _pinMode, 0, (byte)(delay & 0xFF), (byte)(delay >>8), 0x55, 0x55 };
            Int16 result = -1;
            for (byte i = 0; i < 16; ++i)
            {
                tx[3] = i;
                result = _sw.sendPacket(tx);
                if (result < 0)
                {
                    return result;
                }
            }
            return result;

    }
        /// \brief Set a frame delay time to a specified number of uS
        ///
        /// \param frame The frame number (0-15) to set
        /// \param delay  The number of uS to delay in each frame
        /// \return Returns a negative error code if errors occur during configuration 
        /// 
        public Int16 write(byte frame, UInt16 delay)
        {
            byte[] tx = { 201, _pin, _pinMode, frame, (byte)(delay & 0xFF), (byte)(delay >> 8), 0x55, 0x55 };
            return _sw.sendPacket(tx);
        }

        /// \brief Delay a specified number of uS within the packet processing routine
        ///
        /// \param delay  The number of uS to delay in each frame
        /// \return Returns a negative error code if errors occur during configuration 
        /// 
        public Int16 delayInCommProcessing(UInt16 delay)
        {
            byte[] tx = { 222, _pin, _pinMode, (byte)(delay & 0xFF), (byte)(delay >> 8), 0x55, 0x55, 0x55 };
            return (_sw.sendPacket(tx));
        }
    }



}
