using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Data.Entities
{
    public class OrderDetail
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }

        public Order Order { get; set; }

        public Product Product { get; set; }
    }
}
