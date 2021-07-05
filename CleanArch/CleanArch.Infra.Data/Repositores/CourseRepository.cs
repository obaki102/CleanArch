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
        public IEnumerable<Course> GetCourses()
        {
            return _universityDBContext.Courses;
        }

        public async Task<bool> AddCourseAsync(Course course)
        {
            await _universityDBContext.AddAsync(course);

            var created = await _universityDBContext.SaveChangesAsync();

            return created > 0;

        }
    }
}
