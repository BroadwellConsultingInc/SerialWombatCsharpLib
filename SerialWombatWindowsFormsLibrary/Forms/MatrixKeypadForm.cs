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

        public MatrixKeypadForm(SerialWombatChip serialWombatChip, byte pin, CodeGenerationDelegate codeGenerationDelegate)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterParent;
            SerialWombatChip = serialWombatChip;
            Pin = pin;
            matrixKeypadControl1.begin(serialWombatChip, pin);
            Text = $"Pin {pin} Matrix Keypad {serialWombatChip.description}";

            matrixKeypadControl1.Name = $"Pin{pin}Keypad";
        }

  

        private void MatrixKeypadForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            matrixKeypadControl1.end();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SingleLineTextEntryForm sltef = new SingleLineTextEntryForm("Name Form", "Add a name for this form:");
            sltef.ShowDialog();
            if (sltef.Success)
            {
                this.Text = $"{sltef.outputString} Analog Measurement on pin {matrixKeypadControl1.Pin}";
                matrixKeypadControl1.Name = sltef.outputString;
               
            }
        }
    }
}
