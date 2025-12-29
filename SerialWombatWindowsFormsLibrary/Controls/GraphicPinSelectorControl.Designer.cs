namespace SerialWombatWindowsFormsLibrary
{
    partial class GraphicPinSelectorControl
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
            cbModel = new System.Windows.Forms.ComboBox();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(components);
            tsmiInput = new System.Windows.Forms.ToolStripMenuItem();
            tsmiHigh = new System.Windows.Forms.ToolStripMenuItem();
            tsmiLow = new System.Windows.Forms.ToolStripMenuItem();
            toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            tsmiAnalogInput = new System.Windows.Forms.ToolStripMenuItem();
            sW18ABCapTouchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            tsmiResistanceInput = new System.Windows.Forms.ToolStripMenuItem();
            tsmiThroughputConsumer = new System.Windows.Forms.ToolStripMenuItem();
            tsmiUART = new System.Windows.Forms.ToolStripMenuItem();
            tsmiPinStateViewer = new System.Windows.Forms.ToolStripMenuItem();
            queueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            monitorPublicDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            dataLoggerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            tsmiDebounce = new System.Windows.Forms.ToolStripMenuItem();
            highSpeedCounterToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            tsmiMatrixKeypad = new System.Windows.Forms.ToolStripMenuItem();
            tsmiPulseTimer = new System.Windows.Forms.ToolStripMenuItem();
            tsmiQuadratureEncoder = new System.Windows.Forms.ToolStripMenuItem();
            tsmiUltrasonicDistanceSensor = new System.Windows.Forms.ToolStripMenuItem();
            toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            tsmiHBridge = new System.Windows.Forms.ToolStripMenuItem();
            highSpeedClockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            tsmiPWM = new System.Windows.Forms.ToolStripMenuItem();
            tsmiPulseOnChange = new System.Windows.Forms.ToolStripMenuItem();
            toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            tsmiServo = new System.Windows.Forms.ToolStripMenuItem();
            tsmiWatchdog = new System.Windows.Forms.ToolStripMenuItem();
            toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            tsmiLiquidCrystal = new System.Windows.Forms.ToolStripMenuItem();
            tmsiTM1637 = new System.Windows.Forms.ToolStripMenuItem();
            toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            tsmiWS2812 = new System.Windows.Forms.ToolStripMenuItem();
            label1 = new System.Windows.Forms.Label();
            iRRxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbModel);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new System.Drawing.Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(202, 438);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Graphic Pin Selector";
            // 
            // cbModel
            // 
            cbModel.FormattingEnabled = true;
            cbModel.Location = new System.Drawing.Point(19, 384);
            cbModel.Name = "cbModel";
            cbModel.Size = new System.Drawing.Size(157, 23);
            cbModel.TabIndex = 2;
            cbModel.SelectedIndexChanged += cbModel_SelectedIndexChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.ContextMenuStrip = contextMenuStrip1;
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new System.Drawing.Point(19, 53);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(157, 324);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.MouseClick += pictureBox1_MouseClick;
            pictureBox1.MouseDown += pictureBox1_MouseDown;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { tsmiInput, tsmiHigh, tsmiLow, toolStripMenuItem7, tsmiAnalogInput, sW18ABCapTouchToolStripMenuItem, tsmiResistanceInput, tsmiThroughputConsumer, tsmiUART, tsmiPinStateViewer, queueToolStripMenuItem, monitorPublicDataToolStripMenuItem, dataLoggerToolStripMenuItem, toolStripMenuItem4, toolStripMenuItem5, toolStripMenuItem6 });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new System.Drawing.Size(193, 378);
            contextMenuStrip1.Opening += contextMenuStrip1_Opening;
            // 
            // tsmiInput
            // 
            tsmiInput.Name = "tsmiInput";
            tsmiInput.Size = new System.Drawing.Size(192, 22);
            tsmiInput.Text = "Input";
            tsmiInput.Click += tsmiInput_Click;
            // 
            // tsmiHigh
            // 
            tsmiHigh.Name = "tsmiHigh";
            tsmiHigh.Size = new System.Drawing.Size(192, 22);
            tsmiHigh.Text = "High";
            tsmiHigh.Click += tsmiHigh_Click;
            // 
            // tsmiLow
            // 
            tsmiLow.Name = "tsmiLow";
            tsmiLow.Size = new System.Drawing.Size(192, 22);
            tsmiLow.Text = "Low";
            tsmiLow.Click += tsmiLow_Click;
            // 
            // toolStripMenuItem7
            // 
            toolStripMenuItem7.Name = "toolStripMenuItem7";
            toolStripMenuItem7.Size = new System.Drawing.Size(192, 22);
            toolStripMenuItem7.Text = "DigitalIO";
            toolStripMenuItem7.Click += toolStripMenuItem7_Click;
            // 
            // tsmiAnalogInput
            // 
            tsmiAnalogInput.Name = "tsmiAnalogInput";
            tsmiAnalogInput.Size = new System.Drawing.Size(192, 22);
            tsmiAnalogInput.Text = "AnalogInput";
            // 
            // sW18ABCapTouchToolStripMenuItem
            // 
            sW18ABCapTouchToolStripMenuItem.Name = "sW18ABCapTouchToolStripMenuItem";
            sW18ABCapTouchToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            sW18ABCapTouchToolStripMenuItem.Text = "SW18ABCapTouch";
            sW18ABCapTouchToolStripMenuItem.Click += sW18ABCapTouchToolStripMenuItem_Click;
            // 
            // tsmiResistanceInput
            // 
            tsmiResistanceInput.Name = "tsmiResistanceInput";
            tsmiResistanceInput.Size = new System.Drawing.Size(192, 22);
            tsmiResistanceInput.Text = "Resistance Input";
            // 
            // tsmiThroughputConsumer
            // 
            tsmiThroughputConsumer.Name = "tsmiThroughputConsumer";
            tsmiThroughputConsumer.Size = new System.Drawing.Size(192, 22);
            tsmiThroughputConsumer.Text = "ThroughputConsumer";
            tsmiThroughputConsumer.Click += tsmiThroughputConsumer_Click;
            // 
            // tsmiUART
            // 
            tsmiUART.Name = "tsmiUART";
            tsmiUART.Size = new System.Drawing.Size(192, 22);
            tsmiUART.Text = "UART";
            // 
            // tsmiPinStateViewer
            // 
            tsmiPinStateViewer.Name = "tsmiPinStateViewer";
            tsmiPinStateViewer.Size = new System.Drawing.Size(192, 22);
            tsmiPinStateViewer.Text = "PinStateViewer";
            // 
            // queueToolStripMenuItem
            // 
            queueToolStripMenuItem.Name = "queueToolStripMenuItem";
            queueToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            queueToolStripMenuItem.Text = "Queue";
            queueToolStripMenuItem.Click += queueToolStripMenuItem_Click_1;
            // 
            // monitorPublicDataToolStripMenuItem
            // 
            monitorPublicDataToolStripMenuItem.Name = "monitorPublicDataToolStripMenuItem";
            monitorPublicDataToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            monitorPublicDataToolStripMenuItem.Text = "Monitor Public Data";
            // 
            // dataLoggerToolStripMenuItem
            // 
            dataLoggerToolStripMenuItem.Name = "dataLoggerToolStripMenuItem";
            dataLoggerToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            dataLoggerToolStripMenuItem.Text = "Data Logger";
            dataLoggerToolStripMenuItem.Click += dataLoggerToolStripMenuItem_Click;
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { tsmiDebounce, highSpeedCounterToolStripMenuItem1, iRRxToolStripMenuItem, tsmiMatrixKeypad, tsmiPulseTimer, tsmiQuadratureEncoder, tsmiUltrasonicDistanceSensor });
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new System.Drawing.Size(192, 22);
            toolStripMenuItem4.Text = "Digital Input Modes";
            // 
            // tsmiDebounce
            // 
            tsmiDebounce.Name = "tsmiDebounce";
            tsmiDebounce.Size = new System.Drawing.Size(208, 22);
            tsmiDebounce.Text = "Debounce";
            // 
            // highSpeedCounterToolStripMenuItem1
            // 
            highSpeedCounterToolStripMenuItem1.Name = "highSpeedCounterToolStripMenuItem1";
            highSpeedCounterToolStripMenuItem1.Size = new System.Drawing.Size(208, 22);
            highSpeedCounterToolStripMenuItem1.Text = "High Speed Counter";
            highSpeedCounterToolStripMenuItem1.Click += highSpeedCounterToolStripMenuItem_Click;
            // 
            // tsmiMatrixKeypad
            // 
            tsmiMatrixKeypad.Name = "tsmiMatrixKeypad";
            tsmiMatrixKeypad.Size = new System.Drawing.Size(208, 22);
            tsmiMatrixKeypad.Text = "Matrix Keypad";
            // 
            // tsmiPulseTimer
            // 
            tsmiPulseTimer.Name = "tsmiPulseTimer";
            tsmiPulseTimer.Size = new System.Drawing.Size(208, 22);
            tsmiPulseTimer.Text = "PulseTimer";
            // 
            // tsmiQuadratureEncoder
            // 
            tsmiQuadratureEncoder.Name = "tsmiQuadratureEncoder";
            tsmiQuadratureEncoder.Size = new System.Drawing.Size(208, 22);
            tsmiQuadratureEncoder.Text = "Quadrature Encoder";
            // 
            // tsmiUltrasonicDistanceSensor
            // 
            tsmiUltrasonicDistanceSensor.Name = "tsmiUltrasonicDistanceSensor";
            tsmiUltrasonicDistanceSensor.Size = new System.Drawing.Size(208, 22);
            tsmiUltrasonicDistanceSensor.Text = "UltraSonicDistanceSensor";
            // 
            // toolStripMenuItem5
            // 
            toolStripMenuItem5.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { toolStripMenuItem3, tsmiHBridge, highSpeedClockToolStripMenuItem, tsmiPWM, tsmiPulseOnChange, toolStripMenuItem1, tsmiServo, tsmiWatchdog });
            toolStripMenuItem5.Name = "toolStripMenuItem5";
            toolStripMenuItem5.Size = new System.Drawing.Size(192, 22);
            toolStripMenuItem5.Text = "Digital Output Modes";
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new System.Drawing.Size(182, 22);
            toolStripMenuItem3.Text = "Frequency Output";
            toolStripMenuItem3.Click += toolStripMenuItem3_Click;
            // 
            // tsmiHBridge
            // 
            tsmiHBridge.Name = "tsmiHBridge";
            tsmiHBridge.Size = new System.Drawing.Size(182, 22);
            tsmiHBridge.Text = "H Bridge";
            // 
            // highSpeedClockToolStripMenuItem
            // 
            highSpeedClockToolStripMenuItem.Name = "highSpeedClockToolStripMenuItem";
            highSpeedClockToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            highSpeedClockToolStripMenuItem.Text = "High Speed Clock";
            // 
            // tsmiPWM
            // 
            tsmiPWM.Name = "tsmiPWM";
            tsmiPWM.Size = new System.Drawing.Size(182, 22);
            tsmiPWM.Text = "PWM";
            // 
            // tsmiPulseOnChange
            // 
            tsmiPulseOnChange.Name = "tsmiPulseOnChange";
            tsmiPulseOnChange.Size = new System.Drawing.Size(182, 22);
            tsmiPulseOnChange.Text = "Pulse On Change";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new System.Drawing.Size(182, 22);
            toolStripMenuItem1.Text = "QueuedPulseOutput";
            // 
            // tsmiServo
            // 
            tsmiServo.Name = "tsmiServo";
            tsmiServo.Size = new System.Drawing.Size(182, 22);
            tsmiServo.Text = "Servo";
            // 
            // tsmiWatchdog
            // 
            tsmiWatchdog.Name = "tsmiWatchdog";
            tsmiWatchdog.Size = new System.Drawing.Size(182, 22);
            tsmiWatchdog.Text = "Watchdog";
            // 
            // toolStripMenuItem6
            // 
            toolStripMenuItem6.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { tsmiLiquidCrystal, tmsiTM1637, toolStripMenuItem2, tsmiWS2812 });
            toolStripMenuItem6.Name = "toolStripMenuItem6";
            toolStripMenuItem6.Size = new System.Drawing.Size(192, 22);
            toolStripMenuItem6.Text = "Display Modes";
            // 
            // tsmiLiquidCrystal
            // 
            tsmiLiquidCrystal.Name = "tsmiLiquidCrystal";
            tsmiLiquidCrystal.Size = new System.Drawing.Size(143, 22);
            tsmiLiquidCrystal.Text = "LiquidCrystal";
            // 
            // tmsiTM1637
            // 
            tmsiTM1637.Name = "tmsiTM1637";
            tmsiTM1637.Size = new System.Drawing.Size(143, 22);
            tmsiTM1637.Text = "TM1637";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new System.Drawing.Size(143, 22);
            toolStripMenuItem2.Text = "SW18ABVGA";
            // 
            // tsmiWS2812
            // 
            tsmiWS2812.Name = "tsmiWS2812";
            tsmiWS2812.Size = new System.Drawing.Size(143, 22);
            tsmiWS2812.Text = "WS2812";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(19, 23);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(12, 15);
            label1.TabIndex = 1;
            label1.Text = "-";
            // 
            // iRRxToolStripMenuItem
            // 
            iRRxToolStripMenuItem.Name = "iRRxToolStripMenuItem";
            iRRxToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            iRRxToolStripMenuItem.Text = "IR Rx";
            iRRxToolStripMenuItem.Click += iRRxToolStripMenuItem_Click;
            // 
            // GraphicPinSelectorControl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(groupBox1);
            Name = "GraphicPinSelectorControl";
            Size = new System.Drawing.Size(276, 509);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbModel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiInput;
        private System.Windows.Forms.ToolStripMenuItem tsmiHigh;
        private System.Windows.Forms.ToolStripMenuItem tsmiLow;
        private System.Windows.Forms.ToolStripMenuItem tsmiAnalogInput;
        private System.Windows.Forms.ToolStripMenuItem monitorPublicDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiPinStateViewer;
        private System.Windows.Forms.ToolStripMenuItem queueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiResistanceInput;
        private System.Windows.Forms.ToolStripMenuItem tsmiUART;
        private System.Windows.Forms.ToolStripMenuItem sW18ABCapTouchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiThroughputConsumer;
        private System.Windows.Forms.ToolStripMenuItem dataLoggerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem tsmiDebounce;
        private System.Windows.Forms.ToolStripMenuItem highSpeedCounterToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmiMatrixKeypad;
        private System.Windows.Forms.ToolStripMenuItem tsmiPulseTimer;
        private System.Windows.Forms.ToolStripMenuItem tsmiQuadratureEncoder;
        private System.Windows.Forms.ToolStripMenuItem tsmiUltrasonicDistanceSensor;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem tsmiHBridge;
        private System.Windows.Forms.ToolStripMenuItem highSpeedClockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiPWM;
        private System.Windows.Forms.ToolStripMenuItem tsmiPulseOnChange;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmiServo;
        private System.Windows.Forms.ToolStripMenuItem tsmiWatchdog;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem tsmiLiquidCrystal;
        private System.Windows.Forms.ToolStripMenuItem tmsiTM1637;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem tsmiWS2812;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem iRRxToolStripMenuItem;
    }
}
