using SerialWombat;

/*
This example shows how to use the SerialWombatI2CController to access an STMicro LSM6DSO accellerometer / I2C over an I2C 
connection that the Serial Wombat chip is the controller of.   This is a different bus than the one used to control the Serial Wombat Chip
Over I2C.  This is useful to allow access of I2C devices when the Serial Wombat chip is controlled by UART.

A video demonstrating the use of the SerialWombatI2CController class on the Serial Wombat 18AB chip is available at:


Documentation for the SerialWombatI2CController Arduino class is available at:
https://broadwellconsultinginc.github.io/SerialWombatArdLib/

*/


SerialWombatChip sw = new SerialWombatChip();
SerialWombatI2CController i2c = new SerialWombatI2CController(sw);

const byte SCLPin = 19;
const byte SDAPin = 18;
const byte LSM6DSO_Address = 0x6B;

void setup() {

    sw.begin("COM9", true, SerialWombatClassLibrary.SerialPortChipType.SEEDUINO_XIAO_SAMD21);
    i2c.begin(SCLPin, SDAPin,1,false);
}

void loop()

{
    // Reading LSM6DSO WhoAmI Register 
    i2c.SWI2C_requestFrom(LSM6DSO_Address, 1, 0x0F, 1, true);
    i2c.SWI2C_writeBusy(true);
    bool busy = true;
    while (i2c.SWI2C_readBusy())
    {
        Thread.Sleep(1);
    }
    byte[] whoAmIdata; 
    if (i2c.SW_readRxBuffer(out whoAmIdata) >= 0)
    {
        if (whoAmIdata.Length > 0)
        {
            Console.WriteLine($"WhoAmI value was {whoAmIdata[0]}");
        }
        else
        {
            Console.WriteLine("Zero Data Length");
        }
    }
    else
    {
        Console.WriteLine("SW_readRxBuffer returned negative");
    }
    Thread.Sleep(5000);
}

setup();

while (true)
{
    loop();
}
