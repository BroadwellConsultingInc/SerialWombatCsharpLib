using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SerialWombat
{
    public class SerialWombatHBridge:SerialWombatPin
    {
        public SerialWombatHBridgeDriverMode driverMode = SerialWombatHBridgeDriverMode.HBRIDGE_OFF_BOTH_LOW;
        

       
        public SerialWombatHBridge(SerialWombatChip serialWombatChip) : base(serialWombatChip)
        {
            _sw = serialWombatChip;
            _pinMode = (byte)SerialWombatPinModes.PIN_MODE_HBRIDGE;
        }

        public Int16 begin(byte pin, byte secondPin, SerialWombatHBridgeDriverMode mode)
        {
            _pin = pin;
            byte[] tx = { 200, _pin, (byte)_pinMode,  secondPin,(byte)mode,0x55,0x55,0x55};
            return _sw.sendPacket(tx);
        }
    }

    public class SerialWombatHBridge_18AB : SerialWombatHBridge
    {
        public SerialWombatAbstractScaledOutput scaledOutput;
        public SerialWombatHBridge_18AB(SerialWombatChip serialWombatChip) : base(serialWombatChip)
        {
            scaledOutput = new SerialWombatAbstractScaledOutput(serialWombatChip);
        }

        public new Int16 begin(byte pin, byte secondPin, SerialWombatHBridgeDriverMode mode = SerialWombatHBridgeDriverMode.HBRIDGE_OFF_BOTH_LOW)
        {
            Int16 result = base.begin(pin, secondPin, mode);
            if (result < 0) return result;
            scaledOutput.begin(_pin, _pinMode);
            return 0;
        }

        public void setPeriod_SW18AB_uS(UInt32 period_uS)
        {
            byte[] tx = { 220, _pin, _pinMode, (byte)(period_uS & 0xFF), (byte)((period_uS >> 8) & 0xFF), (byte)((period_uS >> 16) & 0xFF), (byte)((period_uS >> 24) & 0xFF), 0x55 };
            _sw.sendPacket(tx);
        }

    }
    public enum SerialWombatHBridgeDriverMode :byte
    {
        HBRIDGE_OFF_BOTH_LOW = 0,
        HBRIDGE_OFF_BOTH_HIGH = 1,
        HBRIDGE_RELAY_AND_PWM = 2,


    }
    public enum SerialWombatHBridgeOffState
    {
        BothPinsLow = 0,
        MainPinHigh = 1,
        SecondPinHigh = 2,
        BothPinsHigh = 3,
    }
}

