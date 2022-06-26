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
    }
}
