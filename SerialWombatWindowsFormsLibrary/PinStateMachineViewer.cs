using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using SerialWombat;

namespace SerialWombatWindowsFormsLibrary
{
    public partial class PinStateMachineViewer : Form
    {
        public List<VariableType> CoreVariableTypes = new List<VariableType>();
        public List<VariableControl> VariableControls = new List<VariableControl>();
        SerialWombatChip _sw;
        byte _pin;
        public PinStateMachineViewer(SerialWombatChip serialWombatChip, byte pin)
        {
            InitializeComponent();
            _sw = serialWombatChip;
            _pin = pin;

            CoreVariableTypes = new List<VariableType>() {
           new VariableType { cType = "uint32_t",lengthInBytes = 4,signed = false, CSharpType = typeof(UInt32)},
           new VariableType { cType = "int32_t",lengthInBytes = 4,signed = true, CSharpType = typeof(Int32)},
           new VariableType { cType = "uint16_t",lengthInBytes = 2,signed = false, CSharpType = typeof(UInt16)},
           new VariableType { cType = "int16_t",lengthInBytes = 2,signed = true, CSharpType = typeof(Int16)},
           new VariableType { cType = "uint8_t",lengthInBytes = 1,signed = false, CSharpType = typeof(Byte)},
           new VariableType { cType = "int8_t",lengthInBytes = 1,signed = true, CSharpType = typeof(char)},
            };
            tbPin.Text = pin.ToString();

        }

        private void bParse_Click(object sender, EventArgs e)
        {
            string[] lines = textBox1.Lines;
            VariableControls = new List<VariableControl>();

            Regex arrayRegex = new Regex(@"^.*\b(\w+)\s+(\w+)\s*\[\s*(\d+)\s*\]\s*;\s*(///<(?'comment'.*))?");
            Regex scalarRegex = new Regex(@"^.*\b(\w+)\s+(\w+)\s*;\s*(///<(?'comment'.*))?");
            Regex bitmapRegex = new Regex(@"^.*\b(\w+)\s+(\w+)\s*:\s*(\d+)\s*;\s*(///<(?'comment'.*))?");


            int offset = 0;
            foreach (VariableType vt in CoreVariableTypes)
            {
                vt.Regex = new Regex($"\\b{vt.cType}\\b");
            }

            VariableType lastBitmapVariable = null;
            foreach (string s in lines)
            {
                VariableType lineVariableType = null;
                foreach (VariableType vt in CoreVariableTypes)
                {
                    Match vtm = vt.Regex.Match(s);
                    if (vtm.Success)
                    {
                        lineVariableType = vt;
                    }
                }

                if (lineVariableType == null)
                {
                    continue;
                }

                VariableType currentVariable = new VariableType(lineVariableType);
                Match m = arrayRegex.Match(s);
                if (m.Success)
                {
                    //textBox2.AppendText($"{m.Groups[1].Value} {m.Groups[2].Value} {m.Groups[3].Value} {offset}" + Environment.NewLine);

                    currentVariable.name = m.Groups[2].Value;
                    currentVariable.offset = offset;
                    currentVariable.numberOfElements = Convert.ToInt32(m.Groups[3].Value);
                    lastBitmapVariable = null;
                    offset += lineVariableType.lengthInBytes * Convert.ToInt32(m.Groups[3].Value);
                    if (m.Groups["comment"] != null)
                    {
                        currentVariable.comment = m.Groups["comment"].Value;
                    }
                }

                m = scalarRegex.Match(s);
                if (m.Success)
                {
                    //textBox2.AppendText( $"{m.Groups[1].Value} {m.Groups[2].Value} {offset}" + Environment.NewLine);

                    currentVariable.name = m.Groups[2].Value;
                    currentVariable.offset = offset;
                    offset += lineVariableType.lengthInBytes;
                    lastBitmapVariable = null;
                    if (m.Groups["comment"] != null)
                    {
                        currentVariable.comment = m.Groups["comment"].Value;
                    }
                }

                m = bitmapRegex.Match(s);
                if (m.Success)
                {
                    currentVariable.name = m.Groups[2].Value;
                    int bitsRemaining = lineVariableType.lengthInBytes * 8;
                    int shift = 0;
                    if (lastBitmapVariable != null)
                    {
                        bitsRemaining = lastBitmapVariable.lengthInBytes * 8 - (lastBitmapVariable.bitfieldShift + lastBitmapVariable.bitfieldLength);
                        shift = lastBitmapVariable.bitfieldShift + lastBitmapVariable.bitfieldLength;
                    }

                    int bits = Convert.ToInt32(m.Groups[3].Value);
                    if (bitsRemaining >= bits)
                    {
                        currentVariable.bitfieldShift = shift;
                        currentVariable.bitfieldLength = bits;

                    }
                    else
                    {
                        offset += lineVariableType.lengthInBytes;
                        currentVariable.bitfieldShift = 0;
                        currentVariable.bitfieldLength = bits;

                    }
                    currentVariable.offset = offset;
                    lastBitmapVariable = currentVariable;
                    if (m.Groups["comment"] != null)
                    {
                        currentVariable.comment = m.Groups["comment"].Value;
                    }
                    //textBox2.AppendText($"{m.Groups[1].Value} {m.Groups[2].Value} {offset}, <<{currentVariable.bitfieldShift} : {currentVariable.bitfieldLength} " + Environment.NewLine);
                }

                VariableControl vc = new VariableControl(currentVariable);
                if (groupBox1.Controls.Count > 0)
                {



                    vc.Top = groupBox1.Controls[groupBox1.Controls.Count - 1].Top + (groupBox1.Controls[groupBox1.Controls.Count - 1].Height + 15);
                    vc.Left = groupBox1.Controls[groupBox1.Controls.Count - 1].Left;

                    if ((groupBox1.Controls.Count % 5) == 0)
                    {
                        vc.Top = groupBox1.Controls[0].Top;
                        vc.Left = groupBox1.Controls[groupBox1.Controls.Count - 5].Right + 15;
                    }
                }
                groupBox1.Controls.Add(vc);
                VariableControls.Add(vc);
                groupBox1.Refresh();


            }
        }

