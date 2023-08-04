namespace SerialWombatWindowsFormsLibrary.Controls
{
    partial class RealTimeScottPlot
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
            this.components = new System.ComponentModel.Container();
            this.formsPlot1 = new ScottPlot.FormsPlot();
            this.ckbPct = new System.Windows.Forms.CheckBox();
            this.tbM = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // formsPlot1
            // 
            this.formsPlot1.Location = new System.Drawing.Point(4, 0);
            this.formsPlot1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.formsPlot1.Name = "formsPlot1";
            this.formsPlot1.Size = new System.Drawing.Size(382, 258);
            this.formsPlot1.TabIndex = 1;
            // 
            // ckbPct
            // 
            this.ckbPct.AutoSize = true;
            this.ckbPct.Location = new System.Drawing.Point(382, 42);
            this.ckbPct.Name = "ckbPct";
            this.ckbPct.Size = new System.Drawing.Size(36, 19);
            this.ckbPct.TabIndex = 2;
            this.ckbPct.Text = "%";
            this.ckbPct.UseVisualStyleBackColor = true;
            // 
            // tbM
            // 
            this.tbM.Location = new System.Drawing.Point(377, 106);
            this.tbM.Name = "tbM";
            this.tbM.Size = new System.Drawing.Size(47, 23);
            this.tbM.TabIndex = 3;
            this.tbM.Text = "1.0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(377, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "m";
            // 
            // tbB
            // 
            this.tbB.Location = new System.Drawing.Point(379, 175);
            this.tbB.Name = "tbB";
            this.tbB.Size = new System.Drawing.Size(47, 23);
            this.tbB.TabIndex = 3;
            this.tbB.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(377, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "b";
            // 
            // RealTimeScottPlot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbB);
            this.Controls.Add(this.tbM);
            this.Controls.Add(this.ckbPct);
            this.Controls.Add(this.formsPlot1);
            this.Name = "RealTimeScottPlot";
            this.Size = new System.Drawing.Size(429, 256);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ScottPlot.FormsPlot formsPlot1;
        private System.Windows.Forms.CheckBox ckbPct;
        private System.Windows.Forms.TextBox tbM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbB;
        private System.Windows.Forms.Label label2;
    }
}
