using SerialWombat;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerialWombatWindowsFormsLibrary.Controls
{
    public partial class CapTouch18ABControl : UserControl
    {
        public SerialWombatChip SerialWombatChip;
        public byte Pin;
        SerialWombat18CapTouch ct;

        public CapTouch18ABControl()
        {
            InitializeComponent();
        }
        public void begin(SerialWombatChip serialWombatChip, byte pin)
        {
            SerialWombatChip = serialWombatChip;
            Pin = pin;
            ct = new SerialWombat18CapTouch(serialWombatChip);

            gbCapTouch.Text = $"Pin {Pin} Capactitive Touch";
            Name = $"Pin{Pin}_CapTouch";
        }

     
        private void bConfigure_Click_1(object sender, EventArgs e)
        {
            ct.begin(Pin, sbsiChargeTime.value, sbsiDelay.value);
            
            publicDataMonitorControl1.begin(SerialWombatChip, Pin);
        }

        private void bCalibrate_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Determining charge time.  Do not touch the sensor.");

            UInt16 noTouchReading = 0;
            UInt16 chargeTime = 250;
            ct.makeAnalog();

            Thread.Sleep(500);
            noTouchReading = ct.readPublicData();

            while (noTouchReading < 60000)
            {
                if (noTouchReading < 30000)
                {
                    chargeTime += 250;
                }
                else
                {
                    chargeTime += 250;
                }
                ct.begin(Pin, chargeTime, 20);
                Thread.Sleep(500);
                noTouchReading = ct.readPublicData();

            }
            UInt16 recommendedChargeTime = chargeTime;

            /*
            Serial.print("Recommended charge time: ");
            Serial.println(recommendedChargeTime);
            Serial.println();
            */

            // Now take a bunch of samples at that charge to see how much varation you get.  Find the
            // smallest returned value over 5 seconds.

            // Serial.println("Calibrating High Limit...");
            UInt16 HighLimit = 65535;
            DateTime end = DateTime.Now;
            end += new TimeSpan(0, 0, 0, 5); // Add 5 seconds
            while (end > DateTime.Now)
            {
                UInt16 result = ct.readPublicData();

                if (result < HighLimit)
                {
                    HighLimit = result;
                    //Serial.println(HighLimit);

                }

            }



            MessageBox.Show("Lightly Hold finger on sensor until told to remove...");
            // Wait for the user to touch the sensor  
            while (ct.readPublicData() > HighLimit - 1500)
            {
                //delay(250);
                //Serial.print(".");
            }
            //Serial.println();


            // Now take 5 seconds worth of samples to determine the maximum value you're likely to see
            // while touched.
            UInt16 LowLimit = 0;
            end = DateTime.Now;
            end += new TimeSpan(0, 0, 0, 5); // Add 5 seconds
            while (end > DateTime.Now)
            {
                {
                    UInt16 result = ct.readPublicData();

                    if (result > LowLimit)
                    {
                        LowLimit = result;
                        // Serial.println(LowLimit);
                    }
                }


                /*
            Serial.print("Recommended charge time: ");
            Serial.println(recommendedChargeTime);
            Serial.print("Recommended High Limit: ");
            Serial.println(LowLimit + (HighLimit - LowLimit) * 3 / 4);
            Serial.print("Recommended Low Limit: ");
            Serial.println(LowLimit + (HighLimit - LowLimit) / 4);

            Serial.println("Done.");

            Serial.println();
            Serial.println("Configuring Touch in digital mode using calibrations.");
            Serial.println();
               
            capTouch.makeDigital(LowLimit, HighLimit, 1, 0, false, 0);
            delay(250);
            lastDigitalRead = sw.readPublicData(TOUCH_PIN);
                 */
            }
            MessageBox.Show("Remove Finger.");
        }

        public void end()
        {
            publicDataMonitorControl1.end();
        }
    }
}
