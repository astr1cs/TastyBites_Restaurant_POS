using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TastyBites.Models
{
    internal class OrderItemModel
    {
        public int OrderItemID { get; set; } 
        public int OrderID { get; set; }      
        public int MenuItemID { get; set; }   
        public int Quantity { get; set; }
        public decimal ItemPriceAtOrderTime { get; set; }
    }
}