        private void bRead_Click(object sender, EventArgs e)
        {
            byte[] data;

            data = _sw.readPinStateMachineBytes(Convert.ToByte(tbPin.Text), 64);
       

            foreach (var vc in VariableControls)
            {
                for (int i = 0; i < vc.tb.Count; ++i)
                {
                    int value = data[vc.vt.offset + i * vc.vt.lengthInBytes];
                    for (int v = 1; v < vc.vt.lengthInBytes; ++v)
                    {
                        value += data[vc.vt.offset + i * vc.vt.lengthInBytes + v] << (8 * v);
                    }

                    value >>= vc.vt.bitfieldShift;
                    if (vc.vt.bitfieldLength > 0)
                    {
                        int mask = 0;
                        for (int m = 0; m < vc.vt.bitfieldLength; ++m)
                        {
                            mask |= 1 << m;
                        }

                        value &= mask;
                    }


                    vc.tb[i].Text = $"0x{value:X2}";
                }
            }

            tbMode.Text = data[data.Length - 2].ToString();
            tbPublicData.Text = (data[data.Length - 3] * 256 + data[data.Length - 4]).ToString();
        }
    }


    public class VariableType
    {

        public VariableType()
        {
        }

        public VariableType(VariableType vt)
        {
            cType = vt.cType;
            lengthInBytes = vt.lengthInBytes;
            signed = vt.signed;
            CSharpType = vt.CSharpType;
            Regex = vt.Regex;
            name = vt.name;
            description = vt.description;
            bitfieldLength = vt.bitfieldLength;
            bitfieldShift = vt.bitfieldShift;
            offset = vt.offset;
            numberOfElements = vt.numberOfElements;
            comment = vt.comment;
        }
        public string cType;
        public int lengthInBytes;
        public bool signed;
        public Type CSharpType;
        public Regex Regex;
        public string name = "";
        public string description = "";
        public int bitfieldLength = 0;
        public int bitfieldShift = 0;
        public int offset = 0;
        public int numberOfElements = 1;
        public string comment = "";
    }

    public class VariableControl : GroupBox
    {
        public Button bRead;
        public Button bWrite;
        public List<TextBox> tb = new List<TextBox>();
        public Label lHex;
        public VariableType vt;

        ToolTip tt = new ToolTip();
        public VariableControl(VariableType variableType) : base()
        {

            vt = variableType;
            if (vt.numberOfElements > 1)
            {
                this.Text = $"{vt.name}   {vt.cType.ToString()} ({vt.offset} - {vt.numberOfElements + vt.offset - 1})";
            }
            else if (vt.bitfieldLength > 0)
            {
                this.Text = $"{vt.name}  {vt.cType.ToString()} ({vt.offset}) :({vt.bitfieldLength} <<{vt.bitfieldShift}) ";
            }
            else
            {
                this.Text = $"{vt.name}  {vt.cType.ToString()} ({vt.offset}) ";
            }

            this.Padding = new Padding(5, 20, 5, 5);
            this.Margin = Padding.Empty;
            for (int i = 0; i < vt.numberOfElements; ++i)
            {
                TextBox newTB;
                newTB = new TextBox();
                newTB.Top = this.Padding.Top + i * newTB.Height;
                newTB.Left = this.Padding.Left;
                this.Controls.Add(newTB);
                tb.Add(newTB);
                newTB.Text = "0";
                if (vt.comment != "")
                {
                    tt.SetToolTip(newTB, $"{vt.comment}");
                }


                lHex = new Label();
                lHex.Top = newTB.Bottom + this.Padding.Bottom;
                lHex.Left = newTB.Left;
                lHex.Text = "0x00";

                this.Controls.Add(lHex);
                lHex.Visible = vt.numberOfElements == 1;  // Hide for arrays

            }


            bRead = new Button();
            bRead.Text = "Read";
            bRead.Top = tb[0].Top;
            bRead.Left = tb[0].Right + this.Padding.Right;
            this.Controls.Add(bRead);

            bWrite = new Button();
            bWrite.Text = "Write";
            bWrite.Top = bRead.Bottom + this.Padding.Bottom;
            bWrite.Left = bRead.Left;
            this.Controls.Add(bWrite);


            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;


        }
    }
}
