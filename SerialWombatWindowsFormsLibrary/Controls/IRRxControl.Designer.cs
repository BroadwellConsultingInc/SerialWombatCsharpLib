namespace SerialWombatWindowsFormsLibrary.Controls
{
    partial class IRRxControl
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
            groupBox1 = new System.Windows.Forms.GroupBox();
            label2 = new System.Windows.Forms.Label();
            enumDropdown1 = new EnumDropdown();
            lAddress = new System.Windows.Forms.Label();
            bReadAddress = new System.Windows.Forms.Button();
            ckbLineNumbers = new System.Windows.Forms.CheckBox();
            bClear = new System.Windows.Forms.Button();
            bReadQueue = new System.Windows.Forms.Button();
            bGenCode = new System.Windows.Forms.Button();
            bConfigure = new System.Windows.Forms.Button();
            ckbActiveHigh = new System.Windows.Forms.CheckBox();
            ckbUseRepeat = new System.Windows.Forms.CheckBox();
            ckbUseAddress = new System.Windows.Forms.CheckBox();
            label1 = new System.Windows.Forms.Label();
            sbacAddress = new SixteenBitAddressControl();
            sbsiTimeoutValue = new SixteenBitSliderInput();
            sbsiTimeout = new SixteenBitSliderInput();
            textBox1 = new System.Windows.Forms.TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.AutoSize = true;
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(enumDropdown1);
            groupBox1.Controls.Add(lAddress);
            groupBox1.Controls.Add(bReadAddress);
            groupBox1.Controls.Add(ckbLineNumbers);
            groupBox1.Controls.Add(bClear);
            groupBox1.Controls.Add(bReadQueue);
            groupBox1.Controls.Add(bGenCode);
            groupBox1.Controls.Add(bConfigure);
            groupBox1.Controls.Add(ckbActiveHigh);
            groupBox1.Controls.Add(ckbUseRepeat);
            groupBox1.Controls.Add(ckbUseAddress);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(sbacAddress);
            groupBox1.Controls.Add(sbsiTimeoutValue);
            groupBox1.Controls.Add(sbsiTimeout);
            groupBox1.Location = new System.Drawing.Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(365, 501);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(138, 280);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(67, 15);
            label2.TabIndex = 13;
            label2.Text = "PublicData:";
            // 
            // enumDropdown1
            // 
            enumDropdown1.DropDownToolTip = "";
            enumDropdown1.dropdowntype = "SerialWombatClassLibrary.SerialWombat.SerialWombatIRRxPublicDataOutput";
            enumDropdown1.Location = new System.Drawing.Point(211, 276);
            enumDropdown1.Name = "enumDropdown1";
            enumDropdown1.Size = new System.Drawing.Size(136, 35);
            enumDropdown1.TabIndex = 12;
            enumDropdown1.Value = 0;
            // 
            // lAddress
            // 
            lAddress.AutoSize = true;
            lAddress.Location = new System.Drawing.Point(149, 460);
            lAddress.Name = "lAddress";
            lAddress.Size = new System.Drawing.Size(12, 15);
            lAddress.TabIndex = 11;
            lAddress.Text = "-";
            // 
            // bReadAddress
            // 
            bReadAddress.Location = new System.Drawing.Point(6, 456);
            bReadAddress.Name = "bReadAddress";
            bReadAddress.Size = new System.Drawing.Size(111, 23);
            bReadAddress.TabIndex = 10;
            bReadAddress.Text = "Read Address";
            bReadAddress.UseVisualStyleBackColor = true;
            bReadAddress.Click += bReadAddress_Click;
            // 
            // ckbLineNumbers
            // 
            ckbLineNumbers.AutoSize = true;
            ckbLineNumbers.Location = new System.Drawing.Point(90, 331);
            ckbLineNumbers.Name = "ckbLineNumbers";
            ckbLineNumbers.Size = new System.Drawing.Size(97, 19);
            ckbLineNumbers.TabIndex = 9;
            ckbLineNumbers.Text = "LineNumbers";
            ckbLineNumbers.UseVisualStyleBackColor = true;
            // 
            // bClear
            // 
            bClear.Location = new System.Drawing.Point(222, 327);
            bClear.Name = "bClear";
            bClear.Size = new System.Drawing.Size(75, 23);
            bClear.TabIndex = 8;
            bClear.Text = "Clear";
            bClear.UseVisualStyleBackColor = true;
            bClear.Click += bClear_Click;
            // 
            // bReadQueue
            // 
            bReadQueue.Location = new System.Drawing.Point(9, 327);
            bReadQueue.Name = "bReadQueue";
            bReadQueue.Size = new System.Drawing.Size(75, 23);
            bReadQueue.TabIndex = 7;
            bReadQueue.Text = "Read Queue";
            bReadQueue.UseVisualStyleBackColor = true;
            bReadQueue.Click += bReadQueue_Click;
            // 
            // bGenCode
            // 
            bGenCode.BackColor = System.Drawing.Color.MediumPurple;
            bGenCode.Location = new System.Drawing.Point(252, 44);
            bGenCode.Name = "bGenCode";
            bGenCode.Size = new System.Drawing.Size(45, 47);
            bGenCode.TabIndex = 6;
            bGenCode.TabStop = false;
            bGenCode.Text = "Gen Code";
            bGenCode.UseVisualStyleBackColor = false;
            // 
            // bConfigure
            // 
            bConfigure.Location = new System.Drawing.Point(25, 44);
            bConfigure.Name = "bConfigure";
            bConfigure.Size = new System.Drawing.Size(75, 23);
            bConfigure.TabIndex = 4;
            bConfigure.Text = "Configure";
            bConfigure.UseVisualStyleBackColor = true;
            bConfigure.Click += bConfigure_Click;
            // 
            // ckbActiveHigh
            // 
            ckbActiveHigh.AutoSize = true;
            ckbActiveHigh.Location = new System.Drawing.Point(25, 276);
            ckbActiveHigh.Name = "ckbActiveHigh";
            ckbActiveHigh.Size = new System.Drawing.Size(88, 19);
            ckbActiveHigh.TabIndex = 3;
            ckbActiveHigh.Text = "Active High";
            ckbActiveHigh.UseVisualStyleBackColor = true;
            // 
            // ckbUseRepeat
            // 
            ckbUseRepeat.AutoSize = true;
            ckbUseRepeat.Checked = true;
            ckbUseRepeat.CheckState = System.Windows.Forms.CheckState.Checked;
            ckbUseRepeat.Location = new System.Drawing.Point(263, 245);
            ckbUseRepeat.Name = "ckbUseRepeat";
            ckbUseRepeat.Size = new System.Drawing.Size(84, 19);
            ckbUseRepeat.TabIndex = 3;
            ckbUseRepeat.Text = "Use Repeat";
            ckbUseRepeat.UseVisualStyleBackColor = true;
            // 
            // ckbUseAddress
            // 
            ckbUseAddress.AutoSize = true;
            ckbUseAddress.Location = new System.Drawing.Point(149, 246);
            ckbUseAddress.Name = "ckbUseAddress";
            ckbUseAddress.Size = new System.Drawing.Size(90, 19);
            ckbUseAddress.TabIndex = 3;
            ckbUseAddress.Text = "Use Address";
            ckbUseAddress.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(25, 245);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(49, 15);
            label1.TabIndex = 2;
            label1.Text = "Address";
            // 
            // sbacAddress
            // 
            sbacAddress.AutoSize = true;
            sbacAddress.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            sbacAddress.Location = new System.Drawing.Point(84, 244);
            sbacAddress.Name = "sbacAddress";
            sbacAddress.Size = new System.Drawing.Size(56, 26);
            sbacAddress.TabIndex = 1;
            sbacAddress.Text = "0x0000";
            sbacAddress.Value = (ushort)0;
            // 
            // sbsiTimeoutValue
            // 
            sbsiTimeoutValue.Location = new System.Drawing.Point(6, 162);
            sbsiTimeoutValue.Maximum = 65535;
            sbsiTimeoutValue.Minimum = 0;
            sbsiTimeoutValue.Name = "sbsiTimeoutValue";
            sbsiTimeoutValue.Size = new System.Drawing.Size(328, 76);
            sbsiTimeoutValue.TabIndex = 0;
            sbsiTimeoutValue.Text = "Timeout Value";
            sbsiTimeoutValue.TextBoxHint = "";
            sbsiTimeoutValue.value = ushort.MaxValue;
            // 
            // sbsiTimeout
            // 
            sbsiTimeout.Location = new System.Drawing.Point(6, 89);
            sbsiTimeout.Maximum = 65535;
            sbsiTimeout.Minimum = 0;
            sbsiTimeout.Name = "sbsiTimeout";
            sbsiTimeout.Size = new System.Drawing.Size(328, 76);
            sbsiTimeout.TabIndex = 0;
            sbsiTimeout.Text = "Timeout (mS)";
            sbsiTimeout.TextBoxHint = "";
            sbsiTimeout.value = (ushort)1000;
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(9, 362);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            textBox1.Size = new System.Drawing.Size(353, 90);
            textBox1.TabIndex = 7;
            // 
            // IRRxControl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            Controls.Add(textBox1);
            Controls.Add(groupBox1);
            Name = "IRRxControl";
            Size = new System.Drawing.Size(371, 507);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox ckbActiveHigh;
        private System.Windows.Forms.CheckBox ckbUseRepeat;
        private System.Windows.Forms.CheckBox ckbUseAddress;
        private System.Windows.Forms.Label label1;
        private SixteenBitAddressControl sbacAddress;
        private SixteenBitSliderInput sbsiTimeoutValue;
        private SixteenBitSliderInput sbsiTimeout;
        private System.Windows.Forms.Button bConfigure;
        private System.Windows.Forms.Button bGenCode;
        private System.Windows.Forms.Button bClear;
        private System.Windows.Forms.Button bReadQueue;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox ckbLineNumbers;
        private System.Windows.Forms.Label lAddress;
        private System.Windows.Forms.Button bReadAddress;
        private System.Windows.Forms.Label label2;
        private EnumDropdown enumDropdown1;
    }
}
