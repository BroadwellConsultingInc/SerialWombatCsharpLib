namespace SerialWombatWindowsFormsLibrary
{
    partial class ScaledOutputControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScaledOutputControl));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.sbsiInputMax = new SerialWombatWindowsFormsLibrary.SixteenBitSliderInput();
            this.sbsiInputMin = new SerialWombatWindowsFormsLibrary.SixteenBitSliderInput();
            this.bConfigureInputScaling = new System.Windows.Forms.Button();
            this.ckbInvert = new System.Windows.Forms.CheckBox();
            this.tpPID = new System.Windows.Forms.TabPage();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.sbsiKd = new SerialWombatWindowsFormsLibrary.SixteenBitSliderInput();
            this.sbsiKi = new SerialWombatWindowsFormsLibrary.SixteenBitSliderInput();
            this.edPIDPeriod = new SerialWombatWindowsFormsLibrary.EnumDropdown();
            this.bConfigurePID = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.sbsiKp = new SerialWombatWindowsFormsLibrary.SixteenBitSliderInput();
            this.sbsiPIDTarget = new SerialWombatWindowsFormsLibrary.SixteenBitSliderInput();
            this.tpHysteresis = new System.Windows.Forms.TabPage();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.bConfigureHysteresis = new System.Windows.Forms.Button();
            this.sbsiHysLowOutput = new SerialWombatWindowsFormsLibrary.SixteenBitSliderInput();
            this.sbsiHysInitialOutputValue = new SerialWombatWindowsFormsLibrary.SixteenBitSliderInput();
            this.sbsiHysHighOutputValue = new SerialWombatWindowsFormsLibrary.SixteenBitSliderInput();
            this.sbsiHysHighLimit = new SerialWombatWindowsFormsLibrary.SixteenBitSliderInput();
            this.sbsiHysLowLimit = new SerialWombatWindowsFormsLibrary.SixteenBitSliderInput();
            this.tpTimeout = new System.Windows.Forms.TabPage();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.bConfigureTimeout = new System.Windows.Forms.Button();
            this.sbsiTimeoutOutputValue = new SerialWombatWindowsFormsLibrary.SixteenBitSliderInput();
            this.sbsiTimeout_mS = new SerialWombatWindowsFormsLibrary.SixteenBitSliderInput();
            this.tpFiltering = new System.Windows.Forms.TabPage();
            this.bWriteTarget = new System.Windows.Forms.Button();
            this.sbsiFilterTarget = new SerialWombatWindowsFormsLibrary.SixteenBitSliderInput();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.bConfigureMaximumRate = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.bConfigureFiltering = new System.Windows.Forms.Button();
            this.edFilteringPeriod = new SerialWombatWindowsFormsLibrary.EnumDropdown();
            this.sbsiFilterConstant = new SerialWombatWindowsFormsLibrary.SixteenBitSliderInput();
            this.tpOutputScaling = new System.Windows.Forms.TabPage();
            this.bConfigureOutputScaling = new System.Windows.Forms.Button();
            this.sbsiOutputScalingMax = new SerialWombatWindowsFormsLibrary.SixteenBitSliderInput();
            this.sbsiOutputScalingMin = new SerialWombatWindowsFormsLibrary.SixteenBitSliderInput();
            this.swpdsInput = new SerialWombatWindowsFormsLibrary.SerialWombatPublicDataControl();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.ckbScaledOutputEnable = new System.Windows.Forms.CheckBox();
            this.sbsiFilterConstant2 = new SerialWombatWindowsFormsLibrary.SixteenBitSliderInput();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tpPID.SuspendLayout();
            this.tpHysteresis.SuspendLayout();
            this.tpTimeout.SuspendLayout();
            this.tpFiltering.SuspendLayout();
            this.tpOutputScaling.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tpPID);
            this.tabControl1.Controls.Add(this.tpHysteresis);
            this.tabControl1.Controls.Add(this.tpTimeout);
            this.tabControl1.Controls.Add(this.tpFiltering);
            this.tabControl1.Controls.Add(this.tpOutputScaling);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(401, 511);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.sbsiInputMax);
            this.tabPage1.Controls.Add(this.sbsiInputMin);
            this.tabPage1.Controls.Add(this.bConfigureInputScaling);
            this.tabPage1.Controls.Add(this.ckbInvert);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(393, 483);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Input Scaling";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 265);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(344, 160);
            this.textBox1.TabIndex = 14;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // sbsiInputMax
            // 
            this.sbsiInputMax.Location = new System.Drawing.Point(25, 75);
            this.sbsiInputMax.Maximum = 65535;
            this.sbsiInputMax.Minimum = 0;
            this.sbsiInputMax.Name = "sbsiInputMax";
            this.sbsiInputMax.Size = new System.Drawing.Size(328, 76);
            this.sbsiInputMax.TabIndex = 13;
            this.sbsiInputMax.Text = "inputMax";
            this.sbsiInputMax.TextBoxHint = "The maximum value of the input range.  Input values greater or equal to that will" +
    " be scaled to 65535";
            this.sbsiInputMax.value = ((ushort)(65535));
            // 
            // sbsiInputMin
            // 
            this.sbsiInputMin.Location = new System.Drawing.Point(22, 6);
            this.sbsiInputMin.Maximum = 65535;
            this.sbsiInputMin.Minimum = 0;
            this.sbsiInputMin.Name = "sbsiInputMin";
            this.sbsiInputMin.Size = new System.Drawing.Size(328, 76);
            this.sbsiInputMin.TabIndex = 12;
            this.sbsiInputMin.Text = "inputMin";
            this.sbsiInputMin.TextBoxHint = "The minimum value of the input range.  Input values less than or equal to that wi" +
    "ll be scaled to 0";
            this.sbsiInputMin.value = ((ushort)(0));
            // 
            // bConfigureInputScaling
            // 
            this.bConfigureInputScaling.Location = new System.Drawing.Point(77, 205);
            this.bConfigureInputScaling.Name = "bConfigureInputScaling";
            this.bConfigureInputScaling.Size = new System.Drawing.Size(167, 23);
            this.bConfigureInputScaling.TabIndex = 5;
            this.bConfigureInputScaling.Text = "Configure Input Scaling";
            this.bConfigureInputScaling.UseVisualStyleBackColor = true;
            this.bConfigureInputScaling.Click += new System.EventHandler(this.bConfigureInputScaling_Click);
            // 
            // ckbInvert
            // 
            this.ckbInvert.AutoSize = true;
            this.ckbInvert.Location = new System.Drawing.Point(119, 157);
            this.ckbInvert.Name = "ckbInvert";
            this.ckbInvert.Size = new System.Drawing.Size(87, 19);
            this.ckbInvert.TabIndex = 4;
            this.ckbInvert.Text = "Invert Input";
            this.toolTip1.SetToolTip(this.ckbInvert, "inverted False - input value isn\'t changed.  True- input value is subtracted from" +
        " 65535");
            this.ckbInvert.UseVisualStyleBackColor = true;
            this.ckbInvert.CheckedChanged += new System.EventHandler(this.ckbInvert_CheckedChanged);
            // 
            // tpPID
            // 
            this.tpPID.Controls.Add(this.textBox2);
            this.tpPID.Controls.Add(this.sbsiKd);
            this.tpPID.Controls.Add(this.sbsiKi);
            this.tpPID.Controls.Add(this.edPIDPeriod);
            this.tpPID.Controls.Add(this.bConfigurePID);
            this.tpPID.Controls.Add(this.label6);
            this.tpPID.Controls.Add(this.sbsiKp);
            this.tpPID.Controls.Add(this.sbsiPIDTarget);
            this.tpPID.Location = new System.Drawing.Point(4, 24);
            this.tpPID.Name = "tpPID";
            this.tpPID.Padding = new System.Windows.Forms.Padding(3);
            this.tpPID.Size = new System.Drawing.Size(393, 483);
            this.tpPID.TabIndex = 1;
            this.tpPID.Text = "PID";
            this.tpPID.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(3, 399);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(344, 78);
            this.textBox2.TabIndex = 18;
            this.textBox2.Text = resources.GetString("textBox2.Text");
            // 
            // sbsiKd
            // 
            this.sbsiKd.Location = new System.Drawing.Point(23, 134);
            this.sbsiKd.Maximum = 65535;
            this.sbsiKd.Minimum = 0;
            this.sbsiKd.Name = "sbsiKd";
            this.sbsiKd.Size = new System.Drawing.Size(311, 74);
            this.sbsiKd.TabIndex = 17;
            this.sbsiKd.Text = "kD";
            this.sbsiKd.TextBoxHint = "The derivative contant applied to the derivative.  This value is scaled to 1/1638" +
    "4. ";
            this.sbsiKd.value = ((ushort)(0));
            // 
            // sbsiKi
            // 
            this.sbsiKi.Location = new System.Drawing.Point(23, 63);
            this.sbsiKi.Maximum = 65535;
            this.sbsiKi.Minimum = 0;
            this.sbsiKi.Name = "sbsiKi";
            this.sbsiKi.Size = new System.Drawing.Size(311, 74);
            this.sbsiKi.TabIndex = 16;
            this.sbsiKi.Text = "kI";
            this.sbsiKi.TextBoxHint = "The integral constant applied to the integral.  Scaled to 1/16384ths, as typicall" +
    "y you want this value to be less than 1.0";
            this.sbsiKi.value = ((ushort)(0));
            // 
            // edPIDPeriod
            // 
            this.edPIDPeriod.DropDownToolTip = "an enumerated time for how often the PID controller updates.  This value should b" +
    "e based on how fast the system responds to change in output so that integral and" +
    " derivative terms work correctly.";
            this.edPIDPeriod.dropdowntype = "SerialWombat.ScaledOutputPeriod";
            this.edPIDPeriod.Location = new System.Drawing.Point(35, 318);
            this.edPIDPeriod.Name = "edPIDPeriod";
            this.edPIDPeriod.Size = new System.Drawing.Size(274, 35);
            this.edPIDPeriod.TabIndex = 15;
            // 
            // bConfigurePID
            // 
            this.bConfigurePID.Location = new System.Drawing.Point(112, 359);
            this.bConfigurePID.Name = "bConfigurePID";
            this.bConfigurePID.Size = new System.Drawing.Size(108, 23);
            this.bConfigurePID.TabIndex = 14;
            this.bConfigurePID.Text = "Configure PID";
            this.bConfigurePID.UseVisualStyleBackColor = true;
            this.bConfigurePID.Click += new System.EventHandler(this.bConfigurePID_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 300);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Sample Period:";
            // 
            // sbsiKp
            // 
            this.sbsiKp.Location = new System.Drawing.Point(23, 6);
            this.sbsiKp.Maximum = 65535;
            this.sbsiKp.Minimum = 0;
            this.sbsiKp.Name = "sbsiKp";
            this.sbsiKp.Size = new System.Drawing.Size(311, 74);
            this.sbsiKp.TabIndex = 11;
            this.sbsiKp.Text = "kP";
            this.sbsiKp.TextBoxHint = "The proportional constant applied to the sum of the error, 1/ki * error sum, and " +
    "kd * derivative.  Scaled to 1/256ths";
            this.sbsiKp.value = ((ushort)(0));
            // 
            // sbsiPIDTarget
            // 
            this.sbsiPIDTarget.Location = new System.Drawing.Point(23, 214);
            this.sbsiPIDTarget.Maximum = 65535;
            this.sbsiPIDTarget.Minimum = 0;
            this.sbsiPIDTarget.Name = "sbsiPIDTarget";
            this.sbsiPIDTarget.Size = new System.Drawing.Size(311, 74);
            this.sbsiPIDTarget.TabIndex = 11;
            this.sbsiPIDTarget.Text = "Target Value";
            this.sbsiPIDTarget.TextBoxHint = "The value the output will attempt to control the input to";
            this.sbsiPIDTarget.value = ((ushort)(0));
            // 
            // tpHysteresis
            // 
            this.tpHysteresis.Controls.Add(this.textBox3);
            this.tpHysteresis.Controls.Add(this.bConfigureHysteresis);
            this.tpHysteresis.Controls.Add(this.sbsiHysLowOutput);
            this.tpHysteresis.Controls.Add(this.sbsiHysInitialOutputValue);
            this.tpHysteresis.Controls.Add(this.sbsiHysHighOutputValue);
            this.tpHysteresis.Controls.Add(this.sbsiHysHighLimit);
            this.tpHysteresis.Controls.Add(this.sbsiHysLowLimit);
            this.tpHysteresis.Location = new System.Drawing.Point(4, 24);
            this.tpHysteresis.Name = "tpHysteresis";
            this.tpHysteresis.Padding = new System.Windows.Forms.Padding(3);
            this.tpHysteresis.Size = new System.Drawing.Size(393, 483);
            this.tpHysteresis.TabIndex = 2;
            this.tpHysteresis.Text = "Hysteresis";
            this.tpHysteresis.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(9, 420);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox3.Size = new System.Drawing.Size(344, 57);
            this.textBox3.TabIndex = 19;
            this.textBox3.Text = resources.GetString("textBox3.Text");
            // 
            // bConfigureHysteresis
            // 
            this.bConfigureHysteresis.Location = new System.Drawing.Point(102, 391);
            this.bConfigureHysteresis.Name = "bConfigureHysteresis";
            this.bConfigureHysteresis.Size = new System.Drawing.Size(144, 23);
            this.bConfigureHysteresis.TabIndex = 2;
            this.bConfigureHysteresis.Text = "Configure Hysteresis";
            this.bConfigureHysteresis.UseVisualStyleBackColor = true;
            this.bConfigureHysteresis.Click += new System.EventHandler(this.bConfigureHysteresis_Click);
            // 
            // sbsiHysLowOutput
            // 
            this.sbsiHysLowOutput.Location = new System.Drawing.Point(6, 76);
            this.sbsiHysLowOutput.Maximum = 65535;
            this.sbsiHysLowOutput.Minimum = 0;
            this.sbsiHysLowOutput.Name = "sbsiHysLowOutput";
            this.sbsiHysLowOutput.Size = new System.Drawing.Size(328, 84);
            this.sbsiHysLowOutput.TabIndex = 1;
            this.sbsiHysLowOutput.Text = "lowOutputValue";
            this.sbsiHysLowOutput.TextBoxHint = "if the input source is at or below lowLimit then this value becomes the output";
            this.toolTip1.SetToolTip(this.sbsiHysLowOutput, "if the input source is at or below lowLimit then this value becomes the output");
            this.sbsiHysLowOutput.value = ((ushort)(0));
            // 
            // sbsiHysInitialOutputValue
            // 
            this.sbsiHysInitialOutputValue.Location = new System.Drawing.Point(3, 298);
            this.sbsiHysInitialOutputValue.Maximum = 65535;
            this.sbsiHysInitialOutputValue.Minimum = 0;
            this.sbsiHysInitialOutputValue.Name = "sbsiHysInitialOutputValue";
            this.sbsiHysInitialOutputValue.Size = new System.Drawing.Size(328, 74);
            this.sbsiHysInitialOutputValue.TabIndex = 0;
            this.sbsiHysInitialOutputValue.Text = "initialOutputValue";
            this.sbsiHysInitialOutputValue.TextBoxHint = "if the input source is between lowLimit and highLimit at initialization then this" +
    " value is output";
            this.sbsiHysInitialOutputValue.value = ((ushort)(0));
            // 
            // sbsiHysHighOutputValue
            // 
            this.sbsiHysHighOutputValue.Location = new System.Drawing.Point(6, 229);
            this.sbsiHysHighOutputValue.Maximum = 65535;
            this.sbsiHysHighOutputValue.Minimum = 0;
            this.sbsiHysHighOutputValue.Name = "sbsiHysHighOutputValue";
            this.sbsiHysHighOutputValue.Size = new System.Drawing.Size(328, 74);
            this.sbsiHysHighOutputValue.TabIndex = 0;
            this.sbsiHysHighOutputValue.Text = "highOutputValue";
            this.sbsiHysHighOutputValue.TextBoxHint = "if the input source is at or above highLimit then this value becomes the output";
            this.sbsiHysHighOutputValue.value = ((ushort)(0));
            // 
            // sbsiHysHighLimit
            // 
            this.sbsiHysHighLimit.Location = new System.Drawing.Point(6, 156);
            this.sbsiHysHighLimit.Maximum = 65535;
            this.sbsiHysHighLimit.Minimum = 0;
            this.sbsiHysHighLimit.Name = "sbsiHysHighLimit";
            this.sbsiHysHighLimit.Size = new System.Drawing.Size(328, 67);
            this.sbsiHysHighLimit.TabIndex = 0;
            this.sbsiHysHighLimit.Text = "highLimit";
            this.sbsiHysHighLimit.TextBoxHint = "if the input source is at or above this level then the output value is highOutput" +
    "Value";
            this.sbsiHysHighLimit.value = ((ushort)(0));
            // 
            // sbsiHysLowLimit
            // 
            this.sbsiHysLowLimit.Location = new System.Drawing.Point(6, 6);
            this.sbsiHysLowLimit.Maximum = 65535;
            this.sbsiHysLowLimit.Minimum = 0;
            this.sbsiHysLowLimit.Name = "sbsiHysLowLimit";
            this.sbsiHysLowLimit.Size = new System.Drawing.Size(328, 78);
            this.sbsiHysLowLimit.TabIndex = 0;
            this.sbsiHysLowLimit.Text = "lowLimit";
            this.sbsiHysLowLimit.TextBoxHint = "If the input source is at or below this level the output value is lowOutputValue";
            this.sbsiHysLowLimit.value = ((ushort)(0));
            // 
            // tpTimeout
            // 
            this.tpTimeout.Controls.Add(this.textBox4);
            this.tpTimeout.Controls.Add(this.bConfigureTimeout);
            this.tpTimeout.Controls.Add(this.sbsiTimeoutOutputValue);
            this.tpTimeout.Controls.Add(this.sbsiTimeout_mS);
            this.tpTimeout.Location = new System.Drawing.Point(4, 24);
            this.tpTimeout.Name = "tpTimeout";
            this.tpTimeout.Padding = new System.Windows.Forms.Padding(3);
            this.tpTimeout.Size = new System.Drawing.Size(393, 483);
            this.tpTimeout.TabIndex = 3;
            this.tpTimeout.Text = "Timeout";
            this.tpTimeout.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(6, 250);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox4.Size = new System.Drawing.Size(344, 217);
            this.textBox4.TabIndex = 20;
            this.textBox4.Text = resources.GetString("textBox4.Text");
            // 
            // bConfigureTimeout
            // 
            this.bConfigureTimeout.Location = new System.Drawing.Point(101, 192);
            this.bConfigureTimeout.Name = "bConfigureTimeout";
            this.bConfigureTimeout.Size = new System.Drawing.Size(128, 36);
            this.bConfigureTimeout.TabIndex = 2;
            this.bConfigureTimeout.Text = "Configure Timeout";
            this.bConfigureTimeout.UseVisualStyleBackColor = true;
            this.bConfigureTimeout.Click += new System.EventHandler(this.bConfigureTimeout_Click);
            // 
            // sbsiTimeoutOutputValue
            // 
            this.sbsiTimeoutOutputValue.Location = new System.Drawing.Point(6, 98);
            this.sbsiTimeoutOutputValue.Maximum = 65535;
            this.sbsiTimeoutOutputValue.Minimum = 0;
            this.sbsiTimeoutOutputValue.Name = "sbsiTimeoutOutputValue";
            this.sbsiTimeoutOutputValue.Size = new System.Drawing.Size(328, 76);
            this.sbsiTimeoutOutputValue.TabIndex = 1;
            this.sbsiTimeoutOutputValue.Text = "timeoutOutputValue";
            this.sbsiTimeoutOutputValue.TextBoxHint = "The 16 bit value that should be output if a timeout occurs";
            this.sbsiTimeoutOutputValue.value = ((ushort)(0));
            // 
            // sbsiTimeout_mS
            // 
            this.sbsiTimeout_mS.Location = new System.Drawing.Point(6, 16);
            this.sbsiTimeout_mS.Maximum = 65535;
            this.sbsiTimeout_mS.Minimum = 0;
            this.sbsiTimeout_mS.Name = "sbsiTimeout_mS";
            this.sbsiTimeout_mS.Size = new System.Drawing.Size(328, 76);
            this.sbsiTimeout_mS.TabIndex = 0;
            this.sbsiTimeout_mS.Text = "timeout_mS";
            this.sbsiTimeout_mS.TextBoxHint = "How long in mS before the timeout occurs.  Set to zero to disable the timeout";
            this.sbsiTimeout_mS.value = ((ushort)(0));
            // 
            // tpFiltering
            // 
            this.tpFiltering.Controls.Add(this.bWriteTarget);
            this.tpFiltering.Controls.Add(this.sbsiFilterTarget);
            this.tpFiltering.Controls.Add(this.textBox6);
            this.tpFiltering.Controls.Add(this.textBox5);
            this.tpFiltering.Controls.Add(this.bConfigureMaximumRate);
            this.tpFiltering.Controls.Add(this.label7);
            this.tpFiltering.Controls.Add(this.bConfigureFiltering);
            this.tpFiltering.Controls.Add(this.edFilteringPeriod);
            this.tpFiltering.Controls.Add(this.sbsiFilterConstant2);
            this.tpFiltering.Controls.Add(this.sbsiFilterConstant);
            this.tpFiltering.Location = new System.Drawing.Point(4, 24);
            this.tpFiltering.Name = "tpFiltering";
            this.tpFiltering.Padding = new System.Windows.Forms.Padding(3);
            this.tpFiltering.Size = new System.Drawing.Size(393, 483);
            this.tpFiltering.TabIndex = 4;
            this.tpFiltering.Text = "Filtering";
            this.tpFiltering.UseVisualStyleBackColor = true;
            // 
            // bWriteTarget
            // 
            this.bWriteTarget.Location = new System.Drawing.Point(333, 431);
            this.bWriteTarget.Name = "bWriteTarget";
            this.bWriteTarget.Size = new System.Drawing.Size(54, 23);
            this.bWriteTarget.TabIndex = 23;
            this.bWriteTarget.Text = "Write";
            this.bWriteTarget.UseVisualStyleBackColor = true;
            this.bWriteTarget.Click += new System.EventHandler(this.bWriteTarget_Click);
            // 
            // sbsiFilterTarget
            // 
            this.sbsiFilterTarget.Location = new System.Drawing.Point(16, 403);
            this.sbsiFilterTarget.Maximum = 65535;
            this.sbsiFilterTarget.Minimum = 0;
            this.sbsiFilterTarget.Name = "sbsiFilterTarget";
            this.sbsiFilterTarget.Size = new System.Drawing.Size(311, 74);
            this.sbsiFilterTarget.TabIndex = 22;
            this.sbsiFilterTarget.Text = "Target Value";
            this.sbsiFilterTarget.TextBoxHint = "The value the output will attempt to control the input to";
            this.sbsiFilterTarget.value = ((ushort)(0));
            this.sbsiFilterTarget.Load += new System.EventHandler(this.sbsiFilterTarget_Load);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(16, 340);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox6.Size = new System.Drawing.Size(344, 57);
            this.textBox6.TabIndex = 21;
            this.textBox6.Text = resources.GetString("textBox6.Text");
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(16, 157);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox5.Size = new System.Drawing.Size(344, 57);
            this.textBox5.TabIndex = 20;
            this.textBox5.Text = resources.GetString("textBox5.Text");
            // 
            // bConfigureMaximumRate
            // 
            this.bConfigureMaximumRate.Location = new System.Drawing.Point(86, 311);
            this.bConfigureMaximumRate.Name = "bConfigureMaximumRate";
            this.bConfigureMaximumRate.Size = new System.Drawing.Size(156, 23);
            this.bConfigureMaximumRate.TabIndex = 4;
            this.bConfigureMaximumRate.Text = "Configure Maxmum Rate";
            this.bConfigureMaximumRate.UseVisualStyleBackColor = true;
            this.bConfigureMaximumRate.Click += new System.EventHandler(this.bConfigureMaximumRate_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(154, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 15);
            this.label7.TabIndex = 3;
            this.label7.Text = "OR";
            // 
            // bConfigureFiltering
            // 
            this.bConfigureFiltering.Location = new System.Drawing.Point(86, 128);
            this.bConfigureFiltering.Name = "bConfigureFiltering";
            this.bConfigureFiltering.Size = new System.Drawing.Size(156, 23);
            this.bConfigureFiltering.TabIndex = 2;
            this.bConfigureFiltering.Text = "Configure 1st order Filtering";
            this.bConfigureFiltering.UseVisualStyleBackColor = true;
            this.bConfigureFiltering.Click += new System.EventHandler(this.bConfigureFiltering_Click);
            // 
            // edFilteringPeriod
            // 
            this.edFilteringPeriod.DropDownToolTip = "";
            this.edFilteringPeriod.dropdowntype = "SerialWombat.ScaledOutputPeriod";
            this.edFilteringPeriod.Location = new System.Drawing.Point(30, 97);
            this.edFilteringPeriod.Name = "edFilteringPeriod";
            this.edFilteringPeriod.Size = new System.Drawing.Size(274, 35);
            this.edFilteringPeriod.TabIndex = 1;
            // 
            // sbsiFilterConstant
            // 
            this.sbsiFilterConstant.Location = new System.Drawing.Point(6, 15);
            this.sbsiFilterConstant.Maximum = 65535;
            this.sbsiFilterConstant.Minimum = 0;
            this.sbsiFilterConstant.Name = "sbsiFilterConstant";
            this.sbsiFilterConstant.Size = new System.Drawing.Size(328, 76);
            this.sbsiFilterConstant.TabIndex = 0;
            this.sbsiFilterConstant.Text = "filterConstant/maximumChangeCounts Up";
            this.sbsiFilterConstant.TextBoxHint = "";
            this.sbsiFilterConstant.value = ((ushort)(0));
            // 
            // tpOutputScaling
            // 
            this.tpOutputScaling.Controls.Add(this.bConfigureOutputScaling);
            this.tpOutputScaling.Controls.Add(this.sbsiOutputScalingMax);
            this.tpOutputScaling.Controls.Add(this.sbsiOutputScalingMin);
            this.tpOutputScaling.Location = new System.Drawing.Point(4, 24);
            this.tpOutputScaling.Name = "tpOutputScaling";
            this.tpOutputScaling.Padding = new System.Windows.Forms.Padding(3);
            this.tpOutputScaling.Size = new System.Drawing.Size(393, 483);
            this.tpOutputScaling.TabIndex = 5;
            this.tpOutputScaling.Text = "Output Scaling";
            this.tpOutputScaling.UseVisualStyleBackColor = true;
            // 
            // bConfigureOutputScaling
            // 
            this.bConfigureOutputScaling.Location = new System.Drawing.Point(77, 175);
            this.bConfigureOutputScaling.Name = "bConfigureOutputScaling";
            this.bConfigureOutputScaling.Size = new System.Drawing.Size(167, 23);
            this.bConfigureOutputScaling.TabIndex = 16;
            this.bConfigureOutputScaling.Text = "Configure Output Scaling";
            this.bConfigureOutputScaling.UseVisualStyleBackColor = true;
            this.bConfigureOutputScaling.Click += new System.EventHandler(this.bConfigureOutputScaling_Click);
            // 
            // sbsiOutputScalingMax
            // 
            this.sbsiOutputScalingMax.Location = new System.Drawing.Point(9, 84);
            this.sbsiOutputScalingMax.Maximum = 65535;
            this.sbsiOutputScalingMax.Minimum = 0;
            this.sbsiOutputScalingMax.Name = "sbsiOutputScalingMax";
            this.sbsiOutputScalingMax.Size = new System.Drawing.Size(328, 76);
            this.sbsiOutputScalingMax.TabIndex = 15;
            this.sbsiOutputScalingMax.Text = "outputMax";
            this.sbsiOutputScalingMax.TextBoxHint = "";
            this.sbsiOutputScalingMax.value = ((ushort)(65535));
            // 
            // sbsiOutputScalingMin
            // 
            this.sbsiOutputScalingMin.Location = new System.Drawing.Point(6, 15);
            this.sbsiOutputScalingMin.Maximum = 65535;
            this.sbsiOutputScalingMin.Minimum = 0;
            this.sbsiOutputScalingMin.Name = "sbsiOutputScalingMin";
            this.sbsiOutputScalingMin.Size = new System.Drawing.Size(328, 76);
            this.sbsiOutputScalingMin.TabIndex = 14;
            this.sbsiOutputScalingMin.Text = "outputMin";
            this.sbsiOutputScalingMin.TextBoxHint = "";
            this.sbsiOutputScalingMin.value = ((ushort)(0));
            // 
            // swpdsInput
            // 
            this.swpdsInput.DataSourceValue = ((byte)(0));
            this.swpdsInput.DropDownToolTip = "The pin or public data id that should be read to drive the output value.  Only us" +
    "ed when enabled is set to true";
            this.swpdsInput.Location = new System.Drawing.Point(84, 516);
            this.swpdsInput.Name = "swpdsInput";
            this.swpdsInput.Size = new System.Drawing.Size(283, 35);
            this.swpdsInput.TabIndex = 11;
            // 
            // ckbScaledOutputEnable
            // 
            this.ckbScaledOutputEnable.AutoSize = true;
            this.ckbScaledOutputEnable.Location = new System.Drawing.Point(6, 523);
            this.ckbScaledOutputEnable.Name = "ckbScaledOutputEnable";
            this.ckbScaledOutputEnable.Size = new System.Drawing.Size(61, 19);
            this.ckbScaledOutputEnable.TabIndex = 12;
            this.ckbScaledOutputEnable.Text = "Enable";
            this.toolTip1.SetToolTip(this.ckbScaledOutputEnable, "Enables the Scaled Output block.  If false then the current pin\'s public data val" +
        "ue is used as the setting for the output");
            this.ckbScaledOutputEnable.UseVisualStyleBackColor = true;
            this.ckbScaledOutputEnable.CheckedChanged += new System.EventHandler(this.ckbScaledOutputEnable_CheckedChanged);
            // 
            // sbsiFilterConstant2
            // 
            this.sbsiFilterConstant2.Location = new System.Drawing.Point(16, 235);
            this.sbsiFilterConstant2.Maximum = 65535;
            this.sbsiFilterConstant2.Minimum = 0;
            this.sbsiFilterConstant2.Name = "sbsiFilterConstant2";
            this.sbsiFilterConstant2.Size = new System.Drawing.Size(328, 76);
            this.sbsiFilterConstant2.TabIndex = 0;
            this.sbsiFilterConstant2.Text = "maximumChangeCountsDown";
            this.sbsiFilterConstant2.TextBoxHint = "";
            this.sbsiFilterConstant2.value = ((ushort)(0));
            // 
            // ScaledOutputControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ckbScaledOutputEnable);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.swpdsInput);
            this.Name = "ScaledOutputControl";
            this.Size = new System.Drawing.Size(407, 542);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tpPID.ResumeLayout(false);
            this.tpPID.PerformLayout();
            this.tpHysteresis.ResumeLayout(false);
            this.tpHysteresis.PerformLayout();
            this.tpTimeout.ResumeLayout(false);
            this.tpTimeout.PerformLayout();
            this.tpFiltering.ResumeLayout(false);
            this.tpFiltering.PerformLayout();
            this.tpOutputScaling.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.CheckBox ckbInvert;
        private System.Windows.Forms.Button bConfigureInputScaling;
        private SerialWombatPublicDataControl swpdsInput;
        private System.Windows.Forms.TabPage tpHysteresis;
        private  SixteenBitSliderInput sbsiHysLowOutput;
        private  SixteenBitSliderInput sbsiHysHighOutputValue;
        private  SixteenBitSliderInput sbsiHysHighLimit;
        private  SixteenBitSliderInput sbsiHysLowLimit;
        private System.Windows.Forms.Button bConfigureHysteresis;
        private  SixteenBitSliderInput sbsiHysInitialOutputValue;
        private System.Windows.Forms.TabPage tpTimeout;
        private System.Windows.Forms.Button bConfigureTimeout;
        private  SixteenBitSliderInput sbsiTimeoutOutputValue;
        private  SixteenBitSliderInput sbsiTimeout_mS;
        private System.Windows.Forms.TabPage tpFiltering;
        private  SixteenBitSliderInput sbsiFilterConstant;
        private EnumDropdown edFilteringPeriod;
        private SixteenBitSliderInput sbsiInputMax;
        private SixteenBitSliderInput sbsiInputMin;
        private System.Windows.Forms.TabPage tpPID;
        private SixteenBitSliderInput sbsiKd;
        private SixteenBitSliderInput sbsiKi;
        private EnumDropdown edPIDPeriod;
        private System.Windows.Forms.Button bConfigurePID;
        private System.Windows.Forms.Label label6;
        private SixteenBitSliderInput sbsiKp;
        private SixteenBitSliderInput sbsiPIDTarget;
        private System.Windows.Forms.Button bConfigureMaximumRate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button bConfigureFiltering;
        private System.Windows.Forms.TabPage tpOutputScaling;
        private System.Windows.Forms.Button bConfigureOutputScaling;
        private SixteenBitSliderInput sbsiOutputScalingMax;
        private SixteenBitSliderInput sbsiOutputScalingMin;
        private System.Windows.Forms.CheckBox ckbScaledOutputEnable;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button bWriteTarget;
        private SixteenBitSliderInput sbsiFilterTarget;
        private SixteenBitSliderInput sbsiFilterConstant2;
    }
}
