﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SednaReservationAPI.Application.Features.Commands.Room.UpdateRoom
{
    public class UpdateRoomCommandResponse
    {
        public int HotelId { get; set; }
        public int RoomTypeId { get; set; }
        public decimal BasePrice { get; set; }
        public string? Status { get; set; }
    }
}
