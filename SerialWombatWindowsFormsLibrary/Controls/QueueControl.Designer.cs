namespace SerialWombatWindowsFormsLibrary.Controls
{
    partial class QueueControl
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
            this.bWrite = new System.Windows.Forms.Button();
            this.bRead = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bInitialize = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbLength = new System.Windows.Forms.TextBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.bWrite);
            this.groupBox1.Controls.Add(this.bRead);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.bInitialize);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbLength);
            this.groupBox1.Controls.Add(this.tbAddress);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(413, 304);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // bWrite
            // 
            this.bWrite.Location = new System.Drawing.Point(119, 259);
            this.bWrite.Name = "bWrite";
            this.bWrite.Size = new System.Drawing.Size(75, 23);
            this.bWrite.TabIndex = 4;
            this.bWrite.Text = "Write";
            this.bWrite.UseVisualStyleBackColor = true;
            this.bWrite.Click += new System.EventHandler(this.bWrite_Click);
            // 
            // bRead
            // 
            this.bRead.Location = new System.Drawing.Point(21, 259);
            this.bRead.Name = "bRead";
            this.bRead.Size = new System.Drawing.Size(75, 23);
            this.bRead.TabIndex = 4;
            this.bRead.Text = "Read";
            this.bRead.UseVisualStyleBackColor = true;
            this.bRead.Click += new System.EventHandler(this.bRead_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 70);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(401, 183);
            this.textBox1.TabIndex = 3;
            // 
            // bInitialize
            // 
            this.bInitialize.Location = new System.Drawing.Point(261, 40);
            this.bInitialize.Name = "bInitialize";
            this.bInitialize.Size = new System.Drawing.Size(75, 23);
            this.bInitialize.TabIndex = 2;
            this.bInitialize.Text = "Initialize";
            this.bInitialize.UseVisualStyleBackColor = true;
            this.bInitialize.Click += new System.EventHandler(this.bInitialize_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Length (bytes)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Address";
            // 
            // tbLength
            // 
            this.tbLength.Location = new System.Drawing.Point(143, 41);
            this.tbLength.Name = "tbLength";
            this.tbLength.Size = new System.Drawing.Size(100, 23);
            this.tbLength.TabIndex = 0;
            this.tbLength.Text = "0x0000";
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(37, 41);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(100, 23);
            this.tbAddress.TabIndex = 0;
            this.tbAddress.Text = "0x0000";
            // 
            // QueueControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.groupBox1);
            this.Name = "QueueControl";
            this.Size = new System.Drawing.Size(419, 310);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bWrite;
        private System.Windows.Forms.Button bRead;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button bInitialize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbLength;
        private System.Windows.Forms.TextBox tbAddress;
    }
}
