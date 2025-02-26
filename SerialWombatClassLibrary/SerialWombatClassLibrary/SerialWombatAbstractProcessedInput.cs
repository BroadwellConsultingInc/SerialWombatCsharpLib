﻿using System;
using System.Collections.Generic;
using System.Text;
/*
Copyright 2022 Broadwell Consulting Inc.

Serial Wombat is a registered trademark in the United States of Broadwell
Consulting Inc.

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
namespace SerialWombat
{
    public class SerialWombatAbstractProcessedInput : SerialWombatPin
    {
        public SerialWombatAbstractProcessedInput(SerialWombatChip chip) : base(chip)
        {

        }


        public enum Period
        {
            PERIOD_1024mS = 10,
            PERIOD_512mS = 9,
            PERIOD_256mS = 8,
            PERIOD_128mS = 7,
            PERIOD_64mS = 6,
            PERIOD_32mS = 5,
            PERIOD_16mS = 4,
            FREQ_8mS = 3,
            PERIOD_4mS = 2,
            PERIOD_2mS = 1,
            FREQ_1mS = 0

        };



        public enum Transform
        {
            NONE = 0,
            SCALE_RANGE = 1,
            LINEAR_MXB = 2
        };



        public void begin(byte pin, SerialWombatPinModes mode)
        {
            begin(pin, (byte)mode);
        }

        public void begin(byte pin, byte pinMode)
        {
            _pin = pin;
            _pinMode = pinMode;
        }

        public Int16 writeProcessedInputEnable(bool enabled)
        {
            byte[] tx = { (byte)SerialWombatCommands.CONFIGURE_PIN_INPUTPROCESS,
        _pin,
        swPinModeNumber,
        0,
        (byte)(enabled?1:0),
        0x55,0x55,0x55
    };

            Int16 result = _sw.sendPacket(tx);

            return (result);
        }

        public UInt16 readMinimum(bool reset)
        {
            byte[] tx = { (byte)SerialWombatCommands.CONFIGURE_PIN_INPUTPROCESS,
        _pin,
        swPinModeNumber,
        9,
        (byte)(reset?1:0),
        0x55,0x55,0x55
    };
            byte[] rx;
            Int16 result = _sw.sendPacket(tx, out rx);
            if (result < 0)
            {
                return (65535);
            }
            return ((UInt16)(rx[4] + 256 * rx[5]));
        }

        public UInt16 readMaximum(bool reset)
        {
            byte[] tx = { (byte)SerialWombatCommands.CONFIGURE_PIN_INPUTPROCESS,
        _pin,
        swPinModeNumber,
        10,
        (byte)(reset?1:0),
        0x55,0x55,0x55
    };
            byte[] rx;
            Int16 result = _sw.sendPacket(tx, out rx);
            if (result < 0)
            {
                return (65535);
            }
            return ((UInt16)(rx[4] + 256 * rx[5]));
        }

        public UInt16 readAverage()
        {
            byte[] tx = { (byte)SerialWombatCommands.CONFIGURE_PIN_INPUTPROCESS,
        _pin,
        swPinModeNumber,
        11,
        0x55,0x55,0x55,0x55
    };
            byte[] rx;
            Int16 result = _sw.sendPacket(tx, out rx);
            if (result < 0)
            {
                return (0);
            }
            return ((UInt16)(rx[4] + 256 * rx[5]));
        }

        public UInt16 readFiltered()
        {
            byte[] tx = { (byte)SerialWombatCommands.CONFIGURE_PIN_INPUTPROCESS,
        _pin,
        swPinModeNumber,
        11,
        0x55,0x55,0x55,0x55
    };
            byte[] rx;
            Int16 result = _sw.sendPacket(tx, out rx);
            if (result < 0)
            {
                return (0);
            }
            return ((UInt16)(rx[6] + 256 * rx[7]));
        }

        public Int16 writeInverted(bool inverted)
        {
            byte[] tx = { (byte)SerialWombatCommands.CONFIGURE_PIN_INPUTPROCESS,
        _pin,
        swPinModeNumber,
        3,
        (byte) (inverted?1:0),
        0x55,0x55,0x55
    };

            Int16 result = _sw.sendPacket(tx);

            return (result);
        }

        public Int16 writeFirstOrderFilteringConstant(UInt16 constant)
        {
            byte[] tx = { (byte)SerialWombatCommands.CONFIGURE_PIN_INPUTPROCESS,
        _pin,
        swPinModeNumber,
        11,
        (byte)(constant & 0xFF),(byte)(constant >>8),
        0x55,0x55
    };
            return (_sw.sendPacket(tx));
        }

        public Int16 writeAveragingNumberOfSamples(UInt16 numberOfSamples)
        {
            byte[] tx = { (byte)SerialWombatCommands.CONFIGURE_PIN_INPUTPROCESS,
        _pin,
        swPinModeNumber,
        1,
        (byte)(numberOfSamples & 0xFF),(byte)(numberOfSamples >>8),
        0x55,0x55
    };

            Int16 result = _sw.sendPacket(tx);

            return (result);
        }

        public Int16 writeExcludeBelowAbove(UInt16 low, UInt16 high)
        {
            byte[] tx = { (byte)SerialWombatCommands.CONFIGURE_PIN_INPUTPROCESS,
        _pin,
        swPinModeNumber,
        2,
        (byte)(low & 0xFF),(byte)(low >>8),
        (byte)(high & 0xFF),(byte)(high >>8)
    };

            Int16 result = _sw.sendPacket(tx);

            return (result);
        }

        public Int16 configureQueue(SerialWombatQueue queue, Period period, bool queueHighByte, bool queueLowByte)
        {
            byte[] tx = { (byte)SerialWombatCommands.CONFIGURE_PIN_INPUTPROCESS,
        _pin,
        swPinModeNumber,
        5,
        (byte)(queue.startIndex & 0xFF),
        (byte)(queue.startIndex >>8)
        ,(byte)period,
        (byte)((queueHighByte?2:0) |(queueLowByte?1:0))
    };

            Int16 result = _sw.sendPacket(tx);

            return (result);
        }

        public Int16 configureOutputValue(ProcessedInputOutputValue outputValue)
        {
            byte[] tx = { (byte)SerialWombatCommands.CONFIGURE_PIN_INPUTPROCESS,
        _pin,
        swPinModeNumber,
        4,
        (byte)outputValue,
        0x55,0x55,0x55
    };

            Int16 result = _sw.sendPacket(tx);

            return (result);
        }

        public Int16 writeTransformScaleRange(UInt16 min, UInt16 max)
        {
            byte[] tx = { (byte)SerialWombatCommands.CONFIGURE_PIN_INPUTPROCESS,
        _pin,
        swPinModeNumber,
        6,
        (byte)(min & 0xFF),(byte)(min >>8),
        (byte)(max & 0xFF),(byte)(max >>8)
    };

            Int16 result = _sw.sendPacket(tx);

            return (result);
        }

        public Int16 writeTransformLinearMXB(Int32 m, Int32 b)
        {
            UInt32 m32;

            if (m < 0)
            {
                m32 = (UInt32)(((Int64)m) + (((Int64)1) << 32));
            }
            else
            {
                m32 = (UInt32)m;
            }
            byte[] tx = { (byte)SerialWombatCommands.CONFIGURE_PIN_INPUTPROCESS,
        _pin,
        swPinModeNumber,
        7,
        (byte)((m32) & 0xFF),(byte)(((m32) >>8)& 0xff),(byte)(((m32) >>16)& 0xFF), (byte)((m32)>>24),
    };

            Int16 result = _sw.sendPacket(tx);
            if (result < 0)
            {
                return (result);
            }

            UInt32 b32;

            if (b < 0)
            {
                b32 = (UInt32)(((Int64)b) + (((Int64)1) << 32));
            }
            else
            {
                b32 = (UInt32)b;
            }
            byte[] tx2 = { (byte)SerialWombatCommands.CONFIGURE_PIN_INPUTPROCESS,
        _pin,
        swPinModeNumber,
        8,
        (byte)((b32) & 0xFF),(byte)(((b32) >>8)& 0xff),(byte)(((b32) >>16)& 0xFF), (byte)((b32)>>24),
    };
            result = _sw.sendPacket(tx2);
            return (result);
        }

        public Int16 configureIntegrator(UInt16 negativeMaxIndex, UInt16 negativeMidIndex,
            UInt16 negativeDeadZone, UInt16 positiveDeadZone, UInt16 positiveMidIndex,
            UInt16 positiveMaxIndex, UInt16 midIncrement, UInt16 maxIncrement, UInt16 initialValue,byte updateRateMask = 0)
        {
            {
                byte[] tx = { (byte)SerialWombatCommands.CONFIGURE_PIN_INPUTPROCESS,
                _pin,
                swPinModeNumber,
                12,
                (byte)(negativeMaxIndex & 0xFF),(byte)(negativeMaxIndex >>8),
                (byte)(negativeMidIndex & 0xFF),(byte)(negativeMidIndex >>8),
                };
                Int16 result = _sw.sendPacket(tx);

                if (result < 0) return (result);
            }
            {
                byte[] tx = { (byte)SerialWombatCommands.CONFIGURE_PIN_INPUTPROCESS,
                _pin,
                swPinModeNumber,
                13,
                (byte)(negativeDeadZone & 0xFF),(byte)(negativeDeadZone >>8),
                (byte)(positiveDeadZone & 0xFF),(byte)(positiveDeadZone >>8),
                };
                Int16 result = _sw.sendPacket(tx);

                if (result < 0) return (result);
            }
            {
                byte[] tx = { (byte)SerialWombatCommands.CONFIGURE_PIN_INPUTPROCESS,
                _pin,
                swPinModeNumber,
                14,
                (byte)(positiveMidIndex & 0xFF),(byte)(positiveMidIndex >>8),
                (byte)(positiveMaxIndex & 0xFF),(byte)(positiveMaxIndex >>8),
                };
                Int16 result = _sw.sendPacket(tx);

                if (result < 0) return (result);
            }
            {
                byte[] tx = { (byte)SerialWombatCommands.CONFIGURE_PIN_INPUTPROCESS,
                _pin,
                swPinModeNumber,
                15,
                (byte)(initialValue & 0xFF),(byte)(initialValue >>8),
                0,0
                };
                Int16 result = _sw.sendPacket(tx);

                if (result < 0)  return (result);
            }
            {
                byte[] tx = { (byte)SerialWombatCommands.CONFIGURE_PIN_INPUTPROCESS,
                _pin,
                swPinModeNumber,
                16,
                (byte)(midIncrement & 0xFF),(byte)(midIncrement >>8),
                (byte)(maxIncrement & 0xFF),(byte)(maxIncrement >>8),
                };
                Int16 result = _sw.sendPacket(tx);

                if (result < 0) return (result);
            }
            {
                byte[] tx = { (byte)SerialWombatCommands.CONFIGURE_PIN_INPUTPROCESS,
                _pin,
                swPinModeNumber,
                17,
                updateRateMask,0,0,0
                };
                Int16 result = _sw.sendPacket(tx);

                return (result);
            }
        }
    }
        public enum ProcessedInputOutputValue
        {
            RAW = 0,
            FIRST_ORDER_FILTERED = 1,
            AVERAGE = 2,

        };
    
}

