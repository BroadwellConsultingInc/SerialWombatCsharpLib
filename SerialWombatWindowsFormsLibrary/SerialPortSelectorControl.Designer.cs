namespace SerialWombatWindowsFormsLibrary
{
    partial class SerialPortSelectorControl
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
            bGeneric = new System.Windows.Forms.Button();
            bESP32 = new System.Windows.Forms.Button();
            lOpen = new System.Windows.Forms.Label();
            listBox1 = new System.Windows.Forms.ListBox();
            bCancel = new System.Windows.Forms.Button();
            bSAMD21 = new System.Windows.Forms.Button();
            bUno = new System.Windows.Forms.Button();
            bBluetooth = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // bGeneric
            // 
            bGeneric.Location = new System.Drawing.Point(12, 241);
            bGeneric.Name = "bGeneric";
            bGeneric.Size = new System.Drawing.Size(92, 23);
            bGeneric.TabIndex = 10;
            bGeneric.Text = "Generic";
            bGeneric.UseVisualStyleBackColor = true;
            bGeneric.Click += bGeneric_Click;
            // 
            // bESP32
            // 
            bESP32.Location = new System.Drawing.Point(12, 212);
            bESP32.Name = "bESP32";
            bESP32.Size = new System.Drawing.Size(92, 23);
            bESP32.TabIndex = 9;
            bESP32.Text = "XIAO ESP32";
            bESP32.UseVisualStyleBackColor = true;
            bESP32.Click += bESP32_Click;
            // 
            // lOpen
            // 
            lOpen.AutoSize = true;
            lOpen.Location = new System.Drawing.Point(12, 160);
            lOpen.Name = "lOpen";
            lOpen.Size = new System.Drawing.Size(39, 15);
            lOpen.TabIndex = 8;
            lOpen.Text = "Open:";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new System.Drawing.Point(12, 3);
            listBox1.Name = "listBox1";
            listBox1.Size = new System.Drawing.Size(120, 154);
            listBox1.TabIndex = 7;
            // 
            // bCancel
            // 
            bCancel.Location = new System.Drawing.Point(117, 241);
            bCancel.Name = "bCancel";
            bCancel.Size = new System.Drawing.Size(75, 23);
            bCancel.TabIndex = 5;
            bCancel.Text = "Cancel";
            bCancel.UseVisualStyleBackColor = true;
            // 
            // bSAMD21
            // 
            bSAMD21.Location = new System.Drawing.Point(12, 183);
            bSAMD21.Name = "bSAMD21";
            bSAMD21.Size = new System.Drawing.Size(92, 23);
            bSAMD21.TabIndex = 6;
            bSAMD21.Text = "XIAO SAMD21";
            bSAMD21.UseVisualStyleBackColor = true;
            bSAMD21.Click += bSAMD21_Click;
            // 
            // bUno
            // 
            bUno.Location = new System.Drawing.Point(110, 183);
            bUno.Name = "bUno";
            bUno.Size = new System.Drawing.Size(92, 23);
            bUno.TabIndex = 11;
            bUno.Text = "Uno";
            bUno.UseVisualStyleBackColor = true;
            bUno.Click += bUno_Click;
            // 
            // bBluetooth
            // 
            bBluetooth.Location = new System.Drawing.Point(110, 212);
            bBluetooth.Name = "bBluetooth";
            bBluetooth.Size = new System.Drawing.Size(92, 23);
            bBluetooth.TabIndex = 12;
            bBluetooth.Text = "Bluetooth";
            bBluetooth.UseVisualStyleBackColor = true;
            bBluetooth.Click += bBluetooth_Click;
            // 
            // SerialPortSelectorControl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            Controls.Add(bBluetooth);
            Controls.Add(bUno);
            Controls.Add(bGeneric);
            Controls.Add(bESP32);
            Controls.Add(lOpen);
            Controls.Add(listBox1);
            Controls.Add(bCancel);
            Controls.Add(bSAMD21);
            Name = "SerialPortSelectorControl";
            Size = new System.Drawing.Size(205, 267);
            Load += SerialPortSelectorControl_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button bGeneric;
        private System.Windows.Forms.Button bESP32;
        private System.Windows.Forms.Label lOpen;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Button bSAMD21;
        private System.Windows.Forms.Button bUno;
        private System.Windows.Forms.Button bBluetooth;
    }
}
