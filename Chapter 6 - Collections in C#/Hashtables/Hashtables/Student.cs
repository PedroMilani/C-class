using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hashtables
{
    class Student
    {
        // property called ID
        public int Id { get; set; }
        //property called name
        public string Name { get; set; }
        // property called GPA
        public float Grade { get; set; }
        // simple constructor
        public Student(int Id, string Name, float Grade)
        {
            this.Id = Id;
            this.Name = Name;
            this.Grade = Grade;
        }
    }
}
