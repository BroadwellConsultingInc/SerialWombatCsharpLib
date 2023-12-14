using Microsoft.VisualBasic;
using SerialWombat;
using System;
using System.Collections.Generic;
/*
Copyright 2020-2023 Broadwell Consulting Inc.

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
/*! \file SerialWombatUltrasonicDistanceSensor.cs
*/
namespace SerialWombat
{
    public enum UltrasonicDriver
    {
        HC_SR04 = 0
    };

    /*! \brief A Class which uses one or two Serial Wombat 18AB pins to measure distance using an Ultrasonic distance sensor.  


    A video Tutorial on this pin mode is available:

    \htmlonly
    //TODO
    \endhtmlonly

    //TODO https://youtu.be/

    Documentation for the SerialWombatUltrasonicDistanceSensor class is available at:
    https://broadwellconsultinginc.github.io/SerialWombatArdLib/class_serial_wombat_ultrasonic_distance_sensor.html


    */
    public class SerialWombatUltrasonicDistanceSensor :  SerialWombatAbstractProcessedInput
    {
        

        public SerialWombatUltrasonicDistanceSensor(SerialWombatChip serialWombatChip):base(serialWombatChip)
        {
            _pinMode = (byte)SerialWombatPinModes.PIN_MODE_ULTRASONIC_DISTANCE;
        }



        /// \brief Initialization routine for SerialWombatUltrasonicDistanceSensor
        /// 
        /// \param echoPin Pin used to time input pulses.  For 5V sensors, 5V tolerant pins 9,10,11,12, 14 and 15 are good choices
        /// \param driver Chip used for distance measurement.  Currently only HC_SR04 is supported.
        /// \param triggerPin Pin used for triggering the sensor.  If same as echo pin (e.g. 3 pin sensors) set equal to echoPin
        /// \return 0 or higher if successful, negative error code if not successful.
        public Int16 begin(byte echoPin, UltrasonicDriver driver, byte triggerPin, bool autoTrigger = true, bool pullUp =false)
        {
            _pin = echoPin;

            byte[] tx = { 200, _pin, _pinMode, (byte)driver, triggerPin,(byte)(pullUp?1:0), (byte)(autoTrigger ? 1 : 0), 0x55 };

            return _sw.sendPacket(tx);
        }

        /// \brief get the number of pulses that have been sent.  
        ///
        /// \return The number of pulses that have been sent.  Rolls over at 65536
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

        /// \brief Manually trigger a distance reading
        ///
        /// Use this interface to trigger a reading if begin was called with autoTrigger = false
        /// \return 0 or higher if successful, negative error code if not successful.
        Int16 manualTrigger()
        {
            byte[] tx = { 201, _pin, _pinMode, 1, 0x55, 0x55, 0x55, 0x55 };

            return _sw.sendPacket(tx);
        }


    }



}

