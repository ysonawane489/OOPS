using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAccess.AccessModfiersInternal
{
    class SimpleCalculator
    {
        public void Add(int a, int b) {
            int c = a + b;
            Console.WriteLine(c);
        }

        void Sub(int a, int b)
        {
            int c = a - b;
            Console.WriteLine(c);
        }

        protected void Mult(int a, int b)
        {
            int c = a * b;
            Console.WriteLine(c);
        }
    }
}
