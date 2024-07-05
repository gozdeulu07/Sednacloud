using SednaReservationAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SednaReservationAPI.Domain.Entities
{
    public class Room : BaseEntitity
    {
        public int HotelId { get; set; }
        public int RoomTypeId { get; set; }
        public decimal BasePrice { get; set; }
        public string? Status { get; set; }
    }
}
