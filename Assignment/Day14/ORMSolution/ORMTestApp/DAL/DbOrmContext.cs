using MySql.Data.EntityFramework;
using ORMTestApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
namespace ORMTestApp.DAL
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]

    public class DbOrmContext: DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbOrmContext() : base("WebAppCon")
        {
        }
    }
}