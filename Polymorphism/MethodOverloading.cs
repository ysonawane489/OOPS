using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAccess.Polymorphism
{
    class MethodOverloading
    {
        public void Add()
        {
            Console.WriteLine("blank method");
        }

        public void Add(int a, int b)
        {
            int c = a + b;
            Console.WriteLine("addition of two integers is : " + c);
        }

        public void Add(long a, float b)
        {
            int c = (int)(a + b);
            Console.WriteLine("addition of long and float is : " + c);
        }

        public void Add(int a, int b, int c)
        {
            int d = a + b + c;
            Console.WriteLine("addition of three integers is : " + d);
        }

      
        //in polymorphism we consider as parameter
    }
}
