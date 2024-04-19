using System;
using System.Text;
using SerialWombat;

namespace SerialWombatChipFinder
{
    class Program
    {
 
        static void Main(string[] args)
        {
            SerialWombatChip sw;
            sw = new SerialWombatChip();

            sw.begin("COM14",false);


            if (sw.queryVersion())
            {
                Console.WriteLine("Serial Wombat chip Found.");
                if (sw.inBoot)
                {
                    Console.WriteLine("Serial Wombat chip is in boot mode.");
                }
                Console.Write("Model: ");
                Console.WriteLine(Encoding.UTF8.GetString(sw.model));
                if (sw.inBoot)
                {
                    Console.Write("Boot ");
                }
                Console.Write("FW Version: ");
                Console.WriteLine(Encoding.UTF8.GetString(sw.fwVersion));


                Console.Write("UniqueID: ");
                for (int i = 0; i < sw.uniqueIdentifierLength; ++i)
                {
                    Console.Write($"{sw.uniqueIdentifier[i]:X2} ");
                }
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
                    UInt16 temperature = sw.readTemperature_100thsDegC();
                    Console.Write(temperature / 100);
                    Console.Write(".");
                    Console.WriteLine(temperature % 100);
                }
            }
            else
            {
                Console.WriteLine("Device did not respond properly to Serial Wombat version information inquiry");
            }
            Console.WriteLine();
            Console.WriteLine();
       
        }
    }
}
