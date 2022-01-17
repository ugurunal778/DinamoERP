using DataLayer;
using DTO;
using System;
using System.Collections.Generic;
using AutoMapper;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public partial class InterruptsBusinessLayer : BaseBusinessLayer, IInterruptsBusinessLayer
    {
        public KeyValuePair<bool, string> Create(InterruptsDto interruptsDto)
        {
            KeyValuePair<bool, string> validationResult = GetCreateValidationResult(interruptsDto);
            if (validationResult.Key)
            {
                var interrupt = new Mapper(InterruptsDtoToInterruptsConfig).Map<Interrupt>(interruptsDto); ;
                var result = InterruptsRepository.Create(interrupt);
                return result;
            }
        }


        public KeyValuePair<bool, string> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IList<InterruptsDto> GetAll()
        {
            throw new NotImplementedException();
        }

        public InterruptsDto GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IList<InterruptsDto> GetByStats(string stats)
        {
            throw new NotImplementedException();
        }

        public KeyValuePair<bool, string> Update(InterruptsDto interruptsTableDto)
        {
            throw new NotImplementedException();
        }
    }
}
