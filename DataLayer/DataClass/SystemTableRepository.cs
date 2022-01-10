using DataLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.DataClass
{
    public class SystemTableRepository : BaseRepository, ISystemTableRepository
    {
        public KeyValuePair<bool, string> Delete(int id)
        {
            var result = new KeyValuePair<bool, string>(true, "işlem başarılı");
            try
            {
                var table = DinamoERPModel.SystemTables.FirstOrDefault(x => x.Id == id);
                if (table == null)
                {
                    result = new KeyValuePair<bool, string>(false, "Kayıt bulunamadı");
                }
                else
                {
                    DinamoERPModel.SystemTables.Remove(table);
                    DinamoERPModel.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                result = new KeyValuePair<bool, string>(false, ex.Message);
            }
            return result;
        }
        public SystemTable GetById(int id)
        {
            var table = DinamoERPModel.SystemTables.FirstOrDefault(x => x.Id == id);
            return table;
        }
        public IList<SystemTable> GetAll()
        {
            var table = DinamoERPModel.SystemTables.ToList();
            return table;
        }
        public IList<SystemTable> GetByStats(string stats)
        {
            var table = DinamoERPModel.SystemTables.Where(x => x.Stats.Contains(stats)).ToList();
            return table;
        }
        public KeyValuePair<bool, string> Create(SystemTable stats)
        {
            var result = new KeyValuePair<bool, string>(true, "İşlem Başarılı");
            try
            {
                DinamoERPModel.SystemTables.Add(stats);
                DinamoERPModel.SaveChanges();
            }
            catch (Exception ex)
            {
                result = new KeyValuePair<bool, string>(false, ex.Message);
            }
            return result;
        }
        public KeyValuePair<bool, string> Update(SystemTable stats)
        {
            var result = new KeyValuePair<bool, string>(true, "İşlem Başarılı");
            try
            {
                DinamoERPModel.SaveChanges();
            }
            catch (Exception ex)
            {
                result = new KeyValuePair<bool, string>(false, ex.Message);
            }
            return result;
        }
    }
}
