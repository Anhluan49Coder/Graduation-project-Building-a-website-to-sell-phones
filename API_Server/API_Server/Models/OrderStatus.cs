﻿namespace API_Server.Models
{
    public class OrderStatus
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Invoice> Invoices { get; set; }

    }
}
