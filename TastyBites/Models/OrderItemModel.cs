using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TastyBites.Models
{
    internal class OrderItemModel
    {
        public int OrderItemID { get; set; }  // optional, if you have PK in DB
        public int OrderID { get; set; }      // FK to Order
        public int MenuItemID { get; set; }   // FK to MenuItem
        public int Quantity { get; set; }
        public decimal ItemPriceAtOrderTime { get; set; }
    }
}
