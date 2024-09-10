﻿namespace ACA.DeliverySystem.Business.Models
{
    public class OrderItemAddModel
    {
        public int ItemId { get; set; }
        public string? ItemName { get; set; }
        public int OrderId { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public ItemAddModel? Item { get; set; }
        public OrderAddModel? Order { get; set; }
    }
}
