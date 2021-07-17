using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class InvalidAgeException:Exception
    {
        public InvalidAgeException(String message)
      : base(message)
        {

        }
    }
}
