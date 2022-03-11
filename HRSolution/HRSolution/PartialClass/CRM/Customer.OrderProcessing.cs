using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PartialClass
{
   public partial class Customer
    {
        public Customer(string fname, string lname, int orderId)
        {
            this.FirstName = fname;
            this.LastName = lname;
            this.OrderId = orderId;
        }
        public Customer(string fname, string lname)
        {
            this.FirstName = fname;
            this.LastName = lname;

        }

        public int OrderId { get; set; }
        public string OrderStatus { get; set; }
        public void PlaceOrder() { }
        public void CancelOrder() { }
        public void ShowOrderHistory() { }
    }
}
