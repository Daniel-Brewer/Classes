using System;
using System.Collections.Generic;

namespace classes
{

    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public DateTime StartDate { get; set; }
    }
    public class Company
    {

        public Company(string name, DateTime dateFounded)
        {
            Name = name;
            CreatedOn = dateFounded;
            EmployeeList = new List<Employee>();
        }

        // Some readonly properties (let's talk about gets, baby)

        public string Name { get; }
        public DateTime CreatedOn { get; }
        // Create a public property for holding a list of current employees

        public List<Employee> EmployeeList { get; set; }

        /*
            Create a constructor method that accepts two arguments:
                1. The name of the company
                2. The date it was created


            The constructor will set the value of the public properties
        */
        public void ListEmployees()
        {
            foreach (Employee emp in EmployeeList)
            {
                Console.WriteLine($"{emp.FirstName} {emp.LastName}");
            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of a company. Name it whatever you like.
            Company AgentsOfGrace = new Company("AOG", new DateTime(2017, 1, 10));
            // Create three employees
            Employee Ryan = new Employee()
            {
                FirstName = "Ryan",
                LastName = "Brewer",
                Title = "Marketing",
                StartDate = new DateTime(2017, 2, 2)
            };
            Employee Aaron = new Employee()
            {
                FirstName = "Aaron",
                LastName = "Brewer",
                Title = "Writer",
                StartDate = new DateTime(2017, 2, 3)
            };
            Employee Teble = new Employee()
            {
                FirstName = "Teble",
                LastName = "Brewer",
                Title = "CFO",
                StartDate = new DateTime(2017, 3, 2)
            };
            // Assign the employees to the company
            List<Employee> Employees = new List<Employee>();
            Employees.Add(Aaron);
            Employees.Add(Ryan);
            Employees.Add(Teble);

            AgentsOfGrace.EmployeeList = Employees;
            /*
                Iterate the company's employee list and generate the
                simple report shown above
            */
            AgentsOfGrace.ListEmployees();
        }
    }
}
