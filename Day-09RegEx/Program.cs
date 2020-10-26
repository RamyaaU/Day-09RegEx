using System;
using System.Text.RegularExpressions;

namespace Day_09RegEx
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to user registration");
            //variables
            string firstName, lastName, Email, mobileNum, Password;
            //patterns for name, email, mobileno, Password
            var regexName = @"^[A-Z][a-z]{2,18}$";
            var regexEmail = @"^[0-9a-zA-Z]+([._+-][0-9a-zA-Z]+)*[@][0-9a-zA-Z]+.[a-zA-Z]{2,3}(.[a-zA-Z]{2})?$";
            var regexMobile = @"^((\+){1}91){1}[1-9]{1}[0-9]{9}$";
            var regexPassword = @"^([a-zA-Z]*[A-Z]+[a-zA-Z]*).{8,}$";

            /// <summary>
            /// Validates the first name.
            /// </summary>
            /// <param name="firstName">The last name.</param>
            Console.WriteLine("Enter First Name: ");
            firstName = Console.ReadLine();
            checkIfValid(regexName, firstName);

            Console.WriteLine("Enter Last Name: ");
            lastName = Console.ReadLine();
            checkIfValid(regexName, lastName);
            /// <summary>
            /// Validates the last name.
            /// </summary>
            /// <param name="lastName">The last name.</param>


            Console.WriteLine("Enter Email ID: ");
            Email = Console.ReadLine();
            checkIfValid(regexEmail, Email);
            /// <summary>
            /// Validates the email.
            /// </summary>
            /// <param name="email">The email.</param>

            Console.WriteLine("Enter Mobile Number: ");
            mobileNum = Console.ReadLine();
            checkIfValid(regexMobile, mobileNum);
            /// <summary>
            /// Validates the mobileno.
            /// </summary>
            /// <param name="mobileno">The mobileno.</param>

            Console.WriteLine("Enter Password: ");
            mobileNum = Console.ReadLine();
            checkIfValid(regexMobile, mobileNum);
            /// <summary>
            /// Validates the password.
            /// </summary>
            /// <param name="password">The password.</param>
        }


        //checkIfValid(string input, string pattern)
        public static void checkIfValid(string regex, string input)
        {
            var matchInput = Regex.Match(input, regex);
            //if pattern matches with the regex
            //then it is valid 
            //else invalid
            if (matchInput.Success)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }

        }
    }
}
