namespace SerialWombatWindowsFormsLibrary
{
    partial class PulseTimerForm
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
            this.pulseTimerControl1 = new SerialWombatWindowsFormsLibrary.Controls.PulseTimerControl();
            this.ckbShowInputProcessing = new System.Windows.Forms.CheckBox();
            this.bRenameWindow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pulseTimerControl1
            // 
            this.pulseTimerControl1.AutoSize = true;
            this.pulseTimerControl1.Location = new System.Drawing.Point(12, 12);
            this.pulseTimerControl1.Name = "pulseTimerControl1";
            this.pulseTimerControl1.Size = new System.Drawing.Size(466, 515);
            this.pulseTimerControl1.TabIndex = 0;
            // 
            // ckbShowInputProcessing
            // 
            this.ckbShowInputProcessing.AutoSize = true;
            this.ckbShowInputProcessing.Checked = true;
            this.ckbShowInputProcessing.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbShowInputProcessing.Location = new System.Drawing.Point(12, 533);
            this.ckbShowInputProcessing.Name = "ckbShowInputProcessing";
            this.ckbShowInputProcessing.Size = new System.Drawing.Size(146, 19);
            this.ckbShowInputProcessing.TabIndex = 1;
            this.ckbShowInputProcessing.Text = "Show Input Processing";
            this.ckbShowInputProcessing.UseVisualStyleBackColor = true;
            this.ckbShowInputProcessing.CheckedChanged += new System.EventHandler(this.ckbShowInputProcessing_CheckedChanged);
            // 
            // bRenameWindow
            // 
            this.bRenameWindow.Location = new System.Drawing.Point(164, 530);
            this.bRenameWindow.Name = "bRenameWindow";
            this.bRenameWindow.Size = new System.Drawing.Size(75, 23);
            this.bRenameWindow.TabIndex = 2;
            this.bRenameWindow.Text = "Rename Window";
            this.bRenameWindow.UseVisualStyleBackColor = true;
            this.bRenameWindow.Click += new System.EventHandler(this.bRenameWindow_Click);
            // 
            // PulseTimerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 547);
            this.Controls.Add(this.bRenameWindow);
            this.Controls.Add(this.ckbShowInputProcessing);
            this.Controls.Add(this.pulseTimerControl1);
            this.Name = "PulseTimerForm";
            this.Text = "PulseTimerForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PulseTimerForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.PulseTimerControl pulseTimerControl1;
        private System.Windows.Forms.CheckBox ckbShowInputProcessing;
        private System.Windows.Forms.Button bRenameWindow;
    }
}