namespace SerialWombatWindowsFormsLibrary
{
    partial class MatrixKeypadForm
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
            this.matrixKeypadControl1 = new SerialWombatWindowsFormsLibrary.MatrixKeypadControl();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // matrixKeypadControl1
            // 
            this.matrixKeypadControl1.AutoSize = true;
            this.matrixKeypadControl1.Location = new System.Drawing.Point(12, 12);
            this.matrixKeypadControl1.Name = "matrixKeypadControl1";
            this.matrixKeypadControl1.Size = new System.Drawing.Size(470, 565);
            this.matrixKeypadControl1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 571);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Rename";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MatrixKeypadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 596);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.matrixKeypadControl1);
            this.Name = "MatrixKeypadForm";
            this.Text = "MatrixKeypadForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MatrixKeypadForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MatrixKeypadControl matrixKeypadControl1;
        private System.Windows.Forms.Button button1;
    }
}