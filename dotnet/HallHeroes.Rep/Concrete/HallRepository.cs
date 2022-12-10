using DataCore.Models;
using HallHeroes.Repository.Generic;
using Repository.Interface;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace HallHeroes.Repository.Concrete
{
    public class HallRepository : GenericRepository<Hall>, IHallRepository
    {
        private readonly AppDbContext _context;
        public HallRepository(AppDbContext entities): base(entities) =>_context = entities;

        public IEnumerable<Hall> GetAll() => _context.Hall.Include(Knight => Knight.Knight).ToList();


    }
}
