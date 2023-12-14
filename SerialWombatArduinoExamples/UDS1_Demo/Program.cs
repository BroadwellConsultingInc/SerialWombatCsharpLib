using System;
using System.Text;
using System.Threading;
using SerialWombat;

/*
This example shows how to interface an HC_SR04 ultrasonic distance sensor to a Serial Wombat 18AB chip.
The Serial Wombat chip will constantly take measurements, starting another measurement after the 
previous one finishes.  This allows the host to simply request the most recent reading over I2C without needing to
wait for a pulse to complete.

Serial Wombat 18AB Firmware 2.1 or later is needed to use this example.

An HC_SR04 sensor needs to be powered by 5V, and outputs a 5V signal.  The echo pin should be connected to one of the 
Serial Wombat 18AB chip's 5V tolerant pins (9,10,11,12, 14 and 15)


A video demonstrating the use of the UltrasonicDistanceSensor pin mode on the Serial Wombat 18AB chip is available at:
TODO

Documentation for the SerialWombatUltrasonicDistanceSensor class is available at:
https://broadwellconsultinginc.github.io/SerialWombatArdLib/class_serial_wombat_ultrasonic_distance_sensor.html
*/


namespace UDS1_Demo
{
    class Program
    {
        static SerialWombatChip sw = new SerialWombatChip();
        static SerialWombatUltrasonicDistanceSensor distanceSensor = new SerialWombatUltrasonicDistanceSensor(sw);
        static void setup()
        {
            // put your setup code here, to run once:
            sw.begin("COM3");  //<<<<<<<<<<<<<<<   Set your COM port here

            distanceSensor.begin(10, // Echo pin is on pin 10
                           UltrasonicDriver.HC_SR04,  // HC_SR04 driver
                        11); // Trigger pin on pin 11.    no parameters for autoTrigger (true) and pullUp (false)
        }

        static UInt16 lastMeasurement = 0;

        // In the loop we will constantly read the I2C value, and print it to Serial When it changes
        static void loop()
        {
            UInt16 newMeasurement = distanceSensor.readPublicData();
            if (newMeasurement != lastMeasurement)
            {
                Console.Write(newMeasurement);
                Console.WriteLine(" mm");
                lastMeasurement = newMeasurement;
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

