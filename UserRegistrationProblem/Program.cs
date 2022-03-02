using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistrationProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //creating object of class
            UserRegistration userRegistration = new UserRegistration();
            //Enter the String inside if condition for validation
            if (userRegistration.ValidMobileNo("91 7155679901"))
            {
                Console.WriteLine("Entered Mobile No are VALID");
            }
            else
                Console.WriteLine("Entered Mobile No are INVALID");
                Console.ReadKey();
        }
    }
}
