using System;
using System.Threading;
using SerialWombat;

namespace SW18AB_Cs_Ex01_AnalogInput
{
    class Program
    {
        static SerialWombatChip sw = new SerialWombatChip();
        static SerialWombatAnalogInput swAn0 = new SerialWombatAnalogInput(sw);
        static SerialWombatServo swServo = new SerialWombatServo(sw);
        static void setup()
        {
            sw.begin("COM98");  // Put your COM port here
            swAn0.begin(0);  // Begin on pin 0
            swServo.attach(10);

        }

        static void loop()
        {
            UInt16 analogReading = swAn0.readCounts();
            Console.WriteLine(analogReading);
            swServo.write16bit(analogReading);
            Thread.Sleep(100);
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
