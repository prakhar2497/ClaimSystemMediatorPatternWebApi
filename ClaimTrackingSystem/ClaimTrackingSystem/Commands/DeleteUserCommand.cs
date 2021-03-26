using ClaimTrackingSystem.Application.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClaimTrackingSystem.Commands
{
    public class DeleteUserCommand : IRequest<List<UserDTO>>
    {
        public Guid userId { get; set; }
        public DeleteUserCommand(Guid userId)
        {
            this.userId = userId;
        }
    }
}
