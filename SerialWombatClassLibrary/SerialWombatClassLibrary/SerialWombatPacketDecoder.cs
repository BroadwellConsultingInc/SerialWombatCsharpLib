/*
Copyright 2024 Broadwell Consulting Inc.

Serial Wombat is a registered trademark in the US of Broadwell Consulting Inc.

Permission is hereby granted, free of charge, to any person obtaining a
 * copy of this software  associated documentation files (the "Software"),
 * to deal in the Software without restriction, including without limitation
 * the rights to use, copy, modify, merge, publish, distribute, sublicense,
 * /or sell copies of the Software, and to permit persons to whom the
 * Software is furnished to do so, subject to the following conditions:

The above copyright notice  this permission notice shall be included in
 * all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL
 * THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR
 * OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE,
 * ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
 * OTHER DEALINGS IN THE SOFTWARE.
*/

using System;
using System.Linq;
using System.Threading;
using System.IO.Ports;
using System.Text;
using System.Collections.Generic;

namespace SerialWombat
{
    static public partial class SerialWombatPacketDecoder
    {


        static byte[] dataList = { 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55 };
        static int dataCount = 0;
        static int address_byte = 0;
        static bool isResponse = true;






        static public string uint8(int index)
        {
            return $"{dataList[index]}";
        }

        static public string uint16(int index)
        {
            return $"{dataList[index] + dataList[index + 1] * 256}";
        }

        static public string hex2(int index)
        {
            return $"0x{dataList[index]:x2}";

        }

        static public string hex4(int index)
        {
            return $"0x{dataList[index] + dataList[index + 1] * 256:x4} ";

        }

        static private string hex8(UInt32 index)
        {
            return $"0x{dataList[index] + dataList[index + 1] * 256 + dataList[index + 2] * 65536 + dataList[index + 3] * 65536 * 256:x2}";

        }

        static private string uint32(int index)
        {
            return $"{dataList[index] + dataList[index + 1] * 256 + dataList[index + 2] * 65536 + dataList[index + 3] * 65536 * 256}";
        }

        static private string hexList(int index, int count = 8)
        {
            string s = "";
            int c = 0;
            for (int i = index; i < 8 && c < count; ++i, ++c)
            {
                s += $"0x{dataList[i]:x2} ";
            }
            return (s);
        }
        static private void unknown()
        { // comment me out to cause errors when unknown frames are received.  Good for checking protocol coverage completeness during unit/system testing.
          //throw (NotImplementedException);
            return;

        }
        static public string decode(byte[] packet, bool packetIsResponse)
        {
            isResponse = packetIsResponse;
            if (packet.Length < 8)
            {
                return "Packet not processed.  less than 8 bytes";
            }
            dataList = packet;
            try
            {
                return generateString();
            }
            catch (Exception ex)
            {
                return $"Exception {ex.Message} thrown decoding response = {isResponse} packet {hexList(0)}";
            }
        }


        static public string generateString()
        {
            string outstr = "";

            if (isResponse)
                outstr = "RESP: ";
            else
                outstr = "CMD: ";


            if (dataList[0] == 0x21)
                outstr = outstr + echo();
            else if (dataList[0] == 0x40)  // @ symbol
                outstr = outstr + testResult();
            else if (dataList[0] == 0x42)
                outstr = outstr + bootload();
            else if (dataList[0] == 0x45)
                outstr = outstr + error();
            else if (dataList[0] == 0x52)
                outstr = outstr + reset();
            else if (dataList[0] == 0x53)
                outstr = outstr + sleep();
            else if (dataList[0] == 0x56)
                outstr = outstr + version();
            else if (dataList[0] == 0x5E)
                outstr = outstr + lineBreak();
            else if (dataList[0] == 0x64)
                outstr = outstr + asciiSetData();
            else if (dataList[0] == 0x67)
                outstr = outstr + asciiGetData();
            else if (dataList[0] == 0x70)
                outstr = outstr + asciiSetPin();
            else if (dataList[0] == 0x81)
                outstr = outstr + readPin();
            else if (dataList[0] == 0x82)
                outstr = outstr + writePin();
            else if (dataList[0] == 0x83)
                outstr = outstr + readUserBuffer();
            else if (dataList[0] == 0x84)
                outstr = outstr + writeUserBuffer();
            else if (dataList[0] == 0x85)
                outstr = outstr + writeUserBufferContinue();
            else if (dataList[0] == 0x90)
                outstr = outstr + queueInit();
            else if (dataList[0] == 0x91)
                outstr = outstr + queueAdd();
            else if (dataList[0] == 0x92)
                outstr = outstr + queueAdd7();
            else if (dataList[0] == 0x93)
                outstr = outstr + queueRead();
            else if (dataList[0] == 0x94)
                outstr = outstr + queueInfo();
            else if (dataList[0] == 0x95)
                outstr = outstr + queueClone();
            else if (dataList[0] == 0xA0)
                outstr = outstr + readRam();
            else if (dataList[0] == 0xA1)
                outstr = outstr + readFlash();
            else if (dataList[0] == 0xA3)
                outstr = outstr + writeRam();
            else if (dataList[0] == 0xA4)
                outstr = outstr + writeFlash();
            else if (dataList[0] == 0xA5)
                outstr = outstr + calibrateAnalog();
            else if (dataList[0] == 0xA6)
                outstr = outstr + enable2ndUART();
            else if (dataList[0] == 0xA7)
                outstr = outstr + readLastErrorPacket();
            else if (dataList[0] == 0xB0)
                outstr = outstr + UART1TX7();
            else if (dataList[0] == 0xB1)
                outstr = outstr + UART1RX7();
            else if (dataList[0] == 0xB2)
                outstr = outstr + UART2TX7();
            else if (dataList[0] == 0xB3)
                outstr = outstr + UART2RX7();
            else if (dataList[0] == 0xB4)
                outstr = outstr + testSequence();
            else if (dataList[0] == 0xB5)
                outstr = outstr + rwPinMemory();
            else if (dataList[0] == 0xB6)
                outstr = outstr + captureStartupSequence();
            else if (dataList[0] == 0xB7)
                outstr = outstr + adjustFrequency();
            else if (dataList[0] == 0xD2) //Output Scaling generic
                outstr = outstr + configureOutputScaling();
            else if (dataList[0] == 0xD3) //input processor generic
                outstr = outstr + configureInputProcessor();
            else if (((dataList[0] >= 0xC8 && dataList[0] <= 0xDA) || dataList[0] == 0xDC))
                outstr = outstr + configurePin();
            else if ((dataList[0] == 0xDB))
                outstr = outstr + disablePin();


            //wombat_frame.data["data"] = outstr
            return outstr;

        }

        static public string echo()
        {
            string outstr = "Echo: ";
            for (int i = 1; i < 8; ++i)
            {
                outstr = outstr + hex2(i);
            }
            return outstr;

        }

        static public string testResult()
        {
            string outstr = "Test result: ";
            if ((dataList[1] == 1))
                outstr = outstr + "Pass ";
            else
                outstr = outstr + "Fail ";
            outstr = outstr + $"X: {hex4(2)} {dataList[2] + dataList[3] * 256} V: {hex4(4)} {dataList[4] + dataList[5] * 256}";
            return outstr;

        }

