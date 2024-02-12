namespace SerialWombatWindowsFormsLibrary
{
    partial class HSCounterForm
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
            this.hsCounterControl1 = new SerialWombatWindowsFormsLibrary.Controls.HSCounterControl();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // hsCounterControl1
            // 
            this.hsCounterControl1.AutoSize = true;
            this.hsCounterControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.hsCounterControl1.Location = new System.Drawing.Point(3, 3);
            this.hsCounterControl1.Name = "hsCounterControl1";
            this.hsCounterControl1.Size = new System.Drawing.Size(441, 555);
            this.hsCounterControl1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 564);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Rename";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // HSCounterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(477, 583);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.hsCounterControl1);
            this.Name = "HSCounterForm";
            this.Text = "HSCounterForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HSCounterForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.HSCounterControl hsCounterControl1;
        private System.Windows.Forms.Button button1;
    }
}