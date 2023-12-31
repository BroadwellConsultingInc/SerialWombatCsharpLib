namespace SerialWombatWindowsFormsLibrary.Controls
{
    partial class UltrasonicDistanceSensorControl
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
            this.realTimeScottPlot1 = new SerialWombatWindowsFormsLibrary.Controls.RealTimeScottPlot();
            this.bConfigure = new System.Windows.Forms.Button();
            this.tbTriggerPin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ckbAutosample = new System.Windows.Forms.CheckBox();
            this.bSample = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ckbReverse = new System.Windows.Forms.CheckBox();
            this.ckbServoAutoSample = new System.Windows.Forms.CheckBox();
            this.formsPlot1 = new ScottPlot.FormsPlot();
            this.sbacMemoryIndex = new SerialWombatWindowsFormsLibrary.SixteenBitAddressControl();
            this.bservoSweepConfigure = new System.Windows.Forms.Button();
            this.ckbservoSweepEnable = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nudReturnDelay = new System.Windows.Forms.NumericUpDown();
            this.nudMoveDelay = new System.Windows.Forms.NumericUpDown();
            this.nudServoIncrement = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.nudServoPin = new System.Windows.Forms.NumericUpDown();
            this.nudServoPositions = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudReturnDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMoveDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudServoIncrement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudServoPin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudServoPositions)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.realTimeScottPlot1);
            this.groupBox1.Controls.Add(this.bConfigure);
            this.groupBox1.Controls.Add(this.tbTriggerPin);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ckbAutosample);
            this.groupBox1.Controls.Add(this.bSample);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(453, 544);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // realTimeScottPlot1
            // 
            this.realTimeScottPlot1.Location = new System.Drawing.Point(12, 137);
            this.realTimeScottPlot1.Name = "realTimeScottPlot1";
            this.realTimeScottPlot1.Size = new System.Drawing.Size(429, 256);
            this.realTimeScottPlot1.TabIndex = 8;
            // 
            // bConfigure
            // 
            this.bConfigure.Location = new System.Drawing.Point(6, 59);
            this.bConfigure.Name = "bConfigure";
            this.bConfigure.Size = new System.Drawing.Size(75, 23);
            this.bConfigure.TabIndex = 7;
            this.bConfigure.Text = "Configure";
            this.bConfigure.UseVisualStyleBackColor = true;
            this.bConfigure.Click += new System.EventHandler(this.bConfigure_Click);
            // 
            // tbTriggerPin
            // 
            this.tbTriggerPin.Location = new System.Drawing.Point(81, 99);
            this.tbTriggerPin.Name = "tbTriggerPin";
            this.tbTriggerPin.Size = new System.Drawing.Size(100, 23);
            this.tbTriggerPin.TabIndex = 5;
            this.tbTriggerPin.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Trigger Pin:";
            // 
            // ckbAutosample
            // 
            this.ckbAutosample.AutoSize = true;
            this.ckbAutosample.Location = new System.Drawing.Point(288, 26);
            this.ckbAutosample.Name = "ckbAutosample";
            this.ckbAutosample.Size = new System.Drawing.Size(90, 19);
            this.ckbAutosample.TabIndex = 3;
            this.ckbAutosample.Text = "Autosample";
            this.ckbAutosample.UseVisualStyleBackColor = true;
            this.ckbAutosample.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // bSample
            // 
            this.bSample.Location = new System.Drawing.Point(6, 22);
            this.bSample.Name = "bSample";
            this.bSample.Size = new System.Drawing.Size(75, 23);
            this.bSample.TabIndex = 2;
            this.bSample.Text = "Sample";
            this.bSample.UseVisualStyleBackColor = true;
            this.bSample.Click += new System.EventHandler(this.bSample_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(466, 590);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(458, 562);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Sensor";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ckbReverse);
            this.tabPage2.Controls.Add(this.ckbServoAutoSample);
            this.tabPage2.Controls.Add(this.formsPlot1);
            this.tabPage2.Controls.Add(this.sbacMemoryIndex);
            this.tabPage2.Controls.Add(this.bservoSweepConfigure);
            this.tabPage2.Controls.Add(this.ckbservoSweepEnable);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.nudReturnDelay);
            this.tabPage2.Controls.Add(this.nudMoveDelay);
            this.tabPage2.Controls.Add(this.nudServoIncrement);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.nudServoPin);
            this.tabPage2.Controls.Add(this.nudServoPositions);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(458, 562);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Servo Sweep";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ckbReverse
            // 
            this.ckbReverse.AutoSize = true;
            this.ckbReverse.Location = new System.Drawing.Point(386, 390);
            this.ckbReverse.Name = "ckbReverse";
            this.ckbReverse.Size = new System.Drawing.Size(66, 19);
            this.ckbReverse.TabIndex = 18;
            this.ckbReverse.Text = "Reverse";
            this.ckbReverse.UseVisualStyleBackColor = true;
            // 
            // ckbServoAutoSample
            // 
            this.ckbServoAutoSample.AutoSize = true;
            this.ckbServoAutoSample.Location = new System.Drawing.Point(267, 528);
            this.ckbServoAutoSample.Name = "ckbServoAutoSample";
            this.ckbServoAutoSample.Size = new System.Drawing.Size(91, 19);
            this.ckbServoAutoSample.TabIndex = 17;
            this.ckbServoAutoSample.Text = "AutoSample";
            this.ckbServoAutoSample.UseVisualStyleBackColor = true;
            this.ckbServoAutoSample.CheckedChanged += new System.EventHandler(this.ckbServoAutoSample_CheckedChanged);
            // 
            // formsPlot1
            // 
            this.formsPlot1.Location = new System.Drawing.Point(21, 17);
            this.formsPlot1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.formsPlot1.Name = "formsPlot1";
            this.formsPlot1.Size = new System.Drawing.Size(412, 342);
            this.formsPlot1.TabIndex = 16;
            this.formsPlot1.Load += new System.EventHandler(this.formsPlot1_Load);
            // 
            // sbacMemoryIndex
            // 
            this.sbacMemoryIndex.AutoSize = true;
            this.sbacMemoryIndex.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.sbacMemoryIndex.Location = new System.Drawing.Point(314, 385);
            this.sbacMemoryIndex.Name = "sbacMemoryIndex";
            this.sbacMemoryIndex.Size = new System.Drawing.Size(56, 26);
            this.sbacMemoryIndex.TabIndex = 1;
            this.sbacMemoryIndex.Value = ((ushort)(0));
            // 
            // bservoSweepConfigure
            // 
            this.bservoSweepConfigure.Location = new System.Drawing.Point(21, 522);
            this.bservoSweepConfigure.Name = "bservoSweepConfigure";
            this.bservoSweepConfigure.Size = new System.Drawing.Size(75, 23);
            this.bservoSweepConfigure.TabIndex = 7;
            this.bservoSweepConfigure.Text = "Configure";
            this.bservoSweepConfigure.UseVisualStyleBackColor = true;
            this.bservoSweepConfigure.Click += new System.EventHandler(this.bservoSweepConfigure_Click);
            // 
            // ckbservoSweepEnable
            // 
            this.ckbservoSweepEnable.AutoSize = true;
            this.ckbservoSweepEnable.Location = new System.Drawing.Point(120, 526);
            this.ckbservoSweepEnable.Name = "ckbservoSweepEnable";
            this.ckbservoSweepEnable.Size = new System.Drawing.Size(130, 19);
            this.ckbservoSweepEnable.TabIndex = 8;
            this.ckbservoSweepEnable.Text = "Servo Sweep Enable";
            this.ckbservoSweepEnable.UseVisualStyleBackColor = true;
            this.ckbservoSweepEnable.CheckedChanged += new System.EventHandler(this.ckbservoSweepEnable_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(215, 390);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 15);
            this.label8.TabIndex = 10;
            this.label8.Text = "Memory Index";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 396);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "ServoPin";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(210, 495);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "Return Delay(ms)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 493);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "Move Delay (ms)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(215, 459);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "Servo Increment";
            // 
            // nudReturnDelay
            // 
            this.nudReturnDelay.Location = new System.Drawing.Point(309, 493);
            this.nudReturnDelay.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.nudReturnDelay.Name = "nudReturnDelay";
            this.nudReturnDelay.Size = new System.Drawing.Size(75, 23);
            this.nudReturnDelay.TabIndex = 6;
            this.nudReturnDelay.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // nudMoveDelay
            // 
            this.nudMoveDelay.Location = new System.Drawing.Point(120, 491);
            this.nudMoveDelay.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.nudMoveDelay.Name = "nudMoveDelay";
            this.nudMoveDelay.Size = new System.Drawing.Size(75, 23);
            this.nudMoveDelay.TabIndex = 5;
            this.nudMoveDelay.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // nudServoIncrement
            // 
            this.nudServoIncrement.Location = new System.Drawing.Point(314, 457);
            this.nudServoIncrement.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.nudServoIncrement.Name = "nudServoIncrement";
            this.nudServoIncrement.Size = new System.Drawing.Size(75, 23);
            this.nudServoIncrement.TabIndex = 4;
            this.nudServoIncrement.Value = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 453);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Servo Positions";
            // 
            // nudServoPin
            // 
            this.nudServoPin.Location = new System.Drawing.Point(120, 388);
            this.nudServoPin.Maximum = new decimal(new int[] {
            19,
            0,
            0,
            0});
            this.nudServoPin.Name = "nudServoPin";
            this.nudServoPin.Size = new System.Drawing.Size(75, 23);
            this.nudServoPin.TabIndex = 0;
            this.nudServoPin.Value = new decimal(new int[] {
            19,
            0,
            0,
            0});
            // 
            // nudServoPositions
            // 
            this.nudServoPositions.Location = new System.Drawing.Point(120, 451);
            this.nudServoPositions.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.nudServoPositions.Name = "nudServoPositions";
            this.nudServoPositions.Size = new System.Drawing.Size(75, 23);
            this.nudServoPositions.TabIndex = 3;
            this.nudServoPositions.Value = new decimal(new int[] {
            64,
            0,
            0,
            0});
            // 
            // UltrasonicDistanceSensorControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.tabControl1);
            this.Name = "UltrasonicDistanceSensorControl";
            this.Size = new System.Drawing.Size(472, 593);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudReturnDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMoveDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudServoIncrement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudServoPin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudServoPositions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bConfigure;
        private System.Windows.Forms.TextBox tbTriggerPin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ckbAutosample;
        private System.Windows.Forms.Button bSample;
        private RealTimeScottPlot realTimeScottPlot1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudServoIncrement;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudServoPositions;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudServoPin;
        private System.Windows.Forms.Button bservoSweepConfigure;
        private System.Windows.Forms.CheckBox ckbservoSweepEnable;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudReturnDelay;
        private System.Windows.Forms.NumericUpDown nudMoveDelay;
        private SixteenBitAddressControl sbacMemoryIndex;
        private System.Windows.Forms.Label label8;
        private ScottPlot.FormsPlot formsPlot1;
        private System.Windows.Forms.CheckBox ckbServoAutoSample;
        private System.Windows.Forms.CheckBox ckbReverse;
    }
}
