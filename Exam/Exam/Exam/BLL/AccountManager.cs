using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Exam.BLL
{
    public class AccountManager
    {
        public static bool Validate(string Username, string Password)
        {
            bool status = false;

            if (Username == "admin@iet.com" && Password == "ankita@12")
            {
                status = true;
                return status;
            }

            return status;
        }
    }
}