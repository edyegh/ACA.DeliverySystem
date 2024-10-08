﻿using ACA.DeliverySystem_Api.Models;

namespace ACA.DeliverySystem.Api.Models
{
    public class OrderViewModelDTO
    {
        public string? Name { get; set; }
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateOnly Date { get; set; }

        public decimal PaidAmount { get; set; }
        public decimal AmountToPay { get; set; }

        public ProgressEnum ProgressEnum { get; set; }
        public List<OrderItemViewModelDTO> Items { get; set; } = new List<OrderItemViewModelDTO>();

    }
}
