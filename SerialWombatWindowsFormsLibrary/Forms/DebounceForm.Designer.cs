namespace SerialWombatWindowsFormsLibrary
{
    partial class DebounceForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bConfigure = new System.Windows.Forms.Button();
            this.lTransitions = new System.Windows.Forms.Label();
            this.lStableTime = new System.Windows.Forms.Label();
            this.lActive = new System.Windows.Forms.Label();
            this.bRefresh = new System.Windows.Forms.Button();
            this.ckbAuto = new System.Windows.Forms.CheckBox();
            this.ckbInvert = new System.Windows.Forms.CheckBox();
            this.ckbPullUp = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.bConfigure);
            this.groupBox1.Controls.Add(this.lTransitions);
            this.groupBox1.Controls.Add(this.lStableTime);
            this.groupBox1.Controls.Add(this.lActive);
            this.groupBox1.Controls.Add(this.bRefresh);
            this.groupBox1.Controls.Add(this.ckbAuto);
            this.groupBox1.Controls.Add(this.ckbInvert);
            this.groupBox1.Controls.Add(this.ckbPullUp);
            this.groupBox1.Location = new System.Drawing.Point(8, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(215, 209);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Debounce mS:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "30";
            // 
            // bConfigure
            // 
            this.bConfigure.Location = new System.Drawing.Point(122, 23);
            this.bConfigure.Name = "bConfigure";
            this.bConfigure.Size = new System.Drawing.Size(73, 23);
            this.bConfigure.TabIndex = 6;
            this.bConfigure.Text = "Configure";
            this.bConfigure.UseVisualStyleBackColor = true;
            this.bConfigure.Click += new System.EventHandler(this.bConfigure_Click);
            // 
            // lTransitions
            // 
            this.lTransitions.AutoSize = true;
            this.lTransitions.Location = new System.Drawing.Point(6, 145);
            this.lTransitions.Name = "lTransitions";
            this.lTransitions.Size = new System.Drawing.Size(66, 15);
            this.lTransitions.TabIndex = 5;
            this.lTransitions.Text = "lTransitions";
            // 
            // lStableTime
            // 
            this.lStableTime.AutoSize = true;
            this.lStableTime.Location = new System.Drawing.Point(6, 130);
            this.lStableTime.Name = "lStableTime";
            this.lStableTime.Size = new System.Drawing.Size(33, 15);
            this.lStableTime.TabIndex = 4;
            this.lStableTime.Text = "0 mS";
            // 
            // lActive
            // 
            this.lActive.AutoSize = true;
            this.lActive.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lActive.Location = new System.Drawing.Point(68, 94);
            this.lActive.Name = "lActive";
            this.lActive.Size = new System.Drawing.Size(70, 32);
            this.lActive.TabIndex = 3;
            this.lActive.Text = "State";
            // 
            // bRefresh
            // 
            this.bRefresh.Location = new System.Drawing.Point(6, 171);
            this.bRefresh.Name = "bRefresh";
            this.bRefresh.Size = new System.Drawing.Size(60, 23);
            this.bRefresh.TabIndex = 2;
            this.bRefresh.Text = "Refresh";
            this.bRefresh.UseVisualStyleBackColor = true;
            this.bRefresh.Click += new System.EventHandler(this.bRefresh_Click);
            // 
            // ckbAuto
            // 
            this.ckbAuto.AutoSize = true;
            this.ckbAuto.Location = new System.Drawing.Point(80, 174);
            this.ckbAuto.Name = "ckbAuto";
            this.ckbAuto.Size = new System.Drawing.Size(94, 19);
            this.ckbAuto.TabIndex = 1;
            this.ckbAuto.Text = "Auto Refresh";
            this.ckbAuto.UseVisualStyleBackColor = true;
            this.ckbAuto.CheckedChanged += new System.EventHandler(this.ckbAuto_CheckedChanged);
            // 
            // ckbInvert
            // 
            this.ckbInvert.AutoSize = true;
            this.ckbInvert.Location = new System.Drawing.Point(6, 72);
            this.ckbInvert.Name = "ckbInvert";
            this.ckbInvert.Size = new System.Drawing.Size(88, 19);
            this.ckbInvert.TabIndex = 1;
            this.ckbInvert.Text = "Invert Logic";
            this.ckbInvert.UseVisualStyleBackColor = true;
            // 
            // ckbPullUp
            // 
            this.ckbPullUp.AutoSize = true;
            this.ckbPullUp.Location = new System.Drawing.Point(100, 72);
            this.ckbPullUp.Name = "ckbPullUp";
            this.ckbPullUp.Size = new System.Drawing.Size(109, 19);
            this.ckbPullUp.TabIndex = 0;
            this.ckbPullUp.Text = "Pull Up Enabled";
            this.ckbPullUp.UseVisualStyleBackColor = true;
            // 
            // DebounceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 217);
            this.Controls.Add(this.groupBox1);
            this.Name = "DebounceForm";
            this.Text = "DebounceForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DebounceForm_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox ckbAuto;
        private System.Windows.Forms.CheckBox ckbInvert;
        private System.Windows.Forms.CheckBox ckbPullUp;
        private System.Windows.Forms.Label lTransitions;
        private System.Windows.Forms.Label lStableTime;
        private System.Windows.Forms.Label lActive;
        private System.Windows.Forms.Button bRefresh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button bConfigure;
    }
}