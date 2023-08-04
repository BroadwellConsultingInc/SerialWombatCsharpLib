namespace SerialWombatWindowsFormsLibrary.Forms
{
    partial class ThroughputConsumerForm
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
            this.throughputConsumerControl1 = new SerialWombatWindowsFormsLibrary.Controls.ThroughputConsumerControl();
            this.SuspendLayout();
            // 
            // throughputConsumerControl1
            // 
            this.throughputConsumerControl1.AutoSize = true;
            this.throughputConsumerControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.throughputConsumerControl1.Location = new System.Drawing.Point(2, 12);
            this.throughputConsumerControl1.Name = "throughputConsumerControl1";
            this.throughputConsumerControl1.Size = new System.Drawing.Size(349, 118);
            this.throughputConsumerControl1.TabIndex = 0;
            // 
            // ThroughputConsumerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(363, 147);
            this.Controls.Add(this.throughputConsumerControl1);
            this.Name = "ThroughputConsumerForm";
            this.Text = "ThroughputConsumerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.ThroughputConsumerControl throughputConsumerControl1;
    }
}