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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScaledOutputControl));
            tabControl1 = new System.Windows.Forms.TabControl();
            tabPage1 = new System.Windows.Forms.TabPage();
            bGenInputScalingCode = new System.Windows.Forms.Button();
            textBox1 = new System.Windows.Forms.TextBox();
            sbsiInputMax = new SixteenBitSliderInput();
            sbsiInputMin = new SixteenBitSliderInput();
            bConfigureInputScaling = new System.Windows.Forms.Button();
            ckbInvert = new System.Windows.Forms.CheckBox();
            tpPID = new System.Windows.Forms.TabPage();
            tabControl4 = new System.Windows.Forms.TabControl();
            tabPage7 = new System.Windows.Forms.TabPage();
            bGenHysteresisCode = new System.Windows.Forms.Button();
            textBox3 = new System.Windows.Forms.TextBox();
            bConfigureHysteresis = new System.Windows.Forms.Button();
            sbsiHysLowOutput = new SixteenBitSliderInput();
            sbsiHysInitialOutputValue = new SixteenBitSliderInput();
            sbsiHysHighOutputValue = new SixteenBitSliderInput();
            sbsiHysHighLimit = new SixteenBitSliderInput();
            sbsiHysLowLimit = new SixteenBitSliderInput();
            tpPID1 = new System.Windows.Forms.TabPage();
            pidControl1 = new PIDControl();
            tpRamp = new System.Windows.Forms.TabPage();
            rampOutputScaleControl1 = new RampOutputScaleControl();
            tpTimeout = new System.Windows.Forms.TabPage();
            bGenTimeoutCode = new System.Windows.Forms.Button();
            textBox4 = new System.Windows.Forms.TextBox();
            bConfigureTimeout = new System.Windows.Forms.Button();
            sbsiTimeoutOutputValue = new SixteenBitSliderInput();
            sbsiTimeout_mS = new SixteenBitSliderInput();
            tpFiltering = new System.Windows.Forms.TabPage();
            tabControl2 = new System.Windows.Forms.TabControl();
            tabPage2 = new System.Windows.Forms.TabPage();
            bGenFilterCode = new System.Windows.Forms.Button();
            sbsiFilterConstant = new SixteenBitSliderInput();
            bConfigureFiltering = new System.Windows.Forms.Button();
            textBox5 = new System.Windows.Forms.TextBox();
            tabPage3 = new System.Windows.Forms.TabPage();
            bGenRateLimit = new System.Windows.Forms.Button();
            sbsiMaxChangeUp = new SixteenBitSliderInput();
            sbsiFilterConstant2 = new SixteenBitSliderInput();
            bConfigureMaximumRate = new System.Windows.Forms.Button();
            textBox6 = new System.Windows.Forms.TextBox();
            edFilteringPeriod = new EnumDropdown();
            tpOutputScaling = new System.Windows.Forms.TabPage();
            tabControl3 = new System.Windows.Forms.TabControl();
            MinMax = new System.Windows.Forms.TabPage();
            sbsiOutputScalingMin = new SixteenBitSliderInput();
            bGenOutputScalingcode = new System.Windows.Forms.Button();
            sbsiOutputScalingMax = new SixteenBitSliderInput();
            bConfigureOutputScaling = new System.Windows.Forms.Button();
            tabPage5 = new System.Windows.Forms.TabPage();
            label1 = new System.Windows.Forms.Label();
            sbac2DIndex = new SixteenBitAddressControl();
            button1 = new System.Windows.Forms.Button();
            b2DConfigure = new System.Windows.Forms.Button();
            gb2DData = new System.Windows.Forms.GroupBox();
            l2DWarning = new System.Windows.Forms.Label();
            pXY = new System.Windows.Forms.Panel();
            formsPlot1 = new ScottPlot.FormsPlot();
            swpdsInput = new SerialWombatPublicDataControl();
            toolTip1 = new System.Windows.Forms.ToolTip(components);
            ckbScaledOutputEnable = new System.Windows.Forms.CheckBox();
            button4 = new System.Windows.Forms.Button();
            tabPage4 = new System.Windows.Forms.TabPage();
            swpdTargetValuePin = new SerialWombatPinDropdown();
            label2 = new System.Windows.Forms.Label();
            bSetCATVP = new System.Windows.Forms.Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tpPID.SuspendLayout();
            tabControl4.SuspendLayout();
            tabPage7.SuspendLayout();
            tpPID1.SuspendLayout();
            tpRamp.SuspendLayout();
            tpTimeout.SuspendLayout();
            tpFiltering.SuspendLayout();
            tabControl2.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            tpOutputScaling.SuspendLayout();
            tabControl3.SuspendLayout();
            MinMax.SuspendLayout();
            tabPage5.SuspendLayout();
            gb2DData.SuspendLayout();
            tabPage4.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tpPID);
            tabControl1.Controls.Add(tpTimeout);
            tabControl1.Controls.Add(tpFiltering);
            tabControl1.Controls.Add(tpOutputScaling);
            tabControl1.Location = new System.Drawing.Point(3, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(401, 496);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(bGenInputScalingCode);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Controls.Add(sbsiInputMax);
            tabPage1.Controls.Add(sbsiInputMin);
            tabPage1.Controls.Add(bConfigureInputScaling);
            tabPage1.Controls.Add(ckbInvert);
            tabPage1.Location = new System.Drawing.Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new System.Windows.Forms.Padding(3);
            tabPage1.Size = new System.Drawing.Size(393, 468);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Input Scaling";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // bGenInputScalingCode
            // 
            bGenInputScalingCode.BackColor = System.Drawing.Color.MediumPurple;
            bGenInputScalingCode.Location = new System.Drawing.Point(283, 193);
            bGenInputScalingCode.Name = "bGenInputScalingCode";
            bGenInputScalingCode.Size = new System.Drawing.Size(91, 47);
            bGenInputScalingCode.TabIndex = 30;
            bGenInputScalingCode.Text = "Gen Input Scaling Code";
            bGenInputScalingCode.UseVisualStyleBackColor = false;
            bGenInputScalingCode.Click += bGenInputScalingCode_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(6, 265);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            textBox1.Size = new System.Drawing.Size(344, 160);
            textBox1.TabIndex = 14;
            textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // sbsiInputMax
            // 
            sbsiInputMax.Location = new System.Drawing.Point(25, 75);
            sbsiInputMax.Maximum = 65535;
            sbsiInputMax.Minimum = 0;
            sbsiInputMax.Name = "sbsiInputMax";
            sbsiInputMax.Size = new System.Drawing.Size(328, 76);
            sbsiInputMax.TabIndex = 13;
            sbsiInputMax.Text = "inputMax";
            sbsiInputMax.TextBoxHint = "The maximum value of the input range.  Input values greater or equal to that will be scaled to 65535";
            sbsiInputMax.value = ushort.MaxValue;
            // 
            // sbsiInputMin
            // 
            sbsiInputMin.Location = new System.Drawing.Point(22, 6);
            sbsiInputMin.Maximum = 65535;
            sbsiInputMin.Minimum = 0;
            sbsiInputMin.Name = "sbsiInputMin";
            sbsiInputMin.Size = new System.Drawing.Size(328, 76);
            sbsiInputMin.TabIndex = 12;
            sbsiInputMin.Text = "inputMin";
            sbsiInputMin.TextBoxHint = "The minimum value of the input range.  Input values less than or equal to that will be scaled to 0";
            sbsiInputMin.value = (ushort)0;
            // 
            // bConfigureInputScaling
            // 
            bConfigureInputScaling.Location = new System.Drawing.Point(77, 205);
            bConfigureInputScaling.Name = "bConfigureInputScaling";
            bConfigureInputScaling.Size = new System.Drawing.Size(167, 23);
            bConfigureInputScaling.TabIndex = 5;
            bConfigureInputScaling.Text = "Configure Input Scaling";
            bConfigureInputScaling.UseVisualStyleBackColor = true;
            bConfigureInputScaling.Click += bConfigureInputScaling_Click;
            // 
            // ckbInvert
            // 
            ckbInvert.AutoSize = true;
            ckbInvert.Location = new System.Drawing.Point(119, 157);
            ckbInvert.Name = "ckbInvert";
            ckbInvert.Size = new System.Drawing.Size(87, 19);
            ckbInvert.TabIndex = 4;
            ckbInvert.Text = "Invert Input";
            toolTip1.SetToolTip(ckbInvert, "inverted False - input value isn't changed.  True- input value is subtracted from 65535");
            ckbInvert.UseVisualStyleBackColor = true;
            ckbInvert.CheckedChanged += ckbInvert_CheckedChanged;
            // 
            // tpPID
            // 
            tpPID.Controls.Add(tabControl4);
            tpPID.Location = new System.Drawing.Point(4, 24);
            tpPID.Name = "tpPID";
            tpPID.Padding = new System.Windows.Forms.Padding(3);
            tpPID.Size = new System.Drawing.Size(393, 468);
            tpPID.TabIndex = 1;
            tpPID.Text = "Feedback Control";
            tpPID.UseVisualStyleBackColor = true;
            // 
            // tabControl4
            // 
            tabControl4.Controls.Add(tabPage7);
            tabControl4.Controls.Add(tpPID1);
            tabControl4.Controls.Add(tpRamp);
            tabControl4.Controls.Add(tabPage4);
            tabControl4.Location = new System.Drawing.Point(6, 6);
            tabControl4.Name = "tabControl4";
            tabControl4.SelectedIndex = 0;
            tabControl4.Size = new System.Drawing.Size(381, 418);
            tabControl4.TabIndex = 33;
            // 
            // tabPage7
            // 
            tabPage7.AutoScroll = true;
            tabPage7.Controls.Add(bGenHysteresisCode);
            tabPage7.Controls.Add(textBox3);
            tabPage7.Controls.Add(bConfigureHysteresis);
            tabPage7.Controls.Add(sbsiHysLowOutput);
            tabPage7.Controls.Add(sbsiHysInitialOutputValue);
            tabPage7.Controls.Add(sbsiHysHighOutputValue);
            tabPage7.Controls.Add(sbsiHysHighLimit);
            tabPage7.Controls.Add(sbsiHysLowLimit);
            tabPage7.Location = new System.Drawing.Point(4, 24);
            tabPage7.Name = "tabPage7";
            tabPage7.Padding = new System.Windows.Forms.Padding(3);
            tabPage7.Size = new System.Drawing.Size(373, 390);
            tabPage7.TabIndex = 1;
            tabPage7.Text = "Hysteresis";
            tabPage7.UseVisualStyleBackColor = true;
            // 
            // bGenHysteresisCode
            // 
            bGenHysteresisCode.BackColor = System.Drawing.Color.MediumPurple;
            bGenHysteresisCode.Location = new System.Drawing.Point(189, 317);
            bGenHysteresisCode.Name = "bGenHysteresisCode";
            bGenHysteresisCode.Size = new System.Drawing.Size(106, 47);
            bGenHysteresisCode.TabIndex = 40;
            bGenHysteresisCode.Text = "Gen Hysteresis Code";
            bGenHysteresisCode.UseVisualStyleBackColor = false;
            bGenHysteresisCode.Click += bGenHysteresisCode_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new System.Drawing.Point(17, 371);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            textBox3.Size = new System.Drawing.Size(344, 57);
            textBox3.TabIndex = 39;
            textBox3.Text = resources.GetString("textBox3.Text");
            // 
            // bConfigureHysteresis
            // 
            bConfigureHysteresis.Location = new System.Drawing.Point(17, 317);
            bConfigureHysteresis.Name = "bConfigureHysteresis";
            bConfigureHysteresis.Size = new System.Drawing.Size(144, 23);
            bConfigureHysteresis.TabIndex = 38;
            bConfigureHysteresis.Text = "Configure Hysteresis";
            bConfigureHysteresis.UseVisualStyleBackColor = true;
            bConfigureHysteresis.Click += bConfigureHysteresis_Click_1;
            // 
            // sbsiHysLowOutput
            // 
            sbsiHysLowOutput.Location = new System.Drawing.Point(11, 63);
            sbsiHysLowOutput.Maximum = 65535;
            sbsiHysLowOutput.Minimum = 0;
            sbsiHysLowOutput.Name = "sbsiHysLowOutput";
            sbsiHysLowOutput.Size = new System.Drawing.Size(328, 60);
            sbsiHysLowOutput.TabIndex = 37;
            sbsiHysLowOutput.Text = "lowOutputValue";
            sbsiHysLowOutput.TextBoxHint = "if the input source is at or below lowLimit then this value becomes the output";
            toolTip1.SetToolTip(sbsiHysLowOutput, "if the input source is at or below lowLimit then this value becomes the output");
            sbsiHysLowOutput.value = (ushort)0;
            // 
            // sbsiHysInitialOutputValue
            // 
            sbsiHysInitialOutputValue.Location = new System.Drawing.Point(11, 248);
            sbsiHysInitialOutputValue.Maximum = 65535;
            sbsiHysInitialOutputValue.Minimum = 0;
            sbsiHysInitialOutputValue.Name = "sbsiHysInitialOutputValue";
            sbsiHysInitialOutputValue.Size = new System.Drawing.Size(328, 63);
            sbsiHysInitialOutputValue.TabIndex = 33;
            sbsiHysInitialOutputValue.Text = "initialOutputValue";
            sbsiHysInitialOutputValue.TextBoxHint = "if the input source is between lowLimit and highLimit at initialization then this value is output";
            sbsiHysInitialOutputValue.value = (ushort)0;
            // 
            // sbsiHysHighOutputValue
            // 
            sbsiHysHighOutputValue.Location = new System.Drawing.Point(14, 191);
            sbsiHysHighOutputValue.Maximum = 65535;
            sbsiHysHighOutputValue.Minimum = 0;
            sbsiHysHighOutputValue.Name = "sbsiHysHighOutputValue";
            sbsiHysHighOutputValue.Size = new System.Drawing.Size(328, 62);
            sbsiHysHighOutputValue.TabIndex = 34;
            sbsiHysHighOutputValue.Text = "highOutputValue";
            sbsiHysHighOutputValue.TextBoxHint = "if the input source is at or above highLimit then this value becomes the output";
            sbsiHysHighOutputValue.value = (ushort)0;
            // 
            // sbsiHysHighLimit
            // 
            sbsiHysHighLimit.Location = new System.Drawing.Point(14, 129);
            sbsiHysHighLimit.Maximum = 65535;
            sbsiHysHighLimit.Minimum = 0;
            sbsiHysHighLimit.Name = "sbsiHysHighLimit";
            sbsiHysHighLimit.Size = new System.Drawing.Size(328, 53);
            sbsiHysHighLimit.TabIndex = 35;
            sbsiHysHighLimit.Text = "highLimit";
            sbsiHysHighLimit.TextBoxHint = "if the input source is at or above this level then the output value is highOutputValue";
            sbsiHysHighLimit.value = (ushort)0;
            // 
            // sbsiHysLowLimit
            // 
            sbsiHysLowLimit.Location = new System.Drawing.Point(14, 6);
            sbsiHysLowLimit.Maximum = 65535;
            sbsiHysLowLimit.Minimum = 0;
            sbsiHysLowLimit.Name = "sbsiHysLowLimit";
            sbsiHysLowLimit.Size = new System.Drawing.Size(328, 64);
            sbsiHysLowLimit.TabIndex = 36;
            sbsiHysLowLimit.Text = "lowLimit";
            sbsiHysLowLimit.TextBoxHint = "If the input source is at or below this level the output value is lowOutputValue";
            sbsiHysLowLimit.value = (ushort)0;
            // 
            // tpPID1
            // 
            tpPID1.AutoScroll = true;
            tpPID1.Controls.Add(pidControl1);
            tpPID1.Location = new System.Drawing.Point(4, 24);
            tpPID1.Name = "tpPID1";
            tpPID1.Padding = new System.Windows.Forms.Padding(3);
            tpPID1.Size = new System.Drawing.Size(373, 390);
            tpPID1.TabIndex = 2;
            tpPID1.Text = "PID";
            tpPID1.UseVisualStyleBackColor = true;
            // 
            // pidControl1
            // 
            pidControl1.AutoScroll = true;
            pidControl1.AutoSize = true;
            pidControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            pidControl1.Location = new System.Drawing.Point(6, 6);
            pidControl1.Name = "pidControl1";
            pidControl1.Size = new System.Drawing.Size(367, 402);
            pidControl1.TabIndex = 0;
            pidControl1.Load += pidControl1_Load;
            // 
            // tpRamp
            // 
            tpRamp.AutoScroll = true;
            tpRamp.Controls.Add(rampOutputScaleControl1);
            tpRamp.Location = new System.Drawing.Point(4, 24);
            tpRamp.Name = "tpRamp";
            tpRamp.Padding = new System.Windows.Forms.Padding(3);
            tpRamp.Size = new System.Drawing.Size(373, 390);
            tpRamp.TabIndex = 3;
            tpRamp.Text = "Ramp";
            tpRamp.UseVisualStyleBackColor = true;
            // 
            // rampOutputScaleControl1
            // 
            rampOutputScaleControl1.AutoSize = true;
            rampOutputScaleControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            rampOutputScaleControl1.Location = new System.Drawing.Point(6, 6);
            rampOutputScaleControl1.Name = "rampOutputScaleControl1";
            rampOutputScaleControl1.Size = new System.Drawing.Size(349, 379);
            rampOutputScaleControl1.TabIndex = 0;
            // 
            // tpTimeout
            // 
            tpTimeout.Controls.Add(bGenTimeoutCode);
            tpTimeout.Controls.Add(textBox4);
            tpTimeout.Controls.Add(bConfigureTimeout);
            tpTimeout.Controls.Add(sbsiTimeoutOutputValue);
            tpTimeout.Controls.Add(sbsiTimeout_mS);
            tpTimeout.Location = new System.Drawing.Point(4, 24);
            tpTimeout.Name = "tpTimeout";
            tpTimeout.Padding = new System.Windows.Forms.Padding(3);
            tpTimeout.Size = new System.Drawing.Size(393, 468);
            tpTimeout.TabIndex = 3;
            tpTimeout.Text = "Timeout";
            tpTimeout.UseVisualStyleBackColor = true;
            // 
            // bGenTimeoutCode
            // 
            bGenTimeoutCode.BackColor = System.Drawing.Color.MediumPurple;
            bGenTimeoutCode.Location = new System.Drawing.Point(255, 187);
            bGenTimeoutCode.Name = "bGenTimeoutCode";
            bGenTimeoutCode.Size = new System.Drawing.Size(106, 47);
            bGenTimeoutCode.TabIndex = 33;
            bGenTimeoutCode.Text = "Gen Timeout Code";
            bGenTimeoutCode.UseVisualStyleBackColor = false;
            bGenTimeoutCode.Click += bGenTimeoutCode_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new System.Drawing.Point(6, 250);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            textBox4.Size = new System.Drawing.Size(344, 217);
            textBox4.TabIndex = 20;
            textBox4.Text = resources.GetString("textBox4.Text");
            // 
            // bConfigureTimeout
            // 
            bConfigureTimeout.Location = new System.Drawing.Point(101, 192);
            bConfigureTimeout.Name = "bConfigureTimeout";
            bConfigureTimeout.Size = new System.Drawing.Size(128, 36);
            bConfigureTimeout.TabIndex = 2;
            bConfigureTimeout.Text = "Configure Timeout";
            bConfigureTimeout.UseVisualStyleBackColor = true;
            bConfigureTimeout.Click += bConfigureTimeout_Click;
            // 
            // sbsiTimeoutOutputValue
            // 
            sbsiTimeoutOutputValue.Location = new System.Drawing.Point(6, 98);
            sbsiTimeoutOutputValue.Maximum = 65535;
            sbsiTimeoutOutputValue.Minimum = 0;
            sbsiTimeoutOutputValue.Name = "sbsiTimeoutOutputValue";
            sbsiTimeoutOutputValue.Size = new System.Drawing.Size(328, 76);
            sbsiTimeoutOutputValue.TabIndex = 1;
            sbsiTimeoutOutputValue.Text = "timeoutOutputValue";
            sbsiTimeoutOutputValue.TextBoxHint = "The 16 bit value that should be output if a timeout occurs";
            sbsiTimeoutOutputValue.value = (ushort)0;
            // 
            // sbsiTimeout_mS
            // 
            sbsiTimeout_mS.Location = new System.Drawing.Point(6, 16);
            sbsiTimeout_mS.Maximum = 65535;
            sbsiTimeout_mS.Minimum = 0;
            sbsiTimeout_mS.Name = "sbsiTimeout_mS";
            sbsiTimeout_mS.Size = new System.Drawing.Size(328, 76);
            sbsiTimeout_mS.TabIndex = 0;
            sbsiTimeout_mS.Text = "timeout_mS";
            sbsiTimeout_mS.TextBoxHint = "How long in mS before the timeout occurs.  Set to zero to disable the timeout";
            sbsiTimeout_mS.value = (ushort)0;
            // 
            // tpFiltering
            // 
            tpFiltering.Controls.Add(tabControl2);
            tpFiltering.Controls.Add(edFilteringPeriod);
            tpFiltering.Location = new System.Drawing.Point(4, 24);
            tpFiltering.Name = "tpFiltering";
            tpFiltering.Padding = new System.Windows.Forms.Padding(3);
            tpFiltering.Size = new System.Drawing.Size(393, 468);
            tpFiltering.TabIndex = 4;
            tpFiltering.Text = "Filtering";
            tpFiltering.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            tabControl2.Controls.Add(tabPage2);
            tabControl2.Controls.Add(tabPage3);
            tabControl2.Location = new System.Drawing.Point(6, 6);
            tabControl2.Name = "tabControl2";
            tabControl2.SelectedIndex = 0;
            tabControl2.Size = new System.Drawing.Size(381, 405);
            tabControl2.TabIndex = 24;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(bGenFilterCode);
            tabPage2.Controls.Add(sbsiFilterConstant);
            tabPage2.Controls.Add(bConfigureFiltering);
            tabPage2.Controls.Add(textBox5);
            tabPage2.Location = new System.Drawing.Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new System.Windows.Forms.Padding(3);
            tabPage2.Size = new System.Drawing.Size(373, 377);
            tabPage2.TabIndex = 0;
            tabPage2.Text = "Filtering";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // bGenFilterCode
            // 
            bGenFilterCode.BackColor = System.Drawing.Color.MediumPurple;
            bGenFilterCode.Location = new System.Drawing.Point(227, 88);
            bGenFilterCode.Name = "bGenFilterCode";
            bGenFilterCode.Size = new System.Drawing.Size(90, 47);
            bGenFilterCode.TabIndex = 30;
            bGenFilterCode.Text = "Gen Filter Code";
            bGenFilterCode.UseVisualStyleBackColor = false;
            bGenFilterCode.Click += bGenFilterCode_Click;
            // 
            // sbsiFilterConstant
            // 
            sbsiFilterConstant.Location = new System.Drawing.Point(6, 6);
            sbsiFilterConstant.Maximum = 65535;
            sbsiFilterConstant.Minimum = 0;
            sbsiFilterConstant.Name = "sbsiFilterConstant";
            sbsiFilterConstant.Size = new System.Drawing.Size(328, 76);
            sbsiFilterConstant.TabIndex = 0;
            sbsiFilterConstant.Text = "filterConstant";
            sbsiFilterConstant.TextBoxHint = "";
            sbsiFilterConstant.value = (ushort)0;
            // 
            // bConfigureFiltering
            // 
            bConfigureFiltering.Location = new System.Drawing.Point(6, 88);
            bConfigureFiltering.Name = "bConfigureFiltering";
            bConfigureFiltering.Size = new System.Drawing.Size(156, 23);
            bConfigureFiltering.TabIndex = 2;
            bConfigureFiltering.Text = "Configure 1st order Filtering";
            bConfigureFiltering.UseVisualStyleBackColor = true;
            bConfigureFiltering.Click += bConfigureFiltering_Click;
            // 
            // textBox5
            // 
            textBox5.Location = new System.Drawing.Point(6, 182);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            textBox5.Size = new System.Drawing.Size(344, 189);
            textBox5.TabIndex = 20;
            textBox5.Text = resources.GetString("textBox5.Text");
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(bGenRateLimit);
            tabPage3.Controls.Add(sbsiMaxChangeUp);
            tabPage3.Controls.Add(sbsiFilterConstant2);
            tabPage3.Controls.Add(bConfigureMaximumRate);
            tabPage3.Controls.Add(textBox6);
            tabPage3.Location = new System.Drawing.Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new System.Windows.Forms.Padding(3);
            tabPage3.Size = new System.Drawing.Size(373, 377);
            tabPage3.TabIndex = 1;
            tabPage3.Text = "Rate Limit";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // bGenRateLimit
            // 
            bGenRateLimit.BackColor = System.Drawing.Color.MediumPurple;
            bGenRateLimit.Location = new System.Drawing.Point(227, 163);
            bGenRateLimit.Name = "bGenRateLimit";
            bGenRateLimit.Size = new System.Drawing.Size(90, 47);
            bGenRateLimit.TabIndex = 31;
            bGenRateLimit.Text = "Gen Rate Limit Code";
            bGenRateLimit.UseVisualStyleBackColor = false;
            bGenRateLimit.Click += bGenRateLimit_Click;
            // 
            // sbsiMaxChangeUp
            // 
            sbsiMaxChangeUp.Location = new System.Drawing.Point(16, 3);
            sbsiMaxChangeUp.Maximum = 65535;
            sbsiMaxChangeUp.Minimum = 0;
            sbsiMaxChangeUp.Name = "sbsiMaxChangeUp";
            sbsiMaxChangeUp.Size = new System.Drawing.Size(328, 76);
            sbsiMaxChangeUp.TabIndex = 22;
            sbsiMaxChangeUp.Text = "maximumChangeCountsUp";
            sbsiMaxChangeUp.TextBoxHint = "";
            sbsiMaxChangeUp.value = (ushort)100;
            // 
            // sbsiFilterConstant2
            // 
            sbsiFilterConstant2.Location = new System.Drawing.Point(16, 81);
            sbsiFilterConstant2.Maximum = 65535;
            sbsiFilterConstant2.Minimum = 0;
            sbsiFilterConstant2.Name = "sbsiFilterConstant2";
            sbsiFilterConstant2.Size = new System.Drawing.Size(328, 76);
            sbsiFilterConstant2.TabIndex = 0;
            sbsiFilterConstant2.Text = "maximumChangeCountsDown";
            sbsiFilterConstant2.TextBoxHint = "";
            sbsiFilterConstant2.value = (ushort)100;
            // 
            // bConfigureMaximumRate
            // 
            bConfigureMaximumRate.Location = new System.Drawing.Point(16, 163);
            bConfigureMaximumRate.Name = "bConfigureMaximumRate";
            bConfigureMaximumRate.Size = new System.Drawing.Size(156, 23);
            bConfigureMaximumRate.TabIndex = 4;
            bConfigureMaximumRate.Text = "Configure Rate Limit";
            bConfigureMaximumRate.UseVisualStyleBackColor = true;
            bConfigureMaximumRate.Click += bConfigureMaximumRate_Click;
            // 
            // textBox6
            // 
            textBox6.Location = new System.Drawing.Point(16, 263);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.ReadOnly = true;
            textBox6.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            textBox6.Size = new System.Drawing.Size(344, 108);
            textBox6.TabIndex = 21;
            textBox6.Text = resources.GetString("textBox6.Text");
            // 
            // edFilteringPeriod
            // 
            edFilteringPeriod.DropDownToolTip = "";
            edFilteringPeriod.dropdowntype = "SerialWombatClassLibrary.SerialWombat.ScaledOutputPeriod";
            edFilteringPeriod.Location = new System.Drawing.Point(53, 417);
            edFilteringPeriod.Name = "edFilteringPeriod";
            edFilteringPeriod.Size = new System.Drawing.Size(274, 35);
            edFilteringPeriod.TabIndex = 1;
            edFilteringPeriod.Value = 0;
            // 
            // tpOutputScaling
            // 
            tpOutputScaling.Controls.Add(tabControl3);
            tpOutputScaling.Location = new System.Drawing.Point(4, 24);
            tpOutputScaling.Name = "tpOutputScaling";
            tpOutputScaling.Padding = new System.Windows.Forms.Padding(3);
            tpOutputScaling.Size = new System.Drawing.Size(393, 468);
            tpOutputScaling.TabIndex = 5;
            tpOutputScaling.Text = "Output Scaling";
            tpOutputScaling.UseVisualStyleBackColor = true;
            // 
            // tabControl3
            // 
            tabControl3.Controls.Add(MinMax);
            tabControl3.Controls.Add(tabPage5);
            tabControl3.Location = new System.Drawing.Point(6, 6);
            tabControl3.Name = "tabControl3";
            tabControl3.SelectedIndex = 0;
            tabControl3.Size = new System.Drawing.Size(381, 456);
            tabControl3.TabIndex = 33;
            // 
            // MinMax
            // 
            MinMax.Controls.Add(sbsiOutputScalingMin);
            MinMax.Controls.Add(bGenOutputScalingcode);
            MinMax.Controls.Add(sbsiOutputScalingMax);
            MinMax.Controls.Add(bConfigureOutputScaling);
            MinMax.Location = new System.Drawing.Point(4, 24);
            MinMax.Name = "MinMax";
            MinMax.Padding = new System.Windows.Forms.Padding(3);
            MinMax.Size = new System.Drawing.Size(373, 428);
            MinMax.TabIndex = 0;
            MinMax.Text = "MinMax";
            MinMax.UseVisualStyleBackColor = true;
            // 
            // sbsiOutputScalingMin
            // 
            sbsiOutputScalingMin.Location = new System.Drawing.Point(6, 6);
            sbsiOutputScalingMin.Maximum = 65535;
            sbsiOutputScalingMin.Minimum = 0;
            sbsiOutputScalingMin.Name = "sbsiOutputScalingMin";
            sbsiOutputScalingMin.Size = new System.Drawing.Size(328, 76);
            sbsiOutputScalingMin.TabIndex = 14;
            sbsiOutputScalingMin.Text = "outputMin";
            sbsiOutputScalingMin.TextBoxHint = "";
            sbsiOutputScalingMin.value = (ushort)0;
            // 
            // bGenOutputScalingcode
            // 
            bGenOutputScalingcode.BackColor = System.Drawing.Color.MediumPurple;
            bGenOutputScalingcode.Location = new System.Drawing.Point(274, 166);
            bGenOutputScalingcode.Name = "bGenOutputScalingcode";
            bGenOutputScalingcode.Size = new System.Drawing.Size(90, 47);
            bGenOutputScalingcode.TabIndex = 32;
            bGenOutputScalingcode.Text = "Gen Output Scaling Code";
            bGenOutputScalingcode.UseVisualStyleBackColor = false;
            bGenOutputScalingcode.Click += bGenOutputScalingcode_Click;
            // 
            // sbsiOutputScalingMax
            // 
            sbsiOutputScalingMax.Location = new System.Drawing.Point(9, 75);
            sbsiOutputScalingMax.Maximum = 65535;
            sbsiOutputScalingMax.Minimum = 0;
            sbsiOutputScalingMax.Name = "sbsiOutputScalingMax";
            sbsiOutputScalingMax.Size = new System.Drawing.Size(328, 76);
            sbsiOutputScalingMax.TabIndex = 15;
            sbsiOutputScalingMax.Text = "outputMax";
            sbsiOutputScalingMax.TextBoxHint = "";
            sbsiOutputScalingMax.value = ushort.MaxValue;
            // 
            // bConfigureOutputScaling
            // 
            bConfigureOutputScaling.Location = new System.Drawing.Point(77, 166);
            bConfigureOutputScaling.Name = "bConfigureOutputScaling";
            bConfigureOutputScaling.Size = new System.Drawing.Size(167, 23);
            bConfigureOutputScaling.TabIndex = 16;
            bConfigureOutputScaling.Text = "Configure Output Scaling";
            bConfigureOutputScaling.UseVisualStyleBackColor = true;
            bConfigureOutputScaling.Click += bConfigureOutputScaling_Click;
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(label1);
            tabPage5.Controls.Add(sbac2DIndex);
            tabPage5.Controls.Add(button1);
            tabPage5.Controls.Add(b2DConfigure);
            tabPage5.Controls.Add(gb2DData);
            tabPage5.Controls.Add(formsPlot1);
            tabPage5.Location = new System.Drawing.Point(4, 24);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new System.Windows.Forms.Padding(3);
            tabPage5.Size = new System.Drawing.Size(373, 428);
            tabPage5.TabIndex = 1;
            tabPage5.Text = "2DLookup";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(25, 23);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(38, 15);
            label1.TabIndex = 33;
            label1.Text = "Index:";
            // 
            // sbac2DIndex
            // 
            sbac2DIndex.AutoSize = true;
            sbac2DIndex.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            sbac2DIndex.Location = new System.Drawing.Point(84, 18);
            sbac2DIndex.Name = "sbac2DIndex";
            sbac2DIndex.Size = new System.Drawing.Size(56, 26);
            sbac2DIndex.TabIndex = 32;
            sbac2DIndex.Text = "0x0000";
            toolTip1.SetToolTip(sbac2DIndex, "The location in User Memory to place the table of lookup data (4 bytes per point)");
            sbac2DIndex.Value = (ushort)0;
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.Color.MediumPurple;
            button1.Location = new System.Drawing.Point(307, 6);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(57, 47);
            button1.TabIndex = 31;
            button1.Text = "Gen Code";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // b2DConfigure
            // 
            b2DConfigure.Location = new System.Drawing.Point(226, 18);
            b2DConfigure.Name = "b2DConfigure";
            b2DConfigure.Size = new System.Drawing.Size(75, 23);
            b2DConfigure.TabIndex = 2;
            b2DConfigure.Text = "Configure";
            b2DConfigure.UseVisualStyleBackColor = true;
            b2DConfigure.Click += b2DConfigure_Click;
            // 
            // gb2DData
            // 
            gb2DData.Controls.Add(l2DWarning);
            gb2DData.Controls.Add(pXY);
            gb2DData.Location = new System.Drawing.Point(7, 56);
            gb2DData.Name = "gb2DData";
            gb2DData.Size = new System.Drawing.Size(363, 182);
            gb2DData.TabIndex = 1;
            gb2DData.TabStop = false;
            gb2DData.Text = "Data (Last X == 65535)";
            // 
            // l2DWarning
            // 
            l2DWarning.AutoSize = true;
            l2DWarning.ForeColor = System.Drawing.Color.Red;
            l2DWarning.Location = new System.Drawing.Point(16, 97);
            l2DWarning.Name = "l2DWarning";
            l2DWarning.Size = new System.Drawing.Size(0, 15);
            l2DWarning.TabIndex = 1;
            // 
            // pXY
            // 
            pXY.AutoScroll = true;
            pXY.Location = new System.Drawing.Point(6, 12);
            pXY.Name = "pXY";
            pXY.Size = new System.Drawing.Size(353, 164);
            pXY.TabIndex = 0;
            // 
            // formsPlot1
            // 
            formsPlot1.Location = new System.Drawing.Point(7, 244);
            formsPlot1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            formsPlot1.Name = "formsPlot1";
            formsPlot1.Size = new System.Drawing.Size(359, 178);
            formsPlot1.TabIndex = 0;
            // 
            // swpdsInput
            // 
            swpdsInput.DataSourceValue = 0;
            swpdsInput.DropDownToolTip = "The pin or public data id that should be read to drive the output value.  Only used when enabled is set to true";
            swpdsInput.Location = new System.Drawing.Point(70, 505);
            swpdsInput.Name = "swpdsInput";
            swpdsInput.Size = new System.Drawing.Size(231, 35);
            swpdsInput.TabIndex = 11;
            // 
            // ckbScaledOutputEnable
            // 
            ckbScaledOutputEnable.AutoSize = true;
            ckbScaledOutputEnable.Location = new System.Drawing.Point(6, 523);
            ckbScaledOutputEnable.Name = "ckbScaledOutputEnable";
            ckbScaledOutputEnable.Size = new System.Drawing.Size(61, 19);
            ckbScaledOutputEnable.TabIndex = 12;
            ckbScaledOutputEnable.Text = "Enable";
            toolTip1.SetToolTip(ckbScaledOutputEnable, "Enables the Scaled Output block.  If false then the current pin's public data value is used as the setting for the output");
            ckbScaledOutputEnable.UseVisualStyleBackColor = true;
            ckbScaledOutputEnable.CheckedChanged += ckbScaledOutputEnable_CheckedChanged;
            // 
            // button4
            // 
            button4.BackColor = System.Drawing.Color.MediumPurple;
            button4.Location = new System.Drawing.Point(307, 501);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(90, 47);
            button4.TabIndex = 30;
            button4.Text = "Gen Enable  Code";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(bSetCATVP);
            tabPage4.Controls.Add(label2);
            tabPage4.Controls.Add(swpdTargetValuePin);
            tabPage4.Location = new System.Drawing.Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new System.Windows.Forms.Padding(3);
            tabPage4.Size = new System.Drawing.Size(373, 390);
            tabPage4.TabIndex = 4;
            tabPage4.Text = "tpOptions";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // swpdTargetValuePin
            // 
            swpdTargetValuePin.IncludeNAPin = false;
            swpdTargetValuePin.Location = new System.Drawing.Point(173, 7);
            swpdTargetValuePin.Name = "swpdTargetValuePin";
            swpdTargetValuePin.Pin = 255;
            swpdTargetValuePin.PinType = SerialWombat.SerialWombatPinType.SerialWombatPin;
            swpdTargetValuePin.Size = new System.Drawing.Size(94, 25);
            swpdTargetValuePin.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(12, 17);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(155, 15);
            label2.TabIndex = 1;
            label2.Text = "Control Alg Target Value Pin";
            // 
            // bSetCATVP
            // 
            bSetCATVP.Location = new System.Drawing.Point(273, 7);
            bSetCATVP.Name = "bSetCATVP";
            bSetCATVP.Size = new System.Drawing.Size(75, 23);
            bSetCATVP.TabIndex = 2;
            bSetCATVP.Text = "Set";
            bSetCATVP.UseVisualStyleBackColor = true;
            bSetCATVP.Click += bSetCATVP_Click;
            // 
            // ScaledOutputControl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            Controls.Add(button4);
            Controls.Add(ckbScaledOutputEnable);
            Controls.Add(tabControl1);
            Controls.Add(swpdsInput);
            Name = "ScaledOutputControl";
            Size = new System.Drawing.Size(407, 551);
            Load += ScaledOutputControl_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tpPID.ResumeLayout(false);
            tabControl4.ResumeLayout(false);
            tabPage7.ResumeLayout(false);
            tabPage7.PerformLayout();
            tpPID1.ResumeLayout(false);
            tpPID1.PerformLayout();
            tpRamp.ResumeLayout(false);
            tpRamp.PerformLayout();
            tpTimeout.ResumeLayout(false);
            tpTimeout.PerformLayout();
            tpFiltering.ResumeLayout(false);
            tabControl2.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tpOutputScaling.ResumeLayout(false);
            tabControl3.ResumeLayout(false);
            MinMax.ResumeLayout(false);
            tabPage5.ResumeLayout(false);
            tabPage5.PerformLayout();
            gb2DData.ResumeLayout(false);
            gb2DData.PerformLayout();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

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
        private System.Windows.Forms.TabPage tpRamp;
        private RampOutputScaleControl rampOutputScaleControl1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label2;
        private SerialWombatPinDropdown swpdTargetValuePin;
        private System.Windows.Forms.Button bSetCATVP;
    }
}
