using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SerialWombatWindowsFormsLibrary
{
    public partial class SerialWombatPublicDataControl : UserControl
    {
        public SerialWombatPublicDataControl()
        {
            InitializeComponent();
            Array array = Enum.GetValues(typeof(SerialWombatDataSources));
            comboBox1.DataSource = array;
           // try
            {
                comboBox1.SelectedIndex = 0;
            }
           // catch { }


        }
        public SerialWombatDataSources DataSourceEnum
        {
            get { return ((SerialWombatDataSources)comboBox1.Items[comboBox1.SelectedIndex]); }
        }
        public byte DataSourceValue
        {
            get { return ((byte)(SerialWombatDataSources)comboBox1.Items[comboBox1.SelectedIndex]); }
            set
            {
                int i = 0;
                foreach (SerialWombatDataSources source in comboBox1.Items)
                {
                    if ((byte)source == value)
                    {
                        comboBox1.SelectedIndex = i;
                        return;
                    }
                    ++i;
                }
            }
        }
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
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

        private void SerialWombatPublicDataControl_Resize(object sender, EventArgs e)
        {
            comboBox1.Width = this.Width - Margin.Right;
        }
    }
}
