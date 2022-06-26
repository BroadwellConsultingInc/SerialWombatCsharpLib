using System;
using System.Collections.Generic;

namespace SerialWombat
{
    public enum UltrasonicDriver
    {
        HC_SR04 = 0
    } ;
    public class SerialWombatUltrasonicDistanceSensor :  SerialWombatPin
    {
        

        public SerialWombatUltrasonicDistanceSensor(SerialWombatChip serialWombatChip):base(serialWombatChip)
        {
            _pinMode = (byte)SerialWombatPinModes.PIN_MODE_ULTRASONIC_DISTANCE;
        }

       
      
        public Int16 begin(byte echoPin, UltrasonicDriver driver, byte triggerPin, bool autoTrigger = true, bool pullUp =false)
        {
            _pin = echoPin;

            byte[] tx = { 200, _pin, _pinMode, (byte)driver, triggerPin,(byte)(pullUp?1:0), (byte)(autoTrigger ? 1 : 0), 0x55 };

            return _sw.sendPacket(tx);
        }

        public UInt16 readPulseCount()
        {
            byte[] tx = { 202, _pin, _pinMode, 0x55, 0x55, 0x55, 0x55, 0x55 };
            byte[] rx;
            if (_sw.sendPacket(tx,out rx) >= 0)
            {
                return ((UInt16)(rx[5] + 256 * rx[6]));
            }
            else
            {
                return 0;
            }
        }

        Int16 manualTrigger()
        {
            byte[] tx = { 201, _pin, _pinMode, 1, 0x55, 0x55, 0x55, 0x55 };

            return _sw.sendPacket(tx);
        }


    }



}
