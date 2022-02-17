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


            Regex regex = new Regex("^[A-Z]{1,}[a-z]{1,}[0-9]{0,}[@][a-z]{1,5}[.][a-z]{1,3}$");
            Regex regex1 = new Regex("^[A-Z]{1,}[a-z]{1,}[0-9]{0,}[@][a-z]{1,5}[.][a-z]{1,2}[.][a-z]{1,2}$");

            Console.WriteLine("Enter Email id :");
            string emailId = Console.ReadLine();
            if (regex.IsMatch(emailId) || regex1.IsMatch(emailId))
            {
                Console.WriteLine("Your Email id is :" + emailId);
            }
            else
            {
                Console.WriteLine("Entered Email id is Invalid");
            }

            Regex regex2 = new Regex("^[+][0-9]{0,2}[ ][0-9]{0,10}$");
            Console.WriteLine("Enter Contact Number :");
            string contact = (Console.ReadLine());

            if (regex2.IsMatch(contact))
            {
                Console.WriteLine("Your contact number is :" + contact);
            }
            else
            {
                Console.WriteLine("Entered Mobile Numberis invalid");
            }

            Regex regex3 = new Regex("^(.*?[A-Z])(.*?[0-9])(.*?[/*-+_@&$#%])[a-zA-Z0-9/*-+_@&$#%]{6,}$");

            Console.WriteLine("Enter password :");
            string password = Console.ReadLine();

            if (regex3.IsMatch(password))
            {
                Console.WriteLine("Your password is :" + password);
            }
            else
            {
                Console.WriteLine("Entered Password ");
            }
        }
    }
}
