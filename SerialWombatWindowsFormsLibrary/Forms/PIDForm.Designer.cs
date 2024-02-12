namespace SerialWombatWindowsFormsLibrary
{ 
    partial class PIDForm
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
            this.components = new System.ComponentModel.Container();
            this.ckbAutoUpdate = new System.Windows.Forms.CheckBox();
            this.pidControl1 = new SerialWombatWindowsFormsLibrary.PIDControl();
            this.formsPlot1 = new ScottPlot.FormsPlot();
            this.formsPlot2 = new ScottPlot.FormsPlot();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.formsPlot3 = new ScottPlot.FormsPlot();
            this.SuspendLayout();
            // 
            // ckbAutoUpdate
            // 
            this.ckbAutoUpdate.AutoSize = true;
            this.ckbAutoUpdate.Location = new System.Drawing.Point(9, 11);
            this.ckbAutoUpdate.Name = "ckbAutoUpdate";
            this.ckbAutoUpdate.Size = new System.Drawing.Size(93, 19);
            this.ckbAutoUpdate.TabIndex = 0;
            this.ckbAutoUpdate.Text = "Auto Update";
            this.ckbAutoUpdate.UseVisualStyleBackColor = true;
            this.ckbAutoUpdate.CheckedChanged += new System.EventHandler(this.ckbAutoUpdate_CheckedChanged);
            // 
            // pidControl1
            // 
            this.pidControl1.AutoSize = true;
            this.pidControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pidControl1.Location = new System.Drawing.Point(12, 36);
            this.pidControl1.Name = "pidControl1";
            this.pidControl1.Size = new System.Drawing.Size(367, 407);
            this.pidControl1.TabIndex = 1;
            // 
            // formsPlot1
            // 
            this.formsPlot1.Location = new System.Drawing.Point(400, 12);
            this.formsPlot1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.formsPlot1.Name = "formsPlot1";
            this.formsPlot1.Size = new System.Drawing.Size(387, 247);
            this.formsPlot1.TabIndex = 2;
            // 
            // formsPlot2
            // 
            this.formsPlot2.Location = new System.Drawing.Point(400, 265);
            this.formsPlot2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.formsPlot2.Name = "formsPlot2";
            this.formsPlot2.Size = new System.Drawing.Size(387, 247);
            this.formsPlot2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(455, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Error:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(455, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = " Yellow = Integral, Red = Derivative)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(455, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(230, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Effort:  (Blue = total, Green = Proportional,";
            // 
            // formsPlot3
            // 
            this.formsPlot3.Location = new System.Drawing.Point(400, 506);
            this.formsPlot3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.formsPlot3.Name = "formsPlot3";
            this.formsPlot3.Size = new System.Drawing.Size(387, 247);
            this.formsPlot3.TabIndex = 6;
            // 
            // PIDForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 737);
            this.Controls.Add(this.formsPlot3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.formsPlot2);
            this.Controls.Add(this.formsPlot1);
            this.Controls.Add(this.pidControl1);
            this.Controls.Add(this.ckbAutoUpdate);
            this.Name = "PIDForm";
            this.Text = "PIDForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ckbAutoUpdate;
    private PIDControl pidControl1;
        private ScottPlot.FormsPlot formsPlot1;
        private ScottPlot.FormsPlot formsPlot2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private ScottPlot.FormsPlot formsPlot3;
    }
}