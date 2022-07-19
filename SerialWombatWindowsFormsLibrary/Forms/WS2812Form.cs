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
    public partial class WS2812Form : Form
    {
        CodeGenerationDelegate CodeGenerationDelegate;
        public WS2812Form(SerialWombatChip serialWombatChip, byte pin, CodeGenerationDelegate codeGeneration)
        {
            InitializeComponent();
            wS2812Control1.begin(serialWombatChip, pin);
            CodeGenerationDelegate = codeGeneration;
            wS2812Control1.CodeGeneration += WS2812Control1_CodeGeneration;
        }

        private void WS2812Control1_CodeGeneration(object sender, EventArgs e)
        {
            if (CodeGenerationDelegate != null)
            {
                CodeGenerationDelegate((CodeGeneratedEventArgs)e);
            }
        }


    }
}
