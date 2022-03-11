using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
   
   
 }
namespace HR
{
 
    class Person
    {
        private string _firstname;
        private string _lastname;
        private string _email;
        private long _phnno;
        public static int count = 0;

        public Person(string firstName, string lastName, string email, long phnNo)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            PhnNo = phnNo;
            count++;
        }

        public string FirstName
        {
            get
            {

                return _firstname;
            }
            set
            {
                _firstname = value;
            }
        }

        public string LastName
        {
            get
            {
                return _lastname;
            }
            set
            {
                _lastname = value;
            }
        }

        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                _email = value;
            }
        }

        public long PhnNo
        {
            get
            {
                return _phnno;
            }
            set
            {
                _phnno = value;
            }
        }
       
        
        public static int getCount()
        {
           
            return count;
        }
    }

}

