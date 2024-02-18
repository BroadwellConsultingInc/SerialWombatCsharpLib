namespace SerialWombatWindowsFormsLibrary
{
    partial class PWMForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bRename = new System.Windows.Forms.Button();
            this.pwmControl1 = new SerialWombatWindowsFormsLibrary.Controls.PWMControl();
            this.ckbOutputScalingVisible = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // bRename
            // 
            this.bRename.AutoSize = true;
            this.bRename.Location = new System.Drawing.Point(12, 247);
            this.bRename.Name = "bRename";
            this.bRename.Size = new System.Drawing.Size(75, 25);
            this.bRename.TabIndex = 1;
            this.bRename.Text = "Rename";
            this.bRename.UseVisualStyleBackColor = true;
            this.bRename.Click += new System.EventHandler(this.bRename_Click);
            // 
            // pwmControl1
            // 
            this.pwmControl1.Location = new System.Drawing.Point(13, 13);
            this.pwmControl1.Name = "pwmControl1";
            this.pwmControl1.Size = new System.Drawing.Size(359, 228);
            this.pwmControl1.TabIndex = 2;
            // 
            // ckbOutputScalingVisible
            // 
            this.ckbOutputScalingVisible.AutoSize = true;
            this.ckbOutputScalingVisible.Checked = true;
            this.ckbOutputScalingVisible.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbOutputScalingVisible.Location = new System.Drawing.Point(115, 251);
            this.ckbOutputScalingVisible.Name = "ckbOutputScalingVisible";
            this.ckbOutputScalingVisible.Size = new System.Drawing.Size(182, 19);
            this.ckbOutputScalingVisible.TabIndex = 3;
            this.ckbOutputScalingVisible.Text = "Show Output Scaling Options";
            this.ckbOutputScalingVisible.UseVisualStyleBackColor = true;
            this.ckbOutputScalingVisible.Visible = false;
            this.ckbOutputScalingVisible.CheckedChanged += new System.EventHandler(this.ckbOutputScalingVisible_CheckedChanged);
            // 
            // PWMForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(376, 331);
            this.Controls.Add(this.ckbOutputScalingVisible);
            this.Controls.Add(this.pwmControl1);
            this.Controls.Add(this.bRename);
            this.Name = "PWMForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bRename;
        private Controls.PWMControl pwmControl1;
        private System.Windows.Forms.CheckBox ckbOutputScalingVisible;
    }
}

