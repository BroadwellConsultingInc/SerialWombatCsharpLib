namespace SerialWombatWindowsFormsLibrary
{
    partial class RampOutputScaleControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RampOutputScaleControl));
            bRampUpdateTarget = new System.Windows.Forms.Button();
            sbsiSlowIncrement = new SixteenBitSliderInput();
            textBox2 = new System.Windows.Forms.TextBox();
            sbsiRampTarget = new SixteenBitSliderInput();
            bGenRampCode = new System.Windows.Forms.Button();
            label6 = new System.Windows.Forms.Label();
            bConfigurePID = new System.Windows.Forms.Button();
            sbsiFastIncrement = new SixteenBitSliderInput();
            edRampPeriod = new EnumDropdown();
            sbsiIncrementThreshold = new SixteenBitSliderInput();
            label1 = new System.Windows.Forms.Label();
            edRampMode = new EnumDropdown();
            SuspendLayout();
            // 
            // bRampUpdateTarget
            // 
            bRampUpdateTarget.Location = new System.Drawing.Point(19, 249);
            bRampUpdateTarget.Name = "bRampUpdateTarget";
            bRampUpdateTarget.Size = new System.Drawing.Size(92, 23);
            bRampUpdateTarget.TabIndex = 47;
            bRampUpdateTarget.Text = "Update Target";
            bRampUpdateTarget.UseVisualStyleBackColor = true;
            bRampUpdateTarget.Click += bRampUpdateTarget_Click;
            // 
            // sbsiSlowIncrement
            // 
            sbsiSlowIncrement.Location = new System.Drawing.Point(14, 9);
            sbsiSlowIncrement.Maximum = 65535;
            sbsiSlowIncrement.Minimum = 0;
            sbsiSlowIncrement.Name = "sbsiSlowIncrement";
            sbsiSlowIncrement.Size = new System.Drawing.Size(311, 56);
            sbsiSlowIncrement.TabIndex = 43;
            sbsiSlowIncrement.Text = "Slow Increment";
            sbsiSlowIncrement.TextBoxHint = "How much to increment each sample period if input is within Increment threshold of target";
            sbsiSlowIncrement.value = (ushort)100;
            // 
            // textBox2
            // 
            textBox2.Location = new System.Drawing.Point(14, 334);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            textBox2.Size = new System.Drawing.Size(332, 42);
            textBox2.TabIndex = 52;
            textBox2.TabStop = false;
            textBox2.Text = resources.GetString("textBox2.Text");
            // 
            // sbsiRampTarget
            // 
            sbsiRampTarget.Location = new System.Drawing.Point(14, 179);
            sbsiRampTarget.Maximum = 65535;
            sbsiRampTarget.Minimum = 0;
            sbsiRampTarget.Name = "sbsiRampTarget";
            sbsiRampTarget.Size = new System.Drawing.Size(311, 58);
            sbsiRampTarget.TabIndex = 46;
            sbsiRampTarget.Text = "Target Value";
            sbsiRampTarget.TextBoxHint = "The value the output will attempt to control the input to";
            sbsiRampTarget.value = (ushort)0;
            // 
            // bGenRampCode
            // 
            bGenRampCode.BackColor = System.Drawing.Color.MediumPurple;
            bGenRampCode.Location = new System.Drawing.Point(117, 249);
            bGenRampCode.Name = "bGenRampCode";
            bGenRampCode.Size = new System.Drawing.Size(103, 23);
            bGenRampCode.TabIndex = 50;
            bGenRampCode.Text = "Gen Ramp Code";
            bGenRampCode.UseVisualStyleBackColor = false;
            bGenRampCode.Click += bGenRampCode_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(236, 257);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(86, 15);
            label6.TabIndex = 51;
            label6.Text = "Sample Period:";
            // 
            // bConfigurePID
            // 
            bConfigurePID.Location = new System.Drawing.Point(11, 305);
            bConfigurePID.Name = "bConfigurePID";
            bConfigurePID.Size = new System.Drawing.Size(108, 23);
            bConfigurePID.TabIndex = 49;
            bConfigurePID.Text = "Configure Ramp";
            bConfigurePID.UseVisualStyleBackColor = true;
            bConfigurePID.Click += bConfigurePID_Click;
            // 
            // sbsiFastIncrement
            // 
            sbsiFastIncrement.Location = new System.Drawing.Point(11, 122);
            sbsiFastIncrement.Maximum = 65535;
            sbsiFastIncrement.Minimum = 0;
            sbsiFastIncrement.Name = "sbsiFastIncrement";
            sbsiFastIncrement.Size = new System.Drawing.Size(311, 61);
            sbsiFastIncrement.TabIndex = 45;
            sbsiFastIncrement.Text = "Fast Increment";
            sbsiFastIncrement.TextBoxHint = "How much to increment each sample period if input is within Increment threshold of target";
            sbsiFastIncrement.value = (ushort)1000;
            // 
            // edRampPeriod
            // 
            edRampPeriod.DropDownToolTip = "an enumerated time for how often the PID controller updates.  This value should be based on how fast the system responds to change in output so that integral and derivative terms work correctly.";
            edRampPeriod.dropdowntype = "SerialWombatClassLibrary.SerialWombat.ScaledOutputPeriod";
            edRampPeriod.Location = new System.Drawing.Point(204, 275);
            edRampPeriod.Name = "edRampPeriod";
            edRampPeriod.Size = new System.Drawing.Size(140, 35);
            edRampPeriod.TabIndex = 48;
            edRampPeriod.Value = 8;
            // 
            // sbsiIncrementThreshold
            // 
            sbsiIncrementThreshold.Location = new System.Drawing.Point(14, 71);
            sbsiIncrementThreshold.Maximum = 65535;
            sbsiIncrementThreshold.Minimum = 0;
            sbsiIncrementThreshold.Name = "sbsiIncrementThreshold";
            sbsiIncrementThreshold.Size = new System.Drawing.Size(311, 60);
            sbsiIncrementThreshold.TabIndex = 44;
            sbsiIncrementThreshold.Text = "Increment Threshold";
            sbsiIncrementThreshold.TextBoxHint = "The integral constant applied to the integral.  Scaled to 1/16384ths, as typically you want this value to be less than 1.0";
            sbsiIncrementThreshold.value = (ushort)250;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(98, 287);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(75, 15);
            label1.TabIndex = 51;
            label1.Text = "Ramp Mode:";
            // 
            // edRampMode
            // 
            edRampMode.DropDownToolTip = "";
            edRampMode.dropdowntype = "SerialWombatClassLibrary.SerialWombat.ScaledOutputRampMode";
            edRampMode.Location = new System.Drawing.Point(125, 305);
            edRampMode.Name = "edRampMode";
            edRampMode.Size = new System.Drawing.Size(219, 35);
            edRampMode.TabIndex = 53;
            edRampMode.Value = 0;
            // 
            // RampOutputScaleControl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            Controls.Add(edRampMode);
            Controls.Add(bRampUpdateTarget);
            Controls.Add(sbsiSlowIncrement);
            Controls.Add(textBox2);
            Controls.Add(sbsiRampTarget);
            Controls.Add(bGenRampCode);
            Controls.Add(label1);
            Controls.Add(label6);
            Controls.Add(bConfigurePID);
            Controls.Add(sbsiFastIncrement);
            Controls.Add(edRampPeriod);
            Controls.Add(sbsiIncrementThreshold);
            Name = "RampOutputScaleControl";
            Size = new System.Drawing.Size(349, 379);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button bRampUpdateTarget;
        private SixteenBitSliderInput sbsiSlowIncrement;
        private System.Windows.Forms.TextBox textBox2;
        private SixteenBitSliderInput sbsiRampTarget;
        private System.Windows.Forms.Button bGenRampCode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bConfigurePID;
        private SixteenBitSliderInput sbsiFastIncrement;
        private EnumDropdown edRampPeriod;
        private SixteenBitSliderInput sbsiIncrementThreshold;
        private System.Windows.Forms.Label label1;
        private EnumDropdown edRampMode;
    }
}
