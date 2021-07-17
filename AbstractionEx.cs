using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    abstract  class AbstractionEx
    {
        public abstract void   Display();

    }

    class AbstractionEx1 :AbstractionEx
    {
       public override  void   Display()
        {
            Console.Write("Implemented Method");
        }

        
    }
   
   
}
