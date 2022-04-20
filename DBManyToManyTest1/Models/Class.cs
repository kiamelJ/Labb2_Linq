using System;
using System.Collections.Generic;
using System.Text;

namespace DBManyToManyTest1.Models
{
    public class Class
    {
        public int Id { get; set; }
        public string Name { get; set; }


        //Navigation Properties (dessa ska väl inte behövas pga joining table gissar jag)
        
        //public ICollection<Teacher> Teachers { get; set; }

        //Däremot ska denna ligga kvar (tror jag) eftersom det är en till många förhållande mellan Class
        //och Students. En klass kan ha många studenter men en student kan bara ha en klass.
        public ICollection<Student> Students { get; set; }

        //Nav Prop joining table
        public ICollection<Teacher_Classes> Teacher_Classes { get; set; }
    }
}
