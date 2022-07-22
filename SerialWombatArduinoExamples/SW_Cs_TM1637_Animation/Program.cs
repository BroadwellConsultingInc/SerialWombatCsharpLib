using System;
using System.Threading;
using SerialWombat;
/*
This example shows how to display an animation on a TM1637 display.  The animation is loaded to the Serial Wombat 18AB chip
from the Arduino board.  The Serial Wombat chip then outputs the animation to the display without any intervention from
the Arduino board.

If you haven't already, run the SW_Ard_TM1637_012345 example to ensure your display displays digits in
the correct order.  If necessary, correct the call to writeDigitOrder below as described in that example.
4 digit displays should use settings to display 0123 in that test to work properly with this sketch.

You can choose an animation to show by commenting in one of the options below //CONFIG:

A video demonstrating the use of the TM1637 pin mode on the Serial Wombat 18AB chip is available at:
https://youtu.be/AwW12n6o_T0

Documentation for the SerialWombatTM1637 Arduino class is available at:
https://broadwellconsultinginc.github.io/SerialWombatArdLib/class_serial_wombat_t_m1637.html#details

Serial Wombat is a registered trademark in the United States of Broadwell Consulting Inc.
*/


namespace SW_Cs_TM1637_Animation
{
    class Program
    {
        static string portname = "COM98";

        const byte SEG_A = 0x1; //TOP 
        const byte SEG_B = 0x2;// UPPER RIGHT
        const byte SEG_C = 0x4;// BOTTOM RIGHT
        const byte SEG_D = 0x8;// BOTTOM
        const byte SEG_E = 0x10;//BOTTOM LEFT
        const byte SEG_F = 0x20;//TOP LEFT
        const byte SEG_G = 0x40; // CENTER
        const byte SEG_POINT = 0x80;
        const byte OFF__ = 0;



        const byte VERTRIGHT = (SEG_B | SEG_C);
        const byte VERTLEFT = (SEG_E | SEG_F);
        const byte TOP = (SEG_A);
        const byte MID = (SEG_G);
        const byte BOT = (SEG_D);


        static SerialWombatChip sw = new SerialWombatChip();
        static SerialWombatTM1637 myDisplay = new SerialWombatTM1637(sw);
        const byte DISPLAY_CLK_PIN = 19;  // <<<<<<<<<   Set this to the Serial Wombat pin connected to your Display Clock Pin
        const byte DISPLAY_DIN_PIN = 18;  // <<<<<<<<<   Set this to the Serial Wombat pin connected to your Display Data Pin

       static  byte[,] LeftToRight ={  // All arrays are 6 bytes wide, regardless of display width.
  {VERTLEFT, 0,0,0,0,0},
  {VERTRIGHT, 0,0,0,0,0},
  { 0,VERTLEFT, 0,0,0,0},
  { 0,VERTRIGHT, 0,0,0,0},
  { 0,0,VERTLEFT, 0,0,0},
  { 0,0,VERTRIGHT, 0,0,0},
  { 0,0,0,VERTLEFT, 0,0},
  { 0,0,0,VERTRIGHT, 0,0},
  { 0,0,0,0,VERTLEFT, 0},
  { 0,0,0,0,VERTRIGHT, 0},
  { 0,0,0,0,0,VERTLEFT },
  { 0,0,0,0,0,VERTRIGHT},
  { 0,0,0,0,0,0},            // putting multiple frames the same in looks like a delay
  { 0,0,0,0,0,0},
  { 0,0,0,0,0,0},
  { 0,0,0,0,0,0},
  { 0,0,0,0,0,0},
  { 0,0,0,0,0,0},
};

        static byte[,] snake_6_digit = {

  {TOP,0,0,0,0,0},
  {0,TOP,0,0,0,0},
  { 0,0,TOP,0,0,0},
  { 0,0,0,TOP,0,0},
  { 0,0,0,0,TOP,0},
  { 0,0,0,0,0,TOP},

  { 0,0,0,0,0,SEG_B},

  { 0,0,0,0,0,MID},
  { 0,0,0,0,MID,0},
  { 0,0,0,MID,0,0},
  { 0,0,MID,0,0,0},
  { 0,MID,0,0,0,0},
  { MID,0,0,0,0,0},

  { SEG_E,0,0,0,0,0},

  { BOT,0,0,0,0,0},
  { 0,BOT,0,0,0,0},
  { 0,0,BOT,0,0,0},
  { 0,0,0,BOT,0,0},
  { 0,0,0,0,BOT,0},
  { 0,0,0,0,0,BOT},

  { 0,0,0,0,0,SEG_C},

  { 0,0,0,0,0,MID},
  { 0,0,0,0,MID,0},
  { 0,0,0,MID,0,0},
  { 0,0,MID,0,0,0},
  { 0,MID,0,0,0,0},
  { MID,0,0,0,0,0},

   { SEG_F,0,0,0,0,0},
};


        static byte[,] snake_4_digit = {

    { TOP,0,0,0,0,0},
  { 0,TOP,0,0,0,0},
  { 0,0,TOP,0,0,0},
  { 0,0,0,TOP,0,0},

  { 0,0,0,SEG_B,0,0},

  { 0,0,0,MID,0,0},
  { 0,0,MID,0,0,0},
  { 0,MID,0,0,0,0},
  { MID,0,0,0,0,0},

  { SEG_E,0,0,0,0,0},

  { BOT,0,0,0,0,0},
  { 0,BOT,0,0,0,0},
  { 0,0,BOT,0,0,0},
  { 0,0,0,BOT,0,0},

  { 0,0,0,SEG_C,0,0},

  { 0,0,0,MID,0,0},
  { 0,0,MID,0,0,0},
  { 0,MID,0,0,0,0},
  { MID,0,0,0,0,0},

   { SEG_F,0,0,0,0,0},
};
        static void setup()
        {
            
            sw.begin(portname);  //<<<<<<<<<< Put your COM port here

            myDisplay.begin(19,  //Clk Pin
  18, // Data Pin
  6, // Number of digits
  SerialWombatTM1637.SWTM1637Mode.tm1637Animation, // Mode enumeration
  0, // source pin Not used in Animation mode
  4);   // Brightness 

                myDisplay.writeDigitOrder(2, 1, 0 , 5,4, 3);


            myDisplay.writeAnimation(0x180, // Place array at index 0x180 in the user buffer
                  100,// Delay 100ms between updates
                 (byte)(snake_6_digit.GetLength(0)),  //Number of frames.  
                  snake_6_digit);  // Array to load.
        }
        static void loop()
        {

        }
        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                portname = args[0];
            }    
            setup();

            while (true)
            {
                loop();
                Thread.Sleep(0);
            }
        }
    }
}
