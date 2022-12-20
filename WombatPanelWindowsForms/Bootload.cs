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

namespace WombatPanelWindowsForms
{
    public partial class Bootload : Form
    {
        SerialWombatSW18ABBootloaderClient bl;
        public Bootload(string filename, SerialWombatChip serialWombatChip)
        {
            InitializeComponent();
            Text = $"Bootload {filename}";

            bl = new SerialWombatSW18ABBootloaderClient(serialWombatChip); 
            bl.bootload(filename);
            Thread t = new Thread(updateThread);
            t.Start();

        }

        void updateThread()
        {
            while (bl.Bootloading)
            {
                statusUpdate();
                Thread.Sleep(200);
            }
        }

        void statusUpdate()
        {
            if (InvokeRequired)
            {
                this.Invoke(new MethodInvoker(statusUpdate));
                return;
            }
            else
            {
                lStatus.Text = bl.Status;
                int pctDone = (int)(bl.PercentDone * 10000);
                if (pctDone > progressBar1.Maximum)
                {
                    pctDone = progressBar1.Maximum;
                }
                if (pctDone < progressBar1.Minimum)
                {
                    pctDone = progressBar1.Minimum;
                }
                progressBar1.Value = pctDone;
            }
        }
    }
}
