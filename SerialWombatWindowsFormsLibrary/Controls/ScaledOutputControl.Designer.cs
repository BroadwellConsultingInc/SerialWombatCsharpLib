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
            this.bGenInputScalingCode = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.sbsiInputMax = new SerialWombatWindowsFormsLibrary.SixteenBitSliderInput();
            this.sbsiInputMin = new SerialWombatWindowsFormsLibrary.SixteenBitSliderInput();
            this.bConfigureInputScaling = new System.Windows.Forms.Button();
            this.ckbInvert = new System.Windows.Forms.CheckBox();
            this.tpPID = new System.Windows.Forms.TabPage();
            this.tabControl4 = new System.Windows.Forms.TabControl();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.bGenHysteresisCode = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.bConfigureHysteresis = new System.Windows.Forms.Button();
            this.sbsiHysLowOutput = new SerialWombatWindowsFormsLibrary.SixteenBitSliderInput();
            this.sbsiHysInitialOutputValue = new SerialWombatWindowsFormsLibrary.SixteenBitSliderInput();
            this.sbsiHysHighOutputValue = new SerialWombatWindowsFormsLibrary.SixteenBitSliderInput();
            this.sbsiHysHighLimit = new SerialWombatWindowsFormsLibrary.SixteenBitSliderInput();
            this.sbsiHysLowLimit = new SerialWombatWindowsFormsLibrary.SixteenBitSliderInput();
            this.tpPID1 = new System.Windows.Forms.TabPage();
            this.pidControl1 = new SerialWombatWindowsFormsLibrary.PIDControl();
            this.tpTimeout = new System.Windows.Forms.TabPage();
            this.bGenTimeoutCode = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.bConfigureTimeout = new System.Windows.Forms.Button();
            this.sbsiTimeoutOutputValue = new SerialWombatWindowsFormsLibrary.SixteenBitSliderInput();
            this.sbsiTimeout_mS = new SerialWombatWindowsFormsLibrary.SixteenBitSliderInput();
            this.tpFiltering = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.bGenFilterCode = new System.Windows.Forms.Button();
            this.sbsiFilterConstant = new SerialWombatWindowsFormsLibrary.SixteenBitSliderInput();
            this.bConfigureFiltering = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.bGenRateLimit = new System.Windows.Forms.Button();
            this.sbsiMaxChangeUp = new SerialWombatWindowsFormsLibrary.SixteenBitSliderInput();
            this.sbsiFilterConstant2 = new SerialWombatWindowsFormsLibrary.SixteenBitSliderInput();
            this.bConfigureMaximumRate = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.edFilteringPeriod = new SerialWombatWindowsFormsLibrary.EnumDropdown();
            this.tpOutputScaling = new System.Windows.Forms.TabPage();
            this.tabControl3 = new System.Windows.Forms.TabControl();
            this.MinMax = new System.Windows.Forms.TabPage();
            this.sbsiOutputScalingMin = new SerialWombatWindowsFormsLibrary.SixteenBitSliderInput();
            this.bGenOutputScalingcode = new System.Windows.Forms.Button();
            this.sbsiOutputScalingMax = new SerialWombatWindowsFormsLibrary.SixteenBitSliderInput();
            this.bConfigureOutputScaling = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.sbac2DIndex = new SerialWombatWindowsFormsLibrary.SixteenBitAddressControl();
            this.button1 = new System.Windows.Forms.Button();
            this.b2DConfigure = new System.Windows.Forms.Button();
            this.gb2DData = new System.Windows.Forms.GroupBox();
            this.l2DWarning = new System.Windows.Forms.Label();
            this.pXY = new System.Windows.Forms.Panel();
            this.formsPlot1 = new ScottPlot.FormsPlot();
            this.swpdsInput = new SerialWombatWindowsFormsLibrary.SerialWombatPublicDataControl();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.ckbScaledOutputEnable = new System.Windows.Forms.CheckBox();
            this.button4 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tpPID.SuspendLayout();
            this.tabControl4.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.tpPID1.SuspendLayout();
            this.tpTimeout.SuspendLayout();
            this.tpFiltering.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tpOutputScaling.SuspendLayout();
            this.tabControl3.SuspendLayout();
            this.MinMax.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.gb2DData.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tpPID);
            this.tabControl1.Controls.Add(this.tpTimeout);
            this.tabControl1.Controls.Add(this.tpFiltering);
            this.tabControl1.Controls.Add(this.tpOutputScaling);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(401, 496);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.bGenInputScalingCode);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.sbsiInputMax);
            this.tabPage1.Controls.Add(this.sbsiInputMin);
            this.tabPage1.Controls.Add(this.bConfigureInputScaling);
            this.tabPage1.Controls.Add(this.ckbInvert);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(393, 468);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Input Scaling";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // bGenInputScalingCode
            // 
            this.bGenInputScalingCode.BackColor = System.Drawing.Color.MediumPurple;
            this.bGenInputScalingCode.Location = new System.Drawing.Point(283, 193);
            this.bGenInputScalingCode.Name = "bGenInputScalingCode";
            this.bGenInputScalingCode.Size = new System.Drawing.Size(91, 47);
            this.bGenInputScalingCode.TabIndex = 30;
            this.bGenInputScalingCode.Text = "Gen Input Scaling Code";
            this.bGenInputScalingCode.UseVisualStyleBackColor = false;
            this.bGenInputScalingCode.Click += new System.EventHandler(this.bGenInputScalingCode_Click);
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
            this.tpPID.Controls.Add(this.tabControl4);
            this.tpPID.Location = new System.Drawing.Point(4, 24);
            this.tpPID.Name = "tpPID";
            this.tpPID.Padding = new System.Windows.Forms.Padding(3);
            this.tpPID.Size = new System.Drawing.Size(393, 468);
            this.tpPID.TabIndex = 1;
            this.tpPID.Text = "Feedback Control";
            this.tpPID.UseVisualStyleBackColor = true;
            // 
            // tabControl4
            // 
            this.tabControl4.Controls.Add(this.tabPage7);
            this.tabControl4.Controls.Add(this.tpPID1);
            this.tabControl4.Location = new System.Drawing.Point(6, 6);
            this.tabControl4.Name = "tabControl4";
            this.tabControl4.SelectedIndex = 0;
            this.tabControl4.Size = new System.Drawing.Size(381, 456);
            this.tabControl4.TabIndex = 33;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.bGenHysteresisCode);
            this.tabPage7.Controls.Add(this.textBox3);
            this.tabPage7.Controls.Add(this.bConfigureHysteresis);
            this.tabPage7.Controls.Add(this.sbsiHysLowOutput);
            this.tabPage7.Controls.Add(this.sbsiHysInitialOutputValue);
            this.tabPage7.Controls.Add(this.sbsiHysHighOutputValue);
            this.tabPage7.Controls.Add(this.sbsiHysHighLimit);
            this.tabPage7.Controls.Add(this.sbsiHysLowLimit);
            this.tabPage7.Location = new System.Drawing.Point(4, 24);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(373, 428);
            this.tabPage7.TabIndex = 1;
            this.tabPage7.Text = "Hysteresis";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // bGenHysteresisCode
            // 
            this.bGenHysteresisCode.BackColor = System.Drawing.Color.MediumPurple;
            this.bGenHysteresisCode.Location = new System.Drawing.Point(189, 317);
            this.bGenHysteresisCode.Name = "bGenHysteresisCode";
            this.bGenHysteresisCode.Size = new System.Drawing.Size(106, 47);
            this.bGenHysteresisCode.TabIndex = 40;
            this.bGenHysteresisCode.Text = "Gen Hysteresis Code";
            this.bGenHysteresisCode.UseVisualStyleBackColor = false;
            this.bGenHysteresisCode.Click += new System.EventHandler(this.bGenHysteresisCode_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(17, 371);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox3.Size = new System.Drawing.Size(344, 57);
            this.textBox3.TabIndex = 39;
            this.textBox3.Text = resources.GetString("textBox3.Text");
            // 
            // bConfigureHysteresis
            // 
            this.bConfigureHysteresis.Location = new System.Drawing.Point(17, 317);
            this.bConfigureHysteresis.Name = "bConfigureHysteresis";
            this.bConfigureHysteresis.Size = new System.Drawing.Size(144, 23);
            this.bConfigureHysteresis.TabIndex = 38;
            this.bConfigureHysteresis.Text = "Configure Hysteresis";
            this.bConfigureHysteresis.UseVisualStyleBackColor = true;
            this.bConfigureHysteresis.Click += new System.EventHandler(this.bConfigureHysteresis_Click_1);
            // 
            // sbsiHysLowOutput
            // 
            this.sbsiHysLowOutput.Location = new System.Drawing.Point(11, 63);
            this.sbsiHysLowOutput.Maximum = 65535;
            this.sbsiHysLowOutput.Minimum = 0;
            this.sbsiHysLowOutput.Name = "sbsiHysLowOutput";
            this.sbsiHysLowOutput.Size = new System.Drawing.Size(328, 60);
            this.sbsiHysLowOutput.TabIndex = 37;
            this.sbsiHysLowOutput.Text = "lowOutputValue";
            this.sbsiHysLowOutput.TextBoxHint = "if the input source is at or below lowLimit then this value becomes the output";
            this.toolTip1.SetToolTip(this.sbsiHysLowOutput, "if the input source is at or below lowLimit then this value becomes the output");
            this.sbsiHysLowOutput.value = ((ushort)(0));
            // 
            // sbsiHysInitialOutputValue
            // 
            this.sbsiHysInitialOutputValue.Location = new System.Drawing.Point(11, 248);
            this.sbsiHysInitialOutputValue.Maximum = 65535;
            this.sbsiHysInitialOutputValue.Minimum = 0;
            this.sbsiHysInitialOutputValue.Name = "sbsiHysInitialOutputValue";
            this.sbsiHysInitialOutputValue.Size = new System.Drawing.Size(328, 63);
            this.sbsiHysInitialOutputValue.TabIndex = 33;
            this.sbsiHysInitialOutputValue.Text = "initialOutputValue";
            this.sbsiHysInitialOutputValue.TextBoxHint = "if the input source is between lowLimit and highLimit at initialization then this" +
    " value is output";
            this.sbsiHysInitialOutputValue.value = ((ushort)(0));
            // 
            // sbsiHysHighOutputValue
            // 
            this.sbsiHysHighOutputValue.Location = new System.Drawing.Point(14, 191);
            this.sbsiHysHighOutputValue.Maximum = 65535;
            this.sbsiHysHighOutputValue.Minimum = 0;
            this.sbsiHysHighOutputValue.Name = "sbsiHysHighOutputValue";
            this.sbsiHysHighOutputValue.Size = new System.Drawing.Size(328, 62);
            this.sbsiHysHighOutputValue.TabIndex = 34;
            this.sbsiHysHighOutputValue.Text = "highOutputValue";
            this.sbsiHysHighOutputValue.TextBoxHint = "if the input source is at or above highLimit then this value becomes the output";
            this.sbsiHysHighOutputValue.value = ((ushort)(0));
            // 
            // sbsiHysHighLimit
            // 
            this.sbsiHysHighLimit.Location = new System.Drawing.Point(14, 129);
            this.sbsiHysHighLimit.Maximum = 65535;
            this.sbsiHysHighLimit.Minimum = 0;
            this.sbsiHysHighLimit.Name = "sbsiHysHighLimit";
            this.sbsiHysHighLimit.Size = new System.Drawing.Size(328, 53);
            this.sbsiHysHighLimit.TabIndex = 35;
            this.sbsiHysHighLimit.Text = "highLimit";
            this.sbsiHysHighLimit.TextBoxHint = "if the input source is at or above this level then the output value is highOutput" +
    "Value";
            this.sbsiHysHighLimit.value = ((ushort)(0));
            // 
            // sbsiHysLowLimit
            // 
            this.sbsiHysLowLimit.Location = new System.Drawing.Point(14, 6);
            this.sbsiHysLowLimit.Maximum = 65535;
            this.sbsiHysLowLimit.Minimum = 0;
            this.sbsiHysLowLimit.Name = "sbsiHysLowLimit";
            this.sbsiHysLowLimit.Size = new System.Drawing.Size(328, 64);
            this.sbsiHysLowLimit.TabIndex = 36;
            this.sbsiHysLowLimit.Text = "lowLimit";
            this.sbsiHysLowLimit.TextBoxHint = "If the input source is at or below this level the output value is lowOutputValue";
            this.sbsiHysLowLimit.value = ((ushort)(0));
            // 
            // tpPID1
            // 
            this.tpPID1.Controls.Add(this.pidControl1);
            this.tpPID1.Location = new System.Drawing.Point(4, 24);
            this.tpPID1.Name = "tpPID1";
            this.tpPID1.Padding = new System.Windows.Forms.Padding(3);
            this.tpPID1.Size = new System.Drawing.Size(373, 428);
            this.tpPID1.TabIndex = 2;
            this.tpPID1.Text = "PID";
            this.tpPID1.UseVisualStyleBackColor = true;
            // 
            // pidControl1
            // 
            this.pidControl1.AutoSize = true;
            this.pidControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pidControl1.Location = new System.Drawing.Point(6, 6);
            this.pidControl1.Name = "pidControl1";
            this.pidControl1.Size = new System.Drawing.Size(367, 402);
            this.pidControl1.TabIndex = 0;
            // 
            // tpTimeout
            // 
            this.tpTimeout.Controls.Add(this.bGenTimeoutCode);
            this.tpTimeout.Controls.Add(this.textBox4);
            this.tpTimeout.Controls.Add(this.bConfigureTimeout);
            this.tpTimeout.Controls.Add(this.sbsiTimeoutOutputValue);
            this.tpTimeout.Controls.Add(this.sbsiTimeout_mS);
            this.tpTimeout.Location = new System.Drawing.Point(4, 24);
            this.tpTimeout.Name = "tpTimeout";
            this.tpTimeout.Padding = new System.Windows.Forms.Padding(3);
            this.tpTimeout.Size = new System.Drawing.Size(393, 468);
            this.tpTimeout.TabIndex = 3;
            this.tpTimeout.Text = "Timeout";
            this.tpTimeout.UseVisualStyleBackColor = true;
            // 
            // bGenTimeoutCode
            // 
            this.bGenTimeoutCode.BackColor = System.Drawing.Color.MediumPurple;
            this.bGenTimeoutCode.Location = new System.Drawing.Point(255, 187);
            this.bGenTimeoutCode.Name = "bGenTimeoutCode";
            this.bGenTimeoutCode.Size = new System.Drawing.Size(106, 47);
            this.bGenTimeoutCode.TabIndex = 33;
            this.bGenTimeoutCode.Text = "Gen Timeout Code";
            this.bGenTimeoutCode.UseVisualStyleBackColor = false;
            this.bGenTimeoutCode.Click += new System.EventHandler(this.bGenTimeoutCode_Click);
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
            this.tpFiltering.Controls.Add(this.tabControl2);
            this.tpFiltering.Controls.Add(this.edFilteringPeriod);
            this.tpFiltering.Location = new System.Drawing.Point(4, 24);
            this.tpFiltering.Name = "tpFiltering";
            this.tpFiltering.Padding = new System.Windows.Forms.Padding(3);
            this.tpFiltering.Size = new System.Drawing.Size(393, 468);
            this.tpFiltering.TabIndex = 4;
            this.tpFiltering.Text = "Filtering";
            this.tpFiltering.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage2);
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Location = new System.Drawing.Point(6, 6);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(381, 405);
            this.tabControl2.TabIndex = 24;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.bGenFilterCode);
            this.tabPage2.Controls.Add(this.sbsiFilterConstant);
            this.tabPage2.Controls.Add(this.bConfigureFiltering);
            this.tabPage2.Controls.Add(this.textBox5);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(373, 377);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "Filtering";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // bGenFilterCode
            // 
            this.bGenFilterCode.BackColor = System.Drawing.Color.MediumPurple;
            this.bGenFilterCode.Location = new System.Drawing.Point(227, 88);
            this.bGenFilterCode.Name = "bGenFilterCode";
            this.bGenFilterCode.Size = new System.Drawing.Size(90, 47);
            this.bGenFilterCode.TabIndex = 30;
            this.bGenFilterCode.Text = "Gen Filter Code";
            this.bGenFilterCode.UseVisualStyleBackColor = false;
            this.bGenFilterCode.Click += new System.EventHandler(this.bGenFilterCode_Click);
            // 
            // sbsiFilterConstant
            // 
            this.sbsiFilterConstant.Location = new System.Drawing.Point(6, 6);
            this.sbsiFilterConstant.Maximum = 65535;
            this.sbsiFilterConstant.Minimum = 0;
            this.sbsiFilterConstant.Name = "sbsiFilterConstant";
            this.sbsiFilterConstant.Size = new System.Drawing.Size(328, 76);
            this.sbsiFilterConstant.TabIndex = 0;
            this.sbsiFilterConstant.Text = "filterConstant";
            this.sbsiFilterConstant.TextBoxHint = "";
            this.sbsiFilterConstant.value = ((ushort)(0));
            // 
            // bConfigureFiltering
            // 
            this.bConfigureFiltering.Location = new System.Drawing.Point(6, 88);
            this.bConfigureFiltering.Name = "bConfigureFiltering";
            this.bConfigureFiltering.Size = new System.Drawing.Size(156, 23);
            this.bConfigureFiltering.TabIndex = 2;
            this.bConfigureFiltering.Text = "Configure 1st order Filtering";
            this.bConfigureFiltering.UseVisualStyleBackColor = true;
            this.bConfigureFiltering.Click += new System.EventHandler(this.bConfigureFiltering_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(6, 182);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox5.Size = new System.Drawing.Size(344, 189);
            this.textBox5.TabIndex = 20;
            this.textBox5.Text = resources.GetString("textBox5.Text");
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.bGenRateLimit);
            this.tabPage3.Controls.Add(this.sbsiMaxChangeUp);
            this.tabPage3.Controls.Add(this.sbsiFilterConstant2);
            this.tabPage3.Controls.Add(this.bConfigureMaximumRate);
            this.tabPage3.Controls.Add(this.textBox6);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(373, 377);
            this.tabPage3.TabIndex = 1;
            this.tabPage3.Text = "Rate Limit";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // bGenRateLimit
            // 
            this.bGenRateLimit.BackColor = System.Drawing.Color.MediumPurple;
            this.bGenRateLimit.Location = new System.Drawing.Point(227, 163);
            this.bGenRateLimit.Name = "bGenRateLimit";
            this.bGenRateLimit.Size = new System.Drawing.Size(90, 47);
            this.bGenRateLimit.TabIndex = 31;
            this.bGenRateLimit.Text = "Gen Rate Limit Code";
            this.bGenRateLimit.UseVisualStyleBackColor = false;
            this.bGenRateLimit.Click += new System.EventHandler(this.bGenRateLimit_Click);
            // 
            // sbsiMaxChangeUp
            // 
            this.sbsiMaxChangeUp.Location = new System.Drawing.Point(16, 3);
            this.sbsiMaxChangeUp.Maximum = 65535;
            this.sbsiMaxChangeUp.Minimum = 0;
            this.sbsiMaxChangeUp.Name = "sbsiMaxChangeUp";
            this.sbsiMaxChangeUp.Size = new System.Drawing.Size(328, 76);
            this.sbsiMaxChangeUp.TabIndex = 22;
            this.sbsiMaxChangeUp.Text = "maximumChangeCountsUp";
            this.sbsiMaxChangeUp.TextBoxHint = "";
            this.sbsiMaxChangeUp.value = ((ushort)(100));
            // 
            // sbsiFilterConstant2
            // 
            this.sbsiFilterConstant2.Location = new System.Drawing.Point(16, 81);
            this.sbsiFilterConstant2.Maximum = 65535;
            this.sbsiFilterConstant2.Minimum = 0;
            this.sbsiFilterConstant2.Name = "sbsiFilterConstant2";
            this.sbsiFilterConstant2.Size = new System.Drawing.Size(328, 76);
            this.sbsiFilterConstant2.TabIndex = 0;
            this.sbsiFilterConstant2.Text = "maximumChangeCountsDown";
            this.sbsiFilterConstant2.TextBoxHint = "";
            this.sbsiFilterConstant2.value = ((ushort)(100));
            // 
            // bConfigureMaximumRate
            // 
            this.bConfigureMaximumRate.Location = new System.Drawing.Point(16, 163);
            this.bConfigureMaximumRate.Name = "bConfigureMaximumRate";
            this.bConfigureMaximumRate.Size = new System.Drawing.Size(156, 23);
            this.bConfigureMaximumRate.TabIndex = 4;
            this.bConfigureMaximumRate.Text = "Configure Rate Limit";
            this.bConfigureMaximumRate.UseVisualStyleBackColor = true;
            this.bConfigureMaximumRate.Click += new System.EventHandler(this.bConfigureMaximumRate_Click);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(16, 263);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox6.Size = new System.Drawing.Size(344, 108);
            this.textBox6.TabIndex = 21;
            this.textBox6.Text = resources.GetString("textBox6.Text");
            // 
            // edFilteringPeriod
            // 
            this.edFilteringPeriod.DropDownToolTip = "";
            this.edFilteringPeriod.dropdowntype = "SerialWombat.ScaledOutputPeriod";
            this.edFilteringPeriod.Location = new System.Drawing.Point(53, 417);
            this.edFilteringPeriod.Name = "edFilteringPeriod";
            this.edFilteringPeriod.Size = new System.Drawing.Size(274, 35);
            this.edFilteringPeriod.TabIndex = 1;
            this.edFilteringPeriod.Value = 0;
            // 
            // tpOutputScaling
            // 
            this.tpOutputScaling.Controls.Add(this.tabControl3);
            this.tpOutputScaling.Location = new System.Drawing.Point(4, 24);
            this.tpOutputScaling.Name = "tpOutputScaling";
            this.tpOutputScaling.Padding = new System.Windows.Forms.Padding(3);
            this.tpOutputScaling.Size = new System.Drawing.Size(393, 468);
            this.tpOutputScaling.TabIndex = 5;
            this.tpOutputScaling.Text = "Output Scaling";
            this.tpOutputScaling.UseVisualStyleBackColor = true;
            // 
            // tabControl3
            // 
            this.tabControl3.Controls.Add(this.MinMax);
            this.tabControl3.Controls.Add(this.tabPage5);
            this.tabControl3.Location = new System.Drawing.Point(6, 6);
            this.tabControl3.Name = "tabControl3";
            this.tabControl3.SelectedIndex = 0;
            this.tabControl3.Size = new System.Drawing.Size(381, 456);
            this.tabControl3.TabIndex = 33;
            // 
            // MinMax
            // 
            this.MinMax.Controls.Add(this.sbsiOutputScalingMin);
            this.MinMax.Controls.Add(this.bGenOutputScalingcode);
            this.MinMax.Controls.Add(this.sbsiOutputScalingMax);
            this.MinMax.Controls.Add(this.bConfigureOutputScaling);
            this.MinMax.Location = new System.Drawing.Point(4, 24);
            this.MinMax.Name = "MinMax";
            this.MinMax.Padding = new System.Windows.Forms.Padding(3);
            this.MinMax.Size = new System.Drawing.Size(373, 428);
            this.MinMax.TabIndex = 0;
            this.MinMax.Text = "MinMax";
            this.MinMax.UseVisualStyleBackColor = true;
            // 
            // sbsiOutputScalingMin
            // 
            this.sbsiOutputScalingMin.Location = new System.Drawing.Point(6, 6);
            this.sbsiOutputScalingMin.Maximum = 65535;
            this.sbsiOutputScalingMin.Minimum = 0;
            this.sbsiOutputScalingMin.Name = "sbsiOutputScalingMin";
            this.sbsiOutputScalingMin.Size = new System.Drawing.Size(328, 76);
            this.sbsiOutputScalingMin.TabIndex = 14;
            this.sbsiOutputScalingMin.Text = "outputMin";
            this.sbsiOutputScalingMin.TextBoxHint = "";
            this.sbsiOutputScalingMin.value = ((ushort)(0));
            // 
            // bGenOutputScalingcode
            // 
            this.bGenOutputScalingcode.BackColor = System.Drawing.Color.MediumPurple;
            this.bGenOutputScalingcode.Location = new System.Drawing.Point(274, 166);
            this.bGenOutputScalingcode.Name = "bGenOutputScalingcode";
            this.bGenOutputScalingcode.Size = new System.Drawing.Size(90, 47);
            this.bGenOutputScalingcode.TabIndex = 32;
            this.bGenOutputScalingcode.Text = "Gen Output Scaling Code";
            this.bGenOutputScalingcode.UseVisualStyleBackColor = false;
            this.bGenOutputScalingcode.Click += new System.EventHandler(this.bGenOutputScalingcode_Click);
            // 
            // sbsiOutputScalingMax
            // 
            this.sbsiOutputScalingMax.Location = new System.Drawing.Point(9, 75);
            this.sbsiOutputScalingMax.Maximum = 65535;
            this.sbsiOutputScalingMax.Minimum = 0;
            this.sbsiOutputScalingMax.Name = "sbsiOutputScalingMax";
            this.sbsiOutputScalingMax.Size = new System.Drawing.Size(328, 76);
            this.sbsiOutputScalingMax.TabIndex = 15;
            this.sbsiOutputScalingMax.Text = "outputMax";
            this.sbsiOutputScalingMax.TextBoxHint = "";
            this.sbsiOutputScalingMax.value = ((ushort)(65535));
            // 
            // bConfigureOutputScaling
            // 
            this.bConfigureOutputScaling.Location = new System.Drawing.Point(77, 166);
            this.bConfigureOutputScaling.Name = "bConfigureOutputScaling";
            this.bConfigureOutputScaling.Size = new System.Drawing.Size(167, 23);
            this.bConfigureOutputScaling.TabIndex = 16;
            this.bConfigureOutputScaling.Text = "Configure Output Scaling";
            this.bConfigureOutputScaling.UseVisualStyleBackColor = true;
            this.bConfigureOutputScaling.Click += new System.EventHandler(this.bConfigureOutputScaling_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.label1);
            this.tabPage5.Controls.Add(this.sbac2DIndex);
            this.tabPage5.Controls.Add(this.button1);
            this.tabPage5.Controls.Add(this.b2DConfigure);
            this.tabPage5.Controls.Add(this.gb2DData);
            this.tabPage5.Controls.Add(this.formsPlot1);
            this.tabPage5.Location = new System.Drawing.Point(4, 24);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(373, 428);
            this.tabPage5.TabIndex = 1;
            this.tabPage5.Text = "2DLookup";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 33;
            this.label1.Text = "Index:";
            // 
            // sbac2DIndex
            // 
            this.sbac2DIndex.AutoSize = true;
            this.sbac2DIndex.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.sbac2DIndex.Location = new System.Drawing.Point(84, 18);
            this.sbac2DIndex.Name = "sbac2DIndex";
            this.sbac2DIndex.Size = new System.Drawing.Size(56, 26);
            this.sbac2DIndex.TabIndex = 32;
            this.toolTip1.SetToolTip(this.sbac2DIndex, "The location in User Memory to place the table of lookup data (4 bytes per point)" +
        "");
            this.sbac2DIndex.Value = ((ushort)(0));
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumPurple;
            this.button1.Location = new System.Drawing.Point(307, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 47);
            this.button1.TabIndex = 31;
            this.button1.Text = "Gen Code";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // b2DConfigure
            // 
            this.b2DConfigure.Location = new System.Drawing.Point(226, 18);
            this.b2DConfigure.Name = "b2DConfigure";
            this.b2DConfigure.Size = new System.Drawing.Size(75, 23);
            this.b2DConfigure.TabIndex = 2;
            this.b2DConfigure.Text = "Configure";
            this.b2DConfigure.UseVisualStyleBackColor = true;
            this.b2DConfigure.Click += new System.EventHandler(this.b2DConfigure_Click);
            // 
            // gb2DData
            // 
            this.gb2DData.Controls.Add(this.l2DWarning);
            this.gb2DData.Controls.Add(this.pXY);
            this.gb2DData.Location = new System.Drawing.Point(7, 56);
            this.gb2DData.Name = "gb2DData";
            this.gb2DData.Size = new System.Drawing.Size(363, 182);
            this.gb2DData.TabIndex = 1;
            this.gb2DData.TabStop = false;
            this.gb2DData.Text = "Data (Last X == 65535)";
            // 
            // l2DWarning
            // 
            this.l2DWarning.AutoSize = true;
            this.l2DWarning.ForeColor = System.Drawing.Color.Red;
            this.l2DWarning.Location = new System.Drawing.Point(16, 97);
            this.l2DWarning.Name = "l2DWarning";
            this.l2DWarning.Size = new System.Drawing.Size(0, 15);
            this.l2DWarning.TabIndex = 1;
            // 
            // pXY
            // 
            this.pXY.AutoScroll = true;
            this.pXY.Location = new System.Drawing.Point(6, 12);
            this.pXY.Name = "pXY";
            this.pXY.Size = new System.Drawing.Size(353, 164);
            this.pXY.TabIndex = 0;
            // 
            // formsPlot1
            // 
            this.formsPlot1.Location = new System.Drawing.Point(7, 244);
            this.formsPlot1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.formsPlot1.Name = "formsPlot1";
            this.formsPlot1.Size = new System.Drawing.Size(359, 178);
            this.formsPlot1.TabIndex = 0;
            // 
            // swpdsInput
            // 
            this.swpdsInput.DataSourceValue = ((byte)(0));
            this.swpdsInput.DropDownToolTip = "The pin or public data id that should be read to drive the output value.  Only us" +
    "ed when enabled is set to true";
            this.swpdsInput.Location = new System.Drawing.Point(70, 505);
            this.swpdsInput.Name = "swpdsInput";
            this.swpdsInput.Size = new System.Drawing.Size(231, 35);
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
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.MediumPurple;
            this.button4.Location = new System.Drawing.Point(307, 501);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(90, 47);
            this.button4.TabIndex = 30;
            this.button4.Text = "Gen Enable  Code";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // ScaledOutputControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.button4);
            this.Controls.Add(this.ckbScaledOutputEnable);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.swpdsInput);
            this.Name = "ScaledOutputControl";
            this.Size = new System.Drawing.Size(407, 551);
            this.Load += new System.EventHandler(this.ScaledOutputControl_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tpPID.ResumeLayout(false);
            this.tabControl4.ResumeLayout(false);
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            this.tpPID1.ResumeLayout(false);
            this.tpPID1.PerformLayout();
            this.tpTimeout.ResumeLayout(false);
            this.tpTimeout.PerformLayout();
            this.tpFiltering.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tpOutputScaling.ResumeLayout(false);
            this.tabControl3.ResumeLayout(false);
            this.MinMax.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.gb2DData.ResumeLayout(false);
            this.gb2DData.PerformLayout();
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
        private System.Windows.Forms.Button bConfigureMaximumRate;
        private System.Windows.Forms.Button bConfigureFiltering;
        private System.Windows.Forms.TabPage tpOutputScaling;
        private System.Windows.Forms.Button bConfigureOutputScaling;
        private SixteenBitSliderInput sbsiOutputScalingMax;
        private SixteenBitSliderInput sbsiOutputScalingMin;
        private System.Windows.Forms.CheckBox ckbScaledOutputEnable;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private SixteenBitSliderInput sbsiFilterConstant2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button bGenInputScalingCode;
        private System.Windows.Forms.Button bGenTimeoutCode;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private SixteenBitSliderInput sbsiMaxChangeUp;
        private System.Windows.Forms.TabControl tabControl4;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.Button bGenHysteresisCode;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button bConfigureHysteresis;
        private SixteenBitSliderInput sbsiHysLowOutput;
        private SixteenBitSliderInput sbsiHysInitialOutputValue;
        private SixteenBitSliderInput sbsiHysHighOutputValue;
        private SixteenBitSliderInput sbsiHysHighLimit;
        private SixteenBitSliderInput sbsiHysLowLimit;
        private System.Windows.Forms.Button bGenFilterCode;
        private System.Windows.Forms.Button bGenRateLimit;
        private System.Windows.Forms.Button bGenOutputScalingcode;
        private System.Windows.Forms.TabControl tabControl3;
        private System.Windows.Forms.TabPage MinMax;
        private System.Windows.Forms.TabPage tabPage5;
        private ScottPlot.FormsPlot formsPlot1;
        private System.Windows.Forms.GroupBox gb2DData;
        private System.Windows.Forms.Panel pXY;
        private System.Windows.Forms.Label l2DWarning;
        private System.Windows.Forms.Label label1;
        private SixteenBitAddressControl sbac2DIndex;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button b2DConfigure;
        private System.Windows.Forms.TabPage tpPID1;
        private PIDControl pidControl1;
    }
}
