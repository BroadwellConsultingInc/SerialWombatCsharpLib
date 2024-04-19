namespace SerialWombatWindowsFormsLibrary
{
    partial class QuadratureEncoderForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.realTimeScottPlot1 = new SerialWombatWindowsFormsLibrary.Controls.RealTimeScottPlot();
            this.ckbAutoSample = new System.Windows.Forms.CheckBox();
            this.bConfigure = new System.Windows.Forms.Button();
            this.bRead = new System.Windows.Forms.Button();
            this.bWrite = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tbHighLimit = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbDebounce = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbValue = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbIncrement = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbLowLimit = new System.Windows.Forms.TextBox();
            this.cbPullUpDown = new System.Windows.Forms.ComboBox();
            this.cbAction = new System.Windows.Forms.ComboBox();
            this.tbSecondPin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.bRename = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.realTimeScottPlot1);
            this.groupBox1.Controls.Add(this.ckbAutoSample);
            this.groupBox1.Controls.Add(this.bConfigure);
            this.groupBox1.Controls.Add(this.bRead);
            this.groupBox1.Controls.Add(this.bWrite);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbHighLimit);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.tbDebounce);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.tbValue);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tbIncrement);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbLowLimit);
            this.groupBox1.Controls.Add(this.cbPullUpDown);
            this.groupBox1.Controls.Add(this.cbAction);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.tbSecondPin);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(1, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(441, 498);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // realTimeScottPlot1
            // 
            this.realTimeScottPlot1.Location = new System.Drawing.Point(6, 220);
            this.realTimeScottPlot1.Name = "realTimeScottPlot1";
            this.realTimeScottPlot1.Size = new System.Drawing.Size(429, 256);
            this.realTimeScottPlot1.TabIndex = 9;
            // 
            // ckbAutoSample
            // 
            this.ckbAutoSample.AutoSize = true;
            this.ckbAutoSample.Location = new System.Drawing.Point(162, 195);
            this.ckbAutoSample.Name = "ckbAutoSample";
            this.ckbAutoSample.Size = new System.Drawing.Size(91, 19);
            this.ckbAutoSample.TabIndex = 8;
            this.ckbAutoSample.Text = "AutoSample";
            this.ckbAutoSample.UseVisualStyleBackColor = true;
            this.ckbAutoSample.CheckedChanged += new System.EventHandler(this.ckbAutoSample_CheckedChanged);
            // 
            // bConfigure
            // 
            this.bConfigure.Location = new System.Drawing.Point(53, 191);
            this.bConfigure.Name = "bConfigure";
            this.bConfigure.Size = new System.Drawing.Size(75, 23);
            this.bConfigure.TabIndex = 7;
            this.bConfigure.Text = "Configure";
            this.bConfigure.UseVisualStyleBackColor = true;
            this.bConfigure.Click += new System.EventHandler(this.bConfigure_Click);
            // 
            // bRead
            // 
            this.bRead.Location = new System.Drawing.Point(243, 148);
            this.bRead.Name = "bRead";
            this.bRead.Size = new System.Drawing.Size(56, 23);
            this.bRead.TabIndex = 6;
            this.bRead.Text = "Read";
            this.bRead.UseVisualStyleBackColor = true;
            this.bRead.Click += new System.EventHandler(this.bRead_Click);
            // 
            // bWrite
            // 
            this.bWrite.Location = new System.Drawing.Point(181, 148);
            this.bWrite.Name = "bWrite";
            this.bWrite.Size = new System.Drawing.Size(56, 23);
            this.bWrite.TabIndex = 6;
            this.bWrite.Text = "Write";
            this.bWrite.UseVisualStyleBackColor = true;
            this.bWrite.Click += new System.EventHandler(this.bWrite_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(181, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "High Limit:";
            // 
            // tbHighLimit
            // 
            this.tbHighLimit.Location = new System.Drawing.Point(252, 80);
            this.tbHighLimit.Name = "tbHighLimit";
            this.tbHighLimit.Size = new System.Drawing.Size(80, 23);
            this.tbHighLimit.TabIndex = 4;
            this.tbHighLimit.Text = "65535";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(181, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 15);
            this.label8.TabIndex = 5;
            this.label8.Text = "Debounce:";
            // 
            // tbDebounce
            // 
            this.tbDebounce.Location = new System.Drawing.Point(252, 115);
            this.tbDebounce.Name = "tbDebounce";
            this.tbDebounce.Size = new System.Drawing.Size(80, 23);
            this.tbDebounce.TabIndex = 4;
            this.tbDebounce.Text = "5";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 152);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 15);
            this.label9.TabIndex = 5;
            this.label9.Text = "Value:";
            // 
            // tbValue
            // 
            this.tbValue.Location = new System.Drawing.Point(83, 149);
            this.tbValue.Name = "tbValue";
            this.tbValue.Size = new System.Drawing.Size(80, 23);
            this.tbValue.TabIndex = 4;
            this.tbValue.Text = "32768";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 15);
            this.label7.TabIndex = 5;
            this.label7.Text = "Increment:";
            // 
            // tbIncrement
            // 
            this.tbIncrement.Location = new System.Drawing.Point(82, 115);
            this.tbIncrement.Name = "tbIncrement";
            this.tbIncrement.Size = new System.Drawing.Size(80, 23);
            this.tbIncrement.TabIndex = 4;
            this.tbIncrement.Text = "1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Low Limit:";
            // 
            // tbLowLimit
            // 
            this.tbLowLimit.Location = new System.Drawing.Point(82, 80);
            this.tbLowLimit.Name = "tbLowLimit";
            this.tbLowLimit.Size = new System.Drawing.Size(80, 23);
            this.tbLowLimit.TabIndex = 4;
            this.tbLowLimit.Text = "0";
            // 
            // cbPullUpDown
            // 
            this.cbPullUpDown.FormattingEnabled = true;
            this.cbPullUpDown.Items.AddRange(new object[] {
            "None",
            "Pull-Up",
            "Pull-Down"});
            this.cbPullUpDown.Location = new System.Drawing.Point(225, 20);
            this.cbPullUpDown.Name = "cbPullUpDown";
            this.cbPullUpDown.Size = new System.Drawing.Size(121, 23);
            this.cbPullUpDown.TabIndex = 3;
            // 
            // cbAction
            // 
            this.cbAction.FormattingEnabled = true;
            this.cbAction.Items.AddRange(new object[] {
            "High to Low HW",
            "Low to High HW",
            "Both HW",
            "Reserved",
            "High to Low Poll",
            "Low to High Poll",
            "Both Poll"});
            this.cbAction.Location = new System.Drawing.Point(82, 50);
            this.cbAction.Name = "cbAction";
            this.cbAction.Size = new System.Drawing.Size(121, 23);
            this.cbAction.TabIndex = 2;
            // 
            // tbSecondPin
            // 
            this.tbSecondPin.Location = new System.Drawing.Point(82, 20);
            this.tbSecondPin.Name = "tbSecondPin";
            this.tbSecondPin.Size = new System.Drawing.Size(46, 23);
            this.tbSecondPin.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Action:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(138, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Pull Up/Down:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Second Pin:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(71, 80);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(80, 23);
            this.textBox2.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(0, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Low Limit:";
            // 
            // bRename
            // 
            this.bRename.Location = new System.Drawing.Point(7, 505);
            this.bRename.Name = "bRename";
            this.bRename.Size = new System.Drawing.Size(75, 23);
            this.bRename.TabIndex = 1;
            this.bRename.Text = "Rename";
            this.bRename.UseVisualStyleBackColor = true;
            this.bRename.Click += new System.EventHandler(this.bRename_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(318, 152);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 15);
            this.label10.TabIndex = 0;
            this.label10.Text = "Target Pin:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(318, 170);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(46, 23);
            this.textBox1.TabIndex = 1;
            // 
            // QuadratureEncoderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(481, 548);
            this.Controls.Add(this.bRename);
            this.Controls.Add(this.groupBox1);
            this.Name = "QuadratureEncoderForm";
            this.Text = "QuadratureEncoderForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbAction;
        private System.Windows.Forms.TextBox tbSecondPin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbPullUpDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bRead;
        private System.Windows.Forms.Button bWrite;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbHighLimit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbDebounce;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbValue;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbIncrement;
        private System.Windows.Forms.Button bConfigure;
        private System.Windows.Forms.TextBox tbLowLimit;
        private System.Windows.Forms.CheckBox ckbAutoSample;
        private Controls.RealTimeScottPlot realTimeScottPlot1;
        private System.Windows.Forms.Button bRename;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label10;
    }
}