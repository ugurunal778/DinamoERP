using DataLayer.DataClass;
using DataLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class BaseBusinessLayer
    {
        private ISystemTableRepository _systemTableRepository;
        public ISystemTableRepository SystemTableRepository
        {
            get
            {
                if (_systemTableRepository is null)
                    _systemTableRepository = new SystemTableRepository();
                return _systemTableRepository;
            }
        }
    }
}
