namespace SerialWombatWindowsFormsLibrary.Controls
{
    partial class DataLoggerControl
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
            this.DataLogger = new System.Windows.Forms.GroupBox();
            this.gbInitialization = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bInitialize = new System.Windows.Forms.Button();
            this.serialWombatPinDropdown1 = new SerialWombatWindowsFormsLibrary.SerialWombatPinDropdown();
            this.sbacLen = new SerialWombatWindowsFormsLibrary.SixteenBitAddressControl();
            this.bAddPin = new System.Windows.Forms.Button();
            this.sbacAddress = new SerialWombatWindowsFormsLibrary.SixteenBitAddressControl();
            this.ckbQueueFrameNumber = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ckbLowByte = new System.Windows.Forms.CheckBox();
            this.edQueueingPeriod = new SerialWombatWindowsFormsLibrary.EnumDropdown();
            this.ckbQueueHighByte = new System.Windows.Forms.CheckBox();
            this.ckbQueueOnChange = new System.Windows.Forms.CheckBox();
            this.ckbQueueing = new System.Windows.Forms.CheckBox();
            this.bReadAll = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.DataLogger.SuspendLayout();
            this.gbInitialization.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataLogger
            // 
            this.DataLogger.AutoSize = true;
            this.DataLogger.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DataLogger.Controls.Add(this.gbInitialization);
            this.DataLogger.Controls.Add(this.ckbQueueing);
            this.DataLogger.Controls.Add(this.bReadAll);
            this.DataLogger.Controls.Add(this.textBox1);
            this.DataLogger.Location = new System.Drawing.Point(9, 8);
            this.DataLogger.Name = "DataLogger";
            this.DataLogger.Size = new System.Drawing.Size(483, 528);
            this.DataLogger.TabIndex = 2;
            this.DataLogger.TabStop = false;
            this.DataLogger.Text = "DataLogger";
            // 
            // gbInitialization
            // 
            this.gbInitialization.Controls.Add(this.button1);
            this.gbInitialization.Controls.Add(this.button4);
            this.gbInitialization.Controls.Add(this.label1);
            this.gbInitialization.Controls.Add(this.label2);
            this.gbInitialization.Controls.Add(this.bInitialize);
            this.gbInitialization.Controls.Add(this.serialWombatPinDropdown1);
            this.gbInitialization.Controls.Add(this.sbacLen);
            this.gbInitialization.Controls.Add(this.bAddPin);
            this.gbInitialization.Controls.Add(this.sbacAddress);
            this.gbInitialization.Controls.Add(this.ckbQueueFrameNumber);
            this.gbInitialization.Controls.Add(this.label9);
            this.gbInitialization.Controls.Add(this.ckbLowByte);
            this.gbInitialization.Controls.Add(this.edQueueingPeriod);
            this.gbInitialization.Controls.Add(this.ckbQueueHighByte);
            this.gbInitialization.Controls.Add(this.ckbQueueOnChange);
            this.gbInitialization.Location = new System.Drawing.Point(6, 18);
            this.gbInitialization.Name = "gbInitialization";
            this.gbInitialization.Size = new System.Drawing.Size(471, 260);
            this.gbInitialization.TabIndex = 30;
            this.gbInitialization.TabStop = false;
            this.gbInitialization.Text = "gbInitialization";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumPurple;
            this.button1.Location = new System.Drawing.Point(420, 207);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 47);
            this.button1.TabIndex = 32;
            this.button1.Text = "Gen Code";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.MediumPurple;
            this.button4.Location = new System.Drawing.Point(143, 128);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(45, 47);
            this.button4.TabIndex = 31;
            this.button4.Text = "Gen Code";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(174, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Length (bytes)";
            // 
            // bInitialize
            // 
            this.bInitialize.Location = new System.Drawing.Point(47, 145);
            this.bInitialize.Name = "bInitialize";
            this.bInitialize.Size = new System.Drawing.Size(75, 23);
            this.bInitialize.TabIndex = 2;
            this.bInitialize.Text = "Initialize";
            this.bInitialize.UseVisualStyleBackColor = true;
            this.bInitialize.Click += new System.EventHandler(this.bInitialize_Click);
            // 
            // serialWombatPinDropdown1
            // 
            this.serialWombatPinDropdown1.IncludeNAPin = false;
            this.serialWombatPinDropdown1.Location = new System.Drawing.Point(47, 190);
            this.serialWombatPinDropdown1.Name = "serialWombatPinDropdown1";
            this.serialWombatPinDropdown1.Pin = ((byte)(255));
            this.serialWombatPinDropdown1.PinType = SerialWombat.SerialWombatPinType.SerialWombatPin;
            this.serialWombatPinDropdown1.Size = new System.Drawing.Size(65, 25);
            this.serialWombatPinDropdown1.TabIndex = 27;
            this.toolTip1.SetToolTip(this.serialWombatPinDropdown1, "Pin to queue");
            // 
            // sbacLen
            // 
            this.sbacLen.AutoSize = true;
            this.sbacLen.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.sbacLen.Location = new System.Drawing.Point(186, 37);
            this.sbacLen.Name = "sbacLen";
            this.sbacLen.Size = new System.Drawing.Size(56, 26);
            this.sbacLen.TabIndex = 5;
            this.toolTip1.SetToolTip(this.sbacLen, "Number of bytes of queue storage to allocate");
            this.sbacLen.Value = ((ushort)(0));
            // 
            // bAddPin
            // 
            this.bAddPin.Enabled = false;
            this.bAddPin.Location = new System.Drawing.Point(326, 187);
            this.bAddPin.Name = "bAddPin";
            this.bAddPin.Size = new System.Drawing.Size(75, 23);
            this.bAddPin.TabIndex = 26;
            this.bAddPin.Text = "Add Pin";
            this.toolTip1.SetToolTip(this.bAddPin, "Add pin to queued list (multiple can be queued)");
            this.bAddPin.UseVisualStyleBackColor = true;
            this.bAddPin.Click += new System.EventHandler(this.bAddPin_Click);
            // 
            // sbacAddress
            // 
            this.sbacAddress.AutoSize = true;
            this.sbacAddress.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.sbacAddress.Location = new System.Drawing.Point(71, 37);
            this.sbacAddress.Name = "sbacAddress";
            this.sbacAddress.Size = new System.Drawing.Size(56, 26);
            this.sbacAddress.TabIndex = 6;
            this.toolTip1.SetToolTip(this.sbacAddress, "Index in User Ram of beginning of Queue");
            this.sbacAddress.Value = ((ushort)(0));
            // 
            // ckbQueueFrameNumber
            // 
            this.ckbQueueFrameNumber.AutoSize = true;
            this.ckbQueueFrameNumber.Location = new System.Drawing.Point(174, 103);
            this.ckbQueueFrameNumber.Name = "ckbQueueFrameNumber";
            this.ckbQueueFrameNumber.Size = new System.Drawing.Size(144, 19);
            this.ckbQueueFrameNumber.TabIndex = 25;
            this.ckbQueueFrameNumber.Text = "Queue Frame Number";
            this.toolTip1.SetToolTip(this.ckbQueueFrameNumber, "Queue 1ms Frame number before data");
            this.ckbQueueFrameNumber.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(34, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 15);
            this.label9.TabIndex = 24;
            this.label9.Text = "Queue Sample Rate:";
            // 
            // ckbLowByte
            // 
            this.ckbLowByte.AutoSize = true;
            this.ckbLowByte.Location = new System.Drawing.Point(203, 190);
            this.ckbLowByte.Name = "ckbLowByte";
            this.ckbLowByte.Size = new System.Drawing.Size(74, 19);
            this.ckbLowByte.TabIndex = 25;
            this.ckbLowByte.Text = "Low Byte";
            this.toolTip1.SetToolTip(this.ckbLowByte, "Queue Low Byte of public data");
            this.ckbLowByte.UseVisualStyleBackColor = true;
            this.ckbLowByte.CheckedChanged += new System.EventHandler(this.ckbQueueOnChange_CheckedChanged);
            // 
            // edQueueingPeriod
            // 
            this.edQueueingPeriod.DropDownToolTip = "";
            this.edQueueingPeriod.dropdowntype = "SerialWombatClassLibrary.SerialWombat.DataLoggerPeriod";
            this.edQueueingPeriod.Location = new System.Drawing.Point(164, 65);
            this.edQueueingPeriod.Name = "edQueueingPeriod";
            this.edQueueingPeriod.Size = new System.Drawing.Size(274, 35);
            this.edQueueingPeriod.TabIndex = 23;
            this.toolTip1.SetToolTip(this.edQueueingPeriod, "Rate at which data will be queued");
            this.edQueueingPeriod.Value = 0;
            // 
            // ckbQueueHighByte
            // 
            this.ckbQueueHighByte.AutoSize = true;
            this.ckbQueueHighByte.Location = new System.Drawing.Point(119, 190);
            this.ckbQueueHighByte.Name = "ckbQueueHighByte";
            this.ckbQueueHighByte.Size = new System.Drawing.Size(78, 19);
            this.ckbQueueHighByte.TabIndex = 25;
            this.ckbQueueHighByte.Text = "High Byte";
            this.toolTip1.SetToolTip(this.ckbQueueHighByte, "Queue High Byte of public data");
            this.ckbQueueHighByte.UseVisualStyleBackColor = true;
            this.ckbQueueHighByte.CheckedChanged += new System.EventHandler(this.ckbQueueOnChange_CheckedChanged);
            // 
            // ckbQueueOnChange
            // 
            this.ckbQueueOnChange.AutoSize = true;
            this.ckbQueueOnChange.Location = new System.Drawing.Point(44, 103);
            this.ckbQueueOnChange.Name = "ckbQueueOnChange";
            this.ckbQueueOnChange.Size = new System.Drawing.Size(118, 19);
            this.ckbQueueOnChange.TabIndex = 25;
            this.ckbQueueOnChange.Text = "QueueOnChange";
            this.toolTip1.SetToolTip(this.ckbQueueOnChange, "Queue on change of pins rather than time");
            this.ckbQueueOnChange.UseVisualStyleBackColor = true;
            this.ckbQueueOnChange.CheckedChanged += new System.EventHandler(this.ckbQueueOnChange_CheckedChanged);
            // 
            // ckbQueueing
            // 
            this.ckbQueueing.AutoSize = true;
            this.ckbQueueing.Location = new System.Drawing.Point(135, 284);
            this.ckbQueueing.Name = "ckbQueueing";
            this.ckbQueueing.Size = new System.Drawing.Size(135, 19);
            this.ckbQueueing.TabIndex = 29;
            this.ckbQueueing.Text = "Data Logger Enabled";
            this.ckbQueueing.UseVisualStyleBackColor = true;
            this.ckbQueueing.CheckedChanged += new System.EventHandler(this.ckbQueueing_CheckedChanged);
            // 
            // bReadAll
            // 
            this.bReadAll.Location = new System.Drawing.Point(23, 284);
            this.bReadAll.Name = "bReadAll";
            this.bReadAll.Size = new System.Drawing.Size(75, 23);
            this.bReadAll.TabIndex = 4;
            this.bReadAll.Text = "ReadAll";
            this.bReadAll.UseVisualStyleBackColor = true;
            this.bReadAll.Click += new System.EventHandler(this.bReadAll_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 323);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(401, 183);
            this.textBox1.TabIndex = 3;
            // 
            // DataLoggerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.DataLogger);
            this.Name = "DataLoggerControl";
            this.Size = new System.Drawing.Size(495, 539);
            this.DataLogger.ResumeLayout(false);
            this.DataLogger.PerformLayout();
            this.gbInitialization.ResumeLayout(false);
            this.gbInitialization.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox DataLogger;
        private SixteenBitAddressControl sbacAddress;
        private SixteenBitAddressControl sbacLen;
        private System.Windows.Forms.Button bReadAll;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button bInitialize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private EnumDropdown edQueueingPeriod;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox ckbQueueFrameNumber;
        private System.Windows.Forms.CheckBox ckbQueueOnChange;
        private System.Windows.Forms.GroupBox gbInitialization;
        private SerialWombatPinDropdown serialWombatPinDropdown1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button bAddPin;
        private System.Windows.Forms.CheckBox ckbLowByte;
        private System.Windows.Forms.CheckBox ckbQueueHighByte;
        private System.Windows.Forms.CheckBox ckbQueueing;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
    }
}
