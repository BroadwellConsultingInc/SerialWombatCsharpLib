using System;
using System.Threading;
using SerialWombat;
namespace SerialWombatChipFinder
{
    class Program
    {
        static SerialWombatChip sw = new SerialWombatChip();
        

        static void setup()
        {
            sw.begin("COM98");  // PUT YOUR COM PORT HERE!

        }

        static void loop()
        {
            if (sw.queryVersion())  // Does the response to a version query look reasonable?
            {
                //Yes
                Console.WriteLine("Serial Wombat chip Found.");
                if (sw.inBoot)
                {
                    Console.WriteLine("Serial Wombat chip is in boot mode.");
                }
                Console.Write("Model: ");
                Console.WriteLine(System.Text.Encoding.ASCII.GetString(sw.model));
                if (sw.inBoot)
                {
                    Console.Write("Boot ");
                }
                Console.Write("FW Version: ");
                Console.WriteLine(System.Text.Encoding.ASCII.GetString(sw.fwVersion));


                Console.Write("UniqueID: ");
                for (int i = 0; i < sw.uniqueIdentifierLength; ++i)
                    Console.Write($"{sw.uniqueIdentifier[i]:X2} ");
                Console.WriteLine();

                Console.Write("Microcontroller DeviceId: ");
                Console.WriteLine(sw.deviceIdentifier);

                Console.Write("Microcontroller DeviceRevision: ");
                Console.WriteLine(sw.deviceRevision);
                Console.Write("Source voltage (mV):  ");
                Console.WriteLine(sw.readSupplyVoltage_mV());

                if (sw.isSW18())
                {
                    Console.Write("Low Accuracy Temperature (deg C):  ");
                    Int16 temperature = sw.readTemperature_100thsDegC();
                    Console.Write(temperature / 100);
                    Console.Write(".");
                    Console.WriteLine(temperature % 100);
                    /*TODO
                    Console.Write("Birthday: ");
                    Console.WriteLine(sw.readBirthday());
                    char brand[33];
                    sw.readBrand(brand);
                    Console.Write("Brand: ");
                    Console.WriteLine(brand);
                    */
                }
            }
            else
            {
                //No
                Console.WriteLine("Device did not respond properly to Serial Wombat version information inquiry");
            }
            Console.WriteLine();
            Console.WriteLine();
            Thread.Sleep(30000);
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
