using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using FeedBackApp.Models;
using MySql.Data.EntityFramework;

namespace FeedBackApp.DAL
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class FeedbackContext : DbContext
    {
        public DbSet<Feedback> feedbacks { get; set; }
        public DbSet<Account> accounts { get; set; }
        public  FeedbackContext() : base("WebAppCon")
        {

        }
    }
}