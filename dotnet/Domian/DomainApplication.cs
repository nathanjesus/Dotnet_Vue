using DataCore.Models;
using HallHeroes.Repository;
using Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domian
{
    public class DomainApplication : IDomainApplication
    {
        private readonly IUnitOfWork _unitOfWork;
        public DomainApplication(IUnitOfWork unitOfWork) => _unitOfWork = unitOfWork;

        #region Knights
        public void AddKnight(Knight knight) => _unitOfWork.KnightRepository.Add(knight);
        public bool DeleteKnight(Knight knight) => _unitOfWork.KnightRepository.DeleteKnight(knight);
        public IEnumerable<Knight> GetAllKnights() => _unitOfWork.KnightRepository.GetAll();
        public IEnumerable<Knight> GetKnightsFindId(int id) => _unitOfWork.KnightRepository.GetFindId(id);
        public void UpdadeKnight(Knight knight) => _unitOfWork.KnightRepository.Update(knight);
        #endregion
        #region Hall
        public IEnumerable<Hall> GetAllHall() => _unitOfWork.HallRepository.GetAll();
        #endregion
    }
}
