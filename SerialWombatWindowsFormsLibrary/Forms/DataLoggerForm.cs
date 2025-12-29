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

namespace SerialWombatWindowsFormsLibrary
{
    public partial class DataLoggerForm : Form
    {
        public SerialWombatFrequencyOutput fo;
        public byte Pin = 0;
        public SerialWombatChip serialWombatChip;
        public SerialWombatAbstractScaledOutput scaledOutput;
        public ScaledOutputControl scaledOutputControl;
        public DataLoggerForm(SerialWombatChip serialWombatChip)
        {
            this.serialWombatChip = serialWombatChip;
            InitializeComponent();
            Text = $"Data Logger {serialWombatChip.description}";
            dataLoggerControl1.begin(serialWombatChip);
        }
    }
}
