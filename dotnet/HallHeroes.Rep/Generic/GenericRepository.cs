using DataCore.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace HallHeroes.Repository.Generic
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected AppDbContext _entities;
        protected readonly IDbSet<T> _dbset;
        public GenericRepository(AppDbContext entities)
        {
            _entities = entities;
            //_dbset = (IDbSet<T>)_entities.Set<T>();
        }

        public void Add(T entity) => _entities.Add(entity);
        public void Delete(T entity) => _entities.Remove(entity);
        public void Update(T entity) => _entities.Entry(entity).State = (Microsoft.EntityFrameworkCore.EntityState)EntityState.Modified;
        public async Task<bool> SaveChangesAsync() => (await _entities.SaveChangesAsync() > 0);
    }
}
