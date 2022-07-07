
namespace SerialWombatWindowsFormsLibrary
{
    partial class UltrasonicDistanceSensorForm
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
            this.ultrasonicDistanceSensorControl1 = new SerialWombatWindowsFormsLibrary.Controls.UltrasonicDistanceSensorControl();
            this.SuspendLayout();
            // 
            // ultrasonicDistanceSensorControl1
            // 
            this.ultrasonicDistanceSensorControl1.AutoSize = true;
            this.ultrasonicDistanceSensorControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ultrasonicDistanceSensorControl1.Location = new System.Drawing.Point(1, 3);
            this.ultrasonicDistanceSensorControl1.Name = "ultrasonicDistanceSensorControl1";
            this.ultrasonicDistanceSensorControl1.Size = new System.Drawing.Size(438, 415);
            this.ultrasonicDistanceSensorControl1.TabIndex = 0;
            // 
            // UltrasonicDistanceSensorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(556, 495);
            this.Controls.Add(this.ultrasonicDistanceSensorControl1);
            this.Name = "UltrasonicDistanceSensorForm";
            this.Text = "UltrasonicDistanceSensorForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UltrasonicDistanceSensorForm_FormClosing);
            this.Load += new System.EventHandler(this.UltrasonicDistanceSensorForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.UltrasonicDistanceSensorControl ultrasonicDistanceSensorControl1;
    }
}