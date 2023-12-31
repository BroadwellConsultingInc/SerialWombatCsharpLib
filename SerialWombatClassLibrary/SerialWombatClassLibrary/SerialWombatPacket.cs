using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace SerialWombat
{
    public class SerialWombatPacket
    {
        protected byte[] _data = { 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55 };
        protected bool _isresponse = false;

        public SerialWombatPacket()
        {
        }

        public SerialWombatPacket(SerialWombatPacket wombatPacket)
        {
            wombatPacket.Data.CopyTo(_data, 0);
            IsResponse = wombatPacket.IsResponse;
        }
        public SerialWombatPacket(byte[] data)
        {
            data.CopyTo(_data, 0);
        }

        public bool IsResponse
        {
            get => _isresponse;
            set => _isresponse = value;
        }

        private enum ParseMode
        {
            Normal,
            InDec,
            InHex,
            InString,
            InChar,
            InComment,
            Error
        };

        private bool ParseMsg(string s)
        {

            
            // Replace any strings
            Regex str = new Regex("(.*)\"([^'].*?)\"(.*)");

            Match m = str.Match(s);
            while (m.Success)
            {

                string pre = m.Groups[1].Value;
                string post = m.Groups[3].Value;
                string mid = "";
                foreach (char c in m.Groups[2].Value)
                {
                    mid += $" 0x{(int)c:X2} ";
                }
                s = $"{pre} {mid} {post}";
                m = str.Match(s);
            }

            // Replace any Single quotes
            Regex quote = new Regex("(.*)'(.)'(.*)");
            m = quote.Match(s);
            while (m.Success)
            {

                string pre = m.Groups[1].Value;
                string post = m.Groups[3].Value;
                string mid = "";
                mid += $" 0x{(int)m.Groups[2].Value[0]:X2} ";
                s = $"{pre} {mid} {post}";
                m = quote.Match(s);
            }

            Regex rS = new Regex(@"(.*)\s(\d+)s\b(.*)");
            m = rS.Match(s);
            while (m.Success)
            {

                string pre = m.Groups[1].Value;
                string post = m.Groups[3].Value;
                int val = Convert.ToUInt16(m.Groups[2].Value);
                string mid = $"0x{val:X4}";
                s = $"{pre} {mid} {post}";
                m = rS.Match(s);
            }

            Regex rl = new Regex(@"(.*)\s(\d+)[lL]\b(.*)");
            m = rl.Match(s);
            while (m.Success)
            {

                string pre = m.Groups[1].Value;
                string post = m.Groups[3].Value;
                UInt32 val = Convert.ToUInt32(m.Groups[2].Value);
                string mid = $"0x{val:X8}";
                s = $"{pre} {mid} {post}";
                m = rl.Match(s);
            }
           

            Regex number = new Regex(@"(.*)\b(\d+)\b(.*)");
            m = number.Match(s);
            while (m.Success)
            {

                string pre = m.Groups[1].Value;
                string post = m.Groups[3].Value;
                byte val = Convert.ToByte(m.Groups[2].Value);
                string mid = $"0x{val:X2}";
                s = $"{pre} {mid} {post}";
                m = number.Match(s);
            }

            Regex comment = new Regex("(.*);[^\"'].*");
            m = comment.Match(s);
            if (m.Success)
            {
                s = m.Groups[1].Value;
            }
            string prior = "";
            while (prior != s)
            {
                prior = s;
                s = Regex.Replace(s, "0[xX]([A-Fa-f0-9][A-Fa-f0-9])([A-Fa-f0-9]+)", "0x$2 0x$1");
            }

            prior = "";
            while (prior != s)
            {
                prior = s;
                s = Regex.Replace(s, @"\s\s", " ");
            }
            s = s.Trim();

            string[] hexbytes = s.Split(" ");


            for (int i = 0; i < 8 && i < hexbytes.Count(); ++i)
            {
                _data[i] = Convert.ToByte(hexbytes[i], 16);
            }
            return (true);

        }


        private bool ParseMsgOld(string s)
        {
            // This function parses a user string into bytes.  
            // Bytes may be expressed in a number of different ways
            // a number between 0 and 255 is a single byte
            // a hex number between 0x00 and 0xFF is a single byte.
            // A character in single quotes is converted to it's ascii equiv.
            // For example 'A' is converted to 65.
            // A group of characters in double quotes is converted to a series
            // of bytes.  For example, "ABCD" is converted to
            // 65 66 67 68 .
            // anything after an unquoted semicolon 
            // 16 bit values can be entered in hex (0x1234) and count as two bytes

            int bytecounter = 0;
            int stringcounter = 0;
            UInt32 partialval = 0;
            int hexcounter = 0;
            bool Error = false;
            string Comment = "";

            ParseMode m = ParseMode.Normal;

            try
            {
                while (stringcounter < s.Length)
                {
                    char c = s[stringcounter];
                    switch (m)
                    {
                        case ParseMode.Normal:
                            {
                                switch (c)
                                {
                                    case ' ':  //Space
                                    case '\t': //Tab
                                               // whitespace.  Ignore.
                                        break;

                                    case '\'':  //Single quote
                                        m = ParseMode.InChar;
                                        break;

                                    case '"': //Double quote
                                        m = ParseMode.InString;
                                        break;

                                    case ';': //Comment
                                        m = ParseMode.InComment;
                                        break;
                                    case '0':
                                        partialval = 0;
                                        if (s.Length - 1 > stringcounter)
                                        {
                                            // There's at least one more char after this one
                                            if (s[stringcounter + 1] == 'x' ||
                                                s[stringcounter + 1] == 'X')
                                            {
                                                ++stringcounter; // Absorb x
                                                m = ParseMode.InHex;
                                                hexcounter = 0;
                                            }
                                            else m = ParseMode.InDec;
                                        }
                                        else
                                        {
                                            // Last character
                                            _data[bytecounter] = 0;
                                            ++bytecounter;
                                        }
                                        break;
                                    case '1':
                                    case '2':
                                    case '3':
                                    case '4':
                                    case '5':
                                    case '6':
                                    case '7':
                                    case '8':
                                    case '9':
                                        partialval = (uint)((byte)(c) - (byte)'0');
                                        m = ParseMode.InDec;
                                        if (s.Length - 1 == stringcounter)
                                        {
                                            //Last character
                                            _data[bytecounter] = (byte)partialval;
                                            ++bytecounter;
                                        }
                                        break;

                                    default:
                                        // Something unexpected or useless.  Do nothing
                                        break;

                                }
                            }
                            break;
                        case ParseMode.InChar:
                            {
                                if (s.Length - 1 > stringcounter)
                                {
                                    // There's at least one more char after this one
                                    if (s[stringcounter + 1] == '\'')
                                    {
                                        _data[bytecounter] = (byte)c;
                                        ++bytecounter;
                                        ++stringcounter; // Absorb trailing ' 
                                        m = ParseMode.Normal;
                                    }
                                    else
                                    {
                                        m = ParseMode.Error;
                                    }
                                }
                                else
                                {
                                    m = ParseMode.Error;
                                }
                            }
                            break;

                        case ParseMode.InString:
                            {
                                _data[bytecounter] = (byte)c;
                                ++bytecounter;
                                if (s.Length - 1 > stringcounter)
                                {
                                    // There's at least one more char after this one
                                    if (s[stringcounter + 1] == '"')
                                    {
                                        //Absorb trailing "
                                        ++stringcounter;
                                        m = ParseMode.Normal;
                                    }
                                }
                                else
                                {
                                    m = ParseMode.Error;
                                }
                            }
                            break;

                        case ParseMode.InDec:

                            {
                                switch (c)
                                {
                                    case '0':
                                    case '1':
                                    case '2':
                                    case '3':
                                    case '4':
                                    case '5':
                                    case '6':
                                    case '7':
                                    case '8':
                                    case '9':
                                        {
                                            partialval *= 10;
                                            partialval = (uint)(partialval + ((byte)(c) - (byte)'0'));
                                        }
                                        break;

                                    case ' ':
                                    case '\t':
                                    case ';':
                                        {
                                            if (c == ';')
                                            {
                                                m = ParseMode.InComment;
                                            }
                                            else
                                            {
                                                m = ParseMode.Normal;
                                            }
                                            if (partialval <= 255)
                                            {
                                                _data[bytecounter] = (byte)partialval;
                                                ++bytecounter;
                                            }
                                            else
                                            {
                                                m = ParseMode.Error;
                                            }
                                        }
                                        break;

                                    default:
                                        m = ParseMode.Error;
                                        break;
                                }
                                if ((s.Length - 1) == stringcounter)
                                {
                                    // Last number in the string.  process it
                                    if (partialval <= 255)
                                    {
                                        _data[bytecounter] = (byte)partialval;
                                        ++bytecounter;
                                    }
                                    else
                                    {
                                        m = ParseMode.Error;
                                    }
                                }
                            }
                            break;

                        case ParseMode.InHex:
                            {
                                switch (c)
                                {
                                    case ' ':
                                    case '\t':
                                    case ';':
                                    case ',':
                                        if (c == ';')
                                        {
                                            m = ParseMode.InComment;
                                        }
                                        else
                                        {
                                            m = ParseMode.Normal;
                                        }

                                        if (hexcounter <= 2)
                                        {
                                            _data[bytecounter] = (byte)partialval;
                                            ++bytecounter;
                                        }
                                        else if (hexcounter <= 4)
                                        {
                                            _data[bytecounter] = (byte)(partialval % 256);
                                            ++bytecounter;
                                            _data[bytecounter] = (byte)(partialval / 256);
                                            ++bytecounter;
                                        }
                                        else
                                        {
                                            m = ParseMode.Error;
                                        }

                                        break;

                                    case char n when (n >= '0' && n <= '9'):
                                        partialval *= 16;
                                        partialval = (uint)(partialval + ((byte)(c) - (byte)'0'));
                                        ++hexcounter;
                                        break;
                                    case char n when (n >= 'a' && n <= 'f'):
                                        partialval *= 16;
                                        partialval = (uint)(partialval + 10 + ((byte)(c) - (byte)'a'));
                                        ++hexcounter;
                                        break;

                                    case char n when (n >= 'A' && n <= 'F'):
                                        partialval *= 16;
                                        partialval = (uint)(partialval + 10 + ((byte)(c) - (byte)'A'));
                                        ++hexcounter;
                                        break;




                                    default:
                                        m = ParseMode.Error;
                                        break;
                                }
                                if ((s.Length - 1) == stringcounter)
                                {
                                    m = ParseMode.Normal;
                                    if (hexcounter <= 2)
                                    {
                                        _data[bytecounter] = (byte)partialval;
                                        ++bytecounter;
                                    }
                                    else if (hexcounter <= 4)
                                    {
                                        _data[bytecounter] = (byte)(partialval % 256);
                                        ++bytecounter;
                                        _data[bytecounter] = (byte)(partialval / 256);
                                        ++bytecounter;
                                    }
                                    else
                                    {
                                        m = ParseMode.Error;
                                    }
                                }
                            }
                            break;

                        case ParseMode.InComment:
                            {
                                Comment += c;
                            }
                            break;


                    }

                    ++stringcounter;
                }
            }
            catch
            {
                m = ParseMode.Error;
                //TODO TxDescription += "Exception: " + e.Message;
            }

            if (m == ParseMode.Error)
            {
                Error = true;
            }


            return (!Error);
        }
        public SerialWombatPacket(string s)
        {
            if (!ParseMsg(s))
            {
                //There was an error.
                _data = new byte[] { 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55 };
            }

        }

        public byte this[int index]
        {
            get => _data[index];
            set => _data[index] = value;
        }

        public byte[] Data
        {
            get => (byte[])_data.Clone();
        }

        public bool DataEqual(SerialWombatPacket wp)
        {
            for (int i = 0; i < Data.Length; ++i)
            {
                if (Data[i] != wp.Data[i])
                {
                    return (false);
                }
            }
            return (true);
        }

        public string RawString
        {
            get
            {
                string s = "";
                foreach (byte b in _data)
                {
                    s += $"{b:X2} ";
                }
                return s;
            }
        }
        public override string ToString()
        {

            return RawString + PacketDescription;
        }

        virtual public string PacketDescription
        {
            get => "";
        }
        public byte CommandByte
        {
            get => _data[0];
            set => _data[0] = value;
        }

        public SerialWombatCommands CommandByteEnum
        {
            get { try { return (SerialWombatCommands)CommandByte; } catch { return SerialWombatCommands.Unknown; } }
            set { CommandByte = (byte)value; }
        }

        virtual public SerialWombatPacket TypedPacket()
        {
            return CommandByteEnum switch
            {
                /*
                WombatCommandByte.Echo => new WombatEchoPacket(this),
                WombatCommandByte.AsciiSetPin => new WombatAsciiSetPinPacket(this),
                WombatCommandByte.Reset => new WombatResetPacket(this),
                WombatCommandByte.ReadBufferBinary => new WombatReadBufferBinaryPacket(this).TypedPacket(),
                WombatCommandByte.SetBufferBinary => new WombatWriteBufferBinaryPacket(this).TypedPacket(),
                WombatCommandByte.Resync => this,
                WombatCommandByte.SetPinMode0 => new WombatSetPinMode(this).TypedPacket(),
                WombatCommandByte.SetPinMode1 => new WombatSetPinMode(this).TypedPacket(),
                WombatCommandByte.SetPinMode2 => new WombatSetPinMode(this).TypedPacket(),
                WombatCommandByte.SetPinMode3 => new WombatSetPinMode(this).TypedPacket(),
                WombatCommandByte.SetPinMode4 => new WombatSetPinMode(this).TypedPacket(),
                WombatCommandByte.SetPinMode5 => new WombatSetPinMode(this).TypedPacket(),
                WombatCommandByte.SetPinMode6 => new WombatSetPinMode(this).TypedPacket(),
                WombatCommandByte.SetPinMode7 => new WombatSetPinMode(this).TypedPacket(),
                WombatCommandByte.SetPinMode8 => new WombatSetPinMode(this).TypedPacket(),
                WombatCommandByte.SetPinMode9 => new WombatSetPinMode(this).TypedPacket(),
                WombatCommandByte.Version => new WombatVersionPacket(this),
                WombatCommandByte.SupplyVoltage => new WombatSupplyVoltagePacket(this),
                */
                _ => this

            };
        }

        public void SetUInt16(UInt16 value, int offset)
        {
            BitConverter.GetBytes(value).CopyTo(_data, offset);
        }
        public void SetInt16(UInt16 value, int offset)
        {
            BitConverter.GetBytes(value).CopyTo(_data, offset);
        }
        public void SetUInt32(UInt32 value, int offset)
        {
            BitConverter.GetBytes(value).CopyTo(_data, offset);
        }
        public void SetInt32(Int32 value, int offset)
        {
            BitConverter.GetBytes(value).CopyTo(_data, offset);
        }



        public void SetAsciiDec(UInt32 value, int offset, int digits)
        {
            if (digits - 1 + offset > 7)
            {
                throw (new IndexOutOfRangeException());
            }
            while (digits > 0)
            {
                _data[offset + digits - 1] = (byte)((value % 10) + '0');
                value /= 10;
                --digits;
            }
        }
        public UInt32 GetAsciiDec(int offset, int digits)
        {
            UInt32 output = 0;
            if (digits - 1 + offset > 7)
            {
                throw (new IndexOutOfRangeException());
            }
            for (int i = 0; i < digits; ++i)
            {
                output *= 10;
                if (_data[offset + i] >= '0' && _data[offset + i] <= '9')
                {
                    output += (UInt32)(_data[offset + i] - '0');
                }
            }
            return (output);
        }


        public UInt16 GetUInt16(int offset)
        {
            return BitConverter.ToUInt16(_data, offset);
        }
        public UInt32 GetUInt32(int offset)
        {
            return BitConverter.ToUInt32(_data, offset);
        }
        public Int16 GetInt16(int offset)
        {
            return BitConverter.ToInt16(_data, offset);
        }

        public Int32 GetInt32(int offset)
        {
            return BitConverter.ToInt32(_data, offset);
        }


        public bool Bool0
        {
            get => _data[0] > 0;
            set => _data[0] = (byte)(value ? 1 : 0);
        }

        public bool Bool1
        {
            get => _data[1] > 0;
            set => _data[1] = (byte)(value ? 1 : 0);
        }

        public bool Bool2
        {
            get => _data[2] > 0;
            set => _data[2] = (byte)(value ? 1 : 0);
        }

        public bool Bool3
        {
            get => _data[3] > 0;
            set => _data[3] = (byte)(value ? 1 : 0);
        }

        public bool Bool4
        {
            get => _data[4] > 0;
            set => _data[4] = (byte)(value ? 1 : 0);
        }

        public bool Bool5
        {
            get => _data[5] > 0;
            set => _data[5] = (byte)(value ? 1 : 0);
        }

        public bool Bool6
        {
            get => _data[6] > 0;
            set => _data[6] = (byte)(value ? 1 : 0);
        }

        public bool Bool7
        {
            get => _data[7] > 0;
            set => _data[7] = (byte)(value ? 1 : 0);
        }
    }
}
