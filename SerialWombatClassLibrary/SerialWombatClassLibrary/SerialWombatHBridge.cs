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
        public enum driver
        {
            RelayAndPWM = 0,
            LG9110_HG7881 = 1,
            DRV8833 = 2,
            DRV8871 = 3,
            L298N = 4,
            MX1508 = 5,
            BTS7960 = 6,
            IBT4 = 7,
            A4990 = 8,
            TB67H420FTG = 9,

        }
        public SerialWombatHBridge(SerialWombatChip serialWombatChip) : base(serialWombatChip)
        {
            _sw = serialWombatChip;
            _pinMode = (byte)SerialWombatPinModes.PIN_MODE_HBRIDGE;
        }

        public Int16 begin(byte pin, byte secondPin)
        {
            _pin = pin;
            byte[] tx = { 200, _pin, (byte)_pinMode,  secondPin,0x55,0x55,0x55,0x55};
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

        public new Int16 begin(byte pin, byte secondPin)
        {
            Int16 result = base.begin(pin, secondPin);
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
}

