using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Application.Automapper
{
    public class AutomapperConfiguration
    {
        public static MapperConfiguration RegisterMappings()
        {
            return new MapperConfiguration(cfg =>
           {
               cfg.AddProfile(new ViewModelToDomainProfile());
               cfg.AddProfile(new DomainToViewModel())
;
           });
        }
    }
}
