using System;
using System.Text;
using System.Threading;
using SerialWombat;

namespace SW18AB_Cs_LQ_Ex02_20x4
{
    class Program
    {
        static SerialWombatChip sw = new SerialWombatChip();
        static SerialWombatLiquidCrystal lcd0 = new SerialWombatLiquidCrystal(sw, 4, 5, 0, 1, 2, 3);
        static SerialWombatQueue q = new SerialWombatQueue(sw);
        static byte[] testString =Encoding.ASCII.GetBytes( "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789One Two Three Four Five Six Seven Eight Nine Ten Uno Dos Tres Quatro Cinco Seis Siete Ocho Nueve 0x01 0x02 0x03 0x04 0x05 0x06 0x07 0x08 0x09 0x0A 0x0B 0x0C 0x0D 0x0E 0x0F 0x10 0x11");// The Quick Brown Fox Jumped over the Lazy Dog.The Early bird gets the worm.Never eat soggy waffles.Righty Tighty Lefty Loosey");

        static void setup()
        {
            sw.begin("COM98");
            lcd0.begin(20, 4);  //  Put your Width and Height here

            lcd0.setRowOffsets(0, 0x40, 0x14, 0x54);
            lcd0.initializeBufferCopy(8, 20);

            q.begin(0, 80, SerialWombatQueueType.QUEUE_TYPE_RAM_BYTE_SHIFT);
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
