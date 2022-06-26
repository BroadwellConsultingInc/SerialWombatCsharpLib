using System;
using System.Text;
using System.Threading;
using SerialWombat;

namespace SW18AB_Cs_LQ_Ex02_40x4
{
    class Program
    {
        static SerialWombatChip sw = new SerialWombatChip();
        static SerialWombatLiquidCrystal lcd0 = new SerialWombatLiquidCrystal(sw, 15, 14, 16, 17, 18, 19);
        static SerialWombatQueue q = new SerialWombatQueue(sw);
        static byte[] testString = Encoding.ASCII.GetBytes("ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789One Two Three Four Five Six Seven Eight Nine Ten Uno Dos Tres Quatro Cinco Seis Siete Ocho Nueve 0x01 0x02 0x03 0x04 0x05 0x06 0x07 0x08 0x09 0x0A 0x0B 0x0C 0x0D 0x0E 0x0F 0x10 0x11");// The Quick Brown Fox Jumped over the Lazy Dog.The Early bird gets the worm.Never eat soggy waffles.Righty Tighty Lefty Loosey");

        static void setup()
        {
            sw.begin("COM98");
            lcd0.begin(40, 2);   // Note that height is 2, not 4 because there's really two 40x2 displays, not one 40x4 display
            lcd0.beginE2(13);

            lcd0.setRowOffsets(0, 0x40, 0x0, 0x40);
            lcd0.initializeBufferCopy(8, 40);

            q.begin(0, 160, SerialWombatQueueType.QUEUE_TYPE_RAM_BYTE_SHIFT);
        }

        static int stringCounter = 0;

        static void loop()
        {

            // put your main code here, to run repeatedly:
            q.write(testString[stringCounter]);
            Thread.Sleep(250);
            ++stringCounter;
            if (stringCounter >= testString.Length)
            {
                stringCounter = 0;
            }
        }
        static void Main(string[] args)
        {
            setup();

            while (true)
            {
                loop();
                Thread.Sleep(0);
            }
        }
    }
}
