using System;
using System.Collections.Generic;

namespace SerialWombat
{
    /// \brief A Class for the Serial Wombat 18AB VGA driver
    ///
    /// This class is only supported on the Serial Wombat SW18AB chip.  It is not supported on the
    /// Serial Wombat 4X line.
    public class SerialWombat18ABVGA :  SerialWombatPin
    {

        /// \brief Constructor for SerialWombat18ABVGA class
        /// \param serialWombat SerialWombatChip on which the SerialWombat18ABVGA will run
        public SerialWombat18ABVGA(SerialWombatChip serialWombatChip):base(serialWombatChip)
        {
            _pinMode = (byte)SerialWombatPinModes.PIN_MODE_VGA;
        }


        /// \brief Initialize an instance of the VGA class
        ///
        /// \return Returns a negative error code if initialization failed.
        public Int32 begin(byte Pin, UInt16 bufferIndex)
        {
            _pin = Pin;

            byte[] tx = { 200, _pin, _pinMode, 0x55,0x55,0x55,0x55,0x55};
  

            byte[] rx;
            Int16 result =  _sw.sendPacket(tx,out rx);
           
                return result;
   

        }

	public int writePixel(byte x, byte y, byte color)
	{
		byte[] tx = {201, 
						_pin,
						(byte)_pinMode ,
						0, //Single pixel
						x,
						y,
						color,
						0x55,
						
	};
	return _sw.sendPacketNoResponse(tx);
	}

public int fillScreen(byte color)
{
byte[] tx = {201, 
						_pin,
						(byte)_pinMode ,
						1, //FillScreen
						color,
						0x55,
						0x55,
		0x55

	};
	return _sw.sendPacketNoResponse(tx);
}

public int fillRect(byte x, byte y, byte w, byte h,
        byte color)
{
byte[] tx = {201, 
						_pin,
						(byte)_pinMode ,
						2, //Fill Rect
						x,
						y,
						(byte)(x + w - 1),
		(byte)(y + h - 1)

	};
	if (color == 0)
	{
		tx[3] = 3; // Make clear rect
	}
	return _sw.sendPacketNoResponse(tx);
}

public int setLineColor(byte color, byte start)
{
return setLineColor(color,start,start);
}
public int setLineColor(byte color, byte start, byte end)
{
byte[] tx = {202, 
						_pin,
						(byte)_pinMode ,
				
						start,
						end,
						color,
		0x55,
		0x55

	};
            return _sw.sendPacketNoResponse(tx);
        }
    }



}
