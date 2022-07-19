namespace SerialWombatWindowsFormsLibrary
{
    partial class LiquidCrystalForm
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
            this.liquidCrystalControl1 = new SerialWombatWindowsFormsLibrary.LiquidCrystalControl();
            this.SuspendLayout();
            // 
            // liquidCrystalControl1
            // 
            this.liquidCrystalControl1.Location = new System.Drawing.Point(1, 0);
            this.liquidCrystalControl1.Name = "liquidCrystalControl1";
            this.liquidCrystalControl1.Size = new System.Drawing.Size(761, 561);
            this.liquidCrystalControl1.TabIndex = 0;
            // 
            // LiquidCrystalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.liquidCrystalControl1);
            this.Name = "LiquidCrystalForm";
            this.Text = "LiquidCrystalForm";
            this.ResumeLayout(false);

        }

        #endregion

        private LiquidCrystalControl liquidCrystalControl1;
    }
}