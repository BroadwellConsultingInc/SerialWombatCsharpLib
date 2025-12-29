namespace SerialWombatWindowsFormsLibrary.Controls
{
    partial class HBridgeControl
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
            bOff = new System.Windows.Forms.Button();
            gbConfigure = new System.Windows.Forms.GroupBox();
            bGenCode = new System.Windows.Forms.Button();
            label3 = new System.Windows.Forms.Label();
            edDriver = new EnumDropdown();
            label2 = new System.Windows.Forms.Label();
            textBox1 = new System.Windows.Forms.TextBox();
            pddSecondPin = new SerialWombatPinDropdown();
            label1 = new System.Windows.Forms.Label();
            bConfigure = new System.Windows.Forms.Button();
            sbsiPower = new SixteenBitSliderInput();
            toolTip1 = new System.Windows.Forms.ToolTip(components);
            groupBox1.SuspendLayout();
            gbConfigure.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.AutoSize = true;
            groupBox1.Controls.Add(bOff);
            groupBox1.Controls.Add(gbConfigure);
            groupBox1.Controls.Add(sbsiPower);
            groupBox1.Location = new System.Drawing.Point(20, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(343, 362);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // bOff
            // 
            bOff.Enabled = false;
            bOff.Location = new System.Drawing.Point(197, 317);
            bOff.Name = "bOff";
            bOff.Size = new System.Drawing.Size(75, 23);
            bOff.TabIndex = 1;
            bOff.Text = "Off";
            toolTip1.SetToolTip(bOff, "Set Power to 32768 (Off)");
            bOff.UseVisualStyleBackColor = true;
            bOff.Click += bOff_Click;
            // 
            // gbConfigure
            // 
            gbConfigure.Controls.Add(bGenCode);
            gbConfigure.Controls.Add(label3);
            gbConfigure.Controls.Add(edDriver);
            gbConfigure.Controls.Add(label2);
            gbConfigure.Controls.Add(textBox1);
            gbConfigure.Controls.Add(pddSecondPin);
            gbConfigure.Controls.Add(label1);
            gbConfigure.Controls.Add(bConfigure);
            gbConfigure.Location = new System.Drawing.Point(16, 25);
            gbConfigure.Name = "gbConfigure";
            gbConfigure.Size = new System.Drawing.Size(310, 178);
            gbConfigure.TabIndex = 4;
            gbConfigure.TabStop = false;
            gbConfigure.Text = "Configure";
            // 
            // bGenCode
            // 
            bGenCode.BackColor = System.Drawing.Color.MediumPurple;
            bGenCode.Location = new System.Drawing.Point(259, 6);
            bGenCode.Name = "bGenCode";
            bGenCode.Size = new System.Drawing.Size(45, 47);
            bGenCode.TabIndex = 5;
            bGenCode.TabStop = false;
            bGenCode.Text = "Gen Code";
            toolTip1.SetToolTip(bGenCode, "Generate Arduino Initialization code for H Bridge module");
            bGenCode.UseVisualStyleBackColor = false;
            bGenCode.Click += bGenCode_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(6, 63);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(72, 15);
            label3.TabIndex = 10;
            label3.Text = "Driver Mode";
            // 
            // edDriver
            // 
            edDriver.DropDownToolTip = "";
            edDriver.dropdowntype = "SerialWombatClassLibrary.SerialWombat.SerialWombatHBridgeDriverMode";
            edDriver.Location = new System.Drawing.Point(77, 54);
            edDriver.Name = "edDriver";
            edDriver.Size = new System.Drawing.Size(214, 35);
            edDriver.TabIndex = 2;
            toolTip1.SetToolTip(edDriver, "Operation mode (Consult datasheet of H Bridge to deterine slow decay mode)");
            edDriver.Value = -1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(6, 148);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(97, 15);
            label2.TabIndex = 7;
            label2.Text = "PWM Period (uS)";
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(109, 140);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(100, 23);
            textBox1.TabIndex = 3;
            textBox1.Text = "1000";
            toolTip1.SetToolTip(textBox1, "Frequency of PWM output");
            // 
            // pddSecondPin
            // 
            pddSecondPin.AutoSize = true;
            pddSecondPin.IncludeNAPin = false;
            pddSecondPin.Location = new System.Drawing.Point(102, 11);
            pddSecondPin.Name = "pddSecondPin";
            pddSecondPin.Pin = 255;
            pddSecondPin.PinType = SerialWombat.SerialWombatPinType.OutputPin;
            pddSecondPin.Size = new System.Drawing.Size(66, 26);
            pddSecondPin.TabIndex = 0;
            toolTip1.SetToolTip(pddSecondPin, "Second Pin to configure as H Bridge PWM");
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(13, 22);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(66, 15);
            label1.TabIndex = 3;
            label1.Text = "SecondPin:";
            // 
            // bConfigure
            // 
            bConfigure.Location = new System.Drawing.Point(229, 107);
            bConfigure.Name = "bConfigure";
            bConfigure.Size = new System.Drawing.Size(75, 23);
            bConfigure.TabIndex = 4;
            bConfigure.Text = "Configure";
            toolTip1.SetToolTip(bConfigure, "Set Pin to H Bridge mode, configure Second pin, Driver Mode, and Period");
            bConfigure.UseVisualStyleBackColor = true;
            bConfigure.Click += bConfigure_Click;
            // 
            // sbsiPower
            // 
            sbsiPower.Enabled = false;
            sbsiPower.Location = new System.Drawing.Point(9, 248);
            sbsiPower.Maximum = 65535;
            sbsiPower.Minimum = 0;
            sbsiPower.Name = "sbsiPower";
            sbsiPower.Size = new System.Drawing.Size(328, 63);
            sbsiPower.TabIndex = 0;
            sbsiPower.Text = "Power";
            sbsiPower.TextBoxHint = "Output ( 0 = Full Left, 32768 = off, 65535 = Full Right)";
            sbsiPower.value = (ushort)32768;
            // 
            // HBridgeControl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            Controls.Add(groupBox1);
            Name = "HBridgeControl";
            Size = new System.Drawing.Size(366, 377);
            groupBox1.ResumeLayout(false);
            gbConfigure.ResumeLayout(false);
            gbConfigure.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bConfigure;
        private SixteenBitSliderInput sbsiPower;
        private SerialWombatPinDropdown pddSecondPin;
        private System.Windows.Forms.GroupBox gbConfigure;
        private System.Windows.Forms.Button bOff;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bGenCode;
        private EnumDropdown edDriver;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
