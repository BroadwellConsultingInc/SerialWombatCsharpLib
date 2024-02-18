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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bOff = new System.Windows.Forms.Button();
            this.gbConfigure = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.edOffState = new SerialWombatWindowsFormsLibrary.EnumDropdown();
            this.edDriver = new SerialWombatWindowsFormsLibrary.EnumDropdown();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pddSecondPin = new SerialWombatWindowsFormsLibrary.SerialWombatPinDropdown();
            this.label1 = new System.Windows.Forms.Label();
            this.bConfigure = new System.Windows.Forms.Button();
            this.sbsiPower = new SerialWombatWindowsFormsLibrary.SixteenBitSliderInput();
            this.bGenCode = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.gbConfigure.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.bOff);
            this.groupBox1.Controls.Add(this.gbConfigure);
            this.groupBox1.Controls.Add(this.sbsiPower);
            this.groupBox1.Location = new System.Drawing.Point(20, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(343, 362);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // bOff
            // 
            this.bOff.Enabled = false;
            this.bOff.Location = new System.Drawing.Point(197, 317);
            this.bOff.Name = "bOff";
            this.bOff.Size = new System.Drawing.Size(75, 23);
            this.bOff.TabIndex = 1;
            this.bOff.Text = "Off";
            this.bOff.UseVisualStyleBackColor = true;
            this.bOff.Click += new System.EventHandler(this.bOff_Click);
            // 
            // gbConfigure
            // 
            this.gbConfigure.Controls.Add(this.bGenCode);
            this.gbConfigure.Controls.Add(this.label4);
            this.gbConfigure.Controls.Add(this.label3);
            this.gbConfigure.Controls.Add(this.edOffState);
            this.gbConfigure.Controls.Add(this.edDriver);
            this.gbConfigure.Controls.Add(this.label2);
            this.gbConfigure.Controls.Add(this.textBox1);
            this.gbConfigure.Controls.Add(this.pddSecondPin);
            this.gbConfigure.Controls.Add(this.label1);
            this.gbConfigure.Controls.Add(this.bConfigure);
            this.gbConfigure.Location = new System.Drawing.Point(16, 25);
            this.gbConfigure.Name = "gbConfigure";
            this.gbConfigure.Size = new System.Drawing.Size(310, 178);
            this.gbConfigure.TabIndex = 4;
            this.gbConfigure.TabStop = false;
            this.gbConfigure.Text = "Configure";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "OffState";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Driver";
            // 
            // edOffState
            // 
            this.edOffState.DropDownToolTip = "";
            this.edOffState.dropdowntype = "SerialWombat.SerialWombatHBridgeOffState";
            this.edOffState.Location = new System.Drawing.Point(77, 95);
            this.edOffState.Name = "edOffState";
            this.edOffState.Size = new System.Drawing.Size(136, 35);
            this.edOffState.TabIndex = 2;
            this.edOffState.Value = 0;
            // 
            // edDriver
            // 
            this.edDriver.DropDownToolTip = "";
            this.edDriver.dropdowntype = "SerialWombat.SerialWombatHBridgeDriver";
            this.edDriver.Location = new System.Drawing.Point(77, 54);
            this.edDriver.Name = "edDriver";
            this.edDriver.Size = new System.Drawing.Size(136, 35);
            this.edDriver.TabIndex = 1;
            this.edDriver.Value = -1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "PWM Period (uS)";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(109, 140);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "1000";
            // 
            // pddSecondPin
            // 
            this.pddSecondPin.AutoSize = true;
            this.pddSecondPin.IncludeNAPin = false;
            this.pddSecondPin.Location = new System.Drawing.Point(102, 11);
            this.pddSecondPin.Name = "pddSecondPin";
            this.pddSecondPin.Pin = ((byte)(255));
            this.pddSecondPin.PinType = SerialWombat.SerialWombatPinType.EnhancedPerformanceOutputPin;
            this.pddSecondPin.Size = new System.Drawing.Size(66, 26);
            this.pddSecondPin.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "SecondPin:";
            // 
            // bConfigure
            // 
            this.bConfigure.Location = new System.Drawing.Point(229, 107);
            this.bConfigure.Name = "bConfigure";
            this.bConfigure.Size = new System.Drawing.Size(75, 23);
            this.bConfigure.TabIndex = 4;
            this.bConfigure.Text = "Configure";
            this.bConfigure.UseVisualStyleBackColor = true;
            this.bConfigure.Click += new System.EventHandler(this.bConfigure_Click);
            // 
            // sbsiPower
            // 
            this.sbsiPower.Enabled = false;
            this.sbsiPower.Location = new System.Drawing.Point(9, 248);
            this.sbsiPower.Maximum = 65535;
            this.sbsiPower.Minimum = 0;
            this.sbsiPower.Name = "sbsiPower";
            this.sbsiPower.Size = new System.Drawing.Size(328, 63);
            this.sbsiPower.TabIndex = 0;
            this.sbsiPower.Text = "Power";
            this.sbsiPower.TextBoxHint = "";
            this.sbsiPower.value = ((ushort)(32768));
            // 
            // bGenCode
            // 
            this.bGenCode.BackColor = System.Drawing.Color.MediumPurple;
            this.bGenCode.Location = new System.Drawing.Point(259, 22);
            this.bGenCode.Name = "bGenCode";
            this.bGenCode.Size = new System.Drawing.Size(45, 47);
            this.bGenCode.TabIndex = 5;
            this.bGenCode.TabStop = false;
            this.bGenCode.Text = "Gen Code";
            this.bGenCode.UseVisualStyleBackColor = false;
            // 
            // HBridgeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.groupBox1);
            this.Name = "HBridgeControl";
            this.Size = new System.Drawing.Size(366, 377);
            this.groupBox1.ResumeLayout(false);
            this.gbConfigure.ResumeLayout(false);
            this.gbConfigure.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private EnumDropdown edDriver;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private EnumDropdown edOffState;
        private System.Windows.Forms.Button bGenCode;
    }
}
