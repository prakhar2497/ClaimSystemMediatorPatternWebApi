using AutoMapper;
using ClaimTrackingSystem.Application.DTOs;
using ClaimTrackingSystem.Commands;
using ClaimTrackingSystem.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ClaimTrackingSystem.Handlers.CommandHandlers
{
    public class DeleteUserCommandHandler : IRequestHandler<DeleteUserCommand, List<UserDTO>>
    {
        public IUserRepository userRepository { get; set; }
        private readonly IMapper mapper;
        public DeleteUserCommandHandler(IUserRepository userRepository, IMapper mapper)
        {
            this.userRepository = userRepository;
            this.mapper = mapper;
        }
        public async Task<List<UserDTO>> Handle(DeleteUserCommand request, CancellationToken cancellationToken)
        {
            userRepository.RemoveUser(request.userId);
            var updatedList = await userRepository.GetUsersWithRole();
            var mappedResult = mapper.Map<List<UserDTO>>(updatedList);
            return mappedResult;
        }
    }
}
