using MediatR;
using Microsoft.EntityFrameworkCore;
using SednaReservationAPI.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SednaReservationAPI.Application.Features.Queries.Hotel.GetAllHotel
{
    public class GetAllHotelQueryHandler : IRequestHandler<GetAllHotelQueryRequest, GetAllHotelQueryResponse>
    {
        readonly IHotelReadRepository _hotelReadRepository;

        public GetAllHotelQueryHandler(IHotelReadRepository hotelReadRepository)
        {
            _hotelReadRepository = hotelReadRepository;
        }

        public async Task<GetAllHotelQueryResponse> Handle(GetAllHotelQueryRequest request, CancellationToken cancellationToken)
        {
            var totalCount = _hotelReadRepository.GetAll(false).Count();
            var hotels = _hotelReadRepository.GetAll(false).Skip(request.Page * request.Size).Take(request.Size)
                .Select(hotel => new
                {
                    hotel.Id,
                    hotel.Name,
                    hotel.Address,
                    hotel.Phone,
                    hotel.Email,
                    hotel.Description,
                    hotel.StarRating,
                    hotel.Star,
                    hotel.ImageUrl

                }).ToList();

            return new()
            {
                TotalCount = totalCount,
                Hotels = hotels
            };
        }
    }
}
