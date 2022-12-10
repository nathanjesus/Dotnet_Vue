using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HallHeroes.Repository.Generic
{
    public interface IGenericRepository<T> where T : class
    {
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
        Task<bool> SaveChangesAsync();
    }
}
