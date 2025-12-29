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
            components = new System.ComponentModel.Container();
            formsPlot1 = new ScottPlot.FormsPlot();
            ckbPct = new System.Windows.Forms.CheckBox();
            tbM = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            tbB = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // formsPlot1
            // 
            formsPlot1.Dock = System.Windows.Forms.DockStyle.Fill;
            formsPlot1.Location = new System.Drawing.Point(0, 0);
            formsPlot1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            formsPlot1.Name = "formsPlot1";
            formsPlot1.Size = new System.Drawing.Size(667, 491);
            formsPlot1.TabIndex = 1;
            // 
            // ckbPct
            // 
            ckbPct.Anchor = System.Windows.Forms.AnchorStyles.Right;
            ckbPct.AutoSize = true;
            ckbPct.Location = new System.Drawing.Point(89, 138);
            ckbPct.Name = "ckbPct";
            ckbPct.Size = new System.Drawing.Size(36, 19);
            ckbPct.TabIndex = 2;
            ckbPct.Text = "%";
            ckbPct.UseVisualStyleBackColor = true;
            // 
            // tbM
            // 
            tbM.Anchor = System.Windows.Forms.AnchorStyles.Right;
            tbM.Location = new System.Drawing.Point(84, 202);
            tbM.Name = "tbM";
            tbM.Size = new System.Drawing.Size(47, 23);
            tbM.TabIndex = 3;
            tbM.Text = "1.0";
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(84, 184);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(18, 15);
            label1.TabIndex = 4;
            label1.Text = "m";
            // 
            // tbB
            // 
            tbB.Anchor = System.Windows.Forms.AnchorStyles.Right;
            tbB.Location = new System.Drawing.Point(86, 271);
            tbB.Name = "tbB";
            tbB.Size = new System.Drawing.Size(47, 23);
            tbB.TabIndex = 3;
            tbB.Text = "0";
            // 
            // label2
            // 
            label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(84, 246);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(14, 15);
            label2.TabIndex = 4;
            label2.Text = "b";
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainer1.Location = new System.Drawing.Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(formsPlot1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(ckbPct);
            splitContainer1.Panel2.Controls.Add(label2);
            splitContainer1.Panel2.Controls.Add(tbM);
            splitContainer1.Panel2.Controls.Add(label1);
            splitContainer1.Panel2.Controls.Add(tbB);
            splitContainer1.Size = new System.Drawing.Size(813, 491);
            splitContainer1.SplitterDistance = 667;
            splitContainer1.TabIndex = 5;
            // 
            // RealTimeScottPlot
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(splitContainer1);
            Name = "RealTimeScottPlot";
            Size = new System.Drawing.Size(813, 491);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private ScottPlot.FormsPlot formsPlot1;
        private System.Windows.Forms.CheckBox ckbPct;
        private System.Windows.Forms.TextBox tbM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}
