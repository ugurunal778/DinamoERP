using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Interfaces
{
    public interface ISystemTableRepository
    {
        SystemTable GetById(int id);
        IList<SystemTable> GetAll();
        IList<SystemTable> GetByStats(string stats);
        KeyValuePair<bool, string> Create(SystemTable stats);
        KeyValuePair<bool, string> Update(SystemTable stats);
        KeyValuePair<bool, string> Delete(int id);
    }
}
