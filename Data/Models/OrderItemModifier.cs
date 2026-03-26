// OrderItemModifier.cs

using System;

namespace Data.Models
{
    public class OrderItemModifier
    {
        public int Id { get; set; }
        public int OrderItemId { get; set; }
        public string ModifierName { get; set; }
        public decimal Price { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}