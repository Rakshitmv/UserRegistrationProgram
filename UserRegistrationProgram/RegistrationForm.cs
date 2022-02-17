using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationProgram
{
    public class RegistrationForm
    {
        public void UserRegistration()
        {
            Regex firstName = new Regex("^[A-Z]{1}[a-z]{3,26}$");

            Console.WriteLine("Enter First Name :");
            string fName = Console.ReadLine();
            if (firstName.IsMatch(fName))
            {
                Console.WriteLine("Your Name is :" + fName);
            }
            else
            {
                Console.WriteLine("Entered First Name is Invalid");
            }

            Regex lastName = new Regex("^[A-Z]{1}[a-z]{3,26}$");

            Console.WriteLine("Enter Last Name :");
            string lName = Console.ReadLine();
            if (lastName.IsMatch(lName))
            {
                Console.WriteLine("Your last Name is :" + lName);
            }
            else
            {
                Console.WriteLine("Entered Last Name is Invalid");
            }
        }
    }
}
