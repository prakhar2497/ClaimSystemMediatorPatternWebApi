using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using UserService.Application.DTOs;

namespace UserService.Handlers.Queries
{
    public class GetAllUserQuery : IRequest<List<UserDTO>>
    {
        public GetAllUserQuery()
        {

        }
    }
}
