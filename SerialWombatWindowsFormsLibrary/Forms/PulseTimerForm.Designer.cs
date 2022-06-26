namespace SerialWombatWindowsFormsLibrary
{
    partial class PulseTimerForm
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lDutyCycle = new System.Windows.Forms.Label();
            this.lFrequency = new System.Windows.Forms.Label();
            this.ckbAllValues = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPulses = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbLowCounts = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbHighCounts = new System.Windows.Forms.TextBox();
            this.formsPlot1 = new ScottPlot.FormsPlot();
            this.ckbAutosample = new System.Windows.Forms.CheckBox();
            this.bSample = new System.Windows.Forms.Button();
            this.bConfigure = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.lDutyCycle);
            this.groupBox1.Controls.Add(this.lFrequency);
            this.groupBox1.Controls.Add(this.ckbAllValues);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbPulses);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbLowCounts);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbHighCounts);
            this.groupBox1.Controls.Add(this.formsPlot1);
            this.groupBox1.Controls.Add(this.ckbAutosample);
            this.groupBox1.Controls.Add(this.bSample);
            this.groupBox1.Controls.Add(this.bConfigure);
            this.groupBox1.Location = new System.Drawing.Point(25, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(460, 509);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(208, 462);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Public Data:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(284, 458);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(170, 23);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lDutyCycle
            // 
            this.lDutyCycle.AutoSize = true;
            this.lDutyCycle.Location = new System.Drawing.Point(219, 428);
            this.lDutyCycle.Name = "lDutyCycle";
            this.lDutyCycle.Size = new System.Drawing.Size(38, 15);
            this.lDutyCycle.TabIndex = 8;
            this.lDutyCycle.Text = "label4";
            // 
            // lFrequency
            // 
            this.lFrequency.AutoSize = true;
            this.lFrequency.Location = new System.Drawing.Point(219, 458);
            this.lFrequency.Name = "lFrequency";
            this.lFrequency.Size = new System.Drawing.Size(0, 15);
            this.lFrequency.TabIndex = 7;
            // 
            // ckbAllValues
            // 
            this.ckbAllValues.AutoSize = true;
            this.ckbAllValues.Location = new System.Drawing.Point(241, 395);
            this.ckbAllValues.Name = "ckbAllValues";
            this.ckbAllValues.Size = new System.Drawing.Size(105, 19);
            this.ckbAllValues.TabIndex = 6;
            this.ckbAllValues.Text = "Read All Values";
            this.ckbAllValues.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 458);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Pulses";
            // 
            // tbPulses
            // 
            this.tbPulses.Location = new System.Drawing.Point(101, 455);
            this.tbPulses.Name = "tbPulses";
            this.tbPulses.Size = new System.Drawing.Size(100, 23);
            this.tbPulses.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 429);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Low Counts";
            // 
            // tbLowCounts
            // 
            this.tbLowCounts.Location = new System.Drawing.Point(101, 426);
            this.tbLowCounts.Name = "tbLowCounts";
            this.tbLowCounts.Size = new System.Drawing.Size(100, 23);
            this.tbLowCounts.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 398);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "High Counts";
            // 
            // tbHighCounts
            // 
            this.tbHighCounts.Location = new System.Drawing.Point(101, 395);
            this.tbHighCounts.Name = "tbHighCounts";
            this.tbHighCounts.Size = new System.Drawing.Size(100, 23);
            this.tbHighCounts.TabIndex = 4;
            // 
            // formsPlot1
            // 
            this.formsPlot1.Location = new System.Drawing.Point(0, 85);
            this.formsPlot1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.formsPlot1.Name = "formsPlot1";
            this.formsPlot1.Size = new System.Drawing.Size(442, 304);
            this.formsPlot1.TabIndex = 3;
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
            // PulseTimerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 547);
            this.Controls.Add(this.groupBox1);
            this.Name = "PulseTimerForm";
            this.Text = "PulseTimerForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PulseTimerForm_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox ckbAutosample;
        private System.Windows.Forms.Button bSample;
        private System.Windows.Forms.Button bConfigure;
        private ScottPlot.FormsPlot formsPlot1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPulses;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbLowCounts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbHighCounts;
        private System.Windows.Forms.CheckBox ckbAllValues;
        private System.Windows.Forms.Label lFrequency;
        private System.Windows.Forms.Label lDutyCycle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}