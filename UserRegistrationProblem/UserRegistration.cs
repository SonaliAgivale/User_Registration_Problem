﻿using System;
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

        //Regex For Email
        public static string email = "^[A-Za-z0-9]+([._#%+][A-Za-z0-9]+)?[@][A-Za-z]+[.][A-Za-z]{2,3}([.][a-zA-Z]{2})?$";
        public bool EmailID(string sample)
        {
            return Regex.IsMatch(sample, email);
        }
    }
}
