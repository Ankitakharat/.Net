using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFeature
{
    class Program
    {
        public const int count = 760;
        public readonly int numberOfLine;
        public string author;

        public Program()
        {
            numberOfLine = 500;
        }
        static void Main(string[] args)
        {
            const double PI = 3.14;
            Program theProgram = new Program();
            theProgram.author = "Ankita Kharat";
            Console.WriteLine("PI Value is {0}", PI);
            Console.ReadLine();
        }
    }
}
