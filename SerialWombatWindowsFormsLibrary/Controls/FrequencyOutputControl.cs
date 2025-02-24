using SerialWombat;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SerialWombat.SerialWombatAbstractProcessedInput;

namespace SerialWombatWindowsFormsLibrary.Controls
{
    public partial class FrequencyOutputControl : UserControl
    {
        public SerialWombatFrequencyOutput fo;
        SerialWombatChip SerialWombatChip;
        byte Pin;
        public FrequencyOutputControl()
        {
            InitializeComponent();
        }

        private void FrequencyOutputControl_Load(object sender, EventArgs e)
        {
            
        }

        public void begin(SerialWombatChip serialWombatChip, byte pin)
        {
            SerialWombatChip = serialWombatChip;
            Pin = pin;

            groupBox1.Text = $"Frequency Output on pin {pin}";
           
           
            sbsiFrequency.trackBarValueChangedDelegates.Add(trackBar1_ValueChanged);
            this.Name = $"Pin{pin}FrequencyOutput";

        }

        private void bConfigure_Click(object sender, EventArgs e)
        {
            try
            {
                fo = new SerialWombatFrequencyOutput(SerialWombatChip);
                fo.begin(Pin, sbsiMaxFrequency.value, ckbLowFrequency.Checked, sbsiDutyCycle.value);

                fo.writePublicData(sbsiFrequency.value);
                sbsiFrequency.Enabled = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {

            if (fo != null)
            {
                fo.writePublicData(sbsiFrequency.value);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            string s =
            @$"
                //Put this line before setup()
                SerialWombatFrequencyOutput {Name}(sw); // Your serial wombat chip may be named something else than sw
                //Add this to  setup():
                                {Name}.begin({Pin}, //Pin Number
                                {sbsiMaxFrequency.value}, // Max Frequency in Hz (up to 65535)
                                {ckbLowFrequency.Checked},
                                {sbsiDutyCycle.value}); // Duty Cycle (out of 65535)); // Low Frequency     
                               
";
           
                s += $@" {Name}.writePublicData({Convert.ToUInt16(sbsiFrequency.value)}); // Set period in uS
";
            
            s = s.Replace("True", "true");
            s = s.Replace("False", "false");
            Clipboard.SetText(s);
        }

      
    }
}
