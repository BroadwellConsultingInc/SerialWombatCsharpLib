namespace SerialWombatWindowsFormsLibrary
{
    partial class WatchdogForm
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
            this.tbTimeout = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ckbReset = new System.Windows.Forms.CheckBox();
            this.tbTimeoutStateDuration = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbNormalState = new SerialWombatWindowsFormsLibrary.DigitalStateComboBox();
            this.cbTimeoutState = new SerialWombatWindowsFormsLibrary.DigitalStateComboBox();
            this.ckbOverride = new System.Windows.Forms.CheckBox();
            this.gbPins = new System.Windows.Forms.GroupBox();
            this.cbP3 = new SerialWombatWindowsFormsLibrary.DigitalStateComboBox();
            this.cbP1 = new SerialWombatWindowsFormsLibrary.DigitalStateComboBox();
            this.cbP2 = new SerialWombatWindowsFormsLibrary.DigitalStateComboBox();
            this.cbP0 = new SerialWombatWindowsFormsLibrary.DigitalStateComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bConfigure = new System.Windows.Forms.Button();
            this.gbPins.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbTimeout
            // 
            this.tbTimeout.Location = new System.Drawing.Point(100, 53);
            this.tbTimeout.Name = "tbTimeout";
            this.tbTimeout.Size = new System.Drawing.Size(100, 23);
            this.tbTimeout.TabIndex = 0;
            this.tbTimeout.Text = "65535";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Timeout (mS):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Normal State:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Timeout State:";
            // 
            // ckbReset
            // 
            this.ckbReset.AutoSize = true;
            this.ckbReset.Location = new System.Drawing.Point(15, 148);
            this.ckbReset.Name = "ckbReset";
            this.ckbReset.Size = new System.Drawing.Size(177, 19);
            this.ckbReset.TabIndex = 4;
            this.ckbReset.Text = "Reset Wombat after Timeout";
            this.ckbReset.UseVisualStyleBackColor = true;
            // 
            // tbTimeoutStateDuration
            // 
            this.tbTimeoutStateDuration.Location = new System.Drawing.Point(178, 119);
            this.tbTimeoutStateDuration.Name = "tbTimeoutStateDuration";
            this.tbTimeoutStateDuration.Size = new System.Drawing.Size(100, 23);
            this.tbTimeoutStateDuration.TabIndex = 0;
            this.tbTimeoutStateDuration.Text = "65535";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Timeout State Duration (mS):";
            // 
            // cbNormalState
            // 
            this.cbNormalState.Location = new System.Drawing.Point(100, 21);
            this.cbNormalState.Name = "cbNormalState";
            this.cbNormalState.Size = new System.Drawing.Size(152, 26);
            this.cbNormalState.TabIndex = 5;
            // 
            // cbTimeoutState
            // 
            this.cbTimeoutState.Location = new System.Drawing.Point(101, 82);
            this.cbTimeoutState.Name = "cbTimeoutState";
            this.cbTimeoutState.Size = new System.Drawing.Size(152, 26);
            this.cbTimeoutState.TabIndex = 5;
            // 
            // ckbOverride
            // 
            this.ckbOverride.AutoSize = true;
            this.ckbOverride.Location = new System.Drawing.Point(15, 173);
            this.ckbOverride.Name = "ckbOverride";
            this.ckbOverride.Size = new System.Drawing.Size(199, 19);
            this.ckbOverride.TabIndex = 6;
            this.ckbOverride.Text = "Reconfigure Pins 0-3 on Timeout";
            this.ckbOverride.UseVisualStyleBackColor = true;
            this.ckbOverride.CheckedChanged += new System.EventHandler(this.ckbOverride_CheckedChanged);
            // 
            // gbPins
            // 
            this.gbPins.Controls.Add(this.cbP3);
            this.gbPins.Controls.Add(this.cbP1);
            this.gbPins.Controls.Add(this.cbP2);
            this.gbPins.Controls.Add(this.cbP0);
            this.gbPins.Controls.Add(this.label8);
            this.gbPins.Controls.Add(this.label7);
            this.gbPins.Controls.Add(this.label6);
            this.gbPins.Controls.Add(this.label5);
            this.gbPins.Location = new System.Drawing.Point(15, 199);
            this.gbPins.Name = "gbPins";
            this.gbPins.Size = new System.Drawing.Size(263, 163);
            this.gbPins.TabIndex = 7;
            this.gbPins.TabStop = false;
            // 
            // cbP3
            // 
            this.cbP3.Location = new System.Drawing.Point(43, 122);
            this.cbP3.Name = "cbP3";
            this.cbP3.Size = new System.Drawing.Size(152, 26);
            this.cbP3.TabIndex = 5;
            // 
            // cbP1
            // 
            this.cbP1.Location = new System.Drawing.Point(43, 56);
            this.cbP1.Name = "cbP1";
            this.cbP1.Size = new System.Drawing.Size(152, 26);
            this.cbP1.TabIndex = 5;
            // 
            // cbP2
            // 
            this.cbP2.Location = new System.Drawing.Point(43, 88);
            this.cbP2.Name = "cbP2";
            this.cbP2.Size = new System.Drawing.Size(152, 26);
            this.cbP2.TabIndex = 5;
            // 
            // cbP0
            // 
            this.cbP0.Location = new System.Drawing.Point(43, 22);
            this.cbP0.Name = "cbP0";
            this.cbP0.Size = new System.Drawing.Size(152, 26);
            this.cbP0.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 15);
            this.label8.TabIndex = 3;
            this.label8.Text = "Pin 3:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 15);
            this.label7.TabIndex = 3;
            this.label7.Text = "Pin 2:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 15);
            this.label6.TabIndex = 3;
            this.label6.Text = "Pin 1:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Pin 0:";
            // 
            // bConfigure
            // 
            this.bConfigure.Location = new System.Drawing.Point(249, 53);
            this.bConfigure.Name = "bConfigure";
            this.bConfigure.Size = new System.Drawing.Size(75, 23);
            this.bConfigure.TabIndex = 8;
            this.bConfigure.Text = "Configure";
            this.bConfigure.UseVisualStyleBackColor = true;
            this.bConfigure.Click += new System.EventHandler(this.bConfigure_Click);
            // 
            // WatchdogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bConfigure);
            this.Controls.Add(this.gbPins);
            this.Controls.Add(this.ckbOverride);
            this.Controls.Add(this.cbTimeoutState);
            this.Controls.Add(this.cbNormalState);
            this.Controls.Add(this.ckbReset);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbTimeoutStateDuration);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbTimeout);
            this.Name = "WatchdogForm";
            this.Text = "WatchdogForm";
            this.gbPins.ResumeLayout(false);
            this.gbPins.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbTimeout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox ckbReset;
        private System.Windows.Forms.TextBox tbTimeoutStateDuration;
        private System.Windows.Forms.Label label4;
        private DigitalStateComboBox cbNormalState;
        private DigitalStateComboBox cbTimeoutState;
        private System.Windows.Forms.CheckBox ckbOverride;
        private System.Windows.Forms.GroupBox gbPins;
        private DigitalStateComboBox cbP0;
        private System.Windows.Forms.Label label5;
        private DigitalStateComboBox cbP1;
        private DigitalStateComboBox cbP2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bConfigure;
        private DigitalStateComboBox cbP3;
    }
}