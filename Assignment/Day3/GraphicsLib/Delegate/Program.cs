using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Controller con = new Controller();
            Operation op = new Operation(con.GET);

            string req = "";
            string res = "";

            op(req, res);

            MathController math = new MathController();
            ArithmeticOp op1 = new ArithmeticOp(math.Add);

            int n1 = 10;
            int n2 = 20;

            int result = op1(n1, n2);

            Console.WriteLine("Arithmetic Result:" + result);
            Console.ReadLine();
        }
    }
}
