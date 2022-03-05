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
            if (userRegistration.validPasswords("sonali#123"))
            {
                Console.WriteLine("Entered Password are VALID");
            }
            else
                Console.WriteLine("Entered Password are INVALID");
                Console.ReadKey();
        }
    }
}
