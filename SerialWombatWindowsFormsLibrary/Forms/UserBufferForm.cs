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
    public partial class UserBufferForm : Form
    {
        SerialWombatChip SerialWombatChip;
        public UserBufferForm(SerialWombatChip serialWombatChip)
        {
            InitializeComponent();
            this.SerialWombatChip = serialWombatChip;

            
            Text = "Serial Wombat Chip User Buffer";

            
            memoryPageEditor1.TypedChange += typedChange;

            reloadData();
        }

        void typedChange(object sender, EventArgs e)
        {
            MemoryWriteEventArgs mwea = (MemoryWriteEventArgs)e;
            byte[] b = { mwea.Value };
            SerialWombatChip.writeUserBuffer((UInt16)mwea.Address, b, 1);

        }
        private void userBufferControl1_Load(object sender, EventArgs e)
        {

        }

        void reloadData()
        {
            byte[] data = new byte[8192];
            SerialWombatChip.readUserBuffer(0, data, 8192);
            memoryPageEditor1.SetData(data);
        }
        private void bReload_Click(object sender, EventArgs e)
        {
            reloadData();
        }
    }
}
