namespace SerialWombatWindowsFormsLibrary
{
    partial class DataLoggerForm
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
            this.dataLoggerControl1 = new SerialWombatWindowsFormsLibrary.Controls.DataLoggerControl();
            this.SuspendLayout();
            // 
            // dataLoggerControl1
            // 
            this.dataLoggerControl1.AutoSize = true;
            this.dataLoggerControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.dataLoggerControl1.Location = new System.Drawing.Point(-5, -1);
            this.dataLoggerControl1.Name = "dataLoggerControl1";
            this.dataLoggerControl1.Size = new System.Drawing.Size(495, 539);
            this.dataLoggerControl1.TabIndex = 0;
            // 
            // DataLoggerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 607);
            this.Controls.Add(this.dataLoggerControl1);
            this.Name = "DataLoggerForm";
            this.Text = "DataLoggerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.DataLoggerControl dataLoggerControl1;
    }
}