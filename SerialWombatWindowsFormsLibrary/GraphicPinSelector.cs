using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SerialWombat;


namespace SerialWombatWindowsFormsLibrary
{
    public partial class GraphicPinSelector : Form
    {
        private SerialWombatModel _model = SerialWombatModel.SerialWombat18AB;
        ToolTip tt = null;
        public GraphicPinSelector()
        {
            InitializeComponent();

            tsmiAnalogInput.Click += TsmiAnalogInput_Click;
            tsmiInput.Click += Direct_Click;
            tsmiHigh.Click += Direct_Click;
            tsmiLow.Click += Direct_Click;
            tsmiDebounce.Click += TsmiDebounce_Click;
            tsmiServo.Click += TsmiServo_Click;
            tsmiPulseOnChange.Click += TsmiPulseOnChange_Click;
            tsmiPulseTimer.Click += TsmiPulseTimer_Click;
            tsmiQuadratureEncoder.Click += TsmiQuadratureEncoder_Click;
            tsmiPWM.Click += TsmiPWM_Click;
            tsmiWatchdog.Click += TsmiWatchdog_Click;
            tmsiTM1637.Click += TmsiTM1637_Click;
            tsmiMatrixKeypad.Click += TsmiMatrixKeypad_Click;


            pictureBox1.Image = Properties.Resources.LIT00034_SW18AB_PinDiagram;

            pictureBox1.Refresh();

            List<string> models = Enum.GetNames(typeof(SerialWombatModel)).ToList();
            foreach (string s in models)
            {
                cbModel.Items.Add(s);
            }
            cbModel.SelectedIndex = 2;
        }

        private void TsmiMatrixKeypad_Click(object sender, EventArgs e)
        {
            MatrixKeypadForm mkf = new MatrixKeypadForm(SerialWombatChip, _lastClickWombatPin);

            mkf.Tag = this;
            mkf.StartPosition = FormStartPosition.Manual;
            mkf.Location = this.Location;
            mkf.Show();
        }

        private void TsmiPulseOnChange_Click(object sender, EventArgs e)
        {
            PulseOnChangeForm pocf = new PulseOnChangeForm(SerialWombatChip, _lastClickWombatPin);
            pocf.Show(this);
            pocf.StartPosition = FormStartPosition.CenterParent;
        }

        private void TmsiTM1637_Click(object sender, EventArgs e)
        {
            TM1637Form tM1637Form = new TM1637Form(SerialWombatChip, _lastClickWombatPin);
            tM1637Form.Show();
        }

        private void TsmiDebounce_Click(object sender, EventArgs e)
        {
            DebounceForm df = new DebounceForm(SerialWombatChip, _lastClickWombatPin );
            df.Show();
        }

        private void TsmiWatchdog_Click(object sender, EventArgs e)
        {
           // WatchdogForm wdf = new WatchdogForm(_lastClickWombatPin,SerialWombatChip);
           // wdf.Show();
        }

        private void TsmiPulseTimer_Click(object sender, EventArgs e)
        {
            PulseTimerForm ptf = new PulseTimerForm(SerialWombatChip, _lastClickWombatPin);
            ptf.Show();
        }

        private void TsmiPWM_Click(object sender, EventArgs e)
        {
           PWMForm pWMForm = new PWMForm(SerialWombatChip, _lastClickWombatPin);
           pWMForm.Show();
        }

        private void TsmiQuadratureEncoder_Click(object sender, EventArgs e)
        {
           QuadratureEncoderForm qef = new QuadratureEncoderForm(SerialWombatChip, _lastClickWombatPin);
           qef.Show();
        }

        private void TsmiServo_Click(object sender, EventArgs e)
        {
            ServoForm sf = new ServoForm(SerialWombatChip, _lastClickWombatPin);
            sf.Show();
        }

        void clearLastClick()
        {
            
             _lastClickReset = false;
             _lastClickTx = false;
             _lastClickRx = false;
             _lastClickGnd = false;
             _lastClick33v = false;
             _lastClickVCAP = false;
             _lastClick5v = false;
             _lastClickSDA = false;
             _lastClickSCL = false;
        }


