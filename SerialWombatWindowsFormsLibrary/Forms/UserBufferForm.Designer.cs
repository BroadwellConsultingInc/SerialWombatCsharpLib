namespace SerialWombatWindowsFormsLibrary
{
    partial class UserBufferForm
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
            this.memoryPageEditor1 = new SerialWombatWindowsFormsLibrary.MemoryPageEditor();
            this.bReload = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // memoryPageEditor1
            // 
            this.memoryPageEditor1.Address = ((uint)(0u));
            this.memoryPageEditor1.AutoSize = true;
            this.memoryPageEditor1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.memoryPageEditor1.Location = new System.Drawing.Point(12, 56);
            this.memoryPageEditor1.Name = "memoryPageEditor1";
            this.memoryPageEditor1.Size = new System.Drawing.Size(729, 483);
            this.memoryPageEditor1.TabIndex = 0;
            // 
            // bReload
            // 
            this.bReload.Location = new System.Drawing.Point(28, 27);
            this.bReload.Name = "bReload";
            this.bReload.Size = new System.Drawing.Size(75, 23);
            this.bReload.TabIndex = 1;
            this.bReload.Text = "Reload";
            this.bReload.UseVisualStyleBackColor = true;
            this.bReload.Click += new System.EventHandler(this.bReload_Click);
            // 
            // UserBufferForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 572);
            this.Controls.Add(this.bReload);
            this.Controls.Add(this.memoryPageEditor1);
            this.Name = "UserBufferForm";
            this.Text = "UserBufferForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MemoryPageEditor memoryPageEditor1;
        private System.Windows.Forms.Button bReload;
    }
}