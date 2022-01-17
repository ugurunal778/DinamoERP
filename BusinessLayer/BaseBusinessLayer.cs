using DataLayer.DataClass;
using DataLayer.Interfaces;
using AutoMapper;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace BusinessLayer
{
    public class BaseBusinessLayer
    {
        public MapperConfiguration InterruptsToInterruptsDtoConfig
        {
            get
            {
                var Config = new MapperConfiguration(cfg => cfg.CreateMap<Interrupt, InterruptsDto>());
                return Config;
            }
        }
        public MapperConfiguration InterruptsDtoToInterruptsConfig
        {
            get
            {
                var Config = new MapperConfiguration(cfg => cfg.CreateMap<InterruptsDto, Interrupt>());
                return Config;
            }
        }
        private IInterruptsRepository _interruptsRepository;
        public IInterruptsRepository InterruptsRepository
        {
            get
            {
                if (_interruptsRepository is null)
                    _interruptsRepository = new InterruptsRepository();
                return _interruptsRepository;
            }
        }
    }
}
