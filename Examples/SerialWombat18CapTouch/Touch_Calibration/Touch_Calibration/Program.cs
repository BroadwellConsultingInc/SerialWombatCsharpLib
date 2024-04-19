using System;
using System.Threading;
using SerialWombat;

/*
This example shows how to configure a Serial Wombat 18AB pin to Touch input and determine working
calibration constants for the touch sensor.

SerialWombat18CapTouch class documentation can be found here:
https://broadwellconsultinginc.github.io/SerialWombatArdLib/class_serial_wombat18_cap_touch.html#details

A demonstration video of this class can be found here:
https://youtu.be/c4B0_DRVHs0

*/

namespace Touch_Calibration
{
    class Program
    {
        

        const byte TOUCH_PIN = 17;      //<<<<<< MODIFY THIS BASED ON WHICH PIN YOUR TOUCH SENSOR IS RUNNING ON
        const string PORTNAME = "COM14"; //<<<<<< MODIFY THIS BASED ON WHICH SERIAL PORT YOUR SW18AB is attached to
        static SerialWombatChip sw = new SerialWombatChip();
        static SerialWombat18CapTouch capTouch = new SerialWombat18CapTouch(sw);

        static UInt16 lastDigitalRead;
        static void setup()
        {
            // Set up the Serial port and I2C



            sw.begin(PORTNAME);
            //Iterate through increasing amounts of charge until we find a value that 90% saturates the sensor.
            Serial.println("Determining charge time.  Do not touch the sensor.");

            UInt16 noTouchReading = 0;
            UInt16 chargeTime = 250;
            capTouch.begin(TOUCH_PIN, chargeTime, 0);
            delay(500);
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
                delay(500);
                noTouchReading = sw.readPublicData(TOUCH_PIN);
                Serial.print(chargeTime);
                Serial.print(": ");
                Serial.println(noTouchReading);

            }
            UInt16 recommendedChargeTime = chargeTime;

            Serial.print("Recommended charge time: ");
            Serial.println(recommendedChargeTime);
            Serial.println();


            // Now take a bunch of samples at that charge to see how much varation you get.  Find the
            // smallest returned value over 5 seconds.
            Serial.println("Calibrating High Limit...");
            UInt16 HighLimit = 65535;
            UInt32 start = millis();
            while (start + 5000 > millis())
            {
                UInt16 result = sw.readPublicData(TOUCH_PIN);

                if (result < HighLimit)
                {
                    HighLimit = result;
                    Serial.println(HighLimit);

                }
                delay(0);
            }



            Serial.println("Lightly Hold finger on sensor until told to remove...");
            // Wait for the user to touch the sensor  
            while (sw.readPublicData(TOUCH_PIN) > HighLimit - 1500)
            {
                delay(250);
                Serial.print(".");
            }
            Serial.println();


            // Now take 5 seconds worth of samples to determine the maximum value you're likely to see
            // while touched.
            UInt16 LowLimit = 0;
            start = millis();
            while (start + 5000 > millis())
            {
                UInt16 result = sw.readPublicData(TOUCH_PIN);

                if (result > LowLimit)
                {
                    LowLimit = result;
                    Serial.println(LowLimit);
                }
            }

            Serial.println("Remove Finger.");
            Serial.print("Recommended charge time: ");
            Serial.println(recommendedChargeTime);
            Serial.print("Recommended High Limit: ");
            Serial.println(LowLimit + (HighLimit - LowLimit) * 3 / 4);
            Serial.print("Recommended Low Limit: ");
            Serial.println(LowLimit + (HighLimit - LowLimit) / 4);

            Serial.println("Done.");

            Serial.println();
            Serial.println("Configuring Touch in digital mode using calibrations.");
            Serial.println();

            capTouch.makeDigital(LowLimit, HighLimit, 1, 0, false, 0);
            delay(250);
            lastDigitalRead = sw.readPublicData(TOUCH_PIN);

        }


        static byte loopcount = 0;
        //In the loop look for a change in state on the sensor and print a 0 or 1
        static void loop()
        {
            
            UInt16 newValue = sw.readPublicData(TOUCH_PIN);

            if (newValue != lastDigitalRead)
            {
                Serial.print(newValue); Serial.print(" ");
                lastDigitalRead = newValue;
                ++loopcount;
                if (loopcount > 20)
                {
                    loopcount = 0;
                    Serial.println();
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

        static void delay(int mS)
        {
            Thread.Sleep(mS);
        }

        static DateTime startTime = DateTime.Now;

        static UInt32 millis()
        {
            return ((UInt32)(DateTime.Now - startTime).TotalMilliseconds);
        }
    }

    class Serial
    {
        public static void println()
        {
            Console.WriteLine();
        }

        public static void println(string s)
        {
            Console.WriteLine(s);
        }
        public static void println(int s)
        {
            Console.WriteLine(s);
        }
        public static void println(UInt16 s)
        {
            Console.WriteLine(s);
        }

        public static void print(string s)
        {
            Console.Write(s);
        }

        public static void print(UInt16 s)
        {
            Console.Write(s);
        }
    }

}
