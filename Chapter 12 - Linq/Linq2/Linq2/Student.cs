using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq2
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }

        // foreign Key
        public int UniversityId { get; set; }

        public void Print()
        {
            Console.WriteLine("Student: {0}; Id {1}; Gender: {2}; Age: {3}; " +
                "UniversityId: {4}", Name, Id, Gender, Age, UniversityId);
        }
    }
}
