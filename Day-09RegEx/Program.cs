using System;
using System.Text.RegularExpressions;

namespace Day_09RegEx
{
    class Program
    {
        private static int regex;

        static void Main(string[] args)
        {
            //variable
            string firstName, lastName, Email;
            //pattern for firstname and lastname
            var regexName = @"^[A-Z][a-z]{2,}$";
            //pattern for email
            var regexEmail = "^[a-z]{3,}[.][a-z]*[@][a-z]{2,}[.][a-z]{2,}[.][a-z]*$";
            //userinput
            Console.WriteLine("Enter First Name: ");
            firstName = Console.ReadLine();
            Console.WriteLine("Enter Last Name: ");
            lastName = Console.ReadLine();
            Console.WriteLine("Enter Valid Email: ");
            Email = Console.ReadLine();
            //var match = Regex.Match(string input, string pattern)
            Match matchfirstName = Regex.Match(firstName, regexName);
            //if pattern matches with the firstname of regex
            //then it is a valid first name
            //else invalid first name
            if (matchfirstName.Success)
            {
                Console.WriteLine("Valid First Name");
            }
            else
            {
                Console.WriteLine("Invalid First Name");
            }
            //var match = Regex.Match(string input, string pattern)
            var matchlastName = Regex.Match(lastName, regexName);
            //if pattern matches with the lastname of regex
            //then it is a valid last name
            //else invalid last name
            if (matchlastName.Success)
            {
                Console.WriteLine("Valid Last Name");
            }
            else
            {
                Console.WriteLine("Invalid Last Name");
            }
            //var match = Regex.Match(string input, string pattern)
            var matchEmail = Regex.Match(Email, regexEmail);
            //if pattern matches with the lastname of regex
            //then it is a valid last name
            //else invalid last name
            if (matchEmail.Success)
            {
                Console.WriteLine("Valid email");
            }
            else
            {
                Console.WriteLine("Invalid email");
            }

        }
    }
}


