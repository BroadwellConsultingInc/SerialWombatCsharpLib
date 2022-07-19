namespace SerialWombatWindowsFormsLibrary
{
    partial class ProcessedInputControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProcessedInputControl));
            this.ckbEnabled = new System.Windows.Forms.CheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.bRemoveBelowAbove = new System.Windows.Forms.Button();
            this.sbsiExcludeAbove = new SerialWombatWindowsFormsLibrary.SixteenBitSliderInput();
            this.sbsiExcludeBelow = new SerialWombatWindowsFormsLibrary.SixteenBitSliderInput();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpInversion = new System.Windows.Forms.TabPage();
            this.ckbInverted = new System.Windows.Forms.CheckBox();
            this.bConfigureInverted = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.bConfigureMXB = new System.Windows.Forms.Button();
            this.tbB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbM = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.bConfigure = new System.Windows.Forms.Button();
            this.sbsiInputScaleMax = new SerialWombatWindowsFormsLibrary.SixteenBitSliderInput();
            this.sbsiInputScaleMin = new SerialWombatWindowsFormsLibrary.SixteenBitSliderInput();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.ckbResetMinMax = new System.Windows.Forms.CheckBox();
            this.bReadMinMax = new System.Windows.Forms.Button();
            this.lMaximum = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lMinimum = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.bSetFilterConstant = new System.Windows.Forms.Button();
            this.bSetAveragedSamples = new System.Windows.Forms.Button();
            this.sbsiFilterConstant = new SerialWombatWindowsFormsLibrary.SixteenBitSliderInput();
            this.sbsiAveragedSamples = new SerialWombatWindowsFormsLibrary.SixteenBitSliderInput();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.bShowQueue = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ckbQueueLowByte = new System.Windows.Forms.CheckBox();
            this.ckbQueueHighByte = new System.Windows.Forms.CheckBox();
            this.edQueueingPeriod = new SerialWombatWindowsFormsLibrary.EnumDropdown();
            this.bInitializeQueue = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbQueueLength = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbQueueAddress = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.edPublicOutput = new SerialWombatWindowsFormsLibrary.EnumDropdown();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tpInversion.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // ckbEnabled
            // 
            this.ckbEnabled.AutoSize = true;
            this.ckbEnabled.Location = new System.Drawing.Point(409, 548);
            this.ckbEnabled.Name = "ckbEnabled";
            this.ckbEnabled.Size = new System.Drawing.Size(68, 19);
            this.ckbEnabled.TabIndex = 1;
            this.ckbEnabled.Text = "Enabled";
            this.ckbEnabled.UseVisualStyleBackColor = true;
            this.ckbEnabled.CheckedChanged += new System.EventHandler(this.ckbEnabled_CheckedChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.bRemoveBelowAbove);
            this.tabPage2.Controls.Add(this.sbsiExcludeAbove);
            this.tabPage2.Controls.Add(this.sbsiExcludeBelow);
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(476, 508);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "OutlierRemoval";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // bRemoveBelowAbove
            // 
            this.bRemoveBelowAbove.Location = new System.Drawing.Point(118, 317);
            this.bRemoveBelowAbove.Name = "bRemoveBelowAbove";
            this.bRemoveBelowAbove.Size = new System.Drawing.Size(210, 23);
            this.bRemoveBelowAbove.TabIndex = 19;
            this.bRemoveBelowAbove.Text = "Configure Remove Below Above";
            this.bRemoveBelowAbove.UseVisualStyleBackColor = true;
            this.bRemoveBelowAbove.Click += new System.EventHandler(this.bExcludeBelowAbove_Click);
            // 
            // sbsiExcludeAbove
            // 
            this.sbsiExcludeAbove.Location = new System.Drawing.Point(15, 220);
            this.sbsiExcludeAbove.Name = "sbsiExcludeAbove";
            this.sbsiExcludeAbove.Size = new System.Drawing.Size(328, 76);
            this.sbsiExcludeAbove.TabIndex = 18;
            this.sbsiExcludeAbove.Text = "excludeAbove";
            this.sbsiExcludeAbove.TextBoxHint = "input values above this value will not be processsed";
            this.sbsiExcludeAbove.value = ((ushort)(0));
            // 
            // sbsiExcludeBelow
            // 
            this.sbsiExcludeBelow.Location = new System.Drawing.Point(15, 138);
            this.sbsiExcludeBelow.Name = "sbsiExcludeBelow";
            this.sbsiExcludeBelow.Size = new System.Drawing.Size(328, 76);
            this.sbsiExcludeBelow.TabIndex = 17;
            this.sbsiExcludeBelow.Text = "excludeBelow";
            this.sbsiExcludeBelow.TextBoxHint = "input values below this value will not be processed";
            this.sbsiExcludeBelow.value = ((ushort)(0));
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(6, 16);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(464, 103);
            this.textBox2.TabIndex = 16;
            this.textBox2.Text = resources.GetString("textBox2.Text");
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(476, 508);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Overview";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 30);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(464, 463);
            this.textBox1.TabIndex = 15;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tpInversion);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(484, 536);
            this.tabControl1.TabIndex = 0;
            // 
            // tpInversion
            // 
            this.tpInversion.Controls.Add(this.ckbInverted);
            this.tpInversion.Controls.Add(this.bConfigureInverted);
            this.tpInversion.Controls.Add(this.textBox3);
            this.tpInversion.Location = new System.Drawing.Point(4, 24);
            this.tpInversion.Name = "tpInversion";
            this.tpInversion.Padding = new System.Windows.Forms.Padding(3);
            this.tpInversion.Size = new System.Drawing.Size(476, 508);
            this.tpInversion.TabIndex = 2;
            this.tpInversion.Text = "Inversion";
            this.tpInversion.UseVisualStyleBackColor = true;
            // 
            // ckbInverted
            // 
            this.ckbInverted.AutoSize = true;
            this.ckbInverted.Location = new System.Drawing.Point(179, 133);
            this.ckbInverted.Name = "ckbInverted";
            this.ckbInverted.Size = new System.Drawing.Size(69, 19);
            this.ckbInverted.TabIndex = 19;
            this.ckbInverted.Text = "Inverted";
            this.toolTip1.SetToolTip(this.ckbInverted, "False - input value isn\'t changed.  True- input value is subtracted from 65535");
            this.ckbInverted.UseVisualStyleBackColor = true;
            // 
            // bConfigureInverted
            // 
            this.bConfigureInverted.Location = new System.Drawing.Point(145, 197);
            this.bConfigureInverted.Name = "bConfigureInverted";
            this.bConfigureInverted.Size = new System.Drawing.Size(143, 23);
            this.bConfigureInverted.TabIndex = 18;
            this.bConfigureInverted.Text = "Configure Inversion";
            this.bConfigureInverted.UseVisualStyleBackColor = true;
            this.bConfigureInverted.Click += new System.EventHandler(this.bConfigureInverted_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(3, 6);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox3.Size = new System.Drawing.Size(464, 103);
            this.textBox3.TabIndex = 17;
            this.textBox3.Text = "if enabled subtract the input value from 65535 before doing any other processing." +
    "";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.bConfigureMXB);
            this.tabPage4.Controls.Add(this.tbB);
            this.tabPage4.Controls.Add(this.label3);
            this.tabPage4.Controls.Add(this.tbM);
            this.tabPage4.Controls.Add(this.label2);
            this.tabPage4.Controls.Add(this.label1);
            this.tabPage4.Controls.Add(this.textBox5);
            this.tabPage4.Controls.Add(this.bConfigure);
            this.tabPage4.Controls.Add(this.sbsiInputScaleMax);
            this.tabPage4.Controls.Add(this.sbsiInputScaleMin);
            this.tabPage4.Controls.Add(this.textBox4);
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(476, 508);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Transform";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // bConfigureMXB
            // 
            this.bConfigureMXB.Location = new System.Drawing.Point(166, 412);
            this.bConfigureMXB.Name = "bConfigureMXB";
            this.bConfigureMXB.Size = new System.Drawing.Size(138, 23);
            this.bConfigureMXB.TabIndex = 26;
            this.bConfigureMXB.Text = "Configure MXB";
            this.bConfigureMXB.UseVisualStyleBackColor = true;
            this.bConfigureMXB.Click += new System.EventHandler(this.bConfigureMXB_Click);
            // 
            // tbB
            // 
            this.tbB.Location = new System.Drawing.Point(284, 365);
            this.tbB.Name = "tbB";
            this.tbB.Size = new System.Drawing.Size(100, 23);
            this.tbB.TabIndex = 25;
            this.toolTip1.SetToolTip(this.tbB, "A value between -65535 and 65535 to add to the result of the multiplication");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(114, 368);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 15);
            this.label3.TabIndex = 24;
            this.label3.Text = "Intercept (-65535 to 65535):";
            // 
            // tbM
            // 
            this.tbM.Location = new System.Drawing.Point(284, 336);
            this.tbM.Name = "tbM";
            this.tbM.Size = new System.Drawing.Size(100, 23);
            this.tbM.TabIndex = 25;
            this.toolTip1.SetToolTip(this.tbM, "A float that will be made a value between -16777215 and +1677215 representing the" +
        " number of 256th by which to multiply the input ");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 339);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 15);
            this.label2.TabIndex = 24;
            this.label2.Text = "Slope (Float between 6551.62 and - 6551.62):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(196, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 15);
            this.label1.TabIndex = 23;
            this.label1.Text = "OR";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(9, 262);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox5.Size = new System.Drawing.Size(464, 55);
            this.textBox5.TabIndex = 22;
            this.textBox5.Text = resources.GetString("textBox5.Text");
            // 
            // bConfigure
            // 
            this.bConfigure.Location = new System.Drawing.Point(340, 138);
            this.bConfigure.Name = "bConfigure";
            this.bConfigure.Size = new System.Drawing.Size(75, 65);
            this.bConfigure.TabIndex = 21;
            this.bConfigure.Text = "Configure Input Scaling";
            this.bConfigure.UseVisualStyleBackColor = true;
            this.bConfigure.Click += new System.EventHandler(this.bConfigure_Click);
            // 
            // sbsiInputScaleMax
            // 
            this.sbsiInputScaleMax.Location = new System.Drawing.Point(6, 152);
            this.sbsiInputScaleMax.Name = "sbsiInputScaleMax";
            this.sbsiInputScaleMax.Size = new System.Drawing.Size(328, 76);
            this.sbsiInputScaleMax.TabIndex = 20;
            this.sbsiInputScaleMax.Text = "Max";
            this.sbsiInputScaleMax.TextBoxHint = "";
            this.sbsiInputScaleMax.value = ((ushort)(0));
            // 
            // sbsiInputScaleMin
            // 
            this.sbsiInputScaleMin.Location = new System.Drawing.Point(6, 70);
            this.sbsiInputScaleMin.Name = "sbsiInputScaleMin";
            this.sbsiInputScaleMin.Size = new System.Drawing.Size(328, 76);
            this.sbsiInputScaleMin.TabIndex = 19;
            this.sbsiInputScaleMin.Text = "min";
            this.sbsiInputScaleMin.TextBoxHint = "";
            this.sbsiInputScaleMin.value = ((ushort)(0));
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(3, 6);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox4.Size = new System.Drawing.Size(464, 58);
            this.textBox4.TabIndex = 18;
            this.textBox4.Text = resources.GetString("textBox4.Text");
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.textBox8);
            this.tabPage5.Controls.Add(this.ckbResetMinMax);
            this.tabPage5.Controls.Add(this.bReadMinMax);
            this.tabPage5.Controls.Add(this.lMaximum);
            this.tabPage5.Controls.Add(this.label7);
            this.tabPage5.Controls.Add(this.lMinimum);
            this.tabPage5.Controls.Add(this.label5);
            this.tabPage5.Controls.Add(this.textBox7);
            this.tabPage5.Controls.Add(this.textBox6);
            this.tabPage5.Controls.Add(this.bSetFilterConstant);
            this.tabPage5.Controls.Add(this.bSetAveragedSamples);
            this.tabPage5.Controls.Add(this.sbsiFilterConstant);
            this.tabPage5.Controls.Add(this.sbsiAveragedSamples);
            this.tabPage5.Location = new System.Drawing.Point(4, 24);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(476, 508);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Averaging";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(6, 315);
            this.textBox8.Multiline = true;
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox8.Size = new System.Drawing.Size(464, 58);
            this.textBox8.TabIndex = 27;
            this.textBox8.Text = resources.GetString("textBox8.Text");
            // 
            // ckbResetMinMax
            // 
            this.ckbResetMinMax.AutoSize = true;
            this.ckbResetMinMax.Location = new System.Drawing.Point(56, 407);
            this.ckbResetMinMax.Name = "ckbResetMinMax";
            this.ckbResetMinMax.Size = new System.Drawing.Size(174, 19);
            this.ckbResetMinMax.TabIndex = 26;
            this.ckbResetMinMax.Text = "Reset MinMax after Reading";
            this.ckbResetMinMax.UseVisualStyleBackColor = true;
            // 
            // bReadMinMax
            // 
            this.bReadMinMax.Location = new System.Drawing.Point(261, 392);
            this.bReadMinMax.Name = "bReadMinMax";
            this.bReadMinMax.Size = new System.Drawing.Size(96, 23);
            this.bReadMinMax.TabIndex = 25;
            this.bReadMinMax.Text = "Read Min/Max";
            this.bReadMinMax.UseVisualStyleBackColor = true;
            this.bReadMinMax.Click += new System.EventHandler(this.bReadMinMax_Click);
            // 
            // lMaximum
            // 
            this.lMaximum.AutoSize = true;
            this.lMaximum.Location = new System.Drawing.Point(220, 380);
            this.lMaximum.Name = "lMaximum";
            this.lMaximum.Size = new System.Drawing.Size(27, 15);
            this.lMaximum.TabIndex = 24;
            this.lMaximum.Text = "----";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(151, 380);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 15);
            this.label7.TabIndex = 23;
            this.label7.Text = "Maximum:";
            // 
            // lMinimum
            // 
            this.lMinimum.AutoSize = true;
            this.lMinimum.Location = new System.Drawing.Point(107, 380);
            this.lMinimum.Name = "lMinimum";
            this.lMinimum.Size = new System.Drawing.Size(27, 15);
            this.lMinimum.TabIndex = 22;
            this.lMinimum.Text = "----";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 380);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 15);
            this.label5.TabIndex = 21;
            this.label5.Text = "Minimum:";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(3, 169);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox7.Size = new System.Drawing.Size(464, 58);
            this.textBox7.TabIndex = 20;
            this.textBox7.Text = resources.GetString("textBox7.Text");
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(6, 6);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox6.Size = new System.Drawing.Size(464, 58);
            this.textBox6.TabIndex = 19;
            this.textBox6.Text = resources.GetString("textBox6.Text");
            // 
            // bSetFilterConstant
            // 
            this.bSetFilterConstant.Location = new System.Drawing.Point(363, 257);
            this.bSetFilterConstant.Name = "bSetFilterConstant";
            this.bSetFilterConstant.Size = new System.Drawing.Size(75, 23);
            this.bSetFilterConstant.TabIndex = 3;
            this.bSetFilterConstant.Text = "Set";
            this.bSetFilterConstant.UseVisualStyleBackColor = true;
            this.bSetFilterConstant.Click += new System.EventHandler(this.bSetFilterConstant_Click);
            // 
            // bSetAveragedSamples
            // 
            this.bSetAveragedSamples.Location = new System.Drawing.Point(363, 113);
            this.bSetAveragedSamples.Name = "bSetAveragedSamples";
            this.bSetAveragedSamples.Size = new System.Drawing.Size(75, 23);
            this.bSetAveragedSamples.TabIndex = 2;
            this.bSetAveragedSamples.Text = "Set";
            this.bSetAveragedSamples.UseVisualStyleBackColor = true;
            this.bSetAveragedSamples.Click += new System.EventHandler(this.bSetAveragedSamples_Click);
            // 
            // sbsiFilterConstant
            // 
            this.sbsiFilterConstant.Location = new System.Drawing.Point(29, 233);
            this.sbsiFilterConstant.Name = "sbsiFilterConstant";
            this.sbsiFilterConstant.Size = new System.Drawing.Size(328, 76);
            this.sbsiFilterConstant.TabIndex = 1;
            this.sbsiFilterConstant.Text = "FilterConstant";
            this.sbsiFilterConstant.TextBoxHint = "";
            this.sbsiFilterConstant.value = ((ushort)(65508));
            // 
            // sbsiAveragedSamples
            // 
            this.sbsiAveragedSamples.Location = new System.Drawing.Point(29, 80);
            this.sbsiAveragedSamples.Name = "sbsiAveragedSamples";
            this.sbsiAveragedSamples.Size = new System.Drawing.Size(328, 76);
            this.sbsiAveragedSamples.TabIndex = 0;
            this.sbsiAveragedSamples.Text = "AveragedSamples";
            this.sbsiAveragedSamples.TextBoxHint = "";
            this.sbsiAveragedSamples.value = ((ushort)(64));
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.bShowQueue);
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.ckbQueueLowByte);
            this.tabPage3.Controls.Add(this.ckbQueueHighByte);
            this.tabPage3.Controls.Add(this.edQueueingPeriod);
            this.tabPage3.Controls.Add(this.bInitializeQueue);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.tbQueueLength);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.tbQueueAddress);
            this.tabPage3.Controls.Add(this.textBox9);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(476, 508);
            this.tabPage3.TabIndex = 5;
            this.tabPage3.Text = "Queueing";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // bShowQueue
            // 
            this.bShowQueue.Location = new System.Drawing.Point(304, 117);
            this.bShowQueue.Name = "bShowQueue";
            this.bShowQueue.Size = new System.Drawing.Size(101, 23);
            this.bShowQueue.TabIndex = 28;
            this.bShowQueue.Text = "ShowQueue";
            this.bShowQueue.UseVisualStyleBackColor = true;
            this.bShowQueue.Click += new System.EventHandler(this.bShowQueue_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(126, 215);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 27;
            this.button1.Text = "Configure Queueing";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ckbQueueLowByte
            // 
            this.ckbQueueLowByte.AutoSize = true;
            this.ckbQueueLowByte.Checked = true;
            this.ckbQueueLowByte.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbQueueLowByte.Location = new System.Drawing.Point(170, 190);
            this.ckbQueueLowByte.Name = "ckbQueueLowByte";
            this.ckbQueueLowByte.Size = new System.Drawing.Size(112, 19);
            this.ckbQueueLowByte.TabIndex = 26;
            this.ckbQueueLowByte.Text = "Queue Low Byte";
            this.ckbQueueLowByte.UseVisualStyleBackColor = true;
            // 
            // ckbQueueHighByte
            // 
            this.ckbQueueHighByte.AutoSize = true;
            this.ckbQueueHighByte.Checked = true;
            this.ckbQueueHighByte.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbQueueHighByte.Location = new System.Drawing.Point(35, 190);
            this.ckbQueueHighByte.Name = "ckbQueueHighByte";
            this.ckbQueueHighByte.Size = new System.Drawing.Size(116, 19);
            this.ckbQueueHighByte.TabIndex = 25;
            this.ckbQueueHighByte.Text = "Queue High Byte";
            this.ckbQueueHighByte.UseVisualStyleBackColor = true;
            // 
            // edQueueingPeriod
            // 
            this.edQueueingPeriod.DropDownToolTip = "";
            this.edQueueingPeriod.dropdowntype = "SerialWombat.ScaledOutputPeriod";
            this.edQueueingPeriod.Location = new System.Drawing.Point(160, 155);
            this.edQueueingPeriod.Name = "edQueueingPeriod";
            this.edQueueingPeriod.Size = new System.Drawing.Size(274, 35);
            this.edQueueingPeriod.TabIndex = 24;
            // 
            // bInitializeQueue
            // 
            this.bInitializeQueue.Location = new System.Drawing.Point(304, 84);
            this.bInitializeQueue.Name = "bInitializeQueue";
            this.bInitializeQueue.Size = new System.Drawing.Size(101, 23);
            this.bInitializeQueue.TabIndex = 23;
            this.bInitializeQueue.Text = "Initialize Queue";
            this.bInitializeQueue.UseVisualStyleBackColor = true;
            this.bInitializeQueue.Click += new System.EventHandler(this.bInitializeQueue_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(30, 164);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 15);
            this.label9.TabIndex = 22;
            this.label9.Text = "Queue Sample Rate:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 15);
            this.label8.TabIndex = 22;
            this.label8.Text = "Queue Length (bytes):";
            // 
            // tbQueueLength
            // 
            this.tbQueueLength.Location = new System.Drawing.Point(160, 114);
            this.tbQueueLength.Name = "tbQueueLength";
            this.tbQueueLength.Size = new System.Drawing.Size(100, 23);
            this.tbQueueLength.TabIndex = 21;
            this.tbQueueLength.Text = "512";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 15);
            this.label6.TabIndex = 22;
            this.label6.Text = "Queue Address:";
            // 
            // tbQueueAddress
            // 
            this.tbQueueAddress.Location = new System.Drawing.Point(126, 76);
            this.tbQueueAddress.Name = "tbQueueAddress";
            this.tbQueueAddress.Size = new System.Drawing.Size(100, 23);
            this.tbQueueAddress.TabIndex = 21;
            this.tbQueueAddress.Text = "0";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(3, 6);
            this.textBox9.Multiline = true;
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox9.Size = new System.Drawing.Size(464, 58);
            this.textBox9.TabIndex = 20;
            this.textBox9.Text = " Allows periodic storage of the public data value into a previously initialized q" +
    "ueue in the user memory buffer.";
            // 
            // edPublicOutput
            // 
            this.edPublicOutput.DropDownToolTip = "";
            this.edPublicOutput.dropdowntype = "SerialWombat.ProcessedInputOutputValue";
            this.edPublicOutput.Location = new System.Drawing.Point(122, 546);
            this.edPublicOutput.Name = "edPublicOutput";
            this.edPublicOutput.Size = new System.Drawing.Size(274, 35);
            this.edPublicOutput.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 552);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Public Data Output:";
            // 
            // ProcessedInputControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.edPublicOutput);
            this.Controls.Add(this.ckbEnabled);
            this.Controls.Add(this.tabControl1);
            this.Name = "ProcessedInputControl";
            this.Size = new System.Drawing.Size(490, 584);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tpInversion.ResumeLayout(false);
            this.tpInversion.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox ckbEnabled;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private SixteenBitSliderInput sbsiExcludeAbove;
        private SixteenBitSliderInput sbsiExcludeBelow;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TabPage tpInversion;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button bRemoveBelowAbove;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.CheckBox ckbInverted;
        private System.Windows.Forms.Button bConfigureInverted;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button bConfigure;
        private SixteenBitSliderInput sbsiInputScaleMax;
        private SixteenBitSliderInput sbsiInputScaleMin;
        private System.Windows.Forms.TextBox tbM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox tbB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bConfigureMXB;
        private SixteenBitSliderInput sbsiFilterConstant;
        private SixteenBitSliderInput sbsiAveragedSamples;
        private System.Windows.Forms.Button bSetFilterConstant;
        private System.Windows.Forms.Button bSetAveragedSamples;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private EnumDropdown edPublicOutput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox ckbResetMinMax;
        private System.Windows.Forms.Button bReadMinMax;
        private System.Windows.Forms.Label lMaximum;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lMinimum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbQueueAddress;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbQueueLength;
        private System.Windows.Forms.Button bInitializeQueue;
        private EnumDropdown edQueueingPeriod;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox ckbQueueLowByte;
        private System.Windows.Forms.CheckBox ckbQueueHighByte;
        private System.Windows.Forms.Button bShowQueue;
    }
}
