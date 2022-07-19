namespace SerialWombatWindowsFormsLibrary
{
    partial class WS2812Form
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
            this.wS2812Control1 = new SerialWombatWindowsFormsLibrary.WS2812Control();
            this.SuspendLayout();
            // 
            // wS2812Control1
            // 
            this.wS2812Control1.AutoSize = true;
            this.wS2812Control1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.wS2812Control1.Location = new System.Drawing.Point(1, 0);
            this.wS2812Control1.Name = "wS2812Control1";
            this.wS2812Control1.Size = new System.Drawing.Size(1131, 627);
            this.wS2812Control1.TabIndex = 0;
            // 
            // WS2812Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 657);
            this.Controls.Add(this.wS2812Control1);
            this.Name = "WS2812Form";
            this.Text = "WS2812Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WS2812Control wS2812Control1;
    }
}