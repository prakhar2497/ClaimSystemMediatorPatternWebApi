using ClaimTrackingSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ClaimTrackingSystem.Domain.Interfaces
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> GetAllUsers();
        void CreateNewUser(User user);
        Task<IEnumerable<User>> GetUsersWithRole();
        Task<User> GetUserById(Guid Id);
        void UpdateUser(User updatedDetails);
        void RemoveUser(Guid userId);
    }
}
