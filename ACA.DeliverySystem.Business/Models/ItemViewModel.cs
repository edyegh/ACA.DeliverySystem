﻿namespace ACA.DeliverySystem.Business.Models
{
    public class ItemViewModel
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }

        public string? ImageUrl { get; set; }
        public decimal Price { get; set; }
    }
}
