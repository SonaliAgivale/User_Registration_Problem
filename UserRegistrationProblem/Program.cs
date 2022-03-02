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
            if (userRegistration.EmailID("Sonali.111@gmail.com.in"))
            {
                Console.WriteLine("Entered Email String are VALID");
            }
            else
                Console.WriteLine("Entered Email String are INVALID");
                Console.ReadKey();
        }
    }
}
