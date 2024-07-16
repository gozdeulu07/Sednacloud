using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SednaReservationAPI.Application.Features.Queries.Room.GetByIdRoom
{
    public class GetByIdRoomQueryResponse
    {
        public string? Id { get; set; }
        public int HotelId { get; set; }
        public int RoomTypeId { get; set; }
        public decimal? BaseAdultPrice { get; set; }
        public decimal? BaseChildPrice { get; set; }
        public string? Status { get; set; }
    }
}