        static public string bootload()
        {
            string outstr = "Bootload ";
            string bootStr = Encoding.ASCII.GetString(dataList);

            if ((bootStr != "BoOtLoAd"))
                outstr += " ERROR! Wrong String " + bootStr;
            return outstr;
        }
        static string[] errorStrings = {
            "SW_ERROR_UNNUMBERED_ERROR", /// = 32767,
    "SW_ERROR_PINS_MUST_BE_ON_SAME_PORT", /// = 1, ///< Pins must be on the same microcontroller part (e.g. PORTA, PORTB, etc.).  See datasheet of micro for port assignments.
    "SW_ERROR_ASCII_NUMBER_TOO_BIG_16", /// = 2, ///<A number bigger than 65535 was provided to convert to a 16 bit value
            "SW_ERROR_UNKNOWN_PIN_MODE", /// = 3, ///< A Pin mode was indicated that is not avaialble on this model or version of Serial Wombat chip
            "SW_ERROR_RESET_STRING_INCORRECT", /// = 4, ///<A Packet starting with 'R' was received but didn"t have the correct following bytes to cause a reset
            "SW_ERROR_INVALID_COMMAND", /// = 5, ///< The first byte of a received packet does not correspond with a command supported by this model of Serial Wombat chip
            "SW_ERROR_INSUFFICIENT_SPACE", /// = 6,  ///< There was not sufficient space in the queue or user area to complete the command.
            "SW_ERROR_WUB_COUNT_GT_4", /// = 7, ///< A count greater than 4 was provided as a number of bytes to write to count user buffer
            "SW_ERROR_WUB_INVALID_ADDRESS", /// = 8, ///<An attempt to write to a user buffer address outside the user buffer was attempted.
            "SW_ERROR_WUB_CONTINUE_OUTOFBOUNDS", /// = 9, ///<  A call to Write User Buffer Continue would have written out of bounds.
            "SW_ERROR_RF_ODD_ADDRESS", /// = 10, ///< Addresses Read From Flash must be even.
            "SW_ERROR_FLASH_WRITE_INVALID_ADDRESS", /// = 11, ///<An attempt to write or erase flash was made to a protected or non-existant area
	    "SW_ERROR_INVALID_PIN_COMMAND", /// = 12, ///< The pin command 0xC1, 0xC2, etc is not suported by this pin mode (May vary by model)
            "SW_ERROR_PIN_CONFIG_WRONG_ORDER", /// = 13, ///<The called pin command 0xC1, 0xC2 was called before other required prior commands (e.g. 0xC0)
            "SW_ERROR_WS2812_INDEX_GT_LEDS", /// = 14, ///<The command references an index that is greater or equal to the number of leds
            "SW_ERROR_PIN_NOT_CAPABLE", /// = 15, ///<The commanded pin does not have the hardware support to perform the commanded pin mode
	    "SW_ERROR_HW_RESOURCE_IN_USE", /// = 16, ///<The requested hardware or software resource in use has already been exclusively claimed by another pin
            "SW_ERROR_INVALID_PARAMETER_3", /// = 17, ///<The pin configuration parameter in Byte 3 was invalid
            "SW_ERROR_INVALID_PARAMETER_4", /// = 18, ///<The pin configuration parameter in Byte 4 was invalid
            "SW_ERROR_INVALID_PARAMETER_5", /// = 19, ///<The pin configuration parameter in Byte 5 was invalid
            "SW_ERROR_INVALID_PARAMETER_6", /// = 20, ///<The pin configuration parameter in Byte 6 was invalid
            "SW_ERROR_INVALID_PARAMETER_7", /// = 21, ///<The pin configuration parameter in Byte 7 was invalid
            "SW_ERROR_PIN_NUMBER_TOO_HIGH", /// = 22, ///<The pin number indicated was greater than the greatest avaialable pin
            "SW_ERROR_PIN_IS_COMM_INTERFACE", /// = 23, ///<The pin number indicated is currently being used for Serial Wombat protocol communicaitons
            "SW_ERROR_ANALOG_CAL_WRONG_UNLOCK", /// = 24, ///<The unlock value provided to write analog calibration was incorrect.
            "SW_ERROR_2ND_INF_WRONG_UNLOCK", /// = 25, ///<The unlock value provided to enable the 2nd interface was incorrect.
            "SW_ERROR_2ND_INF_UNAVAILABLE", /// = 26, ///<The 2nd interface hardware was not avaialble to claim
            "SW_ERROR_UART_NOT_INITIALIZED", /// = 27, ///<A UART operation was requested but the UART was not intialized
            "SW_ERROR_CMD_BYTE_1", /// = 28, ///< Byte 1 of the command was invalid
            "SW_ERROR_CMD_BYTE_2", /// = 29, ///< Byte 2 of the command was invalid
            "SW_ERROR_CMD_BYTE_3", /// = 30, ///< Byte 3 of the command was invalid
            "SW_ERROR_CMD_BYTE_4", /// = 31, ///< Byte 4 of the command was invalid
            "SW_ERROR_CMD_BYTE_5", /// = 32, ///< Byte 5 of the command was invalid
            "SW_ERROR_CMD_BYTE_6", /// = 33, ///< Byte 6 of the command was invalid
            "SW_ERROR_CMD_BYTE_7", /// = 34, ///< Byte 7 of the command was invalid
            "SW_ERROR_CMD_UNSUPPORTED_BAUD_RATE", /// = 35, ///< invalid baud rate enumeration    
            "SW_ERROR_QUEUE_RESULT_INSUFFICIENT_USER_SPACE", /// = 36,
	"SW_ERROR_QUEUE_RESULT_UNALIGNED_ADDRESS", /// = 37,
	"SW_ERROR_QUEUE_RESULT_INVALID_QUEUE", /// = 38,
	"SW_ERROR_QUEUE_RESULT_FULL", /// = 39,
	"SW_ERROR_QUEUE_RESULT_EMPTY", /// = 40,
	"SW_ERROR_DATA_NOT_AVAILABLE", /// = 41,
            "SW_ERROR_TM1637_WRONG_MODE", /// = 42, ///< The TM1637 pin is configured for the wrong TM1637 mode to process the command
           "SW_ERROR_RUB_INVALID_ADDRESS", /// = 43, ///<An attempt to read user buffer address outside the user buffer was attempted.
            "SW_ERROR_UNKNOWN_OUTPUTSCALE_COMMAND", /// = 44, // The command index for an output scaling command is not supported on this firmware
            "SW_ERROR_UNKNOWN_INPUT_PROCESS_COMMAND", /// = 45, // The command index for an inputProcess command is not supported on this firmware
	    "SW_ERROR_PULSE_ON_CHANGE_ENTRY_OUT_OF_RANGE", /// = 46, // The pulse on change entry number exceeded the number of entries
	    "SW_ERROR_PULSE_ON_CHANGE_UNKNOWN_MODE", /// = 47, // The pulse on change Mode requested is unknown
        "SW_ERROR_UNKNOWN_QUEUE_TYPE",/// = 48, ///< This Queue type is not supported on this firwmare
            "SW_ERROR_CAPTURE_PACKET_WRONG",/// = 49, ///< The capture packet did not have the correct protection bytes
	    "SW_ERROR_PS2KB_WRONG_MODE",/// = 50, ///< The command issued is not available for the current Queue mode



    };

        static public string error()
        {
            string outstr = "ERROR: ";
            int errornum = ((dataList[1] - 0x30) * 10000 +
                       (dataList[2] - 0x30) * 1000 +
                       (dataList[3] - 0x30) * 100 +
                       (dataList[4] - 0x30) * 10 +
                       (dataList[5] - 0x30));
            if ((errornum < errorStrings.Length))
                outstr += errorStrings[errornum];
            else
                outstr += $" Unknown error {errornum}";
            unknown();
            return outstr;

        }

        static public string reset()
        {
            return "Reset Command";
        }

        static public string sleep()
        {
            return "sleep Command";

        }

        static public string readUserBuffer()
        {

            if (isResponse)

                return $"Read Result: {hex2(1)} {hex2(2)} {hex2(3)} {hex2(4)} {hex2(5)} {hex2(6)} {hex2(7)}";
            else
                return $"Read User Buffer Index: {hex4(1)}";


        }

        static public string writeUserBuffer()
        {
            string s = $"Write User buffer: Addr: {hex4(1)} count: {dataList[3]} data:";
            for (int i = 0; i < dataList[3]; ++i)
            {
                s += $" {hex2(dataList[4 + i])}";
            }
            return s;
        }

        static public string writeUserBufferContinue()
        {
            string s = $"Write User buffer Continue: ";
            for (int i = 1; i < 8; ++i)
            {
                s += $" {hex2(i)}";
            }
            return s;

        }

        static public string readRam()
        {
            string s = $"Read RAM Address 0x{dataList[1] + 256 * dataList[2]:x4}";
            if (isResponse)
            {
                s += hex2(3);
            }
            return s;

        }

        static public string readFlash()
        {
            UInt32 address = (UInt16)(dataList[1] + 256 * dataList[2] + dataList[3] * 65536);
            string s = $"Read Flash Address: 0x{address:x8}";
            if (isResponse)
            {

                s += $" {hex8(4)}";
            }
            return s;

        }

        static public string writeRam()
        {
            UInt32 address = (UInt32)(dataList[1] + 256 * dataList[2] + dataList[3] * 65536 + dataList[4] * 256 * 65536);
            byte value = dataList[5];
            return $"Write RAM Address: {hex8(address)} Value: {value}/ {hex2(5)} ";

        }

