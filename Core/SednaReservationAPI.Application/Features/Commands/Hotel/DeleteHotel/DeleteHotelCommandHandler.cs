using MediatR;
using SednaReservationAPI.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SednaReservationAPI.Application.Features.Commands.Hotel.DeleteHotel
{
    public class DeleteHotelCommandHandler : IRequestHandler<DeleteHotelCommandRequest, DeleteHotelCommandResponse>
    {


        IHotelWriteRepository _repository;

        public DeleteHotelCommandHandler(IHotelWriteRepository repository)
        {
            _repository = repository;
        }


        public async Task<DeleteHotelCommandResponse> Handle(DeleteHotelCommandRequest request, CancellationToken cancellationToken)
        {
            await _repository.RemoveAsync(request.Id);
            await _repository.SaveAsync();

            return new DeleteHotelCommandResponse();

        }
    }
}
