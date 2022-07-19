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
        CodeGenerationDelegate CodeGenerationDelegate;

        public TM1637Form(SerialWombatChip serialWombatChip, byte pin, CodeGenerationDelegate codeGenerationDelegate = null)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterParent;
            this.SerialWombatChip = serialWombatChip;
            this.Pin = pin;
            this.Text = $"Pin {pin} TM1637";
            CodeGenerationDelegate = codeGenerationDelegate;
            tM1637Control1.CodeGeneration += TM1637Control1_CodeGeneration;
        }

        private void TM1637Control1_CodeGeneration(object sender, EventArgs e)
        {
            if (CodeGenerationDelegate != null)
            {
                CodeGenerationDelegate((CodeGeneratedEventArgs)e);
            }
        }

        private void TM1637Form_Load(object sender, EventArgs e)
        {
            tM1637Control1.begin(SerialWombatChip,Pin);
        }

       
    }
}
