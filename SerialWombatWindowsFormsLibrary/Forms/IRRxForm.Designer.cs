namespace SerialWombatWindowsFormsLibrary.Forms
{
    partial class IRRxForm
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
            irRxControl1 = new SerialWombatWindowsFormsLibrary.Controls.IRRxControl();
            bRename = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // irRxControl1
            // 
            irRxControl1.AutoSize = true;
            irRxControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            irRxControl1.Location = new System.Drawing.Point(2, 12);
            irRxControl1.Name = "irRxControl1";
            irRxControl1.Size = new System.Drawing.Size(371, 462);
            irRxControl1.TabIndex = 0;
            // 
            // bRename
            // 
            bRename.Location = new System.Drawing.Point(12, 517);
            bRename.Name = "bRename";
            bRename.Size = new System.Drawing.Size(75, 23);
            bRename.TabIndex = 1;
            bRename.Text = "Rename";
            bRename.UseVisualStyleBackColor = true;
            bRename.Click += bRename_Click;
            // 
            // IRRxForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(386, 550);
            Controls.Add(bRename);
            Controls.Add(irRxControl1);
            Name = "IRRxForm";
            Text = "IRRxForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Controls.IRRxControl irRxControl1;
        private System.Windows.Forms.Button bRename;
    }
}