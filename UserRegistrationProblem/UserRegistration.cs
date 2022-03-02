using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationProblem
{
    internal class UserRegistration
    {
        //Regex For First Name
        //Creating the Regex According to requirement
        public static string regex = "^[A-Z]{1}[a-z]{3,}$";     
        public bool validateString(string sample)
        {
            return Regex.IsMatch(sample, regex);
        }

        //Regex For Last Name
        public static string regex1 = "^[A-Z]{1}[a-z]{3,}$";
        public bool LastName(string sample)
        {
            return Regex.IsMatch(sample, regex1);
        }
    }
}
