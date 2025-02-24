namespace SerialWombatWindowsFormsLibrary.Controls
{
    partial class HSClockControl
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
            components = new System.ComponentModel.Container();
            groupBox1 = new System.Windows.Forms.GroupBox();
            lActual = new System.Windows.Forms.Label();
            comboBox1 = new System.Windows.Forms.ComboBox();
            label1 = new System.Windows.Forms.Label();
            trackBar1 = new System.Windows.Forms.TrackBar();
            toolTip1 = new System.Windows.Forms.ToolTip(components);
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lActual);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(trackBar1);
            groupBox1.Location = new System.Drawing.Point(8, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(376, 114);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // lActual
            // 
            lActual.AutoSize = true;
            lActual.Location = new System.Drawing.Point(227, 28);
            lActual.Name = "lActual";
            lActual.Size = new System.Drawing.Size(0, 15);
            lActual.TabIndex = 3;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Hz", "kHz", "MHz" });
            comboBox1.Location = new System.Drawing.Point(69, 26);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(121, 23);
            comboBox1.TabIndex = 2;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(18, 29);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(13, 15);
            label1.TabIndex = 1;
            label1.Text = "1";
            // 
            // trackBar1
            // 
            trackBar1.Location = new System.Drawing.Point(6, 54);
            trackBar1.Maximum = 32;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new System.Drawing.Size(364, 45);
            trackBar1.TabIndex = 0;
            trackBar1.Value = 1;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // toolTip1
            // 
            toolTip1.ToolTipTitle = "Drag to configure output freqeuncy.  Actual frequency output will be displayed";
            // 
            // HSClockControl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            Controls.Add(groupBox1);
            Name = "HSClockControl";
            Size = new System.Drawing.Size(387, 122);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label lActual;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
