using MySql.Data.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Exam.Models;

namespace Exam.DAL
{
        [DbConfigurationType(typeof(MySqlEFConfiguration))]
        public class WorkshopContext : DbContext
        {
            public DbSet<Workshop> Workshops { get; set; }

            public DbSet<Account> Accounts { get; set; }
            public WorkshopContext() : base("WebAppCon")
            {

            }
        }
    }
