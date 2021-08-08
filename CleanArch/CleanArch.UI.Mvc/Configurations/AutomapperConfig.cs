using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CleanArch.Application.Automapper;

namespace CleanArch.Mvc.Configurations
{
    public static class AutomapperConfig
    {
        public static void RegisterAutomapper(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(CleanArch.Application.Automapper.AutomapperConfiguration));
            AutomapperConfiguration.RegisterMappings();
        }
    }
}
