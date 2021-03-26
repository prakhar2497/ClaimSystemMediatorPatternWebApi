using ClaimTrackingSystem.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace ClaimTrackingSystem.Data.Repositories
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        public ApplicationDBContext _context { get; set; }

        public RepositoryBase(ApplicationDBContext context)
        {
            this._context = context;
        }

        public IQueryable<T> FindAll()
        {
            return this._context.Set<T>().AsNoTracking();
        }
        void IRepositoryBase<T>.Create(T entity)
        {
            _context.Add(entity);
        }
    }
}
