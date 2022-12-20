namespace SerialWombatWindowsFormsLibrary.Controls
{
    partial class SW18ABCapTouchControl
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
            this.bConfigure = new System.Windows.Forms.Button();
            this.sbsiChargeTime = new SerialWombatWindowsFormsLibrary.SixteenBitSliderInput();
            this.ckbAutosample = new System.Windows.Forms.CheckBox();
            this.bSample = new System.Windows.Forms.Button();
            this.realTimeScottPlot1 = new SerialWombatWindowsFormsLibrary.Controls.RealTimeScottPlot();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.realTimeScottPlot1);
            this.groupBox1.Controls.Add(this.ckbAutosample);
            this.groupBox1.Controls.Add(this.bSample);
            this.groupBox1.Controls.Add(this.sbsiChargeTime);
            this.groupBox1.Controls.Add(this.bConfigure);
            this.groupBox1.Location = new System.Drawing.Point(3, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(454, 417);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // bConfigure
            // 
            this.bConfigure.Location = new System.Drawing.Point(19, 26);
            this.bConfigure.Name = "bConfigure";
            this.bConfigure.Size = new System.Drawing.Size(75, 23);
            this.bConfigure.TabIndex = 0;
            this.bConfigure.Text = "Configure";
            this.bConfigure.UseVisualStyleBackColor = true;
            this.bConfigure.Click += new System.EventHandler(this.bConfigure_Click);
            // 
            // sbsiChargeTime
            // 
            this.sbsiChargeTime.Location = new System.Drawing.Point(55, 57);
            this.sbsiChargeTime.Name = "sbsiChargeTime";
            this.sbsiChargeTime.Size = new System.Drawing.Size(328, 76);
            this.sbsiChargeTime.TabIndex = 1;
            this.sbsiChargeTime.Text = "Charge Time";
            this.sbsiChargeTime.TextBoxHint = "";
            this.sbsiChargeTime.value = ((ushort)(5000));
            // 
            // ckbAutosample
            // 
            this.ckbAutosample.AutoSize = true;
            this.ckbAutosample.Location = new System.Drawing.Point(225, 29);
            this.ckbAutosample.Name = "ckbAutosample";
            this.ckbAutosample.Size = new System.Drawing.Size(90, 19);
            this.ckbAutosample.TabIndex = 5;
            this.ckbAutosample.Text = "Autosample";
            this.ckbAutosample.UseVisualStyleBackColor = true;
            this.ckbAutosample.CheckedChanged += new System.EventHandler(this.ckbAutosample_CheckedChanged);
            // 
            // bSample
            // 
            this.bSample.Location = new System.Drawing.Point(124, 26);
            this.bSample.Name = "bSample";
            this.bSample.Size = new System.Drawing.Size(75, 23);
            this.bSample.TabIndex = 4;
            this.bSample.Text = "Sample";
            this.bSample.UseVisualStyleBackColor = true;
            this.bSample.Click += new System.EventHandler(this.bSample_Click);
            // 
            // realTimeScottPlot1
            // 
            this.realTimeScottPlot1.Location = new System.Drawing.Point(19, 139);
            this.realTimeScottPlot1.Name = "realTimeScottPlot1";
            this.realTimeScottPlot1.Size = new System.Drawing.Size(429, 256);
            this.realTimeScottPlot1.TabIndex = 10;
            // 
            // SW18ABCapTouchControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.groupBox1);
            this.Name = "SW18ABCapTouchControl";
            this.Size = new System.Drawing.Size(460, 420);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bConfigure;
        private SixteenBitSliderInput sbsiChargeTime;
        private System.Windows.Forms.CheckBox ckbAutosample;
        private System.Windows.Forms.Button bSample;
        private RealTimeScottPlot realTimeScottPlot1;
    }
}
