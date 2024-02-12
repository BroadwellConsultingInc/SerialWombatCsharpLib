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
using SerialWombat;

namespace SerialWombatWindowsFormsLibrary
{
    
    public partial class PIDControl : UserControl
    {
        public UInt16 lastTarget = 0;
        public SerialWombatAbstractScaledOutput ScaledOutput;
        public PIDControl()
        {
            InitializeComponent();
        }

        public PIDControl(SerialWombatAbstractScaledOutput scaledOutput)
        {
            ScaledOutput = scaledOutput;
            InitializeComponent();
        }
        private void bUpdateTargetCI_Click(object sender, EventArgs e)
        {
            ScaledOutput.PIDResetIntegrator();
            ScaledOutput.writeScalingTargetValue(sbsiPIDTarget.value);
            lastTarget = sbsiPIDTarget.value;
        }

        private void bPIDUpdateTarget_Click(object sender, EventArgs e)
        {
            ScaledOutput.writeScalingTargetValue(sbsiPIDTarget.value);
            lastTarget = sbsiPIDTarget.value;
        }

        private void bGenPIDCode_Click(object sender, EventArgs e)
        {
            addTextToClipboard(
               $@"//put this line in setup.
                    {Name}.writePID({sbsiKp.value}, //Kp
                    {sbsiKi.value}, //Ki
                    {sbsiKd.value}, //Kd
                    {sbsiPIDTarget.value},  //Target Value
                    {(ScaledOutputPeriod)edPIDPeriod.selectedItem});//Period
");
        }

        private void addTextToClipboard(string text)
        {
            string s = "";
            if (Clipboard.ContainsText())
            {
                s = Clipboard.GetText();
            }
            s += text;
            Clipboard.SetText(s);
        }

        private void bConfigurePID_Click(object sender, EventArgs e)
        {
            ScaledOutput.writePID(sbsiKp.value, sbsiKi.value, sbsiKd.value, sbsiPIDTarget.value, (ScaledOutputPeriod)edPIDPeriod.selectedItem);
            lastTarget = sbsiPIDTarget.value;
        }

        private void bResetIntegrator_Click(object sender, EventArgs e)
        {
            ScaledOutput.PIDResetIntegrator();
        }

        private void bShowPIDGraphs_Click(object sender, EventArgs e)
        {
            PIDForm pf = new PIDForm();
            pf.setScaledOutput(ScaledOutput);
            pf.Show();
        }
    }
}
