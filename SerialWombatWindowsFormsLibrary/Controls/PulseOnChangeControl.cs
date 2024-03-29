﻿using System;
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
    public partial class PulseOnChangeControl : UserControl
    {
        SerialWombatChip SerialWombatChip;
        public byte Pin;
        SerialWombatPulseOnChange PulseOnChange;
        public PulseOnChangeControl()
        {
            InitializeComponent();
            cbEntry.SelectedIndex = 0;
        }

        public void begin(SerialWombatChip serialWombatChip, byte pin)
        {
            SerialWombatChip = serialWombatChip;
            Pin = pin;
            PulseOnChange = new SerialWombatPulseOnChange(serialWombatChip);
            groupBox1.Text = $"Pin {Pin} Pulse on Change";
        }
        private void edMode_SelectedEnumChanged(object sender, EventArgs e)
        {
            sbsiParam1.Enabled = true;
            sbsiParam2.Enabled = true;
            swpdcSecondSource.Enabled = false;
            switch ((PulseOnChangeModes)edMode.selectedItem)
            {
                case PulseOnChangeModes.PULSE_ON_CHANGE:
                    {
                        sbsiParam1.Enabled = false;
                        sbsiParam2.Enabled = false;
                    }
                    break;
                case PulseOnChangeModes.PULSE_ON_INCREASE:
                    {
                        sbsiParam1.Enabled = false;
                        sbsiParam2.Enabled = false;
                    }
                    break;


                case PulseOnChangeModes.PULSE_ON_DECREASE:
                    {
                        sbsiParam1.Enabled = false;
                        sbsiParam2.Enabled = false;
                    }
                    break;


                case PulseOnChangeModes.PULSE_EQUAL_VALUE:
                    {
                        sbsiParam2.Enabled = false;

                    }
                    break;


                case PulseOnChangeModes.PULSE_BELOW_VALUE:
                    {
                        sbsiParam2.Enabled = false;
                    }
                    break;


                case PulseOnChangeModes.PULSE_ABOVE_VALUE:
                    {
                        sbsiParam2.Enabled = false;
                    }
                    break;


                case PulseOnChangeModes.PULSE_NOT_EQUAL_VALUE:
                    {
                        sbsiParam1.Enabled = false;
                    }
                    break;


                case PulseOnChangeModes.PULSE_EQUAL_PIN:
                    {
                        sbsiParam2.Enabled = false;
                        swpdcSecondSource.Enabled = true;
                    }
                    break;


                case PulseOnChangeModes.PULSE_ABOVE_PIN:
                    {
                        sbsiParam2.Enabled = false;
                        swpdcSecondSource.Enabled = true;
                    }
                    break;


                case PulseOnChangeModes.PULSE_BELOW_PIN:
                    {
                        sbsiParam2.Enabled = false;
                        swpdcSecondSource.Enabled = true;
                    }
                    break;


                case PulseOnChangeModes.PULSE_NOT_EQUAL_PIN:
                    {
                        sbsiParam2.Enabled = false;
                        swpdcSecondSource.Enabled = true;
                    }
                    break;

                    /*
                case PulseOnChangeModes.PULSE_CROSS_VALUE:
                    {

                    }
                    break;


                case PulseOnChangeModes.PULSE_CROSS_VALUE_ASCENDING:
                    {

                    }
                    break;


                case PulseOnChangeModes.PULSE_CROSS_VALUE_DESCENDING:
                    {

                    }
                    break;


                case PulseOnChangeModes.PULSE_WITHIN_RANGE:
                    {

                    }
                    break;


                case PulseOnChangeModes.PULSE_OUTSIDE_RANGE:
                    {

                    }
                    break;
                    */

            }
        }

        private void bConfigure_Click(object sender, EventArgs e)
        {
            PulseOnChange.begin(Pin, (SerialWombatPinStates)edActive.selectedItem, (SerialWombatPinStates)edInactive.selectedItem,
                sbsiActiveTime.value, sbsiInactiveTime.value, rbLogicalOr.Checked, sbsiPWMPeriod.value, sbsiDutyCycle.value);

        }

        private void bConfigureEntry_Click(object sender, EventArgs e)
        {
            switch ((PulseOnChangeModes)edMode.selectedItem)
            {
                case PulseOnChangeModes.PULSE_ON_CHANGE:
                    {
                        PulseOnChange.setEntryOnChange((byte)cbEntry.SelectedIndex, swpdcFirstSource.DataSourceValue);
                    }
                    break;
                case PulseOnChangeModes.PULSE_ON_INCREASE:
                    {
                        PulseOnChange.setEntryOnIncrease((byte)cbEntry.SelectedIndex, swpdcFirstSource.DataSourceValue);
                    }
                    break;


                case PulseOnChangeModes.PULSE_ON_DECREASE:
                    {
                        PulseOnChange.setEntryOnDecrease((byte)cbEntry.SelectedIndex, swpdcFirstSource.DataSourceValue);
                    }
                    break;


                case PulseOnChangeModes.PULSE_EQUAL_VALUE:
                    {
                        PulseOnChange.setEntryOnEqualValue((byte)cbEntry.SelectedIndex, swpdcFirstSource.DataSourceValue, sbsiParam1.value);
                    }
                    break;


                case PulseOnChangeModes.PULSE_BELOW_VALUE:
                    {
                        PulseOnChange.setEntryOnLessThanValue((byte)cbEntry.SelectedIndex, swpdcFirstSource.DataSourceValue, sbsiParam1.value);
                    }
                    break;


                case PulseOnChangeModes.PULSE_ABOVE_VALUE:
                    {
                        PulseOnChange.setEntryOnGreaterThanValue((byte)cbEntry.SelectedIndex, swpdcFirstSource.DataSourceValue, sbsiParam1.value);
                    }
                    break;


                case PulseOnChangeModes.PULSE_NOT_EQUAL_VALUE:
                    {
                        PulseOnChange.setEntryOnNotEqualValue((byte)cbEntry.SelectedIndex, swpdcFirstSource.DataSourceValue, sbsiParam1.value);
                    }
                    break;


                case PulseOnChangeModes.PULSE_EQUAL_PIN:
                    {
                        PulseOnChange.setEntryOnPinsEqual((byte)cbEntry.SelectedIndex, swpdcFirstSource.DataSourceValue, swpdcSecondSource.DataSourceValue);

                    }
                    break;


                case PulseOnChangeModes.PULSE_ABOVE_PIN:
                    {
                        PulseOnChange.setEntryOnPinGreaterThanPin((byte)cbEntry.SelectedIndex, swpdcFirstSource.DataSourceValue, swpdcSecondSource.DataSourceValue);

                    }
                    break;


                case PulseOnChangeModes.PULSE_BELOW_PIN:
                    {
                        PulseOnChange.setEntryOnPinLessThanPin((byte)cbEntry.SelectedIndex, swpdcFirstSource.DataSourceValue, swpdcSecondSource.DataSourceValue);
                    }
                    break;


                case PulseOnChangeModes.PULSE_NOT_EQUAL_PIN:
                    {
                        PulseOnChange.setEntryOnPinsNotEqual((byte)cbEntry.SelectedIndex, swpdcFirstSource.DataSourceValue, swpdcSecondSource.DataSourceValue);
                    }
                    break;

                    /*
                case PulseOnChangeModes.PULSE_CROSS_VALUE:
                    {

                    }
                    break;


                case PulseOnChangeModes.PULSE_CROSS_VALUE_ASCENDING:
                    {

                    }
                    break;


                case PulseOnChangeModes.PULSE_CROSS_VALUE_DESCENDING:
                    {

                    }
                    break;


                case PulseOnChangeModes.PULSE_WITHIN_RANGE:
                    {

                    }
                    break;


                case PulseOnChangeModes.PULSE_OUTSIDE_RANGE:
                    {

                    }
                    break;
                    */

            }
        }

        private void bGenCode_Click(object sender, EventArgs e)
        {
            string s =
@$"
                //Put this line before setup()
                SerialWombatPulseOnChange {Name}(sw); // Your serial wombat chip may be named something else than sw
                //Add this line to  setup():
                {Name}.begin({Pin}, 
                  {(SerialWombatPinStates)edActive.selectedItem},
                  {(SerialWombatPinStates)edInactive.selectedItem},
                {sbsiActiveTime.value},
                 {sbsiInactiveTime.value},
                 {rbLogicalOr.Checked},
                {sbsiPWMPeriod.value},
                 {sbsiDutyCycle.value});
";
            s = s.Replace("True", "true");
            s = s.Replace("False", "false");
            Clipboard.SetText(s);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string s =
@$"

                //Add this line to  setup():
";
              switch ((PulseOnChangeModes)edMode.selectedItem)
            {
                case PulseOnChangeModes.PULSE_ON_CHANGE:
                    {
                        s += $"{Name}.setEntryOnChange({(byte)cbEntry.SelectedIndex}, {swpdcFirstSource.DataSourceValue});";
                    }
                    break;
                case PulseOnChangeModes.PULSE_ON_INCREASE:
                    {
                        s += $"{Name}.setEntryOnIncrease({(byte)cbEntry.SelectedIndex},{swpdcFirstSource.DataSourceValue});";
                    }
                    break;


                case PulseOnChangeModes.PULSE_ON_DECREASE:
                    {
                        s += $"{Name}.setEntryOnDecrease({(byte)cbEntry.SelectedIndex}, {swpdcFirstSource.DataSourceValue});";
                    }
                    break;


                case PulseOnChangeModes.PULSE_EQUAL_VALUE:
                    {
                        s += $"{Name}.setEntryOnEqualValue({(byte)cbEntry.SelectedIndex}, {swpdcFirstSource.DataSourceValue}, {sbsiParam1.value});";
                    }
                    break;


                case PulseOnChangeModes.PULSE_BELOW_VALUE:
                    {
                        s += $"{Name}.setEntryOnLessThanValue({(byte)cbEntry.SelectedIndex}, {swpdcFirstSource.DataSourceValue}, {sbsiParam1.value});";
                    }
                    break;


                case PulseOnChangeModes.PULSE_ABOVE_VALUE:
                    {
                        s += $"{Name}.setEntryOnGreaterThanValue({(byte)cbEntry.SelectedIndex}, {swpdcFirstSource.DataSourceValue}, {sbsiParam1.value});";
                    }
                    break;


                case PulseOnChangeModes.PULSE_NOT_EQUAL_VALUE:
                    {
                        s += $"{Name}.setEntryOnNotEqualValue({(byte)cbEntry.SelectedIndex},{ swpdcFirstSource.DataSourceValue}, {sbsiParam1.value});";
                    }
                    break;


                case PulseOnChangeModes.PULSE_EQUAL_PIN:
                    {
                        s += $"{Name}.setEntryOnPinsEqual({(byte)cbEntry.SelectedIndex}, {swpdcFirstSource.DataSourceValue}, {swpdcSecondSource.DataSourceValue});";
                    }
                    break;


                case PulseOnChangeModes.PULSE_ABOVE_PIN:
                    {
                        s += $"{Name}.setEntryOnPinGreaterThanPin({(byte)cbEntry.SelectedIndex}, {swpdcFirstSource.DataSourceValue}, {swpdcSecondSource.DataSourceValue});";

                    }
                    break;


                case PulseOnChangeModes.PULSE_BELOW_PIN:
                    {
                        s += $"{Name}.setEntryOnPinLessThanPin({(byte)cbEntry.SelectedIndex}, {swpdcFirstSource.DataSourceValue}, {swpdcSecondSource.DataSourceValue});";
                    }
                    break;


                case PulseOnChangeModes.PULSE_NOT_EQUAL_PIN:
                    {
                        s += $"{Name}.setEntryOnPinsNotEqual({(byte)cbEntry.SelectedIndex}, {swpdcFirstSource.DataSourceValue}, {swpdcSecondSource.DataSourceValue});";
                    }
                    break;

                    /*
                case PulseOnChangeModes.PULSE_CROSS_VALUE:
                    {

                    }
                    break;


                case PulseOnChangeModes.PULSE_CROSS_VALUE_ASCENDING:
                    {

                    }
                    break;


                case PulseOnChangeModes.PULSE_CROSS_VALUE_DESCENDING:
                    {

                    }
                    break;


                case PulseOnChangeModes.PULSE_WITHIN_RANGE:
                    {

                    }
                    break;


                case PulseOnChangeModes.PULSE_OUTSIDE_RANGE:
                    {

                    }
                    break;
                    */

                  
                }
            s += Environment.NewLine;
            if (Clipboard.ContainsText())
            {
                s = Clipboard.GetText() + s;
            }
            Clipboard.SetText(s);
        }

    }
}
