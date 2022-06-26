using System;
using System.Text;
using System.Threading;
using SerialWombat;
/*
This example shows how to initialize a 16 key, 8 pin 4x4 matrix keypad using the 
Serial Wombat 18AB chip'sSerialWombatMatrixKeypad class, and add a queue mask
to allow only certain digits to be entered in the queue

Note that firmware versions prior to 2.0.7 have a bug that may cause slow recognition of
button presses.

This example assumes a 4x4 keypad attached with rows connected to pins 10,11,12,13 
and columns attached to pins 16,17,18,19 .  This can be changed in the keypad.begin 
statement to fit your circuit.

This example uses default modes for the SerialWombatMatrixKeypad.  The default values 
send ASCII to the queue assuming a standard 

123A
456B
789C
*0#D

keypad format.   See the pin mode documentation (link below) for more information on the 
possible buffer and queue modes It is assumed that the Serial Wombat chip is at I2C 
address 0x6B.


A video demonstrating the use of the SerialWombatMatrixKeypad class on the Serial Wombat 18AB chip is available at:
https://youtu.be/hxLda6lBWNg

Documentation for the SerialWombatTM1637 Arduino class is available at:
https://broadwellconsultinginc.github.io/SerialWombatArdLib/class_serial_wombat_w_s2812.html#details

*/


namespace SW18AB_Cs_MatrixKeypad_Ex04_queueTM1637
{
    class Program
    {
        static SerialWombatChip sw = new SerialWombatChip();
        static SerialWombatMatrixKeypad keypad = new SerialWombatMatrixKeypad(sw);
        static SerialWombatTM1637 myDisplay = new SerialWombatTM1637(sw);
        static void setup()
        {
            sw.begin("COM98");  //PUT YOUR COM PORT HERE

            keypad.begin(10, // Command pin, typically the same as the row0 pin
            10, //row 0
            11, // row 1
            12, // row 2
            13, // row 3
            16, // column 0
            17, // column 1
            18, // column 2
            19); // column 3

            keypad.writeQueueMask(0x2777); // Bit mask with 1's for positions 0,1,2,4,5,6,8,9,0,13 corresponding to keypad marked positions 0-9.

            myDisplay.begin(14,  //Clk Pin
                            15, // Data Pin
                            6, // Number of digits
                            SerialWombatTM1637.SWTM1637Mode.tm1637CharArray, // Mode enumeration
                            0x55, // Source pin Not used in tm1637CharArray mode
                            4);   // Brightness
            myDisplay.writeDigitOrder(2, 1, 0, 5, 4, 3);
        }

        static void loop()
        {

            int i = keypad.read();  // returns a byte, or -1 if no value is avaialble
            if (i > 0)
            {
                myDisplay.write((byte)i);  // We got a keypress.  Dump it to the Display
            }
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
