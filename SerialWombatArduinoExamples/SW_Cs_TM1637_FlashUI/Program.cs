using System;
using System.Text;
using System.Threading;
using SerialWombat;

/*
  This example shows how to configure two Serial Wombat 18AB pins to Touch input and use the
  SerialWombat18CapTouchCounter class to implement a two touch sensor interface to increment
  a counter at various speeds by two different increments.

  The example was created using a Serial Wombat 18AB chip in I2C mode with a Node MCU clone Arduino
  and a penny and quarter both covered with electrial tape wired to pins WP16 and WP17.

  When the penny is touched briefly the total will increment by 1 cent.  When the quarter is touched
  the total will increment by 25 cents.  If a finger is held on them then they will increment slowly, then
  more quickly, then very quickly.  This type of interface could be easily integrated into a complete solution
  for user configuration of parameters.

A video demonstrating the use of the TM1637 pin mode on the Serial Wombat 18AB chip is available at:
https://youtu.be/AwW12n6o_T0

Documentation for the SerialWombatTM1637 Arduino class is available at:
https://broadwellconsultinginc.github.io/SerialWombatArdLib/class_serial_wombat_t_m1637.html#details
*/


namespace SW_Cs_TM1637_FlashUI
{
    class Program
    {
        static SerialWombatChip sw = new SerialWombatChip();
        static SerialWombatTM1637 myDisplay = new SerialWombatTM1637(sw);

        static SerialWombat18CapTouch penny = new SerialWombat18CapTouch(sw);
        static SerialWombat18CapTouch quarter = new SerialWombat18CapTouch(sw);

        static  SerialWombatButtonCounter quarterCounter = new SerialWombatButtonCounter(quarter);



        const byte DISPLAY_CLK_PIN = 19;  // <<<<<<<<<   Set this to the Serial Wombat pin connected to your Display Clock Pin
        const byte DISPLAY_DIN_PIN = 18;  // <<<<<<<<<   Set this to the Serial Wombat pin connected to your Display Data Pin
        const byte PENNY_PIN = 16;  //Must be an Analog capable pin:  0,1,2,3,4,16,17,18,19
        const byte QUARTER_PIN = 17; //Must be an Analog capable pin:  0,1,2,3,4,16,17,18,19

        static UInt32 digitChange = 0;
        static byte[] displayString = Encoding.ASCII.GetBytes("000000");
        byte currentDigit = 6; // 6 means none, 0-5 are the displayed digits

        static void setup()
        {
            // put your setup code here, to run once:
            sw.begin("COM98");  //<<<<<<<<<<<<<<<   Set your COM port here

           

            // Initialize the Penny sensor
            //9000 based on previous calibration of this penny on this pin with this wire using the Calibration example
            penny.begin(PENNY_PIN, 9000, 0);

            // Initialize the Penny sensor
            //9250 based on previous calibration of this quarter on this pin with this wire using the Calibration example
            quarter.begin(QUARTER_PIN, 9250, 0);

            Thread.Sleep(500);

            penny.makeDigital(53985, 57620, 1, 0, false, 0); //Low and High limits based on previous calibration of this penny on this pin with this wire
            quarter.makeDigital(54349, 57792, 1, 0, false, 0); //Low and High limits based on previous calibration of this quarter on this pin with this wire
            Thread.Sleep(250);

            myDisplay.begin(DISPLAY_CLK_PIN,  //Clk Pin
           DISPLAY_DIN_PIN, // Data Pin
           6, // Number of digits
           SerialWombatTM1637.SWTM1637Mode.tm1637CharArray, // Mode enumeration
           0x55, // Source pin Not used in tm1637CharArray mode
           4);   // Brightness 
                 //  myDisplay.writeDigitOrder(2, 1, 0, 5, 4, 3);

            myDisplay.writeArray(displayString);
        }

        static byte count = 0;
        static void loop()
        {
           
            //TODO
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
