using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SerialWombat;


namespace SerialWombatWindowsFormsLibrary
{
    public partial class ServoForm : Form
    {
        public SerialWombatServo Servo;
        public byte Pin = 0;
        public SerialWombatChip SerialWombatChip;
        ServoControl servoControl;
        ScaledOutputControl scaledOutputControl;
        public ServoForm(SerialWombatChip serialWombatChip, byte pin)
        {
            InitializeComponent();
            Pin = pin;
            SerialWombatChip = serialWombatChip;
            this.AutoSize = true;
            servoControl = new ServoControl(serialWombatChip, pin);
            this.Controls.Add(servoControl);
            scaledOutputControl = new ScaledOutputControl(servoControl.Servo.scaledOutput);
            scaledOutputControl.Left = servoControl.Right + 10;
            if (SerialWombatChip.isSW18())
            {
                this.Controls.Add(scaledOutputControl);
            }
            this.Text = $"Servo on pin {pin} on Serial Wombat Chip on {serialWombatChip.Serial.Port.PortName}";
        }

    }



}

