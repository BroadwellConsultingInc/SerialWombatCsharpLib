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
            components = new System.ComponentModel.Container();
            groupBox1 = new System.Windows.Forms.GroupBox();
            pdRx = new SerialWombatPinDropdown();
            pdTx = new SerialWombatPinDropdown();
            button4 = new System.Windows.Forms.Button();
            bClear = new System.Windows.Forms.Button();
            gbSoftwareUartQueues = new System.Windows.Forms.GroupBox();
            sbacQueueIndex = new SixteenBitAddressControl();
            button1 = new System.Windows.Forms.Button();
            tbTxSize = new System.Windows.Forms.TextBox();
            tbRxSize = new System.Windows.Forms.TextBox();
            lRxQueueIndex = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            bTxFile = new System.Windows.Forms.Button();
            ckbAutosample = new System.Windows.Forms.CheckBox();
            tbRx = new System.Windows.Forms.TextBox();
            bConfigure = new System.Windows.Forms.Button();
            cbBaudRate = new System.Windows.Forms.ComboBox();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            cbMode = new System.Windows.Forms.ComboBox();
            toolTip1 = new System.Windows.Forms.ToolTip(components);
            groupBox1.SuspendLayout();
            gbSoftwareUartQueues.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pdRx);
            groupBox1.Controls.Add(pdTx);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(bClear);
            groupBox1.Controls.Add(gbSoftwareUartQueues);
            groupBox1.Controls.Add(bTxFile);
            groupBox1.Controls.Add(ckbAutosample);
            groupBox1.Controls.Add(tbRx);
            groupBox1.Controls.Add(bConfigure);
            groupBox1.Controls.Add(cbBaudRate);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(cbMode);
            groupBox1.Location = new System.Drawing.Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(441, 354);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // pdRx
            // 
            pdRx.IncludeNAPin = false;
            pdRx.Location = new System.Drawing.Point(267, 54);
            pdRx.Name = "pdRx";
            pdRx.Pin = 255;
            pdRx.PinType = SerialWombat.SerialWombatPinType.SerialWombatPin;
            pdRx.Size = new System.Drawing.Size(65, 25);
            pdRx.TabIndex = 2;
            // 
            // pdTx
            // 
            pdTx.IncludeNAPin = false;
            pdTx.Location = new System.Drawing.Point(370, 54);
            pdTx.Name = "pdTx";
            pdTx.Pin = 255;
            pdTx.PinType = SerialWombat.SerialWombatPinType.SerialWombatPin;
            pdTx.Size = new System.Drawing.Size(65, 25);
            pdTx.TabIndex = 3;
            // 
            // button4
            // 
            button4.BackColor = System.Drawing.Color.MediumPurple;
            button4.Location = new System.Drawing.Point(14, 134);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(45, 47);
            button4.TabIndex = 31;
            button4.TabStop = false;
            button4.Text = "Gen Code";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // bClear
            // 
            bClear.Location = new System.Drawing.Point(231, 191);
            bClear.Name = "bClear";
            bClear.Size = new System.Drawing.Size(75, 23);
            bClear.TabIndex = 6;
            bClear.Text = "Clear";
            toolTip1.SetToolTip(bClear, "Clear the receive box");
            bClear.UseVisualStyleBackColor = true;
            bClear.Click += bClear_Click;
            // 
            // gbSoftwareUartQueues
            // 
            gbSoftwareUartQueues.Controls.Add(sbacQueueIndex);
            gbSoftwareUartQueues.Controls.Add(button1);
            gbSoftwareUartQueues.Controls.Add(tbTxSize);
            gbSoftwareUartQueues.Controls.Add(tbRxSize);
            gbSoftwareUartQueues.Controls.Add(lRxQueueIndex);
            gbSoftwareUartQueues.Controls.Add(label5);
            gbSoftwareUartQueues.Controls.Add(label7);
            gbSoftwareUartQueues.Location = new System.Drawing.Point(150, 94);
            gbSoftwareUartQueues.Name = "gbSoftwareUartQueues";
            gbSoftwareUartQueues.Size = new System.Drawing.Size(285, 89);
            gbSoftwareUartQueues.TabIndex = 7;
            gbSoftwareUartQueues.TabStop = false;
            gbSoftwareUartQueues.Text = "Software UART Queues";
            // 
            // sbacQueueIndex
            // 
            sbacQueueIndex.AutoSize = true;
            sbacQueueIndex.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            sbacQueueIndex.Location = new System.Drawing.Point(69, 21);
            sbacQueueIndex.Name = "sbacQueueIndex";
            sbacQueueIndex.Size = new System.Drawing.Size(56, 26);
            sbacQueueIndex.TabIndex = 33;
            sbacQueueIndex.Value = (ushort)0;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(160, 21);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(60, 23);
            button1.TabIndex = 3;
            button1.Text = "Initialize";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // tbTxSize
            // 
            tbTxSize.Location = new System.Drawing.Point(188, 53);
            tbTxSize.Name = "tbTxSize";
            tbTxSize.Size = new System.Drawing.Size(59, 23);
            tbTxSize.TabIndex = 2;
            tbTxSize.Text = "64";
            toolTip1.SetToolTip(tbTxSize, "Size of TX Software Queue in Bytes");
            // 
            // tbRxSize
            // 
            tbRxSize.Location = new System.Drawing.Point(66, 51);
            tbRxSize.Name = "tbRxSize";
            tbRxSize.Size = new System.Drawing.Size(59, 23);
            tbRxSize.TabIndex = 1;
            tbRxSize.Text = "64";
            toolTip1.SetToolTip(tbRxSize, "Size of RX Software Queue in Bytes");
            // 
            // lRxQueueIndex
            // 
            lRxQueueIndex.AutoSize = true;
            lRxQueueIndex.Location = new System.Drawing.Point(6, 25);
            lRxQueueIndex.Name = "lRxQueueIndex";
            lRxQueueIndex.Size = new System.Drawing.Size(36, 15);
            lRxQueueIndex.TabIndex = 1;
            lRxQueueIndex.Text = "Index";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(6, 59);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(43, 15);
            label5.TabIndex = 1;
            label5.Text = "Rx Size";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(141, 59);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(41, 15);
            label7.TabIndex = 1;
            label7.Text = "Tx Size";
            // 
            // bTxFile
            // 
            bTxFile.Enabled = false;
            bTxFile.Location = new System.Drawing.Point(39, 185);
            bTxFile.Name = "bTxFile";
            bTxFile.Size = new System.Drawing.Size(75, 23);
            bTxFile.TabIndex = 5;
            bTxFile.Text = "Tx File";
            toolTip1.SetToolTip(bTxFile, "Send a file out through the TX pin");
            bTxFile.UseVisualStyleBackColor = true;
            bTxFile.Click += bTxFile_Click;
            // 
            // ckbAutosample
            // 
            ckbAutosample.AutoSize = true;
            ckbAutosample.Enabled = false;
            ckbAutosample.Location = new System.Drawing.Point(333, 189);
            ckbAutosample.Name = "ckbAutosample";
            ckbAutosample.Size = new System.Drawing.Size(90, 19);
            ckbAutosample.TabIndex = 7;
            ckbAutosample.Text = "Autosample";
            toolTip1.SetToolTip(ckbAutosample, "Start a thread to move  bytes from Serial Wombat chip to textbox");
            ckbAutosample.UseVisualStyleBackColor = true;
            ckbAutosample.CheckedChanged += ckbAutosample_CheckedChanged;
            // 
            // tbRx
            // 
            tbRx.Location = new System.Drawing.Point(18, 214);
            tbRx.Multiline = true;
            tbRx.Name = "tbRx";
            tbRx.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            tbRx.Size = new System.Drawing.Size(398, 122);
            tbRx.TabIndex = 4;
            tbRx.TabStop = false;
            // 
            // bConfigure
            // 
            bConfigure.Location = new System.Drawing.Point(18, 94);
            bConfigure.Name = "bConfigure";
            bConfigure.Size = new System.Drawing.Size(75, 23);
            bConfigure.TabIndex = 4;
            bConfigure.Text = "Configure UART and start RX";
            bConfigure.UseVisualStyleBackColor = true;
            bConfigure.Click += bConfigure_Click;
            // 
            // cbBaudRate
            // 
            cbBaudRate.FormattingEnabled = true;
            cbBaudRate.Location = new System.Drawing.Point(83, 54);
            cbBaudRate.Name = "cbBaudRate";
            cbBaudRate.Size = new System.Drawing.Size(121, 23);
            cbBaudRate.TabIndex = 1;
            toolTip1.SetToolTip(cbBaudRate, "Baud Rate");
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(329, 57);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(41, 15);
            label4.TabIndex = 1;
            label4.Text = "Tx Pin:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(220, 57);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(43, 15);
            label3.TabIndex = 1;
            label3.Text = "Rx Pin:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(18, 54);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(37, 15);
            label2.TabIndex = 1;
            label2.Text = "Baud:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(18, 25);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(41, 15);
            label1.TabIndex = 1;
            label1.Text = "Mode:";
            // 
            // cbMode
            // 
            cbMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbMode.FormattingEnabled = true;
            cbMode.Items.AddRange(new object[] { "Hardware UART0", "Hardware UART1", "Software UART" });
            cbMode.Location = new System.Drawing.Point(83, 22);
            cbMode.Name = "cbMode";
            cbMode.Size = new System.Drawing.Size(258, 23);
            cbMode.TabIndex = 0;
            toolTip1.SetToolTip(cbMode, "UART Mode");
            cbMode.SelectedIndexChanged += cbMode_SelectedIndexChanged;
            // 
            // UARTControl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            Controls.Add(groupBox1);
            Name = "UARTControl";
            Size = new System.Drawing.Size(444, 357);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            gbSoftwareUartQueues.ResumeLayout(false);
            gbSoftwareUartQueues.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbMode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbBaudRate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbSoftwareUartQueues;
        private System.Windows.Forms.TextBox tbTxSize;
        private System.Windows.Forms.TextBox tbRxSize;
        private System.Windows.Forms.Label lRxQueueIndex;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button bTxFile;
        private System.Windows.Forms.CheckBox ckbAutosample;
        private System.Windows.Forms.TextBox tbRx;
        private System.Windows.Forms.Button bConfigure;
        private System.Windows.Forms.Button bClear;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button button4;
        private SerialWombatPinDropdown pdRx;
        private SerialWombatPinDropdown pdTx;
        private System.Windows.Forms.Button button1;
        private SixteenBitAddressControl sbacQueueIndex;
    }
}
