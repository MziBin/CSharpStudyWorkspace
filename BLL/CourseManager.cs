﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Models;

namespace BLL
{
    public class CourseManager
    {
        public CourseServer courseService = new CourseServer();

        public int AddCourse(Course course)
        {
            return courseService.AddCourse(course);
        }
    }
}
