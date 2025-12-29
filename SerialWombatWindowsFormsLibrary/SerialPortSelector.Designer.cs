namespace SerialWombatWindowsFormsLibrary
{
    partial class SerialPortSelector
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
            components = new System.ComponentModel.Container();
            button1 = new System.Windows.Forms.Button();
            bCancel = new System.Windows.Forms.Button();
            listBox1 = new System.Windows.Forms.ListBox();
            label1 = new System.Windows.Forms.Label();
            button3 = new System.Windows.Forms.Button();
            button4 = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            cbI2CAddress = new System.Windows.Forms.ComboBox();
            ckbNoAddressing = new System.Windows.Forms.CheckBox();
            toolTip1 = new System.Windows.Forms.ToolTip(components);
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(25, 193);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(92, 23);
            button1.TabIndex = 0;
            button1.Text = "XIAO SAMD21";
            toolTip1.SetToolTip(button1, "Use this Button if your UART to I2C Bridge is SAMD21 Based");
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // bCancel
            // 
            bCancel.Location = new System.Drawing.Point(147, 213);
            bCancel.Name = "bCancel";
            bCancel.Size = new System.Drawing.Size(75, 23);
            bCancel.TabIndex = 0;
            bCancel.Text = "Cancel";
            bCancel.UseVisualStyleBackColor = true;
            bCancel.Click += button2_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new System.Drawing.Point(25, 13);
            listBox1.Name = "listBox1";
            listBox1.Size = new System.Drawing.Size(120, 154);
            listBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(25, 170);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(39, 15);
            label1.TabIndex = 2;
            label1.Text = "Open:";
            // 
            // button3
            // 
            button3.Location = new System.Drawing.Point(25, 222);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(92, 23);
            button3.TabIndex = 3;
            button3.Text = "XIAO ESP32";
            toolTip1.SetToolTip(button3, "Use this Button if your UART to I2C Bridge is ESP32 Based");
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new System.Drawing.Point(25, 251);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(92, 23);
            button4.TabIndex = 4;
            button4.Text = "Uno/Generic";
            toolTip1.SetToolTip(button4, "Use this Button for Arduino Uno or Mega, or try it first for boards not listed");
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(23, 283);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(72, 15);
            label2.TabIndex = 12;
            label2.Text = "I2C Address:";
            // 
            // cbI2CAddress
            // 
            cbI2CAddress.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbI2CAddress.FormattingEnabled = true;
            cbI2CAddress.Items.AddRange(new object[] { "default", "0x60", "0x61", "0x62", "0x63", "0x64", "0x65", "0x66", "0x67", "0x68", "0x69", "0x6A", "0x6B", "0x6C", "0x6D", "0x6E", "0x6F" });
            cbI2CAddress.Location = new System.Drawing.Point(101, 280);
            cbI2CAddress.Name = "cbI2CAddress";
            cbI2CAddress.Size = new System.Drawing.Size(121, 23);
            cbI2CAddress.TabIndex = 11;
            toolTip1.SetToolTip(cbI2CAddress, "Select the I2C Address of your Serial Wombat chip, or leave blank to have the bridge app find the lowest address chip");
            // 
            // ckbNoAddressing
            // 
            ckbNoAddressing.AutoSize = true;
            ckbNoAddressing.Location = new System.Drawing.Point(132, 253);
            ckbNoAddressing.Name = "ckbNoAddressing";
            ckbNoAddressing.Size = new System.Drawing.Size(104, 19);
            ckbNoAddressing.TabIndex = 13;
            ckbNoAddressing.Text = "No Addressing";
            toolTip1.SetToolTip(ckbNoAddressing, "Check this box if you're using a SW18AB in UART mode or a legacy  non-addressing UART to I2C Bridge");
            ckbNoAddressing.UseVisualStyleBackColor = true;
            ckbNoAddressing.CheckedChanged += ckbNoAddressing_CheckedChanged;
            // 
            // SerialPortSelector
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(250, 312);
            Controls.Add(ckbNoAddressing);
            Controls.Add(label2);
            Controls.Add(cbI2CAddress);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Controls.Add(bCancel);
            Controls.Add(button1);
            Name = "SerialPortSelector";
            Text = "Select Serial Port";
            Load += SerialPortSelector_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbI2CAddress;
        private System.Windows.Forms.CheckBox ckbNoAddressing;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}