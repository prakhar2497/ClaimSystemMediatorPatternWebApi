using AutoMapper;
using ClaimTrackingSystem.Application.DTOs;
using ClaimTrackingSystem.Domain.Interfaces;
using ClaimTrackingSystem.Queries;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ClaimTrackingSystem.Handlers.QueryHandlers
{
    public class GetUserByIdQueryHandler : IRequestHandler<GetUserByIdQuery, UserDTO>
    {
        public IUserRepository userRepository { get; set; }
        private readonly IMapper mapper;
        public GetUserByIdQueryHandler(IUserRepository _userRepository, IMapper _mapper)
        {
            this.userRepository = _userRepository;
            this.mapper = _mapper;
        }
        public async Task<UserDTO> Handle(GetUserByIdQuery request, CancellationToken cancellationToken)
        {
            var result = await userRepository.GetUserById(request.UserId);
            var mappedResult = mapper.Map<UserDTO>(result);
            return mappedResult;
        }
    }
}
