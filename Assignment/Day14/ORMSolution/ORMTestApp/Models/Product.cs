using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;


namespace ORMTestApp.Models
{
     //POCO class
        [Table("Product")]
        public class Product
        {
            public int Id { get; set; }

         
            public string Name { get; set; }
           public string Discription { get; set; }

            [Range(minimum: 4, maximum: 1000)]
            public int Price { get; set; }

        }
    }
