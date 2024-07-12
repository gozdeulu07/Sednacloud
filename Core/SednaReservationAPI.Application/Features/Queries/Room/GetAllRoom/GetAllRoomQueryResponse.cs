using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SednaReservationAPI.Application.Features.Queries.Room.GetAllRoom
{
    public class GetAllRoomQueryResponse
    {
        public string? Id { get; set; }
        public int HotelId { get; set; }
        public int RoomTypeId { get; set; }
        public decimal BasePrice { get; set; }
        public string? Status { get; set; }
    }
}
