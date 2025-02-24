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
            components = new System.ComponentModel.Container();
            groupBox1 = new System.Windows.Forms.GroupBox();
            groupBox2 = new System.Windows.Forms.GroupBox();
            ckbLowFrequency = new System.Windows.Forms.CheckBox();
            sbsiDutyCycle = new SixteenBitSliderInput();
            button4 = new System.Windows.Forms.Button();
            sbsiMaxFrequency = new SixteenBitSliderInput();
            bConfigure = new System.Windows.Forms.Button();
            sbsiFrequency = new SixteenBitSliderInput();
            toolTip1 = new System.Windows.Forms.ToolTip(components);
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(sbsiFrequency);
            groupBox1.Location = new System.Drawing.Point(8, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(346, 359);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(ckbLowFrequency);
            groupBox2.Controls.Add(sbsiDutyCycle);
            groupBox2.Controls.Add(button4);
            groupBox2.Controls.Add(sbsiMaxFrequency);
            groupBox2.Controls.Add(bConfigure);
            groupBox2.Location = new System.Drawing.Point(10, 104);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(328, 237);
            groupBox2.TabIndex = 31;
            groupBox2.TabStop = false;
            groupBox2.Text = "Configure";
            // 
            // ckbLowFrequency
            // 
            ckbLowFrequency.AutoSize = true;
            ckbLowFrequency.Location = new System.Drawing.Point(22, 164);
            ckbLowFrequency.Name = "ckbLowFrequency";
            ckbLowFrequency.Size = new System.Drawing.Size(218, 19);
            ckbLowFrequency.TabIndex = 31;
            ckbLowFrequency.Text = "Low Freqeuncy Output (under 20Hz)";
            toolTip1.SetToolTip(ckbLowFrequency, "Check this box for slow outputs.  This will make higher frequencies worse");
            ckbLowFrequency.UseVisualStyleBackColor = true;
            // 
            // sbsiDutyCycle
            // 
            sbsiDutyCycle.Location = new System.Drawing.Point(14, 90);
            sbsiDutyCycle.Maximum = 65535;
            sbsiDutyCycle.Minimum = 0;
            sbsiDutyCycle.Name = "sbsiDutyCycle";
            sbsiDutyCycle.Size = new System.Drawing.Size(283, 76);
            sbsiDutyCycle.TabIndex = 0;
            sbsiDutyCycle.Text = "Duty Cycle";
            sbsiDutyCycle.TextBoxHint = "";
            toolTip1.SetToolTip(sbsiDutyCycle, "Duty cycle of output waveform");
            sbsiDutyCycle.value = (ushort)32768;
            // 
            // button4
            // 
            button4.BackColor = System.Drawing.Color.MediumPurple;
            button4.Location = new System.Drawing.Point(252, 172);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(45, 47);
            button4.TabIndex = 30;
            button4.Text = "Gen Code";
            toolTip1.SetToolTip(button4, "Generate Frequency Output Arduino initialization code");
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // sbsiMaxFrequency
            // 
            sbsiMaxFrequency.Location = new System.Drawing.Point(14, 22);
            sbsiMaxFrequency.Maximum = 65535;
            sbsiMaxFrequency.Minimum = 0;
            sbsiMaxFrequency.Name = "sbsiMaxFrequency";
            sbsiMaxFrequency.Size = new System.Drawing.Size(283, 76);
            sbsiMaxFrequency.TabIndex = 0;
            sbsiMaxFrequency.Text = "Max Frequency (Hz)";
            sbsiMaxFrequency.TextBoxHint = "";
            toolTip1.SetToolTip(sbsiMaxFrequency, "Setting the maximum frequency to be output on this pin helps the Serial Wombat firmware allocate resources");
            sbsiMaxFrequency.value = ushort.MaxValue;
            // 
            // bConfigure
            // 
            bConfigure.Location = new System.Drawing.Point(14, 196);
            bConfigure.Name = "bConfigure";
            bConfigure.Size = new System.Drawing.Size(75, 23);
            bConfigure.TabIndex = 3;
            bConfigure.Text = "Configure";
            toolTip1.SetToolTip(bConfigure, "Enable frequency output pin mode and send all parameters to Serial Wombat chip");
            bConfigure.UseVisualStyleBackColor = true;
            bConfigure.Click += bConfigure_Click;
            // 
            // sbsiFrequency
            // 
            sbsiFrequency.Enabled = false;
            sbsiFrequency.Location = new System.Drawing.Point(10, 22);
            sbsiFrequency.Maximum = 65535;
            sbsiFrequency.Minimum = 0;
            sbsiFrequency.Name = "sbsiFrequency";
            sbsiFrequency.Size = new System.Drawing.Size(328, 76);
            sbsiFrequency.TabIndex = 13;
            sbsiFrequency.Text = "Freq Hz (0-65535)";
            sbsiFrequency.TextBoxHint = "";
            toolTip1.SetToolTip(sbsiFrequency, "Frequency to output (Actual output will be an approximation)");
            sbsiFrequency.value = (ushort)0;
            // 
            // FrequencyOutputControl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(groupBox1);
            Name = "FrequencyOutputControl";
            Size = new System.Drawing.Size(357, 368);
            Load += FrequencyOutputControl_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
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
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
