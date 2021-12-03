using System;
using System.Collections.Generic;
using System.Linq;

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

            //Update
            string KeyToUpdate = "HR";
            if (employeesDirectory.ContainsKey(KeyToUpdate))
            {
                employeesDirectory[KeyToUpdate] = new Employee("HR", "Eleka", 26, 18);
            }
            else
            {
                Console.WriteLine("No employee found with this key {0}", KeyToUpdate);
            }

            //Remove
            string KeyToRemove = "Secretary";
            if (employeesDirectory.Remove(KeyToRemove))
            {
                Console.WriteLine("Employee with the role/key {0} was removed.", KeyToRemove);
            }
            else
            {
                Console.WriteLine("No employee with the key {0} found", KeyToRemove);
            }

            for (int i = 0; i < employeesDirectory.Count; i++)
            {
                // using ElementAt(i) to return the key-value pair stored at index i
                KeyValuePair<string, Employee> keyValuePair = employeesDirectory.ElementAt(i);
                // print the key
                Console.WriteLine("Key: {0}", keyValuePair.Key);
                // storing the value in an employee object
                Employee employeeValue = keyValuePair.Value;
                // printing the properties of the employee object
                Console.WriteLine("Employee Name: {0}", employeeValue.Name);
                Console.WriteLine("Employee Role: {0}", employeeValue.Role);
                Console.WriteLine("Employee Age: {0}", employeeValue.Age);
                Console.WriteLine("Employee Salary: {0}", employeeValue.Salary);

            }


            string key = "CEO";
            if (employeesDirectory.ContainsKey(key)) // check if the key exists
            {
                Employee emp1 = employeesDirectory["CEO"];
                Console.WriteLine("Employee Name: {0}\nRole: {1}\nSalary: {2}", emp1.Name, emp1.Role, emp1.Salary);
            }
            else
            {
                Console.WriteLine("No employee found.");
            }


            Employee result = null;
            // using TryGetValue() it returns true if the operation was succesful and false otherwise
            if(employeesDirectory.TryGetValue("intern", out result))
            {
                Console.WriteLine("Value retrieved.");

                Console.WriteLine("Employee Name: {0}", result.Name);
                Console.WriteLine("Employee Role: {0}", result.Role);
                Console.WriteLine("Employee Age: {0}", result.Age);
                Console.WriteLine("Employee Salary: {0}", result.Salary);
            }
            else
            {
                Console.WriteLine("The key does not exist.");
            }

            Console.ReadKey();
        }
    }
}
