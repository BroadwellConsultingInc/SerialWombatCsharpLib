namespace SerialWombatWindowsFormsLibrary
{
    partial class GraphicPinSelector
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiInput = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHigh = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLow = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAnalogInput = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDebounce = new System.Windows.Forms.ToolStripMenuItem();
            this.monitorPublicDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPulseOnChange = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPulseTimer = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPWM = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiQuadratureEncoder = new System.Windows.Forms.ToolStripMenuItem();
            this.queueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiResistanceInput = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiServo = new System.Windows.Forms.ToolStripMenuItem();
            this.tmsiTM1637 = new System.Windows.Forms.ToolStripMenuItem();
            this.ultraSonicDistanceSensorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiWatchdog = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbModel = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tsmiMatrixKeypad = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(25, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 324);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.DoubleClick += new System.EventHandler(this.pictureBox1_DoubleClick);
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiInput,
            this.tsmiHigh,
            this.tsmiLow,
            this.tsmiAnalogInput,
            this.tsmiDebounce,
            this.tsmiMatrixKeypad,
            this.monitorPublicDataToolStripMenuItem,
            this.toolStripMenuItem2,
            this.tsmiPulseOnChange,
            this.tsmiPulseTimer,
            this.tsmiPWM,
            this.tsmiQuadratureEncoder,
            this.queueToolStripMenuItem,
            this.tsmiResistanceInput,
            this.tsmiServo,
            this.tmsiTM1637,
            this.ultraSonicDistanceSensorToolStripMenuItem,
            this.tsmiWatchdog});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(209, 400);
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
            // tsmiDebounce
            // 
            this.tsmiDebounce.Name = "tsmiDebounce";
            this.tsmiDebounce.Size = new System.Drawing.Size(208, 22);
            this.tsmiDebounce.Text = "Debounce";
            // 
            // monitorPublicDataToolStripMenuItem
            // 
            this.monitorPublicDataToolStripMenuItem.Name = "monitorPublicDataToolStripMenuItem";
            this.monitorPublicDataToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.monitorPublicDataToolStripMenuItem.Text = "Monitor Public Data";
            this.monitorPublicDataToolStripMenuItem.Click += new System.EventHandler(this.monitorPublicDataToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(208, 22);
            this.toolStripMenuItem2.Text = "PinStateViewer";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
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
            this.queueToolStripMenuItem.Click += new System.EventHandler(this.queueToolStripMenuItem_Click);
            // 
            // tsmiResistanceInput
            // 
            this.tsmiResistanceInput.Name = "tsmiResistanceInput";
            this.tsmiResistanceInput.Size = new System.Drawing.Size(208, 22);
            this.tsmiResistanceInput.Text = "Resistance Input";
            this.tsmiResistanceInput.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // tsmiServo
            // 
            this.tsmiServo.Name = "tsmiServo";
            this.tsmiServo.Size = new System.Drawing.Size(208, 22);
            this.tsmiServo.Text = "Servo";
            // 
            // tmsiTM1637
            // 
            this.tmsiTM1637.Name = "tmsiTM1637";
            this.tmsiTM1637.Size = new System.Drawing.Size(208, 22);
            this.tmsiTM1637.Text = "TM1637";
            // 
            // ultraSonicDistanceSensorToolStripMenuItem
            // 
            this.ultraSonicDistanceSensorToolStripMenuItem.Name = "ultraSonicDistanceSensorToolStripMenuItem";
            this.ultraSonicDistanceSensorToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.ultraSonicDistanceSensorToolStripMenuItem.Text = "UltraSonicDistanceSensor";
            this.ultraSonicDistanceSensorToolStripMenuItem.Click += new System.EventHandler(this.ultraSonicDistanceSensorToolStripMenuItem_Click);
            // 
            // tsmiWatchdog
            // 
            this.tsmiWatchdog.Name = "tsmiWatchdog";
            this.tsmiWatchdog.Size = new System.Drawing.Size(208, 22);
            this.tsmiWatchdog.Text = "Watchdog";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbModel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(315, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(202, 438);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Graphic Pin Selector";
            // 
            // cbModel
            // 
            this.cbModel.FormattingEnabled = true;
            this.cbModel.Location = new System.Drawing.Point(25, 384);
            this.cbModel.Name = "cbModel";
            this.cbModel.Size = new System.Drawing.Size(157, 23);
            this.cbModel.TabIndex = 2;
            this.cbModel.SelectedIndexChanged += new System.EventHandler(this.cbModel_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "-";
            // 
            // tsmiMatrixKeypad
            // 
            this.tsmiMatrixKeypad.Name = "tsmiMatrixKeypad";
            this.tsmiMatrixKeypad.Size = new System.Drawing.Size(208, 22);
            this.tsmiMatrixKeypad.Text = "Matrix Keypad";
            // 
            // GraphicPinSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 526);
            this.Controls.Add(this.groupBox1);
            this.Name = "GraphicPinSelector";
            this.Text = "GraphicPinSelector";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiInput;
        private System.Windows.Forms.ToolStripMenuItem tsmiHigh;
        private System.Windows.Forms.ToolStripMenuItem tsmiLow;
        private System.Windows.Forms.ToolStripMenuItem tsmiAnalogInput;
        private System.Windows.Forms.ToolStripMenuItem tsmiPWM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem tsmiServo;
        private System.Windows.Forms.ToolStripMenuItem tsmiQuadratureEncoder;
        private System.Windows.Forms.ComboBox cbModel;
        private System.Windows.Forms.ToolStripMenuItem tsmiPulseTimer;
        private System.Windows.Forms.ToolStripMenuItem tsmiWatchdog;
        private System.Windows.Forms.ToolStripMenuItem tsmiDebounce;
        private System.Windows.Forms.ToolStripMenuItem monitorPublicDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiResistanceInput;
        private System.Windows.Forms.ToolStripMenuItem queueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem ultraSonicDistanceSensorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tmsiTM1637;
        private System.Windows.Forms.ToolStripMenuItem tsmiPulseOnChange;
        private System.Windows.Forms.ToolStripMenuItem tsmiMatrixKeypad;
    }
}