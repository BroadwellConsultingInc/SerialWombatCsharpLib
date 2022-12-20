namespace SerialWombatWindowsFormsLibrary.Forms
{
    partial class SW18ABCapTouchForm
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
            this.sW18abCapTouchControl1 = new SerialWombatWindowsFormsLibrary.Controls.SW18ABCapTouchControl();
            this.SuspendLayout();
            // 
            // sW18abCapTouchControl1
            // 
            this.sW18abCapTouchControl1.AutoSize = true;
            this.sW18abCapTouchControl1.Location = new System.Drawing.Point(23, 12);
            this.sW18abCapTouchControl1.Name = "sW18abCapTouchControl1";
            this.sW18abCapTouchControl1.Size = new System.Drawing.Size(460, 420);
            this.sW18abCapTouchControl1.TabIndex = 0;
            // 
            // SW18ABCapTouchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 450);
            this.Controls.Add(this.sW18abCapTouchControl1);
            this.Name = "SW18ABCapTouchForm";
            this.Text = "SW18ABCapTouchForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SW18ABCapTouchForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.SW18ABCapTouchControl sW18abCapTouchControl1;
    }
}