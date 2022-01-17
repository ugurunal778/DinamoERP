using DataLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.DataClass
{
    public class InterruptsRepository : BaseRepository, IInterruptsRepository
    {
        public KeyValuePair<bool, string> Delete(int id)
        {
            var result = new KeyValuePair<bool, string>(true, "işlem başarılı");
            try
            {
                var table = DinamoERPModel.Interrupts.FirstOrDefault(x => x.Id == id);
                if (table == null)
                {
                    result = new KeyValuePair<bool, string>(false, "Kayıt bulunamadı");
                }
                else
                {
                    DinamoERPModel.Interrupts.Remove(table);
                    DinamoERPModel.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                result = new KeyValuePair<bool, string>(false, ex.Message);
            }
            return result;
        }
        public Interrupt GetById(int id)
        {
            var table = DinamoERPModel.Interrupts.FirstOrDefault(x => x.Id == id);
            return table;
        }
        public IList<Interrupt> GetAll()
        {
            var table = DinamoERPModel.Interrupts.ToList();
            return table;
        }
        public IList<Interrupt> GetByStats(string stats)
        {
            var table = DinamoERPModel.Interrupts.Where(x => x.Stats.Contains(stats)).ToList();
            return table;
        }
        public KeyValuePair<bool, string> Create(Interrupt stats)
        {
            var result = new KeyValuePair<bool, string>(true, "İşlem Başarılı");
            try
            {
                DinamoERPModel.Interrupts.Add(stats);
                DinamoERPModel.SaveChanges();
            }
            catch (Exception ex)
            {
                result = new KeyValuePair<bool, string>(false, ex.Message);
            }
            return result;
        }
        public KeyValuePair<bool, string> Update(Interrupt stats)
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
