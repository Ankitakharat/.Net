using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    public class Controller
    {
        public void GET(string request,string response)
        {
            Console.WriteLine("GET from server");
        }
        public void POST(string request, string response)
        {
            Console.WriteLine("POST from server");
        }
        public void PUT(string request, string response)
        {
            Console.WriteLine("PUT from server");
        }
        public void DELETE(string request, string response)
        {
            Console.WriteLine("DELETE from server");
        }
    }
}
