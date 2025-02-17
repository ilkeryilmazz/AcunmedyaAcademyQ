using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace VariablesAndConditions
{
    public static class PasswordController
    {
        public static void Control()
        {
            Console.Write("Enter a password for controlling: ");
            string password = Console.ReadLine();
            if (password.Length < 8)
            {
                Console.WriteLine("Weak password! It must be at least 8 characters long.");
                return;
               
            }
            else if (!Regex.IsMatch(password, @"[A-Z]"))
            {
                Console.WriteLine("Weak password! It must contain at least one uppercase letter.");
                return;
             
            }
            else if (!Regex.IsMatch(password, @"[!@#$%-]"))
            {
                Console.WriteLine("Weak password! It must contain at least one special character (!,@, #, $, %, -).");
                return;
               
            }
            Console.WriteLine("Your Password Is Strong.");

        }
    }
}
