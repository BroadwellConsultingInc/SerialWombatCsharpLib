namespace SerialWombatWindowsFormsLibrary.Controls
{
    partial class UltrasonicDistanceSensorControl
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
            this.realTimeScottPlot1 = new SerialWombatWindowsFormsLibrary.Controls.RealTimeScottPlot();
            this.bConfigure = new System.Windows.Forms.Button();
            this.tbTriggerPin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ckbAutosample = new System.Windows.Forms.CheckBox();
            this.bSample = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.realTimeScottPlot1);
            this.groupBox1.Controls.Add(this.bConfigure);
            this.groupBox1.Controls.Add(this.tbTriggerPin);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ckbAutosample);
            this.groupBox1.Controls.Add(this.bSample);
            this.groupBox1.Location = new System.Drawing.Point(7, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(428, 404);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // realTimeScottPlot1
            // 
            this.realTimeScottPlot1.Location = new System.Drawing.Point(12, 137);
            this.realTimeScottPlot1.Name = "realTimeScottPlot1";
            this.realTimeScottPlot1.Size = new System.Drawing.Size(429, 256);
            this.realTimeScottPlot1.TabIndex = 8;
            // 
            // bConfigure
            // 
            this.bConfigure.Location = new System.Drawing.Point(6, 59);
            this.bConfigure.Name = "bConfigure";
            this.bConfigure.Size = new System.Drawing.Size(75, 23);
            this.bConfigure.TabIndex = 7;
            this.bConfigure.Text = "Configure";
            this.bConfigure.UseVisualStyleBackColor = true;
            this.bConfigure.Click += new System.EventHandler(this.bConfigure_Click);
            // 
            // tbTriggerPin
            // 
            this.tbTriggerPin.Location = new System.Drawing.Point(81, 99);
            this.tbTriggerPin.Name = "tbTriggerPin";
            this.tbTriggerPin.Size = new System.Drawing.Size(100, 23);
            this.tbTriggerPin.TabIndex = 5;
            this.tbTriggerPin.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Trigger Pin:";
            // 
            // ckbAutosample
            // 
            this.ckbAutosample.AutoSize = true;
            this.ckbAutosample.Location = new System.Drawing.Point(288, 26);
            this.ckbAutosample.Name = "ckbAutosample";
            this.ckbAutosample.Size = new System.Drawing.Size(90, 19);
            this.ckbAutosample.TabIndex = 3;
            this.ckbAutosample.Text = "Autosample";
            this.ckbAutosample.UseVisualStyleBackColor = true;
            this.ckbAutosample.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // bSample
            // 
            this.bSample.Location = new System.Drawing.Point(6, 22);
            this.bSample.Name = "bSample";
            this.bSample.Size = new System.Drawing.Size(75, 23);
            this.bSample.TabIndex = 2;
            this.bSample.Text = "Sample";
            this.bSample.UseVisualStyleBackColor = true;
            this.bSample.Click += new System.EventHandler(this.bSample_Click);
            // 
            // UltrasonicDistanceSensorControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.groupBox1);
            this.Name = "UltrasonicDistanceSensorControl";
            this.Size = new System.Drawing.Size(438, 415);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bConfigure;
        private System.Windows.Forms.TextBox tbTriggerPin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ckbAutosample;
        private System.Windows.Forms.Button bSample;
        private RealTimeScottPlot realTimeScottPlot1;
    }
}
