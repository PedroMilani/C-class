using System;
using System.Collections;

namespace Hashtables
{
    class Program
    {
        static void Main(string[] args)
        {
            // Key - Value (hashtable)

            Hashtable studentsTable = new Hashtable();

            Student[] students = new Student[5];
            students[0] = new Student(1, "Abc", 9);
            students[1] = new Student(2, "Bcd", 8);
            students[2] = new Student(3, "Cde", 9);
            students[3] = new Student(2, "Rrr", 6);
            students[4] = new Student(4, "Def", 7);

            foreach(Student s in students)
            {
                if (!studentsTable.ContainsKey(s.Id))
                {
                    // voi Hashtable.Add(object Key, value)
                    studentsTable.Add(s.Id, s); // store data in a hashtable
                    Console.WriteLine("Student with ID {0} was added!", s.Id);
                }
                else
                {
                    Console.WriteLine("Id already exists.");
                }
            }



            // cast the object in type Student with (Student)
            Student storedStudent1 = (Student)studentsTable[1]; // retrieve individual item with known ID
            // or Student storedStudent1 = (Student)studentsTable[stud1.Id];

            // retrieve all values from a Hashtable
            foreach (DictionaryEntry entry in studentsTable) 
            {
                Student temp = (Student)entry.Value;
                Console.WriteLine("Student ID: {0}",temp.Id);
                Console.WriteLine("Student name: {0}", temp.Name);
                Console.WriteLine("Student grade: {0}", temp.Grade);
            }// whenever we add an entry in the hashtable a new DicitionaryEntry object
             // is created, so a hashtable is basically a collection of DicitionaryEntries 


            // we can simplify this foreach loop:
            foreach(Student Value in studentsTable.Values)
            {
                Console.WriteLine("Student ID: {0}", Value.Id);
                Console.WriteLine("Student name: {0}", Value.Name);
                Console.WriteLine("Student grade: {0}", Value.Grade);
            }

            //Console.WriteLine("Student ID: {0}\nName: {1}\nGrade: {2}", storedStudent1.Id, storedStudent1.Name, storedStudent1.Grade);
            Console.ReadKey();
        }

    }

   
}
