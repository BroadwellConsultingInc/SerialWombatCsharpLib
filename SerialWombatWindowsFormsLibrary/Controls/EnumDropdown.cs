using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SerialWombat;

namespace SerialWombatWindowsFormsLibrary
{
    public partial class EnumDropdown : UserControl
    {
        string ddtype = "Enum";
        public EnumDropdown()
        {
            InitializeComponent();
        }
        public object selectedItem { get { return comboBox1.SelectedItem; } }

        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string dropdowntype { set { ddtype = value;
           
                 System.Reflection.Assembly A = System.Reflection.Assembly.Load("SerialWombatClassLibrary");
          
            Type newtype = A.GetType(ddtype);
                Array array = Enum.GetValues(newtype);
                comboBox1.DataSource = array;
                // try
                {
                    comboBox1.SelectedIndex = 0;
                }
              
            }
            get { return ddtype; } 
        }

        [Browsable(true)]
        [Category("Action")]
        [Description("Invoked when user changes selected enum")]
        public event EventHandler SelectedEnumChanged;

        public string DropDownToolTip
        {
            get
            {
                return toolTip1.GetToolTip(comboBox1);
            }
            set
            {
                toolTip1.SetToolTip(comboBox1, value);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedEnumChanged?.Invoke(this, e);
        }

        private void EnumDropdown_Resize(object sender, EventArgs e)
        {
            comboBox1.Width = Width - Margin.Right;
        }
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public int Value { set { if (value < comboBox1.Items.Count) comboBox1.SelectedIndex = value; }
            get { return comboBox1.SelectedIndex; }
        }

    }
}
