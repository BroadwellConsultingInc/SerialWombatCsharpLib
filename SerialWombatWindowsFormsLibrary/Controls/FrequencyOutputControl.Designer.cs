namespace SerialWombatWindowsFormsLibrary.Controls
{
    partial class FrequencyOutputControl
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.sbsiDutyCycle = new SerialWombatWindowsFormsLibrary.SixteenBitSliderInput();
            this.button4 = new System.Windows.Forms.Button();
            this.sbsiMaxFrequency = new SerialWombatWindowsFormsLibrary.SixteenBitSliderInput();
            this.bConfigure = new System.Windows.Forms.Button();
            this.sbsiFrequency = new SerialWombatWindowsFormsLibrary.SixteenBitSliderInput();
            this.ckbLowFrequency = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.sbsiFrequency);
            this.groupBox1.Location = new System.Drawing.Point(8, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(346, 359);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ckbLowFrequency);
            this.groupBox2.Controls.Add(this.sbsiDutyCycle);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.sbsiMaxFrequency);
            this.groupBox2.Controls.Add(this.bConfigure);
            this.groupBox2.Location = new System.Drawing.Point(10, 104);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(328, 237);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Configure";
            // 
            // sbsiDutyCycle
            // 
            this.sbsiDutyCycle.Location = new System.Drawing.Point(14, 90);
            this.sbsiDutyCycle.Maximum = 65535;
            this.sbsiDutyCycle.Minimum = 0;
            this.sbsiDutyCycle.Name = "sbsiDutyCycle";
            this.sbsiDutyCycle.Size = new System.Drawing.Size(283, 76);
            this.sbsiDutyCycle.TabIndex = 0;
            this.sbsiDutyCycle.Text = "Duty Cycle";
            this.sbsiDutyCycle.TextBoxHint = "";
            this.sbsiDutyCycle.value = ((ushort)(32768));
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.MediumPurple;
            this.button4.Location = new System.Drawing.Point(252, 172);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(45, 47);
            this.button4.TabIndex = 30;
            this.button4.Text = "Gen Code";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // sbsiMaxFrequency
            // 
            this.sbsiMaxFrequency.Location = new System.Drawing.Point(14, 22);
            this.sbsiMaxFrequency.Maximum = 65535;
            this.sbsiMaxFrequency.Minimum = 0;
            this.sbsiMaxFrequency.Name = "sbsiMaxFrequency";
            this.sbsiMaxFrequency.Size = new System.Drawing.Size(283, 76);
            this.sbsiMaxFrequency.TabIndex = 0;
            this.sbsiMaxFrequency.Text = "Max Frequency (Hz)";
            this.sbsiMaxFrequency.TextBoxHint = "";
            this.sbsiMaxFrequency.value = ((ushort)(65535));
            // 
            // bConfigure
            // 
            this.bConfigure.Location = new System.Drawing.Point(14, 196);
            this.bConfigure.Name = "bConfigure";
            this.bConfigure.Size = new System.Drawing.Size(75, 23);
            this.bConfigure.TabIndex = 3;
            this.bConfigure.Text = "Configure";
            this.bConfigure.UseVisualStyleBackColor = true;
            this.bConfigure.Click += new System.EventHandler(this.bConfigure_Click);
            // 
            // sbsiFrequency
            // 
            this.sbsiFrequency.Enabled = false;
            this.sbsiFrequency.Location = new System.Drawing.Point(10, 22);
            this.sbsiFrequency.Maximum = 65535;
            this.sbsiFrequency.Minimum = 0;
            this.sbsiFrequency.Name = "sbsiFrequency";
            this.sbsiFrequency.Size = new System.Drawing.Size(328, 76);
            this.sbsiFrequency.TabIndex = 13;
            this.sbsiFrequency.Text = "Freq Hz (0-65535)";
            this.sbsiFrequency.TextBoxHint = "";
            this.sbsiFrequency.value = ((ushort)(0));
            // 
            // ckbLowFrequency
            // 
            this.ckbLowFrequency.AutoSize = true;
            this.ckbLowFrequency.Location = new System.Drawing.Point(22, 164);
            this.ckbLowFrequency.Name = "ckbLowFrequency";
            this.ckbLowFrequency.Size = new System.Drawing.Size(218, 19);
            this.ckbLowFrequency.TabIndex = 31;
            this.ckbLowFrequency.Text = "Low Freqeuncy Output (under 20Hz)";
            this.ckbLowFrequency.UseVisualStyleBackColor = true;
            // 
            // FrequencyOutputControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.groupBox1);
            this.Name = "FrequencyOutputControl";
            this.Size = new System.Drawing.Size(357, 368);
            this.Load += new System.EventHandler(this.FrequencyOutputControl_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private SixteenBitSliderInput sbsiDutyCycle;
        private System.Windows.Forms.Button button4;
        private SixteenBitSliderInput sbsiMaxFrequency;
        private System.Windows.Forms.Button bConfigure;
        private SixteenBitSliderInput sbsiFrequency;
        private System.Windows.Forms.CheckBox ckbLowFrequency;
    }
}
