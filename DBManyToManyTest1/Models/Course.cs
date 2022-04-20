using System;
using System.Collections.Generic;
using System.Text;

namespace DBManyToManyTest1.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }


        //Navigation Properties (dessa ska väl inte behövas pga joining table gissar jag)

        //public ICollection<Teacher> Teachers { get; set; }
        //public ICollection<Student> Students { get; set; }

        //Nav Prop joining table
        public ICollection<Course_Students> Course_Students { get; set; }
        public ICollection<Teacher_Courses> Teacher_Courses { get; set; }
    }
}
