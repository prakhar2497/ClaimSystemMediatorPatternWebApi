using AutoMapper;
using ClaimTrackingSystem.Application.DTOs;
using ClaimTrackingSystem.Commands;
using ClaimTrackingSystem.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace ClaimTrackingSystem.AutoMapperProfiles
{
    public class UserMapping : Profile
    {
        public UserMapping()
        {
            CreateMap<User, UserDTO>().ReverseMap();
            CreateMap<UserDTO, User>();
            CreateMap<UpdateUserDTO, User>();
            CreateMap<UserRole, RoleDTO>();
            CreateMap<RoleDTO, UserRole>();
            CreateMap<CreateNewUserCommand, User>();
            CreateMap<UpdateUserCommand, User>();
        }
    }
}
