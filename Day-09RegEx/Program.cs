using System;
using System.Text.RegularExpressions;

namespace Day_09RegEx
{
    class Program
    {
        static void Main(string[] args)
        {
            //variable
            string firstName;
            //pattern 
            var regex = "^[A-Z]{1}[a-z]{2,20}$";
            //userinput
            Console.WriteLine("Enter first name: ");
            firstName = Console.ReadLine();
            //var match = Regex.Match(string input, string pattern)
            var match = Regex.Match(firstName, regex);
            //if pattern matches with the firstname of regex
            //then it is a valid first name
            //else invalid first name
            if (match.Success)
            {
                Console.WriteLine("User first name matches with pattern successfully");
            }
            else
            {
                Console.WriteLine("User first name is invalid");
            }
        }
    }
}
