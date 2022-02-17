using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistrationProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RegistrationForm form = new RegistrationForm();
            form.UserRegistration();
            Console.ReadLine();
        }
    }
}
