using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

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

        public UInt16 value { get { return (Convert.ToUInt16(tbValue.Text)); }
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
    }
}
