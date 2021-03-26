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
    public class UpdateUserCommandHandler : IRequestHandler<UpdateUserCommand, UserDTO>
    {
        public IUserRepository userRepository { get; set; }
        private readonly IMapper mapper;
        public UpdateUserCommandHandler(IUserRepository _userRepository, IMapper _mapper)
        {
            this.userRepository = _userRepository;
            this.mapper = _mapper;
        }
        public async Task<UserDTO> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
        {
            var userEntity = await userRepository.GetUserById(request.UserId);
            mapper.Map(request.UserEntity, userEntity);
            userEntity.ID = request.UserId;
            userRepository.UpdateUser(userEntity);
            var finalChanges = await userRepository.GetUserById(request.UserId);
            return mapper.Map<UserDTO>(finalChanges);

        }
    }
}
