using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Timers;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Test_Sniper
{
    public class Crosshair
    {
        public int Size { get; set; }
        public string Style { get; set; }
        public int Thickness { get; set; }
        public Color Color { get; set; }
        public Point currentPoint { get; set; }

        public Crosshair()
        {
            this.Size = 240;
            this.Style = "Dash";
            this.Thickness = 2;
            this.Color = Color.Red;
            currentPoint = new Point();
        }

        public Crosshair(Color color, int thickness, int size, string style)
        {
            this.Size = size;
            this.Style = style;
            this.Thickness = thickness;
            this.Color = color;
        }

        public void Draw(Graphics g)
        {
            Pen solidPen = new Pen(Color, 10);
            Pen dashedPen = new Pen(Color, Thickness);
            dashedPen.DashStyle = setDashStyle();
            SolidBrush brush = new SolidBrush(Color.Black);
            
            g.DrawLine(dashedPen, currentPoint.X, currentPoint.Y - (Size / 2), currentPoint.X, currentPoint.Y + (Size / 2));
            g.DrawLine(dashedPen, currentPoint.X - (Size / 2), currentPoint.Y, currentPoint.X + (Size / 2), currentPoint.Y);
            g.DrawEllipse(solidPen, currentPoint.X - (Size / 2), currentPoint.Y - (Size / 2), Size, Size);

            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(currentPoint.X - (Size / 2), currentPoint.Y - (Size / 2), Size, Size);
            Region region = new Region();
            region.Exclude(path);
            g.FillRegion(brush, region);
        }

        public DashStyle setDashStyle()
        {
            switch (Style)
            {
                case "Solid":
                    return System.Drawing.Drawing2D.DashStyle.Solid;
                case "Dash":
                    return System.Drawing.Drawing2D.DashStyle.Dash;
                case "Dot":
                    return System.Drawing.Drawing2D.DashStyle.Dot;
                case "DashDot":
                    return System.Drawing.Drawing2D.DashStyle.DashDot;
                case "DashDotDot":
                    return System.Drawing.Drawing2D.DashStyle.DashDotDot;
                default:
                    return System.Drawing.Drawing2D.DashStyle.Dash;
            }
        }
    }
}
