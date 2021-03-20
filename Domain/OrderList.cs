using System.Collections.Generic;

namespace Domain
{
    public class OrderList
    {
        public int Id { get; set; }
        public List<OrderItem> OrderItems { get; set; }
    }
}