        Point _lastClickLocation = new Point(0, 0);
        byte _lastClickWombatPin = 255;
        bool _lastClickReset = false;
        bool _lastClickTx = false;
        bool _lastClickRx = false;
        bool _lastClickGnd = false;
        bool _lastClick33v = false;
        bool _lastClickVCAP = false;
        bool _lastClick5v = false;
        bool _lastClickSDA = false;
        bool _lastClickSCL = false;
        bool _lastClickAddr = false;
        public SerialWombatChip SerialWombatChip = null;
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            _lastClickLocation = e.Location;
            if (_model == SerialWombatModel.SerialWombat18AB)
            {
                _lastClickWombatPin = chipCalcPin19A(_lastClickLocation);
            }
            else if (_model == SerialWombatModel.SerialWombat4A)
            {
                _lastClickWombatPin = chipCalcPin4A(_lastClickLocation);
            }
            else if (_model == SerialWombatModel.SerialWombat4B)
            {
                _lastClickWombatPin = chipCalcPin4B(_lastClickLocation);
            }
        }

        private void Direct_Click(object sender, EventArgs e)
        {
            if (SerialWombatChip != null)
            {
                /*TODO
                WombatSetPinModeDigitalIO0 cmd = new WombatSetPinModeDigitalIO0(_lastClickWombatPin, DigitalIOState.Input);
                if (sender == tsmiInput)
                {
                    cmd.State = DigitalIOState.Input;
                }
                else if (sender == tsmiHigh)
                {
                    cmd.State = DigitalIOState.High;
                }
                else if (sender == tsmiLow)
                {
                    cmd.State = DigitalIOState.Low;
                }
                SerialWombat.Send(cmd);
                */
            }
        }

        private void TsmiAnalogInput_Click(object sender, EventArgs e)
        {
           AnalogInputForm aiForm = new AnalogInputForm(SerialWombatChip, _lastClickWombatPin);
           aiForm.Show();
        }

