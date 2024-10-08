﻿namespace ACA.DeliverySystem.Data.Models
{
    public class Order
    {
        public Order()
        {
            Date = DateOnly.FromDateTime(DateTime.Now);
        }

        public string Name { get; set; }

        public int Id { get; set; }

        public int? UserId { get; set; }
        public int? OrderItemId { get; set; }
        public DateOnly Date { get; private set; }

        public decimal PaidAmount { get; set; }
        public decimal AmountToPay { get; set; }

        public ProgressEnum ProgressEnum { get; set; } = ProgressEnum.Created;

        public User User { get; set; }
        public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

    }
}
