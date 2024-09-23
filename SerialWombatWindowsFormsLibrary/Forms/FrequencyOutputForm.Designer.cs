namespace SerialWombatWindowsFormsLibrary.Forms
{
    partial class FrequencyOutputForm
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
            this.frequencyOutputControl1 = new SerialWombatWindowsFormsLibrary.Controls.FrequencyOutputControl();
            this.ckbOutputScalingVisible = new System.Windows.Forms.CheckBox();
            this.bRename = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // frequencyOutputControl1
            // 
            this.frequencyOutputControl1.AutoSize = true;
            this.frequencyOutputControl1.Location = new System.Drawing.Point(1, 1);
            this.frequencyOutputControl1.Name = "frequencyOutputControl1";
            this.frequencyOutputControl1.Size = new System.Drawing.Size(357, 368);
            this.frequencyOutputControl1.TabIndex = 0;
            // 
            // ckbOutputScalingVisible
            // 
            this.ckbOutputScalingVisible.AutoSize = true;
            this.ckbOutputScalingVisible.Checked = true;
            this.ckbOutputScalingVisible.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbOutputScalingVisible.Location = new System.Drawing.Point(115, 379);
            this.ckbOutputScalingVisible.Name = "ckbOutputScalingVisible";
            this.ckbOutputScalingVisible.Size = new System.Drawing.Size(182, 19);
            this.ckbOutputScalingVisible.TabIndex = 5;
            this.ckbOutputScalingVisible.Text = "Show Output Scaling Options";
            this.ckbOutputScalingVisible.UseVisualStyleBackColor = true;
            this.ckbOutputScalingVisible.Visible = false;
            this.ckbOutputScalingVisible.CheckedChanged += new System.EventHandler(this.ckbOutputScalingVisible_CheckedChanged);
            // 
            // bRename
            // 
            this.bRename.AutoSize = true;
            this.bRename.Location = new System.Drawing.Point(12, 375);
            this.bRename.Name = "bRename";
            this.bRename.Size = new System.Drawing.Size(75, 25);
            this.bRename.TabIndex = 4;
            this.bRename.Text = "Rename";
            this.bRename.UseVisualStyleBackColor = true;
            this.bRename.Click += new System.EventHandler(this.bRename_Click);
            // 
            // FrequencyOutputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ckbOutputScalingVisible);
            this.Controls.Add(this.bRename);
            this.Controls.Add(this.frequencyOutputControl1);
            this.Name = "FrequencyOutputForm";
            this.Text = "FrequencyOutputForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.FrequencyOutputControl frequencyOutputControl1;
        private System.Windows.Forms.CheckBox ckbOutputScalingVisible;
        private System.Windows.Forms.Button bRename;
    }
}