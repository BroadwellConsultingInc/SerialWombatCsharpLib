namespace SerialWombatWindowsFormsLibrary
{
    partial class AnalogInputForm
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
            this.label6 = new System.Windows.Forms.Label();
            this.analogInputControl1 = new SerialWombatWindowsFormsLibrary.AnalogInputControl();
            this.bRename = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(19, 488);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(494, 34);
            this.label6.TabIndex = 1;
            this.label6.Text = "Real time chart created with Scott Hardin\'s excellent  ScottPlot Library (https:/" +
    "/swharden.com/scottplot/)";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // analogInputControl1
            // 
            this.analogInputControl1.AutoSize = true;
            this.analogInputControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.analogInputControl1.Location = new System.Drawing.Point(12, 12);
            this.analogInputControl1.Name = "analogInputControl1";
            this.analogInputControl1.Size = new System.Drawing.Size(533, 513);
            this.analogInputControl1.TabIndex = 2;
            // 
            // bRename
            // 
            this.bRename.Location = new System.Drawing.Point(12, 535);
            this.bRename.Name = "bRename";
            this.bRename.Size = new System.Drawing.Size(75, 23);
            this.bRename.TabIndex = 3;
            this.bRename.Text = "Rename";
            this.bRename.UseVisualStyleBackColor = true;
            this.bRename.Click += new System.EventHandler(this.bRename_Click);
            // 
            // AnalogInputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 570);
            this.Controls.Add(this.bRename);
            this.Controls.Add(this.analogInputControl1);
            this.Controls.Add(this.label6);
            this.Name = "AnalogInputForm";
            this.Text = "AnalogInputForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AnalogInputForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private AnalogInputControl analogInputControl1;
        private System.Windows.Forms.Button bRename;
    }
}