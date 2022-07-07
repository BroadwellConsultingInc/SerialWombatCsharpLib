
namespace SerialWombatWindowsFormsLibrary
{
    partial class PublicDataMonitorForm
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
            this.label6 = new System.Windows.Forms.Label();
            this.bSample = new System.Windows.Forms.Button();
            this.ckbAutosample = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.realTimeScottPlot1 = new SerialWombatWindowsFormsLibrary.Controls.RealTimeScottPlot();
            this.label1 = new System.Windows.Forms.Label();
            this.tbDataId = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(19, 488);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(494, 34);
            this.label6.TabIndex = 3;
            this.label6.Text = "Real time chart created with Scott Hardin\'s excellent  ScottPlot Library (https:/" +
    "/swharden.com/scottplot/)";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bSample
            // 
            this.bSample.Location = new System.Drawing.Point(103, 22);
            this.bSample.Name = "bSample";
            this.bSample.Size = new System.Drawing.Size(75, 23);
            this.bSample.TabIndex = 2;
            this.bSample.Text = "Sample";
            this.bSample.UseVisualStyleBackColor = true;
            this.bSample.Click += new System.EventHandler(this.bSample_Click);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.realTimeScottPlot1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbDataId);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.ckbAutosample);
            this.groupBox1.Controls.Add(this.bSample);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(440, 473);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // realTimeScottPlot1
            // 
            this.realTimeScottPlot1.Location = new System.Drawing.Point(0, 159);
            this.realTimeScottPlot1.Name = "realTimeScottPlot1";
            this.realTimeScottPlot1.Size = new System.Drawing.Size(429, 256);
            this.realTimeScottPlot1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "DataID";
            // 
            // tbDataId
            // 
            this.tbDataId.Location = new System.Drawing.Point(134, 116);
            this.tbDataId.Name = "tbDataId";
            this.tbDataId.Size = new System.Drawing.Size(100, 23);
            this.tbDataId.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(69, 75);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(274, 23);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // PublicDataMonitorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 538);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Name = "PublicDataMonitorForm";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AnalogInputForm_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bSample;
        private System.Windows.Forms.CheckBox ckbAutosample;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbDataId;
        private Controls.RealTimeScottPlot realTimeScottPlot1;
    }
}
