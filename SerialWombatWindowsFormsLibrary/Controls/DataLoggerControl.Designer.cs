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
            components = new System.ComponentModel.Container();
            DataLogger = new System.Windows.Forms.GroupBox();
            bGenEnable = new System.Windows.Forms.Button();
            gbInitialization = new System.Windows.Forms.GroupBox();
            button1 = new System.Windows.Forms.Button();
            button4 = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            bInitialize = new System.Windows.Forms.Button();
            serialWombatPinDropdown1 = new SerialWombatPinDropdown();
            sbacLen = new SixteenBitAddressControl();
            bAddPin = new System.Windows.Forms.Button();
            sbacAddress = new SixteenBitAddressControl();
            ckbQueueFrameNumber = new System.Windows.Forms.CheckBox();
            label9 = new System.Windows.Forms.Label();
            ckbLowByte = new System.Windows.Forms.CheckBox();
            edQueueingPeriod = new EnumDropdown();
            ckbQueueHighByte = new System.Windows.Forms.CheckBox();
            ckbQueueOnChange = new System.Windows.Forms.CheckBox();
            ckbQueueing = new System.Windows.Forms.CheckBox();
            bReadAll = new System.Windows.Forms.Button();
            textBox1 = new System.Windows.Forms.TextBox();
            toolTip1 = new System.Windows.Forms.ToolTip(components);
            DataLogger.SuspendLayout();
            gbInitialization.SuspendLayout();
            SuspendLayout();
            // 
            // DataLogger
            // 
            DataLogger.AutoSize = true;
            DataLogger.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            DataLogger.Controls.Add(bGenEnable);
            DataLogger.Controls.Add(gbInitialization);
            DataLogger.Controls.Add(ckbQueueing);
            DataLogger.Controls.Add(bReadAll);
            DataLogger.Controls.Add(textBox1);
            DataLogger.Location = new System.Drawing.Point(9, 8);
            DataLogger.Name = "DataLogger";
            DataLogger.Size = new System.Drawing.Size(483, 528);
            DataLogger.TabIndex = 2;
            DataLogger.TabStop = false;
            DataLogger.Text = "DataLogger";
            // 
            // bGenEnable
            // 
            bGenEnable.BackColor = System.Drawing.Color.MediumPurple;
            bGenEnable.Location = new System.Drawing.Point(307, 284);
            bGenEnable.Name = "bGenEnable";
            bGenEnable.Size = new System.Drawing.Size(114, 35);
            bGenEnable.TabIndex = 33;
            bGenEnable.Text = "Gen Enable Code";
            bGenEnable.UseVisualStyleBackColor = false;
            bGenEnable.Click += button2_Click;
            // 
            // gbInitialization
            // 
            gbInitialization.Controls.Add(button1);
            gbInitialization.Controls.Add(button4);
            gbInitialization.Controls.Add(label1);
            gbInitialization.Controls.Add(label2);
            gbInitialization.Controls.Add(bInitialize);
            gbInitialization.Controls.Add(serialWombatPinDropdown1);
            gbInitialization.Controls.Add(sbacLen);
            gbInitialization.Controls.Add(bAddPin);
            gbInitialization.Controls.Add(sbacAddress);
            gbInitialization.Controls.Add(ckbQueueFrameNumber);
            gbInitialization.Controls.Add(label9);
            gbInitialization.Controls.Add(ckbLowByte);
            gbInitialization.Controls.Add(edQueueingPeriod);
            gbInitialization.Controls.Add(ckbQueueHighByte);
            gbInitialization.Controls.Add(ckbQueueOnChange);
            gbInitialization.Location = new System.Drawing.Point(6, 18);
            gbInitialization.Name = "gbInitialization";
            gbInitialization.Size = new System.Drawing.Size(471, 260);
            gbInitialization.TabIndex = 30;
            gbInitialization.TabStop = false;
            gbInitialization.Text = "gbInitialization";
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.Color.MediumPurple;
            button1.Location = new System.Drawing.Point(420, 207);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(45, 47);
            button1.TabIndex = 32;
            button1.Text = "Gen Code";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button4_Click;
            // 
            // button4
            // 
            button4.BackColor = System.Drawing.Color.MediumPurple;
            button4.Location = new System.Drawing.Point(143, 128);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(45, 47);
            button4.TabIndex = 31;
            button4.Text = "Gen Code";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(68, 19);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(49, 15);
            label1.TabIndex = 1;
            label1.Text = "Address";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(174, 19);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(83, 15);
            label2.TabIndex = 1;
            label2.Text = "Length (bytes)";
            // 
            // bInitialize
            // 
            bInitialize.Location = new System.Drawing.Point(47, 145);
            bInitialize.Name = "bInitialize";
            bInitialize.Size = new System.Drawing.Size(75, 23);
            bInitialize.TabIndex = 2;
            bInitialize.Text = "Initialize";
            bInitialize.UseVisualStyleBackColor = true;
            bInitialize.Click += bInitialize_Click;
            // 
            // serialWombatPinDropdown1
            // 
            serialWombatPinDropdown1.IncludeNAPin = false;
            serialWombatPinDropdown1.Location = new System.Drawing.Point(47, 190);
            serialWombatPinDropdown1.Name = "serialWombatPinDropdown1";
            serialWombatPinDropdown1.Pin = 255;
            serialWombatPinDropdown1.PinType = SerialWombat.SerialWombatPinType.SerialWombatPin;
            serialWombatPinDropdown1.Size = new System.Drawing.Size(65, 25);
            serialWombatPinDropdown1.TabIndex = 27;
            toolTip1.SetToolTip(serialWombatPinDropdown1, "Pin to queue");
            // 
            // sbacLen
            // 
            sbacLen.AutoSize = true;
            sbacLen.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            sbacLen.Location = new System.Drawing.Point(186, 37);
            sbacLen.Name = "sbacLen";
            sbacLen.Size = new System.Drawing.Size(56, 26);
            sbacLen.TabIndex = 5;
            toolTip1.SetToolTip(sbacLen, "Number of bytes of queue storage to allocate");
            sbacLen.Value = (ushort)0;
            // 
            // bAddPin
            // 
            bAddPin.Enabled = false;
            bAddPin.Location = new System.Drawing.Point(326, 187);
            bAddPin.Name = "bAddPin";
            bAddPin.Size = new System.Drawing.Size(75, 23);
            bAddPin.TabIndex = 26;
            bAddPin.Text = "Add Pin";
            toolTip1.SetToolTip(bAddPin, "Add pin to queued list (multiple can be queued)");
            bAddPin.UseVisualStyleBackColor = true;
            bAddPin.Click += bAddPin_Click;
            // 
            // sbacAddress
            // 
            sbacAddress.AutoSize = true;
            sbacAddress.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            sbacAddress.Location = new System.Drawing.Point(71, 37);
            sbacAddress.Name = "sbacAddress";
            sbacAddress.Size = new System.Drawing.Size(56, 26);
            sbacAddress.TabIndex = 6;
            toolTip1.SetToolTip(sbacAddress, "Index in User Ram of beginning of Queue");
            sbacAddress.Value = (ushort)0;
            // 
            // ckbQueueFrameNumber
            // 
            ckbQueueFrameNumber.AutoSize = true;
            ckbQueueFrameNumber.Location = new System.Drawing.Point(174, 103);
            ckbQueueFrameNumber.Name = "ckbQueueFrameNumber";
            ckbQueueFrameNumber.Size = new System.Drawing.Size(144, 19);
            ckbQueueFrameNumber.TabIndex = 25;
            ckbQueueFrameNumber.Text = "Queue Frame Number";
            toolTip1.SetToolTip(ckbQueueFrameNumber, "Queue 1ms Frame number before data");
            ckbQueueFrameNumber.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(34, 74);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(113, 15);
            label9.TabIndex = 24;
            label9.Text = "Queue Sample Rate:";
            // 
            // ckbLowByte
            // 
            ckbLowByte.AutoSize = true;
            ckbLowByte.Location = new System.Drawing.Point(203, 190);
            ckbLowByte.Name = "ckbLowByte";
            ckbLowByte.Size = new System.Drawing.Size(74, 19);
            ckbLowByte.TabIndex = 25;
            ckbLowByte.Text = "Low Byte";
            toolTip1.SetToolTip(ckbLowByte, "Queue Low Byte of public data");
            ckbLowByte.UseVisualStyleBackColor = true;
            ckbLowByte.CheckedChanged += ckbQueueOnChange_CheckedChanged;
            // 
            // edQueueingPeriod
            // 
            edQueueingPeriod.DropDownToolTip = "";
            edQueueingPeriod.dropdowntype = "SerialWombatClassLibrary.SerialWombat.DataLoggerPeriod";
            edQueueingPeriod.Location = new System.Drawing.Point(164, 65);
            edQueueingPeriod.Name = "edQueueingPeriod";
            edQueueingPeriod.Size = new System.Drawing.Size(274, 35);
            edQueueingPeriod.TabIndex = 23;
            toolTip1.SetToolTip(edQueueingPeriod, "Rate at which data will be queued");
            edQueueingPeriod.Value = 0;
            // 
            // ckbQueueHighByte
            // 
            ckbQueueHighByte.AutoSize = true;
            ckbQueueHighByte.Location = new System.Drawing.Point(119, 190);
            ckbQueueHighByte.Name = "ckbQueueHighByte";
            ckbQueueHighByte.Size = new System.Drawing.Size(78, 19);
            ckbQueueHighByte.TabIndex = 25;
            ckbQueueHighByte.Text = "High Byte";
            toolTip1.SetToolTip(ckbQueueHighByte, "Queue High Byte of public data");
            ckbQueueHighByte.UseVisualStyleBackColor = true;
            ckbQueueHighByte.CheckedChanged += ckbQueueOnChange_CheckedChanged;
            // 
            // ckbQueueOnChange
            // 
            ckbQueueOnChange.AutoSize = true;
            ckbQueueOnChange.Location = new System.Drawing.Point(44, 103);
            ckbQueueOnChange.Name = "ckbQueueOnChange";
            ckbQueueOnChange.Size = new System.Drawing.Size(118, 19);
            ckbQueueOnChange.TabIndex = 25;
            ckbQueueOnChange.Text = "QueueOnChange";
            toolTip1.SetToolTip(ckbQueueOnChange, "Queue on change of pins rather than time");
            ckbQueueOnChange.UseVisualStyleBackColor = true;
            ckbQueueOnChange.CheckedChanged += ckbQueueOnChange_CheckedChanged;
            // 
            // ckbQueueing
            // 
            ckbQueueing.AutoSize = true;
            ckbQueueing.Location = new System.Drawing.Point(135, 284);
            ckbQueueing.Name = "ckbQueueing";
            ckbQueueing.Size = new System.Drawing.Size(135, 19);
            ckbQueueing.TabIndex = 29;
            ckbQueueing.Text = "Data Logger Enabled";
            ckbQueueing.UseVisualStyleBackColor = true;
            ckbQueueing.CheckedChanged += ckbQueueing_CheckedChanged;
            // 
            // bReadAll
            // 
            bReadAll.Location = new System.Drawing.Point(23, 284);
            bReadAll.Name = "bReadAll";
            bReadAll.Size = new System.Drawing.Size(75, 23);
            bReadAll.TabIndex = 4;
            bReadAll.Text = "ReadAll";
            bReadAll.UseVisualStyleBackColor = true;
            bReadAll.Click += bReadAll_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(6, 323);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            textBox1.Size = new System.Drawing.Size(401, 183);
            textBox1.TabIndex = 3;
            // 
            // DataLoggerControl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            Controls.Add(DataLogger);
            Name = "DataLoggerControl";
            Size = new System.Drawing.Size(495, 539);
            DataLogger.ResumeLayout(false);
            DataLogger.PerformLayout();
            gbInitialization.ResumeLayout(false);
            gbInitialization.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private System.Windows.Forms.Button bGenEnable;
    }
}
