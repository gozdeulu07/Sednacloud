using MediatR;
using SednaReservationAPI.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SednaReservationAPI.Application.Features.Queries.Hotel.GetAllHotel
{
    public class GetAllHotelQueryHandler : IRequestHandler<GetAllHotelQueryRequest, List<GetAllHotelQueryResponse>>
    {
        readonly IHotelReadRepository _hotelReadRepository;

        public GetAllHotelQueryHandler(IHotelReadRepository hotelReadRepository)
        {
            _hotelReadRepository = hotelReadRepository;
        }

        public Task<List<GetAllHotelQueryResponse>> Handle(GetAllHotelQueryRequest request, CancellationToken cancellationToken)
        {
            var hotels = _hotelReadRepository.GetAll(false)
              .Select(hotel => new GetAllHotelQueryResponse
              {
                  Id = hotel.Id.ToString(),
                  Name = hotel.Name,
                  Address = hotel.Address,
                  Phone = hotel.Phone,
                  Email = hotel.Email,
                  Description = hotel.Description,
                  StarRating = hotel.StarRating,
                  Star = hotel.Star,
                  ImageUrl = hotel.ImageUrl
              })
              .ToList();

            return Task.FromResult(hotels);
        }
    }
}
