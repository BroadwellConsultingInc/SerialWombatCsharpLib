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
    public partial class SerialWombatPinDropdown : UserControl
    {
        SerialWombatPinType pinType;
        SerialWombatChip SerialWombatChip;
        bool naPin = false;
        public SerialWombatPinDropdown()
        {
            InitializeComponent();

        }

        public void begin(SerialWombatChip serialWombatChip)
        {
            SerialWombatChip = serialWombatChip;

            comboBox1.Items.Clear();
            int[] p;
            switch (pinType)
            {
                case SerialWombatPinType.OutputPin:
                    {
                        p = serialWombatChip.outputPins;
                    }
                    break;
                case SerialWombatPinType.SerialWombatPin:
                case SerialWombatPinType.InputPin:
                default:
                    {
                        p = serialWombatChip.inputPins;
                    }
                    break;
                case SerialWombatPinType.EnhancedPerformanceInputPin:
                    {
                        p = serialWombatChip.enhancedPerformanceInputPins;
                    }
                    break;
                case SerialWombatPinType.EnhancedPerformanceOutputPin:
                    {
                        p = serialWombatChip.enhancedPerformanceOutputPins;
                    }
                    break;
                case SerialWombatPinType.AnalogPin:
                    {
                        p = serialWombatChip.AnalogPins;
                    }
                    break;
            }
            foreach (int pin in p)
            {
                comboBox1.Items.Add(pin);
            }
            if (naPin)
            {
                comboBox1.Items.Add("None");
            }
        }

        public void begin(SerialWombatChip serialWombatChip, int pin)
        {
            begin(serialWombatChip);
            Pin = (byte)pin;
        }
            [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public SerialWombatPinType PinType
        {
            get { return pinType; }
            set { pinType = value; }
        }

        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public byte Pin
        {
            get
            {
                try
                {
                    if (comboBox1.SelectedIndex== -1)
                    {
                        return 255;
                    }
                    return (byte)(int)comboBox1.SelectedItem;
                }
                catch
                {
                    return 255;
                }
            }
            set
            {
                try
                {
                    for (int i = 0; i < comboBox1.Items.Count; i++)
                    {
                        if ((int)comboBox1.Items[i] == value)
                        {
                            comboBox1.SelectedIndex = i;
                        }
                    }
                }
                catch
                {
                    if (naPin)
                    {
                        comboBox1.SelectedIndex = comboBox1.Items.Count - 1;
                    }
                }

            }
        }

            [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
            [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
            public bool IncludeNAPin
        {
            get
            {
                return naPin;
            }
            set
            {
                naPin = value;

            }
        }
    }
}
