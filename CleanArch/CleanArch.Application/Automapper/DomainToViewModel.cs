using AutoMapper;
using CleanArch.Application.ViewModels;
using CleanArch.Domain.Commands;
using CleanArch.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Application.Automapper
{
    public class DomainToViewModel : Profile
    {

        public DomainToViewModel()
        {
            CreateMap<Course, CourseViewModel>();
        }
    }
}
