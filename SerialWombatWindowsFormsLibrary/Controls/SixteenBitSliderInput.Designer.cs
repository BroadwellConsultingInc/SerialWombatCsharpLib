namespace SerialWombatWindowsFormsLibrary
{
    partial class SixteenBitSliderInput
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
            this.components = new System.ComponentModel.Container();
            this.tbValue = new System.Windows.Forms.TextBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbValue
            // 
            this.tbValue.Location = new System.Drawing.Point(6, 14);
            this.tbValue.Name = "tbValue";
            this.tbValue.Size = new System.Drawing.Size(77, 23);
            this.tbValue.TabIndex = 4;
            this.tbValue.Text = "0";
            this.tbValue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbValue_KeyDown);
            this.tbValue.Leave += new System.EventHandler(this.tbValue_Leave);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(89, 14);
            this.trackBar1.Maximum = 65535;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(221, 45);
            this.trackBar1.TabIndex = 3;
            this.trackBar1.TabStop = false;
            this.trackBar1.TickFrequency = 4096;
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.trackBar1);
            this.groupBox1.Controls.Add(this.tbValue);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(316, 65);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Value Selector";
            // 
            // SixteenBitSliderInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "SixteenBitSliderInput";
            this.Size = new System.Drawing.Size(328, 76);
            this.Resize += new System.EventHandler(this.SixteenBitSliderInput_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox tbValue;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
