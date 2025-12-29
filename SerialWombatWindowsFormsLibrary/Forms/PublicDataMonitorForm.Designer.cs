
namespace SerialWombatWindowsFormsLibrary
{
    partial class PublicDataMonitorForm
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
            publicDataMonitorControl1 = new SerialWombatWindowsFormsLibrary.Controls.PublicDataMonitorControl();
            SuspendLayout();
            // 
            // publicDataMonitorControl1
            // 
            publicDataMonitorControl1.AutoSize = true;
            publicDataMonitorControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            publicDataMonitorControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            publicDataMonitorControl1.Location = new System.Drawing.Point(0, 0);
            publicDataMonitorControl1.Name = "publicDataMonitorControl1";
            publicDataMonitorControl1.Size = new System.Drawing.Size(463, 407);
            publicDataMonitorControl1.TabIndex = 0;
            // 
            // PublicDataMonitorForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(463, 407);
            Controls.Add(publicDataMonitorControl1);
            Name = "PublicDataMonitorForm";
            Text = "Form1";
            FormClosing += AnalogInputForm_FormClosing;
            Resize += PublicDataMonitorForm_Resize;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private Controls.PublicDataMonitorControl publicDataMonitorControl1;
    }
}
