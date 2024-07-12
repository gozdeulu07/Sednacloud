using MediatR;
using SednaReservationAPI.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SednaReservationAPI.Application.Features.Commands.Hotel.UpdateHotel
{
    public class UpdateHotelCommandHandler : IRequestHandler<UpdateHotelCommandRequest, UpdateHotelCommandResponse>
    {
        readonly IHotelReadRepository _hotelReadRepository;
        readonly IHotelWriteRepository _hotelWriteRepository;

        public UpdateHotelCommandHandler(IHotelReadRepository hotelReadRepository, IHotelWriteRepository hotelWriteRepository)
        {
            _hotelReadRepository = hotelReadRepository;
            _hotelWriteRepository = hotelWriteRepository;
        }

        public async Task<UpdateHotelCommandResponse> Handle(UpdateHotelCommandRequest request, CancellationToken cancellationToken)
        {
            Domain.Entities.Hotel hotel = await _hotelReadRepository.GetByIdAsync(request.Id);

            hotel.Name = request.Name;
            hotel.Address = request.Address;
            hotel.Phone = request.Phone;
            hotel.StarRating = request.StarRating;
            hotel.Star = request.Star;
            hotel.Email = request.Email;
            hotel.ImageUrl = request.ImageUrl;
            hotel.UpdatedDate = DateTime.UtcNow;

            await _hotelWriteRepository.SaveAsync();
            return new UpdateHotelCommandResponse();
        }
    }
}