        static public string writeFlash()
        {
            if ((dataList[1] == 0))
            {
                UInt32 address = (UInt32)(dataList[2] + 256 * dataList[3] + dataList[4] * 65536 + dataList[5] * 256 * 65536);
                return $"Erase block at : 0x{address:x8} ";
            }
            else if ((dataList[1] == 1))
            {
                UInt32 address = (UInt32)(dataList[2] + 256 * dataList[3] + dataList[4] * 65536 + dataList[5] * 256 * 65536);
                return $"Write block at : 0x{address:x8} ";
            }
            else if ((dataList[1] == 2))
            {
                if (isResponse)
                {

                    return $"CRC Result :{hex4(2)}";
                }

                else
                    return "CRC App space ";
            }




            else
                unknown();
            return "Unknown flash write command";

        }

        static public string calibrateAnalog()
        {
            return "Calibrate Analog";

        }

        static public string enable2ndUART()
        {
            return $"Enable 2nd Interface: {dataList[1]} Unlock req: B2 A5 61 73 F8 A2 ";

        }

        static public string readLastErrorPacket()
        {

            if (isResponse)

                return $"Read Last Error Packet: {hex2(1)} {hex2(2)} {hex2(3)} {hex2(4)} {hex2(5)} {hex2(6)} {hex2(7)}";
            else
                return $"Read Last Error Packet starting byte {dataList[1]}";

        }

        static public string UART1TX7()
        {
            if (isResponse)
                return $"UART TX1 7 BYTES echo";
            else
                return $"UART TX1 7 BYTES: {hex2(1)} {hex2(2)} {hex2(3)} {hex2(4)} {hex2(5)} {hex2(6)} {hex2(7)} ";

        }

        static public string disablePin()
        {
            return $"Disable pin {dataList[1]}, mode {dataList[2]}";

        }

        static public string UART1RX7()
        {
            if (isResponse)
                return $"UART RX1 7 BYTES: {hex2(1)} {hex2(2)} {hex2(3)} {hex2(4)} {hex2(5)} {hex2(6)} {hex2(7)} ";
            else
                return $"UART RX1 7 BYTES echo";

        }

        static public string UART2TX7()
        {
            if (isResponse)
                return $"UART TX2 7 BYTES echo";
            else
                return $"UART TX2 7 BYTES: {hex2(1)} {hex2(2)} {hex2(3)} {hex2(4)} {hex2(5)} {hex2(6)} {hex2(7)} ";

        }

        static public string UART2RX7()
        {
            if (isResponse)
                return $"UART RX2 7 BYTES: {hex2(1)} {hex2(2)} {hex2(3)} {hex2(4)} {hex2(5)} {hex2(6)} {hex2(7)} ";
            else
                return $"UART RX2 7 BYTES echo";

        }

        static public string testSequence()
        {
            return $"Test Sequence";

        }

        static public string rwPinMemory()
        {
            if ((dataList[1] == 0))
                if (isResponse)
                    return $"Pin Byte BYTES: {hex2(1)} {hex2(2)} {hex2(3)} {hex2(4)} {hex2(5)} {hex2(6)} {hex2(7)} ";
                else
                    return $"Read 7 bytes from pin {dataList[2]} offset {dataList[3]}";
            else
                unknown();
            return $"Unknown pin memory RW command";

        }

        static public string captureStartupSequence()
        {
            if ((dataList[1] == 0))
                return $"Start Startup Sequence Capture";
            else if ((dataList[1] == 1))
                return $"Stop Startup Sequence Capture";
            else if ((dataList[1] == 2))
                return $"Store Startup Sequence Capture";
            else
                unknown();
            return $"Unknown Startup Sequence Capture command";

        }

        static public string adjustFrequency()
        {
            if (isResponse)
                return $"Adjust frequency: New register setting: {hex4(5)}";
            else
                return $"Adjust frequency:  Increment {uint8(1)} steps, decrement {uint8(3)} steps";



        }

        static public string version()
        {
            if (isResponse)

                return $"Version-- Category: {(char)dataList[1]} Model: {Encoding.ASCII.GetString(dataList, 2, 3)} FW Ver: {Encoding.ASCII.GetString(dataList, 5, 3)} ";
            else
                return "Version ";

        }

        static public string lineBreak()
        {
            return $"LineBreak Enable/Disable";

        }

        static public string asciiSetData()
        {
            int pin = (dataList[1] - 0x30) * 10 + (dataList[2] - 0x30);
            return $"Ascii Set static public data pin: {pin}: {(char)(dataList[3])}{(char)(dataList[4])}{(char)(dataList[5])}{(char)(dataList[6])}{(char)(dataList[7])}";

        }

        static public string asciiGetData()
        {
            if (isResponse)
                return $"Get data Result: {(char)(dataList[3])}{(char)(dataList[4])}{(char)(dataList[5])}{(char)(dataList[6])}{(char)(dataList[7])}";
            else
            {
                int pin = (dataList[1] - 0x30) * 100 + (dataList[2] - 0x30) * 10 + (dataList[3] - 0x30);
                return $"Ascii get static public data pin:  {pin} ";
            }

        }

        static public string asciiSetPin()
        {
            int pin = (dataList[1] - 0x30) * 10 + dataList[2] - 0x30;
            return $"Ascii Set pin:  P{pin} {(char)(dataList[3])} P{pin + 1} {(char)(dataList[4])} P{pin + 2} {(char)(dataList[5])} P{pin + 3} {(char)(dataList[6])} P{pin + 4}{(char)(dataList[7])}";

        }

        static public string readPin()
        {
            if (isResponse)
                if ((dataList[1] == 0x41))
                    return $"Read incrementingCounter: {dataList[2] + dataList[3] * 256 + dataList[4] * 65536 + dataList[5] * 256 * 65536}";
                else if ((dataList[1] == 0x42))
                    return $"Read 1.024 V reference:({hex4(2)}).  Inferred Vcc: {(int)(1024.0 * 65536 / (dataList[2] + dataList[3] * 256))} mv ";
                else if ((dataList[1] == 0x43))
                    return $"Read Frames Run LSW: {dataList[2] + dataList[3] * 256 + dataList[4] * 65536 + dataList[5] * 256 * 65536}";
                else if ((dataList[1] == 0x44))
                    return $"Read Frames Run MSW: {dataList[2] + dataList[3] * 256 + dataList[4] * 65536 + dataList[5] * 256 * 65536}";
                else if ((dataList[1] == 0x45))
                    return $"Read Overflow Frames: {dataList[2] + dataList[3] * 256}";
                else if ((dataList[1] == 0x46))
                    return $"Read Temperature: {dataList[2] + dataList[3] * 256} 100ths deg C";
                else if ((dataList[1] == 0x47))
                    return $"Read Packets Processed: {dataList[2] + dataList[3] * 256}";
                else if ((dataList[1] == 0x48))
                    return $"Read Errors: {dataList[2] + dataList[3] * 256}";
                else if ((dataList[1] == 0x49))
                    return $"Read Frames Dropped: {dataList[2] + dataList[3] * 256}";
                else if ((dataList[1] == 0x4A))
                    return $"Read System Utilization average: {dataList[2] + dataList[3] * 256}";
                else
                    return $"Read Pin {dataList[1]}: {dataList[2] + dataList[3] * 256} / {hex4(2)}, {dataList[1] + 1}: {dataList[4] + dataList[5] * 256} / {hex2(4)}, {dataList[1] + 2}: {dataList[6] + dataList[7] * 256} / {hex2(4)}";
            else
                if ((dataList[1] == 0x40))
                return "Read incrementingCounter";
            else if ((dataList[1] == 0x42))
                return "Read 1.024 V reference";
            else if ((dataList[1] == 0x43))
                return "Read Frames Run";
            else if ((dataList[1] == 0x45))
                return "Read OverFlow Frames";
            else
                return $"Read Pin {dataList[1]}";


        }

        static public string writePin()
        {
            string outstr = $"Write Pin {dataList[1]}: {dataList[2] + dataList[3] * 256} / {hex4(2)}";
            if ((dataList[4] != 0xFF))
                outstr = outstr + $",  {dataList[4]}: {dataList[5] + dataList[6] * 256} / {hex4(2)}";
            return outstr;


        }

