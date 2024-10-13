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
            capTouch18abControl1 = new Controls.CapTouch18ABControl();
            SuspendLayout();
            // 
            // capTouch18abControl1
            // 
            capTouch18abControl1.AutoSize = true;
            capTouch18abControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            capTouch18abControl1.Location = new System.Drawing.Point(3, 12);
            capTouch18abControl1.Name = "capTouch18abControl1";
            capTouch18abControl1.Size = new System.Drawing.Size(468, 704);
            capTouch18abControl1.TabIndex = 0;
            // 
            // SW18ABCapTouchForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(507, 724);
            Controls.Add(capTouch18abControl1);
            Name = "SW18ABCapTouchForm";
            Text = "SW18ABCapTouchForm";
            FormClosing += SW18ABCapTouchForm_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Controls.CapTouch18ABControl capTouch18abControl1;
    }
}