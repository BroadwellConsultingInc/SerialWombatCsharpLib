using System;
using System.Collections.Generic;

namespace SerialWombat
{
   
    public class SerialWombatHSClock :  SerialWombatPin
    {
        

        public SerialWombatHSClock(SerialWombatChip serialWombatChip):base(serialWombatChip)
        {
            _pinMode = (byte)SerialWombatPinModes.PIN_MODE_HS_CLOCK;
        }

       
      
        public Int32 begin(byte Pin, UInt32 frequency)
        {
            _pin = Pin;

            byte[] tx = { 200, _pin, _pinMode, 0x55,0x55,0x55,0x55,0x55};
            BitConverter.GetBytes(frequency).CopyTo(tx, 3);

            byte[] rx;
            Int32 result =  _sw.sendPacket(tx,out rx);
            if (result < 0)
            {
                return result;
            }

            return (rx[3] + rx[4] * 256 + rx[5] * 65536);

        }

        public Int16 disable()
        {
            byte[] tx = { 219, _pin, _pinMode, 0x55, 0x55, 0x55, 0x55, 0x55 };
            return (_sw.sendPacket(tx));

    }

    }



}
