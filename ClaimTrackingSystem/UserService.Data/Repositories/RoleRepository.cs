using ClaimTrackingSystem.Domain.Entities;
using ClaimTrackingSystem.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ClaimTrackingSystem.Data.Repositories
{
    public class RoleRepository : RepositoryBase<UserRole>, IRoleRepository
    {
        public ApplicationDBContext Context { get; set; }
        public RoleRepository(ApplicationDBContext _context) : base(_context)
        {
            this.Context = _context;
        }
        public async Task<IEnumerable<UserRole>> GetAllRoles()
        {
            return await FindAll().ToListAsync();
        }
    }
}
