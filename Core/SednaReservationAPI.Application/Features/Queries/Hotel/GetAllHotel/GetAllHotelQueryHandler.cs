using MediatR;
using Microsoft.EntityFrameworkCore;
using SednaReservationAPI.Application.Repositories;
using SednaReservationAPI.Domain.Entities;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace SednaReservationAPI.Application.Features.Queries.Hotel.GetAllHotel
{
    public class GetAllHotelQueryHandler : IRequestHandler<GetAllHotelQueryRequest, GetAllHotelQueryResponse>
    {
        private readonly IHotelReadRepository _hotelReadRepository;

        public GetAllHotelQueryHandler(IHotelReadRepository hotelReadRepository)
        {
            _hotelReadRepository = hotelReadRepository;
        }

        public async Task<GetAllHotelQueryResponse> Handle(GetAllHotelQueryRequest request, CancellationToken cancellationToken)
        {
            //var totalCount = await _hotelReadRepository.GetAll(false).CountAsync(cancellationToken);

            //var query = _hotelReadRepository.GetAll(false);

            //if (!string.IsNullOrEmpty(request.SortBy))
            //{
            //    if (request.IsAscending)
            //    {
            //        query = query.OrderBy(h => EF.Property<object>(h, request.SortBy));
            //    }
            //    else
            //    {
            //        query = query.OrderByDescending(h => EF.Property<object>(h, request.SortBy));
            //    }
            //}
            //var hotels = await query
            //    .Skip(request.Page * request.Size)
            //    .Take(request.Size)
            //    .ToListAsync(cancellationToken);

            //return new GetAllHotelQueryResponse
            //{
            //    TotalCount = totalCount,
            //    Hotels = hotels
            //};
            var totalCount = _hotelReadRepository.GetAll(false).Count();
            var query = _hotelReadRepository.GetAll(false);
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

            if (!string.IsNullOrEmpty(request.SortBy))
            {
                if (request.IsAscending)
                {
                    query = query.OrderBy(h => EF.Property<object>(h, request.SortBy));
                }
                else
                {
                    query = query.OrderByDescending(h => EF.Property<object>(h, request.SortBy));
                }
                var filteredHotels = await query
                .Skip(request.Page * request.Size)
                .Take(request.Size)
                .ToListAsync(cancellationToken);
                return new()
                {
                    TotalCount = totalCount,
                    FiltredHotels = filteredHotels
                };
            }
            else
            {
                return new()
                {
                    TotalCount = totalCount,
                    Hotels = hotels,
                };
            }
        }
    }
}
