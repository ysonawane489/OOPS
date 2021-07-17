using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAccess.Polymorphism
{
    class Bank
    {
        public virtual float getRateOfInterest()
        {
            return 4.5f;
        }
        
        
    }
    class SBI : Bank
    {
        public override float getRateOfInterest()
        {
            float rateOfInteres = 6.5f;
            return rateOfInteres;
        }
    }
    class  BOI : Bank
    {
        public override float getRateOfInterest()
        {
            float rateOfInteres = 7.5f;
            return rateOfInteres;
        }
    }

    class MethodOveriding
    {
        static void Main(string []args)
        {
            Bank bankSBI = new SBI();
            float fSBI =  bankSBI.getRateOfInterest();
            Console.WriteLine("Bank of Sbi RateOfInterest "+fSBI);
            Bank bankBOI = new BOI();
           float fBoi = bankBOI.getRateOfInterest();
            Console.WriteLine("Bank of BOI RateOfInterest " + fBoi);



        }

       
    }
}
