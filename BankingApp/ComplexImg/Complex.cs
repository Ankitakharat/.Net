using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathematic
{
    class Complex
    {
        private int real;
        private int imag;

        public Complex()
        {
            Console.WriteLine("Invoking Default constructor.....");
        }
        public Complex(int r, int i) : this()
        {
            Console.WriteLine("Invoking Parametrized constructor.....");
            this.real = r;
            this.imag = i;
        }
        ~Complex()
        {
            // are always going to be invoked by Garbage Collector
        }

        #region oldway for defining  getter and setter
        /*public void setReal(int r)
        {
            this.real = r;
        }
        public int getReal()
        {
            return this.real;
        }

        */
        #endregion

        public void Display()
        {

        }
        //Property setter getter

        public int Real
        {
            get { return this.real; }
            set { this.real = value; }
        }

        public int Imag
        {
            get { return this.imag; }
            set { this.imag = value; }
        }
    }
}

