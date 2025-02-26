﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using ScottPlot;
using SerialWombat;
using System.Diagnostics;
using System.Security.Policy;

namespace SerialWombatWindowsFormsLibrary
{
    public partial class AnalogInputControl : UserControl
    {
        public SerialWombatAnalogInput AnalogInput;

        public byte Pin = 0;
        public SerialWombatChip SerialWombatChip;
     
        double Vcc = 3.3;
        AnalogInputResult LastResult = new AnalogInputResult();
        private delegate void SafeCallDelegate();



        public AnalogInputControl()
        {
            InitializeComponent();


        }

        public void begin(SerialWombatChip serialWombatChip, byte pin)
        {
        Pin = pin;
            SerialWombatChip = serialWombatChip;
            AnalogInputControl_Load(this,null);
        groupBox1.Text = "";
            Text = $"Analog Input on pin {pin}";
            this.Name = $"Pin{pin}AnalogInput";

        }


        public void end()
        {
            ckbAutosample.Checked = false;
        }
        

       

        private void bSample_Click(object sender, EventArgs e)
        {
            LastResult.PublicData = SerialWombatChip.readPublicData(AnalogInput.Pin);
            LastResult.Averaged = AnalogInput.readAveragedCounts();
            LastResult.Filtered = AnalogInput.readFilteredCounts();
            LastResult.Maximum = AnalogInput.readMaximumCounts(false);
            LastResult.Minimum = AnalogInput.readMinimumCounts(false);

            
            if (ckbVolts.Checked)
            {
               realTimeScottPlot1.PlotData(  LastResult.PublicData / 65535.0 * Vcc);
            }
            else
            {
                realTimeScottPlot1.PlotData(LastResult.PublicData);
            }
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbAutosample.Checked)
            {
                Thread t = new Thread(SampleThread);
                t.Start();
                bSample.Enabled = false;

            }
            else
            {
                bSample.Enabled = true;
            }
        }

        void SampleThread()
        {
            while (ckbAutosample.Checked)
            {
                try
                {

                    if (AnalogInput != null)
                    {
                        LastResult.PublicData = SerialWombatChip.readPublicData(AnalogInput.Pin);
                        LastResult.Averaged = AnalogInput.readAveragedCounts();
                        LastResult.Filtered = AnalogInput.readFilteredCounts();
                        LastResult.Maximum = AnalogInput.readMaximumCounts(false);
                        LastResult.Minimum = AnalogInput.readMinimumCounts(false);


                        if (ckbVolts.Checked)
                        {
                            realTimeScottPlot1.PlotData(LastResult.PublicData / 65535.0 * Vcc);
                        }
                        else
                        {
                            realTimeScottPlot1.PlotData(LastResult.PublicData);
                        }
                    }
                }
                catch { }
                Thread.Sleep(100);


            }

          
        }
        public void updateData()
        {
            if (tbAveraged.InvokeRequired)
            {
                var d = new SafeCallDelegate(updateData);
                tbAveraged.Invoke(d, new object[] { });
            }
            else
            {
                tbAveraged.Text = LastResult.Averaged.ToString();
                tbFiltered.Text = LastResult.Filtered.ToString();
                tbMax.Text = LastResult.Maximum.ToString();
                tbMin.Text = LastResult.Minimum.ToString();
            }
            
        }
        public void AnalogInputControl_FormClosing(object sender, FormClosingEventArgs e)
        {
            ckbAutosample.Checked = false;
        }

        private void AnalogInputControl_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }

        private void bConfigure_Click(object sender, EventArgs e)
        {
            try
            {
                // AnalogInput = new AnalogInput(Pin, SerialWombatChip,Pin, (AnalogInPublicDataSelection)comboBox1.SelectedIndex, Convert.ToUInt16(tbFilterConstant.Text), Convert.ToUInt16(tbAverage.Text)); 
                AnalogInput = new SerialWombatAnalogInput(SerialWombatChip);
                AnalogInput.begin(Pin, Convert.ToUInt16(tbAverage.Text), Convert.ToUInt16(tbFilterConstant.Text), (AnalogInputPublicDataOutput)comboBox1.SelectedIndex);
                bSample.Enabled = true;
                ckbAutosample.Enabled = true;
                bGenCode.Enabled = true;    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void ckbVolts_CheckedChanged(object sender, EventArgs e)
        { /*
            if (ckbVolts.Checked)
            {
               
                WombatSupplyVoltagePacket wsvp = new WombatSupplyVoltagePacket();
                WombatSupplyVoltagePacket response = (WombatSupplyVoltagePacket)SerialWombat.Send(wsvp);
                Vcc = response.SupplyVoltage;
                ckbVolts.Text = $"Volts (Vcc = {Vcc})";
                for (int i = 0; i < Raw16Data.Length; ++ i)
                {
                    Raw16Data[i] = Raw16Data[i] / 65535.0 * Vcc;
                }
            }
            else
            {
                ckbVolts.Text = "Volts";
                for (int i = 0; i < Raw16Data.Length; ++i)
                {
                    Raw16Data[i] = Raw16Data[i] * 65535.0 / Vcc;
                }
            }
        */

        }

        private void button4_Click(object sender, EventArgs e)
        {

            string analogType = "SerialWombatAnalogInput";
            if (AnalogInput._sw.isSW18())
            {
                analogType = "SerialWombatAnalogInput_18AB";
            }
            string s =
            @$"
                //Put this line before setup()
                {analogType} {Name}(sw); // Your serial wombat chip may be named something else than sw
                //Add this line to  setup():
                                {Name}.begin({Pin}, //Pin Number
                                {Convert.ToUInt16(tbAverage.Text)},  // Samples per Average
                                {Convert.ToUInt16(tbFilterConstant.Text)},//Filter Constant 
                                AnalogInputPublicDataOutput::AnalogInputPublicDataOutput_{(AnalogInputPublicDataOutput)comboBox1.SelectedIndex}); //Public data output
";


            Clipboard.SetText(s);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo processInfo = new ProcessStartInfo();
            processInfo.FileName = "https://broadwellconsultinginc.github.io/SerialWombatArdLib/class_serial_wombat_analog_input.html";
            processInfo.UseShellExecute = true;
            Process.Start(processInfo);
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo processInfo = new ProcessStartInfo();
            processInfo.FileName = "https://youtu.be/_EKlrEVaEhg";
            processInfo.UseShellExecute = true;
            Process.Start(processInfo);
        }
    }

    public class AnalogInputResult
    {
        public UInt16 Minimum;
        public UInt16 Maximum;
        public UInt16 PublicData;
        public UInt16 Filtered;
        public UInt16 Averaged;

        public AnalogInputResult() { }
        public AnalogInputResult(UInt16 minimum, UInt16 maximum, UInt16 publicdata, UInt16 filtered, UInt16 averaged)
        { Minimum = minimum; Maximum = maximum; PublicData = publicdata; Filtered = filtered; Averaged = averaged; }
    }
}

