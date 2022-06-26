using System;
using System.Threading;
using SerialWombat;

namespace SW18AB_Cs_FirmwareUpdate_UART
{
    /* This file is used to update the Serial Wombat 18AB chip to the lastest firmware,
 *  version 2.0.7 over UART.  A line from an Arduino GPIO to the  
 *  Serial Wombat 18AB Chip's reset line must be connected and
 *  the GPIO must be specified in the The ARDUINO_PIN_TO_SWC_RESET define below.
 *  This sketch contains the entire 
 *  firmware image as a constant.   
 *  
 *  Download this sketch first to the Arduino without the Serial Wombat Chip attached.
 *
 * Then attach the RX, TX, and ARDUINO_PIN_TO_SWC_RESET lines between the Arduino and
 * the Serial Wombat chip.
 *  
 *  This sketch requires a lot of flash space because it contains the entire firmware
 *  image.  For this reason it cannot be loaded into small-memory boards such as
 *  the Arduino Uno.  Additionally, storing or accessing large flash arrays often requires
 *  board specific compiler instructions or functions.  
 *  
 *  --- THIS SKETCH HAS ONLY BEEN TESTED ON THE ESP8266 AT THIS TIME ---
 *  
 *  Other large flash micros will be supported in the future.
 *  
 *  The download function requires about XX seconds.  A CRC is calculated
 *  on the Serial Wombat Chip at the end of the download and verified against
 *  a CRC stored in the image.  These should match
 *  
 *  A video tutorial on this example is available at:
  TODO
 */

    class Program
    {
        static UInt32 appStartAddress = 0x00008000;
        static SerialWombatChip sw = new SerialWombatChip();
        byte[] pagebuffer = new byte[1024];
        static void setup()
        {

            sw.begin("COM98");
            sw.queryVersion();


            delay(1000);
            //Serial.println("Jumping to boot");
            //Reset the Serial Wombat Chip
            {
                sw.hardwareReset();
                //digitalWrite(ARDUINO_PIN_TO_SWC_RESET, LOW);
                //pinMode(ARDUINO_PIN_TO_SWC_RESET, OUTPUT);
                //pinMode(ARDUINO_PIN_TO_SWC_RESET, INPUT);

            }

            for (int i = 0; i < 10; ++i)
            {
                byte[] tx = "UUUUUUUUUUUUUUUUUBoOtLoAd";  // Resync the chip
                sw.Serial.write(tx, tx.Length);
            }
            for (int i = 0; i < 100; ++i)
            {
                byte[] bl = "BoOtLoAd";  // Resync the chip
                sw.sendPacketNoResponse(bl);

                byte[] tx = "UUUUUUUU";  // Resync the chip
                sw.sendPacketNoResponse(tx);
                delay(1);
            }
            sw.queryVersion();
            //WombatFinder();

            UInt32 address;

            for (address = 0x4000 * 2; address <= (0x1F800 * 2); address += 0x800 * 2)
            {
                sprintf(str, "Erasing Block address: 0x%X", address);
                sw.eraseFlashPage(address); // Datasheet worst case is 40.
                delay(50);
            }


            address = 0x4000 * 2;  // Bytes
            UInt32 pageaddress = address;
            UInt32 tableindex = 0;
            int rlecount = 0;
            int pagebytecount = 0;
            UInt32 data;


            while (address < 0x20000 * 2)
            {
                if (rlecount == 0)
                {
                    data = pgm_read_byte(((byte*)appImage) + 4 * tableindex);
                    data += ((UInt32)pgm_read_byte(((byte*)appImage) + 4 * tableindex + 1)) << 8;
                    data += ((UInt32)pgm_read_byte(((byte*)appImage) + 4 * tableindex + 2)) << 16;
                    rlecount = pgm_read_byte(((byte*)appImage) + 4 * tableindex + 3) + 1;

                    ++tableindex;
                    char str[200];
                    sprintf(str, "Processing rle entry 0x%X count: %X  address: 0x%X", data, rlecount, address);
                    //Serial.println(str);
                }
                --rlecount;
                pagebuffer[pagebytecount] = data & 0xFF;
                ++pagebytecount;
                pagebuffer[pagebytecount] = (data >> 8) & 0xFF;
                ++pagebytecount;
                pagebuffer[pagebytecount] = (data >> 16) & 0xFF;
                ++pagebytecount;
                pagebuffer[pagebytecount] = 0;
                ++pagebytecount;
                address += 4;
                if (pagebytecount == 512)
                {
                    char str[200];
                    sprintf(str, "Writing 0x%X ", pageaddress);
                    //Serial.println(str);

                    pagebytecount = 0;
                    sw.writeUserBuffer(0x00, pagebuffer, 512);
                    sw.writeFlashRow(pageaddress);
                    pageaddress = address;
                    delay(4);// Datasheet worst case is 1.5
                }
                delay(0);

            }

            //Serial.println("Bootload complete.  Calculating CRC...");

            //Calculate CRC
            {
                byte[] tx = { 0xA4, 2, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55 };
                byte[] rx;
                sw.sendPacket(tx, out rx);

                delay(15000);
                byte tx3[] = { 0xA4, 3, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55 };

                sw.sendPacket(tx3, out rx);
                // Serial.print("Calculated CRC: ");
                //Serial.println(rx[2] + rx[3] * 256);
                // Serial.print("Expected CRC: ");
                // Serial.println(rx[4] + rx[5] * 256);
                //Serial.println();
                delay(1000);
                pinMode(ARDUINO_PIN_TO_SWC_RESET, OUTPUT);
                pinMode(ARDUINO_PIN_TO_SWC_RESET, INPUT);
            }




        }

        static void loop()
        {

            // put your main code here, to run repeatedly:
            //Serial.println("Serial Wombat chip Finder");
            //Serial.println();

            //Serial.println();
            //Serial.println("=======================================================");
            //Serial.println();

            sw.queryVersion();
            delay(5000);
        }


        static void Main(string[] args)
        {
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

        static void delay(int d)
        {
            Thread.Sleep(d);
        }
    }
}