        public GroupBox GetGroupBox()
        {
            GroupBox gb = groupBox1;
            Controls.Remove(groupBox1);
            return (gb);
        }
        byte chipCalcPin19A(Point l)
        {

            // Given a point, X and Y, convert the location on the chip 
            // bitmap to its equivalent pin.

            clearLastClick();
            if (l.X <= (154 / 3))
            {
                if (l.Y >= 17 && l.Y <= 32)
                {
                    _lastClickReset = true;
                }

                if (l.Y >= 40 && l.Y <= 55)
                {
                    return (0);
                }
                if (l.Y >= 63 && l.Y <= 77)
                {
                    _lastClickAddr = true;
                }
                if (l.Y >= 84 && l.Y <= 99)
                {
                    return (1);
                }
                if (l.Y >= 106 && l.Y <= 121)
                {
                    return (2);
                }
                if (l.Y >= 127 && l.Y <= 142)
                {
                    return (3);
                }
                if (l.Y >= 149 && l.Y <= 164)
                {
                    return (4);
                }
                if (l.Y >= 158 && l.Y <= 182)
                {
                    _lastClickGnd = true;
                }

                if (l.Y >= 190 && l.Y <= 205)
                {
                    return (5);
                }
                if (l.Y >= 212 && l.Y <= 227)
                {
                    return (6);
                }

                if (l.Y >= 233 && l.Y <= 248)
                {
                    _lastClickTx = true;
                    return (7);
                }

                if (l.Y >= 254 && l.Y <= 269)
                {
                    return (8);

                }
                if (l.Y >= 275 && l.Y <= 290)
                {
                    _lastClick33v = true;
                }

                if (l.Y >= 297 && l.Y <= 312)
                {
                    _lastClickRx = true;
                    return (9);
                }
            }

            else if (l.X >= (2 * 154 / 3))
            {
                if (l.Y >= 17 && l.Y <= 32)
                {
                    _lastClick33v = true;
                }

                if (l.Y >= 63 && l.Y <= 77)
                {
                    return (19);
                }
                if (l.Y >= 84 && l.Y <= 99)
                {
                    return (18);
                }
                if (l.Y >= 106 && l.Y <= 121)
                {
                    return (17);
                }
                if (l.Y >= 127 && l.Y <= 142)
                {
                    return (16);
                }
                if (l.Y >= 149 && l.Y <= 164)
                {
                    return (15);
                }
                if (l.Y >= 169 && l.Y <= 184)
                {
                    return (14);
                }
                if (l.Y >= 190 && l.Y <= 205)
                {
                    _lastClickVCAP = true;
                }
                if (l.Y >= 212 && l.Y <= 227)
                {
                    _lastClickGnd = true;
                }

                if (l.Y >= 233 && l.Y <= 248)
                {
                    return (13);
                }
                if (l.Y >= 254 && l.Y <= 269)
                {
                    return (12);
                }
                if (l.Y >= 275 && l.Y <= 290)
                {
                    return (11);
                }
                if (l.Y >= 297 && l.Y <= 312)
                {
                    return (10);
                }
            }
            return (255);
        }
        byte chipCalcPin4A(Point l)
        {

            // Given a point, X and Y, convert the location on the chip 
            // bitmap to its equivalent pin.

            clearLastClick();
            if (l.X <= (154 / 3))
            {
                    if (l.Y >= 17 && l.Y <= 32)
                {
                    _lastClick5v = true;
                }

                if (l.Y >= 40 && l.Y <= 55)
                {
                    return (0);
                }
                if (l.Y >= 63 && l.Y <= 77)
                {
                    return (1);
                }
                if (l.Y >= 84 && l.Y <= 99)
                {
                    _lastClickRx = true;
                }
                /*
                if (l.Y >= 106 && l.Y <= 121)
                {
                    return (3);
                }
                if (l.Y >= 127 && l.Y <= 142)
                {
                    return (4);
                }
                if (l.Y >= 149 && l.Y <= 164)
                {
                    return (5);
                }
                if (l.Y >= 158 && l.Y <= 182)
                {
                    _lastClickGnd = true;
                }

                if (l.Y >= 190 && l.Y <= 205)
                {
                    return (6);
                }
                if (l.Y >= 212 && l.Y <= 227)
                {
                    return (7);
                }

                if (l.Y >= 233 && l.Y <= 248)
                {
                    _lastClickTx = true;
                }

                if (l.Y >= 254 && l.Y <= 269)
                {
                    return (8);
                }
                if (l.Y >= 275 && l.Y <= 290)
                {
                    _lastClick33v = true;
                }

                if (l.Y >= 297 && l.Y <= 312)
                {
                    _lastClickRx = true;
                }
                */
            }

            else if (l.X >= (2 * 154 / 3))
            {
                if (l.Y >= 17 && l.Y <= 32)
                {
                    _lastClickGnd = true;
                }

                if (l.Y >= 40 && l.Y <= 55)
                {
                    return (3);
                }
                
                if (l.Y >= 63 && l.Y <= 77)
                {
                    return (2);
                }
                if (l.Y >= 84 && l.Y <= 99)
                {
                    _lastClickTx = true;
                }
                /*
              if (l.Y >= 106 && l.Y <= 121)
              {
                  _lastClickTx = true; 
              }

              if (l.Y >= 127 && l.Y <= 142)
              {
                  return (15);
              }
              if (l.Y >= 149 && l.Y <= 164)
              {
                  return (14);
              }
              if (l.Y >= 169 && l.Y <= 184)
              {
                  return (13);
              }
              if (l.Y >= 190 && l.Y <= 205)
              {
                  _lastClickVCAP = true;
              }
              if (l.Y >= 212 && l.Y <= 227)
              {
                  _lastClickGnd = true;
              }

              if (l.Y >= 233 && l.Y <= 248)
              {
                  return (12);
              }
              if (l.Y >= 254 && l.Y <= 269)
              {
                  return (11);
              }
              if (l.Y >= 275 && l.Y <= 290)
              {
                  return (10);
              }
              if (l.Y >= 297 && l.Y <= 312)
              {
                  return (9);
              }
              */
            }
            return (255);
        }
        byte chipCalcPin4B(Point l)
        {

            // Given a point, X and Y, convert the location on the chip 
            // bitmap to its equivalent pin.

            clearLastClick();
            if (l.X <= (154 / 3))
            {
                if (l.Y >= 17 && l.Y <= 32)
                {
                    _lastClick5v = true;
                }

                if (l.Y >= 40 && l.Y <= 55)
                {
                    _lastClickSDA = true; ;
                }
                if (l.Y >= 63 && l.Y <= 77)
                {
                    _lastClickSCL = true;
                }
                if (l.Y >= 84 && l.Y <= 99)
                {
                    return (0);
                }
                /*
                if (l.Y >= 106 && l.Y <= 121)
                {
                    return (3);
                }
                if (l.Y >= 127 && l.Y <= 142)
                {
                    return (4);
                }
                if (l.Y >= 149 && l.Y <= 164)
                {
                    return (5);
                }
                if (l.Y >= 158 && l.Y <= 182)
                {
                    _lastClickGnd = true;
                }

                if (l.Y >= 190 && l.Y <= 205)
                {
                    return (6);
                }
                if (l.Y >= 212 && l.Y <= 227)
                {
                    return (7);
                }

                if (l.Y >= 233 && l.Y <= 248)
                {
                    _lastClickTx = true;
                }

                if (l.Y >= 254 && l.Y <= 269)
                {
                    return (8);
                }
                if (l.Y >= 275 && l.Y <= 290)
                {
                    _lastClick33v = true;
                }

                if (l.Y >= 297 && l.Y <= 312)
                {
                    _lastClickRx = true;
                }
                */
            }

            else if (l.X >= (2 * 154 / 3))
            {
                if (l.Y >= 17 && l.Y <= 32)
                {
                    _lastClickGnd = true;
                }
                if (l.Y >= 40 && l.Y <= 55)
                {
                    return (3);
                }
            

                if (l.Y >= 63 && l.Y <= 77)
                {
                    return (2);
                }
                if (l.Y >= 84 && l.Y <= 99)
                {
                    return (1);
                }
                /*
               if (l.Y >= 106 && l.Y <= 121)
               {
                   return (1);
               }

               if (l.Y >= 127 && l.Y <= 142)
               {
                   return (15);
               }
               if (l.Y >= 149 && l.Y <= 164)
               {
                   return (14);
               }
               if (l.Y >= 169 && l.Y <= 184)
               {
                   return (13);
               }
               if (l.Y >= 190 && l.Y <= 205)
               {
                   _lastClickVCAP = true;
               }
               if (l.Y >= 212 && l.Y <= 227)
               {
                   _lastClickGnd = true;
               }

               if (l.Y >= 233 && l.Y <= 248)
               {
                   return (12);
               }
               if (l.Y >= 254 && l.Y <= 269)
               {
                   return (11);
               }
               if (l.Y >= 275 && l.Y <= 290)
               {
                   return (10);
               }
               if (l.Y >= 297 && l.Y <= 312)
               {
                   return (9);
               }
               */
            }
            return (255);
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {

                if (_lastClickWombatPin == 255)
                {
                    tt = new ToolTip();

                    tt.ShowAlways = false;
                    if (_lastClickReset)
                    {
                        tt.Show("Reset Pin.  Connect to 3.3v via 10k Resistor.",(Control)sender,3000);
                    }
                    if (_lastClickGnd)
                    {
                        tt.Show("Ground Pin.  Connect directly to ground plane or rail.", (Control)sender, 3000);
                    }

                    if (_lastClickTx)
                    {
                        tt.Show("TX Pin.  Outputs UART at 115200.", (Control)sender, 3000);
                    }

                    if (_lastClickRx)
                    {
                        tt.Show("RX Pin.  Inputs UART at 115200.  5V tolerant pin.", (Control)sender, 3000);
                    }
                     
                    if (_lastClick33v)
                    {
                        tt.Show("3.3V power input.  Connect this pin to a supply voltage between 2.0 and 3.3V.  Connect this pin to ground with a 100nF 50v ceramic bypass capacitor", (Control)sender, 4000);
                    }

                    if (_lastClickVCAP)
                    {
                        tt.Show("Internal Voltage Regulator.  Connect this pin to ground with a 10uF 16v ceramic capacitor", (Control)sender, 4000);
                    }
                    
                    if (_lastClick5v)
                    {
                        tt.Show("5V power input.  Connect this pin to a supply voltage between 2.5 and 5V.  Connect this pin to ground with a 100nF 50v ceramic bypass capacitor", (Control)sender, 4000);
                    }

                    
                        if (_lastClickSDA)
                    {
                        tt.Show("I2C Peripheral SDA Pin.  Connect this pin to I2C Bus SDA line.  Requires external pull-up",(Control)sender,4000);
                    }
                    if (_lastClickSCL)
                    {
                        tt.Show("I2C Peripheral SCL Pin.  Connect this pin to I2C Bus SCL line.  Requires external pull-up", (Control)sender, 4000);
                    }

                    if (_lastClickAddr)
                    {
                        tt.Show("Address Pin.  Connect this pin to ground to initialize in Uart mode.  \nUnconnected = I2C:0x6B .  \n10k to Ground = 0x68\n20k to Ground = 0x69\n30k to Ground = 0x6A ", (Control)sender, 4000);
                    }

                    return;
                }



                tsmiAnalogInput.Enabled = true;
                tsmiHigh.Enabled = true;
                tsmiLow.Enabled = true;
                tsmiPWM.Enabled = true;
                tsmiServo.Enabled = true;
                if (_model == SerialWombatModel.SerialWombat18AB)
                {
                    switch (_lastClickWombatPin)
                    {
                        case byte n when (n <= 5 || (n >= 15 && n <= 18)):
                            tsmiAnalogInput.Enabled = true;
                            break;
                        default:
                            tsmiAnalogInput.Enabled = false;
                            break;
                    }
                }
                if (_model == SerialWombatModel.SerialWombat4B)
                {
                   
                        if (_lastClickWombatPin == 0)
                    { 
                            tsmiAnalogInput.Enabled = false;
                            tsmiHigh.Enabled = false;
                            tsmiLow.Enabled = false;
                            tsmiPWM.Enabled = false;
                            tsmiServo.Enabled = false;
                    
                         
                    }
                }

                Control c = (Control)sender;
                contextMenuStrip1.Show(c.PointToScreen(e.Location));
            }
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            if (_lastClickWombatPin != 255)
            {
                if (SerialWombatChip != null)
                {
                    UInt16 data = SerialWombatChip.readPublicData(_lastClickWombatPin);
                    label1.Text = $"Pin {_lastClickWombatPin} =  {data} / 0x{data:X4}";
                }
            }
        }

