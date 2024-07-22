using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SednaReservationAPI.Application.Features.Queries.Hotel.GetAllHotel
{
    public class GetAllHotelQueryRequest : IRequest<GetAllHotelQueryResponse>
    {
        public int Page { get; set; } = 0;
        public int Size { get; set; } = 5;
        public string? SortBy { get; set; }
        public bool IsAscending { get; set; } = true;

    }
}
