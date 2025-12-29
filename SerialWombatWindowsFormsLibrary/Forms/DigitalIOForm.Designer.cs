namespace SerialWombatWindowsFormsLibrary.Forms
{
    partial class DigitalIOForm
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
            digitalioControl1 = new SerialWombatWindowsFormsLibrary.Controls.DigitalIOControl();
            ckbOutputScalingVisible = new System.Windows.Forms.CheckBox();
            ckbInputProcessingVisible = new System.Windows.Forms.CheckBox();
            button1 = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // digitalioControl1
            // 
            digitalioControl1.AutoSize = true;
            digitalioControl1.Location = new System.Drawing.Point(2, 1);
            digitalioControl1.Name = "digitalioControl1";
            digitalioControl1.Size = new System.Drawing.Size(254, 67);
            digitalioControl1.TabIndex = 0;
            // 
            // ckbOutputScalingVisible
            // 
            ckbOutputScalingVisible.AutoSize = true;
            ckbOutputScalingVisible.Location = new System.Drawing.Point(8, 81);
            ckbOutputScalingVisible.Name = "ckbOutputScalingVisible";
            ckbOutputScalingVisible.Size = new System.Drawing.Size(142, 19);
            ckbOutputScalingVisible.TabIndex = 1;
            ckbOutputScalingVisible.Text = "Output Scaling Visible";
            ckbOutputScalingVisible.UseVisualStyleBackColor = true;
            ckbOutputScalingVisible.CheckedChanged += ckbOutputScalingVisible_CheckedChanged;
            // 
            // ckbInputProcessingVisible
            // 
            ckbInputProcessingVisible.AutoSize = true;
            ckbInputProcessingVisible.Location = new System.Drawing.Point(166, 81);
            ckbInputProcessingVisible.Name = "ckbInputProcessingVisible";
            ckbInputProcessingVisible.Size = new System.Drawing.Size(151, 19);
            ckbInputProcessingVisible.TabIndex = 1;
            ckbInputProcessingVisible.Text = "Input Processing Visible";
            ckbInputProcessingVisible.UseVisualStyleBackColor = true;
            ckbInputProcessingVisible.CheckedChanged += ckbInputProcessingVisible_CheckedChanged;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(12, 117);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(138, 23);
            button1.TabIndex = 2;
            button1.Text = "Public Data Window";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // DigitalIOForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(button1);
            Controls.Add(ckbInputProcessingVisible);
            Controls.Add(ckbOutputScalingVisible);
            Controls.Add(digitalioControl1);
            Name = "DigitalIOForm";
            Text = "DigitalIOForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Controls.DigitalIOControl digitalioControl1;
        private System.Windows.Forms.CheckBox ckbOutputScalingVisible;
        private System.Windows.Forms.CheckBox ckbInputProcessingVisible;
        private System.Windows.Forms.Button button1;
    }
}