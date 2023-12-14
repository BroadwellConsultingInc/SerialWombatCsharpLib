using System;
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

    public enum SWWS2812Mode
    {
        ws2812ModeBuffered = 0,  ///< Standard buffered mode.  Colors are uploaded by the host
        ws2812ModeAnimation = 1,    ///< Multiple arrays with delays are uploaded by the host and displayed over time by the Serial Wombat chip
        ws2812ModeChase = 2, ///< A single lit LED cycles through all of the LEDs.
    };


    /// \brief A Class representing a WS2812 or compatible RGB LED string connected to a Serial Wombat pin
    ///
    /// This class is only supported on the Serial Wombat SW18AB chip.  It is not supported on the
    /// Serial Wombat 4X line.  This pin mode can only be used on enhanced capability pins (WP0-4, WP7, or WP9-19)
    /// 
    /// This class controls a State Machine driven driver for a WS2812 compatible RGB LED string.
    /// 
    /// Each instance of this class uses an average of approximately TBD% of the SW18's processing time.
    /// This varies by configuration options and usage.
    /// 
    /// The Serial Wombat WS2812 driver can be configured in a number of ways:
    /// * The driver lights up the LEDs one at a time in sequence
    /// * The driver shows colors as commanded by the host
    /// * The driver cycles through arrays of colors at a specified rate
    /// 
    /// 
    /// See the available examples in the Arduino Library for usage.
    /// 
    /// \warning Different WS2812 pcbs behave differently based on how the manufacturer routed the LEDs on the PCB Board.
    /// For instance a square 4x4 matrix may not light in the order expected.  This is not an issue with the library.
    /// 
    /// \warning An array of WS2812 LEDs can pull lots of current.  Lighting multiple LEDs at full brightness may consume
    /// more power than your supply can provide, causing the system voltage to become unstable.  An unstable system voltage
    /// can cause unreliable operation of the Serial Wombat chip.
    /// 
    /// The Serial Wombat WS2812 driver is extremely efficient in terms of processor time since it uses
    /// the PIC24FJ256GA702's DMA and SPI hardware to generate the WS2812 signal.  This allows the Serial
    /// Wombat firmware to easily clock out WS2812 signals while doing other thigns.  However, this method
    /// is very RAM intensive, requiring about 50 bytes of ram for each LED.  
    /// 
    /// The RAM used for buffering this signal is stored in the User Buffer RAM, an array available for the
    /// user to allocate to various PIN modes' uses.  In Version 2.0.3 of the Serial Wombat 18AB firmware
    /// there is 8k of RAM allocated to User Buffer, allowing about 160 LEDs to be used if all RAM is
    /// allocated to the WS2812.  
    /// 
    /// A number of frames to be shown in rotation with configurable delays inbetween can also be stored
    /// in the User Buffer.  This is in additional to the rendering buffer.  Each animation frame requires
    /// 2+3*NumberOfLEDs bytes.
    /// 
    /// The Update rate is variable with the number of LEDs so that rendering of colors into the User Buffer
    /// is spread across multiple Serial Wombat 1mS execution frames.  The LEDs will be updated approximately every
    /// X mS, where X is the number of LEDs plus 20.
    /// 
    /// A tutorial is available here:
    /// 
    /// https://youtu.be/WoXvLBJFpXk
    /// 
    /// \htmlonly
    /// <iframe width = "560" height = "315" src = "https://youtu.be/WoXvLBJFpXk" title = "YouTube video player"
    /// 	frameborder = "0" allow = "accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; 
    /// 	picture - in - picture" allowfullscreen></iframe>
    /// 	\endhtmlonly
    /// 

    public class SerialWombatWS2812 : SerialWombatPin
    {

        byte NumberOfLEDs = 0;
        UInt16 UserBufferIndex;

        /// \brief Constructor for SerialWombatWS2812 class
        /// \param serialWombat SerialWombat chip on which the driver will run
        public SerialWombatWS2812(SerialWombatChip serialWombatChip) : base(serialWombatChip)
        {
            _pinMode = (byte)SerialWombatPinModes.PIN_MODE_WS2812;
        }

        /// \brief Initialize a WS2812 LED driver object
        ///
        /// This function initializes hardware and data arrays for the WS2812 driver.
        /// It requires about 30uS per LED to initialize the data array.  During this
        /// time pin processing is suspended.  This can cause glitches in other pins.
        /// It is recommended that this pin mode be initialized once near the beginning of
        /// at power up and 
        /// that begin() not be called during real-time operation.
        /// \return 0 or higher for success or a negative number indicating an error code from the Serial Wombat chip.
        /// \param pin  The pin connected to the WS2812.  This must be an enhanced capability pin ( WP0-4, WP7, or WP9-19)
        /// \param numberOfLEDs The number of LEDs connected in series to the pin
        /// \param userBufferIndex The index in bytes into the User Buffer area where the signal train to be sent to the LEDs is stored.  
        /// The amount of data bytes required for the configured number of LEDs can be queried with readBufferSize.  This area must not
        /// be used by other pins, and cannot extend past the end of the 8k of space.
        public Int16 begin(byte pin, byte numberOfLEDs, UInt16 userBufferIndex)
        {
            _pin = pin;
            NumberOfLEDs = numberOfLEDs;
            UserBufferIndex = userBufferIndex;

            byte[] tx = { (byte)SerialWombatCommands.CONFIGURE_PIN_MODE0, _pin, _pinMode, (byte)(userBufferIndex & 0xFF), (byte)(userBufferIndex >> 8), NumberOfLEDs, 0x55 };
            return (_sw.sendPacket(tx));
        }

        public Int16 write(byte led, System.Drawing.Color color)
        {
            byte[] tx = { (byte)SerialWombatCommands.CONFIGURE_PIN_MODE1, _pin, _pinMode, led, (byte)(color.B), (byte)((color.G)), (byte)(color.R), 0x55 };
            return _sw.sendPacket(tx);
        }

        /// \brief Set an LED color
        /// \return 0 or higher for success or a negative number indicating an error code from the Serial Wombat chip.
        /// \param led The index of the LED to be set to color
        /// \param color The color of the LED in 0x00RRGGBB format
        public Int16 write(byte led, UInt32 color)
        {
            byte[] tx = { (byte)SerialWombatCommands.CONFIGURE_PIN_MODE1, _pin, _pinMode, led, (byte)(color & 0xFF), (byte)((color >> 8) & 0xFF), (byte)((color >> 16) & 0xFF), (byte)(color >> 24) };
            tx[7] = 0x55;
            return _sw.sendPacket(tx);
        }

        public Int16 write(byte led, Int16 color)
        {
            return write(led, (UInt32)color);
        }

        public Int16 write(byte led, Int32 color)
        {
            return write(led, (UInt32)color);
        }

        public Int16 write(byte led, byte length, System.Drawing.Color[] colors)
        {
            for (int i = 0; i < length; ++i)
            {
                Int16 result =
                write((byte)(led + i), colors[i]);

                if (result < 0)
                {
                    return (result);
                }

            }
            return (0);
        }

        /// \brief set the color of one LED in an animation frame
        ///
        /// \param frame The Frame index of the color being set
        /// \param led The LED index in that frame of the color being set
        /// \param color The color of the LED in 0x00RRGGBB format
        /// \return 0 or higher for success or a negative number indicating an error code from the Serial Wombat chip.
        public Int16 writeAnimationLED(byte frame, byte led, UInt32 color)
        {
            byte[] tx = { (byte)SerialWombatCommands.CONFIGURE_PIN_MODE3, _pin, _pinMode, frame, led, (byte)((color >> 16) & 0xFF), (byte)((color >> 8) & 0xFF), (byte)(color & 0xFF) };
            return _sw.sendPacket(tx);
        }

        public Int16 writeAnimationLED(byte frame, byte led, Int16 color)
        {
            return writeAnimationLED(frame, led, (UInt32)color);
        }

        public Int16 writeAnimationLED(byte frame, byte led, System.Drawing.Color color)
        {
            return writeAnimationLED(frame, led, (UInt32)color.ToArgb());
        }

        /// \brief Store an array of colors for an entire animation frame
        ///
        /// \param frame The index of the frame being stored
        /// \param colors an array of uint32_t colors in 0x00RRGGBB format to be stored in the frame.  The length of the array must match the number of LEDs
        /// \return 0 or higher for success or a negative number indicating an error code from the Serial Wombat chip.
        public Int16 writeAnimationFrame(byte frame, UInt32[] colors)
        {
            for (int i = 0; i < NumberOfLEDs; ++i)
            {
                Int16 result;
                result = writeAnimationLED(frame, (byte)i, colors[i]);
                if (result < 0)
                {
                    return (result);
                }
            }
            return (0);

        }

        /// \brief Store an array of colors for an entire animation frame
        ///
        /// \param frame The index of the frame being stored
        /// \param colors an array of System.Drawing.Color s to be stored in the frame.  The length of the array must match the number of LEDs
        /// \return 0 or higher for success or a negative number indicating an error code from the Serial Wombat chip.
        public Int16 writeAnimationFrame(byte frame, System.Drawing.Color[] colors)
        {
            for (int i = 0; i < NumberOfLEDs; ++i)
            {
                Int16 result;
                result = writeAnimationLED(frame, (byte)i, colors[i]);
                if (result < 0)
                {
                    return (result);
                }
            }
            return (0);

        }

        /// \brief Set how long an animation frame should be displayed before moving to the next frame
        /// \param frame The index of the frame being set
        /// \param dealy_mS the amount of time to display the frame in mS
        /// \return 0 or higher for success or a negative number indicating an error code from the Serial Wombat chip.
        public Int16 writeAnimationFrameDelay(byte frame, UInt16 delay_mS)
        {
            byte[] tx = { (byte)SerialWombatCommands.CONFIGURE_PIN_MODE5, _pin, _pinMode, frame, (byte)(delay_mS & 0xFF), (byte)(delay_mS >> 8), 0x55, 0x55 };
            return (_sw.sendPacket(tx));
        }

        /// \brief set the location in UserBuffer where the animation array will be stored and number of frames
        ///
        /// \param index The index into UserBuffer
        /// \param numberOfFrames The number of frames that make up the animation
        /// \return 0 or higher for success or a negative number indicating an error code from the Serial Wombat chip.

        public Int16 writeAnimationUserBufferIndex(UInt16 index, byte numberOfFrames)
        {
            byte[] tx = { (byte)SerialWombatCommands.CONFIGURE_PIN_MODE4, _pin, _pinMode, (byte)(index & 0xFF), (byte)(index >> 8), numberOfFrames, 0x55, 0x55 };
            return (_sw.sendPacket(tx));
        }


        /// \brief returns the number of bytes of UserBuffer required to service the configured number of LEDs
        ///
        /// This number does not include any animation frames.
        /// \return 0 or higher for success or a negative number indicating an error code from the Serial Wombat chip.
        public Int16 readBufferSize()
        {
            byte[] tx = { (byte)SerialWombatCommands.CONFIGURE_PIN_MODE2, _pin, _pinMode, NumberOfLEDs, 0x55, 0x55, 0x55, 0x55 };
            byte[] rx;
            Int16 result = _sw.sendPacket(tx, out rx);
            if (result >= 0)
            {
                return ((Int16)(rx[3] + rx[4] * 256));
            }
            else
            {
                return (result);
            }

        }

        /// \brief Sets the mode of the WS2812 LED Driver
        /// \return 0 or higher for success or a negative number indicating an error code from the Serial Wombat chip.
        public Int16 writeMode(SWWS2812Mode mode)
        {
            byte[] tx = { (byte)SerialWombatCommands.CONFIGURE_PIN_MODE6, _pin, _pinMode, (byte)mode, 0x55, 0x55, 0x55, 0x55 };
            return _sw.sendPacket(tx);
        }


        /// \brief Display a bargraph using the configured ws2812 class
        ///
        /// \param sourcePin  The data source to use for the bargraph
        /// \param offRGB The color to use for LEDs beyond the bargraph level
        /// \param onRGB The color to use for LEDs lit by the bargraph
        /// \param min The public data value (or below) to be treated as the beginning of the bargraph
        /// \param max The public data value (or above) to be treated as the end of the bargraph
        public Int16 barGraph(byte sourcePin, UInt32 offRGB, UInt32 onRGB, UInt16 min, UInt16 max)
        {
            byte[] tx = { (byte)SerialWombatCommands.CONFIGURE_PIN_MODE6, _pin, _pinMode, 3, sourcePin, 0x55, 0x55, 0x55 };
            Int16 result = 0;
            result = _sw.sendPacket(tx); if (result < 0) { return result; }
            result = write(0, offRGB); if (result < 0) { return result; }
            result = write(1, onRGB); if (result < 0) { return result; }

            byte[] minMax = { (byte)SerialWombatCommands.CONFIGURE_PIN_MODE7, _pin, _pinMode, (byte)(min & 0xFF), (byte)(min >> 8), (byte)(max & 0xFF), (byte)(max >> 8), 0x55 };
            return _sw.sendPacket(minMax);
        }

        public Int16 barGraph(byte sourcePin, System.Drawing.Color offRGB, System.Drawing.Color onRGB, UInt16 min, UInt16 max)
        {
            return barGraph(sourcePin, (UInt32)offRGB.ToArgb(), (UInt32)onRGB.ToArgb(), min, max);
        }
    }

      

}
