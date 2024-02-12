namespace SerialWombatWindowsFormsLibrary
{
    partial class PWMForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lPeriod = new System.Windows.Forms.Label();
            this.tbSW18ABPeriod = new System.Windows.Forms.TextBox();
            this.lDutyCycle = new System.Windows.Forms.Label();
            this.cbWombat4ABFreq = new System.Windows.Forms.ComboBox();
            this.ckbInvertSignal = new System.Windows.Forms.CheckBox();
            this.bSetPWM = new System.Windows.Forms.Button();
            this.bConfigure = new System.Windows.Forms.Button();
            this.lCommandPin = new System.Windows.Forms.Label();
            this.tbCommandPin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPosition = new System.Windows.Forms.TextBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.bRename = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lPeriod);
            this.groupBox1.Controls.Add(this.tbSW18ABPeriod);
            this.groupBox1.Controls.Add(this.lDutyCycle);
            this.groupBox1.Controls.Add(this.cbWombat4ABFreq);
            this.groupBox1.Controls.Add(this.ckbInvertSignal);
            this.groupBox1.Controls.Add(this.bSetPWM);
            this.groupBox1.Controls.Add(this.bConfigure);
            this.groupBox1.Controls.Add(this.lCommandPin);
            this.groupBox1.Controls.Add(this.tbCommandPin);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbPosition);
            this.groupBox1.Controls.Add(this.trackBar1);
            this.groupBox1.Location = new System.Drawing.Point(2, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 220);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // lPeriod
            // 
            this.lPeriod.AutoSize = true;
            this.lPeriod.Location = new System.Drawing.Point(201, 171);
            this.lPeriod.Name = "lPeriod";
            this.lPeriod.Size = new System.Drawing.Size(65, 15);
            this.lPeriod.TabIndex = 12;
            this.lPeriod.Text = "Period (uS)";
            this.lPeriod.Visible = false;
            // 
            // tbSW18ABPeriod
            // 
            this.tbSW18ABPeriod.Location = new System.Drawing.Point(76, 145);
            this.tbSW18ABPeriod.Name = "tbSW18ABPeriod";
            this.tbSW18ABPeriod.Size = new System.Drawing.Size(100, 23);
            this.tbSW18ABPeriod.TabIndex = 11;
            this.tbSW18ABPeriod.Text = "1000";
            this.tbSW18ABPeriod.Visible = false;
            // 
            // lDutyCycle
            // 
            this.lDutyCycle.AutoSize = true;
            this.lDutyCycle.Location = new System.Drawing.Point(201, 22);
            this.lDutyCycle.Name = "lDutyCycle";
            this.lDutyCycle.Size = new System.Drawing.Size(38, 15);
            this.lDutyCycle.TabIndex = 10;
            this.lDutyCycle.Text = "label3";
            // 
            // cbWombat4ABFreq
            // 
            this.cbWombat4ABFreq.FormattingEnabled = true;
            this.cbWombat4ABFreq.Location = new System.Drawing.Point(55, 145);
            this.cbWombat4ABFreq.Name = "cbWombat4ABFreq";
            this.cbWombat4ABFreq.Size = new System.Drawing.Size(164, 23);
            this.cbWombat4ABFreq.TabIndex = 9;
            this.cbWombat4ABFreq.SelectedIndexChanged += new System.EventHandler(this.cbWombat4ABFreq_SelectedIndexChanged);
            // 
            // ckbInvertSignal
            // 
            this.ckbInvertSignal.AutoSize = true;
            this.ckbInvertSignal.Location = new System.Drawing.Point(93, 120);
            this.ckbInvertSignal.Name = "ckbInvertSignal";
            this.ckbInvertSignal.Size = new System.Drawing.Size(91, 19);
            this.ckbInvertSignal.TabIndex = 6;
            this.ckbInvertSignal.Text = "Invert Signal";
            this.ckbInvertSignal.UseVisualStyleBackColor = true;
            // 
            // bSetPWM
            // 
            this.bSetPWM.Enabled = false;
            this.bSetPWM.Location = new System.Drawing.Point(91, 191);
            this.bSetPWM.Name = "bSetPWM";
            this.bSetPWM.Size = new System.Drawing.Size(85, 23);
            this.bSetPWM.TabIndex = 4;
            this.bSetPWM.Text = "Set PWM";
            this.bSetPWM.UseVisualStyleBackColor = true;
            this.bSetPWM.Click += new System.EventHandler(this.bSetPosition_Click);
            // 
            // bConfigure
            // 
            this.bConfigure.Location = new System.Drawing.Point(10, 191);
            this.bConfigure.Name = "bConfigure";
            this.bConfigure.Size = new System.Drawing.Size(75, 23);
            this.bConfigure.TabIndex = 3;
            this.bConfigure.Text = "Configure";
            this.bConfigure.UseVisualStyleBackColor = true;
            this.bConfigure.Click += new System.EventHandler(this.bConfigure_Click);
            // 
            // lCommandPin
            // 
            this.lCommandPin.AutoSize = true;
            this.lCommandPin.Location = new System.Drawing.Point(10, 91);
            this.lCommandPin.Name = "lCommandPin";
            this.lCommandPin.Size = new System.Drawing.Size(87, 15);
            this.lCommandPin.TabIndex = 2;
            this.lCommandPin.Text = "Command Pin:";
            this.lCommandPin.Visible = false;
            // 
            // tbCommandPin
            // 
            this.tbCommandPin.Location = new System.Drawing.Point(103, 91);
            this.tbCommandPin.Name = "tbCommandPin";
            this.tbCommandPin.Size = new System.Drawing.Size(40, 23);
            this.tbCommandPin.TabIndex = 1;
            this.tbCommandPin.Text = "0";
            this.tbCommandPin.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Duty Cycle";
            // 
            // tbPosition
            // 
            this.tbPosition.Location = new System.Drawing.Point(80, 19);
            this.tbPosition.Name = "tbPosition";
            this.tbPosition.Size = new System.Drawing.Size(100, 23);
            this.tbPosition.TabIndex = 1;
            this.tbPosition.Text = "0";
            // 
            // trackBar1
            // 
            this.trackBar1.Enabled = false;
            this.trackBar1.Location = new System.Drawing.Point(6, 52);
            this.trackBar1.Maximum = 65535;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(270, 45);
            this.trackBar1.TabIndex = 0;
            this.trackBar1.TickFrequency = 4096;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // bRename
            // 
            this.bRename.Location = new System.Drawing.Point(1, 238);
            this.bRename.Name = "bRename";
            this.bRename.Size = new System.Drawing.Size(75, 23);
            this.bRename.TabIndex = 1;
            this.bRename.Text = "Rename";
            this.bRename.UseVisualStyleBackColor = true;
            this.bRename.Click += new System.EventHandler(this.bRename_Click);
            // 
            // PWMForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(304, 331);
            this.Controls.Add(this.bRename);
            this.Controls.Add(this.groupBox1);
            this.Name = "PWMForm";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox ckbInvertSignal;
        private System.Windows.Forms.Button bSetPWM;
        private System.Windows.Forms.Button bConfigure;
        private System.Windows.Forms.Label lCommandPin;
        private System.Windows.Forms.TextBox tbCommandPin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPosition;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.ComboBox cbWombat4ABFreq;
        private System.Windows.Forms.Label lDutyCycle;
        private System.Windows.Forms.TextBox tbSW18ABPeriod;
        private System.Windows.Forms.Label lPeriod;
        private System.Windows.Forms.Button bRename;
    }
}

