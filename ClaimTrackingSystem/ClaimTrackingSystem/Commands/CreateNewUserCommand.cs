using ClaimTrackingSystem.Application.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClaimTrackingSystem.Commands
{
    public class CreateNewUserCommand : IRequest<UserDTO>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public Guid Role { get; set; }
        public int Age { get; set; }
    }
}
