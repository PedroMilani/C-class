using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            // A database e.g
            Employee[] employees =
            {
                new Employee("CEO","Gwyin",95,200),
                new Employee("Manager","Joe",35,25),
                new Employee("HR","Lora",32,21),
                new Employee("Secretary","Petra",28,18),
                new Employee("Developer","Artorias",55,35),
                new Employee("Intern","Ernest",22,8),
            };

            Dictionary<int, string> myDictionary = new Dictionary<int, string>()
            {
                { 1, "one"},
                { 2, "two"},
                { 3, "three"}
            }; // not using this

            Dictionary<string, Employee> employeesDirectory = new Dictionary<string, Employee>();
            foreach (Employee emp in employees)
            {
                employeesDirectory.Add(emp.Role, emp);
            }

            Employee emp1 = employeesDirectory["CEO"];

            Console.WriteLine("Employee Name: {0}\nRole: {1}\nSalary: {2}",emp1.Name, emp1.Role, emp1.Salary);


            Console.WriteLine("Hello World!");
        }
    }
}
