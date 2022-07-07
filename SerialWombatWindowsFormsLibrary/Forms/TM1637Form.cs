using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SerialWombat;
using SerialWombatWindowsFormsLibrary;

namespace SerialWombatWindowsFormsLibrary
{
    public partial class TM1637Form : Form
    {
        SerialWombatChip SerialWombatChip;
        byte Pin;

        public TM1637Form(SerialWombatChip serialWombatChip, byte pin)
        {
            InitializeComponent();
            this.SerialWombatChip = serialWombatChip;
            this.Pin = pin;
            this.Text = $"Pin {pin} TM1637";
        }

        private void TM1637Form_Load(object sender, EventArgs e)
        {
            tM1637Control1.begin(SerialWombatChip,Pin);
        }

       
    }
}
