using AutoMapper;
using ClaimTrackingSystem.Application.DTOs;
using ClaimTrackingSystem.Commands;
using ClaimTrackingSystem.Domain.Entities;
using ClaimTrackingSystem.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ClaimTrackingSystem.Handlers.CommandHandlers
{
    public class CreateNewUserCommandHandler : IRequestHandler<CreateNewUserCommand, UserDTO>
    {
        public IUserRepository userRepository { get; set; }
        private readonly IMapper mapper;
        public CreateNewUserCommandHandler(IUserRepository _userRepository, IMapper _mapper)
        {
            this.userRepository = _userRepository;
            this.mapper = _mapper;
        }
        public async Task<UserDTO> Handle(CreateNewUserCommand request, CancellationToken cancellationToken)
        {
            var userEntity = mapper.Map<User>(request);
            userRepository.CreateNewUser(userEntity);
            return mapper.Map<UserDTO>(userEntity);
        }
    }
}
