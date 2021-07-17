using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAccess.GetterAndSetter
{
    class Employee
    {
        /* int id { get; set; }
         string name { get; set; }
         double salary { get; set; }*/
        private int id;
        private string name;
        private double sal;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public double Sal { get => sal; set => sal = value; }
    }
}
