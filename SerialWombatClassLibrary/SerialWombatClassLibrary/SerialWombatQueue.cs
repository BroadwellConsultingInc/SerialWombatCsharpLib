using System;
using System.Collections.Generic;
using System.Text;

namespace SerialWombat
{

    public enum  SerialWombatQueueType
    {
        QUEUE_TYPE_RAM_BYTE = 0,  ///< A queue that queues byte-sized data in a queue in the User RAM area
    QUEUE_TYPE_RAM_BYTE_SHIFT = 1,  ///< A queue that queues byte-sized data in a queue in the User RAM area
    };

    public class SerialWombatQueue
    {
        SerialWombatChip _sw;
        UInt16 _address;
        UInt16 _size;

        public SerialWombatQueue(SerialWombatChip serialWombatChip)
        {
            _sw = serialWombatChip;

          
        }

        public Int16 begin(UInt16 address, UInt16 size, SerialWombatQueueType queueType)
        {
            _address = address;
            _size = size;

            byte[] tx = {(byte)SerialWombatCommands.COMMAND_BINARY_QUEUE_INITIALIZE,
            (byte) (_address & 0xFF),
            (byte) (_address >>8 ),
            (byte) (_size & 0xFF),
            (byte) (_size >>8 ),
            (byte) queueType, // RAM queue
            0x55,
            0x55  };

            return _sw.sendPacket(tx);
        }
        public int read(int count, out byte[] data)
        {
            List<byte> d = new List<byte>();


            bool bytesAvailable = true;
            while (bytesAvailable && d.Count < count)
            {
                byte request = 6;
                if (count < request)
                {
                    request = (byte)(count);
                }
                byte[] tx = {(byte)SerialWombatCommands.COMMAND_BINARY_QUEUE_READ_BYTES,
            (byte) (_address & 0xFF),
            (byte) (_address >>8 ),
            request,
            0x55,
            0x55,
                0x55,
                0x55};

                byte[] rx;
                _sw.sendPacket(tx, out rx);
                if (rx[1] > 6)
                {
                    rx[1] = 6;
                }
                for (int i = 0; i < rx[1]; ++i)
                {
                    d.Add(rx[2 + i]);
                }

                if (rx[1] < request)
                {
                    bytesAvailable = false;
                }


            }


            data = d.ToArray();

            return d.Count;
        }

        public int write(byte b)
        {
            byte[] ba = { b };
            return (write(1, ba));
        }
        public int write(int count, byte[] data)
        {
            List<byte> d = new List<byte>();


            int bytesSent = 0;

            while (bytesSent < data.Length)
            {
                byte request = 4;
                if (data.Length - bytesSent < 4)
                {
                    request = (byte)(data.Length - bytesSent);
                }
                byte[] tx = {(byte)SerialWombatCommands.COMMAND_BINARY_QUEUE_ADD_BYTES,
            (byte) (_address & 0xFF),
            (byte) (_address >>8 ),
            request,
            0x55,
            0x55,
                0x55,
                0x55};
                for (int i = 0; i < request; ++i)
                {
                    tx[i + 4] = data[bytesSent + i];
                }

                

                byte[] rx;
                _sw.sendPacket(tx, out rx);
                if (rx[1] > 6)
                {
                    rx[1] = 6;
                }
                for (int i = 0; i < rx[1]; ++i)
                {
                    d.Add(rx[2 + i]);
                }

               
                bytesSent += rx[3];
                if (rx[3] < request)
                {
                    return (bytesSent);
                }

            }


           return bytesSent;
        }

        public UInt16 startIndex { get { return (_address); } }
    }
}
