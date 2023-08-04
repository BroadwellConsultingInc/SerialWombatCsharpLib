using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using SerialWombat;
using SerialWombatSW18ABBootloader;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WombatPanelWindowsForms
{
    public partial class Bootload : Form
    {
        SerialWombatSW18ABBootloaderClient bl;
        private delegate void SafeCallDelegate();
        public Bootload(string filename, SerialWombatChip serialWombatChip)
        {
            InitializeComponent();
            Text = $"Bootload {filename}";

            bl = new SerialWombatSW18ABBootloaderClient(serialWombatChip); 
            bl.bootload(filename);
            Thread t = new Thread(updateThread);
            t.Start();

        }
        private String status = "";
        double pctDone = 0;

        void updateThread()
        {
            while (bl.Bootloading)
            {
                status = bl.Status;
                pctDone = bl.PercentDone;

                statusUpdate();
                progressUpdate();
                Thread.Sleep(200);
            }
        }

        void statusUpdate()
        {
            if (lStatus.InvokeRequired)
            {
                var d = new SafeCallDelegate(statusUpdate);
                lStatus.Invoke(d, new object[] { });
                return;
            }
            else
            {
                lStatus.Text = status;
            }
        }

        void progressUpdate()
        {
            if (progressBar1.InvokeRequired)
            {
                var d = new SafeCallDelegate(statusUpdate);
                progressBar1.Invoke(d, new object[] { });
                return;
            }
            else
            {
               
                int pctDonei = (int)(pctDone * 10000);
                if (pctDonei > progressBar1.Maximum)
                {
                    pctDonei = progressBar1.Maximum;
                }
                if (pctDonei < progressBar1.Minimum)
                {
                    pctDonei = progressBar1.Minimum;
                }
                progressBar1.Value = pctDonei;
            }
        }
    }
}
