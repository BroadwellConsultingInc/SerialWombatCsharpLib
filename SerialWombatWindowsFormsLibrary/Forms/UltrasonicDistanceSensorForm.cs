using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using SerialWombat;
using ScottPlot;

namespace SerialWombatWindowsFormsLibrary
{
    public partial class UltrasonicDistanceSensorForm : Form
    {

        public byte Pin = 0;
        public SerialWombatChip SerialWombatChip;
        ProcessedInputControl ProcessedInputControl;

        public UltrasonicDistanceSensorForm(SerialWombatChip serialWombatChip, byte pin)
        {
            InitializeComponent();
            Pin = pin;
            SerialWombatChip = serialWombatChip;

            Text = $"Pin {pin} UltrasonicDistanceSensor {serialWombatChip.description}";
            ultrasonicDistanceSensorControl1.begin(serialWombatChip, pin);

            SerialWombatAbstractProcessedInput processedInput = new SerialWombatAbstractProcessedInput(SerialWombatChip);
            processedInput.begin(pin, SerialWombatPinModes.PIN_MODE_ULTRASONIC_DISTANCE);
            ProcessedInputControl = new ProcessedInputControl(processedInput);
            ProcessedInputControl.Left = ultrasonicDistanceSensorControl1.Right + 10;
            this.AutoSize = true;
            this.Controls.Add(ProcessedInputControl);
            this.Refresh();
        }

        private void UltrasonicDistanceSensorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ultrasonicDistanceSensorControl1.End();
        }

        private void UltrasonicDistanceSensorForm_Load(object sender, EventArgs e)
        {

        }
    }
}
