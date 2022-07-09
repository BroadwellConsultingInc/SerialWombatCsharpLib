using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.Design;
using System.Windows.Forms;
using SerialWombat;

namespace SerialWombatWindowsFormsLibrary
{
    public partial class UserBufferControl : UserControl
    {
        private System.ComponentModel.Design.ByteViewer byteviewer;
        public SerialWombatChip SerialWombatChip;
        byte[] data = new byte[1024];
        public UserBufferControl()
        {
            InitializeComponent();
            byteviewer = new ByteViewer();
            byteviewer.Location = new Point(8, 46);
            byteviewer.AutoSize = false;
            byteviewer.Size = new Size(600, 338);
            byteviewer.Anchor = AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top;
            byteviewer.SetBytes(new byte[] { });
            this.Controls.Add(byteviewer);

        }

        public void begin(SerialWombatChip serialWombatChip)
        {
            this.SerialWombatChip = serialWombatChip;

            SerialWombatChip.readUserBuffer(0, data, (UInt16) data.Length);
            byteviewer.SetBytes(data);
        }

        private void bRefresh_Click(object sender, EventArgs e)
        {
            SerialWombatChip.readUserBuffer(0, data, (UInt16)data.Length);
            byteviewer.SetBytes(data);
        }
    }
}
