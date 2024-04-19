namespace SerialWombatWindowsFormsLibrary.Controls
{
    partial class QueuedPulseOutputControl
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
            this.gbQueue = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.bQueue = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.sbsi2nd = new SerialWombatWindowsFormsLibrary.SixteenBitSliderInput();
            this.sbsi1st = new SerialWombatWindowsFormsLibrary.SixteenBitSliderInput();
            this.ckbPause = new System.Windows.Forms.CheckBox();
            this.phli2nd = new SerialWombatWindowsFormsLibrary.Controls.PinHighLowInputControl();
            this.phli1st = new SerialWombatWindowsFormsLibrary.Controls.PinHighLowInputControl();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bGenConfigCode = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rbus = new System.Windows.Forms.RadioButton();
            this.rbms = new System.Windows.Forms.RadioButton();
            this.bConfigure = new System.Windows.Forms.Button();
            this.phliInit = new SerialWombatWindowsFormsLibrary.Controls.PinHighLowInputControl();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbEntries = new System.Windows.Forms.TextBox();
            this.sbacIndex = new SerialWombatWindowsFormsLibrary.SixteenBitAddressControl();
            this.rbUserRam = new System.Windows.Forms.RadioButton();
            this.rbPinMemory = new System.Windows.Forms.RadioButton();
            this.phliIdle = new SerialWombatWindowsFormsLibrary.Controls.PinHighLowInputControl();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.gbQueue.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbQueue
            // 
            this.gbQueue.Controls.Add(this.groupBox5);
            this.gbQueue.Controls.Add(this.groupBox3);
            this.gbQueue.Location = new System.Drawing.Point(0, 3);
            this.gbQueue.Name = "gbQueue";
            this.gbQueue.Size = new System.Drawing.Size(302, 499);
            this.gbQueue.TabIndex = 0;
            this.gbQueue.TabStop = false;
            this.gbQueue.Text = "groupBox1";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.bQueue);
            this.groupBox5.Controls.Add(this.button3);
            this.groupBox5.Controls.Add(this.button1);
            this.groupBox5.Controls.Add(this.sbsi2nd);
            this.groupBox5.Controls.Add(this.sbsi1st);
            this.groupBox5.Controls.Add(this.ckbPause);
            this.groupBox5.Controls.Add(this.phli2nd);
            this.groupBox5.Controls.Add(this.phli1st);
            this.groupBox5.Enabled = false;
            this.groupBox5.Location = new System.Drawing.Point(6, 299);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(276, 194);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Queue";
            // 
            // bQueue
            // 
            this.bQueue.Location = new System.Drawing.Point(166, 158);
            this.bQueue.Name = "bQueue";
            this.bQueue.Size = new System.Drawing.Size(54, 23);
            this.bQueue.TabIndex = 32;
            this.bQueue.Text = "Queue";
            this.bQueue.UseVisualStyleBackColor = true;
            this.bQueue.Click += new System.EventHandler(this.bQueue_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.MediumPurple;
            this.button3.Location = new System.Drawing.Point(76, 11);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(52, 41);
            this.button3.TabIndex = 31;
            this.button3.TabStop = false;
            this.button3.Text = "Gen Code";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumPurple;
            this.button1.Location = new System.Drawing.Point(224, 147);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(52, 41);
            this.button1.TabIndex = 31;
            this.button1.TabStop = false;
            this.button1.Text = "Gen Code";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // sbsi2nd
            // 
            this.sbsi2nd.Location = new System.Drawing.Point(0, 118);
            this.sbsi2nd.Maximum = 32767;
            this.sbsi2nd.Minimum = 0;
            this.sbsi2nd.Name = "sbsi2nd";
            this.sbsi2nd.Size = new System.Drawing.Size(160, 76);
            this.sbsi2nd.TabIndex = 1;
            this.sbsi2nd.Text = "2nd Entry";
            this.sbsi2nd.TextBoxHint = "";
            this.sbsi2nd.value = ((ushort)(0));
            // 
            // sbsi1st
            // 
            this.sbsi1st.Location = new System.Drawing.Point(0, 48);
            this.sbsi1st.Maximum = 32767;
            this.sbsi1st.Minimum = 0;
            this.sbsi1st.Name = "sbsi1st";
            this.sbsi1st.Size = new System.Drawing.Size(160, 76);
            this.sbsi1st.TabIndex = 1;
            this.sbsi1st.Text = "1st Entry";
            this.sbsi1st.TextBoxHint = "";
            this.sbsi1st.value = ((ushort)(0));
            // 
            // ckbPause
            // 
            this.ckbPause.AutoSize = true;
            this.ckbPause.Location = new System.Drawing.Point(13, 23);
            this.ckbPause.Name = "ckbPause";
            this.ckbPause.Size = new System.Drawing.Size(57, 19);
            this.ckbPause.TabIndex = 0;
            this.ckbPause.Text = "Pause";
            this.ckbPause.UseVisualStyleBackColor = true;
            this.ckbPause.CheckedChanged += new System.EventHandler(this.ckbPause_CheckedChanged);
            // 
            // phli2nd
            // 
            this.phli2nd.AutoSize = true;
            this.phli2nd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.phli2nd.inputOption = false;
            this.phli2nd.Location = new System.Drawing.Point(166, 109);
            this.phli2nd.Name = "phli2nd";
            this.phli2nd.Size = new System.Drawing.Size(63, 43);
            this.phli2nd.TabIndex = 0;
            this.phli2nd.Text = "";
            this.phli2nd.Value = ((byte)(0));
            // 
            // phli1st
            // 
            this.phli1st.AutoSize = true;
            this.phli1st.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.phli1st.inputOption = false;
            this.phli1st.Location = new System.Drawing.Point(166, 48);
            this.phli1st.Name = "phli1st";
            this.phli1st.Size = new System.Drawing.Size(63, 43);
            this.phli1st.TabIndex = 0;
            this.phli1st.Text = "";
            this.phli1st.Value = ((byte)(1));
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.bGenConfigCode);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.bConfigure);
            this.groupBox3.Controls.Add(this.phliInit);
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Controls.Add(this.phliIdle);
            this.groupBox3.Location = new System.Drawing.Point(6, 22);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(276, 271);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Configure";
            // 
            // bGenConfigCode
            // 
            this.bGenConfigCode.BackColor = System.Drawing.Color.MediumPurple;
            this.bGenConfigCode.Location = new System.Drawing.Point(132, 235);
            this.bGenConfigCode.Name = "bGenConfigCode";
            this.bGenConfigCode.Size = new System.Drawing.Size(73, 27);
            this.bGenConfigCode.TabIndex = 31;
            this.bGenConfigCode.TabStop = false;
            this.bGenConfigCode.Text = "Gen Code";
            this.toolTip1.SetToolTip(this.bGenConfigCode, "Generate Configuration Code");
            this.bGenConfigCode.UseVisualStyleBackColor = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rbus);
            this.groupBox4.Controls.Add(this.rbms);
            this.groupBox4.Location = new System.Drawing.Point(6, 184);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 45);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Units";
            // 
            // rbus
            // 
            this.rbus.AutoSize = true;
            this.rbus.Location = new System.Drawing.Point(100, 22);
            this.rbus.Name = "rbus";
            this.rbus.Size = new System.Drawing.Size(99, 19);
            this.rbus.TabIndex = 1;
            this.rbus.Text = "Microseconds";
            this.toolTip1.SetToolTip(this.rbus, "Entries are in microseconds.  Output on SW18AB is in multiples of 17uS");
            this.rbus.UseVisualStyleBackColor = true;
            // 
            // rbms
            // 
            this.rbms.AutoSize = true;
            this.rbms.Checked = true;
            this.rbms.Location = new System.Drawing.Point(6, 22);
            this.rbms.Name = "rbms";
            this.rbms.Size = new System.Drawing.Size(90, 22);
            this.rbms.TabIndex = 0;
            this.rbms.TabStop = true;
            this.rbms.Text = "Milliseconds";
            this.toolTip1.SetToolTip(this.rbms, "Entries are milliseconds");
            this.rbms.UseCompatibleTextRendering = true;
            this.rbms.UseVisualStyleBackColor = true;
            // 
            // bConfigure
            // 
            this.bConfigure.Location = new System.Drawing.Point(13, 237);
            this.bConfigure.Name = "bConfigure";
            this.bConfigure.Size = new System.Drawing.Size(75, 23);
            this.bConfigure.TabIndex = 2;
            this.bConfigure.Text = "Configure";
            this.toolTip1.SetToolTip(this.bConfigure, "Configure the pin mode");
            this.bConfigure.UseVisualStyleBackColor = true;
            this.bConfigure.Click += new System.EventHandler(this.bConfigure_Click);
            // 
            // phliInit
            // 
            this.phliInit.AutoSize = true;
            this.phliInit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.phliInit.inputOption = false;
            this.phliInit.Location = new System.Drawing.Point(6, 22);
            this.phliInit.Name = "phliInit";
            this.phliInit.Size = new System.Drawing.Size(73, 43);
            this.phliInit.TabIndex = 0;
            this.phliInit.Text = "Initial State";
            this.toolTip1.SetToolTip(this.phliInit, "State after Begin Call");
            this.phliInit.Value = ((byte)(0));
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.tbEntries);
            this.groupBox2.Controls.Add(this.sbacIndex);
            this.groupBox2.Controls.Add(this.rbUserRam);
            this.groupBox2.Controls.Add(this.rbPinMemory);
            this.groupBox2.Location = new System.Drawing.Point(6, 71);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 107);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Queue Location";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Entries:";
            // 
            // tbEntries
            // 
            this.tbEntries.Location = new System.Drawing.Point(94, 75);
            this.tbEntries.Name = "tbEntries";
            this.tbEntries.Size = new System.Drawing.Size(100, 23);
            this.tbEntries.TabIndex = 3;
            this.tbEntries.Text = "16";
            this.toolTip1.SetToolTip(this.tbEntries, "Entries.  Memory used will be Entries * 2 + 8");
            // 
            // sbacIndex
            // 
            this.sbacIndex.AutoSize = true;
            this.sbacIndex.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.sbacIndex.Location = new System.Drawing.Point(17, 75);
            this.sbacIndex.Name = "sbacIndex";
            this.sbacIndex.Size = new System.Drawing.Size(56, 26);
            this.sbacIndex.TabIndex = 2;
            this.toolTip1.SetToolTip(this.sbacIndex, "Start Index");
            this.sbacIndex.Value = ((ushort)(0));
            // 
            // rbUserRam
            // 
            this.rbUserRam.AutoSize = true;
            this.rbUserRam.Location = new System.Drawing.Point(17, 47);
            this.rbUserRam.Name = "rbUserRam";
            this.rbUserRam.Size = new System.Drawing.Size(77, 19);
            this.rbUserRam.TabIndex = 1;
            this.rbUserRam.Text = "User RAM";
            this.toolTip1.SetToolTip(this.rbUserRam, "Entries stored in user RAM");
            this.rbUserRam.UseVisualStyleBackColor = true;
            this.rbUserRam.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbPinMemory
            // 
            this.rbPinMemory.AutoSize = true;
            this.rbPinMemory.Checked = true;
            this.rbPinMemory.Location = new System.Drawing.Point(17, 22);
            this.rbPinMemory.Name = "rbPinMemory";
            this.rbPinMemory.Size = new System.Drawing.Size(90, 19);
            this.rbPinMemory.TabIndex = 0;
            this.rbPinMemory.TabStop = true;
            this.rbPinMemory.Text = "Pin Memory";
            this.toolTip1.SetToolTip(this.rbPinMemory, "Entries stored in Pin Memory");
            this.rbPinMemory.UseVisualStyleBackColor = true;
            // 
            // phliIdle
            // 
            this.phliIdle.AutoSize = true;
            this.phliIdle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.phliIdle.inputOption = false;
            this.phliIdle.Location = new System.Drawing.Point(100, 22);
            this.phliIdle.Name = "phliIdle";
            this.phliIdle.Size = new System.Drawing.Size(63, 43);
            this.phliIdle.TabIndex = 0;
            this.phliIdle.Text = "Idle State";
            this.toolTip1.SetToolTip(this.phliIdle, "State when Queue Runs Empty");
            this.phliIdle.Value = ((byte)(0));
            // 
            // QueuedPulseOutputControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.gbQueue);
            this.Name = "QueuedPulseOutputControl";
            this.Size = new System.Drawing.Size(305, 505);
            this.gbQueue.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbQueue;
        private PinHighLowInputControl phliInit;
        private PinHighLowInputControl phliIdle;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbPinMemory;
        private System.Windows.Forms.TextBox tbEntries;
        private SixteenBitAddressControl sbacIndex;
        private System.Windows.Forms.RadioButton rbUserRam;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rbus;
        private System.Windows.Forms.RadioButton rbms;
        private System.Windows.Forms.Button bConfigure;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bGenConfigCode;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox ckbPause;
        private System.Windows.Forms.Button bQueue;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private SixteenBitSliderInput sbsi2nd;
        private SixteenBitSliderInput sbsi1st;
        private PinHighLowInputControl phli2nd;
        private PinHighLowInputControl phli1st;
    }
}
