
namespace SerialWombatWindowsFormsLibrary
{
    partial class QueueForm
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
           
            this.queueControl1 = new SerialWombatWindowsFormsLibrary.Controls.QueueControl();

            this.SuspendLayout();
         
            // 
            // queueControl1
            // 
            this.queueControl1.AutoSize = true;
            this.queueControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.queueControl1.Location = new System.Drawing.Point(12, 12);
            this.queueControl1.Name = "queueControl1";
            this.queueControl1.Size = new System.Drawing.Size(419, 389);
            this.queueControl1.TabIndex = 1;
            // 
            // QueueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.queueControl1);
            this.Name = "QueueForm";
            this.Text = "QueueForm";
          
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

 
        private Controls.QueueControl queueControl1;
    }
}