using ConnectifyHub.Domain.Entities.Concrete;
using MediatR;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectifyHub.Application.Features.Commands.UserCommands
{
    public class UserCreateCommand : IRequest<UserDTO>
    {
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public string ProfilePhotoUrl { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public bool TwoFactorEnabled { get; set; }
    }

    public class UserDTO
    {
        public string Id { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName  { get; set; }
        public string Email  { get; set; }
    }

    public class UserCreateCommandHandler : IRequestHandler<UserCreateCommand, UserDTO>
    {
        private readonly UserManager<User> _userManager;

        public UserCreateCommandHandler(UserManager<User> userManager)
        {
            _userManager = userManager;
        }

        public async Task<UserDTO> Handle(UserCreateCommand request, CancellationToken cancellationToken)
        {
            var user = new User()
            {
                FirstName = request.FirstName,
                LastName = request.LastName,
                Email = request.Email,
                BirthDate = request.BirthDate,
                ProfilePhotoUrl = request.ProfilePhotoUrl,
                UserName = request.UserName,
                PhoneNumber = request.PhoneNumber,
                TwoFactorEnabled = request.TwoFactorEnabled,
            };

            var result = await _userManager.CreateAsync(user, request.Password);

            if (result.Succeeded)
            {
                await _userManager.AddToRoleAsync(user, "Member");
                return new UserDTO()
                {
                    Id = user.Id,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Email = user.Email,
                    UserName = user.UserName,
                };
            }
            else
            {
                throw new Exception("User Eklenirken Hata Olustu !");
            }
        }
    }
}
