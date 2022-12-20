using System;
using System.Text;
using System.Threading;
using SerialWombat;

/*
This example shows how to configure a Serial Wombat 18AB pin to Touch input and determine working
calibration constants for the touch sensor.

SerialWombat18CapTouch class documentation can be found here:
https://broadwellconsultinginc.github.io/SerialWombatArdLib/class_serial_wombat18_cap_touch.html#details


NOTE!   VERSION 2.0.5 of the SW18AB firmware has a bug which prevents configuration of digital mode for the
Touch input.  You must upgrade if you have version 2.0.5 and want to use this feature.


A demonstration video of this class can be found here:
https://youtu.be/c4B0_DRVHs0

*/



namespace SW_Cs_Touch_Calibration
{
    class Program
    {
        static SerialWombatChip sw = new SerialWombatChip();
        static SerialWombat18CapTouch capTouch = new SerialWombat18CapTouch(sw);
        const byte TOUCH_PIN = 19;  // <<<<<<<<<   Set this to the Serial Wombat pin connected to the touch pad
        static UInt16 lastDigitalRead = 2;
        static void setup()
        {
            // put your setup code here, to run once:
            sw.begin("COM98");  //<<<<<<<<<<<<<<<   Set your COM port here

            UInt16 noTouchReading = 0;
            UInt16 chargeTime = 250;
            capTouch.begin(TOUCH_PIN, chargeTime, 0);
            Thread.Sleep(500);
            noTouchReading = sw.readPublicData(TOUCH_PIN);

            while (noTouchReading < 60000)
            {
                if (noTouchReading < 30000)
                {
                    chargeTime += 250;
                }
                else
                {
                    chargeTime += 250;
                }
                capTouch.begin(TOUCH_PIN, chargeTime, 20);
                Thread.Sleep(500);
                noTouchReading = sw.readPublicData(TOUCH_PIN);
                Console.Write(chargeTime);
                Console.Write(": ");
                Console.WriteLine(noTouchReading);

            }
            UInt16 recommendedChargeTime = chargeTime;

            Console.Write("Recommended charge time: ");
            Console.WriteLine(recommendedChargeTime);
            Console.WriteLine();


            // Now take a bunch of samples at that charge to see how much varation you get.  Find the
            // smallest returned value over 5 seconds.
            Console.WriteLine("Calibrating High Limit...");
            UInt16 HighLimit = 65535;
            UInt32 start = sw.millis();
            while (start + 5000 > sw.millis())
            {
                UInt16 result = sw.readPublicData(TOUCH_PIN);

                if (result < HighLimit)
                {
                    HighLimit = result;
                    Console.WriteLine(HighLimit);

                }
                Thread.Sleep(0);
            }



            Console.WriteLine("Lightly Hold finger on sensor until told to remove...");
            // Wait for the user to touch the sensor  
            while (sw.readPublicData(TOUCH_PIN) > HighLimit - 1500)
            {
                Thread.Sleep(250);
                Console.Write(".");
            }
            Console.WriteLine();


            // Now take 5 seconds worth of samples to determine the maximum value you're likely to see
            // while touched.
            UInt16 LowLimit = 0;
            start = sw.millis();
            while (start + 5000 > sw.millis())
            {
                UInt16 result = sw.readPublicData(TOUCH_PIN);

                if (result > LowLimit)
                {
                    LowLimit = result;
                    Console.WriteLine(LowLimit);
                }
            }

            Console.WriteLine("Remove Finger.");
            Console.Write("Recommended charge time: ");
            Console.WriteLine(recommendedChargeTime);
            Console.Write("Recommended High Limit: ");
            Console.WriteLine(LowLimit + (HighLimit - LowLimit) * 3 / 4);
            Console.Write("Recommended Low Limit: ");
            Console.WriteLine(LowLimit + (HighLimit - LowLimit) / 4);

            Console.WriteLine("Done.");

            Console.WriteLine();
            Console.WriteLine("Configuring Touch in digital mode using calibrations.  Code is:");
            Console.WriteLine();
            Console.Write(" capTouch.begin(TOUCH_PIN,"); Console.Write(recommendedChargeTime); Console.WriteLine(",0);");
            Console.Write("capTouch.makeDigital("); Console.Write(LowLimit); Console.Write(","); Console.Write(HighLimit); Console.WriteLine(",1,0,0,0);");
            Console.WriteLine();

            capTouch.makeDigital(LowLimit, HighLimit, 1, 0,false,0);
            Thread.Sleep(250);
            lastDigitalRead = sw.readPublicData(TOUCH_PIN);

        }

        static byte count = 0;
        //In the loop look for a change in state on the sensor and print a 0 or 1
        static void loop()
        {

            UInt16 newValue = sw.readPublicData(TOUCH_PIN);

            if (newValue != lastDigitalRead)
            {
                Console.Write(newValue); Console.Write(" ");
                lastDigitalRead = newValue;
                ++count;
                if (count > 20)
                {
                    count = 0;
                    Console.WriteLine();
                }
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
