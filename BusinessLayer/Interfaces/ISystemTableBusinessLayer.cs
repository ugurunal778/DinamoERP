using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public interface ISystemTableBusinessLayer
    {
        KeyValuePair<bool, string> Create(SystemTableDto systemTableDto);
        KeyValuePair<bool, string> Update(SystemTableDto systemTableDto);
        KeyValuePair<bool, string> Delete(int id);
        IList<SystemTableDto> GetByStats(string stats);
        IList<SystemTableDto> GetAll();
        SystemTableDto GetById(int id);
    }
}
