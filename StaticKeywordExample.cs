using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAccess.Keywords
{
    class StaticKeywordExample
    {
        static int x = 50;
        static int y = 35;
        static int z;
        StaticKeywordExample()
        {
            Console.WriteLine("Non-Parameterised Constructor");
        }
             static StaticKeywordExample()
            {
             z = 100;
                z++;
            }
        //static method
       static int add()
        {
            int a = 7;
            int b = 10;
            return a + b;
        }

        static void Main(string []d)
        {
            int result = StaticKeywordExample.add();
            Console.WriteLine("Addition of 2 number inside static method is " + result);

            int resultStatix = StaticKeywordExample.x + StaticKeywordExample.y;
            Console.WriteLine("Addition of 2 static number is " + resultStatix);

            InnerClassStatic.run();

            SealedClassEx sealedClass = new SealedClassEx();
            Console.Write(sealedClass.Substraction());

            StaticKeywordExample staticKeyword = new StaticKeywordExample();
            

        }
        static class InnerClassStatic
        {
            public static void run()
            {
                Console.WriteLine("Hello Run");
            }
        }
    }
    // we cant inherit sealed class
    // and we canot have void type of methods in sealed class
    sealed class SealedClassEx
    {
        public int Substraction()
        {
            return 10- -4;
        }
    }
}
