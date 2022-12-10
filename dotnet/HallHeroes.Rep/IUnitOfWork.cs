using Repository.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace HallHeroes.Repository
{
    public interface IUnitOfWork : IDisposable
    {
        IKnightRepository KnightRepository { get; }
        IHallRepository HallRepository { get; }

    }
}
