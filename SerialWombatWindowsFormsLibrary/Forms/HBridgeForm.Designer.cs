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
            bRename = new System.Windows.Forms.Button();
            ckbOutputScalingVisible = new System.Windows.Forms.CheckBox();
            hBridgeControl1 = new SerialWombatWindowsFormsLibrary.Controls.HBridgeControl();
            SuspendLayout();
            // 
            // bRename
            // 
            bRename.Location = new System.Drawing.Point(25, 409);
            bRename.Name = "bRename";
            bRename.Size = new System.Drawing.Size(75, 23);
            bRename.TabIndex = 4;
            bRename.Text = "Rename";
            bRename.UseVisualStyleBackColor = true;
            bRename.Click += bRename_Click;
            // 
            // ckbOutputScalingVisible
            // 
            ckbOutputScalingVisible.AutoSize = true;
            ckbOutputScalingVisible.Checked = true;
            ckbOutputScalingVisible.CheckState = System.Windows.Forms.CheckState.Checked;
            ckbOutputScalingVisible.Location = new System.Drawing.Point(21, 385);
            ckbOutputScalingVisible.Name = "ckbOutputScalingVisible";
            ckbOutputScalingVisible.Size = new System.Drawing.Size(182, 19);
            ckbOutputScalingVisible.TabIndex = 3;
            ckbOutputScalingVisible.Text = "Show Output Scaling Options";
            ckbOutputScalingVisible.UseVisualStyleBackColor = true;
            ckbOutputScalingVisible.Visible = false;
            // 
            // hBridgeControl1
            // 
            hBridgeControl1.AutoSize = true;
            hBridgeControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            hBridgeControl1.Location = new System.Drawing.Point(3, 2);
            hBridgeControl1.Name = "hBridgeControl1";
            hBridgeControl1.ShowConfigure = true;
            hBridgeControl1.Size = new System.Drawing.Size(366, 377);
            hBridgeControl1.TabIndex = 5;
            // 
            // HBridgeForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(418, 527);
            Controls.Add(hBridgeControl1);
            Controls.Add(bRename);
            Controls.Add(ckbOutputScalingVisible);
            Name = "HBridgeForm";
            Text = "HBridgeForm";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bRename;
        private System.Windows.Forms.CheckBox ckbOutputScalingVisible;
        private Controls.HBridgeControl hBridgeControl1;
    }
}