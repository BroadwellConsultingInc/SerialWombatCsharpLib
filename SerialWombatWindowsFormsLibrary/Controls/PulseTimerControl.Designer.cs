namespace SerialWombatWindowsFormsLibrary.Controls
{
    partial class PulseTimerControl
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
            this.label4 = new System.Windows.Forms.Label();
            this.lDutyCycle = new System.Windows.Forms.Label();
            this.lFrequency = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPulses = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbLowCounts = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbHighCounts = new System.Windows.Forms.TextBox();
            this.ckbAutosample = new System.Windows.Forms.CheckBox();
            this.bSample = new System.Windows.Forms.Button();
            this.bConfigure = new System.Windows.Forms.Button();
            this.realTimeScottPlot1 = new SerialWombatWindowsFormsLibrary.Controls.RealTimeScottPlot();
            this.enumDropdown1 = new SerialWombatWindowsFormsLibrary.EnumDropdown();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.enumDropdown1);
            this.groupBox1.Controls.Add(this.realTimeScottPlot1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lDutyCycle);
            this.groupBox1.Controls.Add(this.lFrequency);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbPulses);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbLowCounts);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbHighCounts);
            this.groupBox1.Controls.Add(this.ckbAutosample);
            this.groupBox1.Controls.Add(this.bSample);
            this.groupBox1.Controls.Add(this.bConfigure);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(460, 509);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 418);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Public Data Output:";
            // 
            // lDutyCycle
            // 
            this.lDutyCycle.AutoSize = true;
            this.lDutyCycle.Location = new System.Drawing.Point(219, 359);
            this.lDutyCycle.Name = "lDutyCycle";
            this.lDutyCycle.Size = new System.Drawing.Size(38, 15);
            this.lDutyCycle.TabIndex = 8;
            this.lDutyCycle.Text = "label4";
            // 
            // lFrequency
            // 
            this.lFrequency.AutoSize = true;
            this.lFrequency.Location = new System.Drawing.Point(219, 389);
            this.lFrequency.Name = "lFrequency";
            this.lFrequency.Size = new System.Drawing.Size(0, 15);
            this.lFrequency.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 389);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Pulses";
            // 
            // tbPulses
            // 
            this.tbPulses.Location = new System.Drawing.Point(101, 386);
            this.tbPulses.Name = "tbPulses";
            this.tbPulses.Size = new System.Drawing.Size(100, 23);
            this.tbPulses.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 360);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Low Counts";
            // 
            // tbLowCounts
            // 
            this.tbLowCounts.Location = new System.Drawing.Point(101, 357);
            this.tbLowCounts.Name = "tbLowCounts";
            this.tbLowCounts.Size = new System.Drawing.Size(100, 23);
            this.tbLowCounts.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 329);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "High Counts";
            // 
            // tbHighCounts
            // 
            this.tbHighCounts.Location = new System.Drawing.Point(101, 326);
            this.tbHighCounts.Name = "tbHighCounts";
            this.tbHighCounts.Size = new System.Drawing.Size(100, 23);
            this.tbHighCounts.TabIndex = 4;
            // 
            // ckbAutosample
            // 
            this.ckbAutosample.AutoSize = true;
            this.ckbAutosample.Location = new System.Drawing.Point(312, 34);
            this.ckbAutosample.Name = "ckbAutosample";
            this.ckbAutosample.Size = new System.Drawing.Size(91, 19);
            this.ckbAutosample.TabIndex = 2;
            this.ckbAutosample.Text = "AutoSample";
            this.ckbAutosample.UseVisualStyleBackColor = true;
            this.ckbAutosample.CheckedChanged += new System.EventHandler(this.ckbAutosample_CheckedChanged);
            // 
            // bSample
            // 
            this.bSample.Location = new System.Drawing.Point(126, 34);
            this.bSample.Name = "bSample";
            this.bSample.Size = new System.Drawing.Size(75, 23);
            this.bSample.TabIndex = 1;
            this.bSample.Text = "Sample";
            this.bSample.UseVisualStyleBackColor = true;
            this.bSample.Click += new System.EventHandler(this.bSample_Click);
            // 
            // bConfigure
            // 
            this.bConfigure.Location = new System.Drawing.Point(22, 35);
            this.bConfigure.Name = "bConfigure";
            this.bConfigure.Size = new System.Drawing.Size(75, 23);
            this.bConfigure.TabIndex = 0;
            this.bConfigure.Text = "Configure";
            this.bConfigure.UseVisualStyleBackColor = true;
            this.bConfigure.Click += new System.EventHandler(this.bConfigure_Click_1);
            // 
            // realTimeScottPlot1
            // 
            this.realTimeScottPlot1.Location = new System.Drawing.Point(6, 64);
            this.realTimeScottPlot1.Name = "realTimeScottPlot1";
            this.realTimeScottPlot1.Size = new System.Drawing.Size(429, 256);
            this.realTimeScottPlot1.TabIndex = 11;
            // 
            // enumDropdown1
            // 
            this.enumDropdown1.DropDownToolTip = "";
            this.enumDropdown1.dropdowntype = "SerialWombat.SerialWombatPulseTimerPublicData";
            this.enumDropdown1.Location = new System.Drawing.Point(22, 436);
            this.enumDropdown1.Name = "enumDropdown1";
            this.enumDropdown1.Size = new System.Drawing.Size(274, 35);
            this.enumDropdown1.TabIndex = 12;
            // 
            // PulseTimerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.groupBox1);
            this.Name = "PulseTimerControl";
            this.Size = new System.Drawing.Size(474, 524);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private RealTimeScottPlot realTimeScottPlot1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lDutyCycle;
        private System.Windows.Forms.Label lFrequency;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPulses;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbLowCounts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbHighCounts;
        private System.Windows.Forms.CheckBox ckbAutosample;
        private System.Windows.Forms.Button bSample;
        private System.Windows.Forms.Button bConfigure;
        private EnumDropdown enumDropdown1;
    }
}
