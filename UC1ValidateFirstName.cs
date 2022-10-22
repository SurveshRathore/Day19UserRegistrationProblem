using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day19UserRegistrationProblem
{
    internal class UC1ValidateFirstName
    {
        public void CheckFirstName()
        {
            String nameRegex = "^[A-Z][a-zA-Z]{2,}"; 
            Console.Write("Enter the First Name: ");
            String userName = Console.ReadLine();

            bool valid = Regex.IsMatch(userName, nameRegex);
            Console.WriteLine(valid);
        }
    }
}
