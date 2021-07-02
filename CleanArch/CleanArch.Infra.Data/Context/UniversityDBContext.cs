using CleanArch.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Infra.Data.Context
{
    public class UniversityDBContext : DbContext
    {
        public UniversityDBContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Course> Courses { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            // seed Course table
            builder.Entity<Course>().HasData(
                new Course
                {
                    Id = 1,
                    Name = "Physics",
                    Description = "Introductory to Physics",
                    ImageUrl = "images/circle.jpg"

                },

                new Course
                {
                    Id = 2,
                    Name = "Chemistry",
                    Description = "Introductory to Chemistry",
                    ImageUrl = "images/crystal.jpg"
                },

                new Course
                {
                    Id = 3,
                    Name = "Mathematics",
                    Description = "Introductory to Mathematics",
                    ImageUrl = "images/paper.jpg"
                }

                );


        }
    }
}
