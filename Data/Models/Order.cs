// Order.cs

using System;
using System.Collections.Generic;

namespace YourNamespace.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalAmount { get; set; }
        public string CustomerName { get; set; }
        // Add more properties related to Order as needed
    }
}