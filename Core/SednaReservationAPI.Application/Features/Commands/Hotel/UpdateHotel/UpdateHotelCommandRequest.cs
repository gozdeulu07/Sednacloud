using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SednaReservationAPI.Application.Features.Commands.Hotel.UpdateHotel
{
    public class UpdateHotelCommandRequest : IRequest<UpdateHotelCommandResponse>
    {
        public string Id { get; set; }
    }
}
