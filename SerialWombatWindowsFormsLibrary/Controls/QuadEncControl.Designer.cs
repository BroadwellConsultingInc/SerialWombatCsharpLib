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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lFrequency = new System.Windows.Forms.Label();
            this.bReadFrequency = new System.Windows.Forms.Button();
            this.bRead = new System.Windows.Forms.Button();
            this.bWrite = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.tbValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lSecondPin = new System.Windows.Forms.Label();
            this.sbsiFreqPeriod = new SerialWombatWindowsFormsLibrary.SixteenBitSliderInput();
            this.sbsiHighLimit = new SerialWombatWindowsFormsLibrary.SixteenBitSliderInput();
            this.sbsiLowLimit = new SerialWombatWindowsFormsLibrary.SixteenBitSliderInput();
            this.sbsiIncrement = new SerialWombatWindowsFormsLibrary.SixteenBitSliderInput();
            this.sbsiDebounce = new SerialWombatWindowsFormsLibrary.SixteenBitSliderInput();
            this.eddAction = new SerialWombatWindowsFormsLibrary.EnumDropdown();
            this.swpdTargetPin = new SerialWombatWindowsFormsLibrary.SerialWombatPinDropdown();
            this.ckbPullUps = new System.Windows.Forms.CheckBox();
            this.swpdSecondPin = new SerialWombatWindowsFormsLibrary.SerialWombatPinDropdown();
            this.bGenCode = new System.Windows.Forms.Button();
            this.realTimeScottPlot1 = new SerialWombatWindowsFormsLibrary.Controls.RealTimeScottPlot();
            this.ckbAutosample = new System.Windows.Forms.CheckBox();
            this.bSample = new System.Windows.Forms.Button();
            this.bConfigure = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.lFrequency);
            this.groupBox1.Controls.Add(this.bReadFrequency);
            this.groupBox1.Controls.Add(this.bRead);
            this.groupBox1.Controls.Add(this.bWrite);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.tbValue);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lSecondPin);
            this.groupBox1.Controls.Add(this.sbsiFreqPeriod);
            this.groupBox1.Controls.Add(this.sbsiHighLimit);
            this.groupBox1.Controls.Add(this.sbsiLowLimit);
            this.groupBox1.Controls.Add(this.sbsiIncrement);
            this.groupBox1.Controls.Add(this.sbsiDebounce);
            this.groupBox1.Controls.Add(this.eddAction);
            this.groupBox1.Controls.Add(this.swpdTargetPin);
            this.groupBox1.Controls.Add(this.ckbPullUps);
            this.groupBox1.Controls.Add(this.swpdSecondPin);
            this.groupBox1.Controls.Add(this.bGenCode);
            this.groupBox1.Controls.Add(this.realTimeScottPlot1);
            this.groupBox1.Controls.Add(this.ckbAutosample);
            this.groupBox1.Controls.Add(this.bSample);
            this.groupBox1.Controls.Add(this.bConfigure);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(602, 631);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // lFrequency
            // 
            this.lFrequency.AutoSize = true;
            this.lFrequency.Location = new System.Drawing.Point(200, 271);
            this.lFrequency.Name = "lFrequency";
            this.lFrequency.Size = new System.Drawing.Size(13, 15);
            this.lFrequency.TabIndex = 47;
            this.lFrequency.Text = "0";
            // 
            // bReadFrequency
            // 
            this.bReadFrequency.Enabled = false;
            this.bReadFrequency.Location = new System.Drawing.Point(271, 258);
            this.bReadFrequency.Name = "bReadFrequency";
            this.bReadFrequency.Size = new System.Drawing.Size(56, 23);
            this.bReadFrequency.TabIndex = 45;
            this.bReadFrequency.Text = "Read";
            this.bReadFrequency.UseVisualStyleBackColor = true;
            // 
            // bRead
            // 
            this.bRead.Location = new System.Drawing.Point(239, 296);
            this.bRead.Name = "bRead";
            this.bRead.Size = new System.Drawing.Size(56, 23);
            this.bRead.TabIndex = 45;
            this.bRead.Text = "Read";
            this.bRead.UseVisualStyleBackColor = true;
            // 
            // bWrite
            // 
            this.bWrite.Location = new System.Drawing.Point(177, 296);
            this.bWrite.Name = "bWrite";
            this.bWrite.Size = new System.Drawing.Size(56, 23);
            this.bWrite.TabIndex = 46;
            this.bWrite.Text = "Write";
            this.bWrite.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 300);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 15);
            this.label9.TabIndex = 44;
            this.label9.Text = "Value:";
            // 
            // tbValue
            // 
            this.tbValue.Location = new System.Drawing.Point(79, 297);
            this.tbValue.Name = "tbValue";
            this.tbValue.Size = new System.Drawing.Size(80, 23);
            this.tbValue.TabIndex = 43;
            this.tbValue.Text = "32768";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(200, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 15);
            this.label1.TabIndex = 42;
            this.label1.Text = "Frequency:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(346, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 42;
            this.label2.Text = "Target Pin:";
            // 
            // lSecondPin
            // 
            this.lSecondPin.AutoSize = true;
            this.lSecondPin.Location = new System.Drawing.Point(162, 22);
            this.lSecondPin.Name = "lSecondPin";
            this.lSecondPin.Size = new System.Drawing.Size(69, 15);
            this.lSecondPin.TabIndex = 42;
            this.lSecondPin.Text = "Second Pin:";
            // 
            // sbsiFreqPeriod
            // 
            this.sbsiFreqPeriod.Enabled = false;
            this.sbsiFreqPeriod.Location = new System.Drawing.Point(8, 244);
            this.sbsiFreqPeriod.Maximum = 65535;
            this.sbsiFreqPeriod.Minimum = 0;
            this.sbsiFreqPeriod.Name = "sbsiFreqPeriod";
            this.sbsiFreqPeriod.Size = new System.Drawing.Size(170, 47);
            this.sbsiFreqPeriod.TabIndex = 41;
            this.sbsiFreqPeriod.Text = "Freq Sample Period (mS)";
            this.sbsiFreqPeriod.TextBoxHint = "";
            this.sbsiFreqPeriod.value = ((ushort)(1000));
            // 
            // sbsiHighLimit
            // 
            this.sbsiHighLimit.Enabled = false;
            this.sbsiHighLimit.Location = new System.Drawing.Point(183, 176);
            this.sbsiHighLimit.Maximum = 65535;
            this.sbsiHighLimit.Minimum = 0;
            this.sbsiHighLimit.Name = "sbsiHighLimit";
            this.sbsiHighLimit.Size = new System.Drawing.Size(170, 76);
            this.sbsiHighLimit.TabIndex = 41;
            this.sbsiHighLimit.Text = "High Limit";
            this.sbsiHighLimit.TextBoxHint = "";
            this.sbsiHighLimit.value = ((ushort)(0));
            // 
            // sbsiLowLimit
            // 
            this.sbsiLowLimit.Enabled = false;
            this.sbsiLowLimit.Location = new System.Drawing.Point(7, 176);
            this.sbsiLowLimit.Maximum = 65535;
            this.sbsiLowLimit.Minimum = 0;
            this.sbsiLowLimit.Name = "sbsiLowLimit";
            this.sbsiLowLimit.Size = new System.Drawing.Size(170, 76);
            this.sbsiLowLimit.TabIndex = 41;
            this.sbsiLowLimit.Text = "Low Limit";
            this.sbsiLowLimit.TextBoxHint = "";
            this.sbsiLowLimit.value = ((ushort)(65535));
            // 
            // sbsiIncrement
            // 
            this.sbsiIncrement.Location = new System.Drawing.Point(183, 105);
            this.sbsiIncrement.Maximum = 65535;
            this.sbsiIncrement.Minimum = 0;
            this.sbsiIncrement.Name = "sbsiIncrement";
            this.sbsiIncrement.Size = new System.Drawing.Size(170, 76);
            this.sbsiIncrement.TabIndex = 41;
            this.sbsiIncrement.Text = "Increment";
            this.sbsiIncrement.TextBoxHint = "";
            this.sbsiIncrement.value = ((ushort)(1));
            // 
            // sbsiDebounce
            // 
            this.sbsiDebounce.Location = new System.Drawing.Point(7, 105);
            this.sbsiDebounce.Maximum = 65535;
            this.sbsiDebounce.Minimum = 0;
            this.sbsiDebounce.Name = "sbsiDebounce";
            this.sbsiDebounce.Size = new System.Drawing.Size(170, 76);
            this.sbsiDebounce.TabIndex = 41;
            this.sbsiDebounce.Text = "Debounce (mS)";
            this.sbsiDebounce.TextBoxHint = "";
            this.sbsiDebounce.value = ((ushort)(10));
            // 
            // eddAction
            // 
            this.eddAction.DropDownToolTip = "";
            this.eddAction.dropdowntype = "SerialWombatClassLibrary.SerialWombat.QuadEncReadModes";
            this.eddAction.Location = new System.Drawing.Point(6, 73);
            this.eddAction.Name = "eddAction";
            this.eddAction.Size = new System.Drawing.Size(274, 35);
            this.eddAction.TabIndex = 40;
            this.eddAction.Value = 0;
            // 
            // swpdTargetPin
            // 
            this.swpdTargetPin.Enabled = false;
            this.swpdTargetPin.IncludeNAPin = false;
            this.swpdTargetPin.Location = new System.Drawing.Point(350, 276);
            this.swpdTargetPin.Name = "swpdTargetPin";
            this.swpdTargetPin.Pin = ((byte)(255));
            this.swpdTargetPin.PinType = SerialWombat.SerialWombatPinType.SerialWombatPin;
            this.swpdTargetPin.Size = new System.Drawing.Size(65, 25);
            this.swpdTargetPin.TabIndex = 38;
            // 
            // ckbPullUps
            // 
            this.ckbPullUps.AutoSize = true;
            this.ckbPullUps.Checked = true;
            this.ckbPullUps.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbPullUps.Location = new System.Drawing.Point(239, 48);
            this.ckbPullUps.Name = "ckbPullUps";
            this.ckbPullUps.Size = new System.Drawing.Size(69, 19);
            this.ckbPullUps.TabIndex = 39;
            this.ckbPullUps.Text = "Pull Ups";
            this.ckbPullUps.UseVisualStyleBackColor = true;
            // 
            // swpdSecondPin
            // 
            this.swpdSecondPin.IncludeNAPin = false;
            this.swpdSecondPin.Location = new System.Drawing.Point(157, 42);
            this.swpdSecondPin.Name = "swpdSecondPin";
            this.swpdSecondPin.Pin = ((byte)(255));
            this.swpdSecondPin.PinType = SerialWombat.SerialWombatPinType.SerialWombatPin;
            this.swpdSecondPin.Size = new System.Drawing.Size(65, 25);
            this.swpdSecondPin.TabIndex = 38;
            // 
            // bGenCode
            // 
            this.bGenCode.BackColor = System.Drawing.Color.MediumPurple;
            this.bGenCode.Location = new System.Drawing.Point(99, 20);
            this.bGenCode.Name = "bGenCode";
            this.bGenCode.Size = new System.Drawing.Size(45, 47);
            this.bGenCode.TabIndex = 37;
            this.bGenCode.Text = "Gen Code";
            this.bGenCode.UseVisualStyleBackColor = false;
            this.bGenCode.Click += new System.EventHandler(this.bGenCode_Click);
            // 
            // realTimeScottPlot1
            // 
            this.realTimeScottPlot1.Location = new System.Drawing.Point(-14, 353);
            this.realTimeScottPlot1.Name = "realTimeScottPlot1";
            this.realTimeScottPlot1.Size = new System.Drawing.Size(429, 256);
            this.realTimeScottPlot1.TabIndex = 36;
            // 
            // ckbAutosample
            // 
            this.ckbAutosample.AutoSize = true;
            this.ckbAutosample.Location = new System.Drawing.Point(262, 328);
            this.ckbAutosample.Name = "ckbAutosample";
            this.ckbAutosample.Size = new System.Drawing.Size(91, 19);
            this.ckbAutosample.TabIndex = 35;
            this.ckbAutosample.Text = "AutoSample";
            this.ckbAutosample.UseVisualStyleBackColor = true;
            // 
            // bSample
            // 
            this.bSample.Location = new System.Drawing.Point(170, 325);
            this.bSample.Name = "bSample";
            this.bSample.Size = new System.Drawing.Size(75, 23);
            this.bSample.TabIndex = 34;
            this.bSample.Text = "Sample";
            this.bSample.UseVisualStyleBackColor = true;
            // 
            // bConfigure
            // 
            this.bConfigure.Location = new System.Drawing.Point(8, 32);
            this.bConfigure.Name = "bConfigure";
            this.bConfigure.Size = new System.Drawing.Size(75, 23);
            this.bConfigure.TabIndex = 33;
            this.bConfigure.Text = "Configure";
            this.bConfigure.UseVisualStyleBackColor = true;
            this.bConfigure.Click += new System.EventHandler(this.bConfigure_Click);
            // 
            // QuadEncControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.groupBox1);
            this.Name = "QuadEncControl";
            this.Size = new System.Drawing.Size(608, 637);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
