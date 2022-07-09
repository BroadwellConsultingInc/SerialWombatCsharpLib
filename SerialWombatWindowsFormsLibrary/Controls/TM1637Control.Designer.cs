namespace SerialWombatWindowsFormsLibrary
{
    partial class TM1637Control
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbDioPin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gbAnimation = new System.Windows.Forms.GroupBox();
            this.bDownloadAnimation = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tbAnimationFrames = new System.Windows.Forms.TextBox();
            this.tbUserBufferIndex = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.serialWombatPublicDataControl1 = new SerialWombatWindowsFormsLibrary.SerialWombatPublicDataControl();
            this.bPinDataDecimal = new System.Windows.Forms.Button();
            this.bPinDataHex = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbDigits = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.bConfigure = new System.Windows.Forms.Button();
            this.bShowAnimation = new System.Windows.Forms.Button();
            this.bWriteRaw = new System.Windows.Forms.Button();
            this.sevenSegmentControl6 = new SerialWombatWindowsFormsLibrary.SevenSegmentControl();
            this.sevenSegmentControl5 = new SerialWombatWindowsFormsLibrary.SevenSegmentControl();
            this.sevenSegmentControl4 = new SerialWombatWindowsFormsLibrary.SevenSegmentControl();
            this.sevenSegmentControl3 = new SerialWombatWindowsFormsLibrary.SevenSegmentControl();
            this.sevenSegmentControl2 = new SerialWombatWindowsFormsLibrary.SevenSegmentControl();
            this.ckbSurpressZeros = new System.Windows.Forms.CheckBox();
            this.sevenSegmentControl1 = new SerialWombatWindowsFormsLibrary.SevenSegmentControl();
            this.ckbBlink5 = new System.Windows.Forms.CheckBox();
            this.ckbDec5 = new System.Windows.Forms.CheckBox();
            this.ckbBlink4 = new System.Windows.Forms.CheckBox();
            this.ckbDec4 = new System.Windows.Forms.CheckBox();
            this.ckbBlink3 = new System.Windows.Forms.CheckBox();
            this.ckbDec3 = new System.Windows.Forms.CheckBox();
            this.ckbBlink2 = new System.Windows.Forms.CheckBox();
            this.ckbDec2 = new System.Windows.Forms.CheckBox();
            this.ckbBlink1 = new System.Windows.Forms.CheckBox();
            this.ckbDec1 = new System.Windows.Forms.CheckBox();
            this.ckbBlink0 = new System.Windows.Forms.CheckBox();
            this.ckbDec0 = new System.Windows.Forms.CheckBox();
            this.tbOrder5 = new System.Windows.Forms.TextBox();
            this.tbOrder4 = new System.Windows.Forms.TextBox();
            this.tbOrder3 = new System.Windows.Forms.TextBox();
            this.tbOrder2 = new System.Windows.Forms.TextBox();
            this.tbOrder1 = new System.Windows.Forms.TextBox();
            this.tbArray = new System.Windows.Forms.TextBox();
            this.tbOrder0 = new System.Windows.Forms.TextBox();
            this.bWriteBlinkBitmap = new System.Windows.Forms.Button();
            this.bWriteDecimals = new System.Windows.Forms.Button();
            this.bWriteArray = new System.Windows.Forms.Button();
            this.bWriteDigitOrder = new System.Windows.Forms.Button();
            this.bAddToAnimation = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.gbAnimation.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbDioPin
            // 
            this.tbDioPin.Location = new System.Drawing.Point(68, 22);
            this.tbDioPin.Name = "tbDioPin";
            this.tbDioPin.Size = new System.Drawing.Size(100, 23);
            this.tbDioPin.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "DIOpin:";
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.gbAnimation);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.bShowAnimation);
            this.groupBox1.Controls.Add(this.bWriteRaw);
            this.groupBox1.Controls.Add(this.sevenSegmentControl6);
            this.groupBox1.Controls.Add(this.sevenSegmentControl5);
            this.groupBox1.Controls.Add(this.sevenSegmentControl4);
            this.groupBox1.Controls.Add(this.sevenSegmentControl3);
            this.groupBox1.Controls.Add(this.sevenSegmentControl2);
            this.groupBox1.Controls.Add(this.ckbSurpressZeros);
            this.groupBox1.Controls.Add(this.sevenSegmentControl1);
            this.groupBox1.Controls.Add(this.ckbBlink5);
            this.groupBox1.Controls.Add(this.ckbDec5);
            this.groupBox1.Controls.Add(this.ckbBlink4);
            this.groupBox1.Controls.Add(this.ckbDec4);
            this.groupBox1.Controls.Add(this.ckbBlink3);
            this.groupBox1.Controls.Add(this.ckbDec3);
            this.groupBox1.Controls.Add(this.ckbBlink2);
            this.groupBox1.Controls.Add(this.ckbDec2);
            this.groupBox1.Controls.Add(this.ckbBlink1);
            this.groupBox1.Controls.Add(this.ckbDec1);
            this.groupBox1.Controls.Add(this.ckbBlink0);
            this.groupBox1.Controls.Add(this.ckbDec0);
            this.groupBox1.Controls.Add(this.tbOrder5);
            this.groupBox1.Controls.Add(this.tbOrder4);
            this.groupBox1.Controls.Add(this.tbOrder3);
            this.groupBox1.Controls.Add(this.tbOrder2);
            this.groupBox1.Controls.Add(this.tbOrder1);
            this.groupBox1.Controls.Add(this.tbArray);
            this.groupBox1.Controls.Add(this.tbOrder0);
            this.groupBox1.Controls.Add(this.bWriteBlinkBitmap);
            this.groupBox1.Controls.Add(this.bWriteDecimals);
            this.groupBox1.Controls.Add(this.bWriteArray);
            this.groupBox1.Controls.Add(this.bWriteDigitOrder);
            this.groupBox1.Location = new System.Drawing.Point(0, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(748, 630);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // gbAnimation
            // 
            this.gbAnimation.AutoSize = true;
            this.gbAnimation.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbAnimation.Controls.Add(this.bAddToAnimation);
            this.gbAnimation.Controls.Add(this.bDownloadAnimation);
            this.gbAnimation.Controls.Add(this.label5);
            this.gbAnimation.Controls.Add(this.tbAnimationFrames);
            this.gbAnimation.Controls.Add(this.tbUserBufferIndex);
            this.gbAnimation.Location = new System.Drawing.Point(442, 22);
            this.gbAnimation.Name = "gbAnimation";
            this.gbAnimation.Size = new System.Drawing.Size(300, 335);
            this.gbAnimation.TabIndex = 29;
            this.gbAnimation.TabStop = false;
            this.gbAnimation.Text = "Animation";
            this.gbAnimation.Visible = false;
            // 
            // bDownloadAnimation
            // 
            this.bDownloadAnimation.Location = new System.Drawing.Point(179, 290);
            this.bDownloadAnimation.Name = "bDownloadAnimation";
            this.bDownloadAnimation.Size = new System.Drawing.Size(75, 23);
            this.bDownloadAnimation.TabIndex = 30;
            this.bDownloadAnimation.Text = "Download";
            this.bDownloadAnimation.UseVisualStyleBackColor = true;
            this.bDownloadAnimation.Click += new System.EventHandler(this.bDownloadAnimation_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 15);
            this.label5.TabIndex = 26;
            this.label5.Text = "User Buffer Index:";
            // 
            // tbAnimationFrames
            // 
            this.tbAnimationFrames.Location = new System.Drawing.Point(21, 35);
            this.tbAnimationFrames.Multiline = true;
            this.tbAnimationFrames.Name = "tbAnimationFrames";
            this.tbAnimationFrames.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbAnimationFrames.Size = new System.Drawing.Size(273, 200);
            this.tbAnimationFrames.TabIndex = 0;
            // 
            // tbUserBufferIndex
            // 
            this.tbUserBufferIndex.Location = new System.Drawing.Point(154, 244);
            this.tbUserBufferIndex.Name = "tbUserBufferIndex";
            this.tbUserBufferIndex.Size = new System.Drawing.Size(100, 23);
            this.tbUserBufferIndex.TabIndex = 25;
            this.tbUserBufferIndex.Text = "0";
            // 
            // groupBox3
            // 
            this.groupBox3.AutoSize = true;
            this.groupBox3.Controls.Add(this.serialWombatPublicDataControl1);
            this.groupBox3.Controls.Add(this.bPinDataDecimal);
            this.groupBox3.Controls.Add(this.bPinDataHex);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(6, 175);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(421, 108);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // serialWombatPublicDataControl1
            // 
            this.serialWombatPublicDataControl1.DataSourceValue = ((byte)(0));
            this.serialWombatPublicDataControl1.DropDownToolTip = "";
            this.serialWombatPublicDataControl1.Location = new System.Drawing.Point(129, 22);
            this.serialWombatPublicDataControl1.Name = "serialWombatPublicDataControl1";
            this.serialWombatPublicDataControl1.Size = new System.Drawing.Size(286, 35);
            this.serialWombatPublicDataControl1.TabIndex = 4;
            // 
            // bPinDataDecimal
            // 
            this.bPinDataDecimal.Location = new System.Drawing.Point(152, 63);
            this.bPinDataDecimal.Name = "bPinDataDecimal";
            this.bPinDataDecimal.Size = new System.Drawing.Size(126, 23);
            this.bPinDataDecimal.TabIndex = 15;
            this.bPinDataDecimal.Text = "Public Data Decimal";
            this.bPinDataDecimal.UseVisualStyleBackColor = true;
            this.bPinDataDecimal.Click += new System.EventHandler(this.bPinDataDecimal_Click);
            // 
            // bPinDataHex
            // 
            this.bPinDataHex.Location = new System.Drawing.Point(19, 63);
            this.bPinDataHex.Name = "bPinDataHex";
            this.bPinDataHex.Size = new System.Drawing.Size(114, 23);
            this.bPinDataHex.TabIndex = 16;
            this.bPinDataHex.Text = "Public Data Hex";
            this.bPinDataHex.UseVisualStyleBackColor = true;
            this.bPinDataHex.Click += new System.EventHandler(this.bPinDataHex_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Data Source Pin:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.tbDioPin);
            this.groupBox2.Controls.Add(this.tbDigits);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.trackBar1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.bConfigure);
            this.groupBox2.Location = new System.Drawing.Point(11, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(416, 147);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Initialize";
            // 
            // tbDigits
            // 
            this.tbDigits.Location = new System.Drawing.Point(68, 51);
            this.tbDigits.Name = "tbDigits";
            this.tbDigits.Size = new System.Drawing.Size(100, 23);
            this.tbDigits.TabIndex = 0;
            this.tbDigits.Text = "6";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Digits:";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(114, 80);
            this.trackBar1.Maximum = 7;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(187, 45);
            this.trackBar1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Brightness:";
            // 
            // bConfigure
            // 
            this.bConfigure.Location = new System.Drawing.Point(317, 46);
            this.bConfigure.Name = "bConfigure";
            this.bConfigure.Size = new System.Drawing.Size(75, 23);
            this.bConfigure.TabIndex = 14;
            this.bConfigure.Text = "Configure";
            this.bConfigure.UseVisualStyleBackColor = true;
            this.bConfigure.Click += new System.EventHandler(this.bConfigure_Click);
            // 
            // bShowAnimation
            // 
            this.bShowAnimation.Location = new System.Drawing.Point(104, 585);
            this.bShowAnimation.Name = "bShowAnimation";
            this.bShowAnimation.Size = new System.Drawing.Size(113, 23);
            this.bShowAnimation.TabIndex = 24;
            this.bShowAnimation.Text = "Show Animation";
            this.bShowAnimation.UseVisualStyleBackColor = true;
            this.bShowAnimation.Click += new System.EventHandler(this.button1_Click);
            // 
            // bWriteRaw
            // 
            this.bWriteRaw.Location = new System.Drawing.Point(11, 585);
            this.bWriteRaw.Name = "bWriteRaw";
            this.bWriteRaw.Size = new System.Drawing.Size(75, 23);
            this.bWriteRaw.TabIndex = 23;
            this.bWriteRaw.Text = "Write Raw";
            this.bWriteRaw.UseVisualStyleBackColor = true;
            this.bWriteRaw.Click += new System.EventHandler(this.bWriteRaw_Click);
            // 
            // sevenSegmentControl6
            // 
            this.sevenSegmentControl6.AutoSize = true;
            this.sevenSegmentControl6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.sevenSegmentControl6.Location = new System.Drawing.Point(377, 466);
            this.sevenSegmentControl6.Name = "sevenSegmentControl6";
            this.sevenSegmentControl6.Size = new System.Drawing.Size(75, 113);
            this.sevenSegmentControl6.TabIndex = 22;
            this.sevenSegmentControl6.value = ((byte)(255));
            // 
            // sevenSegmentControl5
            // 
            this.sevenSegmentControl5.AutoSize = true;
            this.sevenSegmentControl5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.sevenSegmentControl5.Location = new System.Drawing.Point(302, 466);
            this.sevenSegmentControl5.Name = "sevenSegmentControl5";
            this.sevenSegmentControl5.Size = new System.Drawing.Size(75, 113);
            this.sevenSegmentControl5.TabIndex = 21;
            this.sevenSegmentControl5.value = ((byte)(255));
            // 
            // sevenSegmentControl4
            // 
            this.sevenSegmentControl4.AutoSize = true;
            this.sevenSegmentControl4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.sevenSegmentControl4.Location = new System.Drawing.Point(227, 466);
            this.sevenSegmentControl4.Name = "sevenSegmentControl4";
            this.sevenSegmentControl4.Size = new System.Drawing.Size(75, 113);
            this.sevenSegmentControl4.TabIndex = 20;
            this.sevenSegmentControl4.value = ((byte)(255));
            // 
            // sevenSegmentControl3
            // 
            this.sevenSegmentControl3.AutoSize = true;
            this.sevenSegmentControl3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.sevenSegmentControl3.Location = new System.Drawing.Point(152, 466);
            this.sevenSegmentControl3.Name = "sevenSegmentControl3";
            this.sevenSegmentControl3.Size = new System.Drawing.Size(75, 113);
            this.sevenSegmentControl3.TabIndex = 19;
            this.sevenSegmentControl3.value = ((byte)(255));
            // 
            // sevenSegmentControl2
            // 
            this.sevenSegmentControl2.AutoSize = true;
            this.sevenSegmentControl2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.sevenSegmentControl2.Location = new System.Drawing.Point(77, 466);
            this.sevenSegmentControl2.Name = "sevenSegmentControl2";
            this.sevenSegmentControl2.Size = new System.Drawing.Size(75, 113);
            this.sevenSegmentControl2.TabIndex = 18;
            this.sevenSegmentControl2.value = ((byte)(255));
            // 
            // ckbSurpressZeros
            // 
            this.ckbSurpressZeros.AutoSize = true;
            this.ckbSurpressZeros.Location = new System.Drawing.Point(279, 357);
            this.ckbSurpressZeros.Name = "ckbSurpressZeros";
            this.ckbSurpressZeros.Size = new System.Drawing.Size(98, 19);
            this.ckbSurpressZeros.TabIndex = 13;
            this.ckbSurpressZeros.Text = "Supress Zeros";
            this.ckbSurpressZeros.UseVisualStyleBackColor = true;
            this.ckbSurpressZeros.CheckedChanged += new System.EventHandler(this.ckbSurpressZeros_CheckedChanged);
            // 
            // sevenSegmentControl1
            // 
            this.sevenSegmentControl1.AutoSize = true;
            this.sevenSegmentControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.sevenSegmentControl1.Location = new System.Drawing.Point(2, 466);
            this.sevenSegmentControl1.Name = "sevenSegmentControl1";
            this.sevenSegmentControl1.Size = new System.Drawing.Size(75, 113);
            this.sevenSegmentControl1.TabIndex = 17;
            this.sevenSegmentControl1.value = ((byte)(255));
            // 
            // ckbBlink5
            // 
            this.ckbBlink5.AutoSize = true;
            this.ckbBlink5.Location = new System.Drawing.Point(118, 432);
            this.ckbBlink5.Name = "ckbBlink5";
            this.ckbBlink5.Size = new System.Drawing.Size(15, 14);
            this.ckbBlink5.TabIndex = 12;
            this.ckbBlink5.UseVisualStyleBackColor = true;
            // 
            // ckbDec5
            // 
            this.ckbDec5.AutoSize = true;
            this.ckbDec5.Location = new System.Drawing.Point(117, 403);
            this.ckbDec5.Name = "ckbDec5";
            this.ckbDec5.Size = new System.Drawing.Size(15, 14);
            this.ckbDec5.TabIndex = 12;
            this.ckbDec5.UseVisualStyleBackColor = true;
            // 
            // ckbBlink4
            // 
            this.ckbBlink4.AutoSize = true;
            this.ckbBlink4.Location = new System.Drawing.Point(95, 432);
            this.ckbBlink4.Name = "ckbBlink4";
            this.ckbBlink4.Size = new System.Drawing.Size(15, 14);
            this.ckbBlink4.TabIndex = 12;
            this.ckbBlink4.UseVisualStyleBackColor = true;
            // 
            // ckbDec4
            // 
            this.ckbDec4.AutoSize = true;
            this.ckbDec4.Location = new System.Drawing.Point(94, 403);
            this.ckbDec4.Name = "ckbDec4";
            this.ckbDec4.Size = new System.Drawing.Size(15, 14);
            this.ckbDec4.TabIndex = 12;
            this.ckbDec4.UseVisualStyleBackColor = true;
            // 
            // ckbBlink3
            // 
            this.ckbBlink3.AutoSize = true;
            this.ckbBlink3.Location = new System.Drawing.Point(72, 432);
            this.ckbBlink3.Name = "ckbBlink3";
            this.ckbBlink3.Size = new System.Drawing.Size(15, 14);
            this.ckbBlink3.TabIndex = 12;
            this.ckbBlink3.UseVisualStyleBackColor = true;
            // 
            // ckbDec3
            // 
            this.ckbDec3.AutoSize = true;
            this.ckbDec3.Location = new System.Drawing.Point(71, 403);
            this.ckbDec3.Name = "ckbDec3";
            this.ckbDec3.Size = new System.Drawing.Size(15, 14);
            this.ckbDec3.TabIndex = 12;
            this.ckbDec3.UseVisualStyleBackColor = true;
            // 
            // ckbBlink2
            // 
            this.ckbBlink2.AutoSize = true;
            this.ckbBlink2.Location = new System.Drawing.Point(49, 432);
            this.ckbBlink2.Name = "ckbBlink2";
            this.ckbBlink2.Size = new System.Drawing.Size(15, 14);
            this.ckbBlink2.TabIndex = 12;
            this.ckbBlink2.UseVisualStyleBackColor = true;
            // 
            // ckbDec2
            // 
            this.ckbDec2.AutoSize = true;
            this.ckbDec2.Location = new System.Drawing.Point(48, 403);
            this.ckbDec2.Name = "ckbDec2";
            this.ckbDec2.Size = new System.Drawing.Size(15, 14);
            this.ckbDec2.TabIndex = 12;
            this.ckbDec2.UseVisualStyleBackColor = true;
            // 
            // ckbBlink1
            // 
            this.ckbBlink1.AutoSize = true;
            this.ckbBlink1.Location = new System.Drawing.Point(26, 432);
            this.ckbBlink1.Name = "ckbBlink1";
            this.ckbBlink1.Size = new System.Drawing.Size(15, 14);
            this.ckbBlink1.TabIndex = 12;
            this.ckbBlink1.UseVisualStyleBackColor = true;
            // 
            // ckbDec1
            // 
            this.ckbDec1.AutoSize = true;
            this.ckbDec1.Location = new System.Drawing.Point(25, 403);
            this.ckbDec1.Name = "ckbDec1";
            this.ckbDec1.Size = new System.Drawing.Size(15, 14);
            this.ckbDec1.TabIndex = 12;
            this.ckbDec1.UseVisualStyleBackColor = true;
            // 
            // ckbBlink0
            // 
            this.ckbBlink0.AutoSize = true;
            this.ckbBlink0.Location = new System.Drawing.Point(3, 432);
            this.ckbBlink0.Name = "ckbBlink0";
            this.ckbBlink0.Size = new System.Drawing.Size(15, 14);
            this.ckbBlink0.TabIndex = 12;
            this.ckbBlink0.UseVisualStyleBackColor = true;
            // 
            // ckbDec0
            // 
            this.ckbDec0.AutoSize = true;
            this.ckbDec0.Location = new System.Drawing.Point(2, 403);
            this.ckbDec0.Name = "ckbDec0";
            this.ckbDec0.Size = new System.Drawing.Size(15, 14);
            this.ckbDec0.TabIndex = 12;
            this.ckbDec0.UseVisualStyleBackColor = true;
            // 
            // tbOrder5
            // 
            this.tbOrder5.Location = new System.Drawing.Point(197, 312);
            this.tbOrder5.Name = "tbOrder5";
            this.tbOrder5.Size = new System.Drawing.Size(33, 23);
            this.tbOrder5.TabIndex = 10;
            // 
            // tbOrder4
            // 
            this.tbOrder4.Location = new System.Drawing.Point(158, 312);
            this.tbOrder4.Name = "tbOrder4";
            this.tbOrder4.Size = new System.Drawing.Size(33, 23);
            this.tbOrder4.TabIndex = 9;
            // 
            // tbOrder3
            // 
            this.tbOrder3.Location = new System.Drawing.Point(119, 312);
            this.tbOrder3.Name = "tbOrder3";
            this.tbOrder3.Size = new System.Drawing.Size(33, 23);
            this.tbOrder3.TabIndex = 8;
            // 
            // tbOrder2
            // 
            this.tbOrder2.Location = new System.Drawing.Point(80, 312);
            this.tbOrder2.Name = "tbOrder2";
            this.tbOrder2.Size = new System.Drawing.Size(33, 23);
            this.tbOrder2.TabIndex = 7;
            // 
            // tbOrder1
            // 
            this.tbOrder1.Location = new System.Drawing.Point(41, 312);
            this.tbOrder1.Name = "tbOrder1";
            this.tbOrder1.Size = new System.Drawing.Size(33, 23);
            this.tbOrder1.TabIndex = 6;
            // 
            // tbArray
            // 
            this.tbArray.Location = new System.Drawing.Point(2, 357);
            this.tbArray.Name = "tbArray";
            this.tbArray.Size = new System.Drawing.Size(120, 23);
            this.tbArray.TabIndex = 5;
            // 
            // tbOrder0
            // 
            this.tbOrder0.Location = new System.Drawing.Point(2, 312);
            this.tbOrder0.Name = "tbOrder0";
            this.tbOrder0.Size = new System.Drawing.Size(33, 23);
            this.tbOrder0.TabIndex = 5;
            // 
            // bWriteBlinkBitmap
            // 
            this.bWriteBlinkBitmap.Location = new System.Drawing.Point(152, 427);
            this.bWriteBlinkBitmap.Name = "bWriteBlinkBitmap";
            this.bWriteBlinkBitmap.Size = new System.Drawing.Size(137, 23);
            this.bWriteBlinkBitmap.TabIndex = 3;
            this.bWriteBlinkBitmap.Text = "Write Blink Bitmap";
            this.bWriteBlinkBitmap.UseVisualStyleBackColor = true;
            this.bWriteBlinkBitmap.Click += new System.EventHandler(this.bWriteBlinkBitmap_Click);
            // 
            // bWriteDecimals
            // 
            this.bWriteDecimals.Location = new System.Drawing.Point(151, 398);
            this.bWriteDecimals.Name = "bWriteDecimals";
            this.bWriteDecimals.Size = new System.Drawing.Size(137, 23);
            this.bWriteDecimals.TabIndex = 3;
            this.bWriteDecimals.Text = "Write Decimal Bitmap";
            this.bWriteDecimals.UseVisualStyleBackColor = true;
            this.bWriteDecimals.Click += new System.EventHandler(this.bWriteDecimals_Click);
            // 
            // bWriteArray
            // 
            this.bWriteArray.Location = new System.Drawing.Point(128, 357);
            this.bWriteArray.Name = "bWriteArray";
            this.bWriteArray.Size = new System.Drawing.Size(113, 23);
            this.bWriteArray.TabIndex = 3;
            this.bWriteArray.Text = "Write Array";
            this.bWriteArray.UseVisualStyleBackColor = true;
            this.bWriteArray.Click += new System.EventHandler(this.bWriteArray_Click);
            // 
            // bWriteDigitOrder
            // 
            this.bWriteDigitOrder.Location = new System.Drawing.Point(254, 311);
            this.bWriteDigitOrder.Name = "bWriteDigitOrder";
            this.bWriteDigitOrder.Size = new System.Drawing.Size(113, 23);
            this.bWriteDigitOrder.TabIndex = 3;
            this.bWriteDigitOrder.Text = "Write Digit Order";
            this.bWriteDigitOrder.UseVisualStyleBackColor = true;
            this.bWriteDigitOrder.Click += new System.EventHandler(this.bWriteDigitOrder_Click);
            // 
            // bAddToAnimation
            // 
            this.bAddToAnimation.Location = new System.Drawing.Point(35, 290);
            this.bAddToAnimation.Name = "bAddToAnimation";
            this.bAddToAnimation.Size = new System.Drawing.Size(117, 23);
            this.bAddToAnimation.TabIndex = 31;
            this.bAddToAnimation.Text = "Add To Animation";
            this.bAddToAnimation.UseVisualStyleBackColor = true;
            this.bAddToAnimation.Click += new System.EventHandler(this.bAddToAnimation_Click);
            // 
            // TM1637Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.groupBox1);
            this.Name = "TM1637Control";
            this.Size = new System.Drawing.Size(751, 636);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbAnimation.ResumeLayout(false);
            this.gbAnimation.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbDioPin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbDigits;
        private SerialWombatPublicDataControl serialWombatPublicDataControl1;
        private System.Windows.Forms.TextBox tbOrder5;
        private System.Windows.Forms.TextBox tbOrder4;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TextBox tbOrder3;
        private System.Windows.Forms.TextBox tbOrder2;
        private System.Windows.Forms.TextBox tbOrder1;
        private System.Windows.Forms.TextBox tbArray;
        private System.Windows.Forms.TextBox tbOrder0;
        private System.Windows.Forms.Button bWriteDigitOrder;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbUserBufferIndex;
        private System.Windows.Forms.Button bShowAnimation;
        private System.Windows.Forms.Button bWriteRaw;
        private SevenSegmentControl sevenSegmentControl6;
        private SevenSegmentControl sevenSegmentControl5;
        private SevenSegmentControl sevenSegmentControl4;
        private SevenSegmentControl sevenSegmentControl3;
        private SevenSegmentControl sevenSegmentControl2;
        private SevenSegmentControl sevenSegmentControl1;
        private System.Windows.Forms.Button bPinDataHex;
        private System.Windows.Forms.Button bPinDataDecimal;
        private System.Windows.Forms.Button bConfigure;
        private System.Windows.Forms.CheckBox ckbSurpressZeros;
        private System.Windows.Forms.CheckBox ckbBlink5;
        private System.Windows.Forms.CheckBox ckbDec5;
        private System.Windows.Forms.CheckBox ckbBlink4;
        private System.Windows.Forms.CheckBox ckbDec4;
        private System.Windows.Forms.CheckBox ckbBlink3;
        private System.Windows.Forms.CheckBox ckbDec3;
        private System.Windows.Forms.CheckBox ckbBlink2;
        private System.Windows.Forms.CheckBox ckbDec2;
        private System.Windows.Forms.CheckBox ckbBlink1;
        private System.Windows.Forms.CheckBox ckbDec1;
        private System.Windows.Forms.CheckBox ckbBlink0;
        private System.Windows.Forms.CheckBox ckbDec0;
        private System.Windows.Forms.Button bWriteBlinkBitmap;
        private System.Windows.Forms.Button bWriteDecimals;
        private System.Windows.Forms.Button bWriteArray;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox gbAnimation;
        private System.Windows.Forms.Button bDownloadAnimation;
        private System.Windows.Forms.TextBox tbAnimationFrames;
        private System.Windows.Forms.Button bAddToAnimation;
    }
}
