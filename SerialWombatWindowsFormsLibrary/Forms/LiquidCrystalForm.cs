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

namespace SerialWombatWindowsFormsLibrary
{
    public partial class LiquidCrystalForm : Form
    {
        CodeGenerationDelegate CodeGenerationDelegate;
        public LiquidCrystalForm(SerialWombatChip serialWombatChip, byte pin, CodeGenerationDelegate codeGeneration)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterParent;
            liquidCrystalControl1.begin(serialWombatChip, pin);
            CodeGenerationDelegate = codeGeneration;
            liquidCrystalControl1.CodeGeneration += LiquidCrystalControl1_CodeGeneration;
            Text = $"pin {pin} Liquid Crystal {serialWombatChip.description}";
        }

        private void LiquidCrystalControl1_CodeGeneration(object sender, EventArgs e)
        {
            if (CodeGenerationDelegate != null)
            {
                CodeGenerationDelegate((CodeGeneratedEventArgs)e);
            }
        }
    }
}
