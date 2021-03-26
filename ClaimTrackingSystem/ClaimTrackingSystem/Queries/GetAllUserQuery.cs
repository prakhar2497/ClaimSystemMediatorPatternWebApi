using ClaimTrackingSystem.Application.DTOs;
using MediatR;
using System.Collections.Generic;

namespace ClaimTrackingSystem.Queries
{
    public class GetAllUserQuery : IRequest<List<UserDTO>>
    {
        public GetAllUserQuery()
        {

        }
    }
}
