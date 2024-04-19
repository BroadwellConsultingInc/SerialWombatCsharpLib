using ScottPlot;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerialWombatWindowsFormsLibrary.Controls
{
    public partial class PinHighLowInputControl : UserControl
    {
        public PinHighLowInputControl()
        {
            InitializeComponent();
            comboBox1.SelectedIndex= 0;
        }


        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public byte Value
        {
            get {
                try
                {
                    return ((byte)comboBox1.SelectedIndex);
                }
                catch { return 0; }
                
                    }
            set
            {
                try
                {
                    comboBox1.SelectedIndex = value;
                }
                catch{ }
            }
        }

        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public bool inputOption
        {
            get { return comboBox1.Items.Count > 2; }
            set { if (value && comboBox1.Items.Count < 3)
                {
                    comboBox1.Items.Add("Input");
                }
            else { if (!value && comboBox1.Items.Count > 2)
                    {
                        comboBox1.Items.RemoveAt(2);
                    }
                }
            }
        }

        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string Text
        {
            get { return label1.Text; }
            set
            {
                label1.Text = value;
            }
        }

        private bool ShouldSerializeText() =>
    label1.Text != "Name";
    }

    
}
