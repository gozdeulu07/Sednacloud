﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SednaReservationAPI.Application.Features.Queries.Reservation.GetByIdReservation
{
    public class GetByIdReservationQueryResponse
    {
        public string? Id { get; set; }
        public string? UserId { get; set; }
        public string? RoomId { get; set; }
        public string? HotelId { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public decimal TotalPrice { get; set; }
        public string? Status { get; set; }
    }
}
