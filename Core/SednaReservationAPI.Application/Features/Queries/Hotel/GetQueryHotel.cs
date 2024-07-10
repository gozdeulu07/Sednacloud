using MediatR;
using SednaReservationAPI.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SednaReservationAPI.Application.Features.Queries.Hotel
{

    public class GetAllHotelQueryHandler : IRequestHandler<GetAllHotelQueryRequest, List<GetAllHotelQueryResponse>>
    {

        readonly IHotelReadRepository _repository;

        public GetAllHotelQueryHandler(IHotelReadRepository repository)
        {
            _repository = repository;
        }

        public Task<List<GetAllHotelQueryResponse>> Handle(GetAllHotelQueryRequest request, CancellationToken cancellationToken)
        {
            var hotels = _repository.GetAll(false)
              .Select(h => new GetAllHotelQueryResponse
              {
                  Id = h.Id.ToString(),
                  Name = h.Name,
                  Address = h.Address,
                  Email = h.Email,
                  Phone = h.Phone,
                  Star = h.Star,
                  StarRating = h.StarRating,
                  ImageUrl = h.ImageUrl
              })
              .ToList();

            return Task.FromResult(hotels);
        }
    }

    public class GetAllHotelQueryRequest : IRequest<List<GetAllHotelQueryResponse>>
    {

    }


    public class GetAllHotelQueryResponse
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int Star { get; set; }
        public double StarRating { get; set; }
        public string ImageUrl { get; set; }

    }


    //tekil


    public class GetByIdHotelQueryHandler : IRequestHandler<GetByIdHotelQueryRequest, GetByIdHotelQueryResponse>
    {
        public readonly IHotelReadRepository _repository;

        public GetByIdHotelQueryHandler(IHotelReadRepository repository)
        {
            _repository = repository;
        }

        public async Task<GetByIdHotelQueryResponse> Handle(GetByIdHotelQueryRequest request, CancellationToken cancellationToken)
        {

            var hotel = await _repository.GetByIdAsync(request.id);


            var response = new GetByIdHotelQueryResponse
            {
                Id = hotel.Id.ToString(),
                Name = hotel.Name

            };

            return response;
        }
    }


    public class GetByIdHotelQueryRequest : IRequest<GetByIdHotelQueryResponse>
    {

        public string id { get; set; } = string.Empty;
    }

    public class GetByIdHotelQueryResponse
    {
        public string Id { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public int Star { get; set; }
        public double StarRating { get; set; }
        public string ImageUrl { get; set; } = string.Empty;
    }
}
