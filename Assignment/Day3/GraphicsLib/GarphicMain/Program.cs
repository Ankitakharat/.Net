using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GraphicsLib;

namespace GarphicMain
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(10, 20);
            Point p2 = new Point(1, 2);

            Shape s1 = null;

            Shape s2 = new Line(p1, p2, 1, "peach");

            s1 = s2;

            String result = s1.Draw();
            Console.WriteLine(result);

            

            Point p3 = new Point(100, 200);
            Point p4 = new Point(10, 20);

            Shape s3 = new Rectangle(p3, p4, 2, "Black");
            s1 = s3;

            String result1 = s1.Draw();
            Console.WriteLine(result1);
            if(s1 is Rectangle)
            {
                Console.WriteLine("Rectangle class is blueprint");
            }


            Rectangle rect = s3 as Rectangle;
            IPrintable print = rect;
            print.printToScreen();


            Console.ReadLine();


        }
    }
}
