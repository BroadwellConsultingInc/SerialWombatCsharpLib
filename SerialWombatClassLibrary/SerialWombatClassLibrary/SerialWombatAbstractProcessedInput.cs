using System;
using System.Collections.Generic;
using System.Text;

namespace SerialWombat
{
    public class SerialWombatAbstractProcessedInput : SerialWombatPin
    {
        public SerialWombatAbstractProcessedInput(SerialWombatChip chip) : base(chip)
        {

        }

        
        public enum Period
        {
            PERIOD_1024mS = 0,
            PERIOD_512mS = 1,
            PERIOD_256mS = 2,
            PERIOD_128mS = 3,
            PERIOD_64mS = 4,
            PERIOD_32mS = 5,
            PERIOD_16mS = 6,
            FREQ_8mS = 7,
            PERIOD_4mS = 8,
            PERIOD_2mS = 9,
            FREQ_1mS = 10

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

            if (m < 0)
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

    }
    public enum ProcessedInputOutputValue
    {
        RAW = 0,
        FIRST_ORDER_FILTERED = 1,
        AVERAGE = 2,
       
    };
}

