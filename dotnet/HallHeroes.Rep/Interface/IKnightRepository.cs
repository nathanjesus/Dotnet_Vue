using DataCore.Models;
using HallHeroes.Repository.Generic;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Interface
{
    public interface IKnightRepository : IGenericRepository<Knight>
    {
        IEnumerable<Knight> GetAll();
        IEnumerable<Knight> GetFindId(int id);
        bool DeleteKnight(Knight knight);
    }
}
