using DataLayer;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public partial class SystemTableBusinessLayer : BaseBusinessLayer, ISystemTableBusinessLayer
    {
        public KeyValuePair<bool, string> Create(SystemTableDto systemTableDto)
        {
            KeyValuePair<bool, string> validationResult = GetCreateValidationResult(systemTableDto);
            if (validationResult.Key)
            {
                //mapper
                var systemTable = new SystemTable();
                var result = SystemTableRepository.Create(systemTable);
                return result;
            }
        }


        public KeyValuePair<bool, string> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IList<SystemTableDto> GetAll()
        {
            throw new NotImplementedException();
        }

        public SystemTableDto GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IList<SystemTableDto> GetByStats(string stats)
        {
            throw new NotImplementedException();
        }

        public KeyValuePair<bool, string> Update(SystemTableDto systemTableDto)
        {
            throw new NotImplementedException();
        }
    }
}
