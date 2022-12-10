using DataCore.Models;
using HallHeroes.Repository.Generic;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Interface
{
    public interface IHallRepository : IGenericRepository<Hall>
    {
        IEnumerable<Hall> GetAll();
    }
}
