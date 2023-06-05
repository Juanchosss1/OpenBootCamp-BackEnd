using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public class UserNotFound : Exception
    {
        public UserNotFound() { 
        

        }

        public UserNotFound(string message) : base(message)
        {
           
            Console.WriteLine(message);
        }
    }
}
