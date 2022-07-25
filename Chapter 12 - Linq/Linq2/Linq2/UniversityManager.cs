using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq2
{
    class UniversityManager
    {
        public List<University> universities;
        public List<Student> students;

        public UniversityManager()
        {
            universities = new List<University>();
            students = new List<Student>();

            //Adding Universities

            universities.Add(new University { Id = 1, Name = "Yale" });
            universities.Add(new University { Id = 2, Name = "Beijing Tech" });

            //Adding Students

            students.Add(new Student { Id = 1, Name = "Carla", Gender = "Female", Age = 17, UniversityId = 1 });
            students.Add(new Student { Id = 2, Name = "Toni", Gender = "Male", Age = 21, UniversityId = 1 });
            students.Add(new Student { Id = 3, Name = "Leyla", Gender = "Female", Age = 19, UniversityId = 2 });
            students.Add(new Student { Id = 4, Name = "James", Gender = "trans-gender", Age = 25, UniversityId = 2 });
            students.Add(new Student { Id = 5, Name = "Linda", Gender = "Female", Age = 22, UniversityId = 2 });
            students.Add(new Student { Id = 6, Name = "Fran", Gender = "Male", Age = 20, UniversityId = 2 });
        }

        public void MaleStudents()
        {
            IEnumerable<Student> maleStudents = from student in students where student.Gender == "Male" select student;
            Console.WriteLine("\nMale - Students:");

            foreach(Student student in maleStudents)
            {
                student.Print();
            }
        }
        public void FemaleStudents()
        {
            IEnumerable<Student> femaleStudents = from student in students where student.Gender == "Female" select student;
            Console.WriteLine("\nFemale - Students:");

            foreach (Student student in femaleStudents)
            {
                student.Print(); 
            }
        }

        public void SortStudentsByAge()
        {
            var sortedStudents = from student in students orderby student.Age select student;

            Console.WriteLine("\nStudents sorted by Age:");

            foreach(Student student in sortedStudents)
            {
                student.Print();
            }
        }

        public void AllStudentsFromYale()
        {
            IEnumerable<Student> yaleStudents = from student in students
                                                join university in universities on student.UniversityId equals university.Id
                                                where university.Name == "Yale"
                                                select student;
            Console.WriteLine("\nStudents from Yale:");
            foreach(Student student in yaleStudents)
            {
                student.Print();
            }
        }

        public void AllStudentsFromInput(int Id)
        {
            IEnumerable<Student> inputStudents = from student in students
                                                join university in universities on student.UniversityId equals university.Id
                                                where university.Id == Id
                                                select student;
            Console.WriteLine("\nStudents from user input:");
            foreach (Student student in inputStudents)
            {
                student.Print();
            }

        }

        public void StudentAndUniNameCollection()
        {
            var nameCollection = from student in students
                                 join university in universities on student.UniversityId equals university.Id
                                 orderby student.Name
                                 select new { StudentName = student.Name, UniversityName = university.Name };

            Console.WriteLine("New Collection: ");

            foreach(var col in nameCollection)
            {
                Console.WriteLine("Student {0} from University {1}.", col.StudentName, col.UniversityName);
            }
        }
    }
}
