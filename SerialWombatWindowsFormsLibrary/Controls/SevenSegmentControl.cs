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
    public partial class SevenSegmentControl : UserControl
    {
        public SevenSegmentControl()
        {
            InitializeComponent();

            segments = new List<PointF[]> { aPoints, bPoints, cPoints, dPoints, ePoints, fPoints, gPoints,decPoints };
        }

        const float sideLength = 40;
        const float thickness = 5;
        const float slope = 5;

        const float top = 10;
        const float left = 10;

        const float separation = 3;


        PointF[] aPoints =
        {
          new PointF(left, top),
            new PointF(left + sideLength, top),
            new PointF(left+sideLength  - slope, top + thickness),
        new PointF(left + slope, top + thickness),
    };
        PointF[] bPoints =
       {
            new PointF(left + sideLength, top + separation),
            new PointF(left+ sideLength, top + sideLength+ separation),
            new PointF(left+ sideLength-thickness, top + sideLength - slope+ separation),
        new PointF(left+ sideLength-thickness, top + slope+ separation),
    };
        PointF[] cPoints =
      {
            new PointF(left + sideLength, top + sideLength + separation + separation),
            new PointF(left+ sideLength, top + sideLength + sideLength + separation+ separation),
            new PointF(left+ sideLength-thickness, top + sideLength - slope + sideLength + separation+ separation),
        new PointF(left+ sideLength-thickness, top + slope + sideLength + separation + separation),
    };

        PointF[] dPoints =
       {
          new PointF(left + slope, top + 2 * sideLength + separation + separation),
            new PointF(left - slope + sideLength, top+ 2 * sideLength + separation+ separation),
            new PointF(left+sideLength , top + thickness+ 2 * sideLength + separation+ separation),
        new PointF(left , top + thickness+ 2 * sideLength + separation+ separation),
    };

        PointF[] ePoints =
        {
          new PointF(left, top + sideLength + separation+ separation),
            new PointF(left, top + sideLength+ sideLength + separation+ separation),
            new PointF(left+thickness, top + sideLength - slope+ sideLength + separation+ separation),
        new PointF(left+thickness, top + slope+ sideLength + separation+ separation),
    };

        PointF[] fPoints =
         {
          new PointF(left, top+ separation),
            new PointF(left, top + sideLength+ separation),
            new PointF(left+thickness, top + sideLength - slope+ separation),
        new PointF(left+thickness, top + slope+ separation),
    };
        PointF[] gPoints =
        {
          new PointF(left , top + sideLength + .5F * separation + separation),
            new PointF(left + slope, top + sideLength + .5F * separation - .5F * thickness + separation),
            new PointF(left + sideLength - slope, top + sideLength + .5F * separation- .5F * thickness + separation),
            new PointF(left  + sideLength, top + sideLength + .5F * separation+ separation),
            new PointF(left + sideLength - slope, top + sideLength + .5F * separation + .5F * thickness+ separation),
            new PointF(left +  slope, top + sideLength + .5F * separation + .5F * thickness+ separation),
    };

        PointF[] decPoints =
        {
              new PointF(left  + sideLength + thickness + separation, top + 2 * (sideLength + separation)),
              new PointF(left  + sideLength + thickness + separation, top + 2 * (sideLength + separation) - thickness),
              new PointF(left  + sideLength + thickness + separation + thickness, top + 2 * (sideLength + separation) - thickness),
                       new PointF(left  + sideLength + thickness + separation + thickness, top + 2 * (sideLength + separation) ),
        };

        List<PointF[]> segments = new List<PointF[]>();
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // Create pen.
            SolidBrush redBrush = new SolidBrush(Color.Red);
            SolidBrush grayBrush = new SolidBrush(Color.Gray);

            if ((value & 0x01) > 0)
                e.Graphics.FillClosedCurve(redBrush, aPoints, System.Drawing.Drawing2D.FillMode.Winding, 0.0f);
            else
                e.Graphics.FillClosedCurve(grayBrush, aPoints, System.Drawing.Drawing2D.FillMode.Winding, 0.0f);


            if ((value & 0x02) > 0) e.Graphics.FillClosedCurve(redBrush, bPoints, System.Drawing.Drawing2D.FillMode.Winding, 0.0f);
            else
                e.Graphics.FillClosedCurve(grayBrush, bPoints, System.Drawing.Drawing2D.FillMode.Winding, 0.0f);
            if ((value & 0x04) > 0) e.Graphics.FillClosedCurve(redBrush, cPoints, System.Drawing.Drawing2D.FillMode.Winding, 0.0f);
            else
                e.Graphics.FillClosedCurve(grayBrush, cPoints, System.Drawing.Drawing2D.FillMode.Winding, 0.0f);
            if ((value & 0x08) > 0) e.Graphics.FillClosedCurve(redBrush, dPoints, System.Drawing.Drawing2D.FillMode.Winding, 0.0f);
            else
                e.Graphics.FillClosedCurve(grayBrush, dPoints, System.Drawing.Drawing2D.FillMode.Winding, 0.0f);
            if ((value & 0x10) > 0) e.Graphics.FillClosedCurve(redBrush, ePoints, System.Drawing.Drawing2D.FillMode.Winding, 0.0f);
            else
                e.Graphics.FillClosedCurve(grayBrush, ePoints, System.Drawing.Drawing2D.FillMode.Winding, 0.0f);
            if ((value & 0x20) > 0) e.Graphics.FillClosedCurve(redBrush, fPoints, System.Drawing.Drawing2D.FillMode.Winding,0.0f);
            else
                e.Graphics.FillClosedCurve(grayBrush, fPoints, System.Drawing.Drawing2D.FillMode.Winding, 0.0f);
            if ((value & 0x40) > 0) e.Graphics.FillClosedCurve(redBrush,gPoints, System.Drawing.Drawing2D.FillMode.Winding, 0.0f);
            else
                e.Graphics.FillClosedCurve(grayBrush, gPoints, System.Drawing.Drawing2D.FillMode.Winding, 0.0f);
            if ((value & 0x80) > 0) e.Graphics.FillClosedCurve(redBrush, decPoints, System.Drawing.Drawing2D.FillMode.Winding, 0.0f);
            else
                e.Graphics.FillClosedCurve(grayBrush, decPoints, System.Drawing.Drawing2D.FillMode.Winding, 0.0f);


        }

        byte _value = 0xFF;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public byte value
        {
            get { return _value; }
            set
            {
                if (_value != value)
                {

                    _value = value;
                }


            }
        }

        private void panel1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int x = e.X;
            int y = e.Y;
            int seg = within(x, y);
            if (seg < 0)
            {
                if (value > 0)
                {
                    value = 0;
                }
                else
                {
                    value = 0xFF;
                }
                this.Refresh();
            }
        }

        int within(int x, int y)
        {
            for (int i = 0; i < segments.Count; ++i)
            {
                float leastx = int.MaxValue;
                float leasty = int.MaxValue;
                float maxx = int.MinValue;
                float maxy = int.MinValue;
                foreach (PointF pointF in segments[i])
                {
                    if (pointF.X < leastx)
                    {
                        leastx = pointF.X;
                    }
                    if (pointF.Y < leasty)
                    {
                        leasty = pointF.Y;
                    }
                    if (pointF.X > maxx)
                    {
                        maxx = pointF.X;
                    }
                    if (pointF.Y > maxy)
                    {
                        maxy = pointF.Y;
                    }
                }
                if (x < leastx || y < leasty || x > maxx || y > maxy)
                {
                    continue;
                }
                else
                {
                    return (i);
                }
            }
            return (-1);

        }

        private void SevenSegmentControl_Load(object sender, EventArgs e)
        {
            this.Height = (int)(sideLength * 2 + 3 * separation + 2 * thickness);
            this.Width = (int)(sideLength + 2 * separation + 2 * thickness);
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            int x = e.X;
            int y = e.Y;
            int seg = within(x, y);
            if (seg >= 0)
            {
                byte val = value;
                val ^= (byte)(1 << seg);
                value = val;
            }

            this.Refresh();
        }
    }
}
