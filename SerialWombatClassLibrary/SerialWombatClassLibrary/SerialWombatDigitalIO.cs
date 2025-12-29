using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SerialWombat
{
    public class SerialWombatDigitalIO:SerialWombatPin
    {
        

       
        public SerialWombatDigitalIO(SerialWombatChip serialWombatChip) : base(serialWombatChip)
        {
            _sw = serialWombatChip;
            _pinMode = (byte)SerialWombatPinModes.PIN_MODE_DIGITALIO;
        }

        public Int16 begin(byte pin, SerialWombatPinStates pinState, bool pullUp = false, bool pullDown=false, bool openDrain= false)
        {
            _pin = pin;
            byte[] tx = { 200, _pin, (byte)_pinMode, (byte)pinState,pullUp?(byte)1:(byte)0, pullDown ? (byte)1 : (byte)0, openDrain ? (byte)1 : (byte)0,0x55 };
            return _sw.sendPacket(tx);
        }
    }

    public class SerialWombatDigitalIO_18AB : SerialWombatDigitalIO
    {
        public SerialWombatAbstractScaledOutput scaledOutput;
        public SerialWombatAbstractProcessedInput processedInput;
        public SerialWombatDigitalIO_18AB(SerialWombatChip serialWombatChip) : base(serialWombatChip)
        {
            scaledOutput = new SerialWombatAbstractScaledOutput(serialWombatChip);
            processedInput = new SerialWombatAbstractProcessedInput(serialWombatChip);
        }

        new public Int16 begin(byte pin, SerialWombatPinStates pinState, bool pullUp = false, bool pullDown = false, bool openDrain = false)
        {
            Int16 result = base.begin(pin, pinState, pullUp,pullDown,openDrain);
            if (result < 0) return result;
            if (pinState == SerialWombatPinStates.SW_INPUT)
           
            scaledOutput.begin(_pin, _pinMode);
            processedInput.begin(_pin, _pinMode);

            return 0;
        }


    }
}

