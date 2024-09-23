using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SerialWombat
{
    public enum DataLoggerPeriod
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
    public class SerialWombat18ABDataLogger
    {
        SerialWombatChip _sw;
        public SerialWombatQueue queue;
        
        public SerialWombat18ABDataLogger(SerialWombatChip sw)
        {
            _sw = sw;
        }

        public Int16 begin(UInt16 queueAddress,UInt16 queueSizeBytes, bool queueFrameIndex = true, bool queueOnChange = false, DataLoggerPeriod period = DataLoggerPeriod.FREQ_1mS  )
        {
            queue = new SerialWombatQueue(_sw);
            Int16 result = queue.begin(queueAddress, queueSizeBytes);
            if (result < 0) return (result);
            {
                byte[] tx = {(byte)SerialWombatCommands.COMMAND_BINARY_CONFIG_DATALOGGER,
                0, //Initial Config
                (byte)(queueAddress & 0xFF),
                (byte)(queueAddress >>8),
                (byte)(period),
                queueFrameIndex?(byte)1:(byte)0,
                queueOnChange?(byte)1:(byte)0,
                };
                return(_sw.sendPacket(tx));
            }
        }

        public Int16 enable(bool enable = true)
        {
            byte[] tx = {(byte)SerialWombatCommands.COMMAND_BINARY_CONFIG_DATALOGGER,
                1, //Logger total Enable / Disable
                enable?(byte)1:(byte)0,
                };
            return (_sw.sendPacket(tx));
        }

        public Int16 configurePin(byte pin, bool queueLowByte, bool queueHighByte)
        {
            byte[] tx = {(byte)SerialWombatCommands.COMMAND_BINARY_CONFIG_DATALOGGER,
                2, //Configure individual pins
                pin,
                queueLowByte?(byte)1:(byte)0,
                                queueHighByte?(byte)1:(byte)0,
            };
            return (_sw.sendPacket(tx));
        }
    }
}
