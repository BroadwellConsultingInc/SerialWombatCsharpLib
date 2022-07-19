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
    public partial class MatrixKeypadForm : Form
    {
        SerialWombatChip SerialWombatChip;
        byte Pin;

        CodeGenerationDelegate CodeGenerationDelegate;
        public MatrixKeypadForm(SerialWombatChip serialWombatChip, byte pin, CodeGenerationDelegate codeGenerationDelegate)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterParent;
            SerialWombatChip = serialWombatChip;
            Pin = pin;
            matrixKeypadControl1.begin(serialWombatChip, pin);
            Text = $"Pin {pin} Matrix Keypad";
            CodeGenerationDelegate = codeGenerationDelegate;
            matrixKeypadControl1.CodeGeneration += MatrixKeypadControl1_CodeGeneration;
        }

        private void MatrixKeypadControl1_CodeGeneration(object sender, EventArgs e)
        {
            if (CodeGenerationDelegate != null)
            {
                CodeGenerationDelegate((CodeGeneratedEventArgs) e);
            }
        }

        private void MatrixKeypadForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            matrixKeypadControl1.end();
        }
    }
}
