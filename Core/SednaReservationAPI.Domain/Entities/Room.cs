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
<<<<<<< HEAD
        public Guid HotelId { get; set; }
        public int RoomTypeId { get; set; }
=======
        public string? HotelId { get; set; }
        public string? RoomTypeId { get; set; }
>>>>>>> Berke
        public decimal BasePrice { get; set; }
        public string? Status { get; set; }
    }
}
