namespace SerialWombatWindowsFormsLibrary.Controls
{
    partial class PublicDataMonitorControl
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
            label6 = new System.Windows.Forms.Label();
            groupBox1 = new System.Windows.Forms.GroupBox();
            bSingleSample = new System.Windows.Forms.Button();
            bAdd = new System.Windows.Forms.Button();
            realTimeScottPlot1 = new RealTimeScottPlot();
            label1 = new System.Windows.Forms.Label();
            tbDataId = new System.Windows.Forms.TextBox();
            comboBox1 = new System.Windows.Forms.ComboBox();
            ckbAutosample = new System.Windows.Forms.CheckBox();
            splitContainer1 = new System.Windows.Forms.SplitContainer();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // label6
            // 
            label6.Location = new System.Drawing.Point(13, 70);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(422, 34);
            label6.TabIndex = 5;
            label6.Text = "Real time chart created with Scott Hardin's excellent  ScottPlot Library (https://swharden.com/scottplot/)";
            label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(splitContainer1);
            groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            groupBox1.Location = new System.Drawing.Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(487, 438);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // bSingleSample
            // 
            bSingleSample.Location = new System.Drawing.Point(351, 44);
            bSingleSample.Name = "bSingleSample";
            bSingleSample.Size = new System.Drawing.Size(75, 23);
            bSingleSample.TabIndex = 9;
            bSingleSample.Text = "Single Sample";
            bSingleSample.UseVisualStyleBackColor = true;
            bSingleSample.Click += bSample_Click;
            // 
            // bAdd
            // 
            bAdd.Location = new System.Drawing.Point(28, 38);
            bAdd.Name = "bAdd";
            bAdd.Size = new System.Drawing.Size(75, 23);
            bAdd.TabIndex = 8;
            bAdd.Text = "Add";
            bAdd.UseVisualStyleBackColor = true;
            bAdd.Click += bAdd_Click;
            // 
            // realTimeScottPlot1
            // 
            realTimeScottPlot1.Dock = System.Windows.Forms.DockStyle.Fill;
            realTimeScottPlot1.Location = new System.Drawing.Point(0, 0);
            realTimeScottPlot1.Name = "realTimeScottPlot1";
            realTimeScottPlot1.Size = new System.Drawing.Size(481, 305);
            realTimeScottPlot1.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(292, 11);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(42, 15);
            label1.TabIndex = 6;
            label1.Text = "DataID";
            // 
            // tbDataId
            // 
            tbDataId.Location = new System.Drawing.Point(340, 3);
            tbDataId.Name = "tbDataId";
            tbDataId.Size = new System.Drawing.Size(100, 23);
            tbDataId.TabIndex = 5;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new System.Drawing.Point(13, 3);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(274, 23);
            comboBox1.TabIndex = 4;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // ckbAutosample
            // 
            ckbAutosample.AutoSize = true;
            ckbAutosample.Location = new System.Drawing.Point(141, 42);
            ckbAutosample.Name = "ckbAutosample";
            ckbAutosample.Size = new System.Drawing.Size(90, 19);
            ckbAutosample.TabIndex = 3;
            ckbAutosample.Text = "Autosample";
            ckbAutosample.UseVisualStyleBackColor = true;
            ckbAutosample.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainer1.Location = new System.Drawing.Point(3, 19);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(comboBox1);
            splitContainer1.Panel1.Controls.Add(bSingleSample);
            splitContainer1.Panel1.Controls.Add(ckbAutosample);
            splitContainer1.Panel1.Controls.Add(label6);
            splitContainer1.Panel1.Controls.Add(tbDataId);
            splitContainer1.Panel1.Controls.Add(bAdd);
            splitContainer1.Panel1.Controls.Add(label1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(realTimeScottPlot1);
            splitContainer1.Size = new System.Drawing.Size(481, 416);
            splitContainer1.SplitterDistance = 107;
            splitContainer1.TabIndex = 10;
            // 
            // PublicDataMonitorControl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            Controls.Add(groupBox1);
            Name = "PublicDataMonitorControl";
            Size = new System.Drawing.Size(487, 438);
            groupBox1.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bAdd;
        private RealTimeScottPlot realTimeScottPlot1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbDataId;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox ckbAutosample;
        private System.Windows.Forms.Button bSingleSample;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}
