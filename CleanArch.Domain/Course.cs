﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Domain
{
    class Course
    {
        public int CourseID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }
}