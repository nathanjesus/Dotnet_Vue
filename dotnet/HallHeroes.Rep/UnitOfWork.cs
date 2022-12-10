using DataCore;
using DataCore.Models;
using HallHeroes.Repository.Concrete;
using Repository.Interface;
using System;

 

namespace HallHeroes.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private AppDbContext _entities = null;
        private IKnightRepository _KnightRepository = null;
        private IHallRepository _HallRepository = null;
        public UnitOfWork()
        {
            _entities = new AppDbContext();
        }
        


        public IKnightRepository KnightRepository
        {
            get
            {
                if (_KnightRepository == null)
                {
                    _KnightRepository = new KnightRepository(_entities);
                }
                return _KnightRepository;
            }
        }

        public IHallRepository HallRepository
        {
            get
            {
                if (_HallRepository == null)
                {
                    _HallRepository = new HallRepository(_entities);
                }
                return _HallRepository;
            }
        }
        public void Dispose()
        {
            //Dispose(true);
            GC.SuppressFinalize(this);
        }
        private void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (_entities != null)
                {
                    _entities.Dispose();
                    _entities = null;
                }
            }
        }
    }
}