        static public string configurePin()
        {
            if (dataList[2] == 0)
                return setDigitalIO();
            else if (dataList[2] == 1)
                return setControlled();
            else if (dataList[2] == 2)
                return setAnalogInput();
            else if (dataList[2] == 3)
                return setServo();
            else if (dataList[2] == 4)
                return setThroughputConsumer();
            else if (dataList[2] == 5)
                return setQuadEnc();
            else if (dataList[2] == 6)
                return setHBridge();
            else if (dataList[2] == 7)
                return setWatchdog();
            else if (dataList[2] == 8)
                return setProtectedOutput();
            else if (dataList[2] == 10)
                return setDebounce();
            else if (dataList[2] == 11)
                return setTM1637();
            else if (dataList[2] == 12)
                return setWS2812();
            else if (dataList[2] == 14)  //#13 covered below
                return setInputProcessor();
            else if (dataList[2] == 15)
                return setMatrixKeypad();
            else if (dataList[2] == 16)
                return setPWM();
            else if (dataList[2] == 17 || dataList[2] == 13 || dataList[2] == 23)
                return setUARTTXRX();
            else if (dataList[2] == 18)
                return setPulseTimer();
            else if (dataList[2] == 21)
                return setFrameTimer();
            else if (dataList[2] == 22)
                return setCapTouch18();
            else if (dataList[2] == 24)
                return setResistanceInput();
            else if (dataList[2] == 25)
                return setPulseOnChange();
            else if (dataList[2] == 26)
                return setHFServo();
            else if (dataList[2] == 27)
                return setUltrasonicDistanceSensor();
            else if (dataList[2] == 28)
                return setLiquidCrystal();
            else if (dataList[2] == 29)
                return setHSClock();
            else if (dataList[2] == 30)
                return setHSCounter();
            else if (dataList[2] == 31)
                return setVGA();
            else if (dataList[2] == 34)
                return setQueuedPulseOutput();
            else
                return $"Configure Pin {dataList[1]} mode {dataList[2]} ";

        }

        static public string configureInputProcessor()
        {
            if ((dataList[3] == 0))
                return $"Configure Pin {dataList[1]} Input Processing enabled {dataList[4]}";
            else if ((dataList[3] == 1))
                return $"Configure Pin {dataList[1]} IP SamplesToAverage: {dataList[4] + 256 * dataList[5]} FilterConstant: {dataList[6] + 256 * dataList[7]}";
            else if ((dataList[3] == 2))
                return $"Configure Pin {dataList[1]} IP ExcludeBelow: {dataList[4] + 256 * dataList[5]} ExcludeAbove: {dataList[6] + 256 * dataList[7]}";
            else if ((dataList[3] == 3))
                return $"Configure Pin {dataList[1]} IP Invert {dataList[4]}";
            else if ((dataList[3] == 4))
                return $"Configure Pin {dataList[1]} IP Public Data Mode: {dataList[4]}";
            else if ((dataList[3] == 5))
                return $"Configure Pin {dataList[1]} IP Queue: {dataList[4] + 256 * dataList[5]} Freq: {dataList[6]} HBLB: {dataList[7]}";
            else if ((dataList[3] == 6))
                return $"Configure Pin {dataList[1]} IP ScaleRange Mode - Low:{dataList[4] + 256 * dataList[5]} High:{dataList[6] + 256 * dataList[7]}";
            else if ((dataList[3] == 7))
                return $"Configure Pin {dataList[1]} IP Slope Int32";
            else if ((dataList[3] == 8))
                return $"Configure Pin {dataList[1]} IP Offset Int32";
            else if ((dataList[3] == 9))
                if (isResponse)
                    return $"Set pin {dataList[1]} IP read Min: {dataList[4] + dataList[5] * 256}";
                else
                    return $"Set pin {dataList[1]} IP read Min. Reset: {dataList[4]}";
            else if ((dataList[3] == 10))
                if (isResponse)
                    return $"Set pin {dataList[1]} IP read Max: {dataList[4] + dataList[5] * 256}";
                else
                    return $"Set pin {dataList[1]} IP read Max. Reset: {dataList[4]}";
            else if ((dataList[3] == 11))
                if (isResponse)
                    return $"Set pin {dataList[1]} IP read avg: {dataList[4] + dataList[5] * 256} filtered: {dataList[6] + dataList[7] * 256}";
                else
                    return $"Set pin {dataList[1]} IP read avg, filtered";
            else
                unknown();
            return $"Set pin {dataList[1]} Input Process unknown command";


        }

        static public string configureOutputScaling()
        { //TODO These aren't right
            if ((dataList[3] == 0))
                return $"Configure Pin {dataList[1]} Output Scaling enabled {dataList[4]}, Source pin {dataList[5]}";
            else if ((dataList[3] == 1))
                return $"Configure Pin {dataList[1]} OS Comm Timeout mS: {dataList[4] + 256 * dataList[5]} Timeout Value: {dataList[6] + 256 * dataList[7]}";
            else if ((dataList[3] == 2))
                return $"Configure Pin {dataList[1]} OS Input Min: {dataList[4] + 256 * dataList[5]} input Max: {dataList[6] + 256 * dataList[7]}";
            else if ((dataList[3] == 3))
                return $"Configure Pin {dataList[1]} OS Invert {dataList[4]}";
            else if ((dataList[3] == 4))
                return $"Configure Pin {dataList[1]} OS Filter Mode: {dataList[4]} Filter Constant:{dataList[5] + 256 * dataList[6]}";
            else if ((dataList[3] == 5))
                return $"Configure Pin {dataList[1]} OS Output Min: {dataList[4] + 256 * dataList[5]} Output Max: {dataList[6] + 256 * dataList[7]}";
            else if ((dataList[3] == 6))
                return $"Configure Pin {dataList[1]} OS TargetValue:{dataList[4] + 256 * dataList[5]}";
            else if ((dataList[3] == 7))
                return $"Configure Pin {dataList[1]} Sample Rate Enum: {dataList[4]}";
            else if (dataList[3] == 8)
                return $"Configure Pin {dataList[1]} Filter constant : {uint16(4)}";
            else if (dataList[3] == 9)
            {
                if (isResponse)
                    return $"Set pin {dataList[1]} Last Value {uint16(4)}";
                else

                    return $"Set pin {dataList[1]} Request last value";
            }
            else if ((dataList[3] == 10))
                return $"Configure Pin {dataList[1]} Linear Interpolation setup address {hex4(4)}";
            else if (dataList[3] == 49)
                return $"Configure Pin {dataList[1]} Output Transform Mode None";
            else if ((dataList[3] == 50))
                return $"Configure Pin {dataList[1]} OS hysteresis high Limit{dataList[4] + 256 * dataList[5]} High Output: {dataList[6] + 256 * dataList[7]}";
            else if ((dataList[3] == 51))
                return $"Configure Pin {dataList[1]} OS hysteresis Low Limit{dataList[4] + 256 * dataList[5]} Low Output: {dataList[6] + 256 * dataList[7]}";
            else if ((dataList[3] == 52))
                return $"Configure Pin {dataList[1]} OS hysteresis Last value {dataList[4] + 256 * dataList[5]}";
            else if (dataList[3] == 60)
                return $"Configure Pin {dataList[1]} OS Transform Mode Ramp Slow Inc {uint16(4)} Increment Diff: {uint16(6)}";
            else if (dataList[3] == 61)
                return $"Configure Pin {dataList[1]} OS Transform Mode Ramp Increment {uint16(4)} ";
            else if ((dataList[3] == 100))
                return $"Configure Pin {dataList[1]} OS PID  KP: {dataList[4] + 256 * dataList[5]} KI:{dataList[6] + 256 * dataList[7]}";
            else if ((dataList[3] == 101))
                return $"Configure Pin {dataList[1]} OS PID  KD: {dataList[4] + 256 * dataList[5]} ";
            else if ((dataList[3] == 102))
                return $"Configure Pin {dataList[1]} OS PID  Integrator to zero";
            else if (dataList[3] == 103)
            {
                if (isResponse)
                    return $"Set pin {dataList[1]} PID Last Error {hex8(4)}";
                else
                    return $"Set pin {dataList[1]} Request PID last error";
            }
            else if (dataList[3] == 104)
            {
                if (isResponse)
                    return $"Set pin {dataList[1]} PID Last Integrator {hex8(4)}";
                else
                    return $"Set pin {dataList[1]} Request PID last Integrator";
            }
            else if (dataList[3] == 105)
            {
                if (isResponse)
                    return $"Set pin {dataList[1]} PID Last Integrator Effort {hex8(4)}";
                else
                    return $"Set pin {dataList[1]} Request PID last Integrator Effort";
            }
            else if (dataList[3] == 106)
            {
                if (isResponse)
                    return $"Set pin {dataList[1]} PID Last Proportional Effort {hex8(4)}";
                else
                    return $"Set pin {dataList[1]} Request PID last Proportional Effort";
            }
            else if (dataList[3] == 107)
            {
                if (isResponse)
                    return $"Set pin {dataList[1]} PID Last Derivative Effort {hex8(4)}";
                else
                    return $"Set pin {dataList[1]} Request PID last Derivative Effort";
            }
            else if (dataList[3] == 108)
            {
                if (isResponse)
                    return $"Set pin {dataList[1]} PID Last Total Effort {hex8(4)}";
                else
                    return $"Set pin {dataList[1]} Request PID last Total Effort";
            }
            else if (dataList[3] == 109)
                return $"Configure Pin {dataList[1]} OS PID  Target pin {dataList[4]}  Add 0x8000: {dataList[5]}";
            else if (dataList[3] == 110)
                return $"Configure Pin {dataList[1]} OS PID Reset Integrator and set  Target value {uint16(4)}";
            else if (dataList[3] == 111)
            {
                if (isResponse)
                    return $"Set pin {dataList[1]} PID Last Target value {hex4(4)}";
                else
                    return $"Set pin {dataList[1]} Request Last Target Value";
            }
            else
                unknown();
            return $"Set pin {dataList[1]} Input Process unknown command";

        }

