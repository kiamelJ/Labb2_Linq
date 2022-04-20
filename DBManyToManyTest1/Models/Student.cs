using System;
using System.Collections.Generic;
using System.Text;

namespace DBManyToManyTest1.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }


        //Navigation Properties
        
        public Class Class { get; set; }

        //Som i Teacher så bör dessa ersättas av de som går till joining table.
        //public ICollection<Teacher> Teachers { get; set; }
        //public ICollection<Course> Courses { get; set; }

        //Nav Prop joining table
        public ICollection<Teacher_Students> Teacher_Students { get; set; }
        public ICollection<Course_Students> Course_Students { get; set; }

    }
}
