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

    public partial class LiquidCrystalControl : SerialWombatCodeGenerationControl
    {
        SerialWombatChip SerialWombatChip;
        byte Pin;
        SerialWombatLiquidCrystal lcd;
        SerialWombatQueue serialWombatQueue;

        const int bitmapWidth = 5;
        const int bitmapHeight = 7;
        CheckBox[,] bitmapCheckboxes = new CheckBox[bitmapWidth, bitmapHeight];

        public LiquidCrystalControl()
        {
            InitializeComponent();
        }
        public void begin(SerialWombatChip serialWombatChip, byte pin)
        {
            SerialWombatChip = serialWombatChip;
            Pin = pin;
            swpdRS.begin(serialWombatChip, pin + 1);
            swpdD4.begin(serialWombatChip, pin + 2);
            swpdD5.begin(serialWombatChip, pin + 3);
            swpdD6.begin(serialWombatChip, pin + 4);
            swpdD7.begin(serialWombatChip, pin + 5);

            for (int y = 0; y < bitmapHeight; ++y)
            {
                for (int x = 0; x < bitmapWidth; ++x)
                {
                    CheckBox cb = new CheckBox();
                    cb.AutoSize = true;
                    cb.Text = "";
                    cb.Left = 20 + (10 + 5) * x;
                    cb.Top = 20 + (15 + 5) * y;
                    gbCharacterBitmap.Controls.Add(cb);
                    bitmapCheckboxes[x, y] = cb;
                }
            }


        }

        private void nudRows_ValueChanged(object sender, EventArgs e)
        {
            nudRO2.Enabled =  (nudRows.Value > 1) ;
            nudRO3.Enabled = (nudRows.Value > 1);
            nudRO4.Enabled = (nudRows.Value > 1);
        }

        private void bConfig_Click(object sender, EventArgs e)
        {
            lcd = new SerialWombatLiquidCrystal(SerialWombatChip, swpdRS.Pin, Pin, swpdD4.Pin, swpdD5.Pin, swpdD6.Pin, swpdD7.Pin);
            lcd.begin((byte)nudColumns.Value, (byte)nudRows.Value);
            gbControls.Enabled = true;

            CodeGenerated(CodeGenerationPlatform.CSharp,
                $@"
                // Configure Liquid Crystal on pin {Pin}
                SerialWombatLiquidCrystal lcd = 
                new SerialWombatLiquidCrystal(SerialWombatChip, 
                {swpdRS.Pin}, // RS Pin
                {Pin},  // E Pin
                {swpdD4.Pin},  // D4 Pin
                {swpdD5.Pin},  // D5 Pin
                {swpdD6.Pin},  // D6 Pin
                {swpdD7.Pin}); // D7 Pin
            lcd.begin(
                {(byte)nudColumns.Value},  // Columns
             {(byte)nudRows.Value}); //Rows
             "); 
                
        }

        private void bSetRowOffsets_Click(object sender, EventArgs e)
        {
            lcd.setRowOffsets((byte)nudRO1.Value, (byte)nudRO2.Value, (byte)nudRO3.Value, (byte)nudRO4.Value);
            
            CodeGenerated(CodeGenerationPlatform.CSharp,
               $@"
                    //Configure offsets for each row (1-4)
                    lcd.setRowOffsets(
                    {(byte)nudRO1.Value},  // Row 1 offset
                    {(byte)nudRO2.Value},   //Row 2 offset
                    {(byte)nudRO3.Value},  //Row 3 offset
                    {(byte)nudRO4.Value} // Row 4 offset
                    );
");
        }

        private void bSetCursor_Click(object sender, EventArgs e)
        {
            lcd.setCursor((byte)nudSetColumn.Value,(byte) nudSetRow.Value);


            CodeGenerated(CodeGenerationPlatform.CSharp,
               $@"
                    //Set LED Cursor Location
                    lcd.setCursor(
                        {(byte)nudSetColumn.Value}, //Column
                        {(byte) nudSetRow.Value}); // Row
");
        }

        private void bWrite_Click(object sender, EventArgs e)
        {
            byte[] b = Encoding.ASCII.GetBytes(tbWrite.Text);
            lcd.write(b, b.Count());

            CodeGenerated(CodeGenerationPlatform.CSharp,
               $@"
            byte[] b = Encoding.ASCII.GetBytes(""{tbWrite.Text}"");
            lcd.write(b, b.Count());
");

        }

        private void bClear_Click(object sender, EventArgs e)
        {
            lcd.clear(false);


            CodeGenerated(CodeGenerationPlatform.CSharp,
               $@"
            // Clear display
            lcd.clear(false);
");
        }

        private void bHome_Click(object sender, EventArgs e)
        {
            lcd.home(false);

            CodeGenerated(CodeGenerationPlatform.CSharp,
               $@"
            // Display Home
            lcd.home(false);
");

        }

        private void nudColumns_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ckbDisplayOff_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbDisplayOff.Checked)
            {
                lcd.noDisplay();
                CodeGenerated(CodeGenerationPlatform.CSharp,
                   $@"
            /// Display Off
                lcd.noDisplay();
");
            }
            else
            {
                lcd.display();
                CodeGenerated(CodeGenerationPlatform.CSharp,
                   $@"
            // Display On
            lcd.display();
");
            }
        }

        private void ckbScrollRight_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbScrollRight.Checked)
            {
                lcd.scrollDisplayRight();
                CodeGenerated(CodeGenerationPlatform.CSharp,
           $@"
           lcd.scrollDisplayRight();
");

            }
            else
            {
                lcd.scrollDisplayLeft();

                CodeGenerated(CodeGenerationPlatform.CSharp,
               $@"
           lcd.scrollDisplayLeft();
");
            }
        }

        private void bSetBufferIndex_Click(object sender, EventArgs e)
        {
             serialWombatQueue = new SerialWombatQueue(SerialWombatChip);
            serialWombatQueue.begin(sbacBufferIndex.Value, (UInt16)(nudColumns.Value * nudRows.Value), SerialWombatQueueType.QUEUE_TYPE_RAM_BYTE_SHIFT);
            lcd.initializeBufferCopy((UInt16)(sbacBufferIndex.Value + 8), (byte) nudColumns.Value);
            bBufferWrite.Enabled = true;

            CodeGenerated(CodeGenerationPlatform.CSharp,
                $@"  // Configure for buffered mode

            SerialWombatQueue serialWombatQueue;
            serialWombatQueue = new SerialWombatQueue(SerialWombatChip);
            serialWombatQueue.begin({sbacBufferIndex.Value}, // Queue Index
            {(UInt16)(nudColumns.Value * nudRows.Value)},  //Total Characters
            SerialWombatQueueType.QUEUE_TYPE_RAM_BYTE_SHIFT // Shift type queue 
            )  ;
            lcd.initializeBufferCopy(
            {(UInt16)(sbacBufferIndex.Value + 8)}, // Queue Index plus 8 to get to the shift portion
            {(byte) nudColumns.Value});  // Number of columns
");
        }

        private void bBufferWrite_Click(object sender, EventArgs e)
        {
            byte[] b = Encoding.ASCII.GetBytes(tbBuffer.Text);
            serialWombatQueue.write(b.Count(),b);

            CodeGenerated(CodeGenerationPlatform.CSharp,
               $@"  // Send bytes to Queue
            byte[] b = Encoding.ASCII.GetBytes(""{tbBuffer.Text}"");
            serialWombatQueue.write(b.Count(),b);

");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte[] bm = new byte[8];

            for (int y = 0; y < bitmapHeight; y++)
            {
               
                for (int x = 0; x<bitmapWidth; ++x)
                {
                    if (bitmapCheckboxes[bitmapWidth - x - 1,y].Checked)
                    {
                        bm[y] |= (byte)(1 << x);
                    }
                }
            }

            // Send the bitmap to the LCD


            lcd.createChar((byte)nudCharIndex.Value, 
                bm);

            CodeGenerated(CodeGenerationPlatform.CSharp,
               $@"  // Send Char to LCD

            byte[] bm = {{ {bm[0]} , {bm[1]} , {bm[2]} , {bm[3]} , {bm[4]} , {bm[5]} ,{bm[6]} ,{bm[7]} }};
            lcd.createChar({(byte)nudCharIndex.Value}, 
                bm);
");
        }

        private void bCharWrite_Click(object sender, EventArgs e)
        {
            button1_Click(sender, e);
            lcd.home(true);
            lcd.write((byte)nudCharIndex.Value);
        }
    }

}
