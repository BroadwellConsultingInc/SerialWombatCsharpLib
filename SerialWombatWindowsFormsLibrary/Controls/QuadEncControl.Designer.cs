namespace SerialWombatWindowsFormsLibrary.Controls
{
    partial class QuadEncControl
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
            lFrequency = new System.Windows.Forms.Label();
            bReadFrequency = new System.Windows.Forms.Button();
            bRead = new System.Windows.Forms.Button();
            bWrite = new System.Windows.Forms.Button();
            label9 = new System.Windows.Forms.Label();
            tbValue = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            lSecondPin = new System.Windows.Forms.Label();
            sbsiFreqPeriod = new SixteenBitSliderInput();
            sbsiHighLimit = new SixteenBitSliderInput();
            sbsiLowLimit = new SixteenBitSliderInput();
            sbsiIncrement = new SixteenBitSliderInput();
            sbsiDebounce = new SixteenBitSliderInput();
            eddAction = new EnumDropdown();
            swpdTargetPin = new SerialWombatPinDropdown();
            ckbPullUps = new System.Windows.Forms.CheckBox();
            swpdSecondPin = new SerialWombatPinDropdown();
            bGenCode = new System.Windows.Forms.Button();
            realTimeScottPlot1 = new RealTimeScottPlot();
            ckbAutosample = new System.Windows.Forms.CheckBox();
            bSample = new System.Windows.Forms.Button();
            bConfigure = new System.Windows.Forms.Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.AutoSize = true;
            groupBox1.Controls.Add(lFrequency);
            groupBox1.Controls.Add(bReadFrequency);
            groupBox1.Controls.Add(bRead);
            groupBox1.Controls.Add(bWrite);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(tbValue);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(lSecondPin);
            groupBox1.Controls.Add(sbsiFreqPeriod);
            groupBox1.Controls.Add(sbsiHighLimit);
            groupBox1.Controls.Add(sbsiLowLimit);
            groupBox1.Controls.Add(sbsiIncrement);
            groupBox1.Controls.Add(sbsiDebounce);
            groupBox1.Controls.Add(eddAction);
            groupBox1.Controls.Add(swpdTargetPin);
            groupBox1.Controls.Add(ckbPullUps);
            groupBox1.Controls.Add(swpdSecondPin);
            groupBox1.Controls.Add(bGenCode);
            groupBox1.Controls.Add(realTimeScottPlot1);
            groupBox1.Controls.Add(ckbAutosample);
            groupBox1.Controls.Add(bSample);
            groupBox1.Controls.Add(bConfigure);
            groupBox1.Location = new System.Drawing.Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(602, 631);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // lFrequency
            // 
            lFrequency.AutoSize = true;
            lFrequency.Location = new System.Drawing.Point(200, 271);
            lFrequency.Name = "lFrequency";
            lFrequency.Size = new System.Drawing.Size(13, 15);
            lFrequency.TabIndex = 47;
            lFrequency.Text = "0";
            // 
            // bReadFrequency
            // 
            bReadFrequency.Enabled = false;
            bReadFrequency.Location = new System.Drawing.Point(271, 258);
            bReadFrequency.Name = "bReadFrequency";
            bReadFrequency.Size = new System.Drawing.Size(56, 23);
            bReadFrequency.TabIndex = 45;
            bReadFrequency.Text = "Read";
            bReadFrequency.UseVisualStyleBackColor = true;
            bReadFrequency.Click += bReadFrequency_Click;
            // 
            // bRead
            // 
            bRead.Location = new System.Drawing.Point(239, 296);
            bRead.Name = "bRead";
            bRead.Size = new System.Drawing.Size(56, 23);
            bRead.TabIndex = 45;
            bRead.Text = "Read";
            bRead.UseVisualStyleBackColor = true;
            bRead.Click += bRead_Click;
            // 
            // bWrite
            // 
            bWrite.Location = new System.Drawing.Point(177, 296);
            bWrite.Name = "bWrite";
            bWrite.Size = new System.Drawing.Size(56, 23);
            bWrite.TabIndex = 46;
            bWrite.Text = "Write";
            bWrite.UseVisualStyleBackColor = true;
            bWrite.Click += bWrite_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(8, 300);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(38, 15);
            label9.TabIndex = 44;
            label9.Text = "Value:";
            // 
            // tbValue
            // 
            tbValue.Location = new System.Drawing.Point(79, 297);
            tbValue.Name = "tbValue";
            tbValue.Size = new System.Drawing.Size(80, 23);
            tbValue.TabIndex = 43;
            tbValue.Text = "32768";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(200, 250);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(65, 15);
            label1.TabIndex = 42;
            label1.Text = "Frequency:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(346, 258);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(62, 15);
            label2.TabIndex = 42;
            label2.Text = "Target Pin:";
            // 
            // lSecondPin
            // 
            lSecondPin.AutoSize = true;
            lSecondPin.Location = new System.Drawing.Point(162, 22);
            lSecondPin.Name = "lSecondPin";
            lSecondPin.Size = new System.Drawing.Size(69, 15);
            lSecondPin.TabIndex = 42;
            lSecondPin.Text = "Second Pin:";
            // 
            // sbsiFreqPeriod
            // 
            sbsiFreqPeriod.Enabled = false;
            sbsiFreqPeriod.Location = new System.Drawing.Point(8, 244);
            sbsiFreqPeriod.Maximum = 65535;
            sbsiFreqPeriod.Minimum = 0;
            sbsiFreqPeriod.Name = "sbsiFreqPeriod";
            sbsiFreqPeriod.Size = new System.Drawing.Size(170, 47);
            sbsiFreqPeriod.TabIndex = 41;
            sbsiFreqPeriod.Text = "Freq Sample Period (mS)";
            sbsiFreqPeriod.TextBoxHint = "";
            sbsiFreqPeriod.value = (ushort)1000;
            // 
            // sbsiHighLimit
            // 
            sbsiHighLimit.Enabled = false;
            sbsiHighLimit.Location = new System.Drawing.Point(183, 176);
            sbsiHighLimit.Maximum = 65535;
            sbsiHighLimit.Minimum = 0;
            sbsiHighLimit.Name = "sbsiHighLimit";
            sbsiHighLimit.Size = new System.Drawing.Size(170, 76);
            sbsiHighLimit.TabIndex = 41;
            sbsiHighLimit.Text = "High Limit";
            sbsiHighLimit.TextBoxHint = "";
            sbsiHighLimit.value = ushort.MaxValue;
            // 
            // sbsiLowLimit
            // 
            sbsiLowLimit.Enabled = false;
            sbsiLowLimit.Location = new System.Drawing.Point(7, 176);
            sbsiLowLimit.Maximum = 65535;
            sbsiLowLimit.Minimum = 0;
            sbsiLowLimit.Name = "sbsiLowLimit";
            sbsiLowLimit.Size = new System.Drawing.Size(170, 76);
            sbsiLowLimit.TabIndex = 41;
            sbsiLowLimit.Text = "Low Limit";
            sbsiLowLimit.TextBoxHint = "";
            sbsiLowLimit.value = (ushort)0;
            // 
            // sbsiIncrement
            // 
            sbsiIncrement.Location = new System.Drawing.Point(183, 105);
            sbsiIncrement.Maximum = 65535;
            sbsiIncrement.Minimum = 0;
            sbsiIncrement.Name = "sbsiIncrement";
            sbsiIncrement.Size = new System.Drawing.Size(170, 76);
            sbsiIncrement.TabIndex = 41;
            sbsiIncrement.Text = "Increment";
            sbsiIncrement.TextBoxHint = "";
            sbsiIncrement.value = (ushort)1;
            // 
            // sbsiDebounce
            // 
            sbsiDebounce.Location = new System.Drawing.Point(7, 105);
            sbsiDebounce.Maximum = 65535;
            sbsiDebounce.Minimum = 0;
            sbsiDebounce.Name = "sbsiDebounce";
            sbsiDebounce.Size = new System.Drawing.Size(170, 76);
            sbsiDebounce.TabIndex = 41;
            sbsiDebounce.Text = "Debounce (mS)";
            sbsiDebounce.TextBoxHint = "";
            sbsiDebounce.value = (ushort)10;
            // 
            // eddAction
            // 
            eddAction.DropDownToolTip = "";
            eddAction.dropdowntype = "SerialWombatClassLibrary.SerialWombat.QuadEncReadModes";
            eddAction.Location = new System.Drawing.Point(6, 73);
            eddAction.Name = "eddAction";
            eddAction.Size = new System.Drawing.Size(274, 35);
            eddAction.TabIndex = 40;
            eddAction.Value = 0;
            // 
            // swpdTargetPin
            // 
            swpdTargetPin.Enabled = false;
            swpdTargetPin.IncludeNAPin = false;
            swpdTargetPin.Location = new System.Drawing.Point(350, 276);
            swpdTargetPin.Name = "swpdTargetPin";
            swpdTargetPin.Pin = 255;
            swpdTargetPin.PinType = SerialWombat.SerialWombatPinType.SerialWombatPin;
            swpdTargetPin.Size = new System.Drawing.Size(65, 25);
            swpdTargetPin.TabIndex = 38;
            // 
            // ckbPullUps
            // 
            ckbPullUps.AutoSize = true;
            ckbPullUps.Checked = true;
            ckbPullUps.CheckState = System.Windows.Forms.CheckState.Checked;
            ckbPullUps.Location = new System.Drawing.Point(239, 48);
            ckbPullUps.Name = "ckbPullUps";
            ckbPullUps.Size = new System.Drawing.Size(69, 19);
            ckbPullUps.TabIndex = 39;
            ckbPullUps.Text = "Pull Ups";
            ckbPullUps.UseVisualStyleBackColor = true;
            // 
            // swpdSecondPin
            // 
            swpdSecondPin.IncludeNAPin = false;
            swpdSecondPin.Location = new System.Drawing.Point(157, 42);
            swpdSecondPin.Name = "swpdSecondPin";
            swpdSecondPin.Pin = 255;
            swpdSecondPin.PinType = SerialWombat.SerialWombatPinType.SerialWombatPin;
            swpdSecondPin.Size = new System.Drawing.Size(65, 25);
            swpdSecondPin.TabIndex = 38;
            // 
            // bGenCode
            // 
            bGenCode.BackColor = System.Drawing.Color.MediumPurple;
            bGenCode.Location = new System.Drawing.Point(99, 20);
            bGenCode.Name = "bGenCode";
            bGenCode.Size = new System.Drawing.Size(45, 47);
            bGenCode.TabIndex = 37;
            bGenCode.Text = "Gen Code";
            bGenCode.UseVisualStyleBackColor = false;
            // 
            // realTimeScottPlot1
            // 
            realTimeScottPlot1.Location = new System.Drawing.Point(-14, 353);
            realTimeScottPlot1.Name = "realTimeScottPlot1";
            realTimeScottPlot1.Size = new System.Drawing.Size(429, 256);
            realTimeScottPlot1.TabIndex = 36;
            // 
            // ckbAutosample
            // 
            ckbAutosample.AutoSize = true;
            ckbAutosample.Location = new System.Drawing.Point(262, 328);
            ckbAutosample.Name = "ckbAutosample";
            ckbAutosample.Size = new System.Drawing.Size(91, 19);
            ckbAutosample.TabIndex = 35;
            ckbAutosample.Text = "AutoSample";
            ckbAutosample.UseVisualStyleBackColor = true;
            ckbAutosample.CheckedChanged += ckbAutosample_CheckedChanged;
            // 
            // bSample
            // 
            bSample.Location = new System.Drawing.Point(170, 325);
            bSample.Name = "bSample";
            bSample.Size = new System.Drawing.Size(75, 23);
            bSample.TabIndex = 34;
            bSample.Text = "Sample";
            bSample.UseVisualStyleBackColor = true;
            bSample.Click += bSample_Click;
            // 
            // bConfigure
            // 
            bConfigure.Location = new System.Drawing.Point(8, 32);
            bConfigure.Name = "bConfigure";
            bConfigure.Size = new System.Drawing.Size(75, 23);
            bConfigure.TabIndex = 33;
            bConfigure.Text = "Configure";
            bConfigure.UseVisualStyleBackColor = true;
            bConfigure.Click += bConfigure_Click;
            // 
            // QuadEncControl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(groupBox1);
            Name = "QuadEncControl";
            Size = new System.Drawing.Size(608, 637);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bGenCode;
        private RealTimeScottPlot realTimeScottPlot1;
        private System.Windows.Forms.CheckBox ckbAutosample;
        private System.Windows.Forms.Button bSample;
        private System.Windows.Forms.Button bConfigure;
        private EnumDropdown eddAction;
        private System.Windows.Forms.CheckBox ckbPullUps;
        private SerialWombatPinDropdown swpdSecondPin;
        private System.Windows.Forms.Label lSecondPin;
        private SixteenBitSliderInput sbsiHighLimit;
        private SixteenBitSliderInput sbsiLowLimit;
        private SixteenBitSliderInput sbsiIncrement;
        private SixteenBitSliderInput sbsiDebounce;
        private System.Windows.Forms.Button bRead;
        private System.Windows.Forms.Button bWrite;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbValue;
        private System.Windows.Forms.Label lFrequency;
        private System.Windows.Forms.Button bReadFrequency;
        private System.Windows.Forms.Label label1;
        private SixteenBitSliderInput sbsiFreqPeriod;
        private System.Windows.Forms.Label label2;
        private SerialWombatPinDropdown swpdTargetPin;
    }
}
