using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    public class AccountGenerator
    {
        public static void CreateAccount(Person user)
        {
            Console.WriteLine("Your username is {0}{1}", user.FirstName.Substring(0, 1), user.LastName);
        }
    }
}

