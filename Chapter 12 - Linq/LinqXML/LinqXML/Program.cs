using System;
using System.Linq;
using System.Xml.Linq;

namespace LinqXML
{
    class Program
    {
        static void Main(string[] args)
        {
            string studentsXML =
                        @"<Students>
                            <Student>
                                <Name>Toni</Name>
                                <Age>21</Age>
                                <University>Yale</University>
                                <HairColor>Black</HairColor>
                            </Student>
                            <Student>
                                <Name>Carla</Name>
                                <Age>21</Age>
                                <University>Yale</University>
                                <HairColor>Brown</HairColor>
                            </Student>
                            <Student>
                                <Name>Layla</Name>
                                <Age>19</Age>
                                <University>Beijing Tech</University>
                                <HairColor>Yellow</HairColor>
                            </Student>
                            <Student>
                                <Name>Pedro</Name>
                                <Age>29</Age>
                                <University>IFRS</University>
                                <HairColor>Black</HairColor>
                            </Student>
                        </Students>";

            XDocument studentsXdoc = new XDocument();
            studentsXdoc = XDocument.Parse(studentsXML);

            var students = from student in studentsXdoc.Descendants("Student")
                           select new
                           {
                               Name = student.Element("Name").Value,
                               Age = student.Element("Age").Value,
                               University = student.Element("University").Value,
                               HariColor = student.Element("HairColor").Value
                           };

            foreach(var student in students)
            {
                Console.WriteLine("Student {0} with age {1} from university of {2}", student.Name, student.Age, student.University);
            }

            var studentsSortedByAge = from student in students
                                     orderby student.Age
                                     select student;

            Console.WriteLine();
            Console.WriteLine("Sorted by age:");

            foreach(var student in studentsSortedByAge)
            {
                Console.WriteLine(student.Name + " " + student.Age);
            }

            Console.ReadKey();
        }
    }
}
