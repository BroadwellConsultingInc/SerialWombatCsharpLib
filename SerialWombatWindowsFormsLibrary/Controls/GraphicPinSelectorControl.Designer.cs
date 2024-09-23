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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbModel = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiInput = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHigh = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLow = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAnalogInput = new System.Windows.Forms.ToolStripMenuItem();
            this.sW18ABCapTouchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiResistanceInput = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiThroughputConsumer = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUART = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPinStateViewer = new System.Windows.Forms.ToolStripMenuItem();
            this.queueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monitorPublicDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataLoggerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDebounce = new System.Windows.Forms.ToolStripMenuItem();
            this.highSpeedCounterToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMatrixKeypad = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPulseTimer = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiQuadratureEncoder = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUltrasonicDistanceSensor = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHBridge = new System.Windows.Forms.ToolStripMenuItem();
            this.highSpeedClockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPWM = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPulseOnChange = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiServo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiWatchdog = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLiquidCrystal = new System.Windows.Forms.ToolStripMenuItem();
            this.tmsiTM1637 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiWS2812 = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbModel);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(202, 438);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Graphic Pin Selector";
            // 
            // cbModel
            // 
            this.cbModel.FormattingEnabled = true;
            this.cbModel.Location = new System.Drawing.Point(19, 384);
            this.cbModel.Name = "cbModel";
            this.cbModel.Size = new System.Drawing.Size(157, 23);
            this.cbModel.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(19, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 324);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiInput,
            this.tsmiHigh,
            this.tsmiLow,
            this.tsmiAnalogInput,
            this.sW18ABCapTouchToolStripMenuItem,
            this.tsmiResistanceInput,
            this.tsmiThroughputConsumer,
            this.tsmiUART,
            this.tsmiPinStateViewer,
            this.queueToolStripMenuItem,
            this.monitorPublicDataToolStripMenuItem,
            this.dataLoggerToolStripMenuItem,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(193, 356);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // tsmiInput
            // 
            this.tsmiInput.Name = "tsmiInput";
            this.tsmiInput.Size = new System.Drawing.Size(192, 22);
            this.tsmiInput.Text = "Input";
            this.tsmiInput.Click += new System.EventHandler(this.tsmiInput_Click);
            // 
            // tsmiHigh
            // 
            this.tsmiHigh.Name = "tsmiHigh";
            this.tsmiHigh.Size = new System.Drawing.Size(192, 22);
            this.tsmiHigh.Text = "High";
            this.tsmiHigh.Click += new System.EventHandler(this.tsmiHigh_Click);
            // 
            // tsmiLow
            // 
            this.tsmiLow.Name = "tsmiLow";
            this.tsmiLow.Size = new System.Drawing.Size(192, 22);
            this.tsmiLow.Text = "Low";
            this.tsmiLow.Click += new System.EventHandler(this.tsmiLow_Click);
            // 
            // tsmiAnalogInput
            // 
            this.tsmiAnalogInput.Name = "tsmiAnalogInput";
            this.tsmiAnalogInput.Size = new System.Drawing.Size(192, 22);
            this.tsmiAnalogInput.Text = "AnalogInput";
            // 
            // sW18ABCapTouchToolStripMenuItem
            // 
            this.sW18ABCapTouchToolStripMenuItem.Name = "sW18ABCapTouchToolStripMenuItem";
            this.sW18ABCapTouchToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.sW18ABCapTouchToolStripMenuItem.Text = "SW18ABCapTouch";
            this.sW18ABCapTouchToolStripMenuItem.Click += new System.EventHandler(this.sW18ABCapTouchToolStripMenuItem_Click);
            // 
            // tsmiResistanceInput
            // 
            this.tsmiResistanceInput.Name = "tsmiResistanceInput";
            this.tsmiResistanceInput.Size = new System.Drawing.Size(192, 22);
            this.tsmiResistanceInput.Text = "Resistance Input";
            // 
            // tsmiThroughputConsumer
            // 
            this.tsmiThroughputConsumer.Name = "tsmiThroughputConsumer";
            this.tsmiThroughputConsumer.Size = new System.Drawing.Size(192, 22);
            this.tsmiThroughputConsumer.Text = "ThroughputConsumer";
            this.tsmiThroughputConsumer.Click += new System.EventHandler(this.tsmiThroughputConsumer_Click);
            // 
            // tsmiUART
            // 
            this.tsmiUART.Name = "tsmiUART";
            this.tsmiUART.Size = new System.Drawing.Size(192, 22);
            this.tsmiUART.Text = "UART";
            // 
            // tsmiPinStateViewer
            // 
            this.tsmiPinStateViewer.Name = "tsmiPinStateViewer";
            this.tsmiPinStateViewer.Size = new System.Drawing.Size(192, 22);
            this.tsmiPinStateViewer.Text = "PinStateViewer";
            // 
            // queueToolStripMenuItem
            // 
            this.queueToolStripMenuItem.Name = "queueToolStripMenuItem";
            this.queueToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.queueToolStripMenuItem.Text = "Queue";
            this.queueToolStripMenuItem.Click += new System.EventHandler(this.queueToolStripMenuItem_Click_1);
            // 
            // monitorPublicDataToolStripMenuItem
            // 
            this.monitorPublicDataToolStripMenuItem.Name = "monitorPublicDataToolStripMenuItem";
            this.monitorPublicDataToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.monitorPublicDataToolStripMenuItem.Text = "Monitor Public Data";
            // 
            // dataLoggerToolStripMenuItem
            // 
            this.dataLoggerToolStripMenuItem.Name = "dataLoggerToolStripMenuItem";
            this.dataLoggerToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.dataLoggerToolStripMenuItem.Text = "Data Logger";
            this.dataLoggerToolStripMenuItem.Click += new System.EventHandler(this.dataLoggerToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiDebounce,
            this.highSpeedCounterToolStripMenuItem1,
            this.tsmiMatrixKeypad,
            this.tsmiPulseTimer,
            this.tsmiQuadratureEncoder,
            this.tsmiUltrasonicDistanceSensor});
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(192, 22);
            this.toolStripMenuItem4.Text = "Digital Input Modes";
            // 
            // tsmiDebounce
            // 
            this.tsmiDebounce.Name = "tsmiDebounce";
            this.tsmiDebounce.Size = new System.Drawing.Size(208, 22);
            this.tsmiDebounce.Text = "Debounce";
            // 
            // highSpeedCounterToolStripMenuItem1
            // 
            this.highSpeedCounterToolStripMenuItem1.Name = "highSpeedCounterToolStripMenuItem1";
            this.highSpeedCounterToolStripMenuItem1.Size = new System.Drawing.Size(208, 22);
            this.highSpeedCounterToolStripMenuItem1.Text = "High Speed Counter";
            this.highSpeedCounterToolStripMenuItem1.Click += new System.EventHandler(this.highSpeedCounterToolStripMenuItem_Click);
            // 
            // tsmiMatrixKeypad
            // 
            this.tsmiMatrixKeypad.Name = "tsmiMatrixKeypad";
            this.tsmiMatrixKeypad.Size = new System.Drawing.Size(208, 22);
            this.tsmiMatrixKeypad.Text = "Matrix Keypad";
            // 
            // tsmiPulseTimer
            // 
            this.tsmiPulseTimer.Name = "tsmiPulseTimer";
            this.tsmiPulseTimer.Size = new System.Drawing.Size(208, 22);
            this.tsmiPulseTimer.Text = "PulseTimer";
            // 
            // tsmiQuadratureEncoder
            // 
            this.tsmiQuadratureEncoder.Name = "tsmiQuadratureEncoder";
            this.tsmiQuadratureEncoder.Size = new System.Drawing.Size(208, 22);
            this.tsmiQuadratureEncoder.Text = "Quadrature Encoder";
            // 
            // tsmiUltrasonicDistanceSensor
            // 
            this.tsmiUltrasonicDistanceSensor.Name = "tsmiUltrasonicDistanceSensor";
            this.tsmiUltrasonicDistanceSensor.Size = new System.Drawing.Size(208, 22);
            this.tsmiUltrasonicDistanceSensor.Text = "UltraSonicDistanceSensor";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3,
            this.tsmiHBridge,
            this.highSpeedClockToolStripMenuItem,
            this.tsmiPWM,
            this.tsmiPulseOnChange,
            this.toolStripMenuItem1,
            this.tsmiServo,
            this.tsmiWatchdog});
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(192, 22);
            this.toolStripMenuItem5.Text = "Digital Output Modes";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(182, 22);
            this.toolStripMenuItem3.Text = "Frequency Output";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // tsmiHBridge
            // 
            this.tsmiHBridge.Name = "tsmiHBridge";
            this.tsmiHBridge.Size = new System.Drawing.Size(182, 22);
            this.tsmiHBridge.Text = "H Bridge";
            // 
            // highSpeedClockToolStripMenuItem
            // 
            this.highSpeedClockToolStripMenuItem.Name = "highSpeedClockToolStripMenuItem";
            this.highSpeedClockToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.highSpeedClockToolStripMenuItem.Text = "High Speed Clock";
            // 
            // tsmiPWM
            // 
            this.tsmiPWM.Name = "tsmiPWM";
            this.tsmiPWM.Size = new System.Drawing.Size(182, 22);
            this.tsmiPWM.Text = "PWM";
            // 
            // tsmiPulseOnChange
            // 
            this.tsmiPulseOnChange.Name = "tsmiPulseOnChange";
            this.tsmiPulseOnChange.Size = new System.Drawing.Size(182, 22);
            this.tsmiPulseOnChange.Text = "Pulse On Change";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(182, 22);
            this.toolStripMenuItem1.Text = "QueuedPulseOutput";
            // 
            // tsmiServo
            // 
            this.tsmiServo.Name = "tsmiServo";
            this.tsmiServo.Size = new System.Drawing.Size(182, 22);
            this.tsmiServo.Text = "Servo";
            // 
            // tsmiWatchdog
            // 
            this.tsmiWatchdog.Name = "tsmiWatchdog";
            this.tsmiWatchdog.Size = new System.Drawing.Size(182, 22);
            this.tsmiWatchdog.Text = "Watchdog";
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiLiquidCrystal,
            this.tmsiTM1637,
            this.toolStripMenuItem2,
            this.tsmiWS2812});
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(192, 22);
            this.toolStripMenuItem6.Text = "Display Modes";
            // 
            // tsmiLiquidCrystal
            // 
            this.tsmiLiquidCrystal.Name = "tsmiLiquidCrystal";
            this.tsmiLiquidCrystal.Size = new System.Drawing.Size(143, 22);
            this.tsmiLiquidCrystal.Text = "LiquidCrystal";
            // 
            // tmsiTM1637
            // 
            this.tmsiTM1637.Name = "tmsiTM1637";
            this.tmsiTM1637.Size = new System.Drawing.Size(143, 22);
            this.tmsiTM1637.Text = "TM1637";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(143, 22);
            this.toolStripMenuItem2.Text = "SW18ABVGA";
            // 
            // tsmiWS2812
            // 
            this.tsmiWS2812.Name = "tsmiWS2812";
            this.tsmiWS2812.Size = new System.Drawing.Size(143, 22);
            this.tsmiWS2812.Text = "WS2812";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "-";
            // 
            // GraphicPinSelectorControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.groupBox1);
            this.Name = "GraphicPinSelectorControl";
            this.Size = new System.Drawing.Size(276, 509);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

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
    }
}
