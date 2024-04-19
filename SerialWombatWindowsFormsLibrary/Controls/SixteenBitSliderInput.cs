using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SerialWombatWindowsFormsLibrary
{
    public partial class SixteenBitSliderInput : UserControl
    {

        public delegate void trackBarValueChangedDelegate(object sender, EventArgs e);
        public List<trackBarValueChangedDelegate> trackBarValueChangedDelegates = new List<trackBarValueChangedDelegate>();
        public SixteenBitSliderInput()
        {
            InitializeComponent();

        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            tbValue.Text = trackBar1.Value.ToString();
            foreach (trackBarValueChangedDelegate trackBarValueChangedDelegate in trackBarValueChangedDelegates)
            {
                trackBarValueChangedDelegate(sender, e);
            }
        }

       private UInt16 textBoxLastValue = 0;
        UInt16 getValueFromTextBox()
        {
            try
            {

                if (tbValue.Text.Contains("0x") || tbValue.Text.Contains("0X"))
                {
                    textBoxLastValue = Convert.ToUInt16(tbValue.Text, 16);
                }
                else
                {
                    textBoxLastValue = Convert.ToUInt16(tbValue.Text);
                }
            }
            catch
            { }
            if (textBoxLastValue > trackBar1.Maximum)
            {
                textBoxLastValue = (UInt16) trackBar1.Maximum;
                tbValue.Text = textBoxLastValue.ToString(); 
            }
            if (textBoxLastValue < trackBar1.Minimum)
            {
                textBoxLastValue = (UInt16)trackBar1.Minimum;
                tbValue.Text = textBoxLastValue.ToString();
            }
            return textBoxLastValue;
        }
        public UInt16 value { get { return (getValueFromTextBox()); }
            set { tbValue.Text = value.ToString();
                trackBar1.Value = value;
            }
        }
        
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always), Bindable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public override string Text
        {
            get { return groupBox1.Text; }
            set { groupBox1.Text = value; }
        }

        public string TextBoxHint
        {
            get
            {
                return toolTip1.GetToolTip(groupBox1);
            }
            set
            {
                toolTip1.SetToolTip(groupBox1, value);
            }
        }
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always), Bindable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public int Minimum
        {
            get
            {
                return trackBar1.Minimum;
            }
            set
            {
                if (value < 0 )
                {
                    return;
                }
                if (value > Maximum)
                {
                    return;
                }

                if (this.value < value)
                {
                    this.value = (UInt16)value;
                }
                trackBar1.Minimum = value;
                trackBar1.TickFrequency = (trackBar1.Maximum - trackBar1.Minimum) / 50;
            }
        }

        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always), Bindable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public int Maximum
        {
            get
            {
                return trackBar1.Maximum;
            }
            set
            {
                if (value >65535)
                {
                    value = 65535;
                }
                if (value < Minimum)
                {
                    return;
                }
                if (this.value > value)
                {
                    this.value = (UInt16)value;
                }
                trackBar1.Maximum = value;
                trackBar1.TickFrequency = (trackBar1.Maximum - trackBar1.Minimum) / 50;
            }
        }

        private void tbValue_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                trackBar1.Value = getValueFromTextBox();
                foreach (trackBarValueChangedDelegate trackBarValueChangedDelegate in trackBarValueChangedDelegates)
                {
                    trackBarValueChangedDelegate(trackBar1,null);
                }
            }
        }

        public void ValueChangeEvent()
        {
            foreach (trackBarValueChangedDelegate trackBarValueChangedDelegate in trackBarValueChangedDelegates)
            {
                trackBarValueChangedDelegate(trackBar1, null);
            }
        }

        private void SixteenBitSliderInput_Resize(object sender, EventArgs e)
        {
            groupBox1.Width = this.Width - Margin.Horizontal;
            trackBar1.Width = groupBox1.Width - Margin.Horizontal - trackBar1.Left;
           
        }

        private void tbValue_Leave(object sender, EventArgs e)
        {
            trackBar1.Value = getValueFromTextBox();
            foreach (trackBarValueChangedDelegate trackBarValueChangedDelegate in trackBarValueChangedDelegates)
            {
                trackBarValueChangedDelegate(trackBar1, null);
            }
        }
    }
}
