﻿namespace SerialWombatWindowsFormsLibrary
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
            this.highSpeedClockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.highSpeedCounterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDebounce = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLiquidCrystal = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMatrixKeypad = new System.Windows.Forms.ToolStripMenuItem();
            this.monitorPublicDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPinStateViewer = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPulseOnChange = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPulseTimer = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPWM = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiQuadratureEncoder = new System.Windows.Forms.ToolStripMenuItem();
            this.queueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiResistanceInput = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiServo = new System.Windows.Forms.ToolStripMenuItem();
            this.sW18ABCapTouchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiThroughputConsumer = new System.Windows.Forms.ToolStripMenuItem();
            this.tmsiTM1637 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUART = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUltrasonicDistanceSensor = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiWatchdog = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiWS2812 = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.tsmiHBridge = new System.Windows.Forms.ToolStripMenuItem();
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
            this.tsmiHBridge,
            this.highSpeedClockToolStripMenuItem,
            this.highSpeedCounterToolStripMenuItem,
            this.tsmiDebounce,
            this.tsmiLiquidCrystal,
            this.tsmiMatrixKeypad,
            this.monitorPublicDataToolStripMenuItem,
            this.tsmiPinStateViewer,
            this.tsmiPulseOnChange,
            this.tsmiPulseTimer,
            this.tsmiPWM,
            this.tsmiQuadratureEncoder,
            this.queueToolStripMenuItem,
            this.tsmiResistanceInput,
            this.tsmiServo,
            this.sW18ABCapTouchToolStripMenuItem,
            this.tsmiThroughputConsumer,
            this.tmsiTM1637,
            this.tsmiUART,
            this.tsmiUltrasonicDistanceSensor,
            this.tsmiWatchdog,
            this.tsmiWS2812});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(209, 598);
            // 
            // tsmiInput
            // 
            this.tsmiInput.Name = "tsmiInput";
            this.tsmiInput.Size = new System.Drawing.Size(208, 22);
            this.tsmiInput.Text = "Input";
            this.tsmiInput.Click += new System.EventHandler(this.tsmiInput_Click);
            // 
            // tsmiHigh
            // 
            this.tsmiHigh.Name = "tsmiHigh";
            this.tsmiHigh.Size = new System.Drawing.Size(208, 22);
            this.tsmiHigh.Text = "High";
            this.tsmiHigh.Click += new System.EventHandler(this.tsmiHigh_Click);
            // 
            // tsmiLow
            // 
            this.tsmiLow.Name = "tsmiLow";
            this.tsmiLow.Size = new System.Drawing.Size(208, 22);
            this.tsmiLow.Text = "Low";
            this.tsmiLow.Click += new System.EventHandler(this.tsmiLow_Click);
            // 
            // tsmiAnalogInput
            // 
            this.tsmiAnalogInput.Name = "tsmiAnalogInput";
            this.tsmiAnalogInput.Size = new System.Drawing.Size(208, 22);
            this.tsmiAnalogInput.Text = "AnalogInput";
            // 
            // highSpeedClockToolStripMenuItem
            // 
            this.highSpeedClockToolStripMenuItem.Name = "highSpeedClockToolStripMenuItem";
            this.highSpeedClockToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.highSpeedClockToolStripMenuItem.Text = "High Speed Clock";
            this.highSpeedClockToolStripMenuItem.Click += new System.EventHandler(this.highSpeedClockToolStripMenuItem_Click);
            // 
            // highSpeedCounterToolStripMenuItem
            // 
            this.highSpeedCounterToolStripMenuItem.Name = "highSpeedCounterToolStripMenuItem";
            this.highSpeedCounterToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.highSpeedCounterToolStripMenuItem.Text = "High Speed Counter";
            this.highSpeedCounterToolStripMenuItem.Click += new System.EventHandler(this.highSpeedCounterToolStripMenuItem_Click);
            // 
            // tsmiDebounce
            // 
            this.tsmiDebounce.Name = "tsmiDebounce";
            this.tsmiDebounce.Size = new System.Drawing.Size(208, 22);
            this.tsmiDebounce.Text = "Debounce";
            // 
            // tsmiLiquidCrystal
            // 
            this.tsmiLiquidCrystal.Name = "tsmiLiquidCrystal";
            this.tsmiLiquidCrystal.Size = new System.Drawing.Size(208, 22);
            this.tsmiLiquidCrystal.Text = "LiquidCrystal";
            // 
            // tsmiMatrixKeypad
            // 
            this.tsmiMatrixKeypad.Name = "tsmiMatrixKeypad";
            this.tsmiMatrixKeypad.Size = new System.Drawing.Size(208, 22);
            this.tsmiMatrixKeypad.Text = "Matrix Keypad";
            // 
            // monitorPublicDataToolStripMenuItem
            // 
            this.monitorPublicDataToolStripMenuItem.Name = "monitorPublicDataToolStripMenuItem";
            this.monitorPublicDataToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.monitorPublicDataToolStripMenuItem.Text = "Monitor Public Data";
            // 
            // tsmiPinStateViewer
            // 
            this.tsmiPinStateViewer.Name = "tsmiPinStateViewer";
            this.tsmiPinStateViewer.Size = new System.Drawing.Size(208, 22);
            this.tsmiPinStateViewer.Text = "PinStateViewer";
            // 
            // tsmiPulseOnChange
            // 
            this.tsmiPulseOnChange.Name = "tsmiPulseOnChange";
            this.tsmiPulseOnChange.Size = new System.Drawing.Size(208, 22);
            this.tsmiPulseOnChange.Text = "Pulse On Change";
            // 
            // tsmiPulseTimer
            // 
            this.tsmiPulseTimer.Name = "tsmiPulseTimer";
            this.tsmiPulseTimer.Size = new System.Drawing.Size(208, 22);
            this.tsmiPulseTimer.Text = "PulseTimer";
            // 
            // tsmiPWM
            // 
            this.tsmiPWM.Name = "tsmiPWM";
            this.tsmiPWM.Size = new System.Drawing.Size(208, 22);
            this.tsmiPWM.Text = "PWM";
            // 
            // tsmiQuadratureEncoder
            // 
            this.tsmiQuadratureEncoder.Name = "tsmiQuadratureEncoder";
            this.tsmiQuadratureEncoder.Size = new System.Drawing.Size(208, 22);
            this.tsmiQuadratureEncoder.Text = "Quadrature Encoder";
            // 
            // queueToolStripMenuItem
            // 
            this.queueToolStripMenuItem.Name = "queueToolStripMenuItem";
            this.queueToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.queueToolStripMenuItem.Text = "Queue";
            this.queueToolStripMenuItem.Click += new System.EventHandler(this.queueToolStripMenuItem_Click_1);
            // 
            // tsmiResistanceInput
            // 
            this.tsmiResistanceInput.Name = "tsmiResistanceInput";
            this.tsmiResistanceInput.Size = new System.Drawing.Size(208, 22);
            this.tsmiResistanceInput.Text = "Resistance Input";
            // 
            // tsmiServo
            // 
            this.tsmiServo.Name = "tsmiServo";
            this.tsmiServo.Size = new System.Drawing.Size(208, 22);
            this.tsmiServo.Text = "Servo";
            // 
            // sW18ABCapTouchToolStripMenuItem
            // 
            this.sW18ABCapTouchToolStripMenuItem.Name = "sW18ABCapTouchToolStripMenuItem";
            this.sW18ABCapTouchToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.sW18ABCapTouchToolStripMenuItem.Text = "SW18ABCapTouch";
            this.sW18ABCapTouchToolStripMenuItem.Click += new System.EventHandler(this.sW18ABCapTouchToolStripMenuItem_Click);
            // 
            // tsmiThroughputConsumer
            // 
            this.tsmiThroughputConsumer.Name = "tsmiThroughputConsumer";
            this.tsmiThroughputConsumer.Size = new System.Drawing.Size(208, 22);
            this.tsmiThroughputConsumer.Text = "ThroughputConsumer";
            this.tsmiThroughputConsumer.Click += new System.EventHandler(this.tsmiThroughputConsumer_Click);
            // 
            // tmsiTM1637
            // 
            this.tmsiTM1637.Name = "tmsiTM1637";
            this.tmsiTM1637.Size = new System.Drawing.Size(208, 22);
            this.tmsiTM1637.Text = "TM1637";
            // 
            // tsmiUART
            // 
            this.tsmiUART.Name = "tsmiUART";
            this.tsmiUART.Size = new System.Drawing.Size(208, 22);
            this.tsmiUART.Text = "UART";
            // 
            // tsmiUltrasonicDistanceSensor
            // 
            this.tsmiUltrasonicDistanceSensor.Name = "tsmiUltrasonicDistanceSensor";
            this.tsmiUltrasonicDistanceSensor.Size = new System.Drawing.Size(208, 22);
            this.tsmiUltrasonicDistanceSensor.Text = "UltraSonicDistanceSensor";
            // 
            // tsmiWatchdog
            // 
            this.tsmiWatchdog.Name = "tsmiWatchdog";
            this.tsmiWatchdog.Size = new System.Drawing.Size(208, 22);
            this.tsmiWatchdog.Text = "Watchdog";
            // 
            // tsmiWS2812
            // 
            this.tsmiWS2812.Name = "tsmiWS2812";
            this.tsmiWS2812.Size = new System.Drawing.Size(208, 22);
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
            // tsmiHBridge
            // 
            this.tsmiHBridge.Name = "tsmiHBridge";
            this.tsmiHBridge.Size = new System.Drawing.Size(208, 22);
            this.tsmiHBridge.Text = "H Bridge";
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
        private System.Windows.Forms.ToolStripMenuItem tsmiDebounce;
        private System.Windows.Forms.ToolStripMenuItem tsmiMatrixKeypad;
        private System.Windows.Forms.ToolStripMenuItem monitorPublicDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiPinStateViewer;
        private System.Windows.Forms.ToolStripMenuItem tsmiPulseOnChange;
        private System.Windows.Forms.ToolStripMenuItem tsmiPulseTimer;
        private System.Windows.Forms.ToolStripMenuItem tsmiPWM;
        private System.Windows.Forms.ToolStripMenuItem tsmiQuadratureEncoder;
        private System.Windows.Forms.ToolStripMenuItem queueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiResistanceInput;
        private System.Windows.Forms.ToolStripMenuItem tsmiServo;
        private System.Windows.Forms.ToolStripMenuItem tmsiTM1637;
        private System.Windows.Forms.ToolStripMenuItem tsmiUltrasonicDistanceSensor;
        private System.Windows.Forms.ToolStripMenuItem tsmiWatchdog;
        private System.Windows.Forms.ToolStripMenuItem tsmiWS2812;
        private System.Windows.Forms.ToolStripMenuItem tsmiUART;
        private System.Windows.Forms.ToolStripMenuItem tsmiLiquidCrystal;
        private System.Windows.Forms.ToolStripMenuItem sW18ABCapTouchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem highSpeedClockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem highSpeedCounterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiThroughputConsumer;
        private System.Windows.Forms.ToolStripMenuItem tsmiHBridge;
    }
}
