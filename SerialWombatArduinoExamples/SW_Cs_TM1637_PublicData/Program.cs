using System;
using System.Text;
using System.Threading;
using SerialWombat;

/*
This example shows how to display a number on a TM1637 display based on the public data of a Serial Wombat pin or other
data source within the Serial Wombat chip.

If you haven't already, run the SW_Ard_TM1637_012345 example to ensure your display displays digits in
the correct order.  If necessary, correct the call to writeDigitOrder below as described in that example.
For four digit displays, you'll likely want to use writeDigitOrder(2,3,4,5,0,1) in order to show the least
significant digits.

This sketch assumes a potentiometer output dividing ground and 3.3v  is connected to pin 0 as an analog input.

This sketch is designed to be experimented with.  Comment in #define's in the  CONFIG sections below to try out different options and how they affect the display

A video demonstrating the use of the TM1637 pin mode on the Serial Wombat 18AB chip is available at:
https://youtu.be/AwW12n6o_T0

Documentation for the SerialWombatTM1637 Arduino class is available at:
https://broadwellconsultinginc.github.io/SerialWombatArdLib/class_serial_wombat_t_m1637.html#details

Serial Wombat is a registered trademark in the United States of Broadwell Consulting Inc.

*/


namespace SW_Cs_TM1637_PublicData
{
    class Program
    {
        static SerialWombatChip sw = new SerialWombatChip();
        static SerialWombatTM1637 myDisplay = new SerialWombatTM1637(sw);
        static SerialWombatAnalogInput potentiometer = new SerialWombatAnalogInput(sw);
        const byte DISPLAY_CLK_PIN = 19;  // <<<<<<<<<   Set this to the Serial Wombat pin connected to your Display Clock Pin
        const byte DISPLAY_DIN_PIN = 18;  // <<<<<<<<<   Set this to the Serial Wombat pin connected to your Display Data Pin

        static void setup()
        {
            // put your setup code here, to run once:
            sw.begin("COM98");  //<<<<<<<<<<<<<<<   Set your COM port here

            myDisplay.begin(DISPLAY_CLK_PIN,  //Clk Pin
            DISPLAY_DIN_PIN, // Data Pin
            6, // Number of digits
            SerialWombatTM1637.SWTM1637Mode.tm1637Decimal16, // Mode enumeration, can also be tm1637Hex16
            0, // Potentiometer pin
            4);   // Brightness 

            myDisplay.writeDigitOrder(2, 1, 0, 5, 4, 3);

            myDisplay.suppressLeadingZeros(true);

            potentiometer.begin(0, 64, 0);

        }

        static void loop()
        {
            
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
