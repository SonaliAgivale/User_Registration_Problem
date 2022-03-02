using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationProblem
{
    internal class UserRegistration
    {
        //Creating the Regex According to requirement
        public static string regex = "^[A-Z]{1}[a-z]{3,}$";     
        public bool validateString(string sample)
        {
            return Regex.IsMatch(sample, regex);
        }
    }
}
