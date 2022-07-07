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
            // PulseTimerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 547);
            this.Controls.Add(this.pulseTimerControl1);
            this.Name = "PulseTimerForm";
            this.Text = "PulseTimerForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PulseTimerForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.PulseTimerControl pulseTimerControl1;
    }
}