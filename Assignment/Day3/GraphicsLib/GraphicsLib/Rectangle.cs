using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsLib
{
    public class Rectangle : Shape,IPrintable
    {
        public Point StartPoint;
        public Point EndPoint;

        public Rectangle()
        {
            StartPoint = new Point();
            StartPoint.X = 0;
            StartPoint.Y = 0;

            EndPoint = new Point();
            EndPoint.X = 0;
            EndPoint.Y = 0;

            Color = "Black";
            Width = 10;
        }

        public Rectangle(Point startPoint, Point endPoint, int w, string color)
        {
            StartPoint = startPoint;
            EndPoint = endPoint;
            Width = w;
            Color = color;
        }
        public string printToPaper()
        {
            return "Write on the Paper";
        }
        public string printToScreen()
        {
            return "Watch on the Screen";
        }
        public override string Draw()
        {
            int length = EndPoint.X - StartPoint.X;
            int width = EndPoint.Y - StartPoint.Y;
            int area = length * width;
            return area+" "+this.Width+" "+this.Color;
        }
    }
}
