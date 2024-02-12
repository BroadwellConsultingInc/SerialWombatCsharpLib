namespace SerialWombatWindowsFormsLibrary
{
    partial class HBridgeForm
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
            this.ckbOutputScalingVisible = new System.Windows.Forms.CheckBox();
            this.hBridgeControl1 = new SerialWombatWindowsFormsLibrary.Controls.HBridgeControl();
            this.SuspendLayout();
            // 
            // bRename
            // 
            this.bRename.Location = new System.Drawing.Point(16, 281);
            this.bRename.Name = "bRename";
            this.bRename.Size = new System.Drawing.Size(75, 23);
            this.bRename.TabIndex = 4;
            this.bRename.Text = "Rename";
            this.bRename.UseVisualStyleBackColor = true;
            // 
            // ckbOutputScalingVisible
            // 
            this.ckbOutputScalingVisible.AutoSize = true;
            this.ckbOutputScalingVisible.Checked = true;
            this.ckbOutputScalingVisible.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbOutputScalingVisible.Location = new System.Drawing.Point(12, 257);
            this.ckbOutputScalingVisible.Name = "ckbOutputScalingVisible";
            this.ckbOutputScalingVisible.Size = new System.Drawing.Size(182, 19);
            this.ckbOutputScalingVisible.TabIndex = 3;
            this.ckbOutputScalingVisible.Text = "Show Output Scaling Options";
            this.ckbOutputScalingVisible.UseVisualStyleBackColor = true;
            this.ckbOutputScalingVisible.Visible = false;
            // 
            // hBridgeControl1
            // 
            this.hBridgeControl1.AutoSize = true;
            this.hBridgeControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.hBridgeControl1.Location = new System.Drawing.Point(12, 12);
            this.hBridgeControl1.Name = "hBridgeControl1";
            this.hBridgeControl1.ShowConfigure = true;
            this.hBridgeControl1.Size = new System.Drawing.Size(366, 224);
            this.hBridgeControl1.TabIndex = 5;
            // 
            // HBridgeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.hBridgeControl1);
            this.Controls.Add(this.bRename);
            this.Controls.Add(this.ckbOutputScalingVisible);
            this.Name = "HBridgeForm";
            this.Text = "HBridgeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bRename;
        private System.Windows.Forms.CheckBox ckbOutputScalingVisible;
        private Controls.HBridgeControl hBridgeControl1;
    }
}