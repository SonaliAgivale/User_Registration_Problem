using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationProblem
{
    public class UserRegistration
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

        //Regex For Email
        public static string email = "^[A-Za-z0-9]+([._#%+][A-Za-z0-9]+)?[@][A-Za-z]+[.][A-Za-z]{2,3}([.][a-zA-Z]{2})?$";
        public bool EmailID(string sample)
        {
            return Regex.IsMatch(sample, email);
        }

        //Regex for Mobile Number
        public static string mobileNo = "^(91)?[ ][789][0-9]{9}$";
        public bool ValidMobileNo(string sample)
        {
            return Regex.IsMatch(sample, mobileNo);
        }

        //Regex for Password rule1
        public static string Password = "^[a-z]{8,}$";
        public bool validPassword(string sample)
        {
            return Regex.IsMatch(sample, Password);
        }

        //Regex for Password rule2
        public static string Password2 = "^[A-Z][a-zA-Z]{8,}$";
        public bool validPassword2(string sample)
        {
            return Regex.IsMatch(sample, Password2);
        }

        //Regex for Password rule2,3-4 n  
        public static string Passwords = "(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z])(?=.*[*.!@$%^&(){}[]:;<>,.?/~_+-=|]).{8,20}$";
    public bool validPasswords(string sample)
        {
            return Regex.IsMatch(sample, Passwords);
        }
    }
}
