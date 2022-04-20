using System;
using System.Collections.Generic;
using System.Text;

namespace DBManyToManyTest1.Models
{
    public class Teacher_Classes
    {
        public int TeacherId { get; set; }
        public int ClassId { get; set; }
        public Teacher Teacher { get; set; }
        public Class Class { get; set; }
    }
}
