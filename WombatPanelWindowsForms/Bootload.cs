using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using SerialWombat;
using SerialWombatSW18ABBootloader;
using SerialWombatSW08BBootloader;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WombatPanelWindowsForms
{
    public partial class Bootload : Form
    {
        SerialWombatSW18ABBootloaderClient bl18 = null;
        SerialWombatSW08BBootloaderClient bl08 = null;

        private delegate void SafeCallDelegate();

        public bool alreadyInBoot = false;
        public Bootload(string filename, SerialWombatChip serialWombatChip, bool resetBeforeLoading = true)
        {
            InitializeComponent();
            Text = $"Bootload {filename}";

            if (serialWombatChip.isSW18())
            {
                bl18 = new SerialWombatSW18ABBootloaderClient(serialWombatChip);
                bl18.bootload(filename, resetBeforeLoading);
            }
            else if (serialWombatChip.isSW08())

            {
                bl08 = new SerialWombatSW08BBootloaderClient(serialWombatChip);
                bl08.bootload(filename, resetBeforeLoading);
            }           

        }

        public Bootload(StreamReader reader, SerialWombatChip serialWombatChip, bool resetBeforeLoading = true)
        {
            InitializeComponent();
            Text = $"Bootload latest";
            if (serialWombatChip.isSW18())
            {
                bl18 = new SerialWombatSW18ABBootloaderClient(serialWombatChip);
                bl18.bootload(reader, resetBeforeLoading);
            }
            else if (serialWombatChip.isSW08())
            {
                bl08 = new SerialWombatSW08BBootloaderClient(serialWombatChip);
                bl08.bootload(reader, resetBeforeLoading);
            }


        }
        private String status = "";
        double pctDone = 0;

        void updateThread()
        {
            if (bl18 != null)
            {
                while (bl18.Bootloading)
                {
                    status = bl18.Status;
                    pctDone = bl18.PercentDone;

                    statusUpdate();
                    progressUpdate();
                    Thread.Sleep(200);
                }
            }
            else if (bl08!= null)
                while (bl08.Bootloading)
                {
                    status = bl08.Status;
                    pctDone = bl08.PercentDone;

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

        private void Bootload_Load(object sender, EventArgs e)
        {
            Thread t = new Thread(updateThread);
            t.Start();
        }
    }
}
