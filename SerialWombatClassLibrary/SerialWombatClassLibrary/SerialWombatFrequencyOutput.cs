using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerialWombat
{
    public class SerialWombatFrequencyOutput : SerialWombatPin
    {
        public SerialWombatAbstractScaledOutput scaledOutput;
        public SerialWombatFrequencyOutput(SerialWombatChip serialWombatChip):base(serialWombatChip)
        {
            _sw = serialWombatChip;
            _pinMode = (byte)SerialWombatPinModes.PIN_MODE_FREQUENCY_OUTPUT;
            scaledOutput = new SerialWombatAbstractScaledOutput(serialWombatChip);
        }

        public Int16 begin(byte pin,UInt16 maxFrequency_Hz, bool lowFreqeuency = false, UInt16 dutyCycle = 0x8000)
        {
            _pin = pin;
            initPacketNoResponse(0, dutyCycle, maxFrequency_Hz, lowFreqeuency?(byte)1:(byte)0);
            scaledOutput.begin(_pin, _pinMode);

            return (0);
        }
    }
}
