using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SednaReservationAPI.Application.Features.Commands.Room.CreateRoom
{
    public class CreateRoomCommandRequest : IRequest<CreateRoomCommandResponse>
    {
        public int HotelId { get; set; }
        public int RoomTypeId { get; set; }
        public decimal? BaseAdultPrice { get; set; }
        public decimal? BaseChildPrice { get; set; }
        public string? Status { get; set; }
        public Domain.Entities.RoomType? RoomType { get; set; }
        //public ICollection<Domain.Entities.RoomType>? RoomTypes { get; set; }
    }
}
