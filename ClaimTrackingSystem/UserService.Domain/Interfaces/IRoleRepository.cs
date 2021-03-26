using ClaimTrackingSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ClaimTrackingSystem.Domain.Interfaces
{
    public interface IRoleRepository
    {
        Task<IEnumerable<UserRole>> GetAllRoles();
    }
}
