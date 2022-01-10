using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public interface IScheduleTablesRepository
    {
        ScheduleTable GetById(int id);
        IList<ScheduleTable> GetAll();
        IList<ScheduleTable> GetByStats(string stats);
        KeyValuePair<bool, string> Create(ScheduleTable stats);
        KeyValuePair<bool, string> Update(ScheduleTable stats);
        KeyValuePair<bool, string> Delete(int id);
    }
}
