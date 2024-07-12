using MediatR;
using Microsoft.AspNetCore.Identity;
using SednaReservationAPI.Application.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SednaReservationAPI.Application.Features.Commands.AppUser.CreateAppUser
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommandRequest, CreateUserCommandResponse>
    {
        private readonly UserManager<Domain.Entities.Identity.AppUser> _userManager;

        public CreateUserCommandHandler(UserManager<Domain.Entities.Identity.AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<CreateUserCommandResponse> Handle(CreateUserCommandRequest request, CancellationToken cancellationToken)
        {
            IdentityResult result = await _userManager.CreateAsync(new()
            {
                Id = Guid.NewGuid().ToString(),
                UserName = request.UserName,
                Name = request.Name,
                Email = request.Email,
                PhoneNumber = request.Phone,
                Age = request.Age,
                Gender = request.Gender
            }, request.Password);
            CreateUserCommandResponse response = new() { Success = result.Succeeded};

            if (result.Succeeded)
                response.Message = "User Created Successfully!";
            else
                foreach (var error in result.Errors)
                    response.Message += $"{error.Code} - {error.Description}\n";
            
            return response;
            //throw new UserCreateFailedException();
        }
    }
}
