﻿using SerialWombat;

/*
This example shows how to configure pins 14-18 of the Serial Wombat 18AB chip to output VGA.
It changes the TFT Pong example from:
http://www.arduino.cc/en/Tutorial/TFTPong

To output VGA instead.  Some of the TFT calls are left in and commented out for reference.

Serial Wombat 18AB Firmware 2.1 or later is needed to use this example.

This example assumes a Serial Wombat 18AB chip is attached to the Arduino board via I2C.
In this case we're assuming an ESP-01 module with I2C Data and Clock lines on ESP-02 pins 2 and 0.

Since we only draw rectangles and that functionality is supported by the SerialWombat18ABVGA class,
there's no need to pull in the SerialWombat18ABVGADriver library and class and AdafruitGFX library.

Connections:
Potentiometers that divide VCC and Gnd to Serial Wombat pins 0 and 1.
VGA VSYNC (VGA Pin 14) -> 100 ohm Resistor -> SW Pin 18
VGA HSYNC (VGA Pin 13) -> 100 ohm Resistor ->SW Pin 17
VGA Red   (VGA Pin 1) -> 280 ohm Resistor -> SW Pin 16
VGA Green (VGA Pin 2) -> 280 ohm Resistor -> SW Pin 15
VGA Blue (VGA Pin 3) -> 280 ohm Resistor -> SW Pin 14

A video demonstrating the use of the VGA pin mode on the Serial Wombat 18AB chip is available at:
TODO

Documentation for the VGA class is available at:
TODO


The original TFT Pong Header:
  TFT Pong

  This example for the Arduino screen reads the values
  of 2 potentiometers to move a rectangular platform
  on the x and y axes. The platform can intersect
  with a ball causing it to bounce.


  http://www.arduino.cc/en/Tutorial/TFTPong

*/



SerialWombatChip sw = new SerialWombatChip();
SerialWombat18ABVGA vgaDriver = new SerialWombat18ABVGA(sw);
SerialWombatAnalogInput xInput = new SerialWombatAnalogInput(sw);
SerialWombatAnalogInput yInput = new SerialWombatAnalogInput(sw);


// variables for the position of the ball and paddle
UInt32 paddleX = 0;
UInt32 paddleY = 0;
UInt32 oldPaddleX = 1, oldPaddleY = 1;
int ballDirectionX = 1;
int ballDirectionY = 1;

UInt32 ballSpeed = 50; // lower numbers are faster

UInt32 nextBallMove = 0;

int ballX = 0 , ballY = 0, oldBallX = 1, oldBallY = 1;

void setup()
{
    // initialize the display
    sw.begin("COM25", true);
    sw.queryVersion();
    Console.Write("Version "); Console.WriteLine(sw.fwVersionString);
    

    xInput.begin(0);
    yInput.begin(1);
    vgaDriver.begin(18, 0x0000);

    nextBallMove = (UInt32)(sw.millis() + ballSpeed);
}


void loop()
{

    // save the width and height of the screen
    UInt32 myWidth = 160;
    UInt32 myHeight = 120;

    // map the paddle's location to the position of the potentiometers
    UInt32 x = xInput.readCounts();
    UInt32 y = yInput.readCounts();
    x *= myWidth;
    y *= myHeight;
    x >>= 16;
    y >>= 16;
    paddleX = x - 20 / 2;
    paddleY = y - 5 / 2;

    // set the fill color to black and erase the previous
    // position of the paddle if different from present


    if (oldPaddleX != paddleX || oldPaddleY != paddleY)
    {

        //TFTscreen.rect(oldPaddleX, oldPaddleY, 20, 5);
        vgaDriver.fillRect((byte)oldPaddleX,(byte) oldPaddleY, 20, 5, 0);
    }

    // draw the paddle on screen, save the current position
    // as the previous.
    /*
      TFTscreen.fill(255, 255, 255);

      TFTscreen.rect(paddleX, paddleY, 20, 5);
    */
    vgaDriver.fillRect((byte)paddleX,(byte)paddleY, 20, 5, 1);
    oldPaddleX = paddleX;
    oldPaddleY = paddleY;

    // update the ball's position and draw it on screen
    if (nextBallMove < sw.millis())
    {
        nextBallMove += ballSpeed;
        moveBall();
    }
}

// this function determines the ball's position on screen
void moveBall()
{
    // if the ball goes offscreen, reverse the direction:
    if (ballX > 160 /*TFTscreen.width()*/ || ballX < 0)
    {
        ballDirectionX = -ballDirectionX;
    }

    if (ballY > 120 /*TFTscreen.height()*/ || ballY < 0)
    {
        ballDirectionY = -ballDirectionY;
    }

    // check if the ball and the paddle occupy the same space on screen
    if (inPaddle(ballX, ballY, (byte)paddleX,(byte) paddleY, 20, 5))
    {
        ballDirectionX = -ballDirectionX;
        ballDirectionY = -ballDirectionY;
    }

    // update the ball's position
    ballX += ballDirectionX;
    ballY += ballDirectionY;

    // erase the ball's previous position
    // TFTscreen.fill(0, 0, 0);

    if (oldBallX != ballX || oldBallY != ballY)
    {
        vgaDriver.fillRect((byte)oldBallX, (byte) oldBallY, 5, 5, 0);
        //TFTscreen.rect(oldBallX, oldBallY, 5, 5);
    }


    // draw the ball's current position
    //TFTscreen.fill(255, 255, 255);

    //TFTscreen.rect(ballX, ballY, 5, 5);
    vgaDriver.fillRect((byte)ballX, (byte)ballY, 5, 5, 1);

    // Draw a line across the top and bottom to show screen boundaries
    vgaDriver.fillRect(0, 0, 160, 1, 1);
    vgaDriver.fillRect(0, 119, 160, 1, 1);

    oldBallX = ballX;
    oldBallY = ballY;

}

// this function checks the position of the ball
// to see if it intersects with the paddle
bool inPaddle(int x, int y, int rectX, int rectY, int rectWidth, int rectHeight)
{
    bool result = false;

    if ((x >= rectX && x <= (rectX + rectWidth)) &&
        (y >= rectY && y <= (rectY + rectHeight)))
    {
        result = true;
    }

    return result;
}

setup();

while(true)
{
    loop();
    
}
