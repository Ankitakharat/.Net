using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //one dimensional array
            int[] nums = new int[3] { 10, 20, 30 };

            // Mulit dimensional array
            string[] names = { "Ankita", "Bhagyaa", "Komal" };

            //Rectangular array
            int[,] matrix = new int[2, 3]
            {
                {10,20,30},
                {40,50,60}
            };

            int number = matrix[1, 1];
            Console.WriteLine(number);

            //Jagged array
            //array of array

            int[][] temperature = new int[2][];
            temperature[0] = new int[] { 10, 15, 20, 25 };
            temperature[1] = new int[] { 30, 35, 40, 45, 50, 55, 60, 65 };

            int temp = temperature[1][2];

            int length1 = temperature[0].Length;
            int length2 = temperature[1].Length;

            Console.WriteLine(temp);

            Console.WriteLine("_________________________________________________________");
            int[] marks = { 56, 76, 87, 56, 89, 89 };
            foreach (int mark in marks)
            {
                Console.WriteLine(mark);
            }

            Array.Sort(marks);
            Console.WriteLine("After sorting......");
            foreach (int mark in marks)
            {
                Console.WriteLine(mark);
            }

            //Serialization using xml file

            WriteXML();

            Console.ReadLine();

        }

        private static void WriteXML()
        {
            throw new NotImplementedException();
        }
    }
}
