namespace SerialWombatWindowsFormsLibrary.Controls
{
    partial class DebouncedInputControl
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
            linkLabel2 = new System.Windows.Forms.LinkLabel();
            linkLabel1 = new System.Windows.Forms.LinkLabel();
            lTransitions = new System.Windows.Forms.Label();
            lTimePressed = new System.Windows.Forms.Label();
            ckbInvert = new System.Windows.Forms.CheckBox();
            sbsiDebouncePeriod = new SixteenBitSliderInput();
            bGenCode = new System.Windows.Forms.Button();
            ckbPullUp = new System.Windows.Forms.CheckBox();
            realTimeScottPlot1 = new RealTimeScottPlot();
            lFrequency = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ckbAutosample = new System.Windows.Forms.CheckBox();
            bSample = new System.Windows.Forms.Button();
            bConfigure = new System.Windows.Forms.Button();
            toolTip1 = new System.Windows.Forms.ToolTip(components);
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(linkLabel2);
            groupBox1.Controls.Add(linkLabel1);
            groupBox1.Controls.Add(lTransitions);
            groupBox1.Controls.Add(lTimePressed);
            groupBox1.Controls.Add(ckbInvert);
            groupBox1.Controls.Add(sbsiDebouncePeriod);
            groupBox1.Controls.Add(bGenCode);
            groupBox1.Controls.Add(ckbPullUp);
            groupBox1.Controls.Add(realTimeScottPlot1);
            groupBox1.Controls.Add(lFrequency);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(ckbAutosample);
            groupBox1.Controls.Add(bSample);
            groupBox1.Controls.Add(bConfigure);
            groupBox1.Location = new System.Drawing.Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(460, 509);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Location = new System.Drawing.Point(95, 459);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new System.Drawing.Size(80, 15);
            linkLabel2.TabIndex = 38;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Tutorial Video";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new System.Drawing.Point(245, 459);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new System.Drawing.Size(120, 15);
            linkLabel1.TabIndex = 37;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Class Documentation";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // lTransitions
            // 
            lTransitions.AutoSize = true;
            lTransitions.Location = new System.Drawing.Point(353, 418);
            lTransitions.Name = "lTransitions";
            lTransitions.Size = new System.Drawing.Size(12, 15);
            lTransitions.TabIndex = 36;
            lTransitions.Text = "-";
            // 
            // lTimePressed
            // 
            lTimePressed.AutoSize = true;
            lTimePressed.Location = new System.Drawing.Point(167, 417);
            lTimePressed.Name = "lTimePressed";
            lTimePressed.Size = new System.Drawing.Size(12, 15);
            lTimePressed.TabIndex = 36;
            lTimePressed.Text = "-";
            // 
            // ckbInvert
            // 
            ckbInvert.AutoSize = true;
            ckbInvert.Checked = true;
            ckbInvert.CheckState = System.Windows.Forms.CheckState.Checked;
            ckbInvert.Location = new System.Drawing.Point(25, 61);
            ckbInvert.Name = "ckbInvert";
            ckbInvert.Size = new System.Drawing.Size(56, 19);
            ckbInvert.TabIndex = 35;
            ckbInvert.Text = "Invert";
            toolTip1.SetToolTip(ckbInvert, "When checked low voltage (button to ground) causes 65535 public data");
            ckbInvert.UseVisualStyleBackColor = true;
            // 
            // sbsiDebouncePeriod
            // 
            sbsiDebouncePeriod.Location = new System.Drawing.Point(95, 19);
            sbsiDebouncePeriod.Maximum = 65535;
            sbsiDebouncePeriod.Minimum = 0;
            sbsiDebouncePeriod.Name = "sbsiDebouncePeriod";
            sbsiDebouncePeriod.Size = new System.Drawing.Size(290, 76);
            sbsiDebouncePeriod.TabIndex = 34;
            sbsiDebouncePeriod.Text = "Debounce Period (mS)";
            sbsiDebouncePeriod.TextBoxHint = "";
            sbsiDebouncePeriod.value = (ushort)20;
            // 
            // bGenCode
            // 
            bGenCode.BackColor = System.Drawing.Color.MediumPurple;
            bGenCode.Location = new System.Drawing.Point(402, 77);
            bGenCode.Name = "bGenCode";
            bGenCode.Size = new System.Drawing.Size(45, 47);
            bGenCode.TabIndex = 32;
            bGenCode.Text = "Gen Code";
            toolTip1.SetToolTip(bGenCode, "Generate Debounced Input Arduino Initialization code");
            bGenCode.UseVisualStyleBackColor = false;
            bGenCode.Click += bGenCode_Click;
            // 
            // ckbPullUp
            // 
            ckbPullUp.AutoSize = true;
            ckbPullUp.Checked = true;
            ckbPullUp.CheckState = System.Windows.Forms.CheckState.Checked;
            ckbPullUp.Location = new System.Drawing.Point(25, 36);
            ckbPullUp.Name = "ckbPullUp";
            ckbPullUp.Size = new System.Drawing.Size(64, 19);
            ckbPullUp.TabIndex = 13;
            ckbPullUp.Text = "Pull Up";
            toolTip1.SetToolTip(ckbPullUp, "Enable Serial Wombat Chip's internal pull up resistor");
            ckbPullUp.UseVisualStyleBackColor = true;
            // 
            // realTimeScottPlot1
            // 
            realTimeScottPlot1.Location = new System.Drawing.Point(6, 130);
            realTimeScottPlot1.Name = "realTimeScottPlot1";
            realTimeScottPlot1.Size = new System.Drawing.Size(429, 256);
            realTimeScottPlot1.TabIndex = 11;
            // 
            // lFrequency
            // 
            lFrequency.AutoSize = true;
            lFrequency.Location = new System.Drawing.Point(222, 416);
            lFrequency.Name = "lFrequency";
            lFrequency.Size = new System.Drawing.Size(0, 15);
            lFrequency.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(222, 417);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(66, 15);
            label2.TabIndex = 5;
            label2.Text = "Transitions:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(36, 416);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(104, 15);
            label1.TabIndex = 5;
            label1.Text = "Time Pressed (mS)";
            // 
            // ckbAutosample
            // 
            ckbAutosample.AutoSize = true;
            ckbAutosample.Location = new System.Drawing.Point(305, 101);
            ckbAutosample.Name = "ckbAutosample";
            ckbAutosample.Size = new System.Drawing.Size(91, 19);
            ckbAutosample.TabIndex = 2;
            ckbAutosample.Text = "AutoSample";
            toolTip1.SetToolTip(ckbAutosample, "Continuously read the Pin's public data and graph (asynchronous)");
            ckbAutosample.UseVisualStyleBackColor = true;
            ckbAutosample.CheckedChanged += ckbAutosample_CheckedChanged;
            // 
            // bSample
            // 
            bSample.Location = new System.Drawing.Point(224, 101);
            bSample.Name = "bSample";
            bSample.Size = new System.Drawing.Size(75, 23);
            bSample.TabIndex = 1;
            bSample.Text = "Sample";
            toolTip1.SetToolTip(bSample, "Read the pin's public data and graph");
            bSample.UseVisualStyleBackColor = true;
            bSample.Click += bSample_Click;
            // 
            // bConfigure
            // 
            bConfigure.Location = new System.Drawing.Point(25, 101);
            bConfigure.Name = "bConfigure";
            bConfigure.Size = new System.Drawing.Size(75, 23);
            bConfigure.TabIndex = 0;
            bConfigure.Text = "Configure";
            toolTip1.SetToolTip(bConfigure, "Set pin mode, Send Pull up, Invert, and debounce time to Serial Wombat Chip");
            bConfigure.UseVisualStyleBackColor = true;
            bConfigure.Click += bConfigure_Click;
            // 
            // DebouncedInputControl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            Controls.Add(groupBox1);
            Name = "DebouncedInputControl";
            Size = new System.Drawing.Size(466, 515);
            Load += DebouncedInputControl_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bGenCode;
        private System.Windows.Forms.CheckBox ckbPullUp;
        private System.Windows.Forms.Label lFrequency;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ckbAutosample;
        private System.Windows.Forms.Button bSample;
        private System.Windows.Forms.Button bConfigure;
        private System.Windows.Forms.CheckBox ckbInvert;
        private SixteenBitSliderInput sbsiDebouncePeriod;
        private RealTimeScottPlot realTimeScottPlot1;
        private System.Windows.Forms.Label lTimePressed;
        private System.Windows.Forms.Label lTransitions;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}
