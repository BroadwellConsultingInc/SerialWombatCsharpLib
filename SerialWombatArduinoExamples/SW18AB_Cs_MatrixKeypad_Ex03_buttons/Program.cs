using System;
using System.Threading;
using SerialWombat;
/*
This example shows how to initialize a 16 key, 8 pin 4x4 matrix keypad using the 
Serial Wombat 18AB chip's SerialWombatMatrixKeypad class.

Note that firmware versions prior to 2.0.7 have a bug that may cause slow recognition of
button presses.

This example shows how to treat the matrix keypad as if it were 16 separate digital
inputs by creating 16 instances of SerialWombatMatrixButton from a single instance of
SerialWombatMatrixKeypad.  The SerialWombatMatrixKeypad instance scans the keys and
the SerialWombatMatrixButton class abstracts each one into a single digital input.

After initialization the SerialWombatMatrixButton class has the same interfaces and 
is conceptually interchangable with instances of SerialWombatDebouncedInput and 
digitally configured SerialWombat18CapTouch instances.

This example assumes a 4x4 keypad attached with rows connected to pins 10,11,12,13 
and columns attached to pins 16,17,18,19 .  This can be changed in the keypad.begin 
statement to fit your circuit.

A video demonstrating the use of the SerialWombatMatrixKeypad class on the Serial Wombat 18AB chip is available at:
https://youtu.be/hxLda6lBWNg 

Documentation for the SerialWombatTM1637 Arduino class is available at:
https://broadwellconsultinginc.github.io/SerialWombatArdLib/class_serial_wombat_w_s2812.html#details

*/
namespace SW18AB_Cs_MatrixKeypad_Ex03_buttons
{
    class Program
    {
        static SerialWombatChip sw = new SerialWombatChip();
        static SerialWombatMatrixKeypad keypad = new SerialWombatMatrixKeypad(sw);
        static SerialWombatMatrixButton button0 = new SerialWombatMatrixButton(keypad, 0);
        static SerialWombatMatrixButton button1 = new SerialWombatMatrixButton(keypad, 1);
        static SerialWombatMatrixButton button2 = new SerialWombatMatrixButton(keypad, 2);
        static SerialWombatMatrixButton button3 = new SerialWombatMatrixButton(keypad, 3);
        static SerialWombatMatrixButton button4 = new SerialWombatMatrixButton(keypad, 4);
        static SerialWombatMatrixButton button5 = new SerialWombatMatrixButton(keypad, 5);
        static SerialWombatMatrixButton button6 = new SerialWombatMatrixButton(keypad, 6);
        static SerialWombatMatrixButton button7 = new SerialWombatMatrixButton(keypad, 7);
        static SerialWombatMatrixButton button8 = new SerialWombatMatrixButton(keypad, 8);
        static SerialWombatMatrixButton button9 = new SerialWombatMatrixButton(keypad, 9);
        static SerialWombatMatrixButton button10 = new SerialWombatMatrixButton(keypad, 10);
        static SerialWombatMatrixButton button11 = new SerialWombatMatrixButton(keypad, 11);
        static SerialWombatMatrixButton button12 = new SerialWombatMatrixButton(keypad, 12);
        static SerialWombatMatrixButton button13 = new SerialWombatMatrixButton(keypad, 13);
        static SerialWombatMatrixButton button14 = new SerialWombatMatrixButton(keypad, 14);
        static SerialWombatMatrixButton button15 = new SerialWombatMatrixButton(keypad, 15);

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

        }

        static void loop()
        {

            if (button0.digitalRead()) Console.Write("0 ");
            if (button1.digitalRead()) Console.Write("1 ");
            if (button2.digitalRead()) Console.Write("2 ");
            if (button3.digitalRead()) Console.Write("3 ");
            if (button4.digitalRead()) Console.Write("4 ");
            if (button5.digitalRead()) Console.Write("5 ");
            if (button6.digitalRead()) Console.Write("6 ");
            if (button7.digitalRead()) Console.Write("7 ");
            if (button8.digitalRead()) Console.Write("8 ");
            if (button9.digitalRead()) Console.Write("9 ");
            if (button10.digitalRead()) Console.Write("10 ");
            if (button11.digitalRead()) Console.Write("11 ");
            if (button12.digitalRead()) Console.Write("12 ");
            if (button13.digitalRead()) Console.Write("13 ");
            if (button14.digitalRead()) Console.Write("14 ");
            if (button15.digitalRead()) Console.Write("15 ");

            //Print how many times the lower right key has been pressed or released
            Console.Write(button15.transitions); Console.Write(" ");

            // Print how long the lower right key has been held down (0 if not pressed)
            Console.Write(button15.readDurationInTrueState_mS()); Console.Write(" ");

            Console.WriteLine();

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
