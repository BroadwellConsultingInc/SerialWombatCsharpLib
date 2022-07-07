namespace SerialWombatWindowsFormsLibrary
{ 
    partial class ByteEditor
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiHex = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDecimal = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCharacter = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.textBox1.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(3, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(33, 21);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "--";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiHex,
            this.tsmiDecimal,
            this.tsmiCharacter});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(126, 70);
            // 
            // tsmiHex
            // 
            this.tsmiHex.Checked = true;
            this.tsmiHex.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiHex.Name = "tsmiHex";
            this.tsmiHex.Size = new System.Drawing.Size(125, 22);
            this.tsmiHex.Text = "Hex";
            // 
            // tsmiDecimal
            // 
            this.tsmiDecimal.Name = "tsmiDecimal";
            this.tsmiDecimal.Size = new System.Drawing.Size(125, 22);
            this.tsmiDecimal.Text = "Decimal";
            // 
            // tsmiCharacter
            // 
            this.tsmiCharacter.Name = "tsmiCharacter";
            this.tsmiCharacter.Size = new System.Drawing.Size(125, 22);
            this.tsmiCharacter.Text = "Character";
            // 
            // ByteEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.textBox1);
            this.Name = "ByteEditor";
            this.Size = new System.Drawing.Size(39, 27);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

    #endregion

    private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiHex;
        private System.Windows.Forms.ToolStripMenuItem tsmiDecimal;
        private System.Windows.Forms.ToolStripMenuItem tsmiCharacter;
    }
}
