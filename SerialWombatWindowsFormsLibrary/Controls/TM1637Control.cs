﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using SerialWombat;

namespace SerialWombatWindowsFormsLibrary
{
    public partial class TM1637Control : UserControl
    {
        public SerialWombatChip SerialWombatChip;
        public byte Pin;
        SerialWombatTM1637 tM1637;

        public TM1637Control()
        {
            InitializeComponent();
        }

        public void begin(SerialWombatChip serialWombatChip, byte pin)
        {
            SerialWombatChip = serialWombatChip;
            Pin = pin;
            tM1637 = new SerialWombatTM1637(serialWombatChip);
            serialWombatPublicDataControl1.DataSourceValue = pin;
            tbDioPin.Text = (pin + 1).ToString();
            groupBox1.Text = $"Pin {Pin} TM1637";
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bWriteDigitOrder_Click(object sender, EventArgs e)
        {
            tM1637.writeDigitOrder(Convert.ToByte(tbOrder0.Text),
                Convert.ToByte(tbOrder1.Text),
                Convert.ToByte(tbOrder2.Text),
                Convert.ToByte(tbOrder3.Text),
                Convert.ToByte(tbOrder4.Text),
                Convert.ToByte(tbOrder5.Text)
                );
        }

        private void bConfigure_Click(object sender, EventArgs e)
        {
            tM1637.begin(Pin, Convert.ToByte(tbDioPin.Text), 
                Convert.ToByte(tbDigits.Text), 
                SerialWombatTM1637.SWTM1637Mode.tm1637CharArray, 
                Pin,
                (byte)trackBar1.Value);

              tM1637.writeArray(new byte[] { 0x30, 0x31, 0x32, 0x33, 0x34, 0x35 });

        }

        private void bPinDataHex_Click(object sender, EventArgs e)
        {
            tM1637.begin(Pin, Convert.ToByte(tbDioPin.Text), Convert.ToByte(tbDigits.Text), SerialWombatTM1637.SWTM1637Mode.tm1637Hex16,
                serialWombatPublicDataControl1.DataSourceValue, (byte)trackBar1.Value);
            try
            {
                tM1637.writeDigitOrder(Convert.ToByte(tbOrder0.Text),
               Convert.ToByte(tbOrder1.Text),
               Convert.ToByte(tbOrder2.Text),
               Convert.ToByte(tbOrder3.Text),
               Convert.ToByte(tbOrder4.Text),
               Convert.ToByte(tbOrder5.Text)
               );
            }
            catch
            {

            }
            tM1637.suppressLeadingZeros(ckbSurpressZeros.Checked);
        }

        private void bPinDataDecimal_Click(object sender, EventArgs e)
        {
            tM1637.begin(Pin, Convert.ToByte(tbDioPin.Text), Convert.ToByte(tbDigits.Text), SerialWombatTM1637.SWTM1637Mode.tm1637Decimal16,
                serialWombatPublicDataControl1.DataSourceValue, (byte)trackBar1.Value);
            try
            {
                tM1637.writeDigitOrder(Convert.ToByte(tbOrder0.Text),
               Convert.ToByte(tbOrder1.Text),
               Convert.ToByte(tbOrder2.Text),
               Convert.ToByte(tbOrder3.Text),
               Convert.ToByte(tbOrder4.Text),
               Convert.ToByte(tbOrder5.Text)
               );
            }
            catch
            {

            }
            tM1637.suppressLeadingZeros(ckbSurpressZeros.Checked);
        }

        private void ckbSurpressZeros_CheckedChanged(object sender, EventArgs e)
        {
            tM1637.suppressLeadingZeros(ckbSurpressZeros.Checked);
        }

        private void bWriteDecimals_Click(object sender, EventArgs e)
        {
            int value = 0;
            if (ckbDec0.Checked) value |= 0x01;
            if (ckbDec1.Checked) value |= 0x02;
            if (ckbDec2.Checked) value |= 0x04;
            if (ckbDec3.Checked) value |= 0x08;
            if (ckbDec4.Checked) value |= 0x10;
            if (ckbDec5.Checked) value |= 0x20;
            tM1637.writeDecimalBitmap((byte)value);
        }

        private void bWriteBlinkBitmap_Click(object sender, EventArgs e)
        {
            int value = 0;
            if (ckbBlink0.Checked) value |= 0x01;
            if (ckbBlink1.Checked) value |= 0x02;
            if (ckbBlink2.Checked) value |= 0x04;
            if (ckbBlink3.Checked) value |= 0x08;
            if (ckbBlink4.Checked) value |= 0x10;
            if (ckbBlink5.Checked) value |= 0x20;
            tM1637.writeBlinkBitmap((byte)value);
        }

        private void bWriteRaw_Click(object sender, EventArgs e)
        {
            tM1637.begin(Pin, Convert.ToByte(tbDioPin.Text), Convert.ToByte(tbDigits.Text), SerialWombatTM1637.SWTM1637Mode.tm1637RawArray,
               serialWombatPublicDataControl1.DataSourceValue, (byte)trackBar1.Value);
            try
            {
                tM1637.writeDigitOrder(Convert.ToByte(tbOrder0.Text),
               Convert.ToByte(tbOrder1.Text),
               Convert.ToByte(tbOrder2.Text),
               Convert.ToByte(tbOrder3.Text),
               Convert.ToByte(tbOrder4.Text),
               Convert.ToByte(tbOrder5.Text)
               );
            }
            catch
            {

            }
            tM1637.writeArray(new byte[] {
                sevenSegmentControl1.value,
                sevenSegmentControl2.value,
                sevenSegmentControl3.value,
                sevenSegmentControl4.value,
                sevenSegmentControl5.value,
                sevenSegmentControl6.value});
        }

        private void bWriteArray_Click(object sender, EventArgs e)
        {
            byte[] data = Encoding.ASCII.GetBytes(tbArray.Text);
            byte[] data6 = { 32, 32, 32, 32, 32, 32 };
            for (int i = 0; i < data.Length && i < 6; ++i)
            {
                data6[i] = data[i];
            }
            tM1637.writeArray(data6);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gbAnimation.Visible = true;
        }

       byte[,] readAnimationList()
        {
            List<byte[]> frames = new List<byte[]>();

            Regex rFrame = new Regex(@"^\s*(0x\w\w)\s*,\s*(0x\w\w)\s*,\s*(0x\w\w)\s*,\s*(0x\w\w)\s*,\s*(0x\w\w)\s*,\s*(0x\w\w)\s*", RegexOptions.IgnoreCase);
            Regex rWhitespace = new Regex(@"^\s*$");
            Regex rBegin = new Regex(@"^\s*{\s*$");
            Regex rEnd = new Regex(@"^\s*};\s*$");
            int i = 1;
            bool beginFound = false;
            foreach (string s in tbAnimationFrames.Lines)
            {
                Match m = rFrame.Match(s);
                if (m.Success)
                {
                    try
                    {
                        byte[] b = new byte[]
                        {
                            Convert.ToByte(m.Groups[1].Value,16),
                            Convert.ToByte(m.Groups[2].Value,16),
                            Convert.ToByte(m.Groups[3].Value,16),
                            Convert.ToByte(m.Groups[4].Value,16),
                            Convert.ToByte(m.Groups[5].Value,16),
                            Convert.ToByte(m.Groups[6].Value,16),
                        };
                        frames.Add(b);
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show($" Error parsing line {i}, string {s} , exception: {e.Message}");
                        return null;

                    }
                }
                ++i;
            }

            byte[,] framesArray = new byte[frames.Count, 6];
            for ( i = 0; i < frames.Count; ++i)
            {
                for (int x = 0; x < 6; ++x)
                {
                    framesArray[i, x] = frames[i][x];
                }
            }
            return (framesArray);

        }

        private void bDownloadAnimation_Click(object sender, EventArgs e)
        {
           var frames =  readAnimationList();
            tM1637.begin(Pin, Convert.ToByte(tbDioPin.Text), Convert.ToByte(tbDigits.Text), SerialWombatTM1637.SWTM1637Mode.tm1637Animation,
               serialWombatPublicDataControl1.DataSourceValue, (byte)trackBar1.Value);
            try
            {
                tM1637.writeDigitOrder(Convert.ToByte(tbOrder0.Text),
               Convert.ToByte(tbOrder1.Text),
               Convert.ToByte(tbOrder2.Text),
               Convert.ToByte(tbOrder3.Text),
               Convert.ToByte(tbOrder4.Text),
               Convert.ToByte(tbOrder5.Text)
               );
            }
            catch { }


                tM1637.writeAnimation(Convert.ToUInt16(tbUserBufferIndex.Text), 250,(byte) frames.GetLength(0), frames);
                
           
        }
    }
}