using System;
using System.Text.RegularExpressions;

namespace Day_09RegEx
{
    class Program
    {
        static void Main(string[] args)
        {
            //variable
            string firstName, lastName, Email, PhoneNumber;
            //pattern for firstname,lastname,email, PhoneNumber
            var regexName = @"^[A-Z][a-z]{2,}$";
            var regexEmail = "^[a-z]{3,}[.][a-z]*[@][a-z]{2,}[.][a-z]{2,}[.][a-z]*$";
            var regexPhoneNumber= @"^((\+){+}91[1-9]{1}[0-9]{1,2}[ ]{1}[6-9]{1}[0-9]{9}";
            //userinput
            Console.WriteLine("Enter First Name: ");
            firstName = Console.ReadLine();
            Console.WriteLine("Enter Last Name: ");
            lastName = Console.ReadLine();
            Console.WriteLine("Enter Valid Email: ");
            Email = Console.ReadLine();
            Console.WriteLine("Enter Vaild PhoneNumber");
            PhoneNumber = Console.ReadLine();
            //var match = Regex.Match(string input, string pattern)
            var matchfirstName = Regex.Match(firstName, regexName);
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
            var matchPhoneNumber = Regex.Match(PhoneNumber, regexPhoneNumber);
            //if pattern matches with the phonenumber of regex
            //then it is a valid phonenumber
            //else invalid phonenumber
            if (matchEmail.Success)
            {
                Console.WriteLine("Valid phonenumber");
            }
            else
            {
                Console.WriteLine("Invalid phonenumber");
            }
        }
    }
}
