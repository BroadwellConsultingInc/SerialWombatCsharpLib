using SerialWombat;
using SerialWombatWindowsFormsLibrary.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace SerialWombatWindowsFormsLibrary
{
    public partial class HBridgeForm : Form
    {
        public byte Pin = 0;
        public SerialWombatChip SerialWombatChip;
        public SerialWombatAbstractScaledOutput scaledOutput;
        public ScaledOutputControl scaledOutputControl;
        public HBridgeForm(SerialWombatChip serialWombatChip, byte pin)
        {
            InitializeComponent();
            Pin = pin;
            SerialWombatChip = serialWombatChip;
            this.Text = $"HBridge on pin {pin} on {serialWombatChip.description}";
            hBridgeControl1.Name = $"Pin{pin}HBridge";



            if (SerialWombatChip.isSW08() || SerialWombatChip.isSW18())
            {

                this.AutoSize = true;
                scaledOutput = new SerialWombatAbstractScaledOutput(SerialWombatChip);
                scaledOutput.biDirectional = true;
                scaledOutput.begin(pin, SerialWombatPinModes.PIN_MODE_HBRIDGE);
                scaledOutputControl = new ScaledOutputControl(scaledOutput);
                scaledOutputControl.Left = hBridgeControl1.Right + 10;
                this.Controls.Add(scaledOutputControl);
                ckbOutputScalingVisible.Visible = true;
                ckbOutputScalingVisible.Checked = true;
                scaledOutputControl.SetPinName($"Pin{Pin}HBridge");
                this.Refresh();
            }
            hBridgeControl1.begin(SerialWombatChip, Pin);
        }

        private void bRename_Click(object sender, EventArgs e)
        {
            SingleLineTextEntryForm sltef = new SingleLineTextEntryForm("Name Form", "Add a name for this form:");
            sltef.ShowDialog();
            if (sltef.Success)
            {
                this.Text = $"{sltef.outputString} HBridge on pin {hBridgeControl1.Pin}";
                hBridgeControl1.Name = sltef.outputString;
                if (scaledOutputControl != null)
                {
                    scaledOutputControl.Name = sltef.outputString;
                }
            }
        }
    }
}
