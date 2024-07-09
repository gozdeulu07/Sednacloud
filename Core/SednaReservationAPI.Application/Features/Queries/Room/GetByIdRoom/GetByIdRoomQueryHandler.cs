using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SednaReservationAPI.Application.Features.Queries.Room.GetByIdRoom
{
    public class GetByIdRoomQueryHandler : IRequestHandler<GetByIdRoomQueryRequest, GetByIdRoomQueryResponse>
    {
        public Task<GetByIdRoomQueryResponse> Handle(GetByIdRoomQueryRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
