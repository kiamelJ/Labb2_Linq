using System;
using System.Collections.Generic;
using System.Text;

namespace DBManyToManyTest1.Models
{
    public class Course_Students
    {
        public int CourseId { get; set; }
        public int StudentId { get; set; }
        public Course Course { get; set; }
        public Student Student { get; set; }
    }
}
