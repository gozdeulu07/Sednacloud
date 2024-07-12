using MediatR;
using SednaReservationAPI.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SednaReservationAPI.Application.Features.Commands.Hotel.CreateHotel
{
    public class CreateHotelCommandHandler : IRequestHandler<CreateHotelCommandRequest, CreateHotelCommandResponse>
    {
        readonly IHotelWriteRepository _hotelWriteRepository;

        public CreateHotelCommandHandler(IHotelWriteRepository hotelWriteRepository)
        {
            _hotelWriteRepository = hotelWriteRepository;
        }

        public async Task<CreateHotelCommandResponse> Handle(CreateHotelCommandRequest request, CancellationToken cancellationToken)
        {
            await _hotelWriteRepository.AddAsync(new()
            {
                Name = request.Name,
                Address = request.Address,
                Phone = request.Phone,
                Email = request.Email,
                Description = request.Description,
                StarRating = request.StarRating,
                Star = request.Star,
                ImageUrl = request.ImageUrl

            });

            await _hotelWriteRepository.SaveAsync();

            return new();

        }
    }
}
