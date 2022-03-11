using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializationDemo
{ 
    //anotation
    [Serializable]
   public  class Customer
    {
        public  string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhnNumber { get; set; }
    }
}
