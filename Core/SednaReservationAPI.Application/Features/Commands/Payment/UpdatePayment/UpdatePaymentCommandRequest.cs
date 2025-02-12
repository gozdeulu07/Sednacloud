﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SednaReservationAPI.Application.Features.Commands.Payment.UpdatePayment
{
    public class UpdatePaymentCommandRequest : IRequest<UpdatePaymentCommandResponse>
    {
        public string? Id { get; set; }
        public string? ReservationId { get; set; }
        public decimal Amount { get; set; }
        public string? Status { get; set; }
        public string? PaymentMethod { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
    }
}
