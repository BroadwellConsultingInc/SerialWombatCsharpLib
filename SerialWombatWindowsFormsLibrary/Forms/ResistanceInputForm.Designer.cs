
namespace SerialWombatWindowsFormsLibrary
{
    partial class ResistanceInputForm
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
            this.resistanceInputControl1 = new SerialWombatWindowsFormsLibrary.Controls.ResistanceInputControl();
            this.SuspendLayout();
            // 
            // resistanceInputControl1
            // 
            this.resistanceInputControl1.AutoSize = true;
            this.resistanceInputControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.resistanceInputControl1.Location = new System.Drawing.Point(8, 4);
            this.resistanceInputControl1.Name = "resistanceInputControl1";
            this.resistanceInputControl1.Size = new System.Drawing.Size(534, 518);
            this.resistanceInputControl1.TabIndex = 0;
            // 
            // ResistanceInputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(554, 534);
            this.Controls.Add(this.resistanceInputControl1);
            this.Name = "ResistanceInputForm";
            this.Text = "ResistanceInputForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ResistanceInputForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox ckbVolts;
        private Controls.ResistanceInputControl resistanceInputControl1;
    }
}