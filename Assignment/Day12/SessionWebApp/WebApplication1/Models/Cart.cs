using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AddtoCartWeb.Models
{
    public class Cart
    {
        private List<Item> items = new List<Item>();

        public List<Item> GetAllItems()
        {
            return items;
        }
        public bool AddItem(Item item)
        {
            bool status = false;
            items.Add(item);
            status = true;
            return status;
        }
        public bool RemoveItem(int id)
        {
            bool status = false;
            Item item = items.Find((theIitem) => theIitem.ProductId == id);
            items.Remove(item);
            status = true;
            return status;
        }
        public bool Update(Item itemTobeUpdated)
        {
            bool status = false;
            Item foundItem = items.Find((theIitem) => theIitem.ProductId == itemTobeUpdated.ProductId);
            foundItem.Quantity = itemTobeUpdated.Quantity;
            status = true;
            return status;
        }
    }
}