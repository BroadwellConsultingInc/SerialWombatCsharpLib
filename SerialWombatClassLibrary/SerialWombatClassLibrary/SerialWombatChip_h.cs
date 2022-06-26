/*
Copyright 2021 Broadwell Consulting Inc.

Permission is hereby granted, free of charge, to any person obtaining a
 * copy of this software and associated documentation files (the "Software"),
 * to deal in the Software without restriction, including without limitation
 * the rights to use, copy, modify, merge, publish, distribute, sublicense,
 * and/or sell copies of the Software, and to permit persons to whom the
 * Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in
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
using System.Collections.Generic;
using System.Text;



public enum SerialWombatPinStates
{
	SW_LOW = 0,
	SW_HIGH = 1,
	SW_INPUT = 2,
}


public enum SerialWombatDataSources
{

	SW_DATA_SOURCE_PIN_0 = 0,
	SW_DATA_SOURCE_PIN_1 = 1,
	SW_DATA_SOURCE_PIN_2 = 2,
	SW_DATA_SOURCE_PIN_3 = 3,
	SW_DATA_SOURCE_PIN_4 = 4,
	SW_DATA_SOURCE_PIN_5 = 5,
	SW_DATA_SOURCE_PIN_6 = 6,
	SW_DATA_SOURCE_PIN_7 = 7,
	SW_DATA_SOURCE_PIN_8 = 8,
	SW_DATA_SOURCE_PIN_9 = 9,
	SW_DATA_SOURCE_PIN_10 = 10,
	SW_DATA_SOURCE_PIN_11 = 11,
	SW_DATA_SOURCE_PIN_12 = 12,
	SW_DATA_SOURCE_PIN_13 = 13,
	SW_DATA_SOURCE_PIN_14 = 14,
	SW_DATA_SOURCE_PIN_15 = 15,
	SW_DATA_SOURCE_PIN_16 = 16,
	SW_DATA_SOURCE_PIN_17 = 17,
	SW_DATA_SOURCE_PIN_18 = 18,
	SW_DATA_SOURCE_PIN_19 = 19,
	//	SW_DATA_SOURCE_PIN_20 = 20,
	//	SW_DATA_SOURCE_PIN_21 = 21,
	//	SW_DATA_SOURCE_PIN_22 = 22,
	//	SW_DATA_SOURCE_PIN_23 = 23,
	//	SW_DATA_SOURCE_PIN_24 = 24,
	//	SW_DATA_SOURCE_PIN_25 = 25,
	//	SW_DATA_SOURCE_PIN_26 = 26,
	//	SW_DATA_SOURCE_PIN_27 = 27,
	//	SW_DATA_SOURCE_PIN_28 = 28,
	//	SW_DATA_SOURCE_PIN_29 = 29,
	//	SW_DATA_SOURCE_PIN_30 = 30,
	//	SW_DATA_SOURCE_PIN_31 = 31,
	//	SW_DATA_SOURCE_PIN_32 = 32,
	//	SW_DATA_SOURCE_PIN_33 = 33,
	//	SW_DATA_SOURCE_PIN_34 = 34,
	//	SW_DATA_SOURCE_PIN_35 = 35,
	//	SW_DATA_SOURCE_PIN_36 = 36,
	//	SW_DATA_SOURCE_PIN_37 = 37,
	//	SW_DATA_SOURCE_PIN_38 = 38,
	//	SW_DATA_SOURCE_PIN_39 = 39,
	//	SW_DATA_SOURCE_PIN_40 = 40,
	//	SW_DATA_SOURCE_PIN_41 = 41,
	//	SW_DATA_SOURCE_PIN_42 = 42,
	//	SW_DATA_SOURCE_PIN_43 = 43,
	//	SW_DATA_SOURCE_PIN_44 = 44,
	//	SW_DATA_SOURCE_PIN_45 = 45,
	//	SW_DATA_SOURCE_PIN_46 = 46,
	//	SW_DATA_SOURCE_PIN_47 = 47,
	//	SW_DATA_SOURCE_PIN_48 = 48,
	//	SW_DATA_SOURCE_PIN_49 = 49,
	//	SW_DATA_SOURCE_PIN_50 = 50,
	//	SW_DATA_SOURCE_PIN_51 = 51,
	//	SW_DATA_SOURCE_PIN_52 = 52,
	//	SW_DATA_SOURCE_PIN_53 = 53,
	//	SW_DATA_SOURCE_PIN_54 = 54,
	//	SW_DATA_SOURCE_PIN_55 = 55,
	//	SW_DATA_SOURCE_PIN_56 = 56,
	//	SW_DATA_SOURCE_PIN_57 = 57,
	//	SW_DATA_SOURCE_PIN_58 = 58,
	//	SW_DATA_SOURCE_PIN_59 = 59,
	//	SW_DATA_SOURCE_PIN_60 = 60,
	//	SW_DATA_SOURCE_PIN_61 = 61,
	//	SW_DATA_SOURCE_PIN_62 = 62,
	//	SW_DATA_SOURCE_PIN_63 = 63,
	SW_DATA_SOURCE_INCREMENTING_NUMBER = 65, ///< An number that increments each time it is accessed.
	SW_DATA_SOURCE_1024mvCounts = 66, ///< The number of ADC counts that result from a 1.024V reading
	SW_DATA_SOURCE_FRAMES_RUN_LSW = 67, ///< The number of frames run since reset, least significant 16 bits
	SW_DATA_SOURCE_FRAMES_RUN_MSW = 68, ///< The number of frames run since reset, most significant 16 bits
	SW_DATA_SOURCE_OVERRUN_FRAMES = 69, ///< The number of frames that ran more than 1mS
	SW_DATA_SOURCE_TEMPERATURE = 70, ///<The internal core temperature expressed in 100ths deg C
	SW_DATA_SOURCE_PACKETS_RECEIVED = 71,  ///<The nubmer of incoming command packets that have been processed since reset (rolls over at 65535)
	SW_DATA_SOURCE_ERRORS = 72,  ///<The number of incoming packets that have caused errors since reset (rolls over at 65535)  
	SW_DATA_SOURCE_FRAMES_DROPPED = 73, ///<The number of times since reset that a frame ran so far behind that it crossed two subsequent 1ms boundaries, causing a permanent lost frame
	SW_DATA_SOURCE_SYSTEM_UTILIZATION = 74, ///< A number between 0 and 65535 that scales to the average length of pin processing frames between 0 and 1000mS
	SW_DATA_SOURCE_VCC_mVOLTS = 75, ///<The system source voltage in mV
	SW_DATA_SOURCE_VBG_COUNTS_VS_VREF = 76, ///< A/D conversion of VBG against VRef .  Used for mfg calibration
	SW_DATA_SOURCE_PIN_0_MV = 100,
	SW_DATA_SOURCE_PIN_1_MV = 101,
	SW_DATA_SOURCE_PIN_2_MV = 102,
	SW_DATA_SOURCE_PIN_3_MV = 103,
	SW_DATA_SOURCE_PIN_4_MV = 104,
	//NOT ANALOG            SW_DATA_SOURCE_PIN_5_MV = 105,
	//NOT ANALOG            SW_DATA_SOURCE_PIN_6_MV = 106,
	//NOT ANALOG            SW_DATA_SOURCE_PIN_7_MV = 107,
	//NOT ANALOG            SW_DATA_SOURCE_PIN_8_MV = 108,
	//NOT ANALOG            SW_DATA_SOURCE_PIN_9_MV = 109,
	//NOT ANALOG            SW_DATA_SOURCE_PIN_10_MV = 110,
	//NOT ANALOG            SW_DATA_SOURCE_PIN_11_MV = 111,
	//NOT ANALOG            SW_DATA_SOURCE_PIN_12_MV = 112,
	//NOT ANALOG            SW_DATA_SOURCE_PIN_13_MV = 113,
	//NOT ANALOG            SW_DATA_SOURCE_PIN_14_MV = 114,
	//NOT ANALOG            SW_DATA_SOURCE_PIN_15_MV = 115,
	SW_DATA_SOURCE_PIN_16_MV = 116,
	SW_DATA_SOURCE_PIN_17_MV = 117,
	SW_DATA_SOURCE_PIN_18_MV = 118,
	SW_DATA_SOURCE_PIN_19_MV = 119,
}



public enum SerialWombatCommands
{
	CMD_ECHO = '!', ///< ('!')
	CMD_READ_BUFFER_ASCII = 'G',///< ('G')
	CMD_ASCII_SET_PIN = 'P', ///< ('P')
	CMD_RESET = 'R', ///< ('R')
	CMD_SET_BUFFER_ASCII = 'S',///< ('S')
	CMD_RESYNC = 'U',///< ('U')
	CMD_VERSION = 'V',///< ('V')
	CMD_SUPPLYVOLTAGE = 'v',///< ('v')
	COMMAND_BINARY_READ_PIN_BUFFFER = 0x81, ///< (0x81)
	COMMAND_BINARY_SET_PIN_BUFFFER = 0x82, ///< (0x82)
	COMMAND_BINARY_READ_USER_BUFFER = 0x83, ///< (0x83)
	COMMAND_BINARY_WRITE_USER_BUFFER = 0x84, ///< (0x84)
	COMMAND_BINARY_WRITE_USER_BUFFER_CONTINUE = 0x85, ///< (0x85)
	COMMAND_BINARY_QUEUE_INITIALIZE = 0x90, ///< (0x90)
	COMMAND_BINARY_QUEUE_ADD_BYTES = 0x91, ///< (0x91)
	COMMAND_BINARY_QUEUE_ADD_7BYTES = 0x92, ///< (0x92)
	COMMAND_BINARY_QUEUE_READ_BYTES = 0x93, ///< (0x93)
	COMMAND_BINARY_QUEUE_INFORMATION = 0x94, ///< (0x94)
	COMMAND_BINARY_CONFIGURE = 0x9F, ///< (0x9F)
	COMMAND_BINARY_READ_RAM = 0xA0, ///< (0xA0)
	COMMAND_BINARY_READ_FLASH = 0xA1, ///< (0xA1)
	COMMAND_BINARY_READ_EEPROM = 0xA2, ///< (0xA2)
	COMMAND_BINARY_WRITE_RAM = 0xA3, ///< (0xA3)
	COMMAND_BINARY_WRITE_FLASH = 0xA4, ///< (0xA4)
	COMMAND_CALIBRATE_ANALOG = 0xA5, ///< (0xA5)
	COMMAND_ENABLE_2ND_UART = 0xA6, ///< (0xA6)
	COMMAND_READ_LAST_ERROR_PACKET = 0xA7, ///< (0xA7)
	COMMAND_UART0_TX_7BYTES = 0xB0, ///< (0xB0)
	COMMAND_UART0_RX_7BYTES = 0xB1, ///< (0xB1)
	COMMAND_UART1_TX_7BYTES = 0xB2, ///< (0xB2)
	COMMAND_UART1_RX_7BYTES = 0xB3, ///< (0xB3)
	CONFIGURE_PIN_MODE0 = 200, ///< (200)
	CONFIGURE_PIN_MODE1 = 201, ///< (201)
	CONFIGURE_PIN_MODE2 = 202, ///< (202)
	CONFIGURE_PIN_MODE3 = 203, ///< (203)
	CONFIGURE_PIN_MODE4 = 204, ///< (204)
	CONFIGURE_PIN_MODE5 = 205, ///< (205)
	CONFIGURE_PIN_MODE6 = 206, ///< (206)
	CONFIGURE_PIN_MODE7 = 207, ///< (207)
	CONFIGURE_PIN_MODE8 = 208, ///< (208)
	CONFIGURE_PIN_MODE9 = 209, ///< (209)
	CONFIGURE_PIN_MODE10 = 210, ///< (210)
	CONFIGURE_PIN_OUTPUTSCALE = 210, ///< (210)
	CONFIGURE_PIN_INPUTPROCESS = 211, ///< (211)
	CONFIGURE_PIN_MODE_HW_0 = 220, ///< (220)
	CONFIGURE_CHANNEL_MODE_HW_1 = 221, ///< (221)
	CONFIGURE_CHANNEL_MODE_HW_2 = 222, ///< (222)
	CONFIGURE_CHANNEL_MODE_HW_3 = 223, ///< (223)
	Unknown = 256, // Will cause exception if loaded into a byte
}



public enum SerialWombatPinModes
{
	PIN_MODE_DIGITALIO = 0,
	PIN_MODE_CONTROLLED = 1,
	PIN_MODE_ANALOGINPUT = 2,
	PIN_MODE_SERVO = 3,
	PIN_MODE_QUADRATUREENCODER = 5,
	PIN_MODE_WATCHDOG = 7,
	PIN_MODE_PROTECTED_OUTPUT = 8,
	PIN_MODE_TM1637 = 11,
	PIN_MODE_WS2812 = 12, ///< (12)
	PIN_MODE_SW_UART = 13, ///< (13)
	PIN_MODE_INPUT_PROCESSOR = 14, ///< (14)
	PIN_MODE_MATRIX_KEYPAD = 15, ///< (15)
	PIN_MODE_PWM = 16,
	PIN_MODE_UART_RX_TX = 17,
	PIN_MODE_PULSETIMER = 18,
	PIN_MODE_FRAME_TIMER = 21, ///< (21)
	PIN_MODE_SW18AB_CAPTOUCH = 22, ///< (22)
	PIN_MODE_UART1_RX_TX = 23, ///< (23)
	PIN_MODE_RESISTANCEINPUT = 24,
	PIN_MODE_PULSE_ON_CHANGE = 25, ///< (25)
	PIN_MODE_HS_SERVO = 26, ///< (26)
	PIN_MODE_ULTRASONIC_DISTANCE = 27,
	PIN_MODE_LIQUIDCRYSTAL = 28,
	PIN_MODE_UNKNOWN = 255
}


namespace SerialWombat
{
    public partial class SerialWombatChip
    {
		/// Stores the last value retreived by readSupplyVoltage_mV().  Used by SerialWombatAnalogInput 
		/// class to calculate mV outputs from retreived A/D counts.
		/// Don't access this member, as it may become private and SerialWombatAnalog input be made
		/// a friend of SerialWombat in the future.  Call readSupplyVoltage_mV instead.
		public UInt16 _supplyVoltagemV = 0;

		/// Contains the last model retreived by queryVersion() as a zero-terminated string
		public byte[] model = { 0,0,0 };

		/// Contains the last firmware Version retreived by queryVersion() as a zero-terminated string
		public byte[] fwVersion = { 0,0,0};

		public byte[] uniqueIdentifier = new byte[16];
		public byte uniqueIdentifierLength = 0;

		public UInt16 deviceIdentifier;
		public UInt16 deviceRevision;
		/// Incremented every time a communication or command error is detected.
		public UInt32 errorCount = 0;

		/// The last error number reported
		public UInt32 errorNum = 0;

		public bool inBoot = false;

		public const int WOMBAT_MAXIMUM_PINS =  19;
		public ArduinoSerial Serial;

		//private:
		//byte address = 0;
		byte[] version = new byte[7];
		byte[] _pinmode = new byte[WOMBAT_MAXIMUM_PINS]; // Includes Pullup
		bool[] _pullDown = new bool[WOMBAT_MAXIMUM_PINS];
		bool[] _openDrain = new bool[WOMBAT_MAXIMUM_PINS];
		bool[] _highLow = new bool[WOMBAT_MAXIMUM_PINS] ;
		bool _asleep = false;
		
		UInt32 sendReadyTime = 0;


		public bool IsSerial = false;
	}
}


