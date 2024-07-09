using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SednaReservationAPI.Application.Features.Queries.Hotel.GetByIdHotel
{
    public class GetByIdHotelQueryHandler : IRequestHandler<GetByIdHotelQueryRequest, GetByIdHotelQueryResponse>
    {
        public Task<GetByIdHotelQueryResponse> Handle(GetByIdHotelQueryRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
