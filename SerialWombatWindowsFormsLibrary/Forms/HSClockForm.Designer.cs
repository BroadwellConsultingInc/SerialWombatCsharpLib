namespace SerialWombatWindowsFormsLibrary.Forms
{
    partial class HSClockForm
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
            this.hsClockControl1 = new SerialWombatWindowsFormsLibrary.Controls.HSClockControl();
            this.SuspendLayout();
            // 
            // hsClockControl1
            // 
            this.hsClockControl1.AutoSize = true;
            this.hsClockControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.hsClockControl1.Location = new System.Drawing.Point(12, 12);
            this.hsClockControl1.Name = "hsClockControl1";
            this.hsClockControl1.Size = new System.Drawing.Size(387, 122);
            this.hsClockControl1.TabIndex = 0;
            // 
            // HSClockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.hsClockControl1);
            this.Name = "HSClockForm";
            this.Text = "HSClockForm";
            this.Load += new System.EventHandler(this.HSClockForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.HSClockControl hsClockControl1;
    }
}