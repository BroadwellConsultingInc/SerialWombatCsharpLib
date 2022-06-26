
namespace SerialWombatWindowsFormsLibrary
{
    partial class PinStateMachineViewer
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bParse = new System.Windows.Forms.Button();
            this.tbPin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bRemove = new System.Windows.Forms.Button();
            this.bRead = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbMode = new System.Windows.Forms.TextBox();
            this.tbPublicData = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(196, 190);
            this.textBox1.TabIndex = 0;
            // 
            // bParse
            // 
            this.bParse.Location = new System.Drawing.Point(12, 229);
            this.bParse.Name = "bParse";
            this.bParse.Size = new System.Drawing.Size(75, 23);
            this.bParse.TabIndex = 1;
            this.bParse.Text = "Parse";
            this.bParse.UseVisualStyleBackColor = true;
            this.bParse.Click += new System.EventHandler(this.bParse_Click);
            // 
            // tbPin
            // 
            this.tbPin.Location = new System.Drawing.Point(108, 278);
            this.tbPin.Name = "tbPin";
            this.tbPin.Size = new System.Drawing.Size(100, 23);
            this.tbPin.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pin:";
            // 
            // bRemove
            // 
            this.bRemove.Location = new System.Drawing.Point(12, 321);
            this.bRemove.Name = "bRemove";
            this.bRemove.Size = new System.Drawing.Size(75, 23);
            this.bRemove.TabIndex = 4;
            this.bRemove.Text = "Remove";
            this.bRemove.UseVisualStyleBackColor = true;
            // 
            // bRead
            // 
            this.bRead.Location = new System.Drawing.Point(13, 278);
            this.bRead.Name = "bRead";
            this.bRead.Size = new System.Drawing.Size(75, 23);
            this.bRead.TabIndex = 5;
            this.bRead.Text = "Read";
            this.bRead.UseVisualStyleBackColor = true;
            this.bRead.Click += new System.EventHandler(this.bRead_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Location = new System.Drawing.Point(266, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(266, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Mode:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(420, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Public Data:";
            // 
            // tbMode
            // 
            this.tbMode.Location = new System.Drawing.Point(314, 13);
            this.tbMode.Name = "tbMode";
            this.tbMode.Size = new System.Drawing.Size(100, 23);
            this.tbMode.TabIndex = 2;
            // 
            // tbPublicData
            // 
            this.tbPublicData.Location = new System.Drawing.Point(496, 12);
            this.tbPublicData.Name = "tbPublicData";
            this.tbPublicData.Size = new System.Drawing.Size(100, 23);
            this.tbPublicData.TabIndex = 2;
            // 
            // PinStateMachineViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bRead);
            this.Controls.Add(this.bRemove);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPublicData);
            this.Controls.Add(this.tbMode);
            this.Controls.Add(this.tbPin);
            this.Controls.Add(this.bParse);
            this.Controls.Add(this.textBox1);
            this.Name = "PinStateMachineViewer";
            this.Text = "PinStateMachineViewer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button bParse;
        private System.Windows.Forms.TextBox tbPin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bRemove;
        private System.Windows.Forms.Button bRead;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbMode;
        private System.Windows.Forms.TextBox tbPublicData;
    }
}