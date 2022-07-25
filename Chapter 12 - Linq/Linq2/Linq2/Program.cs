using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq2
{
    class Program
    {
        static void Main(string[] args)
        {
            UniversityManager um = new UniversityManager();

            um.MaleStudents();
            um.FemaleStudents();
            um.SortStudentsByAge();
            um.AllStudentsFromYale();

            Console.WriteLine("\nTo select students from university of Yale type 1 or BeijingTech type 2 and Enter:");
            string input = Console.ReadLine();
            try
            {
                int inputInt = Convert.ToInt32(input);
                um.AllStudentsFromInput(inputInt);

            }
            catch (Exception)
            {
                Console.WriteLine("Wrong value.");
            }

            Console.WriteLine();

            // Another Linq library usage

            int[] someInts = { 30, 15, 4, 3, 15 };
            IEnumerable<int> sortedInts = from i in someInts orderby i select i;
            IEnumerable<int> reversedInts = sortedInts.Reverse();

            foreach(int i in reversedInts)
            {
                Console.WriteLine(i);
            }

            // We could also

            IEnumerable<int> reversedSortedInts = from i in someInts orderby i descending select i;

            um.StudentAndUniNameCollection();

            Console.ReadKey();
        }
    }
}
