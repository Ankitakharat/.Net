using System;

using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace SerializationDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer cust = new Customer
            {
                FirstName = "Ankita",
                LastName = "Kharat",
                Email = "ankita@gmail.com",
                PhnNumber = "3258996565"

            };

            string path = @"C:\Users\Ankita\Desktop\CDAC\.NET\data";
            SaveData(path, cust);

            Console.WriteLine(cust.FirstName+" "+cust.LastName+" "+cust.Email+" "+cust.PhnNumber);

            Console.ReadLine();

        }
        public  static void SaveData(string path, Customer cust)
        {
            FileStream fs = new FileStream(path, FileMode.OpenOrCreate);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs,cust);
            fs.Close();

        }

        
    }
}
