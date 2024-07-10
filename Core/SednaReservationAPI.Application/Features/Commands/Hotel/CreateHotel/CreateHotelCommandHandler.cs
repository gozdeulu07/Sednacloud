using MediatR;
using SednaReservationAPI.Application.Repositories;

namespace SednaReservationAPI.Application.Features.Commands.Hotel.CreateHotel
{
    public class CreateHotelCommandHandler : IRequestHandler<CreateHotelCommandRequest, CreateHotelCommandResponse>
    {

        IHotelWriteRepository _repository;

        public CreateHotelCommandHandler(IHotelWriteRepository repository)
        {
            _repository = repository;
        }

        public async Task<CreateHotelCommandResponse> Handle(CreateHotelCommandRequest request, CancellationToken cancellationToken)
        {
            await _repository.AddAsync(new()
            {
                Name = request.Name,
                Address = request.Address,
                Phone = request.Phone,
                Email = request.Email,
                Description = request.Description,
                ImageUrl = request.ImageUrl,
                Star = request.Star,
           
            });

            await _repository.SaveAsync();

            return new();

        }
    }
}
