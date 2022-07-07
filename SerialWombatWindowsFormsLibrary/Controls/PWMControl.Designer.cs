namespace SerialWombatWindowsFormsLibrary.Controls
{
    partial class PWMControl
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
            this.sbsiDutyCycle = new SerialWombatWindowsFormsLibrary.SixteenBitSliderInput();
            this.lPeriod = new System.Windows.Forms.Label();
            this.tbSW18ABPeriod = new System.Windows.Forms.TextBox();
            this.cbWombat4ABFreq = new System.Windows.Forms.ComboBox();
            this.ckbInvertSignal = new System.Windows.Forms.CheckBox();
            this.bSetPWM = new System.Windows.Forms.Button();
            this.bConfigure = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sbsiDutyCycle);
            this.groupBox1.Controls.Add(this.lPeriod);
            this.groupBox1.Controls.Add(this.tbSW18ABPeriod);
            this.groupBox1.Controls.Add(this.cbWombat4ABFreq);
            this.groupBox1.Controls.Add(this.ckbInvertSignal);
            this.groupBox1.Controls.Add(this.bSetPWM);
            this.groupBox1.Controls.Add(this.bConfigure);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(346, 220);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // sbsiDutyCycle
            // 
            this.sbsiDutyCycle.Enabled = false;
            this.sbsiDutyCycle.Location = new System.Drawing.Point(10, 22);
            this.sbsiDutyCycle.Name = "sbsiDutyCycle";
            this.sbsiDutyCycle.Size = new System.Drawing.Size(328, 76);
            this.sbsiDutyCycle.TabIndex = 13;
            this.sbsiDutyCycle.Text = "Duty Cycle (0-65535)";
            this.sbsiDutyCycle.TextBoxHint = "";
            // 
            // lPeriod
            // 
            this.lPeriod.AutoSize = true;
            this.lPeriod.Location = new System.Drawing.Point(234, 153);
            this.lPeriod.Name = "lPeriod";
            this.lPeriod.Size = new System.Drawing.Size(65, 15);
            this.lPeriod.TabIndex = 12;
            this.lPeriod.Text = "Period (uS)";
            this.lPeriod.Visible = false;
            // 
            // tbSW18ABPeriod
            // 
            this.tbSW18ABPeriod.Location = new System.Drawing.Point(76, 145);
            this.tbSW18ABPeriod.Name = "tbSW18ABPeriod";
            this.tbSW18ABPeriod.Size = new System.Drawing.Size(100, 23);
            this.tbSW18ABPeriod.TabIndex = 11;
            this.tbSW18ABPeriod.Text = "1000";
            this.tbSW18ABPeriod.Visible = false;
            // 
            // cbWombat4ABFreq
            // 
            this.cbWombat4ABFreq.FormattingEnabled = true;
            this.cbWombat4ABFreq.Location = new System.Drawing.Point(55, 145);
            this.cbWombat4ABFreq.Name = "cbWombat4ABFreq";
            this.cbWombat4ABFreq.Size = new System.Drawing.Size(164, 23);
            this.cbWombat4ABFreq.TabIndex = 9;
            // 
            // ckbInvertSignal
            // 
            this.ckbInvertSignal.AutoSize = true;
            this.ckbInvertSignal.Location = new System.Drawing.Point(10, 104);
            this.ckbInvertSignal.Name = "ckbInvertSignal";
            this.ckbInvertSignal.Size = new System.Drawing.Size(91, 19);
            this.ckbInvertSignal.TabIndex = 6;
            this.ckbInvertSignal.Text = "Invert Signal";
            this.ckbInvertSignal.UseVisualStyleBackColor = true;
            // 
            // bSetPWM
            // 
            this.bSetPWM.Enabled = false;
            this.bSetPWM.Location = new System.Drawing.Point(198, 191);
            this.bSetPWM.Name = "bSetPWM";
            this.bSetPWM.Size = new System.Drawing.Size(85, 23);
            this.bSetPWM.TabIndex = 4;
            this.bSetPWM.Text = "Set PWM";
            this.bSetPWM.UseVisualStyleBackColor = true;
            this.bSetPWM.Click += new System.EventHandler(this.bSetDutyCycle_Click);
            // 
            // bConfigure
            // 
            this.bConfigure.Location = new System.Drawing.Point(55, 191);
            this.bConfigure.Name = "bConfigure";
            this.bConfigure.Size = new System.Drawing.Size(75, 23);
            this.bConfigure.TabIndex = 3;
            this.bConfigure.Text = "Configure";
            this.bConfigure.UseVisualStyleBackColor = true;
            // 
            // PWMControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "PWMControl";
            this.Size = new System.Drawing.Size(359, 228);
            this.Click += new System.EventHandler(this.bConfigure_Click);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lPeriod;
        private System.Windows.Forms.TextBox tbSW18ABPeriod;
        private System.Windows.Forms.ComboBox cbWombat4ABFreq;
        private System.Windows.Forms.CheckBox ckbInvertSignal;
        private System.Windows.Forms.Button bSetPWM;
        private System.Windows.Forms.Button bConfigure;
        private SixteenBitSliderInput sbsiDutyCycle;
    }
}