        static public string setDigitalIO()
        {
            string state = "";
            if (dataList[0] == 0xC8)
            {
                if ((dataList[3] == 0))
                {
                    state = "Low";
                    if ((dataList[6] == 1))
                        state = state + ", Open Drain";
                    else if ((dataList[3] == 1))
                        state = "High";
                    if ((dataList[6] == 1))
                        state = state + ", Open Drain";
                }
                else if ((dataList[3] == 2))
                    state = "Input";
                else
                    state = "Unknown";

                if ((dataList[4] == 0))
                    state = state + " - Pull Up Disabled";
                else
                    state = state + " - Pull Up Enabled";


                return $"Set pin {dataList[1]} Digital {state}";
            }
            else
                unknown();
            return $"Set pin {dataList[1]} Digital IO- Unknown command  ";

        }

        static public string setControlled()
        {
            return $"Set pin {dataList[1]} Controlled - Unknown command ";

        }

        static public string setServo()
        {
            if (dataList[0] == 0xC8)
            {
                bool reverse = dataList[6] > 0;
                int position = dataList[4] + dataList[5] * 256;
                return $"Set pin {dataList[1]} Servo- Position: {position} reverse:{reverse} ";
            }
            else if (dataList[0] == 0xC9)
                return $"Set pin {dataList[1]} Servo- fixedTime: {dataList[3] + dataList[4] * 256} uS, variableTime:{dataList[5] + dataList[6] * 256} uS";
            else
            {
                unknown();
                return $"Set pin {dataList[1]} Servo- Unknown command {dataList[0]} ";
            }

        }

        static public string setThroughputConsumer()
        {
            if (dataList[0] == 0xC8)
                return $"Set pin {dataList[1]} Throughput Consumer Reset all to Zero";
            else if (dataList[0] == 0xC9)
                return $"Set pin {dataList[1]} Throughput Consumer entry {dataList[3]} to {dataList[4] + dataList[5] * 256}";
            else if (dataList[0] == 0xCA)
                return $"Set pin {dataList[1]} Throughput Consumer consume {dataList[3] + dataList[3] * 256} now";
            else
                return $"Set pin {dataList[1]} Throughput Coonsumer ";

        }

        static public string setQuadEnc()
        {
            if (dataList[0] == 0xC8)
                return $"Set pin {dataList[1]} QuadEnc- debounce count:{dataList[3] + dataList[4] * 256} 2nd Pin:{dataList[5]}  Read State: {dataList[6]} Pull Ups Enabled: {dataList[7]} ";
            else
            {
                unknown();
                return $"Set pin {dataList[1]} Quad Enc- Unknown command {dataList[0]} ";
            }

        }

        static public string setHBridge()
        {
            if (dataList[0] == 0xC8)
                return $"Set pin {dataList[1]} HBridge- 2nd Pin:{dataList[3]} Driver enum: {dataList[5]}";
            else if (dataList[0] == 0xDC)
                return $"Set pin {dataList[1]} HBridge- PWM Period {dataList[3] + dataList[4] * 256 + dataList[5] * 65536 + dataList[6] * 256 * 65536} ";
            else
                unknown();
            return $"Set pin {dataList[1]} HBridge- Unknown command {dataList[0]} ";

        }

        static public string setWatchdog()
        {
            if (dataList[0] == 0xC8)
                return $"Set pin {dataList[1]} Watchdog: NonTimeout State:{dataList[3]}, TimeoutState:{dataList[4]}, Timeout (mS) {dataList[5] + 256 * dataList[6]}, ResetOnTimeout: {dataList[7]}    ";
            else if (dataList[0] == 0xC9)
                return $"Set pin {dataList[1]} Watchdog: Use Pin Bitfield: {dataList[3]}, PinBitfield:{dataList[4]}, Delay in TimeoutState (mS) {dataList[5] + 256 * dataList[6]}     ";

            else
            {
                unknown();
                return $"Set pin {dataList[1]} Watchdog - Unknown command {dataList[0]} ";
            }

        }

        static public string setInputProcessor()
        {
            return $"Set pin {dataList[1]} Input Processor, source pin {dataList[3]}, default value {dataList[4]} ";

        }

        static public string setAnalogInput()
        {
            if (dataList[0] == 0xC8)
                return $"Set pin {dataList[1]} Analog Input - (Initialization) ";
            else if (dataList[0] == 0xC9)
                return $"Set pin {dataList[1]} Analog Input - Set Total Samples {dataList[3]}, filter constant {dataList[5] + dataList[6] * 256} ";
            else if (dataList[0] == 0xCB)
                if (isResponse)
                    return $"Set pin {dataList[1]} Analog Input - Min: {dataList[3] + dataList[4] * 256} Max: {dataList[5] + dataList[6] * 256}";
                else
                    return $"Set pin {dataList[1]} Analog Input - Read Min/Max, Reset MinMax: {dataList[3]} ";
            else if (dataList[0] == 0xCC)
                if (isResponse)
                    return $"Set pin {dataList[1]} Analog Input - Averaged: {dataList[3] + dataList[4] * 256} Filtered: {dataList[5] + dataList[6] * 256}";
                else
                    return $"Set pin {dataList[1]} Analog Input - Read Averaged / Filtered ";
            else
                unknown();
            return $"Set pin {dataList[1]} Analog Input - Unknown command {dataList[0]} ";

        }

        static public string setResistanceInput()
        {
            if (dataList[0] == 0xC8)
                return $"Set pin {dataList[1]} Resistance Input - (Initialization) ";
            else if (dataList[0] == 0xC9)
                return $"Set pin {dataList[1]} Resistance Input - Set Total Samples {dataList[3]}, filter constant {dataList[5] + dataList[6] * 256} ";
            else if (dataList[0] == 0xCB)
            {
                if (isResponse)
                    return $"Set pin {dataList[1]} Resistance Input - Min: {dataList[3] + dataList[4] * 256} Max: {dataList[5] + dataList[6] * 256}";
                else
                    return $"Set pin {dataList[1]} Resistance Input - Read Min/Max, Reset MinMax: {dataList[3]} ";
            }
            else if (dataList[0] == 0xCC)
            {
                if (isResponse)
                    return $"Set pin {dataList[1]} Resistance Input - Averaged: {dataList[3] + dataList[4] * 256} Filtered: {dataList[5] + dataList[6] * 256}";
                else
                    return $"Set pin {dataList[1]} Resistance Input - Read Averaged / Filtered ";
            }
            else
                unknown();
            return $"Set pin {dataList[1]} Resistance Input - Unknown command {dataList[0]} ";

        }

        static public string setPulseOnChange()
        {
            if (dataList[0] == 0xC8)
                return $"Set pin {dataList[1]} PulseOnChange active mode: {dataList[3]} Inactive mode {dataList[4]} orNotAnd: {dataList[5]}";
            else if (dataList[0] == 0xC9)
                return $"Set pin {dataList[1]} PulseOnChange ontime:{dataList[3] + dataList[4] * 256} offtime: {dataList[5] + dataList[6] * 256} ";
            else if (dataList[0] == 0xCA)
                return $"Set pin {dataList[1]} PulseOnChange pwmPeriod:{dataList[3] + dataList[4] * 256} pwmDuty: {dataList[5] + dataList[6] * 256} ";
            else if (dataList[0] == 0xCB)
                return $"Set pin {dataList[1]} PulseOnChange configure entry {dataList[3]} value0: {dataList[4] + dataList[5] * 256} value1: {dataList[6] + dataList[7] * 256} ";
            else if (dataList[0] == 0xCC)
                return $"Set pin {dataList[1]} PulseOnChange configure entry {dataList[3]} mode: {dataList[4]} sourcePin: {dataList[5]}";
            else
                unknown();
            return $"Set pin {dataList[1]} PulseOnChange - Unknown command {dataList[0]} ";

        }

