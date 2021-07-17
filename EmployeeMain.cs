using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleAppAccess.GetterAndSetter;

namespace ConsoleAppAccess.GetterAndSetter
{
    class EmployeeMain
    {
        static void Main(string []d)
        {
            Employee employee = new Employee();
           Console.WriteLine( employee.Id = 101);
           Console.WriteLine( employee.Name = "vikrant");
           Console.WriteLine( employee.Sal = 21800);
        }
    }

}
