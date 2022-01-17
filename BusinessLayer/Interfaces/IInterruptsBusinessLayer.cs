using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public interface IInterruptsBusinessLayer
    {
        KeyValuePair<bool, string> Create(InterruptsDto interruptsDto);
        KeyValuePair<bool, string> Update(InterruptsDto interruptsDto);
        KeyValuePair<bool, string> Delete(int id);
        IList<InterruptsDto> GetByStats(string stats);
        IList<InterruptsDto> GetAll();
        InterruptsDto GetById(int id);
    }
}
