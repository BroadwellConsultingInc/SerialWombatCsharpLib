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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace SerialWombatWindowsFormsLibrary
{
    public partial class HBridgeForm : Form
    {
        public SerialWombatHBridge_18AB hBridge_18AB;
        public byte Pin = 0;
        public SerialWombatChip SerialWombatChip;
        public SerialWombatAbstractScaledOutput scaledOutput;
        public ScaledOutputControl scaledOutputControl;
        public HBridgeForm(SerialWombatChip serialWombatChip, byte pin)
        {
            InitializeComponent();
            Pin = pin;
            SerialWombatChip = serialWombatChip;
            this.Text = $"HBridge on pin {pin} on Serial Wombat Chip on {serialWombatChip.Serial.Port.PortName}";


            if (serialWombatChip.ModelEnum == SerialWombatModel.SerialWombat18AB)
            {

                this.AutoSize = true;
                scaledOutput = new SerialWombatAbstractScaledOutput(serialWombatChip);
                scaledOutput.biDirectional = true;
                scaledOutput.begin(pin, SerialWombatPinModes.PIN_MODE_HBRIDGE);
                scaledOutputControl = new ScaledOutputControl(scaledOutput);
                scaledOutputControl.Left = hBridgeControl1.Right + 10;
                this.Controls.Add(scaledOutputControl);
                ckbOutputScalingVisible.Visible = true;
                ckbOutputScalingVisible.Checked = true;
                this.Refresh();
            }
            hBridgeControl1.begin(serialWombatChip,Pin);
        }
    }
}
