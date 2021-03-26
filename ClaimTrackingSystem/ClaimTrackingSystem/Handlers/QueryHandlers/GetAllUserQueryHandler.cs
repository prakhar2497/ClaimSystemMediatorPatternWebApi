using AutoMapper;
using ClaimTrackingSystem.Application.DTOs;
using ClaimTrackingSystem.Domain.Interfaces;
using ClaimTrackingSystem.Queries;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace ClaimTrackingSystem.QueryHandlers
{
    public class GetAllUserQueryHandler : IRequestHandler<GetAllUserQuery, List<UserDTO>>
    {
        public IUserRepository userRepository { get; set; }
        private readonly IMapper mapper;
        public GetAllUserQueryHandler(IUserRepository _userRepository, IMapper _mapper)
        {
            userRepository = _userRepository;
            this.mapper = _mapper;
        }
        public async Task<List<UserDTO>> Handle(GetAllUserQuery request, CancellationToken cancellationToken)
        {
            var result = await userRepository.GetUsersWithRole();
            var mappedResult = mapper.Map<List<UserDTO>>(result);
            return mappedResult;
        }
    }
}
