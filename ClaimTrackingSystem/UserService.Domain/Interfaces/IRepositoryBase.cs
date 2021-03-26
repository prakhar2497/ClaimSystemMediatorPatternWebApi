using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClaimTrackingSystem.Domain.Interfaces
{
    public interface IRepositoryBase<T>
    {
        IQueryable<T> FindAll();
        void Create(T entity);
    }
}
