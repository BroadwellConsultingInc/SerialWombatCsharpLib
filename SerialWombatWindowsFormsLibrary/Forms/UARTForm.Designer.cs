namespace SerialWombatWindowsFormsLibrary
{
    partial class UARTForm
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
            this.uartControl1 = new SerialWombatWindowsFormsLibrary.UARTControl();
            this.SuspendLayout();
            // 
            // uartControl1
            // 
            this.uartControl1.AutoSize = true;
            this.uartControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.uartControl1.Location = new System.Drawing.Point(12, 12);
            this.uartControl1.Name = "uartControl1";
            this.uartControl1.Size = new System.Drawing.Size(444, 357);
            this.uartControl1.TabIndex = 0;
            // 
            // UARTForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.uartControl1);
            this.Name = "UARTForm";
            this.Text = "UARTForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UARTForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UARTControl uartControl1;
    }
}