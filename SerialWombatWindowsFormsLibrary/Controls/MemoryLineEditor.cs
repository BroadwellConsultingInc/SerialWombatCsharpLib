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
    public partial class MemoryLineEditor : UserControl
    {
         UInt32 address = 0;
        Label addressLabel;
        public MemoryLineEditor()
        {
            InitializeComponent();
           addressLabel = new Label();
            addressLabel.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            addressLabel.AutoSize = true;
            addressLabel.Top = 6;
            Address = 0;
            this.Controls.Add(addressLabel);
            int x = addressLabel.Right + 5;

            for (int i = 0; i < 16; ++i)
            {
                ByteEditor b = new ByteEditor();
                ByteEditors.Add(b);
                b.Left = x;
                x = b.Right ;
                this.Controls.Add(b);
            }

            
        }
        public List<ByteEditor> ByteEditors = new List<ByteEditor>();

       
        private void MemoryLineEditor_Load(object sender, EventArgs e)
        {
            
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public UInt32 Address { get { return address; } set { address = value; addressLabel.Text = $"0x{value:X4}";
            } }
    }
}
