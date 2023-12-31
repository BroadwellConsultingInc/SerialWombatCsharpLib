using Microsoft.VisualBasic;
using SerialWombat;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
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

        private UInt16 servoMemoryIndex;
        private UInt16 servoPositions;
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
        public Int16 manualTrigger()
        {
            byte[] tx = { 201, _pin, _pinMode, 1, 0x55, 0x55, 0x55, 0x55 };

            return _sw.sendPacket(tx);
        }

        /// \brief Configure a Servo sweep of Ultrasonic Distance Sensor
        
        public Int16 configureServoSweep(byte servoPin,UInt16 memoryIndex,UInt16 servoPositions,UInt16 servoIncrement, bool reverse = false,  UInt16 servoMoveDelay = 100, UInt16 servoReturnDelay = 1000)
        {
            {
                byte[] tx = { 203, _pin, _pinMode, servoPin, (byte)(memoryIndex & 0xFF), (byte)(memoryIndex >>8),
                (byte)(servoPositions & 0xFF),(byte)(servoPositions >>8)};
                Int16 result = _sw.sendPacket(tx);
                if (result < 0) { return result; }
            }
            {
                byte[] tx = { 204, _pin, _pinMode,  (byte)(servoIncrement & 0xFF), (byte)(servoIncrement >>8),
                0x55,0x55, (byte)(reverse?1:0)};
                Int16 result = _sw.sendPacket(tx);
                if (result < 0) { return result; }
            }
            {
                byte[] tx = { 205, _pin, _pinMode,  (byte)(servoMoveDelay & 0xFF), (byte)(servoMoveDelay >>8),
                (byte)(servoReturnDelay & 0xFF),(byte)(servoReturnDelay >>8), 0x55};
                Int16 result = _sw.sendPacket(tx);
                if (result < 0) { return result; }
            }
            servoMemoryIndex = memoryIndex;
            this.servoPositions = servoPositions;
            return 0;
        }
        public Int16 enableServoSweep(bool enable)
        {
            byte[] tx = { 206, _pin, _pinMode,  (byte)(enable?1:0),0x55,0x55,0x55, 0x55};
           return _sw.sendPacket(tx);
        }

        public UInt16 readServoSweepEntry(UInt16 servoSweepEntry)
        {
            byte[] b = new byte[2];
            _sw.readUserBuffer((UInt16)(servoMemoryIndex + 2 * servoSweepEntry), b, 2);
            return ((UInt16)(b[0] + 256 * b[1]));
        }

        public UInt16[] readServoSweepEntries()
        {
            byte[] b = new byte[servoPositions * 2];
            _sw.readUserBuffer(servoMemoryIndex, b,(UInt16)( 2 * servoPositions));
            UInt16[] data = new UInt16[servoPositions];
            for (int i = 0; i < data.Length; i++)
            {
                data[i] = (UInt16)(b[i * 2] + 256 * b[i * 2 + 1]);
            }

            return data;
        }
    }



}

