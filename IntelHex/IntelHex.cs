﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace IntelHex
{
    public class HexData
    {
#pragma warning disable CS8605 // Unboxing a possibly null value.
        public Hashtable Memory;
        private String Warnings = "";

        private const int HexLengthOffset = 1;
        private const int HexAddressOffset = 3;
        private const int HexRecordTypeOffset = 7;
        private const int HexDataOffset = 9;

        private UInt32 HexToVal(string s)
        {
            UInt32 returnvalue = 0;
            s = s.ToUpper();
            for (int i = 0; i < s.Length; ++i)
            {
                if ((s[i] >= '0') && (s[i] <= '9'))
                {
                    returnvalue *= 16;
                    returnvalue += (UInt32)((byte)(s[i]) - (byte)'0');
                }
                else if ((s[i] >= 'A') && (s[i] <= 'F'))
                {
                    byte b = (byte)s[i];
                    b -= (byte)'A';
                    b += 10;
                    returnvalue *= 16;
                    returnvalue += b;
                }
                else
                {
                    throw new InvalidDataException("Invalid character " + s[i] + " in Hex conversion");
                }
            }
            return returnvalue;
        }


        public HexData()
        {
            Memory = new Hashtable();
        }

        public HexData(string filename, Boolean enforceChecksum) : this()
        {
            Load(filename, enforceChecksum);
        }

        public HexData(StreamReader reader, Boolean enforceChecksum) : this()
        {
            Load(reader, enforceChecksum);
        }
        public void Load(string Filename, Boolean EnforceChecksum)
        {
            StreamReader sr = new StreamReader(Filename);
            Load(sr,EnforceChecksum);
            sr.Close();
        }

        public void Load(StreamReader sr, Boolean EnforceChecksum)
        {

                String? line;

                UInt32 extendedaddress = 0;
                // Read and display lines from the file until the end of 
                // the file is reached.
                while ((line = sr.ReadLine()) != null)
                {
                    //First remove any whitespace
                    line = Regex.Replace(line, "\\s*", "");

                    //Ignore lines that contain illegal characters
                    if (Regex.Match(line, "[^A-Fa-f0-9:]").Success)
                    {
                        continue;
                    }
                    //The following prevents out of range exceptions later
                    if (line.Length < 11)
                    {
                        continue;
                    }

                    // First character should be a ':'
                    if (line[0] != ':')
                    {
                        continue;
                    }

                    // Get the length.  There are 11 bytes per line in addition to
                    // the data.  Each byte of data takes 2 ascii characters to 
                    // display.  Check that the indicated length matches the 
                    // true length
                    UInt32 length = HexToVal(line.Substring(HexLengthOffset, 2));
                    if ((length * 2 + 11) != line.Length)
                    {
                        continue;
                    }
                    UInt32 lineaddress = HexToVal(line.Substring(HexAddressOffset, 4));

                    UInt32 indicatedchecksum = HexToVal(line.Substring(line.Length - 2, 2));
                    UInt32 calculatedchecksum = 0;

                    for (int i = HexLengthOffset; i < line.Length - 3; i += 2)
                    {
                        calculatedchecksum += HexToVal(line.Substring(i, 2));
                    }
                    calculatedchecksum %= 256;
                    calculatedchecksum = (256 - calculatedchecksum) % 256;

                    if ((calculatedchecksum != indicatedchecksum) && EnforceChecksum)
                    {
                        continue;
                    }

                    // At this point, the line has been validated for length, leading
                    // character, and checksum.
                    // Switch based on command character

                    UInt32 recordtype = HexToVal(line.Substring(HexRecordTypeOffset, 2));

                    switch (recordtype)
                    {
                        case 0:
                            // Data Record

                            for (UInt32 i = 0; i < length; ++i)
                            {
                                byte data = (byte)HexToVal(line.Substring((int)(HexDataOffset + 2 * i), 2));
                                UInt32 byteaddress = extendedaddress * 65536 + lineaddress + i;
                                if (Memory.ContainsKey((UInt32)(byteaddress)))
                                {
                                    Warnings += "Address " + String.Format("{0:X}", byteaddress) +
                                        "is defined multiple times";
                                }
                                Memory[byteaddress] = data;
                            }

                            break;

                        case 4:
                            //Extended Record

                            if (length != 2)
                            {
                                continue;
                            }
                            extendedaddress = HexToVal(line.Substring(HexDataOffset, 4));

                            break;

                        case 1:
                            // End of File

                            break;

                        default:
                            //unsupported line type

                            break;
                    }
            }
        }

        public string TwoColumn()
        {
            string s = "";
            ArrayList keys = SortedKeys();
            foreach (UInt32 key in keys)
            {
                s += string.Format("{0:X}", key) + " " + string.Format("{0,2:X}", Memory[key]) + "\n";
            }
            return s;
        }

        private ArrayList SortedKeys()
        {
            ArrayList aKeys = new ArrayList(Memory.Keys);
            aKeys.Sort();
            return aKeys;
        }

        public UInt32 HighestAddress
        {
            get
            {
                ArrayList aKeys = SortedKeys();

                return ((UInt32)aKeys[aKeys.Count - 1]);

            }
        }

        public UInt32 LowestAddress
        {
            get
            {
                ArrayList aKeys = SortedKeys();
                return ((UInt32)aKeys[0]);
            }
        }

        public void Crop(UInt32 InclusiveStartAddress, UInt32 ExclusiveEndAddress)
        {
            ArrayList keys = SortedKeys();

            foreach (UInt32 key in keys)
            {
                if (key < InclusiveStartAddress || key >= ExclusiveEndAddress)
                {
                    Memory.Remove(key);
                }
            }
        }

        public void Fill(UInt32 InclusiveStartAddress, UInt32 ExclusiveEndAddress, byte value)
        {
            for (UInt32 address = InclusiveStartAddress; address < ExclusiveEndAddress; ++address)
            {
                if (!Memory.ContainsKey(address))
                {
                    Memory[address] = value;
                }
            }
        }

        public void Fill16(UInt32 InclusiveStartAddress, UInt32 ExclusiveEndAddress, UInt16 value)
        {
            for (UInt32 address = InclusiveStartAddress; address < ExclusiveEndAddress; address += 2)
            {
                if (!Memory.ContainsKey(address))
                {
                    Memory[address] = (byte)(value & 0xFF);
                    Memory[address + 1] = (byte)(value >> 8);
                }
            }
        }
        public void Fill32(UInt32 InclusiveStartAddress, UInt32 ExclusiveEndAddress, UInt32 value)
        {
            for (UInt32 address = InclusiveStartAddress; address < ExclusiveEndAddress; address += 4)
            {
                if (!Memory.ContainsKey(address))
                {
                    Memory[address] = (byte)(value & 0xFF);
                    Memory[address + 1] = (byte)(value >> 8);
                    Memory[address + 2] = (byte)(value >> 16);
                    Memory[address + 3] = (byte)(value >> 24);
                }
            }
        }

        public void Binary(string Filename, UInt32 InclusiveStartAddress, UInt32 ExclusiveEndAddress, byte value)
        {
            FileStream fs = new FileStream(Filename, FileMode.Create);
            {
                for (UInt32 i = InclusiveStartAddress; i < ExclusiveEndAddress; ++i)
                {
                    if (Memory.ContainsKey(i))
                    {
                        
                            fs.WriteByte((byte)Memory[i]);
   
                    }
                    else
                    {
                        fs.WriteByte(value);
                    }
                }
            }
            fs.Close();

        }

        public void Add(ref HexData x)
        {
            ArrayList aKeys = new ArrayList(x.Memory.Keys);
            foreach (UInt32 key in aKeys)
            {
                if (Memory.ContainsKey(key))
                {
                    Warnings += (string.Format("Warning, address 0x{0,X} is being overwritten in add.  Original value: 0x{1,X} New Value: 0x{2,X}", key, Memory[key], x.Memory[key]));
                }
                Memory[key] = x.Memory[key];
            }
        }

        public byte[] Subarray(uint start, uint length)
        {
            byte[] b = new byte[length];
            for (int i = 0; i < length; ++i)
            {
                b[i] = (byte)Memory[(UInt32)(i + start)];
            }
            return (b);
        }

        public UInt16 Crc16citt(uint start, uint exclusiveEnd)
        {
            ushort crc = 0xFFFF;
            uint length = exclusiveEnd - start;

            for (int i = 0; i < length; i++)
            {
                UInt32 addr = (UInt32)(i + start);
                UInt16 data = (byte)Memory[addr];
                crc ^= (UInt16)((data) << 8);
                for (int j = 0; j < 8; j++)
                {
                    if ((crc & 0x8000) > 0)
                        crc = (ushort)((crc << 1) ^ 0x1021);
                    else
                        crc <<= 1;
                }
            }
            return crc;
        }

        private string HexLine(UInt32 address, ref UInt32 addressHighWord, List<byte> dataline)
        {
            string s = "";

            for (int i = 0; i < dataline.Count; ++i)
            {
                if ((address + i >> 16) != addressHighWord)
                {

                    if (i != 0)
                    {
                        UInt32 checksum = 0;
                        s += $":{i:X2}{(address & 0xFFFF):X4}00";
                        checksum += (UInt32)i;
                        checksum += address >> 8;
                        checksum += address & 0xFF;

                        for (int x = 0; x < i; ++x)
                        {
                            s += $"{dataline[0]:X2}";
                            checksum += dataline[0];
                            dataline.RemoveAt(0);
                        }
                        checksum = ~checksum;
                        ++checksum;
                        s += $"{checksum & 0xFF:X2}";
                        s += Environment.NewLine;
                    }
                    {
                        UInt32 checksum = 0;
                        s += $":02000004{(address >> 16):X4}";
                        checksum = 2 + 4 + ((address >> 16) & 0xFF) + ((address >> 24) & 0xFF);
                        checksum = ~checksum;
                        checksum++;
                        s += $"{checksum & 0xFF:X2}{Environment.NewLine}";
                        addressHighWord = address >> 16;
                    }



                }
                else
                {


                }

            }
            if (dataline.Count > 0)
            {
                UInt32 checksum = 0;
                s += $":{dataline.Count:X2}{(address & 0xFFFF):X4}00";
                checksum += (UInt32)dataline.Count;
                checksum += address >> 8;
                checksum += address & 0xFF;

                foreach (byte b in dataline)
                {
                    s += $"{b:X2}";
                    checksum += b;
                }
                checksum = ~checksum;
                ++checksum;
                s += $"{checksum & 0xFF:X2}";
                s += Environment.NewLine;
            }
            return (s);
        }
        public string toHexFileString(UInt32 InclusiveStartAddress, UInt32 ExclusiveEndAddress)
        {
            string s = "";
            UInt32 address = InclusiveStartAddress;
            UInt32 addressHighWord = 0;
            List<byte> dataline = new List<byte>();

            for (UInt32 i = InclusiveStartAddress; i < ExclusiveEndAddress; ++i)
            {
                if (Memory.ContainsKey(i))
                {
                    // Good to continue writing data lines
                    if (dataline.Count == 0)
                    {
                        address = i;
                    }
                    dataline.Add((byte)Memory[i]);
                    if (dataline.Count >= 16 || (((address + i) & 0xF) == 0xF))
                    {
                        s += HexLine(address, ref addressHighWord, dataline);
                        dataline = new List<byte>();
                    }
                }
                else
                {
                    if (dataline.Count > 0)
                    {
                        s += HexLine(address, ref addressHighWord, dataline);
                        dataline = new List<byte>();
                    }
                    if (Memory.ContainsKey(i))
                    {
                        dataline.Add((byte)Memory[i]);
                        address = i;
                    }


                }
            }
            if (dataline.Count > 0)
            {
                s += HexLine(address, ref addressHighWord, dataline);
            }
            s += ":00000001FF" + Environment.NewLine;
            return (s);
        }
        /// <summary>
        /// Create a c array of 32 bit values for download using the SW18 bootloader
        /// and Arduino utility.  This array contains 32 bit values that match up with
        /// the 24 bit data.  The most significant byte is used for Run length encoding.
        /// That value + 1 is how many times that word should be repeated.  Good
        /// for blank areas, vector tables, and the Serial Wombat And/Or assembly
        /// routines.
        /// </summary>
        /// <param name="InclusiveStartAddress"></param>
        /// <param name="ExclusiveEndAddress"></param>
        /// <returns></returns>
        public string toSW18BootloaderArray(UInt32 InclusiveStartAddress, UInt32 ExclusiveEndAddress, bool CommentAddresses = false)
        {
            if ((InclusiveStartAddress & 0x03) != 0)
            {
                return ($"Inclusive Start address 0x{InclusiveStartAddress:X8} is not on word boundary.");
            }
            else if ((ExclusiveEndAddress & 0x03) != 0)
            {
                return ($"Inclusive Start address 0x{ExclusiveEndAddress:X8} is not on word boundary.");
            }

            string s = $"#include <std_int.h>{Environment.NewLine}uint32_t appStartAddress = 0x{InclusiveStartAddress:X8};{Environment.NewLine}";
            s += $"const uint32_t appImage[] = {{ {Environment.NewLine}";
            UInt32 RLEStartAddress = InclusiveStartAddress;
            UInt32 currentdata = (byte)Memory[(UInt32)InclusiveStartAddress];
            currentdata += (UInt32)((byte)Memory[(UInt32)(InclusiveStartAddress + 1)]) << 8;
            currentdata += (UInt32)((byte)Memory[(UInt32)(InclusiveStartAddress + 2)]) << 16;
            //final byte is zero.

            for (UInt32 i = InclusiveStartAddress + 4; i < ExclusiveEndAddress; i += 4)
            {
                UInt32 newData = (byte)Memory[(UInt32)i];
                newData += (UInt32)((byte)Memory[(UInt32)(i + 1)]) << 8;
                newData += (UInt32)((byte)Memory[(UInt32)i + 2]) << 16;
                if (newData == (currentdata & 0xFFFFFF) && (currentdata >> 24) != 0xFF)
                {
                    currentdata += (1 << 24);
                }
                else
                {
                    //Write out current data
                    s += $"0x{(currentdata & 0xFFFFFFFF):X},";
                    if (CommentAddresses)
                    {
                        s += $" // {RLEStartAddress:X8}";
                    }

                    s += Environment.NewLine;
                    RLEStartAddress = i;
                    currentdata = newData;
                }


            }
            //Write out current data
            s += $"0x{(currentdata & 0xFFFFFFFF):X},";
            if (CommentAddresses)
            {
                s += $" // {RLEStartAddress:X8}";
            }

            s += Environment.NewLine;
            s += "};" + Environment.NewLine;
            return (s);
        }

        public void loadSW18BootloaderArray(string fileName)
        {
            TextReader tw = new StreamReader(fileName);
            string? s = tw.ReadLine();
            Regex rAddr = new Regex(@"appStartAddress\s*=\s*0x(\w+)", RegexOptions.IgnoreCase);
            Regex rData = new Regex(@"0x(\w+)\s*,");
            UInt32 address = 0xFFFFFFFF;
            while (s != null)
            {
                Match m = rAddr.Match(s);
                if (m.Success)
                {
                    address = UInt32.Parse(m.Groups[1].Value, System.Globalization.NumberStyles.HexNumber);
                    s = tw.ReadLine();
                    break;
                }
                s = tw.ReadLine();
            }

            while (s != null)
            {
                Match m = rData.Match(s);
                if (m.Success)
                {
                    UInt32 data = UInt32.Parse(m.Groups[1].Value, System.Globalization.NumberStyles.HexNumber);
                    int count = (int)(data >> 24) + 1;
                    data &= 0x00FFFFFF;
                    for (int i = 0; i < count; ++i)
                    {
                        Memory[address] = (byte)(data & 0xFF);
                        ++address;
                        Memory[address] = (byte)((data >> 8) & 0xFF);
                        ++address;
                        Memory[address] = (byte)((data >> 16) & 0xFF);
                        ++address;
                        Memory[address] = (byte)0;
                        ++address;
                    }
                }
                s = tw.ReadLine();
            }
        }

        /// <summary>
        /// Create a c array of 32 bit values in a C array
        /// </summary>
        /// <param name="InclusiveStartAddress"></param>
        /// <param name="ExclusiveEndAddress"></param>
        /// <returns></returns>
        public string to32BitArray(UInt32 InclusiveStartAddress, UInt32 ExclusiveEndAddress, bool CommentAddresses = false)
        {
            if ((InclusiveStartAddress & 0x03) != 0)
            {
                return ($"Inclusive Start address 0x{InclusiveStartAddress:X8} is not on word boundary.");
            }
            else if ((ExclusiveEndAddress & 0x03) != 0)
            {
                return ($"Inclusive Start address 0x{ExclusiveEndAddress:X8} is not on word boundary.");
            }

            string s = $"#include <std_int.h>{Environment.NewLine}uint32_t appStartAddress = 0x{InclusiveStartAddress:X8};{Environment.NewLine}";
            s += $"const uint32_t appImage[] = {{ {Environment.NewLine}";
            //final byte is zero.

            for (UInt32 i = InclusiveStartAddress ; i < ExclusiveEndAddress; i += 4)
            {
                UInt32 newData = (byte)Memory[(UInt32)i];
                newData += (UInt32)((byte)Memory[(UInt32)(i + 1)]) << 8;
                newData += (UInt32)((byte)Memory[(UInt32)i + 2]) << 16;
                newData += (UInt32)((byte)Memory[(UInt32)i + 3]) << 24;
                s += $"0x{(newData ):X8},";
                    if (CommentAddresses)
                    {
                        s += $" // {i:X8}";

                    }
                s += Environment.NewLine;
            }
           

            
            s += "};" + Environment.NewLine;
            return (s);
        }


    }
}
