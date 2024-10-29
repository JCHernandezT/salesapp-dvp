using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesApp
{
    public class Order
    {
        public int Id { get; set; }
        public String OrderDate { get; set; }
        public String Customer { get; set; }
        public List<OrderItem> OrderItems { get; set; }
        public
        decimal TotalAmount
        { get; set; }
        public OrderStatus Status { get; set; }

        public Order()
        {
            OrderItems = new List<OrderItem>();
        }
    }
}
