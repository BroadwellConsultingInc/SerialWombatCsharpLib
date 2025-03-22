using SerialWombat;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace SerialWombatWindowsFormsLibrary.Controls
{
    public partial class HBridgeControl : UserControl
    {
        public SerialWombatHBridge_18AB hBridge;
        public byte Pin = 0;
        public SerialWombatChip SerialWombatChip;

       
        public HBridgeControl()
        {
            InitializeComponent();
            edDriver.Value = (int)SerialWombatHBridgeDriverMode.HBRIDGE_OFF_BOTH_LOW;
            
        }

        public void begin(SerialWombatChip serialWombatChip, byte pin)
        {
            Pin = pin;
            SerialWombatChip = serialWombatChip;

            groupBox1.Text = "";

            this.Text = $"HBridge on pin {pin} on Serial Wombat Chip on {serialWombatChip.Serial.Port.PortName}";
            sbsiPower.trackBarValueChangedDelegates.Add(trackBar1_ValueChanged);
            pddSecondPin.begin(serialWombatChip);
            if (pin < SerialWombatChip.WOMBAT_MAXIMUM_PINS - 1)
            {
                pddSecondPin.Pin =(byte)( pin + 1);
            }

        }
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public new string Text { get { return groupBox1.Text; } set { groupBox1.Text = value; } }


        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]

        public bool ShowConfigure { get { return gbConfigure.Visible; } set { gbConfigure.Visible = value; } }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public UInt16 Value
        {
            get
            {
                return hBridge.readPublicData();
            }
            set
            {
                sbsiPower.value= value;
                try
                {
                    if (hBridge != null)
                    {
                        hBridge.writePublicData(value);
                    }
                }
                catch { }
            }
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {

            hBridge.writePublicData(sbsiPower.value);
        }

        private void bConfigure_Click(object sender, EventArgs e)
        {
            hBridge = new SerialWombatHBridge_18AB(SerialWombatChip);

            hBridge.begin(Pin, pddSecondPin.Pin);
            sbsiPower.Enabled= true;
            bOff.Enabled= true;

        }

        private void bSetPeriod_Click(object sender, EventArgs e)
        {
            try
            {
                hBridge.setPeriod_SW18AB_uS(Convert.ToUInt32(textBox1.Text));
            }
            catch (Exception ex) {
               MessageBox.Show(ex.Message);
            
            }
        }

        private void bOff_Click(object sender, EventArgs e)
        {
            sbsiPower.value = 32768;
            sbsiPower.ValueChangeEvent();
        }

        private void bGenCode_Click(object sender, EventArgs e)
        {
            
            string s =
            @$"
                //Put this line before setup()
                SerialWombatHBridge_18AB {Name}(sw); // Your serial wombat chip may be named something else than sw
                //Add this to  setup():
                                {Name}.begin({Pin}, //Pin Number
                                {pddSecondPin.Pin}, // Second Pin
                                {Convert.ToUInt16( textBox1.Text)},// PWM Period in uS
                                {edDriver.selectedItem.ToString()});   // Driver
                               
";
           
            s = s.Replace("True", "true");
            s = s.Replace("False", "false");
            Clipboard.SetText(s);
        }

       
    }
}
