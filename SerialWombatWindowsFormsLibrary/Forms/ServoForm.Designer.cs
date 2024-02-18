namespace SerialWombatWindowsFormsLibrary
{
    partial class ServoForm
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
            this.servoControl1 = new SerialWombatWindowsFormsLibrary.ServoControl();
            this.ckbOutputScalingVisible = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // bRename
            // 
            this.bRename.Location = new System.Drawing.Point(8, 300);
            this.bRename.Name = "bRename";
            this.bRename.Size = new System.Drawing.Size(75, 23);
            this.bRename.TabIndex = 2;
            this.bRename.Text = "Rename";
            this.bRename.UseVisualStyleBackColor = true;
            this.bRename.Click += new System.EventHandler(this.bRename_Click);
            // 
            // servoControl1
            // 
            this.servoControl1.AutoSize = true;
            this.servoControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.servoControl1.Location = new System.Drawing.Point(8, 5);
            this.servoControl1.Name = "servoControl1";
            this.servoControl1.ShowConfigure = true;
            this.servoControl1.Size = new System.Drawing.Size(306, 289);
            this.servoControl1.TabIndex = 3;
            // 
            // ckbOutputScalingVisible
            // 
            this.ckbOutputScalingVisible.AutoSize = true;
            this.ckbOutputScalingVisible.Checked = true;
            this.ckbOutputScalingVisible.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbOutputScalingVisible.Location = new System.Drawing.Point(89, 304);
            this.ckbOutputScalingVisible.Name = "ckbOutputScalingVisible";
            this.ckbOutputScalingVisible.Size = new System.Drawing.Size(182, 19);
            this.ckbOutputScalingVisible.TabIndex = 1;
            this.ckbOutputScalingVisible.Text = "Show Output Scaling Options";
            this.ckbOutputScalingVisible.UseVisualStyleBackColor = true;
            this.ckbOutputScalingVisible.Visible = false;
            this.ckbOutputScalingVisible.CheckedChanged += new System.EventHandler(this.ckbOutputScalingVisible_CheckedChanged);
            // 
            // ServoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(872, 543);
            this.Controls.Add(this.servoControl1);
            this.Controls.Add(this.bRename);
            this.Controls.Add(this.ckbOutputScalingVisible);
            this.Name = "ServoForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ServoForm_Load);
            this.Shown += new System.EventHandler(this.ServoForm_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bRename;
        private ServoControl servoControl1;
        private System.Windows.Forms.CheckBox ckbOutputScalingVisible;
    }
}

