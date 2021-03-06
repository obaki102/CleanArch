using CleanArch.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Domain.Interfaces
{
    public interface ICourseRepository
    {
        IQueryable<Course> GetCourses();
        Task<bool> AddCourse(Course course);

    }
}
