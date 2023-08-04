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
            this.bConfig = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bLoad = new System.Windows.Forms.Button();
            this.sixteenBitAddressControl1 = new SerialWombatWindowsFormsLibrary.SixteenBitAddressControl();
            this.lAddr = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(29, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // bLoad
            // 
            this.bLoad.Location = new System.Drawing.Point(158, 78);
            this.bLoad.Name = "bLoad";
            this.bLoad.Size = new System.Drawing.Size(75, 23);
            this.bLoad.TabIndex = 2;
            this.bLoad.Text = "Load Bitmap";
            this.bLoad.UseVisualStyleBackColor = true;
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
            // lAddr
            // 
            this.lAddr.AutoSize = true;
            this.lAddr.Location = new System.Drawing.Point(99, 19);
            this.lAddr.Name = "lAddr";
            this.lAddr.Size = new System.Drawing.Size(87, 15);
            this.lAddr.TabIndex = 4;
            this.lAddr.Text = "Memory Index:";
            // 
            // VGA18ABControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.groupBox1);
            this.Name = "VGA18ABControl";
            this.Size = new System.Drawing.Size(245, 135);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
    }
}
