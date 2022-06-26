namespace SerialWombatWindowsFormsLibrary
{
    partial class ProcessedInputControl
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProcessedInputControl));
            this.ckbEnabled = new System.Windows.Forms.CheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.bRemoveBelowAbove = new System.Windows.Forms.Button();
            this.sbsiExcludeAbove = new SerialWombatWindowsFormsLibrary.SixteenBitSliderInput();
            this.sbsiExcludeBelow = new SerialWombatWindowsFormsLibrary.SixteenBitSliderInput();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpInversion = new System.Windows.Forms.TabPage();
            this.ckbInverted = new System.Windows.Forms.CheckBox();
            this.bConfigureInverted = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.bConfigure = new System.Windows.Forms.Button();
            this.sbsiInputScaleMax = new SerialWombatWindowsFormsLibrary.SixteenBitSliderInput();
            this.sbsiInputScaleMin = new SerialWombatWindowsFormsLibrary.SixteenBitSliderInput();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbM = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbB = new System.Windows.Forms.TextBox();
            this.bConfigureMXB = new System.Windows.Forms.Button();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tpInversion.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // ckbEnabled
            // 
            this.ckbEnabled.AutoSize = true;
            this.ckbEnabled.Location = new System.Drawing.Point(173, 550);
            this.ckbEnabled.Name = "ckbEnabled";
            this.ckbEnabled.Size = new System.Drawing.Size(68, 19);
            this.ckbEnabled.TabIndex = 1;
            this.ckbEnabled.Text = "Enabled";
            this.ckbEnabled.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.bRemoveBelowAbove);
            this.tabPage2.Controls.Add(this.sbsiExcludeAbove);
            this.tabPage2.Controls.Add(this.sbsiExcludeBelow);
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(476, 508);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "OutlierRemoval";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // bRemoveBelowAbove
            // 
            this.bRemoveBelowAbove.Location = new System.Drawing.Point(118, 317);
            this.bRemoveBelowAbove.Name = "bRemoveBelowAbove";
            this.bRemoveBelowAbove.Size = new System.Drawing.Size(210, 23);
            this.bRemoveBelowAbove.TabIndex = 19;
            this.bRemoveBelowAbove.Text = "Configure Remove Below Above";
            this.bRemoveBelowAbove.UseVisualStyleBackColor = true;
            this.bRemoveBelowAbove.Click += new System.EventHandler(this.bExcludeBelowAbove_Click);
            // 
            // sbsiExcludeAbove
            // 
            this.sbsiExcludeAbove.Location = new System.Drawing.Point(15, 220);
            this.sbsiExcludeAbove.Name = "sbsiExcludeAbove";
            this.sbsiExcludeAbove.Size = new System.Drawing.Size(328, 76);
            this.sbsiExcludeAbove.TabIndex = 18;
            this.sbsiExcludeAbove.Text = "excludeAbove";
            this.sbsiExcludeAbove.TextBoxHint = "input values above this value will not be processsed";
            // 
            // sbsiExcludeBelow
            // 
            this.sbsiExcludeBelow.Location = new System.Drawing.Point(15, 138);
            this.sbsiExcludeBelow.Name = "sbsiExcludeBelow";
            this.sbsiExcludeBelow.Size = new System.Drawing.Size(328, 76);
            this.sbsiExcludeBelow.TabIndex = 17;
            this.sbsiExcludeBelow.Text = "excludeBelow";
            this.sbsiExcludeBelow.TextBoxHint = "input values below this value will not be processed";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(6, 16);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(464, 103);
            this.textBox2.TabIndex = 16;
            this.textBox2.Text = resources.GetString("textBox2.Text");
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(476, 508);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Overview";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 30);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(464, 463);
            this.textBox1.TabIndex = 15;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tpInversion);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(484, 536);
            this.tabControl1.TabIndex = 0;
            // 
            // tpInversion
            // 
            this.tpInversion.Controls.Add(this.ckbInverted);
            this.tpInversion.Controls.Add(this.bConfigureInverted);
            this.tpInversion.Controls.Add(this.textBox3);
            this.tpInversion.Location = new System.Drawing.Point(4, 24);
            this.tpInversion.Name = "tpInversion";
            this.tpInversion.Padding = new System.Windows.Forms.Padding(3);
            this.tpInversion.Size = new System.Drawing.Size(476, 508);
            this.tpInversion.TabIndex = 2;
            this.tpInversion.Text = "Inversion";
            this.tpInversion.UseVisualStyleBackColor = true;
            // 
            // ckbInverted
            // 
            this.ckbInverted.AutoSize = true;
            this.ckbInverted.Location = new System.Drawing.Point(179, 133);
            this.ckbInverted.Name = "ckbInverted";
            this.ckbInverted.Size = new System.Drawing.Size(69, 19);
            this.ckbInverted.TabIndex = 19;
            this.ckbInverted.Text = "Inverted";
            this.toolTip1.SetToolTip(this.ckbInverted, "False - input value isn\'t changed.  True- input value is subtracted from 65535");
            this.ckbInverted.UseVisualStyleBackColor = true;
            // 
            // bConfigureInverted
            // 
            this.bConfigureInverted.Location = new System.Drawing.Point(145, 197);
            this.bConfigureInverted.Name = "bConfigureInverted";
            this.bConfigureInverted.Size = new System.Drawing.Size(143, 23);
            this.bConfigureInverted.TabIndex = 18;
            this.bConfigureInverted.Text = "Configure Inversion";
            this.bConfigureInverted.UseVisualStyleBackColor = true;
            this.bConfigureInverted.Click += new System.EventHandler(this.bConfigureInverted_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(3, 6);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox3.Size = new System.Drawing.Size(464, 103);
            this.textBox3.TabIndex = 17;
            this.textBox3.Text = "if enabled subtract the input value from 65535 before doing any other processing." +
    "";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.bConfigureMXB);
            this.tabPage4.Controls.Add(this.tbB);
            this.tabPage4.Controls.Add(this.label3);
            this.tabPage4.Controls.Add(this.tbM);
            this.tabPage4.Controls.Add(this.label2);
            this.tabPage4.Controls.Add(this.label1);
            this.tabPage4.Controls.Add(this.textBox5);
            this.tabPage4.Controls.Add(this.bConfigure);
            this.tabPage4.Controls.Add(this.sbsiInputScaleMax);
            this.tabPage4.Controls.Add(this.sbsiInputScaleMin);
            this.tabPage4.Controls.Add(this.textBox4);
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(476, 508);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Transform";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // bConfigure
            // 
            this.bConfigure.Location = new System.Drawing.Point(340, 138);
            this.bConfigure.Name = "bConfigure";
            this.bConfigure.Size = new System.Drawing.Size(75, 65);
            this.bConfigure.TabIndex = 21;
            this.bConfigure.Text = "Configure Input Scaling";
            this.bConfigure.UseVisualStyleBackColor = true;
            this.bConfigure.Click += new System.EventHandler(this.bConfigure_Click);
            // 
            // sbsiInputScaleMax
            // 
            this.sbsiInputScaleMax.Location = new System.Drawing.Point(6, 152);
            this.sbsiInputScaleMax.Name = "sbsiInputScaleMax";
            this.sbsiInputScaleMax.Size = new System.Drawing.Size(328, 76);
            this.sbsiInputScaleMax.TabIndex = 20;
            this.sbsiInputScaleMax.Text = "Max";
            this.sbsiInputScaleMax.TextBoxHint = "";
            // 
            // sbsiInputScaleMin
            // 
            this.sbsiInputScaleMin.Location = new System.Drawing.Point(6, 70);
            this.sbsiInputScaleMin.Name = "sbsiInputScaleMin";
            this.sbsiInputScaleMin.Size = new System.Drawing.Size(328, 76);
            this.sbsiInputScaleMin.TabIndex = 19;
            this.sbsiInputScaleMin.Text = "min";
            this.sbsiInputScaleMin.TextBoxHint = "";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(3, 6);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox4.Size = new System.Drawing.Size(464, 58);
            this.textBox4.TabIndex = 18;
            this.textBox4.Text = resources.GetString("textBox4.Text");
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 24);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(476, 508);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "tabPage5";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(9, 262);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox5.Size = new System.Drawing.Size(464, 55);
            this.textBox5.TabIndex = 22;
            this.textBox5.Text = resources.GetString("textBox5.Text");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(196, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 15);
            this.label1.TabIndex = 23;
            this.label1.Text = "OR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 339);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 15);
            this.label2.TabIndex = 24;
            this.label2.Text = "Slope (Float between 6551.62 and - 6551.62):";
            // 
            // tbM
            // 
            this.tbM.Location = new System.Drawing.Point(284, 336);
            this.tbM.Name = "tbM";
            this.tbM.Size = new System.Drawing.Size(100, 23);
            this.tbM.TabIndex = 25;
            this.toolTip1.SetToolTip(this.tbM, "A float that will be made a value between -16777215 and +1677215 representing the" +
        " number of 256th by which to multiply the input ");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(114, 368);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 15);
            this.label3.TabIndex = 24;
            this.label3.Text = "Intercept (-65535 to 65535):";
            // 
            // tbB
            // 
            this.tbB.Location = new System.Drawing.Point(284, 365);
            this.tbB.Name = "tbB";
            this.tbB.Size = new System.Drawing.Size(100, 23);
            this.tbB.TabIndex = 25;
            this.toolTip1.SetToolTip(this.tbB, "A value between -65535 and 65535 to add to the result of the multiplication");
            // 
            // bConfigureMXB
            // 
            this.bConfigureMXB.Location = new System.Drawing.Point(166, 412);
            this.bConfigureMXB.Name = "bConfigureMXB";
            this.bConfigureMXB.Size = new System.Drawing.Size(138, 23);
            this.bConfigureMXB.TabIndex = 26;
            this.bConfigureMXB.Text = "Configure MXB";
            this.bConfigureMXB.UseVisualStyleBackColor = true;
            this.bConfigureMXB.Click += new System.EventHandler(this.bConfigureMXB_Click);
            // 
            // ProcessedInputControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ckbEnabled);
            this.Controls.Add(this.tabControl1);
            this.Name = "ProcessedInputControl";
            this.Size = new System.Drawing.Size(490, 581);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tpInversion.ResumeLayout(false);
            this.tpInversion.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox ckbEnabled;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private SixteenBitSliderInput sbsiExcludeAbove;
        private SixteenBitSliderInput sbsiExcludeBelow;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TabPage tpInversion;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button bRemoveBelowAbove;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.CheckBox ckbInverted;
        private System.Windows.Forms.Button bConfigureInverted;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button bConfigure;
        private SixteenBitSliderInput sbsiInputScaleMax;
        private SixteenBitSliderInput sbsiInputScaleMin;
        private System.Windows.Forms.TextBox tbM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox tbB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bConfigureMXB;
    }
}
