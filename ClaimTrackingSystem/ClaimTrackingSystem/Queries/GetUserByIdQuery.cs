using ClaimTrackingSystem.Application.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClaimTrackingSystem.Queries
{
    public class GetUserByIdQuery : IRequest<UserDTO>
    {
        public Guid UserId { get; set; }
        public GetUserByIdQuery(Guid UserId)
        {
            this.UserId = UserId;
        }
    }
}
