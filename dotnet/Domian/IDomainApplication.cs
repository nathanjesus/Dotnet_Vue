using DataCore.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domian
{
    public interface IDomainApplication
    {
        #region Knights
        IEnumerable<Knight> GetAllKnights();
        IEnumerable<Knight> GetKnightsFindId(int id);
        void AddKnight(Knight knight);
        void UpdadeKnight(Knight knight);
        bool DeleteKnight(Knight knight);
        #endregion
        #region Hall
        IEnumerable<Hall> GetAllHall();

        #endregion
    }
}
