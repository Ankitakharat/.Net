using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ToyStoreWeb.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public double UnitPrice { get; set; }
        public int Quantity { get; set; }

    }
}