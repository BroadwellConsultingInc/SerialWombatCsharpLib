namespace SerialWombatWindowsFormsLibrary
{
    partial class LiquidCrystalControl
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
            this.gbControls = new System.Windows.Forms.GroupBox();
            this.gbCharacterBitmap = new System.Windows.Forms.GroupBox();
            this.bCharWrite = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.nudCharIndex = new System.Windows.Forms.NumericUpDown();
            this.gbRowOffsets = new System.Windows.Forms.GroupBox();
            this.bSetRowOffsets = new System.Windows.Forms.Button();
            this.nudRO4 = new System.Windows.Forms.NumericUpDown();
            this.nudRO3 = new System.Windows.Forms.NumericUpDown();
            this.nudRO2 = new System.Windows.Forms.NumericUpDown();
            this.nudRO1 = new System.Windows.Forms.NumericUpDown();
            this.ckbDisplayOff = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.sbacBufferIndex = new SerialWombatWindowsFormsLibrary.SixteenBitAddressControl();
            this.bSetBufferIndex = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.tbBuffer = new System.Windows.Forms.TextBox();
            this.bBufferWrite = new System.Windows.Forms.Button();
            this.gbSetCursor = new System.Windows.Forms.GroupBox();
            this.bSetCursor = new System.Windows.Forms.Button();
            this.nudSetColumn = new System.Windows.Forms.NumericUpDown();
            this.nudSetRow = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ckbBlink = new System.Windows.Forms.CheckBox();
            this.tbWrite = new System.Windows.Forms.TextBox();
            this.ckbCursor = new System.Windows.Forms.CheckBox();
            this.bWrite = new System.Windows.Forms.Button();
            this.ckbRightToLeft = new System.Windows.Forms.CheckBox();
            this.bClear = new System.Windows.Forms.Button();
            this.ckbAutoScroll = new System.Windows.Forms.CheckBox();
            this.bHome = new System.Windows.Forms.Button();
            this.ckbScrollRight = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.swpdD7 = new SerialWombatWindowsFormsLibrary.SerialWombatPinDropdown();
            this.bConfig = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nudColumns = new System.Windows.Forms.NumericUpDown();
            this.lEPin = new System.Windows.Forms.Label();
            this.nudRows = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.swpdRS = new SerialWombatWindowsFormsLibrary.SerialWombatPinDropdown();
            this.label4 = new System.Windows.Forms.Label();
            this.swpdD4 = new SerialWombatWindowsFormsLibrary.SerialWombatPinDropdown();
            this.label3 = new System.Windows.Forms.Label();
            this.swpdD5 = new SerialWombatWindowsFormsLibrary.SerialWombatPinDropdown();
            this.label2 = new System.Windows.Forms.Label();
            this.swpdD6 = new SerialWombatWindowsFormsLibrary.SerialWombatPinDropdown();
            this.lRsPin = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.gbControls.SuspendLayout();
            this.gbCharacterBitmap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCharIndex)).BeginInit();
            this.gbRowOffsets.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRO4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRO3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRO2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRO1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.gbSetCursor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSetColumn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSetRow)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudColumns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRows)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gbControls);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(3, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(797, 597);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // gbControls
            // 
            this.gbControls.Controls.Add(this.gbCharacterBitmap);
            this.gbControls.Controls.Add(this.gbRowOffsets);
            this.gbControls.Controls.Add(this.ckbDisplayOff);
            this.gbControls.Controls.Add(this.groupBox3);
            this.gbControls.Controls.Add(this.gbSetCursor);
            this.gbControls.Controls.Add(this.ckbBlink);
            this.gbControls.Controls.Add(this.tbWrite);
            this.gbControls.Controls.Add(this.ckbCursor);
            this.gbControls.Controls.Add(this.bWrite);
            this.gbControls.Controls.Add(this.ckbRightToLeft);
            this.gbControls.Controls.Add(this.bClear);
            this.gbControls.Controls.Add(this.ckbAutoScroll);
            this.gbControls.Controls.Add(this.bHome);
            this.gbControls.Controls.Add(this.ckbScrollRight);
            this.gbControls.Location = new System.Drawing.Point(8, 161);
            this.gbControls.Name = "gbControls";
            this.gbControls.Size = new System.Drawing.Size(704, 436);
            this.gbControls.TabIndex = 14;
            this.gbControls.TabStop = false;
            // 
            // gbCharacterBitmap
            // 
            this.gbCharacterBitmap.Controls.Add(this.bCharWrite);
            this.gbCharacterBitmap.Controls.Add(this.button1);
            this.gbCharacterBitmap.Controls.Add(this.label11);
            this.gbCharacterBitmap.Controls.Add(this.nudCharIndex);
            this.gbCharacterBitmap.Location = new System.Drawing.Point(485, 46);
            this.gbCharacterBitmap.Name = "gbCharacterBitmap";
            this.gbCharacterBitmap.Size = new System.Drawing.Size(200, 176);
            this.gbCharacterBitmap.TabIndex = 14;
            this.gbCharacterBitmap.TabStop = false;
            this.gbCharacterBitmap.Text = "Character bitmap";
            // 
            // bCharWrite
            // 
            this.bCharWrite.Location = new System.Drawing.Point(118, 120);
            this.bCharWrite.Name = "bCharWrite";
            this.bCharWrite.Size = new System.Drawing.Size(75, 23);
            this.bCharWrite.TabIndex = 2;
            this.bCharWrite.Text = "Write";
            this.bCharWrite.UseVisualStyleBackColor = true;
            this.bCharWrite.Click += new System.EventHandler(this.bCharWrite_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(118, 82);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Set";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(132, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 15);
            this.label11.TabIndex = 1;
            this.label11.Text = "Index:";
            // 
            // nudCharIndex
            // 
            this.nudCharIndex.Location = new System.Drawing.Point(132, 43);
            this.nudCharIndex.Name = "nudCharIndex";
            this.nudCharIndex.Size = new System.Drawing.Size(51, 23);
            this.nudCharIndex.TabIndex = 0;
            // 
            // gbRowOffsets
            // 
            this.gbRowOffsets.Controls.Add(this.bSetRowOffsets);
            this.gbRowOffsets.Controls.Add(this.nudRO4);
            this.gbRowOffsets.Controls.Add(this.nudRO3);
            this.gbRowOffsets.Controls.Add(this.nudRO2);
            this.gbRowOffsets.Controls.Add(this.nudRO1);
            this.gbRowOffsets.Location = new System.Drawing.Point(6, 25);
            this.gbRowOffsets.Name = "gbRowOffsets";
            this.gbRowOffsets.Size = new System.Drawing.Size(415, 69);
            this.gbRowOffsets.TabIndex = 5;
            this.gbRowOffsets.TabStop = false;
            this.gbRowOffsets.Text = "Row Offsets";
            // 
            // bSetRowOffsets
            // 
            this.bSetRowOffsets.Location = new System.Drawing.Point(371, 26);
            this.bSetRowOffsets.Name = "bSetRowOffsets";
            this.bSetRowOffsets.Size = new System.Drawing.Size(38, 23);
            this.bSetRowOffsets.TabIndex = 5;
            this.bSetRowOffsets.Text = "Set";
            this.bSetRowOffsets.UseVisualStyleBackColor = true;
            this.bSetRowOffsets.Click += new System.EventHandler(this.bSetRowOffsets_Click);
            // 
            // nudRO4
            // 
            this.nudRO4.Enabled = false;
            this.nudRO4.Location = new System.Drawing.Point(277, 22);
            this.nudRO4.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudRO4.Name = "nudRO4";
            this.nudRO4.Size = new System.Drawing.Size(75, 23);
            this.nudRO4.TabIndex = 4;
            this.nudRO4.Value = new decimal(new int[] {
            84,
            0,
            0,
            0});
            // 
            // nudRO3
            // 
            this.nudRO3.Enabled = false;
            this.nudRO3.Location = new System.Drawing.Point(184, 22);
            this.nudRO3.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudRO3.Name = "nudRO3";
            this.nudRO3.Size = new System.Drawing.Size(75, 23);
            this.nudRO3.TabIndex = 4;
            this.nudRO3.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // nudRO2
            // 
            this.nudRO2.Location = new System.Drawing.Point(92, 22);
            this.nudRO2.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudRO2.Name = "nudRO2";
            this.nudRO2.Size = new System.Drawing.Size(75, 23);
            this.nudRO2.TabIndex = 4;
            this.nudRO2.Value = new decimal(new int[] {
            64,
            0,
            0,
            0});
            // 
            // nudRO1
            // 
            this.nudRO1.Location = new System.Drawing.Point(6, 22);
            this.nudRO1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudRO1.Name = "nudRO1";
            this.nudRO1.Size = new System.Drawing.Size(75, 23);
            this.nudRO1.TabIndex = 4;
            // 
            // ckbDisplayOff
            // 
            this.ckbDisplayOff.AutoSize = true;
            this.ckbDisplayOff.Location = new System.Drawing.Point(190, 233);
            this.ckbDisplayOff.Name = "ckbDisplayOff";
            this.ckbDisplayOff.Size = new System.Drawing.Size(84, 19);
            this.ckbDisplayOff.TabIndex = 13;
            this.ckbDisplayOff.Text = "Display Off";
            this.ckbDisplayOff.UseVisualStyleBackColor = true;
            this.ckbDisplayOff.CheckedChanged += new System.EventHandler(this.ckbDisplayOff_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.sbacBufferIndex);
            this.groupBox3.Controls.Add(this.bSetBufferIndex);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.tbBuffer);
            this.groupBox3.Controls.Add(this.bBufferWrite);
            this.groupBox3.Location = new System.Drawing.Point(15, 304);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(654, 113);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Buffer Mode";
            // 
            // sbacBufferIndex
            // 
            this.sbacBufferIndex.AutoSize = true;
            this.sbacBufferIndex.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.sbacBufferIndex.Location = new System.Drawing.Point(86, 22);
            this.sbacBufferIndex.Name = "sbacBufferIndex";
            this.sbacBufferIndex.Size = new System.Drawing.Size(56, 26);
            this.sbacBufferIndex.TabIndex = 6;
            this.sbacBufferIndex.Value = ((ushort)(0));
            // 
            // bSetBufferIndex
            // 
            this.bSetBufferIndex.Location = new System.Drawing.Point(148, 22);
            this.bSetBufferIndex.Name = "bSetBufferIndex";
            this.bSetBufferIndex.Size = new System.Drawing.Size(38, 23);
            this.bSetBufferIndex.TabIndex = 5;
            this.bSetBufferIndex.Text = "Set";
            this.bSetBufferIndex.UseVisualStyleBackColor = true;
            this.bSetBufferIndex.Click += new System.EventHandler(this.bSetBufferIndex_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 15);
            this.label10.TabIndex = 0;
            this.label10.Text = "Buffer Index:";
            // 
            // tbBuffer
            // 
            this.tbBuffer.Location = new System.Drawing.Point(6, 73);
            this.tbBuffer.Name = "tbBuffer";
            this.tbBuffer.Size = new System.Drawing.Size(569, 23);
            this.tbBuffer.TabIndex = 8;
            // 
            // bBufferWrite
            // 
            this.bBufferWrite.Enabled = false;
            this.bBufferWrite.Location = new System.Drawing.Point(581, 73);
            this.bBufferWrite.Name = "bBufferWrite";
            this.bBufferWrite.Size = new System.Drawing.Size(44, 23);
            this.bBufferWrite.TabIndex = 5;
            this.bBufferWrite.Text = "Write";
            this.bBufferWrite.UseVisualStyleBackColor = true;
            this.bBufferWrite.Click += new System.EventHandler(this.bBufferWrite_Click);
            // 
            // gbSetCursor
            // 
            this.gbSetCursor.Controls.Add(this.bSetCursor);
            this.gbSetCursor.Controls.Add(this.nudSetColumn);
            this.gbSetCursor.Controls.Add(this.nudSetRow);
            this.gbSetCursor.Controls.Add(this.label8);
            this.gbSetCursor.Controls.Add(this.label9);
            this.gbSetCursor.Location = new System.Drawing.Point(5, 100);
            this.gbSetCursor.Name = "gbSetCursor";
            this.gbSetCursor.Size = new System.Drawing.Size(353, 69);
            this.gbSetCursor.TabIndex = 5;
            this.gbSetCursor.TabStop = false;
            this.gbSetCursor.Text = "Set Cursor";
            // 
            // bSetCursor
            // 
            this.bSetCursor.Location = new System.Drawing.Point(303, 24);
            this.bSetCursor.Name = "bSetCursor";
            this.bSetCursor.Size = new System.Drawing.Size(38, 23);
            this.bSetCursor.TabIndex = 5;
            this.bSetCursor.Text = "Set";
            this.bSetCursor.UseVisualStyleBackColor = true;
            this.bSetCursor.Click += new System.EventHandler(this.bSetCursor_Click);
            // 
            // nudSetColumn
            // 
            this.nudSetColumn.Location = new System.Drawing.Point(202, 24);
            this.nudSetColumn.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nudSetColumn.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSetColumn.Name = "nudSetColumn";
            this.nudSetColumn.Size = new System.Drawing.Size(75, 23);
            this.nudSetColumn.TabIndex = 4;
            this.nudSetColumn.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // nudSetRow
            // 
            this.nudSetRow.Location = new System.Drawing.Point(57, 22);
            this.nudSetRow.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nudSetRow.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSetRow.Name = "nudSetRow";
            this.nudSetRow.Size = new System.Drawing.Size(75, 23);
            this.nudSetRow.TabIndex = 4;
            this.nudSetRow.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "Row";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(146, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 15);
            this.label9.TabIndex = 0;
            this.label9.Text = "Column";
            // 
            // ckbBlink
            // 
            this.ckbBlink.AutoSize = true;
            this.ckbBlink.Location = new System.Drawing.Point(377, 271);
            this.ckbBlink.Name = "ckbBlink";
            this.ckbBlink.Size = new System.Drawing.Size(52, 19);
            this.ckbBlink.TabIndex = 12;
            this.ckbBlink.Text = "Blink";
            this.ckbBlink.UseVisualStyleBackColor = true;
            // 
            // tbWrite
            // 
            this.tbWrite.Location = new System.Drawing.Point(12, 185);
            this.tbWrite.Name = "tbWrite";
            this.tbWrite.Size = new System.Drawing.Size(346, 23);
            this.tbWrite.TabIndex = 8;
            // 
            // ckbCursor
            // 
            this.ckbCursor.AutoSize = true;
            this.ckbCursor.Location = new System.Drawing.Point(308, 271);
            this.ckbCursor.Name = "ckbCursor";
            this.ckbCursor.Size = new System.Drawing.Size(61, 19);
            this.ckbCursor.TabIndex = 12;
            this.ckbCursor.Text = "Cursor";
            this.ckbCursor.UseVisualStyleBackColor = true;
            // 
            // bWrite
            // 
            this.bWrite.Location = new System.Drawing.Point(377, 184);
            this.bWrite.Name = "bWrite";
            this.bWrite.Size = new System.Drawing.Size(44, 23);
            this.bWrite.TabIndex = 5;
            this.bWrite.Text = "Write";
            this.bWrite.UseVisualStyleBackColor = true;
            this.bWrite.Click += new System.EventHandler(this.bWrite_Click);
            // 
            // ckbRightToLeft
            // 
            this.ckbRightToLeft.AutoSize = true;
            this.ckbRightToLeft.Location = new System.Drawing.Point(207, 271);
            this.ckbRightToLeft.Name = "ckbRightToLeft";
            this.ckbRightToLeft.Size = new System.Drawing.Size(92, 19);
            this.ckbRightToLeft.TabIndex = 11;
            this.ckbRightToLeft.Text = "Right To Left";
            this.ckbRightToLeft.UseVisualStyleBackColor = true;
            // 
            // bClear
            // 
            this.bClear.Location = new System.Drawing.Point(15, 229);
            this.bClear.Name = "bClear";
            this.bClear.Size = new System.Drawing.Size(75, 23);
            this.bClear.TabIndex = 9;
            this.bClear.Text = "Clear";
            this.bClear.UseVisualStyleBackColor = true;
            this.bClear.Click += new System.EventHandler(this.bClear_Click);
            // 
            // ckbAutoScroll
            // 
            this.ckbAutoScroll.AutoSize = true;
            this.ckbAutoScroll.Location = new System.Drawing.Point(115, 271);
            this.ckbAutoScroll.Name = "ckbAutoScroll";
            this.ckbAutoScroll.Size = new System.Drawing.Size(81, 19);
            this.ckbAutoScroll.TabIndex = 10;
            this.ckbAutoScroll.Text = "AutoScroll";
            this.ckbAutoScroll.UseVisualStyleBackColor = true;
            // 
            // bHome
            // 
            this.bHome.Location = new System.Drawing.Point(98, 229);
            this.bHome.Name = "bHome";
            this.bHome.Size = new System.Drawing.Size(75, 23);
            this.bHome.TabIndex = 9;
            this.bHome.Text = "Home";
            this.bHome.UseVisualStyleBackColor = true;
            this.bHome.Click += new System.EventHandler(this.bHome_Click);
            // 
            // ckbScrollRight
            // 
            this.ckbScrollRight.AutoSize = true;
            this.ckbScrollRight.Location = new System.Drawing.Point(15, 271);
            this.ckbScrollRight.Name = "ckbScrollRight";
            this.ckbScrollRight.Size = new System.Drawing.Size(86, 19);
            this.ckbScrollRight.TabIndex = 10;
            this.ckbScrollRight.Text = "Scroll Right";
            this.ckbScrollRight.UseVisualStyleBackColor = true;
            this.ckbScrollRight.CheckedChanged += new System.EventHandler(this.ckbScrollRight_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.swpdD7);
            this.groupBox2.Controls.Add(this.bConfig);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.nudColumns);
            this.groupBox2.Controls.Add(this.lEPin);
            this.groupBox2.Controls.Add(this.nudRows);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.swpdRS);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.swpdD4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.swpdD5);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.swpdD6);
            this.groupBox2.Controls.Add(this.lRsPin);
            this.groupBox2.Location = new System.Drawing.Point(8, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(452, 133);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // swpdD7
            // 
            this.swpdD7.IncludeNAPin = false;
            this.swpdD7.Location = new System.Drawing.Point(351, 44);
            this.swpdD7.Name = "swpdD7";
            this.swpdD7.Pin = ((byte)(255));
            this.swpdD7.PinType = SerialWombat.SerialWombatPinType.EnhancedPerformanceOutputPin;
            this.swpdD7.Size = new System.Drawing.Size(65, 25);
            this.swpdD7.TabIndex = 2;
            // 
            // bConfig
            // 
            this.bConfig.Location = new System.Drawing.Point(341, 86);
            this.bConfig.Name = "bConfig";
            this.bConfig.Size = new System.Drawing.Size(75, 23);
            this.bConfig.TabIndex = 6;
            this.bConfig.Text = "Configure";
            this.bConfig.UseVisualStyleBackColor = true;
            this.bConfig.Click += new System.EventHandler(this.bConfig_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "E Pin:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Rows:";
            // 
            // nudColumns
            // 
            this.nudColumns.Location = new System.Drawing.Point(221, 86);
            this.nudColumns.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.nudColumns.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudColumns.Name = "nudColumns";
            this.nudColumns.Size = new System.Drawing.Size(75, 23);
            this.nudColumns.TabIndex = 4;
            this.nudColumns.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudColumns.ValueChanged += new System.EventHandler(this.nudColumns_ValueChanged);
            // 
            // lEPin
            // 
            this.lEPin.AutoSize = true;
            this.lEPin.Location = new System.Drawing.Point(15, 33);
            this.lEPin.Name = "lEPin";
            this.lEPin.Size = new System.Drawing.Size(21, 15);
            this.lEPin.TabIndex = 1;
            this.lEPin.Text = "XX";
            // 
            // nudRows
            // 
            this.nudRows.Location = new System.Drawing.Point(67, 86);
            this.nudRows.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nudRows.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudRows.Name = "nudRows";
            this.nudRows.Size = new System.Drawing.Size(75, 23);
            this.nudRows.TabIndex = 4;
            this.nudRows.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudRows.ValueChanged += new System.EventHandler(this.nudRows_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(157, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "Columns:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(351, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "D7 Pin:";
            // 
            // swpdRS
            // 
            this.swpdRS.IncludeNAPin = false;
            this.swpdRS.Location = new System.Drawing.Point(67, 44);
            this.swpdRS.Name = "swpdRS";
            this.swpdRS.Pin = ((byte)(255));
            this.swpdRS.PinType = SerialWombat.SerialWombatPinType.EnhancedPerformanceOutputPin;
            this.swpdRS.Size = new System.Drawing.Size(65, 25);
            this.swpdRS.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(280, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "D6 Pin:";
            // 
            // swpdD4
            // 
            this.swpdD4.IncludeNAPin = false;
            this.swpdD4.Location = new System.Drawing.Point(138, 44);
            this.swpdD4.Name = "swpdD4";
            this.swpdD4.Pin = ((byte)(255));
            this.swpdD4.PinType = SerialWombat.SerialWombatPinType.EnhancedPerformanceOutputPin;
            this.swpdD4.Size = new System.Drawing.Size(65, 25);
            this.swpdD4.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(209, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "D5 Pin:";
            // 
            // swpdD5
            // 
            this.swpdD5.IncludeNAPin = false;
            this.swpdD5.Location = new System.Drawing.Point(209, 44);
            this.swpdD5.Name = "swpdD5";
            this.swpdD5.Pin = ((byte)(255));
            this.swpdD5.PinType = SerialWombat.SerialWombatPinType.EnhancedPerformanceOutputPin;
            this.swpdD5.Size = new System.Drawing.Size(65, 25);
            this.swpdD5.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "D4 Pin:";
            // 
            // swpdD6
            // 
            this.swpdD6.IncludeNAPin = false;
            this.swpdD6.Location = new System.Drawing.Point(280, 44);
            this.swpdD6.Name = "swpdD6";
            this.swpdD6.Pin = ((byte)(255));
            this.swpdD6.PinType = SerialWombat.SerialWombatPinType.EnhancedPerformanceOutputPin;
            this.swpdD6.Size = new System.Drawing.Size(65, 25);
            this.swpdD6.TabIndex = 2;
            // 
            // lRsPin
            // 
            this.lRsPin.AutoSize = true;
            this.lRsPin.Location = new System.Drawing.Point(67, 18);
            this.lRsPin.Name = "lRsPin";
            this.lRsPin.Size = new System.Drawing.Size(43, 15);
            this.lRsPin.TabIndex = 3;
            this.lRsPin.Text = "RS Pin:";
            // 
            // LiquidCrystalControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "LiquidCrystalControl";
            this.Size = new System.Drawing.Size(761, 626);
            this.groupBox1.ResumeLayout(false);
            this.gbControls.ResumeLayout(false);
            this.gbControls.PerformLayout();
            this.gbCharacterBitmap.ResumeLayout(false);
            this.gbCharacterBitmap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCharIndex)).EndInit();
            this.gbRowOffsets.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudRO4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRO3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRO2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRO1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.gbSetCursor.ResumeLayout(false);
            this.gbSetCursor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSetColumn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSetRow)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudColumns)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRows)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lEPin;
        private System.Windows.Forms.Label label1;
        private SerialWombatPinDropdown swpdRS;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lRsPin;
        private SerialWombatPinDropdown swpdD7;
        private SerialWombatPinDropdown swpdD6;
        private SerialWombatPinDropdown swpdD5;
        private SerialWombatPinDropdown swpdD4;
        private System.Windows.Forms.CheckBox ckbAutoScroll;
        private System.Windows.Forms.CheckBox ckbScrollRight;
        private System.Windows.Forms.Button bHome;
        private System.Windows.Forms.Button bClear;
        private System.Windows.Forms.Button bWrite;
        private System.Windows.Forms.TextBox tbWrite;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bConfig;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudColumns;
        private System.Windows.Forms.NumericUpDown nudRows;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox gbSetCursor;
        private System.Windows.Forms.Button bSetCursor;
        private System.Windows.Forms.NumericUpDown nudSetColumn;
        private System.Windows.Forms.NumericUpDown nudSetRow;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox gbRowOffsets;
        private System.Windows.Forms.Button bSetRowOffsets;
        private System.Windows.Forms.NumericUpDown nudRO4;
        private System.Windows.Forms.NumericUpDown nudRO3;
        private System.Windows.Forms.NumericUpDown nudRO2;
        private System.Windows.Forms.NumericUpDown nudRO1;
        private System.Windows.Forms.GroupBox gbControls;
        private System.Windows.Forms.CheckBox ckbDisplayOff;
        private System.Windows.Forms.CheckBox ckbBlink;
        private System.Windows.Forms.CheckBox ckbCursor;
        private System.Windows.Forms.CheckBox ckbRightToLeft;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button bSetBufferIndex;
        private System.Windows.Forms.Label label10;
        private SixteenBitAddressControl sbacBufferIndex;
        private System.Windows.Forms.TextBox tbBuffer;
        private System.Windows.Forms.Button bBufferWrite;
        private System.Windows.Forms.GroupBox gbCharacterBitmap;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown nudCharIndex;
        private System.Windows.Forms.Button bCharWrite;
    }
}
