
namespace SerialWombatWindowsFormsLibrary
{
    partial class ResistanceInputForm
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
            resistanceInputControl1 = new Controls.ResistanceInputControl();
            bRename = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // resistanceInputControl1
            // 
            resistanceInputControl1.AutoSize = true;
            resistanceInputControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            resistanceInputControl1.Location = new System.Drawing.Point(8, 4);
            resistanceInputControl1.Name = "resistanceInputControl1";
            resistanceInputControl1.Size = new System.Drawing.Size(534, 518);
            resistanceInputControl1.TabIndex = 0;
            // 
            // bRename
            // 
            bRename.Location = new System.Drawing.Point(12, 528);
            bRename.Name = "bRename";
            bRename.Size = new System.Drawing.Size(75, 23);
            bRename.TabIndex = 1;
            bRename.Text = "Rename";
            bRename.UseVisualStyleBackColor = true;
            bRename.Click += bRename_Click;
            // 
            // ResistanceInputForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new System.Drawing.Size(554, 575);
            Controls.Add(bRename);
            Controls.Add(resistanceInputControl1);
            Name = "ResistanceInputForm";
            Text = "ResistanceInputForm";
            FormClosing += ResistanceInputForm_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Controls.ResistanceInputControl resistanceInputControl1;
        private System.Windows.Forms.Button bRename;
    }
}