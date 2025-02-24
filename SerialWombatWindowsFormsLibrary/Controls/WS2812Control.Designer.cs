namespace SerialWombatWindowsFormsLibrary
{
    partial class WS2812Control
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bResend = new System.Windows.Forms.Button();
            this.ckbReverseRG = new System.Windows.Forms.CheckBox();
            this.gbAnimation = new System.Windows.Forms.GroupBox();
            this.bAnimationStart = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbDelay = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nudFrameToWrite = new System.Windows.Forms.NumericUpDown();
            this.bWriteAnimationFrame = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.sbacAnimationIndex = new SerialWombatWindowsFormsLibrary.SixteenBitAddressControl();
            this.bConfigAnimation = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nudTotalFrames = new System.Windows.Forms.NumericUpDown();
            this.sbacUserBufferAddress = new SerialWombatWindowsFormsLibrary.SixteenBitAddressControl();
            this.bTestSequence = new System.Windows.Forms.Button();
            this.gbBarGraph = new System.Windows.Forms.GroupBox();
            this.bBGConfigure = new System.Windows.Forms.Button();
            this.sbsiMax = new SerialWombatWindowsFormsLibrary.SixteenBitSliderInput();
            this.sbsiMin = new SerialWombatWindowsFormsLibrary.SixteenBitSliderInput();
            this.label3 = new System.Windows.Forms.Label();
            this.serialWombatPublicDataControl1 = new SerialWombatWindowsFormsLibrary.SerialWombatPublicDataControl();
            this.gbSetColor = new System.Windows.Forms.GroupBox();
            this.ckbDivsor = new System.Windows.Forms.CheckBox();
            this.bConfig = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.nudNumberOfLEDs = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.gbAnimation.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFrameToWrite)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotalFrames)).BeginInit();
            this.gbBarGraph.SuspendLayout();
            this.gbSetColor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfLEDs)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bResend);
            this.groupBox1.Controls.Add(this.ckbReverseRG);
            this.groupBox1.Controls.Add(this.gbAnimation);
            this.groupBox1.Controls.Add(this.sbacUserBufferAddress);
            this.groupBox1.Controls.Add(this.bTestSequence);
            this.groupBox1.Controls.Add(this.gbBarGraph);
            this.groupBox1.Controls.Add(this.gbSetColor);
            this.groupBox1.Controls.Add(this.bConfig);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.nudNumberOfLEDs);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1125, 621);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // bResend
            // 
            this.bResend.Location = new System.Drawing.Point(473, 99);
            this.bResend.Name = "bResend";
            this.bResend.Size = new System.Drawing.Size(75, 23);
            this.bResend.TabIndex = 10;
            this.bResend.Text = "Resend Colors";
            this.bResend.UseVisualStyleBackColor = true;
            this.bResend.Click += new System.EventHandler(this.bResend_Click);
            // 
            // ckbReverseRG
            // 
            this.ckbReverseRG.AutoSize = true;
            this.ckbReverseRG.Location = new System.Drawing.Point(287, 65);
            this.ckbReverseRG.Name = "ckbReverseRG";
            this.ckbReverseRG.Size = new System.Drawing.Size(198, 19);
            this.ckbReverseRG.TabIndex = 9;
            this.ckbReverseRG.Text = "Reverse Red and Green (WS2811)";
            this.ckbReverseRG.UseVisualStyleBackColor = true;
            this.ckbReverseRG.CheckedChanged += new System.EventHandler(this.ckbReverseRG_CheckedChanged);
            // 
            // gbAnimation
            // 
            this.gbAnimation.Controls.Add(this.bAnimationStart);
            this.gbAnimation.Controls.Add(this.groupBox3);
            this.gbAnimation.Controls.Add(this.groupBox2);
            this.gbAnimation.Location = new System.Drawing.Point(22, 474);
            this.gbAnimation.Name = "gbAnimation";
            this.gbAnimation.Size = new System.Drawing.Size(601, 141);
            this.gbAnimation.TabIndex = 8;
            this.gbAnimation.TabStop = false;
            this.gbAnimation.Text = "Animation";
            // 
            // bAnimationStart
            // 
            this.bAnimationStart.Location = new System.Drawing.Point(393, 91);
            this.bAnimationStart.Name = "bAnimationStart";
            this.bAnimationStart.Size = new System.Drawing.Size(75, 23);
            this.bAnimationStart.TabIndex = 6;
            this.bAnimationStart.Text = "Start";
            this.bAnimationStart.UseVisualStyleBackColor = true;
            this.bAnimationStart.Click += new System.EventHandler(this.bAnimationStart_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.tbDelay);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.nudFrameToWrite);
            this.groupBox3.Controls.Add(this.bWriteAnimationFrame);
            this.groupBox3.Location = new System.Drawing.Point(6, 69);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(352, 59);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Frame Data";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(133, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 15);
            this.label7.TabIndex = 5;
            this.label7.Text = "Delay:";
            // 
            // tbDelay
            // 
            this.tbDelay.Location = new System.Drawing.Point(177, 25);
            this.tbDelay.Name = "tbDelay";
            this.tbDelay.Size = new System.Drawing.Size(52, 23);
            this.tbDelay.TabIndex = 4;
            this.tbDelay.Text = "250";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Frame #";
            // 
            // nudFrameToWrite
            // 
            this.nudFrameToWrite.Location = new System.Drawing.Point(62, 24);
            this.nudFrameToWrite.Name = "nudFrameToWrite";
            this.nudFrameToWrite.Size = new System.Drawing.Size(60, 23);
            this.nudFrameToWrite.TabIndex = 2;
            // 
            // bWriteAnimationFrame
            // 
            this.bWriteAnimationFrame.Location = new System.Drawing.Point(251, 24);
            this.bWriteAnimationFrame.Name = "bWriteAnimationFrame";
            this.bWriteAnimationFrame.Size = new System.Drawing.Size(75, 23);
            this.bWriteAnimationFrame.TabIndex = 3;
            this.bWriteAnimationFrame.Text = "Write";
            this.bWriteAnimationFrame.UseVisualStyleBackColor = true;
            this.bWriteAnimationFrame.Click += new System.EventHandler(this.bWriteAnimationFrame_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.sbacAnimationIndex);
            this.groupBox2.Controls.Add(this.bConfigAnimation);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.nudTotalFrames);
            this.groupBox2.Location = new System.Drawing.Point(20, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(551, 41);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Configuration";
            // 
            // sbacAnimationIndex
            // 
            this.sbacAnimationIndex.AutoSize = true;
            this.sbacAnimationIndex.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.sbacAnimationIndex.Location = new System.Drawing.Point(207, 15);
            this.sbacAnimationIndex.Name = "sbacAnimationIndex";
            this.sbacAnimationIndex.Size = new System.Drawing.Size(56, 26);
            this.sbacAnimationIndex.TabIndex = 1;
            this.sbacAnimationIndex.Value = ((ushort)(0));
            // 
            // bConfigAnimation
            // 
            this.bConfigAnimation.Location = new System.Drawing.Point(431, 15);
            this.bConfigAnimation.Name = "bConfigAnimation";
            this.bConfigAnimation.Size = new System.Drawing.Size(75, 23);
            this.bConfigAnimation.TabIndex = 3;
            this.bConfigAnimation.Text = "Write";
            this.bConfigAnimation.UseVisualStyleBackColor = true;
            this.bConfigAnimation.Click += new System.EventHandler(this.bConfigAnimation_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Animation Frames Memory Index:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(276, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Total Frames";
            // 
            // nudTotalFrames
            // 
            this.nudTotalFrames.Location = new System.Drawing.Point(355, 11);
            this.nudTotalFrames.Name = "nudTotalFrames";
            this.nudTotalFrames.Size = new System.Drawing.Size(60, 23);
            this.nudTotalFrames.TabIndex = 2;
            this.nudTotalFrames.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // sbacUserBufferAddress
            // 
            this.sbacUserBufferAddress.AutoSize = true;
            this.sbacUserBufferAddress.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.sbacUserBufferAddress.Location = new System.Drawing.Point(138, 51);
            this.sbacUserBufferAddress.Name = "sbacUserBufferAddress";
            this.sbacUserBufferAddress.Size = new System.Drawing.Size(56, 26);
            this.sbacUserBufferAddress.TabIndex = 7;
            this.sbacUserBufferAddress.Value = ((ushort)(0));
            // 
            // bTestSequence
            // 
            this.bTestSequence.Location = new System.Drawing.Point(405, 32);
            this.bTestSequence.Name = "bTestSequence";
            this.bTestSequence.Size = new System.Drawing.Size(99, 23);
            this.bTestSequence.TabIndex = 6;
            this.bTestSequence.Text = "Test Sequence";
            this.bTestSequence.UseVisualStyleBackColor = true;
            this.bTestSequence.Click += new System.EventHandler(this.bTestSequence_Click);
            // 
            // gbBarGraph
            // 
            this.gbBarGraph.Controls.Add(this.bBGConfigure);
            this.gbBarGraph.Controls.Add(this.sbsiMax);
            this.gbBarGraph.Controls.Add(this.sbsiMin);
            this.gbBarGraph.Controls.Add(this.label3);
            this.gbBarGraph.Controls.Add(this.serialWombatPublicDataControl1);
            this.gbBarGraph.Location = new System.Drawing.Point(656, 129);
            this.gbBarGraph.Name = "gbBarGraph";
            this.gbBarGraph.Size = new System.Drawing.Size(436, 368);
            this.gbBarGraph.TabIndex = 5;
            this.gbBarGraph.TabStop = false;
            this.gbBarGraph.Text = "BarGraph";
            // 
            // bBGConfigure
            // 
            this.bBGConfigure.Location = new System.Drawing.Point(17, 227);
            this.bBGConfigure.Name = "bBGConfigure";
            this.bBGConfigure.Size = new System.Drawing.Size(75, 23);
            this.bBGConfigure.TabIndex = 3;
            this.bBGConfigure.Text = "Configure";
            this.bBGConfigure.UseVisualStyleBackColor = true;
            this.bBGConfigure.Click += new System.EventHandler(this.bBGConfigure_Click);
            // 
            // sbsiMax
            // 
            this.sbsiMax.Location = new System.Drawing.Point(17, 145);
            this.sbsiMax.Maximum = 65535;
            this.sbsiMax.Minimum = 0;
            this.sbsiMax.Name = "sbsiMax";
            this.sbsiMax.Size = new System.Drawing.Size(328, 76);
            this.sbsiMax.TabIndex = 2;
            this.sbsiMax.Text = "Maximum";
            this.sbsiMax.TextBoxHint = "";
            this.sbsiMax.value = ((ushort)(0));
            // 
            // sbsiMin
            // 
            this.sbsiMin.Location = new System.Drawing.Point(17, 63);
            this.sbsiMin.Maximum = 65535;
            this.sbsiMin.Minimum = 0;
            this.sbsiMin.Name = "sbsiMin";
            this.sbsiMin.Size = new System.Drawing.Size(328, 76);
            this.sbsiMin.TabIndex = 2;
            this.sbsiMin.Text = "Minimum";
            this.sbsiMin.TextBoxHint = "";
            this.sbsiMin.value = ((ushort)(0));
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Public Data";
            // 
            // serialWombatPublicDataControl1
            // 
            this.serialWombatPublicDataControl1.DataSourceValue = ((byte)(0));
            this.serialWombatPublicDataControl1.DropDownToolTip = "";
            this.serialWombatPublicDataControl1.Location = new System.Drawing.Point(80, 22);
            this.serialWombatPublicDataControl1.Name = "serialWombatPublicDataControl1";
            this.serialWombatPublicDataControl1.Size = new System.Drawing.Size(286, 35);
            this.serialWombatPublicDataControl1.TabIndex = 0;
            // 
            // gbSetColor
            // 
            this.gbSetColor.Controls.Add(this.ckbDivsor);
            this.gbSetColor.Location = new System.Drawing.Point(22, 119);
            this.gbSetColor.Name = "gbSetColor";
            this.gbSetColor.Size = new System.Drawing.Size(601, 338);
            this.gbSetColor.TabIndex = 4;
            this.gbSetColor.TabStop = false;
            this.gbSetColor.Text = "Set Color";
            // 
            // ckbDivsor
            // 
            this.ckbDivsor.AutoSize = true;
            this.ckbDivsor.Location = new System.Drawing.Point(20, 309);
            this.ckbDivsor.Name = "ckbDivsor";
            this.ckbDivsor.Size = new System.Drawing.Size(101, 19);
            this.ckbDivsor.TabIndex = 0;
            this.ckbDivsor.Text = "1/8 Brightness";
            this.toolTip1.SetToolTip(this.ckbDivsor, "Reduces RGB values to 1/8 to reduce LED current (happens on PC side)");
            this.ckbDivsor.UseVisualStyleBackColor = true;
            // 
            // bConfig
            // 
            this.bConfig.Location = new System.Drawing.Point(279, 32);
            this.bConfig.Name = "bConfig";
            this.bConfig.Size = new System.Drawing.Size(75, 23);
            this.bConfig.TabIndex = 2;
            this.bConfig.Text = "Configure";
            this.bConfig.UseVisualStyleBackColor = true;
            this.bConfig.Click += new System.EventHandler(this.bConfig_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "User Buffer Address";
            // 
            // nudNumberOfLEDs
            // 
            this.nudNumberOfLEDs.Location = new System.Drawing.Point(96, 22);
            this.nudNumberOfLEDs.Name = "nudNumberOfLEDs";
            this.nudNumberOfLEDs.Size = new System.Drawing.Size(48, 23);
            this.nudNumberOfLEDs.TabIndex = 3;
            this.nudNumberOfLEDs.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nudNumberOfLEDs.ValueChanged += new System.EventHandler(this.nudNumberOfLEDs_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "# of LEDs";
            // 
            // colorDialog1
            // 
            this.colorDialog1.FullOpen = true;
            // 
            // WS2812Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.groupBox1);
            this.Name = "WS2812Control";
            this.Size = new System.Drawing.Size(1131, 627);
            this.Load += new System.EventHandler(this.WS2812Control_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbAnimation.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFrameToWrite)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotalFrames)).EndInit();
            this.gbBarGraph.ResumeLayout(false);
            this.gbBarGraph.PerformLayout();
            this.gbSetColor.ResumeLayout(false);
            this.gbSetColor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfLEDs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gbSetColor;
        private System.Windows.Forms.Button bConfig;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.NumericUpDown nudNumberOfLEDs;
        private System.Windows.Forms.GroupBox gbBarGraph;
        private System.Windows.Forms.Button bTestSequence;
        private SixteenBitSliderInput sbsiMax;
        private SixteenBitSliderInput sbsiMin;
        private System.Windows.Forms.Label label3;
        private SerialWombatPublicDataControl serialWombatPublicDataControl1;
        private System.Windows.Forms.Button bBGConfigure;
        private SixteenBitAddressControl sbacUserBufferAddress;
        private System.Windows.Forms.CheckBox ckbDivsor;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox gbAnimation;
        private System.Windows.Forms.Button bAnimationStart;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbDelay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudFrameToWrite;
        private System.Windows.Forms.Button bWriteAnimationFrame;
        private System.Windows.Forms.GroupBox groupBox2;
        private SixteenBitAddressControl sbacAnimationIndex;
        private System.Windows.Forms.Button bConfigAnimation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudTotalFrames;
        private System.Windows.Forms.CheckBox ckbReverseRG;
        private System.Windows.Forms.Button bResend;
    }
}
