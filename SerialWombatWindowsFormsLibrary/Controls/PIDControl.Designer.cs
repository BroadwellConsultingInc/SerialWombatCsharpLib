namespace SerialWombatWindowsFormsLibrary
{
    partial class PIDControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PIDControl));
            this.bUpdateTargetCI = new System.Windows.Forms.Button();
            this.bResetIntegrator = new System.Windows.Forms.Button();
            this.bPIDUpdateTarget = new System.Windows.Forms.Button();
            this.sbsiKp = new SerialWombatWindowsFormsLibrary.SixteenBitSliderInput();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.sbsiPIDTarget = new SerialWombatWindowsFormsLibrary.SixteenBitSliderInput();
            this.bGenPIDCode = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.bConfigurePID = new System.Windows.Forms.Button();
            this.sbsiKd = new SerialWombatWindowsFormsLibrary.SixteenBitSliderInput();
            this.edPIDPeriod = new SerialWombatWindowsFormsLibrary.EnumDropdown();
            this.sbsiKi = new SerialWombatWindowsFormsLibrary.SixteenBitSliderInput();
            this.bShowPIDGraphs = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bUpdateTargetCI
            // 
            this.bUpdateTargetCI.Location = new System.Drawing.Point(15, 237);
            this.bUpdateTargetCI.Name = "bUpdateTargetCI";
            this.bUpdateTargetCI.Size = new System.Drawing.Size(139, 23);
            this.bUpdateTargetCI.TabIndex = 46;
            this.bUpdateTargetCI.Text = "Update Target, Clear I";
            this.bUpdateTargetCI.UseVisualStyleBackColor = true;
            this.bUpdateTargetCI.Click += new System.EventHandler(this.bUpdateTargetCI_Click);
            // 
            // bResetIntegrator
            // 
            this.bResetIntegrator.Location = new System.Drawing.Point(129, 297);
            this.bResetIntegrator.Name = "bResetIntegrator";
            this.bResetIntegrator.Size = new System.Drawing.Size(106, 23);
            this.bResetIntegrator.TabIndex = 45;
            this.bResetIntegrator.Text = "Reset Integrator";
            this.bResetIntegrator.UseVisualStyleBackColor = true;
            this.bResetIntegrator.Click += new System.EventHandler(this.bResetIntegrator_Click);
            // 
            // bPIDUpdateTarget
            // 
            this.bPIDUpdateTarget.Location = new System.Drawing.Point(177, 237);
            this.bPIDUpdateTarget.Name = "bPIDUpdateTarget";
            this.bPIDUpdateTarget.Size = new System.Drawing.Size(92, 23);
            this.bPIDUpdateTarget.TabIndex = 44;
            this.bPIDUpdateTarget.Text = "Update Target";
            this.bPIDUpdateTarget.UseVisualStyleBackColor = true;
            this.bPIDUpdateTarget.Click += new System.EventHandler(this.bPIDUpdateTarget_Click);
            // 
            // sbsiKp
            // 
            this.sbsiKp.Location = new System.Drawing.Point(3, 3);
            this.sbsiKp.Maximum = 65535;
            this.sbsiKp.Minimum = 0;
            this.sbsiKp.Name = "sbsiKp";
            this.sbsiKp.Size = new System.Drawing.Size(311, 56);
            this.sbsiKp.TabIndex = 35;
            this.sbsiKp.Text = "kP";
            this.sbsiKp.TextBoxHint = "The proportional constant applied to the sum of the error, 1/ki * error sum, and " +
    "kd * derivative.  Scaled to 1/256ths";
            this.sbsiKp.value = ((ushort)(0));
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(15, 326);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(344, 78);
            this.textBox2.TabIndex = 42;
            this.textBox2.Text = resources.GetString("textBox2.Text");
            // 
            // sbsiPIDTarget
            // 
            this.sbsiPIDTarget.Location = new System.Drawing.Point(6, 173);
            this.sbsiPIDTarget.Maximum = 65535;
            this.sbsiPIDTarget.Minimum = 0;
            this.sbsiPIDTarget.Name = "sbsiPIDTarget";
            this.sbsiPIDTarget.Size = new System.Drawing.Size(311, 58);
            this.sbsiPIDTarget.TabIndex = 36;
            this.sbsiPIDTarget.Text = "Target Value";
            this.sbsiPIDTarget.TextBoxHint = "The value the output will attempt to control the input to";
            this.sbsiPIDTarget.value = ((ushort)(0));
            // 
            // bGenPIDCode
            // 
            this.bGenPIDCode.BackColor = System.Drawing.Color.MediumPurple;
            this.bGenPIDCode.Location = new System.Drawing.Point(290, 237);
            this.bGenPIDCode.Name = "bGenPIDCode";
            this.bGenPIDCode.Size = new System.Drawing.Size(74, 47);
            this.bGenPIDCode.TabIndex = 43;
            this.bGenPIDCode.Text = "Gen PID Code";
            this.bGenPIDCode.UseVisualStyleBackColor = false;
            this.bGenPIDCode.Click += new System.EventHandler(this.bGenPIDCode_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 15);
            this.label6.TabIndex = 37;
            this.label6.Text = "Sample Period:";
            // 
            // bConfigurePID
            // 
            this.bConfigurePID.Location = new System.Drawing.Point(15, 297);
            this.bConfigurePID.Name = "bConfigurePID";
            this.bConfigurePID.Size = new System.Drawing.Size(108, 23);
            this.bConfigurePID.TabIndex = 38;
            this.bConfigurePID.Text = "Configure PID";
            this.bConfigurePID.UseVisualStyleBackColor = true;
            this.bConfigurePID.Click += new System.EventHandler(this.bConfigurePID_Click);
            // 
            // sbsiKd
            // 
            this.sbsiKd.Location = new System.Drawing.Point(3, 116);
            this.sbsiKd.Maximum = 65535;
            this.sbsiKd.Minimum = 0;
            this.sbsiKd.Name = "sbsiKd";
            this.sbsiKd.Size = new System.Drawing.Size(311, 61);
            this.sbsiKd.TabIndex = 41;
            this.sbsiKd.Text = "kD";
            this.sbsiKd.TextBoxHint = "The derivative contant applied to the derivative.  This value is scaled to 1/1638" +
    "4. ";
            this.sbsiKd.value = ((ushort)(0));
            // 
            // edPIDPeriod
            // 
            this.edPIDPeriod.DropDownToolTip = "an enumerated time for how often the PID controller updates.  This value should b" +
    "e based on how fast the system responds to change in output so that integral and" +
    " derivative terms work correctly.";
            this.edPIDPeriod.dropdowntype = "SerialWombat.ScaledOutputPeriod";
            this.edPIDPeriod.Location = new System.Drawing.Point(129, 266);
            this.edPIDPeriod.Name = "edPIDPeriod";
            this.edPIDPeriod.Size = new System.Drawing.Size(140, 35);
            this.edPIDPeriod.TabIndex = 39;
            // 
            // sbsiKi
            // 
            this.sbsiKi.Location = new System.Drawing.Point(6, 65);
            this.sbsiKi.Maximum = 65535;
            this.sbsiKi.Minimum = 0;
            this.sbsiKi.Name = "sbsiKi";
            this.sbsiKi.Size = new System.Drawing.Size(311, 60);
            this.sbsiKi.TabIndex = 40;
            this.sbsiKi.Text = "kI";
            this.sbsiKi.TextBoxHint = "The integral constant applied to the integral.  Scaled to 1/16384ths, as typicall" +
    "y you want this value to be less than 1.0";
            this.sbsiKi.value = ((ushort)(0));
            // 
            // bShowPIDGraphs
            // 
            this.bShowPIDGraphs.Location = new System.Drawing.Point(241, 297);
            this.bShowPIDGraphs.Name = "bShowPIDGraphs";
            this.bShowPIDGraphs.Size = new System.Drawing.Size(91, 23);
            this.bShowPIDGraphs.TabIndex = 47;
            this.bShowPIDGraphs.Text = "Show Graphs";
            this.bShowPIDGraphs.UseVisualStyleBackColor = true;
            this.bShowPIDGraphs.Click += new System.EventHandler(this.bShowPIDGraphs_Click);
            // 
            // PIDControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.bShowPIDGraphs);
            this.Controls.Add(this.bUpdateTargetCI);
            this.Controls.Add(this.bResetIntegrator);
            this.Controls.Add(this.bPIDUpdateTarget);
            this.Controls.Add(this.sbsiKp);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.sbsiPIDTarget);
            this.Controls.Add(this.bGenPIDCode);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.bConfigurePID);
            this.Controls.Add(this.sbsiKd);
            this.Controls.Add(this.edPIDPeriod);
            this.Controls.Add(this.sbsiKi);
            this.Name = "PIDControl";
            this.Size = new System.Drawing.Size(367, 407);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bUpdateTargetCI;
        private System.Windows.Forms.Button bResetIntegrator;
        private System.Windows.Forms.Button bPIDUpdateTarget;
        private SixteenBitSliderInput sbsiKp;
        private System.Windows.Forms.TextBox textBox2;
        private SixteenBitSliderInput sbsiPIDTarget;
        private System.Windows.Forms.Button bGenPIDCode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bConfigurePID;
        private SixteenBitSliderInput sbsiKd;
        private EnumDropdown edPIDPeriod;
        private SixteenBitSliderInput sbsiKi;
        private System.Windows.Forms.Button bShowPIDGraphs;
    }
}