        static public string setHFServo()
        {
            if (dataList[0] == 0xC8)
            {
                bool reverse = dataList[6] > 0;
                int position = dataList[4] + dataList[5] * 256;
                return $"Set pin {dataList[1]} HF Servo- Position: {position} reverse:{reverse} ";
            }
            else if (dataList[0] == 0xC9)
                return $"Set pin {dataList[1]} HF Servo- fixedTime: {dataList[3] + dataList[4] * 256} uS, variableTime:{dataList[5] + dataList[6] * 256} uS";
            else if (dataList[0] == 0xCB)
                return $"Set pin {dataList[1]} HF Servo- period: {dataList[3] + dataList[4] * 256} uS";
            else
            {
                unknown();
                return $"Set pin {dataList[1]} HF Servo- Unknown command {dataList[0]} ";
            }
        }

        static public string setVGA()
        {
            if (dataList[0] == 0xC8)
                return $"Set pin {dataList[1]} VGA:  Buffer Address:  0x{hex4(6)}";
            else if (dataList[0] == 0xC9)
            {
                if (dataList[3] == 0)
                    return $"Set pin {dataList[1]} VGA set Pixel ({dataList[4]},{dataList[5]}) to color {dataList[6]}";
                if (dataList[3] == 1)
                    return $"Set pin {dataList[1]} VGA Fill Screen color {dataList[4]}";
                if (dataList[3] == 2)
                    return $"Set pin {dataList[1]} VGA Fill Rect  ({dataList[4]},{dataList[5]}) to ({dataList[6]},{dataList[7]})";
                if (dataList[3] == 3)
                    return $"Set pin {dataList[1]} VGA Clear Rect ({dataList[4]},{dataList[5]}) to ({dataList[6]},{dataList[7]})";
                else
                {
                    unknown();
                    return $"Set pin {dataList[1]} VGA Unknown command {dataList[3]}";

                }
            }
            else if (dataList[0] == 0xCA)
                return $"Set pin {dataList[1]} VGA line {dataList[3]} to {dataList[4]} to color {dataList[5]}";
            else
            {
                unknown();
                return $"Set pin {dataList[1]} VGA - Unknown command {dataList[0]}";
            }

        }

        static public string setQueuedPulseOutput()
        {
            string units = "";
            if (dataList[0] == 0xC8)
            {
                if ((dataList[5] > 0))
                    units = "mS";
                else
                    units = "uS";
                return $"Set pin {dataList[1]} Queued Pulse Output - Initial State: {dataList[3]} Idle State: {dataList[4]} Units: {units}  Queue Address: {hex4(6)}";
            }
            else if (dataList[0] == 0xC9)
            {
                string item1 = "";
                string item2 = "";
                if ((isResponse))
                    return $"Set pin {dataList[1]} Queued Pulse Output - Queue result code:  {dataList[3]} items in queue: {uint16(4)} Free items in queue: {uint16(6)}";
                else
                    if ((dataList[4] >= 128))
                    item1 = "High";
                else
                    item1 = "Low ";
                if ((dataList[6] >= 128))
                    item2 = "High";
                else
                    item2 = "Low";
                return $"Set pin {dataList[1]} Queued Pulse Output - Queue {item1} {dataList[3] + (dataList[4] & 0x7F) * 256}, queue {item2} {dataList[5] + (dataList[6] & 0x7F) * 256}";
            }
            else
                unknown();
            return $"Set pin {dataList[1]} HF Servo- Unknown command {dataList[0]} ";


        }

        static public string setProtectedOutput()
        {
            if (dataList[0] == 0xC8)
                return $"Set pin {dataList[1]} Protected Output - Expected Value {dataList[3] + 256 * dataList[4]} Debounce time: {dataList[5]} monitorPin: {dataList[6]} Safe State: {dataList[7]}";
            else if (dataList[0] == 0xC9)
                return $"Set pin {dataList[1]} Protected Output - Match Method: {dataList[3]}";
            else
                unknown();
            return $"Set pin {dataList[1]} Protected Output - Unknown command {dataList[0]} ";

        }

        static public string setDebounce()
        {
            if (dataList[0] == 0xC8)
                return $"Set pin {dataList[1]} Debounce:  Pull ups: {dataList[7]}, period (mS){dataList[3]},  invert: {dataList[5]} ";
            if (dataList[0] == 0xC9)
            {
                if (isResponse)
                    return $"Set pin {dataList[1]} Debounce:  Level: {dataList[3]}, transitions:{dataList[4] + dataList[5] * 256}  Stable mS:  {dataList[6] + dataList[7] * 256}";
                else
                    return $"Set pin {dataList[1]} Debounce:  Request data";
            }
            else
                unknown();
            return $"Set pin {dataList[1]} Debounced Inp. - Unknown command {dataList[0]}";


        }

        static public string setTM1637()
        {
            if (dataList[0] == 0xC8)
                return $"Set pin {dataList[1]} TM1637: CLK Pin:{dataList[3]}, Digits: {dataList[4]}  Mode: {dataList[5]} Source: {dataList[6]} Bright: {dataList[7]}";
            else if (dataList[0] == 0xC9)
                return $"Set pin {dataList[1]} TM1637: Map 0 dig:{dataList[3]}, Map 1 dig: {dataList[4]}  Map 2 dig: {dataList[5]} Map 3 dig: {dataList[6]} Map 4 dig: {dataList[7]}";
            else if (dataList[0] == 0xCA)
                return $"Set pin {dataList[1]} TM1637: Map 5 dig:{dataList[3]}";
            else if (dataList[0] == 0xCB)
                return $"Set pin {dataList[1]} TM1637: Brightness:{dataList[3]}";
            else if (dataList[0] == 0xCC)
                return $"Set pin {dataList[1]} TM1637: Output 0:{dataList[3]},  Output 1: {dataList[4]}  Output 2: {dataList[5]} Output 3: {dataList[6]} Output 4: {dataList[7]}  Anim: Addr: {hex4(3)} Delay:{hex4(5)} Frames: {dataList[7]}";
            else if (dataList[0] == 0xCD)
                return $"Set pin {dataList[1]} TM1637: Decimal bitmap:{dataList[3]}";
            else
                unknown();
            return $"Set pin {dataList[1]} TM1637 - Unknown command {dataList[0]}";

        }

        static public string setWS2812()
        {
            if (dataList[0] == 0xC8)
                return $"Set pin {dataList[1]} WS2812: Buff indx: {hex4(3)}, #LEDs:{dataList[5]}";
            else if (dataList[0] == 0xC9)
                return $"Set pin {dataList[1]} WS2812: Set LED:{dataList[3]} Blue: {hex2(4)} Green: {hex2(5)} Red: {hex2(5)}";
            else if (dataList[0] == 0xCA)
            {
                if (isResponse)
                    return $"Set pin {dataList[1]} WS2812:  Bytes Required: {dataList[3] + dataList[4] * 256}";
                else
                    return $"Set pin {dataList[1]} WS2812:  Request bytes required for {dataList[3]} LEDs";
            }
            else if (dataList[0] == 0xCB)
                return $"Set pin {dataList[1]} WS2812: Set Frame:{dataList[3]} LED:{dataList[4]} Blue: {hex2(5)} Green: {hex2(6)} Red: {hex2(7)}";
            else if (dataList[0] == 0xCC)
                return $"Set pin {dataList[1]} WS2812: Anim indx: {hex4(3)}, #Frames:{dataList[5]}";
            else if (dataList[0] == 0xCD)
                return $"Set pin {dataList[1]} WS2812: Anim delay frame:{dataList[3]} to {dataList[4] + dataList[5] * 256} mS";
            else if (dataList[0] == 0xCE)
            {
                if (dataList[3] == 0)
                    return $"Set pin {dataList[1]} WS2812: Mode Buffered RGB";
                else if (dataList[3] == 1)
                    return $"Set pin {dataList[1]} WS2812: Mode Animation";
                else if (dataList[3] == 2)
                    return $"Set pin {dataList[1]} WS2812: Mode Chase";
                else
                {
                    unknown();
                    return $"Set pin {dataList[1]} WS2812: Mode UNKNOWN";
                }
            }
            else
                unknown();
            return $"Set pin {dataList[1]} WS2812 - Unknown command {dataList[0]}";



        }

