using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SednaReservationAPI.Application.Features.Queries.RoomType.GetByIdRoomType
{
    public class GetByIdRoomTypeQueryHandler : IRequestHandler<GetByIdRoomTypeQueryRequest, GetByIdRoomTypeQueryResponse>
    {
        public Task<GetByIdRoomTypeQueryResponse> Handle(GetByIdRoomTypeQueryRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
