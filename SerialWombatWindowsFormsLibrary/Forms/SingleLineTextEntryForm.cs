using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerialWombatWindowsFormsLibrary
{
    public partial class SingleLineTextEntryForm : Form
    {
        public bool Success = false;
        public string outputString = "";
        public SingleLineTextEntryForm(string title,string text)
        {
            InitializeComponent();
            label1.Text = text;
            this.Text = title;

        }

        private void bOk_Click(object sender, EventArgs e)
        {
            outputString = textBox1.Text;
            Success = true;
            Close();
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
