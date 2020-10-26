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
            var match = Regex.Match(firstName, regex);
            //if pattern matches with the firstname of regex
            //then it is a valid first name
            //else invalid first name
            if (match.Success)
            {
                Console.WriteLine("Valid first name");
            }
            else
            {
                Console.WriteLine("Invalid first name");
            }
        }
    }
}
