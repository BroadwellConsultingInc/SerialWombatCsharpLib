namespace SerialWombatWindowsFormsLibrary
{
    partial class UARTControl
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bClear = new System.Windows.Forms.Button();
            this.gbSoftwareUartQueues = new System.Windows.Forms.GroupBox();
            this.tbTxSize = new System.Windows.Forms.TextBox();
            this.tbRxSize = new System.Windows.Forms.TextBox();
            this.tbQueueIndex = new System.Windows.Forms.TextBox();
            this.lRxQueueIndex = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.bTxFile = new System.Windows.Forms.Button();
            this.ckbAutosample = new System.Windows.Forms.CheckBox();
            this.tbRx = new System.Windows.Forms.TextBox();
            this.bConfigure = new System.Windows.Forms.Button();
            this.cbTxPin = new System.Windows.Forms.ComboBox();
            this.cbRxPin = new System.Windows.Forms.ComboBox();
            this.cbBaudRate = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbMode = new System.Windows.Forms.ComboBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.gbSoftwareUartQueues.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bClear);
            this.groupBox1.Controls.Add(this.gbSoftwareUartQueues);
            this.groupBox1.Controls.Add(this.bTxFile);
            this.groupBox1.Controls.Add(this.ckbAutosample);
            this.groupBox1.Controls.Add(this.tbRx);
            this.groupBox1.Controls.Add(this.bConfigure);
            this.groupBox1.Controls.Add(this.cbTxPin);
            this.groupBox1.Controls.Add(this.cbRxPin);
            this.groupBox1.Controls.Add(this.cbBaudRate);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbMode);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(441, 354);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // bClear
            // 
            this.bClear.Location = new System.Drawing.Point(231, 191);
            this.bClear.Name = "bClear";
            this.bClear.Size = new System.Drawing.Size(75, 23);
            this.bClear.TabIndex = 8;
            this.bClear.Text = "Clear";
            this.toolTip1.SetToolTip(this.bClear, "Clear the receive box");
            this.bClear.UseVisualStyleBackColor = true;
            this.bClear.Click += new System.EventHandler(this.bClear_Click);
            // 
            // gbSoftwareUartQueues
            // 
            this.gbSoftwareUartQueues.Controls.Add(this.tbTxSize);
            this.gbSoftwareUartQueues.Controls.Add(this.tbRxSize);
            this.gbSoftwareUartQueues.Controls.Add(this.tbQueueIndex);
            this.gbSoftwareUartQueues.Controls.Add(this.lRxQueueIndex);
            this.gbSoftwareUartQueues.Controls.Add(this.label5);
            this.gbSoftwareUartQueues.Controls.Add(this.label7);
            this.gbSoftwareUartQueues.Location = new System.Drawing.Point(150, 94);
            this.gbSoftwareUartQueues.Name = "gbSoftwareUartQueues";
            this.gbSoftwareUartQueues.Size = new System.Drawing.Size(285, 89);
            this.gbSoftwareUartQueues.TabIndex = 7;
            this.gbSoftwareUartQueues.TabStop = false;
            this.gbSoftwareUartQueues.Text = "Software UART Queues";
            // 
            // tbTxSize
            // 
            this.tbTxSize.Location = new System.Drawing.Point(188, 53);
            this.tbTxSize.Name = "tbTxSize";
            this.tbTxSize.Size = new System.Drawing.Size(59, 23);
            this.tbTxSize.TabIndex = 2;
            this.tbTxSize.Text = "64";
            this.toolTip1.SetToolTip(this.tbTxSize, "Size of TX Software Queue in Bytes");
            // 
            // tbRxSize
            // 
            this.tbRxSize.Location = new System.Drawing.Point(66, 51);
            this.tbRxSize.Name = "tbRxSize";
            this.tbRxSize.Size = new System.Drawing.Size(59, 23);
            this.tbRxSize.TabIndex = 2;
            this.tbRxSize.Text = "64";
            this.toolTip1.SetToolTip(this.tbRxSize, "Size of RX Software Queue in Bytes");
            // 
            // tbQueueIndex
            // 
            this.tbQueueIndex.Location = new System.Drawing.Point(66, 22);
            this.tbQueueIndex.Name = "tbQueueIndex";
            this.tbQueueIndex.Size = new System.Drawing.Size(100, 23);
            this.tbQueueIndex.TabIndex = 2;
            this.tbQueueIndex.Text = "0";
            this.toolTip1.SetToolTip(this.tbQueueIndex, "Index in User Memory where TX and RX queues are stored");
            // 
            // lRxQueueIndex
            // 
            this.lRxQueueIndex.AutoSize = true;
            this.lRxQueueIndex.Location = new System.Drawing.Point(6, 25);
            this.lRxQueueIndex.Name = "lRxQueueIndex";
            this.lRxQueueIndex.Size = new System.Drawing.Size(36, 15);
            this.lRxQueueIndex.TabIndex = 1;
            this.lRxQueueIndex.Text = "Index";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Rx Size";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(141, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 15);
            this.label7.TabIndex = 1;
            this.label7.Text = "Tx Size";
            // 
            // bTxFile
            // 
            this.bTxFile.Enabled = false;
            this.bTxFile.Location = new System.Drawing.Point(39, 185);
            this.bTxFile.Name = "bTxFile";
            this.bTxFile.Size = new System.Drawing.Size(75, 23);
            this.bTxFile.TabIndex = 6;
            this.bTxFile.Text = "Tx File";
            this.toolTip1.SetToolTip(this.bTxFile, "Send a file out through the TX pin");
            this.bTxFile.UseVisualStyleBackColor = true;
            this.bTxFile.Click += new System.EventHandler(this.bTxFile_Click);
            // 
            // ckbAutosample
            // 
            this.ckbAutosample.AutoSize = true;
            this.ckbAutosample.Enabled = false;
            this.ckbAutosample.Location = new System.Drawing.Point(333, 189);
            this.ckbAutosample.Name = "ckbAutosample";
            this.ckbAutosample.Size = new System.Drawing.Size(90, 19);
            this.ckbAutosample.TabIndex = 5;
            this.ckbAutosample.Text = "Autosample";
            this.toolTip1.SetToolTip(this.ckbAutosample, "Start a thread to move  bytes from Serial Wombat chip to textbox");
            this.ckbAutosample.UseVisualStyleBackColor = true;
            this.ckbAutosample.CheckedChanged += new System.EventHandler(this.ckbAutosample_CheckedChanged);
            // 
            // tbRx
            // 
            this.tbRx.Location = new System.Drawing.Point(18, 214);
            this.tbRx.Multiline = true;
            this.tbRx.Name = "tbRx";
            this.tbRx.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbRx.Size = new System.Drawing.Size(398, 122);
            this.tbRx.TabIndex = 4;
            // 
            // bConfigure
            // 
            this.bConfigure.Location = new System.Drawing.Point(18, 94);
            this.bConfigure.Name = "bConfigure";
            this.bConfigure.Size = new System.Drawing.Size(75, 23);
            this.bConfigure.TabIndex = 3;
            this.bConfigure.Text = "Configure UART and start RX";
            this.bConfigure.UseVisualStyleBackColor = true;
            this.bConfigure.Click += new System.EventHandler(this.bConfigure_Click);
            // 
            // cbTxPin
            // 
            this.cbTxPin.FormattingEnabled = true;
            this.cbTxPin.Location = new System.Drawing.Point(378, 54);
            this.cbTxPin.Name = "cbTxPin";
            this.cbTxPin.Size = new System.Drawing.Size(38, 23);
            this.cbTxPin.TabIndex = 2;
            this.toolTip1.SetToolTip(this.cbTxPin, "Pin for Transmit (Out from Serial Wombat chip)");
            // 
            // cbRxPin
            // 
            this.cbRxPin.FormattingEnabled = true;
            this.cbRxPin.Location = new System.Drawing.Point(269, 54);
            this.cbRxPin.Name = "cbRxPin";
            this.cbRxPin.Size = new System.Drawing.Size(38, 23);
            this.cbRxPin.TabIndex = 2;
            this.toolTip1.SetToolTip(this.cbRxPin, "Pin for Receive (In to Serial Wombat chip)");
            // 
            // cbBaudRate
            // 
            this.cbBaudRate.FormattingEnabled = true;
            this.cbBaudRate.Location = new System.Drawing.Point(83, 54);
            this.cbBaudRate.Name = "cbBaudRate";
            this.cbBaudRate.Size = new System.Drawing.Size(121, 23);
            this.cbBaudRate.TabIndex = 2;
            this.toolTip1.SetToolTip(this.cbBaudRate, "Baud Rate");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(329, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tx Pin:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(220, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Rx Pin:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Baud:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mode:";
            // 
            // cbMode
            // 
            this.cbMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMode.FormattingEnabled = true;
            this.cbMode.Items.AddRange(new object[] {
            "Hardware UART0",
            "Hardware UART1",
            "Software UART"});
            this.cbMode.Location = new System.Drawing.Point(83, 22);
            this.cbMode.Name = "cbMode";
            this.cbMode.Size = new System.Drawing.Size(258, 23);
            this.cbMode.TabIndex = 0;
            this.toolTip1.SetToolTip(this.cbMode, "UART Mode");
            this.cbMode.SelectedIndexChanged += new System.EventHandler(this.cbMode_SelectedIndexChanged);
            // 
            // UARTControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.groupBox1);
            this.Name = "UARTControl";
            this.Size = new System.Drawing.Size(444, 357);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbSoftwareUartQueues.ResumeLayout(false);
            this.gbSoftwareUartQueues.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbMode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTxPin;
        private System.Windows.Forms.ComboBox cbRxPin;
        private System.Windows.Forms.ComboBox cbBaudRate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbSoftwareUartQueues;
        private System.Windows.Forms.TextBox tbTxSize;
        private System.Windows.Forms.TextBox tbRxSize;
        private System.Windows.Forms.TextBox tbQueueIndex;
        private System.Windows.Forms.Label lRxQueueIndex;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button bTxFile;
        private System.Windows.Forms.CheckBox ckbAutosample;
        private System.Windows.Forms.TextBox tbRx;
        private System.Windows.Forms.Button bConfigure;
        private System.Windows.Forms.Button bClear;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
