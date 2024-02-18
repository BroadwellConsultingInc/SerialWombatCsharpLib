namespace SerialWombatWindowsFormsLibrary
{
    partial class ServoControl
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
            this.tbSignalPeriod = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.bConfigure = new System.Windows.Forms.Button();
            this.ckbReverse = new System.Windows.Forms.CheckBox();
            this.ckbInvertSignal = new System.Windows.Forms.CheckBox();
            this.tbFixedTime = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbVariableTime = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sbsiPosition = new SerialWombatWindowsFormsLibrary.SixteenBitSliderInput();
            this.gbConfigure = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.gbConfigure.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbSignalPeriod
            // 
            this.tbSignalPeriod.Location = new System.Drawing.Point(119, 58);
            this.tbSignalPeriod.Name = "tbSignalPeriod";
            this.tbSignalPeriod.Size = new System.Drawing.Size(40, 23);
            this.tbSignalPeriod.TabIndex = 1;
            this.tbSignalPeriod.Text = "20";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(0, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Signal period (ms):";
            // 
            // bConfigure
            // 
            this.bConfigure.Location = new System.Drawing.Point(0, 99);
            this.bConfigure.Name = "bConfigure";
            this.bConfigure.Size = new System.Drawing.Size(75, 23);
            this.bConfigure.TabIndex = 3;
            this.bConfigure.Text = "Configure";
            this.bConfigure.UseVisualStyleBackColor = true;
            this.bConfigure.Click += new System.EventHandler(this.bConfigure_Click);
            // 
            // ckbReverse
            // 
            this.ckbReverse.AutoSize = true;
            this.ckbReverse.Location = new System.Drawing.Point(9, 29);
            this.ckbReverse.Name = "ckbReverse";
            this.ckbReverse.Size = new System.Drawing.Size(66, 19);
            this.ckbReverse.TabIndex = 5;
            this.ckbReverse.Text = "Reverse";
            this.ckbReverse.UseVisualStyleBackColor = true;
            // 
            // ckbInvertSignal
            // 
            this.ckbInvertSignal.AutoSize = true;
            this.ckbInvertSignal.Location = new System.Drawing.Point(83, 28);
            this.ckbInvertSignal.Name = "ckbInvertSignal";
            this.ckbInvertSignal.Size = new System.Drawing.Size(91, 19);
            this.ckbInvertSignal.TabIndex = 6;
            this.ckbInvertSignal.Text = "Invert Signal";
            this.ckbInvertSignal.UseVisualStyleBackColor = true;
            // 
            // tbFixedTime
            // 
            this.tbFixedTime.Location = new System.Drawing.Point(180, 53);
            this.tbFixedTime.Name = "tbFixedTime";
            this.tbFixedTime.Size = new System.Drawing.Size(66, 23);
            this.tbFixedTime.TabIndex = 7;
            this.tbFixedTime.Text = "500";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(178, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Fixed Time (uS)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(178, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Variable Time (us)";
            // 
            // tbVariableTime
            // 
            this.tbVariableTime.Location = new System.Drawing.Point(184, 99);
            this.tbVariableTime.Name = "tbVariableTime";
            this.tbVariableTime.Size = new System.Drawing.Size(66, 23);
            this.tbVariableTime.TabIndex = 9;
            this.tbVariableTime.Text = "2000";
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.sbsiPosition);
            this.groupBox1.Controls.Add(this.gbConfigure);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 283);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // sbsiPosition
            // 
            this.sbsiPosition.Location = new System.Drawing.Point(0, 28);
            this.sbsiPosition.Maximum = 65535;
            this.sbsiPosition.Minimum = 0;
            this.sbsiPosition.Name = "sbsiPosition";
            this.sbsiPosition.Size = new System.Drawing.Size(288, 76);
            this.sbsiPosition.TabIndex = 11;
            this.sbsiPosition.Text = "Position";
            this.sbsiPosition.TextBoxHint = "";
            this.sbsiPosition.value = ((ushort)(32768));
            // 
            // gbConfigure
            // 
            this.gbConfigure.Controls.Add(this.button4);
            this.gbConfigure.Controls.Add(this.label5);
            this.gbConfigure.Controls.Add(this.tbVariableTime);
            this.gbConfigure.Controls.Add(this.tbSignalPeriod);
            this.gbConfigure.Controls.Add(this.label4);
            this.gbConfigure.Controls.Add(this.bConfigure);
            this.gbConfigure.Controls.Add(this.label3);
            this.gbConfigure.Controls.Add(this.tbFixedTime);
            this.gbConfigure.Controls.Add(this.ckbReverse);
            this.gbConfigure.Controls.Add(this.ckbInvertSignal);
            this.gbConfigure.Location = new System.Drawing.Point(10, 110);
            this.gbConfigure.Name = "gbConfigure";
            this.gbConfigure.Size = new System.Drawing.Size(284, 151);
            this.gbConfigure.TabIndex = 10;
            this.gbConfigure.TabStop = false;
            this.gbConfigure.Text = "Configure";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.MediumPurple;
            this.button4.Location = new System.Drawing.Point(105, 98);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(45, 47);
            this.button4.TabIndex = 29;
            this.button4.Text = "Gen Code";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // ServoControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.groupBox1);
            this.Name = "ServoControl";
            this.Size = new System.Drawing.Size(306, 289);
            this.groupBox1.ResumeLayout(false);
            this.gbConfigure.ResumeLayout(false);
            this.gbConfigure.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbSignalPeriod;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bConfigure;
        private System.Windows.Forms.CheckBox ckbReverse;
        private System.Windows.Forms.CheckBox ckbInvertSignal;
        private System.Windows.Forms.TextBox tbFixedTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbVariableTime;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gbConfigure;
        private System.Windows.Forms.Button button4;
        private SixteenBitSliderInput sbsiPosition;
    }
}
