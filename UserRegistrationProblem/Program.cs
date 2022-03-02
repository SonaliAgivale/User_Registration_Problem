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
            if (userRegistration.validateString("Sonali"))
            {
                Console.WriteLine("Enter String are Valid");
            }
            else
                Console.WriteLine("Enter String are Invalid");
                Console.ReadKey();
        }
    }
}
