using System;
using System.Collections.Generic;
using System.Text;

namespace DBManyToManyTest1.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; }


        //Navigation Properties (dessa ska väl inte behövas pga joining table gissar jag)

        //public ICollection<Student> Students { get; set; }
        //public ICollection<Class> Classes { get; set;  }
        //public ICollection<Course> Courses { get; set; }

        //Nav Prop joining table
        public ICollection<Teacher_Students> Teacher_Students { get; set; }
        public ICollection<Teacher_Courses> Teacher_Courses { get; set; }
        public ICollection<Teacher_Classes> Teacher_Classes { get; set; }

    }
}
