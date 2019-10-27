using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    public class StandardMessages
    {
        public static void DisplayValidationError(string Name)
        {
            Console.WriteLine("You did not give us a valid {0}!", Name);
        }
    }
}