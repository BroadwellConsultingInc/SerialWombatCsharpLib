namespace SerialWombatWindowsFormsLibrary
{
    partial class PulseOnChangeForm
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
            this.pulseOnChangeControl1 = new SerialWombatWindowsFormsLibrary.PulseOnChangeControl();
            this.SuspendLayout();
            // 
            // pulseOnChangeControl1
            // 
            this.pulseOnChangeControl1.AutoSize = true;
            this.pulseOnChangeControl1.Location = new System.Drawing.Point(1, 3);
            this.pulseOnChangeControl1.Name = "pulseOnChangeControl1";
            this.pulseOnChangeControl1.Size = new System.Drawing.Size(979, 660);
            this.pulseOnChangeControl1.TabIndex = 0;
            // 
            // PulseOnChangeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 664);
            this.Controls.Add(this.pulseOnChangeControl1);
            this.Name = "PulseOnChangeForm";
            this.Text = "PulseOnChangeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PulseOnChangeControl pulseOnChangeControl1;
    }
}