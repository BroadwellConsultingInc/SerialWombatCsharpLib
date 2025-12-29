namespace SerialWombatWindowsFormsLibrary.Controls
{
    partial class DigitalIOControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            bLow = new System.Windows.Forms.Button();
            bHigh = new System.Windows.Forms.Button();
            bInput = new System.Windows.Forms.Button();
            ckbPullUp = new System.Windows.Forms.CheckBox();
            ckbPullDown = new System.Windows.Forms.CheckBox();
            ckbOpenDrain = new System.Windows.Forms.CheckBox();
            SuspendLayout();
            // 
            // bLow
            // 
            bLow.Location = new System.Drawing.Point(3, 3);
            bLow.Name = "bLow";
            bLow.Size = new System.Drawing.Size(75, 23);
            bLow.TabIndex = 0;
            bLow.Text = "Low";
            bLow.UseVisualStyleBackColor = true;
            bLow.Click += bLow_Click;
            // 
            // bHigh
            // 
            bHigh.Location = new System.Drawing.Point(84, 3);
            bHigh.Name = "bHigh";
            bHigh.Size = new System.Drawing.Size(75, 23);
            bHigh.TabIndex = 0;
            bHigh.Text = "High";
            bHigh.UseVisualStyleBackColor = true;
            bHigh.Click += bHigh_Click;
            // 
            // bInput
            // 
            bInput.Location = new System.Drawing.Point(165, 3);
            bInput.Name = "bInput";
            bInput.Size = new System.Drawing.Size(75, 23);
            bInput.TabIndex = 0;
            bInput.Text = "Input";
            bInput.UseVisualStyleBackColor = true;
            bInput.Click += bInput_Click;
            // 
            // ckbPullUp
            // 
            ckbPullUp.AutoSize = true;
            ckbPullUp.Location = new System.Drawing.Point(3, 45);
            ckbPullUp.Name = "ckbPullUp";
            ckbPullUp.Size = new System.Drawing.Size(64, 19);
            ckbPullUp.TabIndex = 1;
            ckbPullUp.Text = "Pull Up";
            ckbPullUp.UseVisualStyleBackColor = true;
            // 
            // ckbPullDown
            // 
            ckbPullDown.AutoSize = true;
            ckbPullDown.Location = new System.Drawing.Point(73, 45);
            ckbPullDown.Name = "ckbPullDown";
            ckbPullDown.Size = new System.Drawing.Size(80, 19);
            ckbPullDown.TabIndex = 1;
            ckbPullDown.Text = "Pull Down";
            ckbPullDown.UseVisualStyleBackColor = true;
            // 
            // ckbOpenDrain
            // 
            ckbOpenDrain.AutoSize = true;
            ckbOpenDrain.Location = new System.Drawing.Point(165, 45);
            ckbOpenDrain.Name = "ckbOpenDrain";
            ckbOpenDrain.Size = new System.Drawing.Size(86, 19);
            ckbOpenDrain.TabIndex = 1;
            ckbOpenDrain.Text = "Open Drain";
            ckbOpenDrain.UseVisualStyleBackColor = true;
            // 
            // DigitalIOControl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(ckbOpenDrain);
            Controls.Add(ckbPullDown);
            Controls.Add(ckbPullUp);
            Controls.Add(bInput);
            Controls.Add(bHigh);
            Controls.Add(bLow);
            Name = "DigitalIOControl";
            Size = new System.Drawing.Size(254, 67);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button bLow;
        private System.Windows.Forms.Button bHigh;
        private System.Windows.Forms.Button bInput;
        private System.Windows.Forms.CheckBox ckbPullUp;
        private System.Windows.Forms.CheckBox ckbPullDown;
        private System.Windows.Forms.CheckBox ckbOpenDrain;
    }
}
