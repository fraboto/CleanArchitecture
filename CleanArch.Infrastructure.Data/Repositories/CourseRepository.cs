﻿using CleanArch.Domain.Interfaces;
using CleanArch.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Infrastructure.Data.Repositories
{
    public class CourseRepository : ICourseRepository
    {
        private UniversityDBContext _context;

        public CourseRepository(UniversityDBContext context)
        {
            _context = context;
        }

        public IEnumerable<Course> GetCourses()
        {
            return _context.Courses;
        }
    }
}