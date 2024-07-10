using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SednaReservationAPI.Application.Features.Commands.RoomType.CreateRoomType
{
    public class CreateRoomTypeCommandHandler : IRequestHandler<CreateRoomTypeCommandRequest, CreateRoomTypeCommandResponse>
    {
        public Task<CreateRoomTypeCommandResponse> Handle(CreateRoomTypeCommandRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
