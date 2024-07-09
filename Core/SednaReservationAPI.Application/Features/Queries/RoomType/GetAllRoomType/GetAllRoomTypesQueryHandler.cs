using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SednaReservationAPI.Application.Features.Queries.RoomType.GetAllRoomType
{
    public class GetAllRoomTypesQueryHandler : IRequestHandler<GetAllRoomTypesQueryRequest, GetAllRoomTypesQueryResponse>
    {
        public Task<GetAllRoomTypesQueryResponse> Handle(GetAllRoomTypesQueryRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
