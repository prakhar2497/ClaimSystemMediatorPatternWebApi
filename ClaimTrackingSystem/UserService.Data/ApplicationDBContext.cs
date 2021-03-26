using ClaimTrackingSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace ClaimTrackingSystem.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
        }
        public DbSet<User> User { get; set; }
        public DbSet<UserRole> UserRole { get; set; }

        internal object Find(Func<object, bool> p)
        {
            throw new NotImplementedException();
        }
    }
}
