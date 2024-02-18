using SerialWombat;
namespace SerialWombatWindowsFormsLibrary.Controls
{
    partial class HSCounterControl
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
            this.sbsiFramesBetweenUpdates = new SerialWombatWindowsFormsLibrary.SixteenBitSliderInput();
            this.sbsiPublicDataDivisor = new SerialWombatWindowsFormsLibrary.SixteenBitSliderInput();
            this.enumDropdown1 = new SerialWombatWindowsFormsLibrary.EnumDropdown();
            this.bConfigure = new System.Windows.Forms.Button();
            this.bSample = new System.Windows.Forms.Button();
            this.ckbAutosample = new System.Windows.Forms.CheckBox();
            this.realTimeScottPlot1 = new SerialWombatWindowsFormsLibrary.Controls.RealTimeScottPlot();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bGenCode = new System.Windows.Forms.Button();
            this.lFreq = new System.Windows.Forms.Label();
            this.lCounts = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sbsiFramesBetweenUpdates
            // 
            this.sbsiFramesBetweenUpdates.Location = new System.Drawing.Point(6, 331);
            this.sbsiFramesBetweenUpdates.Maximum = 65535;
            this.sbsiFramesBetweenUpdates.Minimum = 0;
            this.sbsiFramesBetweenUpdates.Name = "sbsiFramesBetweenUpdates";
            this.sbsiFramesBetweenUpdates.Size = new System.Drawing.Size(328, 76);
            this.sbsiFramesBetweenUpdates.TabIndex = 3;
            this.sbsiFramesBetweenUpdates.Text = "Frames Between Updates";
            this.sbsiFramesBetweenUpdates.TextBoxHint = "";
            this.sbsiFramesBetweenUpdates.value = ((ushort)(100));
            // 
            // sbsiPublicDataDivisor
            // 
            this.sbsiPublicDataDivisor.Location = new System.Drawing.Point(6, 413);
            this.sbsiPublicDataDivisor.Maximum = 65535;
            this.sbsiPublicDataDivisor.Minimum = 0;
            this.sbsiPublicDataDivisor.Name = "sbsiPublicDataDivisor";
            this.sbsiPublicDataDivisor.Size = new System.Drawing.Size(328, 76);
            this.sbsiPublicDataDivisor.TabIndex = 4;
            this.sbsiPublicDataDivisor.Text = "Public Data Divisor";
            this.sbsiPublicDataDivisor.TextBoxHint = "";
            this.sbsiPublicDataDivisor.value = ((ushort)(100));
            // 
            // enumDropdown1
            // 
            this.enumDropdown1.DropDownToolTip = "";
            this.enumDropdown1.dropdowntype = "SerialWombat.SerialWombatHSCounterPublicData";
            this.enumDropdown1.Location = new System.Drawing.Point(6, 495);
            this.enumDropdown1.Name = "enumDropdown1";
            this.enumDropdown1.Size = new System.Drawing.Size(274, 35);
            this.enumDropdown1.TabIndex = 5;
            this.enumDropdown1.Value = 0;
            // 
            // bConfigure
            // 
            this.bConfigure.Location = new System.Drawing.Point(6, 22);
            this.bConfigure.Name = "bConfigure";
            this.bConfigure.Size = new System.Drawing.Size(75, 23);
            this.bConfigure.TabIndex = 0;
            this.bConfigure.Text = "Configure";
            this.bConfigure.UseVisualStyleBackColor = true;
            this.bConfigure.Click += new System.EventHandler(this.bConfigure_Click_1);
            // 
            // bSample
            // 
            this.bSample.Location = new System.Drawing.Point(125, 22);
            this.bSample.Name = "bSample";
            this.bSample.Size = new System.Drawing.Size(75, 23);
            this.bSample.TabIndex = 1;
            this.bSample.Text = "Sample";
            this.bSample.UseVisualStyleBackColor = true;
            this.bSample.Click += new System.EventHandler(this.bSample_Click);
            // 
            // ckbAutosample
            // 
            this.ckbAutosample.AutoSize = true;
            this.ckbAutosample.Location = new System.Drawing.Point(241, 28);
            this.ckbAutosample.Name = "ckbAutosample";
            this.ckbAutosample.Size = new System.Drawing.Size(90, 19);
            this.ckbAutosample.TabIndex = 2;
            this.ckbAutosample.Text = "Autosample";
            this.ckbAutosample.UseVisualStyleBackColor = true;
            this.ckbAutosample.CheckedChanged += new System.EventHandler(this.ckbAutosample_CheckedChanged);
            // 
            // realTimeScottPlot1
            // 
            this.realTimeScottPlot1.Location = new System.Drawing.Point(3, 53);
            this.realTimeScottPlot1.Name = "realTimeScottPlot1";
            this.realTimeScottPlot1.Size = new System.Drawing.Size(429, 256);
            this.realTimeScottPlot1.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.bGenCode);
            this.groupBox1.Controls.Add(this.lFreq);
            this.groupBox1.Controls.Add(this.lCounts);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.bConfigure);
            this.groupBox1.Controls.Add(this.realTimeScottPlot1);
            this.groupBox1.Controls.Add(this.sbsiFramesBetweenUpdates);
            this.groupBox1.Controls.Add(this.ckbAutosample);
            this.groupBox1.Controls.Add(this.sbsiPublicDataDivisor);
            this.groupBox1.Controls.Add(this.bSample);
            this.groupBox1.Controls.Add(this.enumDropdown1);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(438, 564);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // bGenCode
            // 
            this.bGenCode.BackColor = System.Drawing.Color.MediumPurple;
            this.bGenCode.Location = new System.Drawing.Point(340, 495);
            this.bGenCode.Name = "bGenCode";
            this.bGenCode.Size = new System.Drawing.Size(45, 47);
            this.bGenCode.TabIndex = 31;
            this.bGenCode.TabStop = false;
            this.bGenCode.Text = "Gen Code";
            this.bGenCode.UseVisualStyleBackColor = false;
            this.bGenCode.Click += new System.EventHandler(this.bGenCode_Click);
            // 
            // lFreq
            // 
            this.lFreq.AutoSize = true;
            this.lFreq.Location = new System.Drawing.Point(286, 313);
            this.lFreq.Name = "lFreq";
            this.lFreq.Size = new System.Drawing.Size(13, 15);
            this.lFreq.TabIndex = 8;
            this.lFreq.Text = "0";
            // 
            // lCounts
            // 
            this.lCounts.AutoSize = true;
            this.lCounts.Location = new System.Drawing.Point(78, 305);
            this.lCounts.Name = "lCounts";
            this.lCounts.Size = new System.Drawing.Size(13, 15);
            this.lCounts.TabIndex = 8;
            this.lCounts.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(232, 312);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Freq";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 305);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Counts:";
            // 
            // HSCounterControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.groupBox1);
            this.Name = "HSCounterControl";
            this.Size = new System.Drawing.Size(441, 567);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SixteenBitSliderInput sbsiFramesBetweenUpdates;
        private SixteenBitSliderInput sbsiPublicDataDivisor;
        private EnumDropdown enumDropdown1;
        private System.Windows.Forms.Button bConfigure;
        private System.Windows.Forms.Button bSample;
        private System.Windows.Forms.CheckBox ckbAutosample;
        private RealTimeScottPlot realTimeScottPlot1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lFreq;
        private System.Windows.Forms.Label lCounts;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bGenCode;
    }
}
