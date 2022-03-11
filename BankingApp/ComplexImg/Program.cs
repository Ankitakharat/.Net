using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mathematic;

namespace ComplexImg
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Good Morning");
            DateTime time = DateTime.Now;
            Console.WriteLine(time);


            Complex c2 = new Complex(56, 54);

            Point startPoint = new Point();
            startPoint.x = 12;
            startPoint.y = 56;


            int x = 56; //pushed on stack

            Console.WriteLine(x);

            Complex c1 = new Complex();
            //Complex instance will be created on heap
            //c1 will contain refernce which will pushed on stack

            Console.ReadLine();
        }
    }
}
