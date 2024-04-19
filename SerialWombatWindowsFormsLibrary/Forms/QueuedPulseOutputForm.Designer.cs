namespace SerialWombatWindowsFormsLibrary.Forms
{
    partial class QueuedPulseOutputForm
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
            this.queuedPulseOutputControl1 = new SerialWombatWindowsFormsLibrary.Controls.QueuedPulseOutputControl();
            this.SuspendLayout();
            // 
            // queuedPulseOutputControl1
            // 
            this.queuedPulseOutputControl1.AutoSize = true;
            this.queuedPulseOutputControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.queuedPulseOutputControl1.Location = new System.Drawing.Point(12, 12);
            this.queuedPulseOutputControl1.Name = "queuedPulseOutputControl1";
            this.queuedPulseOutputControl1.Size = new System.Drawing.Size(949, 505);
            this.queuedPulseOutputControl1.TabIndex = 0;
            // 
            // QueuedPulseOutputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 542);
            this.Controls.Add(this.queuedPulseOutputControl1);
            this.Name = "QueuedPulseOutputForm";
            this.Text = "QueuedPulseOutputForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.QueuedPulseOutputControl queuedPulseOutputControl1;
    }
}