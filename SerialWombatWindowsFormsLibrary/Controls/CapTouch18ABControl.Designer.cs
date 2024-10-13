namespace SerialWombatWindowsFormsLibrary.Controls
{
    partial class CapTouch18ABControl
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
            gbCapTouch = new System.Windows.Forms.GroupBox();
            bCalibrate = new System.Windows.Forms.Button();
            publicDataMonitorControl1 = new PublicDataMonitorControl();
            groupBox3 = new System.Windows.Forms.GroupBox();
            sbsiDelay = new SixteenBitSliderInput();
            sbsiChargeTime = new SixteenBitSliderInput();
            bGenConfigCode = new System.Windows.Forms.Button();
            bConfigure = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            gbCapTouch.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // gbCapTouch
            // 
            gbCapTouch.Controls.Add(bCalibrate);
            gbCapTouch.Controls.Add(publicDataMonitorControl1);
            gbCapTouch.Controls.Add(groupBox3);
            gbCapTouch.Location = new System.Drawing.Point(3, 3);
            gbCapTouch.Name = "gbCapTouch";
            gbCapTouch.Size = new System.Drawing.Size(462, 698);
            gbCapTouch.TabIndex = 1;
            gbCapTouch.TabStop = false;
            gbCapTouch.Text = "groupBox1";
            // 
            // bCalibrate
            // 
            bCalibrate.Location = new System.Drawing.Point(276, 34);
            bCalibrate.Name = "bCalibrate";
            bCalibrate.Size = new System.Drawing.Size(161, 23);
            bCalibrate.TabIndex = 4;
            bCalibrate.Text = "Measure Calibration";
            bCalibrate.UseVisualStyleBackColor = true;
            bCalibrate.Click += bCalibrate_Click;
            // 
            // publicDataMonitorControl1
            // 
            publicDataMonitorControl1.AutoSize = true;
            publicDataMonitorControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            publicDataMonitorControl1.Location = new System.Drawing.Point(6, 259);
            publicDataMonitorControl1.Name = "publicDataMonitorControl1";
            publicDataMonitorControl1.Size = new System.Drawing.Size(446, 427);
            publicDataMonitorControl1.TabIndex = 3;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(sbsiDelay);
            groupBox3.Controls.Add(sbsiChargeTime);
            groupBox3.Controls.Add(bGenConfigCode);
            groupBox3.Controls.Add(bConfigure);
            groupBox3.Location = new System.Drawing.Point(6, 22);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new System.Drawing.Size(253, 231);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Configure";
            // 
            // sbsiDelay
            // 
            sbsiDelay.Location = new System.Drawing.Point(10, 97);
            sbsiDelay.Maximum = 65535;
            sbsiDelay.Minimum = 0;
            sbsiDelay.Name = "sbsiDelay";
            sbsiDelay.Size = new System.Drawing.Size(235, 76);
            sbsiDelay.TabIndex = 33;
            sbsiDelay.Text = "Delay between readings (mS)";
            sbsiDelay.TextBoxHint = "delay in mS between readings";
            sbsiDelay.value = (ushort)10;
            // 
            // sbsiChargeTime
            // 
            sbsiChargeTime.Location = new System.Drawing.Point(13, 22);
            sbsiChargeTime.Maximum = 65535;
            sbsiChargeTime.Minimum = 0;
            sbsiChargeTime.Name = "sbsiChargeTime";
            sbsiChargeTime.Size = new System.Drawing.Size(232, 76);
            sbsiChargeTime.TabIndex = 32;
            sbsiChargeTime.Text = "Charge Time (uS)";
            sbsiChargeTime.TextBoxHint = "time in uS for capactive charging";
            sbsiChargeTime.value = (ushort)5000;
            // 
            // bGenConfigCode
            // 
            bGenConfigCode.BackColor = System.Drawing.Color.MediumPurple;
            bGenConfigCode.Enabled = false;
            bGenConfigCode.Location = new System.Drawing.Point(133, 179);
            bGenConfigCode.Name = "bGenConfigCode";
            bGenConfigCode.Size = new System.Drawing.Size(73, 27);
            bGenConfigCode.TabIndex = 31;
            bGenConfigCode.TabStop = false;
            bGenConfigCode.Text = "Gen Code";
            bGenConfigCode.UseVisualStyleBackColor = false;
            bGenConfigCode.Visible = false;
            // 
            // bConfigure
            // 
            bConfigure.Location = new System.Drawing.Point(13, 179);
            bConfigure.Name = "bConfigure";
            bConfigure.Size = new System.Drawing.Size(75, 23);
            bConfigure.TabIndex = 2;
            bConfigure.Text = "Configure";
            bConfigure.UseVisualStyleBackColor = true;
            bConfigure.Click += bConfigure_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(115, 209);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(132, 15);
            label1.TabIndex = 34;
            label1.Text = "CodeGen Coming Soon";
            // 
            // CapTouch18ABControl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            Controls.Add(gbCapTouch);
            Name = "CapTouch18ABControl";
            Size = new System.Drawing.Size(468, 704);
            gbCapTouch.ResumeLayout(false);
            gbCapTouch.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox gbCapTouch;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button bGenConfigCode;
        private System.Windows.Forms.Button bConfigure;
        private SixteenBitSliderInput sbsiChargeTime;
        private SixteenBitSliderInput sbsiDelay;
        private PublicDataMonitorControl publicDataMonitorControl1;
        private System.Windows.Forms.Button bCalibrate;
        private System.Windows.Forms.Label label1;
    }
}
