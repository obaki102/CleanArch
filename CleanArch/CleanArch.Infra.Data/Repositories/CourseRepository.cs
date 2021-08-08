using CleanArch.Domain.Entities;
using CleanArch.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanArch.Domain.Interfaces;
using CleanArch.Infra.Data.Context;

namespace CleanArch.Infra.Data.Repositores
{

    public class CourseRepository : ICourseRepository
    {
        private readonly UniversityDBContext _universityDBContext;

        public CourseRepository(UniversityDBContext universityDBContext)
        {
            _universityDBContext = universityDBContext;
        }
        public IQueryable<Course> GetCourses()
        {
            return _universityDBContext.Courses;
        }

        public Task<bool> AddCourse(Course course)
        {
            _universityDBContext.Add(course);

            var created = _universityDBContext.SaveChanges();

            return Task.FromResult(created > 0);
        }
    }
}