        private void cbModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(cbModel.SelectedIndex)
            {
              
                case 0:
                    {
                        _model = SerialWombatModel.SerialWombat4A;
                        pictureBox1.Image = Properties.Resources.pinDiagramWombat4A;
                        pictureBox1.Refresh();
                    }
                    break;
                case 1:
                    {
                        _model = SerialWombatModel.SerialWombat4B;
                        pictureBox1.Image = Properties.Resources.pinDiagramWombat4B;
                        pictureBox1.Refresh();
                    }
                    break;
                case 2:
                default:
                    {
                        _model = SerialWombatModel.SerialWombat18AB;
                        pictureBox1.Image = Properties.Resources.LIT00034_SW18AB_PinDiagram;
                        pictureBox1.Refresh();
                    }
                    break;
            }
        }
        public SerialWombatModel Model
        {
            get => _model;
            set
            {
                switch (value)
                {
                    case SerialWombatModel.SerialWombat18AB:
                    default:
                        {
                            cbModel.SelectedIndex = 2;
                        }
                        break;
                    case SerialWombatModel.SerialWombat4A:
                        {
                            cbModel.SelectedIndex = 0;
                        }
                        break;
                    case SerialWombatModel.SerialWombat4B:
                        {
                            cbModel.SelectedIndex = 1;
                        }
                        break;

                }
                _model = value;
            }
        }
        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            clearLastClick();

        }

        private void monitorPublicDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PublicDataMonitorForm pdMonitorForm = new PublicDataMonitorForm(SerialWombatChip, _lastClickWombatPin);
           pdMonitorForm.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ResistanceInputForm resistanceInputForm = new ResistanceInputForm(SerialWombatChip, _lastClickWombatPin);
            resistanceInputForm.Show();
        }

        private void queueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QueueForm qf = new QueueForm(SerialWombatChip);
            qf.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            PinStateMachineViewer psmv = new PinStateMachineViewer(SerialWombatChip,_lastClickWombatPin);
            psmv.Show();
        }

        private void tsmiHigh_Click(object sender, EventArgs e)
        {
            SerialWombatChip.digitalWrite(_lastClickWombatPin, 1);
            SerialWombatChip.pinMode(_lastClickWombatPin, 1);
            SerialWombatChip.digitalWrite(_lastClickWombatPin, 1);
        }

        private void tsmiLow_Click(object sender, EventArgs e)
        {
            SerialWombatChip.digitalWrite(_lastClickWombatPin, 0);
            SerialWombatChip.pinMode(_lastClickWombatPin, 1);
        }

        private void tsmiInput_Click(object sender, EventArgs e)
        {

            SerialWombatChip.pinMode(_lastClickWombatPin, 0);
        }

        private void ultraSonicDistanceSensorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UltrasonicDistanceSensorForm sensorForm = new UltrasonicDistanceSensorForm(SerialWombatChip, _lastClickWombatPin);
            sensorForm.Show();
        }
    }
}
