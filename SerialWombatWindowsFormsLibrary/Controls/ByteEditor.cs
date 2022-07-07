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
    public partial class ByteEditor : UserControl
    {
        SerialWombatChip SerialWombatChip;
        public ByteEditor next = null;
        public UInt32 address = 0;
        byte bytevalue = 0;
        bool dirty = false;
        public ByteEditor()
        {
            InitializeComponent();

        }

        public void begin(SerialWombatChip serialWombatChip)
        {
            SerialWombatChip = serialWombatChip;
        }

        void updateTextbox()
        {
            textBox1.Text = Value.ToString();
        }
        public byte Value { get { return bytevalue; }
            
            set { 
                bytevalue = value;  
                updateTextbox();
                dirty = false;
            }
        } 

        public void AddMenuStrip( string s, EventHandler e)
        {

            contextMenuStrip1.Items.Add(s, null, e);


        }


        public EventHandler onTypedChange;

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (dirty)
            {
                bytevalue = Convert.ToByte(textBox1.Text); 
                onTypedChange?.Invoke(this, EventArgs.Empty);
                dirty = false; 
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            dirty = true;
        }
    }

}
