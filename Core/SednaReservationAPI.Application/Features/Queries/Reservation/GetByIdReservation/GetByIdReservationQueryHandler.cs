using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SednaReservationAPI.Application.Features.Queries.Reservation.GetByIdReservation
{
    public class GetByIdReservationQueryHandler : IRequestHandler<GetByIdReservationQueryRequest, GetByIdReservationQueryResponse>
    {
        public Task<GetByIdReservationQueryResponse> Handle(GetByIdReservationQueryRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
