using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SednaReservationAPI.Application.Features.Commands.AppUser.DeleteAppUser
{
    public class DeleteAppUserCommandHandler : IRequestHandler<DeleteAppUserCommandRequest, DeleteAppUserCommandResponse>
    {
        public Task<DeleteAppUserCommandResponse> Handle(DeleteAppUserCommandRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
