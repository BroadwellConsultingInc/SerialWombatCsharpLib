namespace SerialWombatWindowsFormsLibrary.Forms
{
    partial class QuadEncForm
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
            this.quadEncControl1 = new SerialWombatWindowsFormsLibrary.Controls.QuadEncControl();
            this.bRename = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // quadEncControl1
            // 
            this.quadEncControl1.AutoSize = true;
            this.quadEncControl1.Location = new System.Drawing.Point(12, 12);
            this.quadEncControl1.Name = "quadEncControl1";
            this.quadEncControl1.Size = new System.Drawing.Size(608, 637);
            this.quadEncControl1.TabIndex = 0;
            // 
            // bRename
            // 
            this.bRename.Location = new System.Drawing.Point(24, 655);
            this.bRename.Name = "bRename";
            this.bRename.Size = new System.Drawing.Size(75, 23);
            this.bRename.TabIndex = 1;
            this.bRename.Text = "Rename";
            this.bRename.UseVisualStyleBackColor = true;
            this.bRename.Click += new System.EventHandler(this.bRenameWindow_Click);
            // 
            // QuadEncForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 693);
            this.Controls.Add(this.bRename);
            this.Controls.Add(this.quadEncControl1);
            this.Name = "QuadEncForm";
            this.Text = "QuadEncForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QuadEncForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.QuadEncControl quadEncControl1;
        private System.Windows.Forms.Button bRename;
    }
}