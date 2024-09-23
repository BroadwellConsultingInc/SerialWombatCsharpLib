namespace SerialWombatWindowsFormsLibrary.Controls
{
    partial class VGA18ABControl
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lAddr = new System.Windows.Forms.Label();
            this.sixteenBitAddressControl1 = new SerialWombatWindowsFormsLibrary.SixteenBitAddressControl();
            this.bLoad = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bConfig = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbFirstLine = new System.Windows.Forms.TextBox();
            this.tbLastLine = new System.Windows.Forms.TextBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.lAddr);
            this.groupBox1.Controls.Add(this.sixteenBitAddressControl1);
            this.groupBox1.Controls.Add(this.bLoad);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.bConfig);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(239, 129);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // lAddr
            // 
            this.lAddr.AutoSize = true;
            this.lAddr.Location = new System.Drawing.Point(99, 19);
            this.lAddr.Name = "lAddr";
            this.lAddr.Size = new System.Drawing.Size(87, 15);
            this.lAddr.TabIndex = 4;
            this.lAddr.Text = "Memory Index:";
            // 
            // sixteenBitAddressControl1
            // 
            this.sixteenBitAddressControl1.AutoSize = true;
            this.sixteenBitAddressControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.sixteenBitAddressControl1.Location = new System.Drawing.Point(177, 37);
            this.sixteenBitAddressControl1.Name = "sixteenBitAddressControl1";
            this.sixteenBitAddressControl1.Size = new System.Drawing.Size(56, 26);
            this.sixteenBitAddressControl1.TabIndex = 3;
            this.sixteenBitAddressControl1.Value = ((ushort)(0));
            // 
            // bLoad
            // 
            this.bLoad.Location = new System.Drawing.Point(158, 78);
            this.bLoad.Name = "bLoad";
            this.bLoad.Size = new System.Drawing.Size(75, 23);
            this.bLoad.TabIndex = 2;
            this.bLoad.Text = "Load Bitmap";
            this.bLoad.UseVisualStyleBackColor = true;
            this.bLoad.Click += new System.EventHandler(this.bLoad_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(29, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // bConfig
            // 
            this.bConfig.Location = new System.Drawing.Point(6, 22);
            this.bConfig.Name = "bConfig";
            this.bConfig.Size = new System.Drawing.Size(87, 23);
            this.bConfig.TabIndex = 0;
            this.bConfig.Text = "Config Pin 18";
            this.bConfig.UseVisualStyleBackColor = true;
            this.bConfig.Click += new System.EventHandler(this.bConfig_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.trackBar1);
            this.groupBox2.Controls.Add(this.tbLastLine);
            this.groupBox2.Controls.Add(this.tbFirstLine);
            this.groupBox2.Location = new System.Drawing.Point(9, 138);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 124);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Set Color";
            // 
            // tbFirstLine
            // 
            this.tbFirstLine.Location = new System.Drawing.Point(80, 22);
            this.tbFirstLine.Name = "tbFirstLine";
            this.tbFirstLine.Size = new System.Drawing.Size(100, 23);
            this.tbFirstLine.TabIndex = 0;
            this.tbFirstLine.Text = "0";
            // 
            // tbLastLine
            // 
            this.tbLastLine.Location = new System.Drawing.Point(80, 51);
            this.tbLastLine.Name = "tbLastLine";
            this.tbLastLine.Size = new System.Drawing.Size(100, 23);
            this.tbLastLine.TabIndex = 0;
            this.tbLastLine.Text = "119";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(57, 82);
            this.trackBar1.Maximum = 7;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(104, 45);
            this.trackBar1.TabIndex = 1;
            this.trackBar1.Value = 7;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "First Line";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last Line";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Color";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(167, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "7";
            // 
            // VGA18ABControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "VGA18ABControl";
            this.Size = new System.Drawing.Size(245, 265);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bLoad;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bConfig;
        private System.Windows.Forms.Label lAddr;
        private SixteenBitAddressControl sixteenBitAddressControl1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TextBox tbLastLine;
        private System.Windows.Forms.TextBox tbFirstLine;
    }
}
