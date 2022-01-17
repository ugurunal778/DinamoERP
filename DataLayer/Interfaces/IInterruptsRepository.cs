using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Interfaces
{
    public interface IInterruptsRepository
    {
        Interrupt GetById(int id);
        IList<Interrupt> GetAll();
        IList<Interrupt> GetByStats(string stats);
        KeyValuePair<bool, string> Create(Interrupt stats);
        KeyValuePair<bool, string> Update(Interrupt stats);
        KeyValuePair<bool, string> Delete(int id);
    }
}
