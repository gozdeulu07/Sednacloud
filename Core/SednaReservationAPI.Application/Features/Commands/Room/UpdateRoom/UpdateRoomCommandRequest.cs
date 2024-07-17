using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SednaReservationAPI.Application.Features.Commands.Room.UpdateRoom
{
    public class UpdateRoomCommandRequest : IRequest<UpdateRoomCommandResponse>
    {
        public string? Id { get; set; }
        public string? HotelId { get; set; }
        public string? RoomTypeId { get; set; }
        public decimal? BaseAdultPrice { get; set; }
        public decimal? BaseChildPrice { get; set; }
        public string? Status { get; set; }
    }
}
