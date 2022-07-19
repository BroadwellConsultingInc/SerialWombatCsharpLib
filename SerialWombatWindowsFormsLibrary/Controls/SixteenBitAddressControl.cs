using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerialWombatWindowsFormsLibrary
{
    public partial class SixteenBitAddressControl : UserControl
    {
        public SixteenBitAddressControl()
        {
            InitializeComponent();
        }

        public UInt16 Value
        {
            get
            {
                if (textBox1.Text.Contains("0x") || textBox1.Text.Contains("0X"))
                {
                    return Convert.ToUInt16(textBox1.Text, 16);
                }
                else
                {
                    return Convert.ToUInt16(textBox1.Text);
                }

            }

            set { textBox1.Text = $"0x{value:X4}"; }
        }

        public override string Text
        {
            get
            {
                    return textBox1.Text;
            }

            set { textBox1.Text = value; }
        }
    }

}
