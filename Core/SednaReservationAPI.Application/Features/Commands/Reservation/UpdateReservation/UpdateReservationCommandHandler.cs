﻿using MediatR;
using SednaReservationAPI.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SednaReservationAPI.Application.Features.Commands.Reservation.UpdateReservation
{
    public class UpdateReservationCommandHandler : IRequestHandler<UpdateReservationCommandRequest, UpdateReservationCommandResponse>
    {
        readonly IReservationReadRepository _reservationReadRepository;
        readonly IReservationWriteRepository _reservationWriteRepository;

        public UpdateReservationCommandHandler(IReservationReadRepository reservationReadRepository, IReservationWriteRepository reservationWriteRepository)
        {
            _reservationReadRepository = reservationReadRepository;
            _reservationWriteRepository = reservationWriteRepository;
        }
        public async Task<UpdateReservationCommandResponse> Handle(UpdateReservationCommandRequest request, CancellationToken cancellationToken)
        {
            Domain.Entities.Reservation reservation = await _reservationReadRepository.GetByIdAsync(request.Id);

            reservation.UserId = request.UserId;
            reservation.RoomId = request.RoomId;
            reservation.HotelId = request.HotelId;
            reservation.CheckIn = request.CheckIn;
            reservation.CheckOut = request.CheckOut;
            reservation.TotalPrice = request.TotalPrice;
            reservation.Status = request.Status;

            await _reservationWriteRepository.SaveAsync();
            return new();
        }
    }
}
