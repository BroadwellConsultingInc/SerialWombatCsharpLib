namespace SerialWombatWindowsFormsLibrary
{
    partial class ServoForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbVariableTime = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbFixedTime = new System.Windows.Forms.TextBox();
            this.ckbInvertSignal = new System.Windows.Forms.CheckBox();
            this.ckbReverse = new System.Windows.Forms.CheckBox();
            this.bSetPosition = new System.Windows.Forms.Button();
            this.bConfigure = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tbSignalPeriod = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbCommandPin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPosition = new System.Windows.Forms.TextBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbVariableTime);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbFixedTime);
            this.groupBox1.Controls.Add(this.ckbInvertSignal);
            this.groupBox1.Controls.Add(this.ckbReverse);
            this.groupBox1.Controls.Add(this.bSetPosition);
            this.groupBox1.Controls.Add(this.bConfigure);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbSignalPeriod);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbCommandPin);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbPosition);
            this.groupBox1.Controls.Add(this.trackBar1);
            this.groupBox1.Location = new System.Drawing.Point(2, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 220);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // tbVariableTime
            // 
            this.tbVariableTime.Location = new System.Drawing.Point(210, 182);
            this.tbVariableTime.Name = "tbVariableTime";
            this.tbVariableTime.Size = new System.Drawing.Size(66, 23);
            this.tbVariableTime.TabIndex = 9;
            this.tbVariableTime.Text = "2000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(194, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Variable Time (us)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(210, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Fixed Time (uS)";
            // 
            // tbFixedTime
            // 
            this.tbFixedTime.Location = new System.Drawing.Point(210, 116);
            this.tbFixedTime.Name = "tbFixedTime";
            this.tbFixedTime.Size = new System.Drawing.Size(66, 23);
            this.tbFixedTime.TabIndex = 7;
            this.tbFixedTime.Text = "500";
            // 
            // ckbInvertSignal
            // 
            this.ckbInvertSignal.AutoSize = true;
            this.ckbInvertSignal.Location = new System.Drawing.Point(93, 120);
            this.ckbInvertSignal.Name = "ckbInvertSignal";
            this.ckbInvertSignal.Size = new System.Drawing.Size(91, 19);
            this.ckbInvertSignal.TabIndex = 6;
            this.ckbInvertSignal.Text = "Invert Signal";
            this.ckbInvertSignal.UseVisualStyleBackColor = true;
            // 
            // ckbReverse
            // 
            this.ckbReverse.AutoSize = true;
            this.ckbReverse.Location = new System.Drawing.Point(19, 121);
            this.ckbReverse.Name = "ckbReverse";
            this.ckbReverse.Size = new System.Drawing.Size(66, 19);
            this.ckbReverse.TabIndex = 5;
            this.ckbReverse.Text = "Reverse";
            this.ckbReverse.UseVisualStyleBackColor = true;
            // 
            // bSetPosition
            // 
            this.bSetPosition.Enabled = false;
            this.bSetPosition.Location = new System.Drawing.Point(91, 191);
            this.bSetPosition.Name = "bSetPosition";
            this.bSetPosition.Size = new System.Drawing.Size(85, 23);
            this.bSetPosition.TabIndex = 4;
            this.bSetPosition.Text = "Set Position";
            this.bSetPosition.UseVisualStyleBackColor = true;
            this.bSetPosition.Click += new System.EventHandler(this.bSetPosition_Click);
            // 
            // bConfigure
            // 
            this.bConfigure.Location = new System.Drawing.Point(10, 191);
            this.bConfigure.Name = "bConfigure";
            this.bConfigure.Size = new System.Drawing.Size(75, 23);
            this.bConfigure.TabIndex = 3;
            this.bConfigure.Text = "Configure";
            this.bConfigure.UseVisualStyleBackColor = true;
            this.bConfigure.Click += new System.EventHandler(this.bConfigure_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Signal period (ms):";
            // 
            // tbSignalPeriod
            // 
            this.tbSignalPeriod.Location = new System.Drawing.Point(129, 150);
            this.tbSignalPeriod.Name = "tbSignalPeriod";
            this.tbSignalPeriod.Size = new System.Drawing.Size(40, 23);
            this.tbSignalPeriod.TabIndex = 1;
            this.tbSignalPeriod.Text = "20";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Command Pin:";
            // 
            // tbCommandPin
            // 
            this.tbCommandPin.Location = new System.Drawing.Point(103, 91);
            this.tbCommandPin.Name = "tbCommandPin";
            this.tbCommandPin.Size = new System.Drawing.Size(40, 23);
            this.tbCommandPin.TabIndex = 1;
            this.tbCommandPin.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Position:";
            // 
            // tbPosition
            // 
            this.tbPosition.Location = new System.Drawing.Point(69, 22);
            this.tbPosition.Name = "tbPosition";
            this.tbPosition.Size = new System.Drawing.Size(100, 23);
            this.tbPosition.TabIndex = 1;
            this.tbPosition.Text = "0";
            // 
            // trackBar1
            // 
            this.trackBar1.Enabled = false;
            this.trackBar1.Location = new System.Drawing.Point(6, 52);
            this.trackBar1.Maximum = 65535;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(270, 45);
            this.trackBar1.TabIndex = 0;
            this.trackBar1.TickFrequency = 4096;
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // ServoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(304, 234);
            this.Controls.Add(this.groupBox1);
            this.Name = "ServoForm";
            this.Text = "Form1";
            this.Shown += new System.EventHandler(this.ServoForm_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbFixedTime;
        private System.Windows.Forms.CheckBox ckbInvertSignal;
        private System.Windows.Forms.CheckBox ckbReverse;
        private System.Windows.Forms.Button bSetPosition;
        private System.Windows.Forms.Button bConfigure;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbCommandPin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPosition;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbVariableTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbSignalPeriod;
    }
}

