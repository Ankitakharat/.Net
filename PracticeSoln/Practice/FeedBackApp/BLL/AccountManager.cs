using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FeedBackApp.BLL
{
    public class AccountManager
    {
        public static bool Validate(string username,string password)
        {
            bool status = false;
            if(username=="ankita" && password== "ankita@123")
            {
                status = true;
            }
            return status;
        }
    }
}