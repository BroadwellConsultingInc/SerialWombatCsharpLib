/*
Copyright 2021-2022 Broadwell Consulting Inc.

Serial Wombat is a registered trademark in the US of Broadwell Consulting Inc.

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
using System.Linq;
using System.Threading;
using System.IO.Ports;
using System.Text;
using System.Collections.Generic;

namespace SerialWombat
{
    public partial class SerialWombatChip
    {


        public Int16 lastErrorCode = 0;



        public SerialWombatChip()
        {
            Serial = new ArduinoSerial();
        }

        public void begin(string portName)
        {

            begin(portName, true);

        }

        public void begin(string portName, bool reset)
        {
            IsSerial = true;
            Serial.begin(portName);
            Serial.setTimeout(1000);
            sendPacket("UUUUUUUU"); // Resync
            if (reset)
            {
                hardwareReset();
                sendReadyTime = millis() + 1000;
            }
            else
            {
                initialize();
            }


        }

        /*
		public void begin(TwoWire& wire, byte i2cAddress)
		{
			begin(wire, i2cAddress, true);

		}
		public void begin(TwoWire& wire, byte i2cAddress, bool reset)
		{
			i2cInterface = &wire;
			address = i2cAddress;
			if (reset)
			{
				hardwareReset();
				sendReadyTime = millis() + 1000;
			}
			else
			{
				sendReadyTime = 0;
				initialize();

			}
		}

		public void begin(byte i2cAddress)
		{
			//i2cInterface = &Wire;
			//address = i2cAddress;
			begin(Wire, i2cAddress);
		}
		*/
        public Int16 initialize()
        {
            lastErrorCode = 0;
            readVersion();
            readSupplyVoltage_mV();
            readUniqueIdentifier();
            readDeviceIdentifier();
            return (lastErrorCode);
        }

        public void readUniqueIdentifier()
        {
            uniqueIdentifierLength = 0;
            if (version[0] == 'S' && version[1] == '0' && version[2] == '4')
            { //16F15214
                for (UInt32 address = 0x8100; address <= 0x8108; ++address)
                {
                    UInt32 data = readFlashAddress(address);
                    uniqueIdentifier[uniqueIdentifierLength] = (byte)data;
                    ++uniqueIdentifierLength;
                    /* Always zero... leave out
					uniqueIdentifier[uniqueIdentifierLength] = (byte)(data>>8);
					++uniqueIdentifierLength;
					*/
                }
            }
            else if (isSW18())
            {
                for (UInt32 address = 0x801600; address <= 0x801608; address += 2)
                {
                    UInt32 data = readFlashAddress(address);
                    uniqueIdentifier[uniqueIdentifierLength] = (byte)(data & 0xFF);
                    ++uniqueIdentifierLength;
                    uniqueIdentifier[uniqueIdentifierLength] = (byte)((data >> 8) & 0xFF);
                    ++uniqueIdentifierLength;
                    uniqueIdentifier[uniqueIdentifierLength] = (byte)((data >> 16) & 0xFF);
                    ++uniqueIdentifierLength;
                }
            }
        }

        public void readDeviceIdentifier()
        {
            if (version[0] == 'S' && version[1] == '0' && version[2] == '4')
            { //16F15214

                UInt32 data = readFlashAddress(0x8006);
                deviceIdentifier = (UInt16)data;
                data = readFlashAddress(0x8005);
                deviceRevision = (UInt16)data;
            }
            else if (isSW18())
            {
                UInt32 data = readFlashAddress(0xFF0000);
                deviceIdentifier = (UInt16)data;
                data = readFlashAddress(0xFF0002);
                deviceRevision = (UInt16)(data & 0xF);
            }
        }

        public SerialWombatPacket sendPacket(SerialWombatPacket packet)
        {
            byte[] rx;
            sendPacket(packet.Data, out rx);
            return (new SerialWombatPacket(rx));
        }
        public int sendPacket(string s)
        {
            byte[] tx = Encoding.GetEncoding("UTF-8").GetBytes(s);
            return sendPacket(tx);
        }

        public int sendPacketNoResponse(string s)
        {
            byte[] tx = Encoding.GetEncoding("UTF-8").GetBytes(s);

            return sendPacketNoResponse(tx);
        }

        public int sendPacketNoResponse(byte[] tx)
        {
            if (tx.Length < 8)
            {
                byte[] newtx = { 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55 };
                tx.CopyTo(newtx, 0);
                tx = newtx; 
            }
            Serial.Pool.WaitOne();
            Serial.write(tx, 8);
            Serial.Pool.Release();
            return (8);
        }
        public int sendPacket(string s, out byte[] rx)
        {
            byte[] tx = Encoding.GetEncoding("UTF-8").GetBytes(s);

            return sendPacket(tx, out rx);
        }
        public Int16 sendPacket(byte[] tx, out byte[] rx)
        {
            rx = new byte[] { (byte)'E', 0, 0, 0, 0, 0, 0, 0 };
            if (tx.Length < 8)
            {
                byte[] newtx = { 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55 };
                tx.CopyTo(newtx, 0);
                tx = newtx;
            }
            if (sendReadyTime != 0)
            {
                UInt32 currentTime = millis();
                if (currentTime < sendReadyTime)
                {
                    delay(sendReadyTime - currentTime);

                }
                sendReadyTime = 0;
                initialize();
            }

            if (IsSerial)
            {
                Serial.Pool.WaitOne();
                Serial.write(tx, 8);  //TODO add addressing, CRC
                int bytesRx = Serial.readBytes(out rx, 8);
                Serial.Pool.Release();

                {
                    SerialWombatPacket txPacket = new SerialWombatPacket(tx);
                    SerialWombatPacket rxPacket = new SerialWombatPacket(rx);
                    foreach (SendDelegate sd in SendDelegates)
                    {
                        sd(txPacket, rxPacket);
                    }
                }

                if (bytesRx < 8)
                {/*TODO
                    if (errorHandler != NULL)
                    {
                        errorHandler(SW_ERROR_LESS_THAN_8_BYTES_RETURNED, this);
                    }
                    */
                    ++errorCount;
                    return (-1 * 48 /*TODO Make Enum SW_ERROR_LESS_THAN_8_BYTES_RETURNED*/);
                }
                if (rx[0] == 'E')
                {
                    lastErrorCode = (Int16)returnErrorCode(rx);
                    /*TODO
                    if (errorHandler != NULL)
                    {
                        errorHandler(lastErrorCode, this);
                    }
                    */
                    lastErrorCode *= -1;
                    ++errorCount;
                    return (lastErrorCode);
                }
                return (8);
            }
            return (0);

        }

        public Int16 sendPacket(byte[] tx)
        {
            byte[] rx;

            if (_asleep)
            {
                /* TODO
				_asleep = false;
				byte txw[8] = { '!', '!', '!', '!', '!', '!', '!', '!' };  //TODO adapt for UART
				sendPacket(txw);
				delayMicroseconds(200);
				*/
            }

            return (sendPacket(tx, out rx));
            /*
            if (sendReadyTime != 0)
            {
                UInt32 currentTime = millis();
                if (currentTime < sendReadyTime)
                {
                    delay(sendReadyTime - currentTime);

                }
                sendReadyTime = 0;
                initialize();
            }

            if (IsSerial)
            {
                Serial.write(tx, 8);  //TODO add addressing, CRC		
                return (8);
            }
            /*
			if (i2cInterface != NULL)
			{
				int count = 8;
				//	while (tx[count - 1] == 0x55)
				//{
				//	--count;
				//}
				i2cInterface->beginTransmission(address);
				i2cInterface->write(tx, 8);
				i2cInterface->endTransmission();
			}
			
            return (0);
            */
        }

        public byte[] readVersion()
        {
            byte[] tx = { (byte)'V', 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55 };
            byte[] rx;
            sendPacket(tx, out rx);
            version = rx.Skip(1).ToArray();

            model = rx.Skip(1).Take(3).ToArray();
            fwVersion = rx.Skip(5).Take(3).ToArray();
            inBoot = rx[1] == 'B';
            return (version);
        }

        public UInt16 readSupplyVoltage_mV()
        {
            if (isSW18())
            {
                _supplyVoltagemV = readPublicData(SerialWombatDataSources.SW_DATA_SOURCE_VCC_mVOLTS);
            }
            else
            {
                UInt16 counts = readPublicData(66); // Get FVR counts (1.024 v)
                UInt32 mv = (UInt32)(1024 * 65536 / counts);
                _supplyVoltagemV = (UInt16)mv;
            }
            return (_supplyVoltagemV);
        }

        public Int16 readTemperature_100thsDegC()
        {
            if (isSW18())
            {
                Int32 result = readPublicData(70);
                if (result >= 32768)
                {
                    result = result - 65536;
                }
                return ((Int16)result);
            }
            else
            {
                return 2500;
            }
        }

        public void hardwareReset(bool waitForResponse = true)
        {
            if (waitForResponse)
            {
                sendPacket("ReSeT!#*");
            }
        }

        public void pinMode(byte pin, byte mode)
        {
            pinMode(pin, mode, false, false);
        }

        public void pinMode(byte pin, byte mode, bool pullDown, bool openDrain)
        {
            if (pin >= WOMBAT_MAXIMUM_PINS)
            {
                return;
            }
            _pullDown[pin] = openDrain;
            _openDrain[pin] = openDrain;
            _pinmode[pin] = mode;
            configureDigitalPin(pin,(byte)(_highLow[pin]?1:0));
        }

        public void digitalWrite(byte pin, byte val)
        {
            _highLow[pin] = val > 0;
            configureDigitalPin(pin,val);
        }


        public int digitalRead(byte pin)
        {
            if (readPublicData(pin) > 0)
            {
                return (1);
            }
            else
            {
                return (0);
            }
        }

        public int analogRead(byte pin)
        {
            byte[] tx = { 200, pin, (byte)SerialWombatPinModes.PIN_MODE_ANALOGINPUT, 0, 0, 0, 0, 0 };
            byte[] rx;
            sendPacket(tx, out rx);
            return (readPublicData(pin) >> 6); // Scale from 16 bit value to 10 bit value.
        }

        public void analogWrite(byte pin, int val)
        {
            byte dutyCycleLow = 0;
            if (val == 255)
            {
                dutyCycleLow = 255;
            }
            byte[] tx = { (byte)SerialWombatCommands.CONFIGURE_PIN_MODE0, pin, (byte)SerialWombatPinModes.PIN_MODE_PWM, pin, dutyCycleLow, (byte)val, 0, 0x55 };
            byte[] rx;
            sendPacket(tx, out rx);
        }

        public bool queryVersion()
        {
            byte[] rx;
            int receivedBytes = sendPacket("V", out rx);
            if (rx[0] == 'V' && (rx[1] == 'S' || rx[1] == 'B'))
            {
                model[0] = rx[1];
                model[1] = rx[2];
                model[2] = rx[3];

                fwVersion[0] = rx[5];
                fwVersion[1] = rx[6];
                fwVersion[2] = rx[7];

                inBoot = (rx[1] == 'B');
                return (true);
            }
            return (false);
        }

        public UInt32 readFramesExecuted()
        {
            byte[] tx = { 0x81, 67, 68, 0x55, 0x55, 0x55, 0x55, 0x55 };
            byte[] rx;
            sendPacket(tx, out rx);
            UInt32 returnval = rx[2] + (((UInt32)rx[3]) << 8) + (((UInt32)rx[4]) << 16) + (((UInt32)rx[5]) << 24);
            return (returnval);
        }

        public UInt16 readOverflowFrames()
        {
            return readPublicData(69);
        }

        public void jumpToBoot()
        {
            sendPacket("BoOtLoAd");
        }

        public byte readRamAddress(UInt16 address)
        {
            byte[] tx = { 0xA0, (byte)(address & 0xFF), (byte)(address >> 8), 0x55, 0x55, 0x55, 0x55, 0x55 };
            byte[] rx;
            sendPacket(tx, out rx);
            return (rx[3]);
        }

        public void writeRamAddress(UInt16 address, byte value)
        {
            byte[] tx = { 0xA3, (byte)(address & 0xFF), (byte)(address >> 8), 0, 0, value, 0x55, 0x55 };
            sendPacket(tx);
        }

        public UInt32 readFlashAddress(UInt32 address)
        {
            byte[] tx = { 0xA1, (byte)(address & 0xFF), (byte)(address >> 8), (byte)((address >> 16) & 0xFF), (byte)((address >> 24) & 0xFF), 0x55, 0x55, 0x55 };
            byte[] rx;
            sendPacket(tx, out rx);
            return (UInt32)(rx[4] + (rx[5] << 8) + (rx[6] << 16) + (rx[7] << 24));
        }

        public void sleep()
        {
            sendPacket("SlEeP!E*");
            _asleep = true;
        }

        public void wake()
        {

            sendPacket("!!!!!!!!");
        }

        public bool isSW18()
        {
            return (model[1] == '1' && model[2] == '8');
        }

        public void eraseFlashPage(UInt32 address)
        {
            byte[] tx = { 0xA4, 0, (byte)(address & 0xFF), (byte)(address >> 8), (byte)((address >> 16) & 0xFF), (byte)((address >> 24) & 0xFF) };
            sendPacket(tx);
        }

        public void writeFlashRow(UInt32 address)
        {
            byte[] tx = { 0xA4, 1, (byte)(address & 0xFF), (byte)(address >> 8), (byte)((address >> 16) & 0xFF), (byte)((address >> 24) & 0xFF) };
            sendPacket(tx);
        }

        public void setThroughputPin(byte pin)
        {
            byte[] tx = { 200, pin, 21, 0x55, 0x55, 0x55, 0x55, 0x55 };
            sendPacket(tx);
        }

        public byte find()
        {/*
			for (int i2cAddress = 0x68; i2cAddress <= 0x6F; ++i2cAddress)
			{
				Wire.beginTransmission(i2cAddress);
				int error = Wire.endTransmission();


				if (error == 0)
				{
					byte tx[8] = { 'V', 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55 };
					byte rx[8];
					Wire.beginTransmission(i2cAddress);
					Wire.write(tx, 8);
					Wire.endTransmission();
					Wire.requestFrom((byte)i2cAddress, (byte)8);

					int count = 0;
					while (Wire.available() && count < 8)
					{
						rx[count] = Wire.read();
						++count;
					}
					if (count == 8)
					{
						if (rx[0] = 'V' && rx[1] == 'S')
						{
							return (i2cAddress); // Found one.
						}
					}
				}
			}
			*/
            return (0);  // Didn't find one.
        }
            public int readUserBuffer(UInt16 index, byte[] buffer, UInt16 count)
{
                UInt16 bytesRead = 0;
                while (bytesRead < count)
                {
                    byte[] tx = { (byte)SerialWombatCommands.COMMAND_BINARY_READ_USER_BUFFER, (byte)(index & 0xFF), (byte)(index >>8), 0x55, 0x55, 0x55, 0x55, 0x55 };
                    byte[] rx;
                    Int16 result = sendPacket(tx, out rx);
                    if (result >= 0)
                    {
                        for (int i = 1; i < 8; ++i)
                        {
                            buffer[bytesRead] = rx[i];
                            ++bytesRead;
                        ++index;
                            if (bytesRead >= count)
                            {
                                break;
                            }
                        }
                    }
                    else
                    {
                        return (bytesRead);
                    }
                }
                return (bytesRead);
            }
        /*
            void registerErrorHandler(SerialWombatErrorHandler_t handler)
{
                errorHandler = handler;
            }
        */
            public void configureDigitalPin(byte pin, byte highLow)
            {
                byte[] tx = { 200, pin, 0, 0, 0, 0, 0, 0x55 };
                byte[] rx;
                _highLow[pin] = highLow > 0;
                switch (_pinmode[pin])
                {
                    case 0: // Arduino input
                        {
                            tx[3] = 2; //Input
                        }
                        break;
                    case 1:
                        {
                            if (_highLow[pin])
                            {
                                tx[3] = 1; //Output
                            }
                            else
                            {
                                tx[3] = 0;
                            }

                        }
                        break;
                    case 2:
                        {
                            tx[3] = 2; //Input
                            tx[4] = 1; //Pullup on
                        }
                        break;
                    default:
                        {
                            return;
                        }
                }
                tx[6] = _openDrain[pin] ? (byte)1 : (byte)0;
                tx[5] = _pullDown[pin] ? (byte)1 : (byte)0;
                sendPacket(tx, out rx);
            }


            public UInt16 readPublicData(SerialWombatDataSources ds)
            {
                return (readPublicData((byte)ds));
            }
            public UInt16 readPublicData(byte pin)
            {
                byte[] tx = { 0x81, pin, 255, 255, 0x55, 0x55, 0x55, 0x55 };
                byte[] rx;
                sendPacket(tx, out rx);

                for (int retry = 0; retry < 5; ++retry)  // Added code to help with multithreading
                {
                    if (rx[1] != pin)
                    {
                        while (Serial.read() >= 0) ;
                    }
                    else
                    {
                        break;
                    }
                    sendPacket(tx, out rx);
                }
                return (UInt16)(rx[2] + (UInt16)rx[3] * 256);
            }

            public UInt16 writePublicData(byte pin, UInt16 value)
            {
                byte[] tx = { 0x82, pin, (byte)(value & 0xFF), (byte)(value >> 8), 255, 0x55, 0x55, 0x55 };
                byte[] rx;
                sendPacket(tx, out rx);
                return ((UInt16)(rx[2] + rx[3] * 256));
            }

            public Int16 writeUserBuffer(UInt16 address, byte[] buffer, UInt16 count)
            {
                UInt16 bytesSent = 0;
                if (count == 0)
                {
                    return 0;
                }

                { // Send first packet of up to 4 bytes
                    UInt16 bytesToSend = 4;
                    if (count < 4)
                    {
                        bytesToSend = count;
                        count = 0;
                    }
                    else
                    {
                        count -= 4;
                    }

                    byte[] tx = { 0x84, (byte)(address & 0xFF), (byte)(address >> 8), (byte)bytesToSend, 0x55, 0x55, 0x55, 0x55 };
                    byte[] rx;

                    byte i;
                    for (i = 0; i < bytesToSend; ++i)
                    {
                        tx[4 + i] = buffer[i];
                    }
                    int result = sendPacket(tx, out rx);
                    if (rx[0] == 'E')
                    {
                        return ((Int16)result);
                    }
                    bytesSent = bytesToSend;
                }
                while (count >= 7)  // Continue sending
                {
                    
                count -= 7;
                    byte[] tx = { 0x85, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55 };
                    byte[] rx;
                    byte i;
                    for (i = 0; i < 7; ++i)
                    {
                        tx[1 + i] = buffer[bytesSent + i];
                    }
                    int result = sendPacket(tx, out rx);
                    if (rx[0] == 'E')
                    {
                        return ((Int16)result);
                    }
                    bytesSent += 7;
                }
                while (count > 0)
                {
                    { // Send first packet of up to 4 bytes
                        byte bytesToSend = 4;
                        if (count < 4)
                        {
                            bytesToSend = (byte)count;
                            count = 0;
                        }
                        else
                        {
                            count -= 4;
                        }

                        byte[] tx = { 0x84, (byte)((address + bytesSent) & 0xFF), (byte)((address + bytesSent) >> 8), (byte)bytesToSend, 0x55, 0x55, 0x55, 0x55 };
                        byte[] rx;

                        byte i;
                        for (i = 0; i < bytesToSend; ++i)
                        {
                            tx[4 + i] = buffer[i + bytesSent];
                        }
                        int result = sendPacket(tx, out rx);
                        if (rx[0] == 'E')
                        {
                            return ((Int16)result);
                        }
                        bytesSent += bytesToSend;
                    }
                    
                }
            return ((Int16)bytesSent);



            }

        public Int16 StartCommandCapture()
        {
            byte[] tx = { (byte)SerialWombatCommands.COMMAND_CAPTURE_STARTUP_SEQUENCE, 0,(byte)'C',(byte)'A',
            (byte)'P',(byte)'T',(byte)'U', (byte)'R'};
            return sendPacket(tx);
        }

        public Int16 StopCommandCapture()
        {
            byte[] tx = { (byte)SerialWombatCommands.COMMAND_CAPTURE_STARTUP_SEQUENCE, 1,(byte)'C',(byte)'A',
            (byte)'P',(byte)'T',(byte)'U', (byte)'R'};
            return sendPacket(tx);
        }

        public Int16 StoreCommandCapture()
        {
            byte[] tx = { (byte)SerialWombatCommands.COMMAND_CAPTURE_STARTUP_SEQUENCE, 2,(byte)'C',(byte)'A',
            (byte)'P',(byte)'T',(byte)'U', (byte)'R'};
            return sendPacket(tx);
        }



        public SerialWombatModel ModelEnum
        {
            get
            {
                if (version[0] == 'S' &&
                 version[1] == '1' &&
                  version[2] == '8' &&
                  (version[3] == 'A' || version[3] == 'B'))
                {
                    return SerialWombatModel.SerialWombat18AB;

                }
                else
                {

                    return (SerialWombatModel.SerialWombat18AB);
                }
            }

        }

        public Int16 echo(byte[] tx, out byte[] rx)
        {
            byte[] tx2 = new byte[8];
            tx.CopyTo(tx2, 1);
            tx2[0] = (byte)'!';
            byte[] rx2;
            Int16 result = sendPacket(tx2, out rx2);
            if (result >= 0)
            {
                rx = rx2.Skip(1).ToArray();

            }
            else
            {
                rx = null;
            }
            return (result);

        }

        public byte[] readPinStateMachineBytes(byte pin, UInt16 count)
        {

            byte[] tx = { 0xB5, 0, pin, 0, 0x55, 0x55, 0x55, 0x55 };
            byte[] rx;
            byte[] output = new byte[count];
            UInt16 received = 0;
            while (received < count)
            {
                sendPacket(tx, out rx);
                for (int i = 0; i < 7 && received < count; ++i)
                {

                    output[received] = rx[i + 1];
                    ++received;
                }
                tx[3] += 7;
            }
            return (output);
        }

        public delegate void SendDelegate(SerialWombatPacket sent, SerialWombatPacket received);
        public List<SendDelegate> SendDelegates = new List<SendDelegate>();


        int writeUserBuffer(UInt16 index, string s)
        {
            return writeUserBuffer(index, Encoding.ASCII.GetBytes(s),(UInt16) s.Length);
        }

      

    public Int16 enable2ndCommandInterface(bool enabled)
    {
        byte[] tx = { 0xA6, 0, 0xB2, 0xA5, 0x61, 0x73, 0xF8, 0xA2 };
        if (enabled)
        {
            tx[1] = 1;
        }
        return sendPacket(tx);
    }

        public UInt16 returnErrorCode(byte[] rx)
    {
        int result = rx[1] - (byte)'0';
        result *= 10;
        result += rx[2] - '0';
        result *= 10;
        result += rx[3] - '0';
        result *= 10;
        result += rx[4] - '0';
        result *= 10;
        result += rx[5] - '0';
        return ((UInt16)result);
    }

        public Int16 echo(byte[] data, byte count)
    {
        byte[] tx = Encoding.ASCII.GetBytes( "!UUUUUUU");
        for (int i = 0; i < 7 && i < count; ++i)
        {
            tx[i + 1] = (byte)data[i];
        }
        return sendPacket(tx);
    }

        public Int16 echo(string data)
    {
        int length = data.Length;
        byte[] tx = Encoding.ASCII.GetBytes("!UUUUUUU");
            for (int i = 0; i < 7 && i < length; ++i)
        {
            tx[i + 1] = Encoding.ASCII.GetBytes( data)[i];
        }
        return sendPacket(tx);
    }

        public UInt32 readBirthday()
    {
        if (isSW18())
        {
            UInt32 birthday = (readFlashAddress(0x2A00C) >> 8) & 0xFF;
            birthday *= 100;
            birthday += (readFlashAddress(0x2A00C)) & 0xFF;
            birthday *= 100;
            birthday += readFlashAddress(0x2A00E) & 0xFF;
            birthday *= 100;
            birthday += readFlashAddress(0x2A010) & 0xFF;
            return (birthday);
        }
        return 0;
    }

        public Int16 readBrand(out String data)
        {
            byte length = 0;
            data = "";
            if (isSW18())
            {
                for (int i = 0; i < 32; ++i)
                {
                    UInt32 val = readFlashAddress((UInt32)(0x2A020 + i * 2));
                    if ((val & 0xFF) != 0xFF)
                    {
                        data.Append((char)(val & 0xFF));
                        ++length;
                    }
                    else
                    {

                        return (length);
                    }
                }
                return (length);
            }

            return 0;
        }




        // Stuff to simulate Arduino environment
        DateTime startTime = DateTime.Now;

        public UInt32 millis()
        {
            return ((UInt32)(DateTime.Now - startTime).TotalMilliseconds);
        }

        void delay(UInt32 ms)
        {
            Thread.Sleep((int)ms);
        }

        public int[] inputPins
        {
            get
            {
                if (isSW18())
                {
                    int[] ints = new int[20];
                    for (int i = 0; i < 20; ++i)
                    {
                        ints[i] = i;
                    }
                    return (ints);
                }
                else
                {
                    int[] ints = new int[4];
                    for (int i = 0; i < 4; ++i)
                    {
                        ints[i] = i;
                    }
                    return (ints);
                }
            }
        }
        public int[] outputPins
        {
            get
            {
                if (isSW18())
                {
                    int[] ints = new int[20];
                    for (int i = 0; i < 20; ++i)
                    {
                        ints[i] = i;
                    }
                    return (ints);
                }
                else
                {
                    int[] ints = { 1, 2, 3 };
                    return (ints);
                }
            }
        }
        public int[] enhancedPerformanceInputPins
        {
            get
            {
                if (isSW18())
                {
                    int[] ints = { 0, 1, 2, 3, 4, 7, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 };
                    return (ints);
                }
                else
                {
                    int[] ints = { 0, 1, 2, 3 };
                    return (ints);
                }
            }
        }
        public int[] enhancedPerformanceOutputPins
        {
            get
            {
                if (isSW18())
                {
                    int[] ints = { 0, 1, 2, 3, 4, 7, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 };
                    return (ints);
                }
                else
                {
                    int[] ints = { 1, 2, 3 };
                    return (ints);
                }
            }
        }

        public int[] AnalogPins
        {
            get
            {
                if (isSW18())
                {
                    int[] ints = { 0, 1, 2, 3, 4, 16, 17, 18, 19 };
                    return (ints);
                }
                else
                {
                    int[] ints = { 1, 2, 3 };
                    return (ints);
                }
            }
        }

        public int[] AvailablePins(SerialWombatPinType pinType)
        {
            switch (pinType)
            {
                case SerialWombatPinType.SerialWombatPin:
                case SerialWombatPinType.InputPin:
                default:
                    return (inputPins);

                case SerialWombatPinType.OutputPin:
                    return(outputPins);

                case SerialWombatPinType.EnhancedPerformanceInputPin:
                    return (enhancedPerformanceInputPins);

                         case SerialWombatPinType.EnhancedPerformanceOutputPin:
                    return(enhancedPerformanceOutputPins);

                case SerialWombatPinType.AnalogPin:
                    return (AnalogPins);
            }
        }
    }

    public enum SerialWombatPinType
    {
        SerialWombatPin,
        InputPin,
        OutputPin,
        EnhancedPerformanceInputPin,
        EnhancedPerformanceOutputPin,
        AnalogPin
    }
    public class ArduinoSerial
    {
        public SerialPort Port;
        public Semaphore Pool = new Semaphore(0, 1);
        public void begin(string portName)
        {
            Port = new SerialPort(portName, 115200, Parity.None, 8, StopBits.One);
            Port.DtrEnable = true; // Added for compatibility with Seeeduino Xiao
            Port.Open();
            Port.ReadTimeout = 20;
            Pool.Release(1);
        }

        public void setTimeout(int mS)
        {

        }

        public int write(byte[] tx, int count)
        {
            Port.Write(tx, 0, count);
            return (count);
        }

        public int readBytes(out byte[] rx, int count)
        {
            rx = new byte[] { 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55 };
            int i = 0;
            int retries = 0;
            while (i < 8 && retries < 50)
            {
                try
                {
                    i += Port.Read(rx, i, 1);
                }

                catch
                {
                    Thread.Sleep(20);
                    ++retries;
                }
            }
            return (i);
        }

        public int read()
        {
            try
            {
                return Port.ReadByte();
            }
            catch
            {
                return (-1);
            }
        }
    }

    public class SerialWombatPin
    {
        public SerialWombatChip _sw;
        protected byte _pin = 255;
        protected byte _pinMode = 0;

        public SerialWombatPin(SerialWombatChip serialWombatChip)
        {
            _sw = serialWombatChip;
        }

        public SerialWombatPin(SerialWombatPin pin)
        {
            _sw = pin._sw;
            _pin = pin._pin;
            _pinMode = pin._pinMode;
        }

        public SerialWombatPin(SerialWombatChip serialWombatChip, byte pin)
        {
            _sw = serialWombatChip;
            _pin = pin;
            _pinMode = 0;
        }

        /// \brief Read the 16 Bit public data associated with this pin 
        /// 
        /// Reads and returns the 16 bit value associated with this pin.
        /// \return 16 bit public data for this pin.
        public UInt16 readPublicData()
        {
            return _sw.readPublicData(_pin);
        }

        /// \brief Set pin to INPUT or OUTPUT
        /// 
        /// This method matches the Arduino Digital io pinMode command
        /// It should only be used on pins that have not been configured to a more
        /// sophisticated (e.g. debounce or servo) pin mode.  
        /// 
        /// \param mode Valid values are INPUT or OUTPUT as defined by arduino.  Do 
        /// not use SW_INPUT, SW_HIGH or SW_LOW here, as these have different meanings
        public void pinMode(byte mode)
        {
            _sw.pinMode(_pin, mode);
        }

        /// \brief Set pin to INPUT or OUTPUT, with options for pull Ups and open Drain settings
        /// 
        /// \param mode Valid values are INPUT, OUTPUT or INPUT_PULLUP as defined by arduino.  Do 
        /// not use SW_INPUT, SW_HIGH or SW_LOW here, as these have different meanings
        /// \param pullDown  If True, a weak pull down will be enabled on this pin (No effect on SW4A/SW4B)
        /// \param openDrain If True, output becomes openDrain output rather than push / pull
        public void pinMode(byte mode, bool pullDown, bool openDrain)
        {
            _sw.pinMode(_pin, mode, pullDown, openDrain);
        }

        /// \brief Set output pin High or Low
        /// 
        /// Before calling this function, the pin should be configured as an input or output with pinMode()
        /// \param pin The Serial Wombat pin to set.  Valid values for SW4A: 0-3  SW4B: 1-3
        /// \param val  Valid values are HIGH or LOW
        /// not use SW_INPUT, SW_HIGH or SW_LOW here, as these have different meanings
        public void digitalWrite(byte val)
        {
            _sw.digitalWrite(_pin, val);
        }

        /// \brief Reads the state of the Pin
        /// 
        /// This function is based on the pin's public data, not a raw reading.
        /// 
        /// \return Returns LOW if pin is low or public data is 0.  Returns HIGH if pin is high or public data is > 0
        public int digitalRead()
        {
            return (_sw.digitalRead(_pin));
        }


        /// \brief Write a 16 bit value to this pin
        /// \param value The 16 bit value to write
        public UInt16 writePublicData(UInt16 value)
        { return _sw.writePublicData(_pin, value); }

        public byte pin { get { return _pin; } }
        public byte swPinModeNumber { get { return _pinMode; } }
    }
}

