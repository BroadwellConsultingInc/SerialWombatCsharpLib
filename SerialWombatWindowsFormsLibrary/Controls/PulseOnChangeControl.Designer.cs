namespace SerialWombatWindowsFormsLibrary
{
    partial class PulseOnChangeControl
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bConfigureEntry = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.swpdcSecondSource = new SerialWombatWindowsFormsLibrary.SerialWombatPublicDataControl();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bConfigure = new System.Windows.Forms.Button();
            this.sbsiDutyCycle = new SerialWombatWindowsFormsLibrary.SixteenBitSliderInput();
            this.sbsiPWMPeriod = new SerialWombatWindowsFormsLibrary.SixteenBitSliderInput();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbLogicalOr = new System.Windows.Forms.RadioButton();
            this.rbLogicalAnd = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.edActive = new SerialWombatWindowsFormsLibrary.EnumDropdown();
            this.sbsiInactiveTime = new SerialWombatWindowsFormsLibrary.SixteenBitSliderInput();
            this.edInactive = new SerialWombatWindowsFormsLibrary.EnumDropdown();
            this.sbsiActiveTime = new SerialWombatWindowsFormsLibrary.SixteenBitSliderInput();
            this.sbsiParam2 = new SerialWombatWindowsFormsLibrary.SixteenBitSliderInput();
            this.sbsiParam1 = new SerialWombatWindowsFormsLibrary.SixteenBitSliderInput();
            this.edMode = new SerialWombatWindowsFormsLibrary.EnumDropdown();
            this.cbEntry = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.swpdcFirstSource = new SerialWombatWindowsFormsLibrary.SerialWombatPublicDataControl();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.bConfigureEntry);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.swpdcSecondSource);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.sbsiParam2);
            this.groupBox1.Controls.Add(this.sbsiParam1);
            this.groupBox1.Controls.Add(this.edMode);
            this.groupBox1.Controls.Add(this.cbEntry);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.swpdcFirstSource);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(973, 654);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // bConfigureEntry
            // 
            this.bConfigureEntry.Location = new System.Drawing.Point(464, 418);
            this.bConfigureEntry.Name = "bConfigureEntry";
            this.bConfigureEntry.Size = new System.Drawing.Size(138, 23);
            this.bConfigureEntry.TabIndex = 9;
            this.bConfigureEntry.Text = "ConfigureEntry";
            this.bConfigureEntry.UseVisualStyleBackColor = true;
            this.bConfigureEntry.Click += new System.EventHandler(this.bConfigureEntry_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(374, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "Second Source:";
            // 
            // swpdcSecondSource
            // 
            this.swpdcSecondSource.DataSourceValue = ((byte)(0));
            this.swpdcSecondSource.DropDownToolTip = "";
            this.swpdcSecondSource.Enabled = false;
            this.swpdcSecondSource.Location = new System.Drawing.Point(374, 204);
            this.swpdcSecondSource.Name = "swpdcSecondSource";
            this.swpdcSecondSource.Size = new System.Drawing.Size(286, 35);
            this.swpdcSecondSource.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Inactive Mode";
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.bConfigure);
            this.groupBox2.Controls.Add(this.sbsiDutyCycle);
            this.groupBox2.Controls.Add(this.sbsiPWMPeriod);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.edActive);
            this.groupBox2.Controls.Add(this.sbsiInactiveTime);
            this.groupBox2.Controls.Add(this.edInactive);
            this.groupBox2.Controls.Add(this.sbsiActiveTime);
            this.groupBox2.Location = new System.Drawing.Point(10, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(340, 610);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mode Configuration";
            // 
            // bConfigure
            // 
            this.bConfigure.Location = new System.Drawing.Point(115, 565);
            this.bConfigure.Name = "bConfigure";
            this.bConfigure.Size = new System.Drawing.Size(75, 23);
            this.bConfigure.TabIndex = 8;
            this.bConfigure.Text = "Configure";
            this.bConfigure.UseVisualStyleBackColor = true;
            this.bConfigure.Click += new System.EventHandler(this.bConfigure_Click);
            // 
            // sbsiDutyCycle
            // 
            this.sbsiDutyCycle.Location = new System.Drawing.Point(0, 483);
            this.sbsiDutyCycle.Name = "sbsiDutyCycle";
            this.sbsiDutyCycle.Size = new System.Drawing.Size(328, 76);
            this.sbsiDutyCycle.TabIndex = 7;
            this.sbsiDutyCycle.Text = "DutyCycle";
            this.sbsiDutyCycle.TextBoxHint = "";
            this.sbsiDutyCycle.value = ((ushort)(32768));
            // 
            // sbsiPWMPeriod
            // 
            this.sbsiPWMPeriod.Location = new System.Drawing.Point(6, 401);
            this.sbsiPWMPeriod.Name = "sbsiPWMPeriod";
            this.sbsiPWMPeriod.Size = new System.Drawing.Size(328, 76);
            this.sbsiPWMPeriod.TabIndex = 7;
            this.sbsiPWMPeriod.Text = "PWM Period (0 = NO PWM)";
            this.sbsiPWMPeriod.TextBoxHint = "";
            this.sbsiPWMPeriod.value = ((ushort)(0));
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbLogicalOr);
            this.groupBox3.Controls.Add(this.rbLogicalAnd);
            this.groupBox3.Location = new System.Drawing.Point(6, 305);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(135, 79);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Entry Combination";
            // 
            // rbLogicalOr
            // 
            this.rbLogicalOr.AutoSize = true;
            this.rbLogicalOr.Checked = true;
            this.rbLogicalOr.Location = new System.Drawing.Point(10, 47);
            this.rbLogicalOr.Name = "rbLogicalOr";
            this.rbLogicalOr.Size = new System.Drawing.Size(79, 19);
            this.rbLogicalOr.TabIndex = 1;
            this.rbLogicalOr.TabStop = true;
            this.rbLogicalOr.Text = "Logical Or";
            this.rbLogicalOr.UseVisualStyleBackColor = true;
            // 
            // rbLogicalAnd
            // 
            this.rbLogicalAnd.AutoSize = true;
            this.rbLogicalAnd.Location = new System.Drawing.Point(10, 22);
            this.rbLogicalAnd.Name = "rbLogicalAnd";
            this.rbLogicalAnd.Size = new System.Drawing.Size(88, 19);
            this.rbLogicalAnd.TabIndex = 0;
            this.rbLogicalAnd.Text = "Logical And";
            this.rbLogicalAnd.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Active Mode:";
            // 
            // edActive
            // 
            this.edActive.DropDownToolTip = "";
            this.edActive.dropdowntype = "SerialWombatPinStates";
            this.edActive.Location = new System.Drawing.Point(6, 35);
            this.edActive.Name = "edActive";
            this.edActive.Size = new System.Drawing.Size(274, 35);
            this.edActive.TabIndex = 0;
            // 
            // sbsiInactiveTime
            // 
            this.sbsiInactiveTime.Location = new System.Drawing.Point(0, 223);
            this.sbsiInactiveTime.Name = "sbsiInactiveTime";
            this.sbsiInactiveTime.Size = new System.Drawing.Size(328, 76);
            this.sbsiInactiveTime.TabIndex = 5;
            this.sbsiInactiveTime.Text = "Inactive Time (mS)";
            this.sbsiInactiveTime.TextBoxHint = "";
            this.sbsiInactiveTime.value = ((ushort)(200));
            // 
            // edInactive
            // 
            this.edInactive.DropDownToolTip = "";
            this.edInactive.dropdowntype = "SerialWombatPinStates";
            this.edInactive.Location = new System.Drawing.Point(6, 89);
            this.edInactive.Name = "edInactive";
            this.edInactive.Size = new System.Drawing.Size(274, 35);
            this.edInactive.TabIndex = 2;
            // 
            // sbsiActiveTime
            // 
            this.sbsiActiveTime.Location = new System.Drawing.Point(0, 141);
            this.sbsiActiveTime.Name = "sbsiActiveTime";
            this.sbsiActiveTime.Size = new System.Drawing.Size(328, 76);
            this.sbsiActiveTime.TabIndex = 5;
            this.sbsiActiveTime.Text = "Active Time (mS)";
            this.sbsiActiveTime.TextBoxHint = "";
            this.sbsiActiveTime.value = ((ushort)(100));
            // 
            // sbsiParam2
            // 
            this.sbsiParam2.Enabled = false;
            this.sbsiParam2.Location = new System.Drawing.Point(374, 336);
            this.sbsiParam2.Name = "sbsiParam2";
            this.sbsiParam2.Size = new System.Drawing.Size(328, 76);
            this.sbsiParam2.TabIndex = 5;
            this.sbsiParam2.Text = "Param 2";
            this.sbsiParam2.TextBoxHint = "";
            this.sbsiParam2.value = ((ushort)(0));
            // 
            // sbsiParam1
            // 
            this.sbsiParam1.Enabled = false;
            this.sbsiParam1.Location = new System.Drawing.Point(374, 254);
            this.sbsiParam1.Name = "sbsiParam1";
            this.sbsiParam1.Size = new System.Drawing.Size(328, 76);
            this.sbsiParam1.TabIndex = 5;
            this.sbsiParam1.Text = "Param 1";
            this.sbsiParam1.TextBoxHint = "";
            this.sbsiParam1.value = ((ushort)(0));
            // 
            // edMode
            // 
            this.edMode.DropDownToolTip = "";
            this.edMode.dropdowntype = "SerialWombat.PulseOnChangeModes";
            this.edMode.Location = new System.Drawing.Point(374, 150);
            this.edMode.Name = "edMode";
            this.edMode.Size = new System.Drawing.Size(274, 35);
            this.edMode.TabIndex = 4;
            this.edMode.SelectedEnumChanged += new System.EventHandler(this.edMode_SelectedEnumChanged);
            // 
            // cbEntry
            // 
            this.cbEntry.FormattingEnabled = true;
            this.cbEntry.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.cbEntry.Location = new System.Drawing.Point(418, 31);
            this.cbEntry.Name = "cbEntry";
            this.cbEntry.Size = new System.Drawing.Size(121, 23);
            this.cbEntry.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(374, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mode:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(374, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data Source:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(374, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Entry:";
            // 
            // swpdcFirstSource
            // 
            this.swpdcFirstSource.DataSourceValue = ((byte)(0));
            this.swpdcFirstSource.DropDownToolTip = "";
            this.swpdcFirstSource.Location = new System.Drawing.Point(374, 90);
            this.swpdcFirstSource.Name = "swpdcFirstSource";
            this.swpdcFirstSource.Size = new System.Drawing.Size(286, 35);
            this.swpdcFirstSource.TabIndex = 0;
            // 
            // PulseOnChangeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.groupBox1);
            this.Name = "PulseOnChangeControl";
            this.Size = new System.Drawing.Size(979, 660);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private EnumDropdown edMode;
        private System.Windows.Forms.ComboBox cbEntry;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private SerialWombatPublicDataControl swpdcFirstSource;
        private System.Windows.Forms.GroupBox groupBox2;
        private SixteenBitSliderInput sbsiParam2;
        private SixteenBitSliderInput sbsiParam1;
        private EnumDropdown edActive;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bConfigure;
        private SixteenBitSliderInput sbsiDutyCycle;
        private SixteenBitSliderInput sbsiPWMPeriod;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbLogicalOr;
        private System.Windows.Forms.RadioButton rbLogicalAnd;
        private SixteenBitSliderInput sbsiInactiveTime;
        private EnumDropdown edInactive;
        private SixteenBitSliderInput sbsiActiveTime;
        private System.Windows.Forms.Label label6;
        private SerialWombatPublicDataControl swpdcSecondSource;
        private System.Windows.Forms.Button bConfigureEntry;
    }
}
