namespace SerialWombatWindowsFormsLibrary
{
    partial class AnalogInputControl
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
            label6 = new System.Windows.Forms.Label();
            groupBox1 = new System.Windows.Forms.GroupBox();
            linkLabel2 = new System.Windows.Forms.LinkLabel();
            linkLabel1 = new System.Windows.Forms.LinkLabel();
            bGenCode = new System.Windows.Forms.Button();
            realTimeScottPlot1 = new Controls.RealTimeScottPlot();
            ckbVolts = new System.Windows.Forms.CheckBox();
            ckbAllValues = new System.Windows.Forms.CheckBox();
            comboBox1 = new System.Windows.Forms.ComboBox();
            tbFilterConstant = new System.Windows.Forms.TextBox();
            tbMax = new System.Windows.Forms.TextBox();
            tbAveraged = new System.Windows.Forms.TextBox();
            tbMin = new System.Windows.Forms.TextBox();
            tbFiltered = new System.Windows.Forms.TextBox();
            tbRaw = new System.Windows.Forms.TextBox();
            label8 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            tbAverage = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ckbAutosample = new System.Windows.Forms.CheckBox();
            bSample = new System.Windows.Forms.Button();
            bConfigure = new System.Windows.Forms.Button();
            toolTip1 = new System.Windows.Forms.ToolTip(components);
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label6
            // 
            label6.Location = new System.Drawing.Point(7, 479);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(494, 34);
            label6.TabIndex = 3;
            label6.Text = "Real time chart created with Scott Hardin's excellent  ScottPlot Library (https://swharden.com/scottplot/)";
            label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(linkLabel2);
            groupBox1.Controls.Add(linkLabel1);
            groupBox1.Controls.Add(bGenCode);
            groupBox1.Controls.Add(realTimeScottPlot1);
            groupBox1.Controls.Add(ckbVolts);
            groupBox1.Controls.Add(ckbAllValues);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(tbFilterConstant);
            groupBox1.Controls.Add(tbMax);
            groupBox1.Controls.Add(tbAveraged);
            groupBox1.Controls.Add(tbMin);
            groupBox1.Controls.Add(tbFiltered);
            groupBox1.Controls.Add(tbRaw);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(tbAverage);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(ckbAutosample);
            groupBox1.Controls.Add(bSample);
            groupBox1.Controls.Add(bConfigure);
            groupBox1.Location = new System.Drawing.Point(0, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(530, 473);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Location = new System.Drawing.Point(403, 43);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new System.Drawing.Size(80, 15);
            linkLabel2.TabIndex = 32;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Tutorial Video";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new System.Drawing.Point(401, 87);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new System.Drawing.Size(120, 15);
            linkLabel1.TabIndex = 31;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Class Documentation";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // bGenCode
            // 
            bGenCode.BackColor = System.Drawing.Color.MediumPurple;
            bGenCode.Enabled = false;
            bGenCode.Location = new System.Drawing.Point(216, 11);
            bGenCode.Name = "bGenCode";
            bGenCode.Size = new System.Drawing.Size(45, 47);
            bGenCode.TabIndex = 30;
            bGenCode.TabStop = false;
            bGenCode.Text = "Gen Code";
            toolTip1.SetToolTip(bGenCode, "Generate Arduino initalization code for Analog Input");
            bGenCode.UseVisualStyleBackColor = false;
            bGenCode.Click += button4_Click;
            // 
            // realTimeScottPlot1
            // 
            realTimeScottPlot1.Location = new System.Drawing.Point(29, 116);
            realTimeScottPlot1.Name = "realTimeScottPlot1";
            realTimeScottPlot1.Size = new System.Drawing.Size(429, 256);
            realTimeScottPlot1.TabIndex = 5;
            // 
            // ckbVolts
            // 
            ckbVolts.AutoSize = true;
            ckbVolts.Location = new System.Drawing.Point(216, 454);
            ckbVolts.Name = "ckbVolts";
            ckbVolts.Size = new System.Drawing.Size(51, 19);
            ckbVolts.TabIndex = 8;
            ckbVolts.Text = "Volts";
            ckbVolts.UseVisualStyleBackColor = true;
            ckbVolts.CheckedChanged += ckbVolts_CheckedChanged;
            // 
            // ckbAllValues
            // 
            ckbAllValues.AutoSize = true;
            ckbAllValues.Checked = true;
            ckbAllValues.CheckState = System.Windows.Forms.CheckState.Checked;
            ckbAllValues.Location = new System.Drawing.Point(216, 433);
            ckbAllValues.Name = "ckbAllValues";
            ckbAllValues.Size = new System.Drawing.Size(69, 19);
            ckbAllValues.TabIndex = 7;
            ckbAllValues.Text = "Read All";
            ckbAllValues.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Raw = 0", "Filtered = 1", "Average = 2,", "Minimum = 3", "Maximum = 4" });
            comboBox1.Location = new System.Drawing.Point(274, 60);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(121, 23);
            comboBox1.TabIndex = 3;
            comboBox1.Tag = "";
            // 
            // tbFilterConstant
            // 
            tbFilterConstant.Location = new System.Drawing.Point(149, 87);
            tbFilterConstant.Name = "tbFilterConstant";
            tbFilterConstant.Size = new System.Drawing.Size(100, 23);
            tbFilterConstant.TabIndex = 4;
            tbFilterConstant.Text = "65408";
            // 
            // tbMax
            // 
            tbMax.Location = new System.Drawing.Point(403, 434);
            tbMax.Name = "tbMax";
            tbMax.Size = new System.Drawing.Size(100, 23);
            tbMax.TabIndex = 5;
            tbMax.TabStop = false;
            tbMax.Text = "0";
            // 
            // tbAveraged
            // 
            tbAveraged.Location = new System.Drawing.Point(69, 434);
            tbAveraged.Name = "tbAveraged";
            tbAveraged.Size = new System.Drawing.Size(100, 23);
            tbAveraged.TabIndex = 5;
            tbAveraged.TabStop = false;
            tbAveraged.Text = "0";
            // 
            // tbMin
            // 
            tbMin.Location = new System.Drawing.Point(401, 399);
            tbMin.Name = "tbMin";
            tbMin.Size = new System.Drawing.Size(100, 23);
            tbMin.TabIndex = 5;
            tbMin.TabStop = false;
            tbMin.Text = "0";
            // 
            // tbFiltered
            // 
            tbFiltered.Location = new System.Drawing.Point(258, 399);
            tbFiltered.Name = "tbFiltered";
            tbFiltered.Size = new System.Drawing.Size(100, 23);
            tbFiltered.TabIndex = 5;
            tbFiltered.TabStop = false;
            tbFiltered.Text = "0";
            // 
            // tbRaw
            // 
            tbRaw.Location = new System.Drawing.Point(69, 399);
            tbRaw.Name = "tbRaw";
            tbRaw.Size = new System.Drawing.Size(100, 23);
            tbRaw.TabIndex = 5;
            tbRaw.TabStop = false;
            tbRaw.Text = "0";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(364, 437);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(33, 15);
            label8.TabIndex = 4;
            label8.Text = "Max:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(0, 437);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(53, 15);
            label4.TabIndex = 4;
            label4.Text = "Average:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(364, 402);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(31, 15);
            label7.TabIndex = 4;
            label7.Text = "Min:";
            // 
            // tbAverage
            // 
            tbAverage.Location = new System.Drawing.Point(121, 60);
            tbAverage.Name = "tbAverage";
            tbAverage.Size = new System.Drawing.Size(100, 23);
            tbAverage.TabIndex = 2;
            tbAverage.Text = "64";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(189, 402);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(49, 15);
            label5.TabIndex = 4;
            label5.Text = "Filtered:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(0, 402);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(32, 15);
            label3.TabIndex = 4;
            label3.Text = "Raw:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(7, 91);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(139, 15);
            label2.TabIndex = 4;
            label2.Text = "Filter Constant (0-65535):";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(0, 63);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(115, 15);
            label1.TabIndex = 4;
            label1.Text = "Samples To Average:";
            // 
            // ckbAutosample
            // 
            ckbAutosample.AutoSize = true;
            ckbAutosample.Enabled = false;
            ckbAutosample.Location = new System.Drawing.Point(288, 26);
            ckbAutosample.Name = "ckbAutosample";
            ckbAutosample.Size = new System.Drawing.Size(90, 19);
            ckbAutosample.TabIndex = 3;
            ckbAutosample.Text = "Autosample";
            toolTip1.SetToolTip(ckbAutosample, "Continuously read pin's public data and graph (Asynchronous reads)");
            ckbAutosample.UseVisualStyleBackColor = true;
            ckbAutosample.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // bSample
            // 
            bSample.Enabled = false;
            bSample.Location = new System.Drawing.Point(103, 22);
            bSample.Name = "bSample";
            bSample.Size = new System.Drawing.Size(75, 23);
            bSample.TabIndex = 1;
            bSample.Text = "Sample";
            toolTip1.SetToolTip(bSample, "Read one sample from the Pin mode and chart it");
            bSample.UseVisualStyleBackColor = true;
            bSample.Click += bSample_Click;
            // 
            // bConfigure
            // 
            bConfigure.Location = new System.Drawing.Point(7, 22);
            bConfigure.Name = "bConfigure";
            bConfigure.Size = new System.Drawing.Size(75, 23);
            bConfigure.TabIndex = 0;
            bConfigure.Text = "Configure";
            toolTip1.SetToolTip(bConfigure, "Set pin to Analog input and configure Average and Filter, and Public output type");
            bConfigure.UseVisualStyleBackColor = true;
            bConfigure.Click += bConfigure_Click;
            // 
            // AnalogInputControl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            Controls.Add(label6);
            Controls.Add(groupBox1);
            Name = "AnalogInputControl";
            Size = new System.Drawing.Size(533, 513);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox ckbVolts;
        private System.Windows.Forms.CheckBox ckbAllValues;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox tbFilterConstant;
        private System.Windows.Forms.TextBox tbMax;
        private System.Windows.Forms.TextBox tbAveraged;
        private System.Windows.Forms.TextBox tbMin;
        private System.Windows.Forms.TextBox tbFiltered;
        private System.Windows.Forms.TextBox tbRaw;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbAverage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ckbAutosample;
        private System.Windows.Forms.Button bSample;
        private System.Windows.Forms.Button bConfigure;
        private Controls.RealTimeScottPlot realTimeScottPlot1;
        private System.Windows.Forms.Button bGenCode;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
