using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class InvalidAge
    {
        static void validate(int age)
        {
            if (age < 18)
            {
                throw new InvalidAgeException("Sorry, Age must be greater than 18");
            }
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Enetr Your age");
            int age = Convert.ToInt32(Console.ReadLine());
            try
            {
                
                InvalidAge.validate(age);
            }
            catch (InvalidAgeException e) 
            {
                Console.WriteLine(e);
            }
            finally
                {
                Console.WriteLine("Rest of the code");
                 }
        }
    }
}

