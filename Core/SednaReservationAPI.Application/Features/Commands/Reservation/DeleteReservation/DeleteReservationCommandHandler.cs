using MediatR;
using SednaReservationAPI.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SednaReservationAPI.Application.Features.Commands.Reservation.DeleteReservation
{
    public class DeleteReservationCommandHandler : IRequestHandler<DeleteReservationCommandRequest, DeleteReservationCommandResponse>
    {
        readonly IReservationWriteRepository _reservationWriteRepository;

        public DeleteReservationCommandHandler(IReservationWriteRepository reservationWriteRepository)
        {
            _reservationWriteRepository = reservationWriteRepository;
        }

        public async Task<DeleteReservationCommandResponse> Handle(DeleteReservationCommandRequest request, CancellationToken cancellationToken)
        {
            await _reservationWriteRepository.RemoveAsync(request.Id);
            await _reservationWriteRepository.SaveAsync();
            return new();
        }
    }
}
