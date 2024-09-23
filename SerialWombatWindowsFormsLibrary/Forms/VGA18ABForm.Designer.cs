namespace SerialWombatWindowsFormsLibrary.Forms
{
    partial class VGA18ABForm
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
            this.vgA18abControl1 = new SerialWombatWindowsFormsLibrary.Controls.VGA18ABControl();
            this.SuspendLayout();
            // 
            // vgA18abControl1
            // 
            this.vgA18abControl1.AutoSize = true;
            this.vgA18abControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.vgA18abControl1.Location = new System.Drawing.Point(12, 12);
            this.vgA18abControl1.Name = "vgA18abControl1";
            this.vgA18abControl1.Size = new System.Drawing.Size(245, 135);
            this.vgA18abControl1.TabIndex = 0;
            // 
            // VGA18ABForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.vgA18abControl1);
            this.Name = "VGA18ABForm";
            this.Text = "VGA18ABForm";
            this.Load += new System.EventHandler(this.VGA18ABForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.VGA18ABControl vgA18abControl1;
    }
}