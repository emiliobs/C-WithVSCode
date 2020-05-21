using System;
using EmployeeAppVSCode.EmployeeComponent;
using System.Collections.Generic;

namespace EmployeeAppVSCode.EmployeeConsoleApp
{
  class Program
  {
    static void Main(string[] args)
    {
      List<Employee> employees = new List<Employee>()
      {
              new Employee
              {
                  Id = 1,
                  FirstName = "Bob",
                  LastName = "Jones",
                  Gender = 'm',
              },
              new Employee
              {
                  Id = 2,
                  FirstName = "Emilio",
                  LastName = "Barrera",
                  Gender = 'm',
              },
              new Employee
              {
                  Id = 3,
                  FirstName = "Luz",
                  LastName = "Linda",
                  Gender = 'f',
              },
              new Employee
              {
                  Id = 4,
                  FirstName = "Marica",
                  LastName = "Flaca",
                  Gender = 'f',
              },
              new Employee
              {
                  Id = 5,
                  FirstName = "Joe",
                  LastName = "Felix",
                  Gender = 'f',
              },
           };

      foreach (var employee in employees)
      {
        System.Console.WriteLine($"{employee.Id.ToString().PadRight(6)}{employee.FullName.PadRight(20)}{employee.Gender.ToString().PadRight(2)}");
      }

    }
  }
}
