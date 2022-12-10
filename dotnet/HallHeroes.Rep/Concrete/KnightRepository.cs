using DataCore.Models;
using HallHeroes.Repository.Generic;
using Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace HallHeroes.Repository.Concrete
{
    public class KnightRepository : GenericRepository<Knight>, IKnightRepository
    {
        private readonly AppDbContext _context;
        public KnightRepository(AppDbContext entities): base(entities) =>_context = entities;

        public IEnumerable<Knight> GetAll() => _context.Knight.Where(k => k.IsAtivo.Value);

        public IEnumerable<Knight> GetFindId(int id) => _context.Knight.Where(k =>  k.KnightId == id &&k.IsAtivo.Value);

        public bool DeleteKnight(Knight knight)
        {
            try
            {
                knight.IsAtivo = false;
                _context.Knight.Update(knight);
                _context.Hall.Add(new Hall { KnightId = knight.KnightId });
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
