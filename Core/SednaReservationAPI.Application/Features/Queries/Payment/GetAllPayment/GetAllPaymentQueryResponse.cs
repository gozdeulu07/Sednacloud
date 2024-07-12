﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SednaReservationAPI.Application.Features.Queries.Payment.GetAllPayment
{
    public class GetAllPaymentQueryResponse
    {
        public string? Id { get; set; }
        public int ReservationId { get; set; }
        public decimal Amount { get; set; }
        public string? Status { get; set; }
        public string? PaymentMethod { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
    }
}