using CommunityProApp.Enums;
using System;
using System.Collections.Generic;

namespace CommunityProApp.Entities
{
    public class Order : BaseEntity
    {
        public string OrderReference { get; set; }

        public int CustomerId { get; set; }

        public Customer Customer { get; set; }

        public OrderStatus Status { get; set; }

        public string DeliveryAddress { get; set; }

        public DateTime DeliveryDate { get; set; }

        public decimal TotalPrice { get; set; }

        public ICollection<OrderProduct> OrderProducts { get; set; } = new List<OrderProduct>();
        public ICollection<OrderFoodItem> OrderFoodItems { get; set; } = new List<OrderFoodItem>();
    }
}
