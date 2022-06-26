using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace SerialWombatWindowsFormsLibrary
{
    public partial class TCPPortSelector : Form
    {
        public TCPPortSelector()
        {
            InitializeComponent();
        }

        public IPAddress ipAddress = null;
        public Int32 port;
        private void bOpen_Click(object sender, EventArgs e)
        {
            try
            {
                ipAddress = IPAddress.Parse(tbIP.Text);
                port = Convert.ToInt32(tbPort.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Close();
        }
    }
}