        static public string setMatrixKeypad()
        {
            if (dataList[0] == 0xC8)
                return $"Set pin {dataList[1]} Matrix Keypad r0: {dataList[3]} r1: {dataList[4]} r2: {dataList[5]} r3: {dataList[6]} c0: {dataList[7]} ";
            else if (dataList[0] == 0xCA)
            {
                if (isResponse)
                    return $"Set pin {dataList[1]} Matrix Keypad- Read data: Read {dataList[3]} bytes:{hexList(4, dataList[3])} ";
                else
                    return $"Set pin {dataList[1]} Matrix Keypad- Read data: up to {dataList[3]} bytes";
            }
            else if (dataList[0] == 0xCB)
            {
                if (isResponse)
                    return $"Set pin {dataList[1]} Matrix Keypad- Peek data:   {dataList[3]} bytes rx available, 1st available data value: {hex2(5)}";
                else
                    return $"Set pin {dataList[1]} Matrix Keypad- Peek data";
            }
            if (dataList[0] == 0xCD)
                return $"Set pin {dataList[1]} Matrix Keypad c1: {dataList[3]} c2: {dataList[4]} c3: {dataList[5]} buf mode: {dataList[6]} queue mode: {dataList[7]} ";
            if (dataList[0] == 0xCE)
            {
                if (isResponse)
                    return $"Set pin {dataList[1]} Matrix Keypad Get info Pressed: {dataList[3]} Changecount:{dataList[4] + dataList[5] * 256} Current held time: {dataList[6] + dataList[7] * 256}";
                else
                    return $"Set pin {dataList[1]} Matrix Keypad Get info for key Index {dataList[4]}  Reset count: {dataList[3]}";
            }
            if (dataList[0] == 0xCF)
                return $"Set pin {dataList[1]} Matrix Keypad set queueMask {hex2(3)}";
            if (dataList[0] == 0xD0)
                return $"Set pin {dataList[1]} Matrix Keypad set delay Period {dataList[3]}";
            else
                unknown();
            return $"Set pin {dataList[1]} Matrix Keypad - Unknown command {dataList[0]} ";

        }

        static public string setPWM()
        {
            if (dataList[0] == 0xC8)
            {
                int counts = dataList[4] + dataList[5] * 256;
                return $"Set pin {dataList[1]} PWM- Duty Cycle: {counts}/65535, {counts * 100 / 65535}%  Invert: {dataList[6]}";
            }
            else
            {
                unknown();
                return $"Set pin {dataList[1]} PWM - Unknown command {dataList[0]} ";
            }

        }

        static public string setUARTTXRX()
        {
            string swUart = "HW1";
            if (dataList[2] == 23)
                swUart = "HW2";
            if (dataList[2] == 13)
                swUart = " SW";
            if (dataList[0] == 0xC8)
            {
                int baud = 0;
                int[] baudList = { 300, 1200, 2400, 4800, 9600, 19200, 38400, 57600, 115200 };
                if (dataList[3] <= 8)

                    baud = baudList[dataList[3]];
                else
                    baud = 115200;

                string outstr = $"Set pin {dataList[1]}";
                if (dataList[2] == 13) //software uart
                {
                    outstr = outstr + swUart;
                }
                return outstr + $" UART- Baud: {baud}, Rx Pin: {dataList[4]}, Tx Pin {dataList[5]}";
            }
            else if (dataList[0] == 0xC9)
            {
                if (isResponse)
                    return $"Set pin {dataList[1]} {swUart} UART- Transmit data: {dataList[3]} bytes tx buffer available, {dataList[4]} bytes available for RX";
                else
                    return $"Set pin {dataList[1]} {swUart} UART- Transmit data: {hexList(4, dataList[3])}";
            }
            else if (dataList[0] == 0xCA)
            {
                if (isResponse)
                    return $"Set pin {dataList[1]} {swUart} UART- Read data: Read {dataList[3]} bytes:{hexList(4, dataList[3])} ";
                else
                    return $"Set pin {dataList[1]} {swUart} UART- Read data: up to {dataList[3]} bytes";
            }
            else if (dataList[0] == 0xCB)
            {
                if (isResponse)
                    return $"Set pin {dataList[1]} {swUart} UART- Peek data:  {dataList[3]} bytes tx buffer available, {dataList[3]} bytes rx available, 1st available data value: {hex4(5)}";
                else
                    return $"Set pin {dataList[1]} {swUart} UART- Peek data";
            }
            else if (dataList[0] == 0xCC)
                return $"Set pin {dataList[1]} {swUart} UART- Close Port";
            else if (dataList[0] == 0xCD)
            {
                if (isResponse)
                    return $"Set pin {dataList[1]} {swUart} UART- Bytes free in Tx queue  {dataList[5] + dataList[6] * 256} bytes";
                else
                    return $"Set pin {dataList[1]} {swUart} UART- Set TX queue Index {dataList[3] + 256 * dataList[4]}";
            }
            else if (dataList[0] == 0xCE)
            {
                if (isResponse)
                    return $"Set pin {dataList[1]} {swUart} UART- Bytes free in Rx queue  {dataList[5] + dataList[6] * 256} bytes";
                else
                    return $"Set pin {dataList[1]} {swUart} UART- Set RX queue Index {dataList[3] + 256 * dataList[4]}";
            }
            else
                unknown();
            return $"Set pin {dataList[1]} UARTTXRX - Unknown command {dataList[0]}  ";


        }

        static public string setPulseTimer()
        {
            string units = "";
            string pullUps = "";
            if (dataList[0] == 0xC8)
            {
                if ((dataList[4] == 0))
                    units = "uS";
                else
                    units = "mS";
                if ((dataList[3] == 0))
                    pullUps = "Pull Ups Disabled";
                else
                    pullUps = "Pull Ups Enabled";
                return $"Set pin {dataList[1]} Pulse Timer- {pullUps} units {units}  ";
            }
            else if (dataList[0] == 0xC9)
            {
                if (isResponse)
                    return $"Set pin {dataList[1]} Pulse Timer- High time: {dataList[3] + dataList[4] * 256}  Low time: {dataList[5] + dataList[6] * 256} Count LSB: {dataList[7]}";
                else
                    return $"Set pin {dataList[1]} Pulse Timer- Read High Time  Low Time";
            }
            else if (dataList[0] == 0xCA)
            {
                if (isResponse)
                    return $"Set pin {dataList[1]} Pulse Timer- High time: {dataList[3] + dataList[4] * 256}  Count: {dataList[5] + dataList[6] * 256} Overflow: {dataList[7]}";
                else
                    return $"Set pin {dataList[1]} Pulse Timer- Read High Time  Low Time";
            }
            else
                unknown();
            return $"Set pin {dataList[1]} Pulse Timer - Unknown command {dataList[0]}";

        }

        static public string setFrameTimer()
        {
            return $"Set pin {dataList[1]} to frame timer";

        }

        static public string setCapTouch18()
        {
            if (dataList[0] == 0xC8)
                return $"Set pin {dataList[1]} CapTouch18- Charge Counts:{uint16(3)} Delay: {uint16(5)}  ";
            else if (dataList[0] == 0xC9)
                return $"Set pin {dataList[1]} CapTouch18- Dig Low Limit:{dataList[3] + dataList[4] * 256}  Dig High Limit:{dataList[5] + dataList[6] * 256}";
            else if (dataList[0] == 0xCA)
                return $"Set pin {dataList[1]} CapTouch18- Dig Low Value:{dataList[3] + dataList[4] * 256}  Dig High Value:{dataList[5] + dataList[6] * 256}";
            else if (dataList[0] == 0xCB)
                return $"Set pin {dataList[1]} CapTouch18- DigEnable: {dataList[3]} Invert: {dataList[4]} Debounce: {dataList[5] + dataList[6] * 256} ";
            else if (dataList[0] == 0xCC)
            {
                if (isResponse)
                    return $"Set pin {dataList[1]} CapTouch Timer- Current State: {dataList[3]}  Transitions: {dataList[4] + dataList[5] * 256}  Time: {dataList[6] + dataList[7] * 256}";
                else
                    return $"Set pin {dataList[1]} CapTouch Request Digital - Reset Trans: {dataList[3]}";
            }
            else
                unknown();
            return $"Set pin {dataList[1]} CapTouch18 - Unknown command {dataList[0]}";

        }

