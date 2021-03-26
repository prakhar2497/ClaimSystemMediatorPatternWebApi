using AutoMapper;
using ClaimTrackingSystem.Data.Repositories;
using ClaimTrackingSystem.Domain.Entities;
using ClaimTrackingSystem.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClaimTrackingSystem.Data.Repository
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public ApplicationDBContext Context { get; set; }
        private IMapper Mapper { get; set; }
        public UserRepository(ApplicationDBContext _context, IMapper _mapper) : base(_context)
        {
            this.Context = _context;
            this.Mapper = _mapper;
        }

        public void CreateNewUser(User user)
        {
            Context.Add(user);
            Context.SaveChanges();
        }

        public async Task<IEnumerable<User>> GetAllUsers()
        {
            return await FindAll().ToListAsync();
        }
        public async Task<IEnumerable<User>> GetUsersWithRole()
        {
            var userDetails = await Context.User.AsNoTracking().Include(c => c.UserRole).ToListAsync();
            return userDetails;
        }
        public async Task<User> GetUserById(Guid Id)
        {
            return await Context.User.AsNoTracking().Include(c => c.UserRole).FirstOrDefaultAsync(c => c.ID == Id);

        }
        public void UpdateUser(User updatedDetails)
        {
            Context.Update(updatedDetails);
            Context.SaveChanges();
            
        }
        public void RemoveUser(Guid userID)
        {
            var userToBeDeleted = Context.User.AsNoTracking().Include(c => c.UserRole).FirstOrDefault(c => c.ID == userID);
            Context.User.Remove(userToBeDeleted);
            Context.SaveChanges();
        }
    }
}
