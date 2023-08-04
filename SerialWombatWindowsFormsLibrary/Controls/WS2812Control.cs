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

    public partial class WS2812Control : SerialWombatCodeGenerationControl
    {
        Label[] labelArray;
        int labelArrayLength = 128;
        SerialWombatChip SerialWombatChip;
        Byte Pin;
        SerialWombatWS2812 Ws2812;
        public WS2812Control()
        {
            InitializeComponent();
        }

       
        public void begin(SerialWombatChip serialWombatChip, byte pin)
        {
            SerialWombatChip = serialWombatChip;
            Pin = pin;
            Ws2812 = new SerialWombatWS2812(serialWombatChip);
        }
        private void nudNumberOfLEDs_ValueChanged(object sender, EventArgs e)
        {

        }

        private void WS2812Control_Load(object sender, EventArgs e)
        {
            labelArray = new Label[labelArrayLength];
            for (int y = 0; y < 8; ++y)
            {
                for (int x = 0; x < 16; ++x)
                {
                    Label l = new Label();
                    l.AutoSize = false;
                    l.Width = 31;
                    l.Height = 31;
                    l.BackColor = Color.Black;
                    l.Top = 15 + y * 32;
                    l.Left = 15 + x * 32;
                    l.ForeColor = Color.White;
                    labelArray[y * 16 + x] = l;
                    l.DoubleClick += LSetColor_DoubleClick;
                    gbSetColor.Controls.Add(l);


                }
            }


        }

        private void LSetColor_DoubleClick(object sender, EventArgs e)
        {
            int ledNum = -1;
            for (int i = 0; i < labelArray.Length; ++i)
            {
                if ((Label)sender == labelArray[i])
                {
                    ledNum = i;
                }
            }
            if (ledNum >= 0)
            {
                if (colorDialog1.ShowDialog() == DialogResult.OK)
                {
               
                    Color outputColor = colorDialog1.Color;
                    if (ckbDivsor.Checked)
                    {
                        outputColor = Color.FromArgb(255, outputColor.R / 8, outputColor.G / 8, outputColor.B / 8);
                    }
                    Ws2812.write((byte)ledNum, outputColor);
                    CodeGenerated(CodeGenerationPlatform.CSharp,
               $@"  // Write LED color

           Ws2812.write({(byte)ledNum}, // LED Number
               Color.fromARGB(255,{outputColor.R},{outputColor.G},{outputColor.B} ));
");

                    ((Label)sender).BackColor = colorDialog1.Color;

                    if (colorDialog1.Color.R < 16 && colorDialog1.Color.G < 16 && colorDialog1.Color.B < 16)
                    {
                        ((Label)sender).ForeColor = Color.White;
                    }
                    else
                    {
                        ((Label)sender).ForeColor = Color.Black;
                    }
                    
                }
            }
        }

        private void bConfig_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < labelArrayLength; ++i)
            {
                labelArray[i].Visible = i < nudNumberOfLEDs.Value;
            }
            Ws2812.begin(Pin, (byte)nudNumberOfLEDs.Value, sbacUserBufferAddress.Value);
            
            CodeGenerated(CodeGenerationPlatform.CSharp,
               $@"  // Initialize WS2812
            SerialWombatWS2812 Ws2812 = new SerialWombatWS2812(serialWombatChip);
            Ws2812.begin({Pin},  //Pin Number
             {(byte)nudNumberOfLEDs.Value} , // Number of LEDs
                {sbacUserBufferAddress.Text} // Buffer Index
                );
");
            Int16 memoryUse = Ws2812.readBufferSize();
            sbacAnimationIndex.Value = (UInt16)(memoryUse + 16);
        }

        private void bBGConfigure_Click(object sender, EventArgs e)
        {
            if (labelArray[0].BackColor.ToArgb() == labelArray[1].BackColor.ToArgb())
            {
                MessageBox.Show("Set the first and second boxes in the Write LED area to different colors.");
                return;
            }
            Ws2812.barGraph(serialWombatPublicDataControl1.DataSourceValue, labelArray[0].BackColor, labelArray[1].BackColor, sbsiMin.value, sbsiMax.value);

            CodeGenerated(CodeGenerationPlatform.CSharp,
              $@"  // Configure WS2812 BarGraph

            Ws2812.barGraph({serialWombatPublicDataControl1.DataSourceValue}, // Data Source
            Color.fromARGB(255,{labelArray[0].BackColor.R},{labelArray[0].BackColor.G},{labelArray[0].BackColor.B}), // Off Color 
            Color.fromARGB(255,{labelArray[1].BackColor.R},{labelArray[1].BackColor.G},{labelArray[1].BackColor.B}), // On Color 
             {sbsiMin.value}, // Minimum Value
            {sbsiMax.value});  // Maximum value
               
");
        }

        private void bConfigAnimation_Click(object sender, EventArgs e)
        {
            Ws2812.writeAnimationUserBufferIndex(sbacAnimationIndex.Value, (byte)nudTotalFrames.Value);
            CodeGenerated(CodeGenerationPlatform.CSharp,
                $@"  // Configure WS2812 Animation Index and # of frames

                  Ws2812.writeAnimationUserBufferIndex(
                0x{sbacAnimationIndex.Value:X4}, //Index
                {(byte)nudTotalFrames.Value}); // Number of frames
               
");

        }

        private void bWriteAnimationFrame_Click(object sender, EventArgs e)
        {
            Color[] colors = new Color[(int)nudNumberOfLEDs.Value];
            int i = 0;

            string Codegen = $"Color[] colors = new Color[] {{" + Environment.NewLine;
            foreach (Label l in labelArray)
            {
                if (ckbDivsor.Checked)
                {
                    colors[i] = Color.FromArgb(255, l.BackColor.R / 8, l.BackColor.G / 8, l.BackColor.B / 8);
                }
                else
                {
                    colors[i] = l.BackColor;
                }
                Codegen += $" Color.FromArgb(255,{colors[i].R},{colors[i].G},{colors[i].B})," + Environment.NewLine;
                ++i;
                if (i == nudNumberOfLEDs.Value)
                {
                    break;
                }
            }
            Codegen += "};" + Environment.NewLine;

            Ws2812.writeAnimationFrame((byte)nudFrameToWrite.Value, colors);

            Codegen += @$"
                Ws2812.writeAnimationFrame({(byte)nudFrameToWrite.Value}, colors); 
            ";

            Ws2812.writeAnimationFrameDelay((byte)nudFrameToWrite.Value, Convert.ToUInt16(tbDelay.Text));

            Codegen += @$"
                Ws2812.writeAnimationFrameDelay({(byte)nudFrameToWrite.Value},//Frame Index
                {Convert.ToUInt16(tbDelay.Text)});  // Delay in mS
            ";

            CodeGenerated(CodeGenerationPlatform.CSharp, Codegen);
        }

        private void bAnimationStart_Click(object sender, EventArgs e)
        {
            Ws2812.writeMode(SWWS2812Mode.ws2812ModeAnimation);

            CodeGenerated(CodeGenerationPlatform.CSharp,
                @" // Start Animation
Ws2812.writeMode(SWWS2812Mode.ws2812ModeAnimation);
");
        }

        private void bTestSequence_Click(object sender, EventArgs e)
        {
            Ws2812.begin(Pin, (byte)nudNumberOfLEDs.Value, sbacUserBufferAddress.Value);
            Ws2812.writeMode(SWWS2812Mode.ws2812ModeChase);
            CodeGenerated(CodeGenerationPlatform.CSharp,
              $@"  // Initialize WS2812 to Test Sequence
            SerialWombatWS2812 Ws2812 = new SerialWombatWS2812(serialWombatChip);
            Ws2812.begin({Pin},  //Pin Number
             {(byte)nudNumberOfLEDs.Value} , // Number of LEDs
                {sbacUserBufferAddress.Text} // Buffer Index
                );
            Ws2812.writeMode(SWWS2812Mode.ws2812ModeChase);
");
        }
    }
}
