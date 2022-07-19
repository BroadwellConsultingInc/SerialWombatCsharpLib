using System;
using System.Threading;
using System.Collections.Generic;
/*
Copyright 2022 Broadwell Consulting Inc.

"Serial Wombat" is a registered trademark of Broadwell Consulting Inc. in
the United States.  See SerialWombat.com for usage guidance.

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

namespace SerialWombat
{
	public class SerialWombatUART : SerialWombatPin
	{

		protected byte _rxPin = 255;
		protected byte _txPin = 255;
		protected byte _baudMarker = 0;
		UInt32 timeout = 5000;

		byte _tx7Command = (byte)SerialWombatCommands.COMMAND_UART0_TX_7BYTES;
		byte _rx7Command = (byte)SerialWombatCommands.COMMAND_UART0_RX_7BYTES;

		public SerialWombatUART(SerialWombatChip serialWombatChip) : base(serialWombatChip)
		{
			_sw = serialWombatChip;
			_pinMode = (byte)SerialWombatPinModes.PIN_MODE_UART_RX_TX;
		}
		public Int16 begin(UInt32 baudRate, byte pin, byte rxPin, byte txPin, byte HWinterface = 1)
		{
			_rxPin = rxPin;
			_txPin = txPin;
			_pin = pin;
			if (HWinterface == 2)
			{
				_pinMode = (byte)SerialWombatPinModes.PIN_MODE_UART1_RX_TX;
				_tx7Command = (byte)SerialWombatCommands.COMMAND_UART1_TX_7BYTES;
				_rx7Command = (byte)SerialWombatCommands.COMMAND_UART1_RX_7BYTES;

			}
			else if (HWinterface == 1)
			{
				_pinMode = (byte)SerialWombatPinModes.PIN_MODE_UART_RX_TX;
				_tx7Command = (byte)SerialWombatCommands.COMMAND_UART0_TX_7BYTES;
				_rx7Command = (byte)SerialWombatCommands.COMMAND_UART0_RX_7BYTES;
			}
			else
			{
				return (-1);
			}
			switch (baudRate)
			{
				case 300:
					_baudMarker = 0;
					break;
				case 1200:
					_baudMarker = 1;
					break;

				case 2400:
					_baudMarker = 2;
					break;

				case 4800:
					_baudMarker = 3;
					break;
				case 9600:
					_baudMarker = 4;
					break;
				case 19200:
					_baudMarker = 5;
					break;

				case 38400:
					_baudMarker = 6;
					break;

				case 57600:
					_baudMarker = 7;
					break;

				default:
				case 115200:
					_baudMarker = 8;
					break;
			}
			byte[] tx = { 200, _pin, _pinMode, _baudMarker, _rxPin, _txPin, 0x55, 0x55 };
			byte[] rx;
			return _sw.sendPacket(tx, out rx);

		}

		public int available()
		{
			byte[] tx = { 201, _pin, _pinMode, 0, 0x55, 0x55, 0x55, 0x55 };
			byte[] rx;
			_sw.sendPacket(tx, out rx);
			return (rx[4]);
		}

		public int read()
		{
			byte[] tx = { 202, _pin, _pinMode, 1, 0x55, 0x55, 0x55, 0x55 };
			byte[] rx;
			if (_sw.sendPacket(tx, out rx) < 0)
			{
				return -1;
			}

			if (rx[3] != 0)
			{
				return (rx[4]);
			}
			else
			{
				return (-1);
			}
		}

		public void flush()
		{
			byte[] tx = { 200, _pin, _pinMode, _baudMarker, _rxPin, _txPin, 0x55 };
			byte[] rx;
			_sw.sendPacket(tx, out rx);
		}

		public int peek()
		{
			byte[] tx = { 203, _pin, _pinMode, 0x55, 0x55, 0x55, 0x55, 0x55 };
			byte[] rx;
			_sw.sendPacket(tx, out rx);
			if (rx[4] > 0)
			{
				return (rx[5]);
			}
			else
			{
				return (-1);
			}
		}

		public int write(byte data)
		{
			byte[] tx = { 201, _pin, _pinMode, 1, data, 0x55, 0x55, 0x55 };
			_sw.sendPacket(tx);
			return (1);
		}

		public int write(byte[] buffer, int size)
		{
			int bytesAvailable = 0;
			int bytesSent;
			DateTime timeoutMillis = DateTime.Now + new TimeSpan(0, 0, 0, 0, (int)timeout);

			for (bytesSent = 0; bytesSent < size;)
			{

				while (bytesAvailable < 4)
				{
					byte[] peektx = { 203, _pin, _pinMode, 0x55, 0x55, 0x55, 0x55, 0x55 };
					byte[] peekrx;
					_sw.sendPacket(peektx, out peekrx);
					bytesAvailable = peekrx[3];
					if (timeoutMillis < DateTime.Now && bytesAvailable == 0)
					{
						//			       Serial.printf("UART TX TIMEOUT!\r\n");
						return (bytesSent);
					}
				}
				timeoutMillis = DateTime.Now + new TimeSpan(0, 0, 0, 0, (int)timeout);

				while (bytesSent < size && bytesAvailable > 0)
				{

					if ((size - bytesSent) < 7 || bytesAvailable < 7)
					{
						byte[] tx = { 201, _pin, _pinMode, 0, 0x55, 0x55, 0x55, 0x55 };
						byte[] rx;
						int txLen;
						tx[3] = 0;
						for (txLen = 0; txLen < 4 && txLen < bytesAvailable && bytesSent < size; ++txLen)
						{
							tx[4 + txLen] = buffer[bytesSent];
							++bytesSent;
							++tx[3];
						}
						_sw.sendPacket(tx, out rx);
						bytesAvailable = rx[3];
					}
					else
					{
						byte[] tx = { _tx7Command, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55 };
						int txLen;

						for (txLen = 0; txLen < 7; ++txLen)
						{
							tx[1 + txLen] = buffer[bytesSent];
							++bytesSent;
							--bytesAvailable;
						}
						_sw.sendPacket(tx);
					}
					Thread.Sleep(1);
				}
			}
			return (bytesSent);
		}

		public int availableForWrite()
		{
			byte[] peektx = { 203, _pin, _pinMode, 0x55, 0x55, 0x55, 0x55, 0x55 };
			byte[] peekrx;
			_sw.sendPacket(peektx, out peekrx);
			return peekrx[3];
		}

		public void setTimeout(long timeout_mS)
		{
			if (timeout_mS == 0)
			{
				timeout = 0x80000000;
			}
			else
			{
				timeout = (UInt32)timeout_mS;
			}
		}

		public int readBytes(byte[] buffer, int length)
		{
			int index = 0;
			int bytesAvailable = 0;
			DateTime timeoutMillis = DateTime.Now + new TimeSpan(0, 0, 0, 0, (int)timeout);
			while (length > 0 && timeoutMillis > DateTime.Now)
			{
				int bytecount = 4;
				if (length < 4)
				{
					bytecount = length;
				}
				{

					byte[] tx = { 202, _pin, _pinMode, (byte)bytecount, 0x55, 0x55, 0x55, 0x55 };
					byte[] rx;
					_sw.sendPacket(tx, out rx);
					bytesAvailable = rx[3];

					if (bytesAvailable == 0)
					{
						continue;
					}
					else
					{
						timeoutMillis = DateTime.Now + new TimeSpan(0, 0, 0, 0, (int)timeout);
					}
					byte bytesReturned = (byte)bytecount;
					if (rx[3] < bytecount)
					{
						bytesReturned = rx[3];
					}
					for (int i = 0; i < bytesReturned; ++i)
					{
						buffer[index] = rx[i + 4];
						++index;
						--bytesAvailable;
						--length;

					}
				}
				while (bytesAvailable >= 7 && length >= 7)
				{
					byte[] tx = { _rx7Command, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55 };
					byte[] rx;
					_sw.sendPacket(tx, out rx);
					for (int i = 0; i < 7; ++i)
					{
						buffer[index] = rx[i + 1];
						++index;
						--bytesAvailable;
						--length;

					}
				}

			}

			return (index);
		}
	}
	public class SerialWombatSWUART : SerialWombatUART
	{
		SerialWombatQueue rxQueue;
		SerialWombatQueue txQueue;
		public SerialWombatSWUART(SerialWombatChip serialWombatChip) : base(serialWombatChip)
		{
			_sw = serialWombatChip;
			_pinMode = (byte)SerialWombatPinModes.PIN_MODE_SW_UART;
		}
		public Int16 begin(UInt32 baudRate, byte pin, byte rxPin, byte txPin, UInt16 userMemoryOffset, UInt16 rxLength, UInt16 txLength)
		{
			_rxPin = rxPin;
			_txPin = txPin;
			_pin = pin;

			_pinMode = (byte)SerialWombatPinModes.PIN_MODE_SW_UART;

			switch (baudRate)
			{
				case 300:
					_baudMarker = 0;
					break;
				case 1200:
					_baudMarker = 1;
					break;

				case 2400:
					_baudMarker = 2;
					break;

				case 4800:
					_baudMarker = 3;
					break;
				case 9600:
					_baudMarker = 4;
					break;
				case 19200:
					_baudMarker = 5;
					break;

				case 38400:
					_baudMarker = 6;
					break;

				case 57600:
					_baudMarker = 7;
					break;

				default:
				case 115200:
					_baudMarker = 7;  // Limit to 57600
					break;
			}
			byte[] tx = { 200, _pin, _pinMode, _baudMarker, _rxPin, _txPin, 0x55, 0x55 };
			byte[] rx;

			Int16 result = _sw.sendPacket(tx, out rx);
			if (result < 0)
			{
				return (result);
			}
			Int16 rxoffset = 0;
			//if (_rxPin != 255)
			{
				if (rxLength == 0)
				{
					rxLength = 2;
				}
				rxQueue = new SerialWombatQueue(_sw);
				rxoffset = rxQueue.begin(userMemoryOffset, rxLength);
				if (rxoffset >= 0)
				{
					userMemoryOffset += (UInt16)rxoffset;
				}
				else
				{
					return (0);  // No memory should have been allocated.
				}
			}

			Int16 txoffset = 0;
			//if (_txPin != 255)
			{
				if (txLength == 0)
				{
					txLength = 2;
				}
				txoffset = txQueue.begin(userMemoryOffset, txLength);
				if (txoffset >= 0)
				{
					userMemoryOffset += (UInt16)txoffset;
				}
				else
				{
					return rxoffset;
				}
			}

			byte[] tx5 = { 205, _pin, _pinMode, (byte)(txQueue.startIndex & 0xFF), (byte)(txQueue.startIndex >> 8) };
			result = _sw.sendPacket(tx5);
			if (result < 0) return (result);


			byte[] tx6 = { 206, _pin, _pinMode, (byte)(rxQueue.startIndex & 0xFF), (byte)(rxQueue.startIndex >> 8) };
			result = _sw.sendPacket(tx6);
			if (result < 0) return (result);

			return ((Int16)(txoffset + rxoffset));
		}

		public new int write(byte[] buffer, int size)
		{
			return (txQueue.write(size, buffer));
		}

		[Obsolete("Cannot call this constructor in inherited SerialWombatSWUART class.", true)]
		public new Int16 begin(UInt32 baudRate, byte pin, byte rxPin, byte txPin, byte HWinterface = 1)
		{
			return (-1);
		}
	}
}
