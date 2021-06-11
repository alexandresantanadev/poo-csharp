using System;
using System.Collections.Generic;
using System.Globalization;

namespace Exercicio_Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            System.Console.Write("How many employees will be registered?");
            int employee = int.Parse(Console.ReadLine());


            for (int i = 1; i <= employee; i++)
            {
                System.Console.WriteLine("Employee #" + i + ":");
                System.Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                System.Console.Write("Name: ");
                string name = Console.ReadLine();
                System.Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                employees.Add(new Employee(id, name, salary));
                System.Console.WriteLine();
            }
            System.Console.Write("Enter the employee id that will have salary increase: ");
            int searchId = int.Parse(Console.ReadLine());

            Employee emp = employees.Find(x => x.Id == searchId);
            if (emp != null)
            {
                System.Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.IncreaseSalary(percentage);
            }
            else
            {
                System.Console.WriteLine("This id does not exist!");
            }

            System.Console.WriteLine();
            System.Console.WriteLine("Update list of employees:");
            foreach (Employee obj in employees)
            {
                System.Console.WriteLine(obj);
            }
        }
    }
}
