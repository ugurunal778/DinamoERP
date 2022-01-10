using DataLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class ScheduleTablesRepository : BaseRepository, IScheduleTablesRepository
    {
        public KeyValuePair<bool, string> Create(ScheduleTable stats)
        {
            throw new NotImplementedException();
        }

        public KeyValuePair<bool, string> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IList<ScheduleTable> GetAll()
        {
            throw new NotImplementedException();
        }

        public ScheduleTable GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IList<ScheduleTable> GetByStats(string stats)
        {
            throw new NotImplementedException();
        }

        public KeyValuePair<bool, string> Update(ScheduleTable stats)
        {
            throw new NotImplementedException();
        }
    }
}
