using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace SerialWombat
{
	public class SerialWombatAbstractScaledOutput : SerialWombatPin
	{
		public bool biDirectional = false; // Set to true if H Bridge or similar
		public SerialWombatAbstractScaledOutput(SerialWombatChip serialWombatChip) : base(serialWombatChip)
		{
		}





		public void begin(byte pin, SerialWombatPinModes mode)
		{
			begin(pin, (byte)mode);
		}

		public void begin(byte pin, byte pinMode)
		{
			_pin = pin;
			_pinMode = pinMode;
		}

		public Int16 writeTimeout(UInt16 timeout_mS, UInt16 timeoutOutputValue)
		{

			byte[] tx = { (byte)SerialWombatCommands.CONFIGURE_PIN_OUTPUTSCALE,
		_pin,
		_pinMode,
		1,
		(byte)(timeout_mS & 0xFF), ((byte)(timeout_mS >>8)),
		(byte)(timeoutOutputValue & 0xFF), ((byte)(timeoutOutputValue >>8)),
		};

			Int16 result = _sw.sendPacket(tx);

			return (result);

		}

		public byte ScalingSourcePin = 255;
		public Int16 writeScalingEnabled(bool enabled, byte sourcePin)
		{
			ScalingSourcePin = sourcePin;
			byte[] tx = { (byte)SerialWombatCommands.CONFIGURE_PIN_OUTPUTSCALE,
		_pin,   _pinMode,
		0, //Enable/disable scaling, set source pin
		(byte)(enabled?1:0),
		sourcePin,
		0x55, 0x55};

			Int16 result = _sw.sendPacket(tx);
			return (result);
		}

		public Int16 writeInputScaling(UInt16 inputMin, UInt16 inputMax)
		{
			byte[] tx = { (byte)SerialWombatCommands.CONFIGURE_PIN_OUTPUTSCALE,
		_pin,
		_pinMode,
		2,  // Set input scaling
		(byte)(inputMin & 0xFF), ((byte)(inputMin >>8)),
		(byte)(inputMax & 0xFF), ((byte)(inputMax >>8)),
		};
			return (_sw.sendPacket(tx));
		}

		public Int16 writeOutputScaling(UInt16 outputMin, UInt16 outputMax)
		{
			byte[] tx = { (byte)SerialWombatCommands.CONFIGURE_PIN_OUTPUTSCALE,
		_pin,
		_pinMode,
		5,  //Set output scaling
		(byte)(outputMin & 0xFF), ((byte)(outputMin >>8)),
		(byte)(outputMax & 0xFF), ((byte)(outputMax >>8)),
		};
			return (_sw.sendPacket(tx));
		}

		public Int16 writeScalingInvertedInput(bool inverted)
		{
			byte[] tx = { (byte)SerialWombatCommands.CONFIGURE_PIN_OUTPUTSCALE,
		_pin,
		_pinMode,
		3,  // Set inverted/not inverted
		(byte)(inverted?1:0),
		0x55,0x55,0x55,
	};
			return (_sw.sendPacket(tx));
		}

		public Int16 writeScalingTargetValue(UInt16 target)
		{
			byte[] tx = { (byte)SerialWombatCommands.CONFIGURE_PIN_OUTPUTSCALE,
		_pin,
		_pinMode,
		6,  // Set target value for PID controller
		(byte)(target & 0xFF), ((byte)(target >>8)),0x55,0x55,
	};
			return (_sw.sendPacket(tx));
		}

		public Int16 writeRateControl(ScaledOutputPeriod sampleRate, UInt16 filterConstantIncreasing, UInt16 filterConstantDecreasing)
		{
			{
				byte[] tx = { (byte)SerialWombatCommands.CONFIGURE_PIN_OUTPUTSCALE,
			_pin,
			_pinMode,
			4, // Set filter mode
			1, // Filter mode rate control
			(byte)(filterConstantIncreasing & 0xFF), ((byte)(filterConstantIncreasing >>8)),0x55,
		};
				Int16 result = _sw.sendPacket(tx);
				if (result < 0)
				{
					return (result);
				}
				byte[] tx2 = { (byte)SerialWombatCommands.CONFIGURE_PIN_OUTPUTSCALE,
			_pin,
			_pinMode,
			8, // Set filter mode
			(byte)(filterConstantDecreasing & 0xFF), ((byte)(filterConstantDecreasing >>8)),0x55,0x55
		};
				result = _sw.sendPacket(tx2);
				if (result < 0)
				{
					return (result);
				}
			}

			{
				byte[] tx = { (byte)SerialWombatCommands.CONFIGURE_PIN_OUTPUTSCALE,
		_pin,
		_pinMode,
		7, // Set Sample Rate
		(byte)sampleRate,
		0x55,0x55,0x55,
	};
				return (_sw.sendPacket(tx));
			}
		}

		public Int16 write1stOrderFiltering(ScaledOutputPeriod sampleRate, UInt16 filterConstant)
		{
			{
				byte[] tx = { (byte)SerialWombatCommands.CONFIGURE_PIN_OUTPUTSCALE,
			_pin,
			_pinMode,
			4, // Set filter mode
			2, // Filter mode 1st Order
			(byte)(filterConstant & 0xFF), ((byte)(filterConstant >>8)),0x55,
		};
				Int16 result = _sw.sendPacket(tx);
				if (result < 0)
				{
					return (result);
				}
			}
			{
				byte[] tx = { (byte)SerialWombatCommands.CONFIGURE_PIN_OUTPUTSCALE,
		_pin,
		_pinMode,
		7, // Set Sample Rate
		(byte)sampleRate,
		0x55,0x55,0x55,
		};
				return (_sw.sendPacket(tx));
			}
		}

		public Int16 writeHysteresis(UInt16 lowLimit, UInt16 lowOutputValue, UInt16 highLimit, UInt16 highOutputValue, UInt16 initialOutputValue)
		{
			{
				byte[] tx = { (byte)SerialWombatCommands.CONFIGURE_PIN_OUTPUTSCALE,
			_pin,
			_pinMode,
			50, // Set hysteresis high limit/output
			(byte)(highLimit & 0xFF), ((byte)(highLimit >>8)),
			(byte)(highOutputValue & 0xFF), ((byte)(highOutputValue >>8))
		};
				Int16 result = _sw.sendPacket(tx); if (result < 0) { return (result); }
			}

			{
				byte[] tx = { (byte)SerialWombatCommands.CONFIGURE_PIN_OUTPUTSCALE,
			_pin,
			_pinMode,
			51, // Set hysteresis low limit/output
			(byte)(lowLimit & 0xFF), ((byte)(lowLimit >>8)),
			(byte)(lowOutputValue & 0xFF), ((byte)(lowOutputValue >>8))
		};
				Int16 result = _sw.sendPacket(tx); if (result < 0) { return (result); }
			}
			{
				byte[] tx = { (byte)SerialWombatCommands.CONFIGURE_PIN_OUTPUTSCALE,
			_pin,
			_pinMode,
			52, // Set hysteresis low limit/output
			(byte)(initialOutputValue & 0xFF), ((byte)(initialOutputValue >>8)),
			0x55,0x55
		};
				Int16 result = _sw.sendPacket(tx); if (result < 0) { return (result); }
			}
			return (0);
		}

		public Int16 writePID(UInt16 kp, UInt16 ki, UInt16 kd, UInt16 target, ScaledOutputPeriod sampleRate, byte targetPin = 255)
		{
			{
				byte[] tx = { (byte)SerialWombatCommands.CONFIGURE_PIN_OUTPUTSCALE,
			_pin,
			_pinMode,
			100, // Set kp and ki
			(byte)(kp & 0xFF), ((byte)(kp >>8)),
			(byte)(ki & 0xFF), ((byte)(ki >>8))
		};
				Int16 result = _sw.sendPacket(tx); if (result < 0) { return (result); }
			}
			{
				byte[] tx = { (byte)SerialWombatCommands.CONFIGURE_PIN_OUTPUTSCALE,
			_pin,
			_pinMode,
			101, // Set kd
			(byte)(kd & 0xFF), ((byte)(kd >>8)),
			0x55,0x55
		};
				Int16 result = _sw.sendPacket(tx); if (result < 0) { return (result); }
			}
			writeScalingTargetValue(target);
			{
				byte[] tx = { (byte)SerialWombatCommands.CONFIGURE_PIN_OUTPUTSCALE,
		_pin,
		_pinMode,
		7, // Set Sample Rate
		(byte)sampleRate,
		0x55,0x55,0x55,
		};
				Int16 result = _sw.sendPacket(tx); if (result < 0) { return (result); }
			}
			{
				byte[] tx = { (byte)SerialWombatCommands.CONFIGURE_PIN_OUTPUTSCALE,
			_pin,
			_pinMode,
			102, // Reset Integrator
			0x55,0x55,0x55,0x55
		};
				Int16 result = _sw.sendPacket(tx); if (result < 0) { return (result); }
			}
            {
                byte[] tx = { (byte)SerialWombatCommands.CONFIGURE_PIN_OUTPUTSCALE,
            _pin,
            _pinMode,
            109, // Enable Pid
			targetPin,(byte)(biDirectional?1:0),0x55,0x55
        };
                Int16 result = _sw.sendPacket(tx); if (result < 0) { return (result); }
            }
            return 0;

		}


		public Int16 PIDResetIntegrator()
		{
			byte[] tx = { (byte)SerialWombatCommands.CONFIGURE_PIN_OUTPUTSCALE,
			_pin,
			_pinMode,
			102, // Reset Integrator
			0x55,0x55,0x55,0x55
		};
			return _sw.sendPacket(tx);
		}

        public Int16 writeScalingTargetValueResetIntegrator(UInt16 target)
        {
            byte[] tx = { (byte)SerialWombatCommands.CONFIGURE_PIN_OUTPUTSCALE,
            _pin,
            _pinMode,
            110, // Write target Value and Reset Integrator
			(byte)(target&0xFF),(byte)(target>>8),0x55,0x55
        };
            return _sw.sendPacket(tx);
        }
        public Int32 PIDGetLastError()
		{
			byte[] tx = { (byte)SerialWombatCommands.CONFIGURE_PIN_OUTPUTSCALE,
			_pin,
			_pinMode,
			103, // Get Last Error
			0x55,0x55,0x55,0x55
			};
			byte[] rx;

			_sw.sendPacket(tx, out rx);

			return BitConverter.ToInt32(rx, 4);

		}


		public Int32 PIDGetLastIntegrator()
		{
			byte[] tx = { (byte)SerialWombatCommands.CONFIGURE_PIN_OUTPUTSCALE,
			_pin,
			_pinMode,
			104, // Get Last Integrator
			0x55,0x55,0x55,0x55
			};
			byte[] rx;

			_sw.sendPacket(tx, out rx);

			return BitConverter.ToInt32(rx, 4);
		}

		public Int32 PIDGetLastIntegratorEffort()
		{
			byte[] tx = { (byte)SerialWombatCommands.CONFIGURE_PIN_OUTPUTSCALE,
			_pin,
			_pinMode,
			105, // Get Last Integrator Effort
			0x55,0x55,0x55,0x55
			};
			byte[] rx;

			_sw.sendPacket(tx, out rx);

			return BitConverter.ToInt32(rx, 4);
		}

		public Int32 PIDGetLastProportionalEffort()
		{
			byte[] tx = { (byte)SerialWombatCommands.CONFIGURE_PIN_OUTPUTSCALE,
			_pin,
			_pinMode,
			106, // Get Last Proportional Effort
			0x55,0x55,0x55,0x55
			};
			byte[] rx;

			_sw.sendPacket(tx, out rx);

			return BitConverter.ToInt32(rx, 4);
		}

		public Int32 PIDGetLastDerivativeEffort()
		{
			byte[] tx = { (byte)SerialWombatCommands.CONFIGURE_PIN_OUTPUTSCALE,
			_pin,
			_pinMode,
			107, // Get Last Derivative Effort
			0x55,0x55,0x55,0x55
			};
			byte[] rx;

			_sw.sendPacket(tx, out rx);

			return BitConverter.ToInt32(rx, 4);
		}

		public Int32 PIDGetLastEffort()
		{
			byte[] tx = { (byte)SerialWombatCommands.CONFIGURE_PIN_OUTPUTSCALE,
			_pin,
			_pinMode,
			108, // Get Last Total Effort
			0x55,0x55,0x55,0x55
			};
			byte[] rx;

			_sw.sendPacket(tx, out rx);

			return BitConverter.ToInt32(rx, 4);
		}

		public UInt16 ReadLastTarget()
		{
            byte[] tx = { (byte)SerialWombatCommands.CONFIGURE_PIN_OUTPUTSCALE,
            _pin,
            _pinMode,
            111, // Get Last Target
			0x55,0x55,0x55,0x55
            };
            byte[] rx;

            _sw.sendPacket(tx, out rx);

            return BitConverter.ToUInt16(rx, 4);
        }

		public Int16 Enable2DLookupOutputScaling(UInt16 IndexInUserMemory)
		{
			byte[] tx = { (byte)SerialWombatCommands.CONFIGURE_PIN_OUTPUTSCALE,
			_pin,
			_pinMode,
			10, // Set 2D Lookup Index 
			(byte)(IndexInUserMemory & 0xFF), (byte)(IndexInUserMemory >>8),0x55,0x55};
			return _sw.sendPacket(tx);
		}
	}



	public enum ScaledOutputPeriod
	{
		PERIOD_1mS = 0,
		PERIOD_2mS = 1,
		PERIOD_4mS = 2,
		PERIOD_8mS = 3,
		PERIOD_16mS = 4,
		PERIOD_32mS = 5,
		PERIOD_64mS = 6,
		PERIOD_128mS = 7,
		PERIOD_256mS = 8,
		PERIOD_512mS = 9,
		PERIOD_1024mS = 10,
	};
}
