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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PIDControl));
            bUpdateTargetCI = new System.Windows.Forms.Button();
            bResetIntegrator = new System.Windows.Forms.Button();
            bPIDUpdateTarget = new System.Windows.Forms.Button();
            sbsiKp = new SixteenBitSliderInput();
            textBox2 = new System.Windows.Forms.TextBox();
            sbsiPIDTarget = new SixteenBitSliderInput();
            bGenPIDCode = new System.Windows.Forms.Button();
            label6 = new System.Windows.Forms.Label();
            bConfigurePID = new System.Windows.Forms.Button();
            sbsiKd = new SixteenBitSliderInput();
            edPIDPeriod = new EnumDropdown();
            sbsiKi = new SixteenBitSliderInput();
            bShowPIDGraphs = new System.Windows.Forms.Button();
            this.swpdcPIDTargetSource = new SerialWombatWindowsFormsLibrary.SerialWombatPublicDataControl();
            label1 = new System.Windows.Forms.Label();
            ckbBiDirectional = new System.Windows.Forms.CheckBox();
            toolTip1 = new System.Windows.Forms.ToolTip(components);
            SuspendLayout();
            // 
            // bUpdateTargetCI
            // 
            bUpdateTargetCI.Location = new System.Drawing.Point(15, 237);
            bUpdateTargetCI.Name = "bUpdateTargetCI";
            bUpdateTargetCI.Size = new System.Drawing.Size(139, 23);
            bUpdateTargetCI.TabIndex = 4;
            bUpdateTargetCI.Text = "Update Target, Clear I";
            toolTip1.SetToolTip(bUpdateTargetCI, "Write the target value to the Serial Wombat Chip and reset integrator to 0");
            bUpdateTargetCI.UseVisualStyleBackColor = true;
            bUpdateTargetCI.Click += bUpdateTargetCI_Click;
            // 
            // bResetIntegrator
            // 
            bResetIntegrator.Location = new System.Drawing.Point(129, 297);
            bResetIntegrator.Name = "bResetIntegrator";
            bResetIntegrator.Size = new System.Drawing.Size(106, 23);
            bResetIntegrator.TabIndex = 8;
            bResetIntegrator.Text = "Reset Integrator";
            toolTip1.SetToolTip(bResetIntegrator, "Reset Integrator to 0");
            bResetIntegrator.UseVisualStyleBackColor = true;
            bResetIntegrator.Click += bResetIntegrator_Click;
            // 
            // bPIDUpdateTarget
            // 
            bPIDUpdateTarget.Location = new System.Drawing.Point(177, 237);
            bPIDUpdateTarget.Name = "bPIDUpdateTarget";
            bPIDUpdateTarget.Size = new System.Drawing.Size(92, 23);
            bPIDUpdateTarget.TabIndex = 5;
            bPIDUpdateTarget.Text = "Update Target";
            toolTip1.SetToolTip(bPIDUpdateTarget, "Write the target value to the Serial Wombat Chip without changing the integrator");
            bPIDUpdateTarget.UseVisualStyleBackColor = true;
            bPIDUpdateTarget.Click += bPIDUpdateTarget_Click;
            // 
            // sbsiKp
            // 
            sbsiKp.Location = new System.Drawing.Point(3, 3);
            sbsiKp.Maximum = 65535;
            sbsiKp.Minimum = 0;
            sbsiKp.Name = "sbsiKp";
            sbsiKp.Size = new System.Drawing.Size(311, 56);
            sbsiKp.TabIndex = 0;
            sbsiKp.Text = "kP";
            sbsiKp.TextBoxHint = "The proportional constant applied to the sum of the error, 1/ki * error sum, and kd * derivative.  Scaled to 1/256ths";
            sbsiKp.value = (ushort)256;
            // 
            // textBox2
            // 
            textBox2.Location = new System.Drawing.Point(20, 357);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            textBox2.Size = new System.Drawing.Size(344, 42);
            textBox2.TabIndex = 42;
            textBox2.TabStop = false;
            textBox2.Text = resources.GetString("textBox2.Text");
            // 
            // sbsiPIDTarget
            // 
            sbsiPIDTarget.Location = new System.Drawing.Point(6, 173);
            sbsiPIDTarget.Maximum = 65535;
            sbsiPIDTarget.Minimum = 0;
            sbsiPIDTarget.Name = "sbsiPIDTarget";
            sbsiPIDTarget.Size = new System.Drawing.Size(311, 58);
            sbsiPIDTarget.TabIndex = 3;
            sbsiPIDTarget.Text = "Target Value";
            sbsiPIDTarget.TextBoxHint = "The value the output will attempt to control the input to";
            sbsiPIDTarget.value = (ushort)0;
            // 
            // bGenPIDCode
            // 
            bGenPIDCode.BackColor = System.Drawing.Color.MediumPurple;
            bGenPIDCode.Location = new System.Drawing.Point(275, 237);
            bGenPIDCode.Name = "bGenPIDCode";
            bGenPIDCode.Size = new System.Drawing.Size(89, 23);
            bGenPIDCode.TabIndex = 11;
            bGenPIDCode.Text = "Gen PID Code";
            toolTip1.SetToolTip(bGenPIDCode, "Generate Arduino initialization code for PID.");
            bGenPIDCode.UseVisualStyleBackColor = false;
            bGenPIDCode.Click += bGenPIDCode_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(6, 269);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(86, 15);
            label6.TabIndex = 37;
            label6.Text = "Sample Period:";
            // 
            // bConfigurePID
            // 
            bConfigurePID.Location = new System.Drawing.Point(15, 297);
            bConfigurePID.Name = "bConfigurePID";
            bConfigurePID.Size = new System.Drawing.Size(108, 23);
            bConfigurePID.TabIndex = 7;
            bConfigurePID.Text = "Configure PID";
            toolTip1.SetToolTip(bConfigurePID, "Send P,I,D,Sample Period to Serial wombat chip and enable algorithm.  Resets Integrator");
            bConfigurePID.UseVisualStyleBackColor = true;
            bConfigurePID.Click += bConfigurePID_Click;
            // 
            // sbsiKd
            // 
            sbsiKd.Location = new System.Drawing.Point(3, 116);
            sbsiKd.Maximum = 65535;
            sbsiKd.Minimum = 0;
            sbsiKd.Name = "sbsiKd";
            sbsiKd.Size = new System.Drawing.Size(311, 61);
            sbsiKd.TabIndex = 2;
            sbsiKd.Text = "kD";
            sbsiKd.TextBoxHint = "The derivative contant applied to the derivative.  This value is scaled to 1/16384. ";
            sbsiKd.value = (ushort)0;
            // 
            // edPIDPeriod
            // 
            edPIDPeriod.DropDownToolTip = "an enumerated time for how often the PID controller updates.  This value should be based on how fast the system responds to change in output so that integral and derivative terms work correctly.";
            edPIDPeriod.dropdowntype = "SerialWombatClassLibrary.SerialWombat.ScaledOutputPeriod";
            edPIDPeriod.Location = new System.Drawing.Point(95, 266);
            edPIDPeriod.Name = "edPIDPeriod";
            edPIDPeriod.Size = new System.Drawing.Size(140, 35);
            edPIDPeriod.TabIndex = 6;
            toolTip1.SetToolTip(edPIDPeriod, "Time between PID control sample and calculation");
            edPIDPeriod.Value = 0;
            // 
            // sbsiKi
            // 
            sbsiKi.Location = new System.Drawing.Point(6, 65);
            sbsiKi.Maximum = 65535;
            sbsiKi.Minimum = 0;
            sbsiKi.Name = "sbsiKi";
            sbsiKi.Size = new System.Drawing.Size(311, 60);
            sbsiKi.TabIndex = 1;
            sbsiKi.Text = "kI";
            sbsiKi.TextBoxHint = "The integral constant applied to the integral.  Scaled to 1/16384ths, as typically you want this value to be less than 1.0";
            sbsiKi.value = (ushort)0;
            // 
            // bShowPIDGraphs
            // 
            bShowPIDGraphs.Location = new System.Drawing.Point(241, 297);
            bShowPIDGraphs.Name = "bShowPIDGraphs";
            bShowPIDGraphs.Size = new System.Drawing.Size(91, 23);
            bShowPIDGraphs.TabIndex = 9;
            bShowPIDGraphs.Text = "Show Graphs";
            toolTip1.SetToolTip(bShowPIDGraphs, "Open a new window designed to facilitate real-time PID tuning");
            bShowPIDGraphs.UseVisualStyleBackColor = true;
            bShowPIDGraphs.Click += bShowPIDGraphs_Click;
            // 
            // swpdcPIDTargetSource
            // 
            this.swpdcPIDTargetSource.DataSourceValue = ((byte)(0));
            this.swpdcPIDTargetSource.DropDownToolTip = "";
            this.swpdcPIDTargetSource.Location = new System.Drawing.Point(152, 326);
            this.swpdcPIDTargetSource.Name = "swpdcPIDTargetSource";
            this.swpdcPIDTargetSource.Size = new System.Drawing.Size(212, 35);
            this.swpdcPIDTargetSource.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(21, 326);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(102, 15);
            label1.TabIndex = 49;
            label1.Text = "PID Target Source:";
            // 
            // ckbBiDirectional
            // 
            ckbBiDirectional.AutoSize = true;
            ckbBiDirectional.Location = new System.Drawing.Point(260, 272);
            ckbBiDirectional.Name = "ckbBiDirectional";
            ckbBiDirectional.Size = new System.Drawing.Size(93, 19);
            ckbBiDirectional.TabIndex = 50;
            ckbBiDirectional.Text = "BiDirectional";
            toolTip1.SetToolTip(ckbBiDirectional, "Check if neutral output is 32768, not 0 (Like H Bridge)");
            ckbBiDirectional.UseVisualStyleBackColor = true;
            // 
            // PIDControl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            Controls.Add(ckbBiDirectional);
            Controls.Add(label1);
            Controls.Add(bShowPIDGraphs);
            Controls.Add(bUpdateTargetCI);
            Controls.Add(bResetIntegrator);
            Controls.Add(bPIDUpdateTarget);
            Controls.Add(sbsiKp);
            Controls.Add(textBox2);
            Controls.Add(sbsiPIDTarget);
            Controls.Add(bGenPIDCode);
            Controls.Add(label6);
            Controls.Add(bConfigurePID);
            Controls.Add(sbsiKd);
            Controls.Add(edPIDPeriod);
            Controls.Add(sbsiKi);
            Name = "PIDControl";
            Size = new System.Drawing.Size(367, 402);
            ResumeLayout(false);
            PerformLayout();
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
        private SerialWombatPublicDataControl swpdcPIDTargetSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ckbBiDirectional;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
