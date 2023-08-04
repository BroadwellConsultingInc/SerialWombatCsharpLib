namespace SerialWombatWindowsFormsLibrary.Controls
{
    partial class ThroughputConsumerControl
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sixteenBitSliderInput1 = new SerialWombatWindowsFormsLibrary.SixteenBitSliderInput();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sixteenBitSliderInput1);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(343, 112);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // sixteenBitSliderInput1
            // 
            this.sixteenBitSliderInput1.Location = new System.Drawing.Point(6, 24);
            this.sixteenBitSliderInput1.Maximum = 1000;
            this.sixteenBitSliderInput1.Minimum = 0;
            this.sixteenBitSliderInput1.Name = "sixteenBitSliderInput1";
            this.sixteenBitSliderInput1.Size = new System.Drawing.Size(328, 76);
            this.sixteenBitSliderInput1.TabIndex = 0;
            this.sixteenBitSliderInput1.Text = "Frame Delay (uS)";
            this.sixteenBitSliderInput1.TextBoxHint = "";
            this.sixteenBitSliderInput1.value = ((ushort)(0));
             // 
            // ThroughputConsumerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.groupBox1);
            this.Name = "ThroughputConsumerControl";
            this.Size = new System.Drawing.Size(349, 118);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private SixteenBitSliderInput sixteenBitSliderInput1;
    }
}
