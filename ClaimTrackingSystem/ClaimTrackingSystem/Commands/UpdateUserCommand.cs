using ClaimTrackingSystem.Application.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClaimTrackingSystem.Commands
{
    public class UpdateUserCommand : IRequest<UserDTO>
    {
        public Guid UserId { get; set; }
        public UserDTO UserEntity { get; set; }
        public UpdateUserCommand(Guid UserId, UserDTO UserEntity)
        {
            this.UserId = UserId;
            this.UserEntity = UserEntity;
        }
    }
}