        static public string setUltrasonicDistanceSensor()
        {
            if (dataList[0] == 0xC8)
                return $"Set pin {dataList[1]} Ultrasonic Distance Sensor- Driver: {dataList[3]} Trig Pin: {dataList[4]} Pull up: {dataList[5]} AutoTrigger: {dataList[6]}  ";
            else if (dataList[0] == 0xC9)
            {
                if (isResponse)
                    return $"Set pin {dataList[1]} Ultrasonic Distance Sensor - Distance: {dataList[3] + dataList[4] * 256} mm   Pulse Count: {dataList[5] + dataList[6] * 256} ";
                else
                    return $"Set pin {dataList[1]} UltraSonic Distance sensor  Manual Trigger: {dataList[3]}";
            }
            else if (dataList[0] == 0xCA)
            {
                if (isResponse)
                    return $"Set pin {dataList[1]} Ultrasonic Distance Sensor - Distance: {dataList[3] + dataList[4] * 256} mm   Pulse Count: {dataList[5] + dataList[6] * 256} ";
                else
                    return $"Set pin {dataList[1]} UltraSonic Distance sensor  Request Distance  Pulse Count";
            }
            else if (dataList[0] == 0xCB)
            {
                if (isResponse)
                    return $"Set pin {dataList[1]} Ultrasonic Distance Sensor - Servo pin {dataList[3]} Mem Index: {hex2(4)}   Positions: {dataList[6] + dataList[7] * 256} ";
                else
                    return $"Set pin {dataList[1]} Ultrasonic Distance Sensor - Servo pin {dataList[3]} Mem Index: {hex2(4)}   Positions: {dataList[6] + dataList[7] * 256} ";
            }
            else if (dataList[0] == 0xCC)
            {
                if (isResponse)
                    return $"Set pin {dataList[1]} Ultrasonic Distance Sensor - Servo increment: {dataList[3] + dataList[4] * 256}   Reverse: {dataList[7]} ";
                else
                    return $"Set pin {dataList[1]} Ultrasonic Distance Sensor - Servo increment: {dataList[3] + dataList[4] * 256}   Reverse: {dataList[7]} ";
            }
            else if (dataList[0] == 0xCD)
            {
                if (isResponse)
                    return $"Set pin {dataList[1]} Ultrasonic Distance Sensor -  Move delay: {dataList[3] + dataList[4] * 256}   Return Delay: {dataList[5] + dataList[6] * 256} ";
                else
                    return $"Set pin {dataList[1]} Ultrasonic Distance Sensor -  Move delay: {dataList[3] + dataList[4] * 256}   Return Delay: {dataList[5] + dataList[6] * 256} ";
            }
            else if (dataList[0] == 0xCD)
            {
                if (isResponse)
                    return $"Set pin {dataList[1]} Ultrasonic Distance Sensor -  Sweep Enable: {dataList[3]}";
                else
                    return $"Set pin {dataList[1]} Ultrasonic Distance Sensor -  Sweep Enable: {dataList[3]}";
            }

            else
            {
                unknown();

                return "Unknown Ultrasonic Distance Sensor Packet";
            }

        }

        static public string setLiquidCrystal()
        {
            if (dataList[0] == 0xC8)
                return $"Set pin {dataList[1]} Liquid Crystal RS: {dataList[3]} D4: {dataList[4]} D5: {dataList[5]} D6: {dataList[6]} D7: {dataList[7]} ";
            else if (dataList[0] == 0xC9)
                return $"Set pin {dataList[1]} Clock in - Address : {dataList[3]} Data: {dataList[4]} Data: {dataList[5]} Data: {dataList[6]} Data: {dataList[7]} ";
            else if (dataList[0] == 0xCA)
                return $"Set pin {dataList[1]} Set CGRAM - Address : {dataList[3]} Data: {dataList[4]} Data: {dataList[5]} Data: {dataList[6]} Data: {dataList[7]} ";
            else if (dataList[0] == 0xCB)
                return $"Set pin {dataList[1]} Configure Display Control / Mode : {dataList[3]} And Mask: {dataList[4]} Or Mask: {dataList[5]} ";
            else if (dataList[0] == 0xCC)
                return $"Set pin {dataList[1]} Clock first Command/Data  : {dataList[3]} Value: {dataList[4]}  second Command/Data  : {dataList[3]} Value: {dataList[4]} ";
            else if (dataList[0] == 0xCD)
                return $"Set pin {dataList[1]} Clock Five Data  : {hex2(3)} {hex2(4)} {hex2(5)} {hex2(6)} {hex2(7)}";
            else if (dataList[0] == 0xCE)
                return $"Set pin {dataList[1]} Set User Buffer index  : {hex4(3)}  Width: {dataList[5]} ";
            else if (dataList[0] == 0xCF)
                return $"Set pin {dataList[1]} Set E2 Pin  :  {dataList[3]} ";
            else if (dataList[0] == 0xD0)
                return $"Set pin {dataList[1]} Set LCD Row Index  {dataList[3]}  set to {hex2(4)}";
            else
            {
                unknown();
                return "Unknown Liquid Crystal Packet";
            }


        }

        static public string setHSClock()
        {
            if (dataList[0] == 0xC8)
                return $"Set pin {dataList[1]} HS Clock: Frequency {hex8(3)}";
            unknown();
            return "Unknown HS Clock Packet";

        }

        static public string setHSCounter()
        {
            if (dataList[0] == 0xC8)
                return $"Set pin {dataList[1]} HS Counter: Sample Frames {hex4(3)} Public Output Divisor: {hex4(5)}  Public Output type: {dataList[7]} ";
            else if (dataList[0] == 0xC9)
            {
                if (isResponse)
                    return $"Set pin {dataList[1]} HS Counter Read Counter: {uint32(3)}  ";
                else
                    return $"Set pin {dataList[1]} HS Counter Read Counter.   Reset After Read: {dataList[3]} ";
            }
            else if (dataList[0] == 0xCA)
            {
                if (isResponse)
                    return $"Set pin {dataList[1]} HS Counter Read Frequency: {uint32(3)}  ";
                else
                    return $"Set pin {dataList[1]} HS Counter Read Frequency.  ";
            }
            unknown();
            return "Unknown HS Counter Packet";

        }

        static public string queueInit()
        {
            if (isResponse)
            {
                if ((dataList[3] + 256 * dataList[4]) > 0)
                    return $"Queue Init address {hex4(1)}, Actual Length {hex4(3)} Type {dataList[5]} ";
                else
                    return $"Queue Init creation error {dataList[5]}";
            }
            else
                return $"Queue Init address {hex4(1)}, Length {hex4(3)} Type {dataList[5]} ";

        }

        static public string queueAdd()
        {
            byte count = dataList[3];
            if (isResponse)
                return $"Add to Queue.  {uint8(3)} added.  Code: {uint8(4)}  Free bytes: {uint16(5)}";
            else
                return $"Add to Queue Addr: {hex4(1)} count: {count} {hexList(4, count)} ";

        }

        static public string queueAdd7()
        {
            byte count = dataList[3];
            if (isResponse)
                return $"Add 7 bytes to Queue prev addr    {uint8(3)} added.  Code: {uint8(4)}  Free bytes: {uint16(5)}";
            else
                return $"Add 7 bytes to Queue prev addr   {hexList(1)} ";

        }

        static public string queueRead()
        {
            if (isResponse)
            {
                byte count = dataList[1];
                return $"Read Queue.  Count: {uint8(1)}   {hexList(2, count)} ";
            }
            else

                return $"Read Queue Addr: {hex4(1)}  ";

        }

        static public string queueInfo()
        {
            byte count = dataList[3];
            if (isResponse)
                return $"Queue Info. Addr: {hex4(1)} Peek: {hex2(3)} Filled: {uint16(4)} Empty: {uint16(6)}";
            else
                return $"Queue Info Addr: {hex4(1)} ";

        }

        static public string queueClone()
        {
            byte count = dataList[3];
            if (isResponse)
                return $"Clone Queue Info. Addr: {hex4(1)} Peek: {hex2(3)} Filled: {uint16(4)} Empty: {uint16(6)}";
            else
                return $"Clone Queue Addr: {hex4(1)}  Copy Addr: {hex4(3)} ";
        }
    }
}
