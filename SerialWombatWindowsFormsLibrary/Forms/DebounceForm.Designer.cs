namespace SerialWombatWindowsFormsLibrary
{
    partial class DebounceForm
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
            this.bRename = new System.Windows.Forms.Button();
            this.debouncedInputControl1 = new SerialWombatWindowsFormsLibrary.Controls.DebouncedInputControl();
            this.SuspendLayout();
            // 
            // bRename
            // 
            this.bRename.Location = new System.Drawing.Point(12, 524);
            this.bRename.Name = "bRename";
            this.bRename.Size = new System.Drawing.Size(75, 23);
            this.bRename.TabIndex = 1;
            this.bRename.Text = "Rename";
            this.bRename.UseVisualStyleBackColor = true;
            this.bRename.Click += new System.EventHandler(this.bRename_Click);
            // 
            // debouncedInputControl1
            // 
            this.debouncedInputControl1.AutoSize = true;
            this.debouncedInputControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.debouncedInputControl1.Location = new System.Drawing.Point(12, 3);
            this.debouncedInputControl1.Name = "debouncedInputControl1";
            this.debouncedInputControl1.Size = new System.Drawing.Size(466, 515);
            this.debouncedInputControl1.TabIndex = 2;
            // 
            // DebounceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 546);
            this.Controls.Add(this.debouncedInputControl1);
            this.Controls.Add(this.bRename);
            this.Name = "DebounceForm";
            this.Text = "DebounceForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DebounceForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bRename;
        private Controls.DebouncedInputControl debouncedInputControl1;
    }
}