using SednaReservationAPI.Domain.Entities;
using SednaReservationAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SednaReservationAPI.Application.Features.Queries.Hotel.GetAllHotel
{
    public class GetAllHotelQueryResponse
    {
        public int TotalCount { get; set; }
        //public List<SednaReservationAPI.Domain.Entities.Hotel>? Hotels { get; set; }
        public object? FiltredHotels { get; set; }
        public object? Hotels { get; set; }
    }
}

