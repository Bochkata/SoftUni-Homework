using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;



namespace T01CompanyRoster
{
    class Program
    {
        static void Main(string[] args)
        {

            int number = int.Parse(Console.ReadLine());

            List<Department> allDepartments = new List<Department>();

            for (int i = 0; i < number; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string currentName = input[0];
                double currentSalary = double.Parse(input[1]);
                string currentDepartment = input[2];

                Employee newEmployee = new Employee();
                {
                    newEmployee.Name = currentName;
                    newEmployee.Salary = currentSalary;
                }

                Department repetativeDept = allDepartments.FirstOrDefault(x => x.DepartmentName == currentDepartment);
                if (repetativeDept == null)
                {

                    Department newDepartment = new Department();
                    {
                        newDepartment.DepartmentName = currentDepartment;
                        newDepartment.Employee.Add(newEmployee);
                        newDepartment.Salaries.Add(currentSalary);

                    }
                    allDepartments.Add(newDepartment);
                }
                else
                {
                    repetativeDept.Employee.Add(newEmployee);
                    repetativeDept.Salaries.Add(currentSalary);

                    allDepartments.Add(repetativeDept);
                }
                
            }

            Department highestSalaryDept = allDepartments.OrderByDescending(x => x.Salaries.Sum() / x.Salaries.Count).First();

            Console.WriteLine($"Highest Average Salary: {highestSalaryDept.DepartmentName}");
            foreach (Employee employee in highestSalaryDept.Employee.OrderByDescending(x=>x.Salary))
            {
                Console.WriteLine($"{employee.Name} {employee.Salary:f2}");
            }
           
        }

        class Employee
        {

            public string Name { get; set; }
            public double Salary { get; set; }

        }
        class Department
        {
           
            public string DepartmentName { get; set; }
            public List<Employee> Employee = new List<Employee>();
            public List<double> Salaries = new List<double>();

        }
    }
}

