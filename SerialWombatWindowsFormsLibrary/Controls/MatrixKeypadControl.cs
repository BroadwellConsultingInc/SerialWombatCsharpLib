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

namespace SerialWombatWindowsFormsLibrary
{ 
    public partial class MatrixKeypadControl : SerialWombatCodeGenerationControl
    {
    SerialWombatChip SerialWombatChip;
    public byte Pin;
        SerialWombatMatrixKeypad keypad;


        private delegate void SafeCallDelegate();
        public MatrixKeypadControl()
        {
            InitializeComponent();
            lmatrix = new Label[] { l1, l2, l3, lA, l4, l5, l6, lB, l7, l8, l9, lC, lStar, l0, lHash, lD };
        }

        Label[] lmatrix;
        public void begin(SerialWombatChip serialWombatChip, byte pin)
    {
        SerialWombatChip = serialWombatChip;
        Pin = pin;
            keypad = new SerialWombatMatrixKeypad(SerialWombatChip);
            groupBox1.Text = $"Pin {pin} Keypad";

            tbRow0.Text = pin.ToString();
            tbRow1.Text = (pin + 1).ToString();
            tbRow2.Text = (pin + 2).ToString();
            tbRow3.Text = (pin + 3).ToString();
            tbCol0.Text = (pin + 4).ToString();
            tbCol1.Text = (pin + 5).ToString();
            tbCol2.Text = (pin + 6).ToString();
            tbCol3.Text = (pin + 7).ToString();
        }

        private void bConfigure_Click(object sender, EventArgs e)
        {
            byte PublicDataMode = 0;


            if (rbCurrentKey.Checked)
            {
                PublicDataMode = 1;
            }
            if (rbLastKey.Checked)
            {
                PublicDataMode = 2;
            }
            if (rbAscii.Checked)
            {
                PublicDataMode = 3;
            }


            byte QueueMode = 0;
            if (rbQueueASCII.Checked)
            {
                QueueMode = 1;
            }
            keypad.begin(Pin, Convert.ToByte(tbRow0.Text),
                Convert.ToByte(tbRow1.Text),
                Convert.ToByte(tbRow2.Text),
                Convert.ToByte(tbRow3.Text),
                Convert.ToByte(tbCol0.Text),
                Convert.ToByte(tbCol1.Text),
                Convert.ToByte(tbCol2.Text),
                    Convert.ToByte(tbCol3.Text),
                    PublicDataMode,
                    QueueMode);

           

}

        private void bSetQueueMask_Click(object sender, EventArgs e)
        {
            keypad.writeQueueMask(Convert.ToUInt16(tbMask.Text, 16));
           
            
            }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbAutosample.Checked)
            {
                Thread t = new Thread(SampleThread);
                t.Start();          
            }

        }

        void update()
        { 

         if (l0.InvokeRequired)
            {
                var d = new SafeCallDelegate(update);
        l0.Invoke(d, new object[] { });
            }
            else
{
                UInt16 publicData = keypad.readPublicData();

                if (rbBitmap.Checked)
                {
                    for (int i = 0; i < 16; ++i)
                    {
                        if ((publicData & (1<<i)) > 0)
                        {
                            lmatrix[i].BackColor = Color.LightGreen;
                        }
                        else
                        {
                            lmatrix[i].BackColor = DefaultBackColor;
                        }
                    }
                }
                if (rbLastKey.Checked || rbCurrentKey.Checked)
                {
                    for (int i = 0; i < 16; ++i)
                    {
                        if (publicData == i)
                        {
                            lmatrix[i].BackColor = Color.LightGreen;
                        }
                        else
                        {
                            lmatrix[i].BackColor = DefaultBackColor;
                        }
                    }
                }

                int k = keypad.read();
                while (k >= 0)
                {
                    if (rbQueueASCII.Checked)
                    {
                        textBox1.AppendText($"{(char)k} ");
                    }
                    else
                    {
                        textBox1.AppendText($"{k} ");
                    }
                    k = keypad.read();
                }
            
            }
        }
        public void end()
        {
            ckbAutosample.Checked = false;
        }

void SampleThread()
        {
            while (ckbAutosample.Checked)
            {
                update();
                Thread.Sleep(100);
            }


        }

        private void bGenCodeConfigure_Click(object sender, EventArgs e)
        {
            byte PublicDataMode = 0;


            if (rbCurrentKey.Checked)
            {
                PublicDataMode = 1;
            }
            if (rbLastKey.Checked)
            {
                PublicDataMode = 2;
            }
            if (rbAscii.Checked)
            {
                PublicDataMode = 3;
            }


            byte QueueMode = 0;
            if (rbQueueASCII.Checked)
            {
                QueueMode = 1;
            }


            string s =
            @$"
                //Put this line before setup()
                SerialWombatMatrixKeypad {Name}(sw); // Your serial wombat chip may be named something else than sw
                //Add this line to  setup():
                                {Name}.begin({Pin}, //Control pin
                {Convert.ToByte(tbRow0.Text)}, //Row 0 pin
                {Convert.ToByte(tbRow1.Text)}, // Row 1 pin
                {Convert.ToByte(tbRow2.Text)}, // Row 2 pin
                {Convert.ToByte(tbRow3.Text)}, // Row 3 pin
                {Convert.ToByte(tbCol0.Text)}, // Col 0 pin
                {Convert.ToByte(tbCol1.Text)}, // Col 1 pin
                {Convert.ToByte(tbCol2.Text)}, // Col 2 pin
                    {Convert.ToByte(tbCol3.Text)}, // Col 3 pin
                    {PublicDataMode},  //Public data mode
                    {QueueMode}); //Queue Mode
";
            Clipboard.SetText(s);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s =
            @$"
                //Add this line to  setup():
                {Name}.writeQueueMask(0x{Convert.ToUInt16(tbMask.Text, 16):X4});
";
            Clipboard.SetText(s);
        }
    }
}
