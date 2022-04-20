using System;
using System.Collections.Generic;
using System.Text;

namespace DBManyToManyTest1.Models
{
    public class Teacher_Courses
    {
        public int TeacherId { get; set; }
        public int CourseId { get; set; }
        public Teacher Teacher { get; set; }
        public Course Course { get; set; }

    }
}
