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
            this.bRename = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pulseOnChangeControl1
            // 
            this.pulseOnChangeControl1.AutoSize = true;
            this.pulseOnChangeControl1.Location = new System.Drawing.Point(1, 3);
            this.pulseOnChangeControl1.Name = "pulseOnChangeControl1";
            this.pulseOnChangeControl1.Size = new System.Drawing.Size(979, 676);
            this.pulseOnChangeControl1.TabIndex = 0;
            // 
            // bRename
            // 
            this.bRename.Location = new System.Drawing.Point(20, 692);
            this.bRename.Name = "bRename";
            this.bRename.Size = new System.Drawing.Size(75, 23);
            this.bRename.TabIndex = 1;
            this.bRename.Text = "Rename";
            this.bRename.UseVisualStyleBackColor = true;
            this.bRename.Click += new System.EventHandler(this.bRename_Click);
            // 
            // PulseOnChangeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 730);
            this.Controls.Add(this.bRename);
            this.Controls.Add(this.pulseOnChangeControl1);
            this.Name = "PulseOnChangeForm";
            this.Text = "PulseOnChangeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PulseOnChangeControl pulseOnChangeControl1;
        private System.Windows.Forms.Button bRename;
    }
}