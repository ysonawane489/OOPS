using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    class Modifiers
    {
        public readonly string str = "Yogesh";
        public void Assign()
        {
            Console.WriteLine(str+"readonly can nott inti second time");
           // str = "Sagar";//Readonly can not assign agin;


        }
     
    }
    }

