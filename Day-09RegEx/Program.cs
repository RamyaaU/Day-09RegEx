using System;
using System.Text.RegularExpressions;

namespace Day_09RegEx
{
    class Program
    {
        static void Main(string[] args)
        {
            //variable
            string firstName, lastName;
            //pattern
            var regex = @"^[A-Z][a-z]{2,}$";
            //userinput
            Console.WriteLine("Enter First Name: ");
            firstName = Console.ReadLine();
            Console.WriteLine("Enter Last Name: ");
            lastName = Console.ReadLine();
            //var match = Regex.Match(string input, string pattern)
            var matchFirstName = Regex.Match(firstName, regex);
            //if pattern matches with the firstname of regex
            //then it is a valid first name
            //else invalid first name
            if (matchFirstName.Success)
            {
                Console.WriteLine("Valid First Name");
            }
            else
            {
                Console.WriteLine("Invalid First Name");
            }
            //var match = Regex.Match(string input, string pattern)
            var matchLastName = Regex.Match(lastName, regex);
            //if pattern matches with the firstname of regex
            //then it is a valid last name
            //else invalid last name
            if (matchLastName.Success)
            {
                Console.WriteLine("Valid Last Name");
            }
            else
            {
                Console.WriteLine("Invalid Last Name");
            }
        }
    }
}
