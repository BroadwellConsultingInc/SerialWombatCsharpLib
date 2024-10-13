using System;
using System.Collections.Generic;
using System.Text;

namespace SerialWombat
{
    public class SerialWombat18CapTouch : SerialWombatAbstractButton
    {
        /// \brief Number of transitions returned by last call to readTransitionsState()
      
        UInt16 _trueOutput = 1;
        UInt16 _falseOutput = 1;

        public SerialWombatAbstractProcessedInput processedInput;

        public SerialWombat18CapTouch(SerialWombatChip serialWombatChip) : base(serialWombatChip)
        {
         
        }

       

        public Int16 begin(byte pin, UInt16 chargeTime, UInt16 delay = 10)
        {
            _pin = pin;

            byte[] tx = { 200, _pin, 22, (byte)(chargeTime & 0xFF), (byte)((chargeTime >> 8) & 0xFF), (byte)(delay & 0xFF), (byte)((delay >> 8) & 0xFF), 0x55 };

            _sw.sendPacket(tx);

            _pin = pin;
            _pinMode = (byte)SerialWombatPinModes.PIN_MODE_SW18AB_CAPTOUCH;
            processedInput = new SerialWombatAbstractProcessedInput(_sw);
            processedInput.begin(_pin, _pinMode);
            processedInput.writeProcessedInputEnable(true);
            processedInput.writeAveragingNumberOfSamples(8);
            processedInput.configureOutputValue(ProcessedInputOutputValue.AVERAGE);

            return (0);
        }

        public Int16 makeDigital(UInt16 touchLimit, UInt16 noTouchLimit)
        {
            return makeDigital(touchLimit, noTouchLimit, 1, 0, false, 0);
        }

        public Int16 makeDigital(UInt16 touchLimit, UInt16 noTouchLimit, UInt16 touchValue, UInt16 noTouchValue, bool invert, UInt16 debounceCount)
        {
            byte[] tx1 = { 201, _pin, 22, (byte)(touchLimit & 0xFF), (byte)((touchLimit >> 8) & 0xFF), (byte)(noTouchLimit & 0xFF), (byte)((noTouchLimit >> 8) & 0xFF), 0x55 };
            Int16 result = _sw.sendPacket(tx1);
            if (result < 0)
            {
                return (result);
            }

            _trueOutput = touchValue;
            _falseOutput = noTouchValue;
            byte[] tx2 = { 202, _pin, 22, (byte)(touchValue & 0xFF), (byte)((touchValue >> 8) & 0xFF), (byte)(noTouchValue & 0xFF), (byte)((noTouchValue >>8) & 0xFF), 0x55 };
            result = _sw.sendPacket(tx2);
            if (result < 0)
            {
                return (result);
            }
            byte[] tx3 = { 203, _pin, 22, 1, invert ? (byte)1 : (byte)0, (byte)(debounceCount & 0xFF), (byte)((debounceCount >> 8) & 0xFF), 0x55 };
            result = _sw.sendPacket(tx3);
            if (result < 0)
            {
                return (result);
            }
            return (0);


        }

        public Int16 makeAnalog()
        {
            byte[] tx3 = { 203, _pin, 22, 0, 0x55, 0x55, 0x55, 0x55 };
            return _sw.sendPacket(tx3);
        }

        override public bool digitalRead()
        {
            byte[] tx = { 204, _pin, 22, 0, 0x55, 0x55, 0x55, 0x55 };
            byte[] rx;
            if (_sw.sendPacket(tx, out rx) >= 0)
            {
                return (rx[3] > 0);
            }
            return (false);

        }
        override public UInt16 readDurationInTrueState_mS()
        {
            byte[] tx = { 204, _pin, 22, 1, 0x55, 0x55, 0x55, 0x55 };
            byte[] rx;
            _sw.sendPacket(tx, out rx);

            transitions += (UInt16)(256 * rx[5] + rx[4]);
            if (rx[3] == 0)
            {
                return (0);
            }
            else
            {
                return (UInt16)(256 * rx[7] + rx[6]);
            }
        }
        override public UInt16 readDurationInFalseState_mS()
        {
            byte[] tx = { 204, _pin, 22, 1, 0x55, 0x55, 0x55, 0x55 };
            byte[] rx;
            _sw.sendPacket(tx, out rx);

            transitions += (UInt16)(256 * rx[5] + rx[4]);

            if (rx[3] == 1)
            {
                return (0);
            }
            else
            {
                return (UInt16)(256 * rx[7] + rx[6]);
            }
        }

        override public bool readTransitionsState()
        {
            byte[] tx = { 204, _pin, 22, 1, 0x55, 0x55, 0x55, 0x55 };
            byte[] rx;
            _sw.sendPacket(tx, out rx);
            transitions = (UInt16)(256 * rx[5] + rx[4]);
            return (rx[3] > 0);
        }

    }



}
