using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAccess.Inheritance
{
    class MainInheritance
    {
      static void Main(string []ar)
        {
            B b = new B();
            b.Running();
            b.Sitting();

            C c = new C();
            c.Walking();
            c.Sitting();
            c.Sitting();
        }
    }
    class A
    {
        public void Running()
        {
            Console.WriteLine("A is Running");
        }
    }
    class B : A
    {
        public void Sitting()
        {
            Console.WriteLine("A is Sitting");
        }
    }
    class C : B
    {
        public void Walking()
        {
            Console.WriteLine("A is Walking");
        }

    }
}
