namespace SerialWombatWindowsFormsLibrary
{
    partial class TM1637Form
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
            this.tM1637Control1 = new SerialWombatWindowsFormsLibrary.TM1637Control();
            this.SuspendLayout();
            // 
            // tM1637Control1
            // 
            this.tM1637Control1.AutoSize = true;
            this.tM1637Control1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tM1637Control1.Location = new System.Drawing.Point(12, 12);
            this.tM1637Control1.Name = "tM1637Control1";
            this.tM1637Control1.Size = new System.Drawing.Size(461, 636);
            this.tM1637Control1.TabIndex = 0;
            // 
            // TM1637Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 662);
            this.Controls.Add(this.tM1637Control1);
            this.Name = "TM1637Form";
            this.Text = "TM1637Form";
            this.Load += new System.EventHandler(this.TM1637Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TM1637Control tM1637Control1;
    }
}