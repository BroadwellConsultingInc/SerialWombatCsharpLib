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
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.button4 = new System.Windows.Forms.Button();
            this.realTimeScottPlot1 = new SerialWombatWindowsFormsLibrary.Controls.RealTimeScottPlot();
            this.ckbVolts = new System.Windows.Forms.CheckBox();
            this.ckbAllValues = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tbFilterConstant = new System.Windows.Forms.TextBox();
            this.tbMax = new System.Windows.Forms.TextBox();
            this.tbAveraged = new System.Windows.Forms.TextBox();
            this.tbMin = new System.Windows.Forms.TextBox();
            this.tbFiltered = new System.Windows.Forms.TextBox();
            this.tbRaw = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbAverage = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ckbAutosample = new System.Windows.Forms.CheckBox();
            this.bSample = new System.Windows.Forms.Button();
            this.bConfigure = new System.Windows.Forms.Button();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(7, 479);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(494, 34);
            this.label6.TabIndex = 3;
            this.label6.Text = "Real time chart created with Scott Hardin\'s excellent  ScottPlot Library (https:/" +
    "/swharden.com/scottplot/)";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.linkLabel2);
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.realTimeScottPlot1);
            this.groupBox1.Controls.Add(this.ckbVolts);
            this.groupBox1.Controls.Add(this.ckbAllValues);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.tbFilterConstant);
            this.groupBox1.Controls.Add(this.tbMax);
            this.groupBox1.Controls.Add(this.tbAveraged);
            this.groupBox1.Controls.Add(this.tbMin);
            this.groupBox1.Controls.Add(this.tbFiltered);
            this.groupBox1.Controls.Add(this.tbRaw);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tbAverage);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ckbAutosample);
            this.groupBox1.Controls.Add(this.bSample);
            this.groupBox1.Controls.Add(this.bConfigure);
            this.groupBox1.Location = new System.Drawing.Point(0, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(530, 473);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(401, 87);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(120, 15);
            this.linkLabel1.TabIndex = 31;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Class Documentation";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.MediumPurple;
            this.button4.Location = new System.Drawing.Point(216, 11);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(45, 47);
            this.button4.TabIndex = 30;
            this.button4.TabStop = false;
            this.button4.Text = "Gen Code";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // realTimeScottPlot1
            // 
            this.realTimeScottPlot1.Location = new System.Drawing.Point(29, 116);
            this.realTimeScottPlot1.Name = "realTimeScottPlot1";
            this.realTimeScottPlot1.Size = new System.Drawing.Size(429, 256);
            this.realTimeScottPlot1.TabIndex = 5;
            // 
            // ckbVolts
            // 
            this.ckbVolts.AutoSize = true;
            this.ckbVolts.Location = new System.Drawing.Point(216, 454);
            this.ckbVolts.Name = "ckbVolts";
            this.ckbVolts.Size = new System.Drawing.Size(51, 19);
            this.ckbVolts.TabIndex = 8;
            this.ckbVolts.Text = "Volts";
            this.ckbVolts.UseVisualStyleBackColor = true;
            this.ckbVolts.CheckedChanged += new System.EventHandler(this.ckbVolts_CheckedChanged);
            // 
            // ckbAllValues
            // 
            this.ckbAllValues.AutoSize = true;
            this.ckbAllValues.Checked = true;
            this.ckbAllValues.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbAllValues.Location = new System.Drawing.Point(216, 433);
            this.ckbAllValues.Name = "ckbAllValues";
            this.ckbAllValues.Size = new System.Drawing.Size(69, 19);
            this.ckbAllValues.TabIndex = 7;
            this.ckbAllValues.Text = "Read All";
            this.ckbAllValues.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Raw = 0",
            "Filtered = 1",
            "Average = 2,",
            "Minimum = 3",
            "Maximum = 4"});
            this.comboBox1.Location = new System.Drawing.Point(274, 60);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.Tag = "";
            // 
            // tbFilterConstant
            // 
            this.tbFilterConstant.Location = new System.Drawing.Point(149, 87);
            this.tbFilterConstant.Name = "tbFilterConstant";
            this.tbFilterConstant.Size = new System.Drawing.Size(100, 23);
            this.tbFilterConstant.TabIndex = 4;
            this.tbFilterConstant.Text = "65408";
            // 
            // tbMax
            // 
            this.tbMax.Location = new System.Drawing.Point(403, 434);
            this.tbMax.Name = "tbMax";
            this.tbMax.Size = new System.Drawing.Size(100, 23);
            this.tbMax.TabIndex = 5;
            this.tbMax.TabStop = false;
            this.tbMax.Text = "0";
            // 
            // tbAveraged
            // 
            this.tbAveraged.Location = new System.Drawing.Point(69, 434);
            this.tbAveraged.Name = "tbAveraged";
            this.tbAveraged.Size = new System.Drawing.Size(100, 23);
            this.tbAveraged.TabIndex = 5;
            this.tbAveraged.TabStop = false;
            this.tbAveraged.Text = "0";
            // 
            // tbMin
            // 
            this.tbMin.Location = new System.Drawing.Point(401, 399);
            this.tbMin.Name = "tbMin";
            this.tbMin.Size = new System.Drawing.Size(100, 23);
            this.tbMin.TabIndex = 5;
            this.tbMin.TabStop = false;
            this.tbMin.Text = "0";
            // 
            // tbFiltered
            // 
            this.tbFiltered.Location = new System.Drawing.Point(258, 399);
            this.tbFiltered.Name = "tbFiltered";
            this.tbFiltered.Size = new System.Drawing.Size(100, 23);
            this.tbFiltered.TabIndex = 5;
            this.tbFiltered.TabStop = false;
            this.tbFiltered.Text = "0";
            // 
            // tbRaw
            // 
            this.tbRaw.Location = new System.Drawing.Point(69, 399);
            this.tbRaw.Name = "tbRaw";
            this.tbRaw.Size = new System.Drawing.Size(100, 23);
            this.tbRaw.TabIndex = 5;
            this.tbRaw.TabStop = false;
            this.tbRaw.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(364, 437);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 15);
            this.label8.TabIndex = 4;
            this.label8.Text = "Max:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 437);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Average:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(364, 402);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 15);
            this.label7.TabIndex = 4;
            this.label7.Text = "Min:";
            // 
            // tbAverage
            // 
            this.tbAverage.Location = new System.Drawing.Point(121, 60);
            this.tbAverage.Name = "tbAverage";
            this.tbAverage.Size = new System.Drawing.Size(100, 23);
            this.tbAverage.TabIndex = 2;
            this.tbAverage.Text = "64";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(189, 402);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Filtered:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 402);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Raw:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Filter Constant (0-65535):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Samples To Average:";
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
            this.bSample.Location = new System.Drawing.Point(103, 22);
            this.bSample.Name = "bSample";
            this.bSample.Size = new System.Drawing.Size(75, 23);
            this.bSample.TabIndex = 1;
            this.bSample.Text = "Sample";
            this.bSample.UseVisualStyleBackColor = true;
            this.bSample.Click += new System.EventHandler(this.bSample_Click);
            // 
            // bConfigure
            // 
            this.bConfigure.Location = new System.Drawing.Point(7, 22);
            this.bConfigure.Name = "bConfigure";
            this.bConfigure.Size = new System.Drawing.Size(75, 23);
            this.bConfigure.TabIndex = 0;
            this.bConfigure.Text = "Configure";
            this.bConfigure.UseVisualStyleBackColor = true;
            this.bConfigure.Click += new System.EventHandler(this.bConfigure_Click);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(403, 43);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(80, 15);
            this.linkLabel2.TabIndex = 32;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Tutorial Video";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // AnalogInputControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Name = "AnalogInputControl";
            this.Size = new System.Drawing.Size(533, 513);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
    }
}
