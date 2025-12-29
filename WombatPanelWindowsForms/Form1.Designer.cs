namespace WombatPanelWindowsForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            printPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            tsmiDownloadNewHexFile = new System.Windows.Forms.ToolStripMenuItem();
            tsmiReadRam = new System.Windows.Forms.ToolStripMenuItem();
            tsmiCArray = new System.Windows.Forms.ToolStripMenuItem();
            createSW08BCArrayFromHexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            sendStayInBootToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            communicationsTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            portStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            portOpenSerialMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            portOpenTCPMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            portOpenI2CBridgeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            portCloseMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            tsmiResetSWCOnOpen = new System.Windows.Forms.ToolStripMenuItem();
            commandCaptureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            cancelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            stopAndStoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            readToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            tbLog = new System.Windows.Forms.TextBox();
            bReset = new System.Windows.Forms.Button();
            bSourceVoltage = new System.Windows.Forms.Button();
            bResync = new System.Windows.Forms.Button();
            graphicPinSelectorControl1 = new SerialWombatWindowsFormsLibrary.GraphicPinSelectorControl();
            ckbDecodeMessages = new System.Windows.Forms.CheckBox();
            toolTip1 = new System.Windows.Forms.ToolTip(components);
            button1 = new System.Windows.Forms.Button();
            ckbIgnoreReads = new System.Windows.Forms.CheckBox();
            bClearCapture = new System.Windows.Forms.Button();
            cbI2CAddress = new System.Windows.Forms.ComboBox();
            label1 = new System.Windows.Forms.Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, toolsToolStripMenuItem, portStripMenuItem, commandCaptureToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(1163, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { newToolStripMenuItem, openToolStripMenuItem, toolStripSeparator, saveToolStripMenuItem, saveAsToolStripMenuItem, toolStripSeparator1, printToolStripMenuItem, printPreviewToolStripMenuItem, toolStripSeparator2, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("newToolStripMenuItem.Image");
            newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N;
            newToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            newToolStripMenuItem.Text = "&New";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("openToolStripMenuItem.Image");
            openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O;
            openToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            openToolStripMenuItem.Text = "&Open";
            // 
            // toolStripSeparator
            // 
            toolStripSeparator.Name = "toolStripSeparator";
            toolStripSeparator.Size = new System.Drawing.Size(143, 6);
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("saveToolStripMenuItem.Image");
            saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S;
            saveToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            saveToolStripMenuItem.Text = "&Save";
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            saveAsToolStripMenuItem.Text = "Save &As";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new System.Drawing.Size(143, 6);
            // 
            // printToolStripMenuItem
            // 
            printToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("printToolStripMenuItem.Image");
            printToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            printToolStripMenuItem.Name = "printToolStripMenuItem";
            printToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P;
            printToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            printToolStripMenuItem.Text = "&Print";
            // 
            // printPreviewToolStripMenuItem
            // 
            printPreviewToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("printPreviewToolStripMenuItem.Image");
            printPreviewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
            printPreviewToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            printPreviewToolStripMenuItem.Text = "Print Pre&view";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new System.Drawing.Size(143, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            exitToolStripMenuItem.Text = "E&xit";
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { undoToolStripMenuItem, redoToolStripMenuItem, toolStripSeparator3, cutToolStripMenuItem, copyToolStripMenuItem, pasteToolStripMenuItem, toolStripSeparator4, selectAllToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            editToolStripMenuItem.Text = "&Edit";
            // 
            // undoToolStripMenuItem
            // 
            undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            undoToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z;
            undoToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            undoToolStripMenuItem.Text = "&Undo";
            // 
            // redoToolStripMenuItem
            // 
            redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            redoToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y;
            redoToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            redoToolStripMenuItem.Text = "&Redo";
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new System.Drawing.Size(141, 6);
            // 
            // cutToolStripMenuItem
            // 
            cutToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("cutToolStripMenuItem.Image");
            cutToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            cutToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X;
            cutToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            cutToolStripMenuItem.Text = "Cu&t";
            // 
            // copyToolStripMenuItem
            // 
            copyToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("copyToolStripMenuItem.Image");
            copyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            copyToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C;
            copyToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            copyToolStripMenuItem.Text = "&Copy";
            // 
            // pasteToolStripMenuItem
            // 
            pasteToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("pasteToolStripMenuItem.Image");
            pasteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            pasteToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V;
            pasteToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            pasteToolStripMenuItem.Text = "&Paste";
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new System.Drawing.Size(141, 6);
            // 
            // selectAllToolStripMenuItem
            // 
            selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            selectAllToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            selectAllToolStripMenuItem.Text = "Select &All";
            // 
            // toolsToolStripMenuItem
            // 
            toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { tsmiDownloadNewHexFile, tsmiReadRam, tsmiCArray, createSW08BCArrayFromHexToolStripMenuItem, sendStayInBootToolStripMenuItem, communicationsTestToolStripMenuItem });
            toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            toolsToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            toolsToolStripMenuItem.Text = "&Tools";
            // 
            // tsmiDownloadNewHexFile
            // 
            tsmiDownloadNewHexFile.Name = "tsmiDownloadNewHexFile";
            tsmiDownloadNewHexFile.Size = new System.Drawing.Size(249, 22);
            tsmiDownloadNewHexFile.Text = "Download New Firmware";
            tsmiDownloadNewHexFile.Click += TsmiDownloadNewHexFile_Click;
            // 
            // tsmiReadRam
            // 
            tsmiReadRam.Name = "tsmiReadRam";
            tsmiReadRam.Size = new System.Drawing.Size(249, 22);
            tsmiReadRam.Text = "Read RAM";
            tsmiReadRam.Click += tsmiReadRam_Click_1;
            // 
            // tsmiCArray
            // 
            tsmiCArray.Name = "tsmiCArray";
            tsmiCArray.Size = new System.Drawing.Size(249, 22);
            tsmiCArray.Text = "Create SW18AB C Array from Hex";
            tsmiCArray.Click += tsmiCArray_Click_1;
            // 
            // createSW08BCArrayFromHexToolStripMenuItem
            // 
            createSW08BCArrayFromHexToolStripMenuItem.Name = "createSW08BCArrayFromHexToolStripMenuItem";
            createSW08BCArrayFromHexToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            createSW08BCArrayFromHexToolStripMenuItem.Text = "CreateSW08B C Array from hex";
            createSW08BCArrayFromHexToolStripMenuItem.Click += createSW08BCArrayFromHexToolStripMenuItem_Click;
            // 
            // sendStayInBootToolStripMenuItem
            // 
            sendStayInBootToolStripMenuItem.Name = "sendStayInBootToolStripMenuItem";
            sendStayInBootToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            sendStayInBootToolStripMenuItem.Text = "Send Stay In Boot";
            sendStayInBootToolStripMenuItem.Click += sendStayInBootToolStripMenuItem_Click;
            // 
            // communicationsTestToolStripMenuItem
            // 
            communicationsTestToolStripMenuItem.Name = "communicationsTestToolStripMenuItem";
            communicationsTestToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            communicationsTestToolStripMenuItem.Text = "Communications Test";
            communicationsTestToolStripMenuItem.Click += communicationsTestToolStripMenuItem_Click;
            // 
            // portStripMenuItem
            // 
            portStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { portOpenSerialMenuItem, portOpenTCPMenuItem, portOpenI2CBridgeMenuItem, portCloseMenuItem, tsmiResetSWCOnOpen });
            portStripMenuItem.Name = "portStripMenuItem";
            portStripMenuItem.Size = new System.Drawing.Size(41, 20);
            portStripMenuItem.Text = "&Port";
            // 
            // portOpenSerialMenuItem
            // 
            portOpenSerialMenuItem.Name = "portOpenSerialMenuItem";
            portOpenSerialMenuItem.Size = new System.Drawing.Size(179, 22);
            portOpenSerialMenuItem.Text = "Open&Serial";
            portOpenSerialMenuItem.Click += PortOpenSerialMenuItem_Click;
            // 
            // portOpenTCPMenuItem
            // 
            portOpenTCPMenuItem.Name = "portOpenTCPMenuItem";
            portOpenTCPMenuItem.Size = new System.Drawing.Size(179, 22);
            portOpenTCPMenuItem.Text = "Open &TCP";
            portOpenTCPMenuItem.Click += portOpenTCPMenuItem_Click_1;
            // 
            // portOpenI2CBridgeMenuItem
            // 
            portOpenI2CBridgeMenuItem.Enabled = false;
            portOpenI2CBridgeMenuItem.Name = "portOpenI2CBridgeMenuItem";
            portOpenI2CBridgeMenuItem.Size = new System.Drawing.Size(179, 22);
            portOpenI2CBridgeMenuItem.Text = "Open I2C Bridge";
            // 
            // portCloseMenuItem
            // 
            portCloseMenuItem.Name = "portCloseMenuItem";
            portCloseMenuItem.Size = new System.Drawing.Size(179, 22);
            portCloseMenuItem.Text = "&Close";
            // 
            // tsmiResetSWCOnOpen
            // 
            tsmiResetSWCOnOpen.Name = "tsmiResetSWCOnOpen";
            tsmiResetSWCOnOpen.Size = new System.Drawing.Size(179, 22);
            tsmiResetSWCOnOpen.Text = "Reset SWC on Open";
            tsmiResetSWCOnOpen.Click += tsmiResetSWCOnOpen_Click;
            // 
            // commandCaptureToolStripMenuItem
            // 
            commandCaptureToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { startToolStripMenuItem, cancelToolStripMenuItem, stopAndStoreToolStripMenuItem, readToolStripMenuItem });
            commandCaptureToolStripMenuItem.Name = "commandCaptureToolStripMenuItem";
            commandCaptureToolStripMenuItem.Size = new System.Drawing.Size(118, 20);
            commandCaptureToolStripMenuItem.Text = "CommandCapture";
            // 
            // startToolStripMenuItem
            // 
            startToolStripMenuItem.Name = "startToolStripMenuItem";
            startToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            startToolStripMenuItem.Text = "Start";
            startToolStripMenuItem.Click += startToolStripMenuItem_Click;
            // 
            // cancelToolStripMenuItem
            // 
            cancelToolStripMenuItem.Name = "cancelToolStripMenuItem";
            cancelToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            cancelToolStripMenuItem.Text = "Cancel";
            cancelToolStripMenuItem.Click += cancelToolStripMenuItem_Click;
            // 
            // stopAndStoreToolStripMenuItem
            // 
            stopAndStoreToolStripMenuItem.Name = "stopAndStoreToolStripMenuItem";
            stopAndStoreToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            stopAndStoreToolStripMenuItem.Text = "Stop And Store";
            stopAndStoreToolStripMenuItem.Click += stopAndStoreToolStripMenuItem_Click;
            // 
            // readToolStripMenuItem
            // 
            readToolStripMenuItem.Name = "readToolStripMenuItem";
            readToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            readToolStripMenuItem.Text = "Read";
            readToolStripMenuItem.Click += readToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { searchToolStripMenuItem, toolStripMenuItem1, toolStripMenuItem2, toolStripSeparator5, aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            helpToolStripMenuItem.Text = "&Help";
            // 
            // searchToolStripMenuItem
            // 
            searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            searchToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            searchToolStripMenuItem.Text = "User Guides";
            searchToolStripMenuItem.Click += searchToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new System.Drawing.Size(168, 22);
            toolStripMenuItem1.Text = "Class Information";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new System.Drawing.Size(168, 22);
            toolStripMenuItem2.Text = "YouTube Channel";
            toolStripMenuItem2.Click += toolStripMenuItem2_Click;
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new System.Drawing.Size(165, 6);
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            aboutToolStripMenuItem.Text = "&About...";
            // 
            // tbLog
            // 
            tbLog.Font = new System.Drawing.Font("Courier New", 9F);
            tbLog.Location = new System.Drawing.Point(13, 345);
            tbLog.Multiline = true;
            tbLog.Name = "tbLog";
            tbLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            tbLog.Size = new System.Drawing.Size(731, 179);
            tbLog.TabIndex = 1;
            // 
            // bReset
            // 
            bReset.Location = new System.Drawing.Point(226, 316);
            bReset.Name = "bReset";
            bReset.Size = new System.Drawing.Size(75, 23);
            bReset.TabIndex = 2;
            bReset.Text = "Reset Chip";
            bReset.UseVisualStyleBackColor = true;
            bReset.Click += bReset_Click;
            // 
            // bSourceVoltage
            // 
            bSourceVoltage.Location = new System.Drawing.Point(121, 316);
            bSourceVoltage.Name = "bSourceVoltage";
            bSourceVoltage.Size = new System.Drawing.Size(99, 23);
            bSourceVoltage.TabIndex = 3;
            bSourceVoltage.Text = "Source Voltage";
            bSourceVoltage.UseVisualStyleBackColor = true;
            bSourceVoltage.Click += bSourceVoltage_Click;
            // 
            // bResync
            // 
            bResync.Location = new System.Drawing.Point(13, 316);
            bResync.Name = "bResync";
            bResync.Size = new System.Drawing.Size(102, 23);
            bResync.TabIndex = 4;
            bResync.Text = "Resync Comm";
            bResync.UseVisualStyleBackColor = true;
            bResync.Click += bResync_Click;
            // 
            // graphicPinSelectorControl1
            // 
            graphicPinSelectorControl1.AutoSize = true;
            graphicPinSelectorControl1.Enabled = false;
            graphicPinSelectorControl1.Location = new System.Drawing.Point(777, 27);
            graphicPinSelectorControl1.Model = SerialWombat.SerialWombatModel.SerialWombat18AB;
            graphicPinSelectorControl1.Name = "graphicPinSelectorControl1";
            graphicPinSelectorControl1.Size = new System.Drawing.Size(208, 444);
            graphicPinSelectorControl1.TabIndex = 5;
            // 
            // ckbDecodeMessages
            // 
            ckbDecodeMessages.AutoSize = true;
            ckbDecodeMessages.Checked = true;
            ckbDecodeMessages.CheckState = System.Windows.Forms.CheckState.Checked;
            ckbDecodeMessages.Location = new System.Drawing.Point(678, 324);
            ckbDecodeMessages.Name = "ckbDecodeMessages";
            ckbDecodeMessages.Size = new System.Drawing.Size(66, 19);
            ckbDecodeMessages.TabIndex = 6;
            ckbDecodeMessages.Text = "Decode";
            toolTip1.SetToolTip(ckbDecodeMessages, "Decode Messages using SerialWombatPacketDecoder class ");
            ckbDecodeMessages.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(407, 316);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(102, 23);
            button1.TabIndex = 8;
            button1.Text = "Init Array";
            toolTip1.SetToolTip(button1, "Creates a C array of all the commands in the window.  Can be compiled into firmware");
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ckbIgnoreReads
            // 
            ckbIgnoreReads.AutoSize = true;
            ckbIgnoreReads.Location = new System.Drawing.Point(515, 324);
            ckbIgnoreReads.Name = "ckbIgnoreReads";
            ckbIgnoreReads.Size = new System.Drawing.Size(157, 19);
            ckbIgnoreReads.TabIndex = 6;
            ckbIgnoreReads.Text = "Ignore Public Data Reads";
            ckbIgnoreReads.UseVisualStyleBackColor = true;
            // 
            // bClearCapture
            // 
            bClearCapture.Location = new System.Drawing.Point(307, 316);
            bClearCapture.Name = "bClearCapture";
            bClearCapture.Size = new System.Drawing.Size(94, 23);
            bClearCapture.TabIndex = 7;
            bClearCapture.Text = "Clear Capture";
            bClearCapture.UseVisualStyleBackColor = true;
            bClearCapture.Click += bClearCapture_Click;
            // 
            // cbI2CAddress
            // 
            cbI2CAddress.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbI2CAddress.FormattingEnabled = true;
            cbI2CAddress.Items.AddRange(new object[] { "default", "0x60", "0x61", "0x62", "0x63", "0x64", "0x65", "0x66", "0x67", "0x68", "0x69", "0x6A", "0x6B", "0x6C", "0x6D", "0x6E", "0x6F" });
            cbI2CAddress.Location = new System.Drawing.Point(854, 477);
            cbI2CAddress.Name = "cbI2CAddress";
            cbI2CAddress.Size = new System.Drawing.Size(121, 23);
            cbI2CAddress.TabIndex = 9;
            cbI2CAddress.SelectedIndexChanged += cbI2CAddress_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(776, 480);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(72, 15);
            label1.TabIndex = 10;
            label1.Text = "I2C Address:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1163, 568);
            Controls.Add(label1);
            Controls.Add(cbI2CAddress);
            Controls.Add(button1);
            Controls.Add(bClearCapture);
            Controls.Add(ckbIgnoreReads);
            Controls.Add(ckbDecodeMessages);
            Controls.Add(graphicPinSelectorControl1);
            Controls.Add(bResync);
            Controls.Add(bSourceVoltage);
            Controls.Add(bReset);
            Controls.Add(tbLog);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Wombat Panel V2.2.20 20251220";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }



        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem portStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem portOpenSerialMenuItem;
        private System.Windows.Forms.ToolStripMenuItem portOpenTCPMenuItem;
        private System.Windows.Forms.ToolStripMenuItem portCloseMenuItem;
        private System.Windows.Forms.TextBox tbLog;
        private System.Windows.Forms.ToolStripMenuItem tsmiDownloadNewHexFile;
        private System.Windows.Forms.ToolStripMenuItem tsmiReadRam;
        private System.Windows.Forms.Button bReset;
        private System.Windows.Forms.Button bSourceVoltage;
        private System.Windows.Forms.ToolStripMenuItem portOpenI2CBridgeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiCArray;
        private System.Windows.Forms.Button bResync;
        private System.Windows.Forms.ToolStripMenuItem tsmiResetSWCOnOpen;
        private System.Windows.Forms.ToolStripMenuItem commandCaptureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopAndStoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem readToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendStayInBootToolStripMenuItem;
        private SerialWombatWindowsFormsLibrary.GraphicPinSelectorControl graphicPinSelectorControl1;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.CheckBox ckbDecodeMessages;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripMenuItem communicationsTestToolStripMenuItem;
        private System.Windows.Forms.CheckBox ckbIgnoreReads;
        private System.Windows.Forms.ToolStripMenuItem createSW08BCArrayFromHexToolStripMenuItem;
        private System.Windows.Forms.Button bClearCapture;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbI2CAddress;
        private System.Windows.Forms.Label label1;
    }
}

