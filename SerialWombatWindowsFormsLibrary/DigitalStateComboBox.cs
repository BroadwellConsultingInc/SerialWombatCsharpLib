using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using SerialWombatLib;

namespace SerialWombatWindowsFormsLibrary
{
    public partial class DigitalStateComboBox : UserControl
    {
        public DigitalStateComboBox()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
        }

        public PinState PinState{
            get{
                return ((PinState)comboBox1.SelectedIndex);
            }
}
        
    }
}
