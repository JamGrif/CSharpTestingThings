using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            string FirstName = "";
            string LastName = "";
            Console.WriteLine("Hello World!");
            Console.Write("Enter your first name: ");
            FirstName = Console.ReadLine();
            Console.Write("Enter your last name: ");
            LastName = Console.ReadLine();

            Console.WriteLine("Hello " + FirstName + " " + LastName);

            string password = "apple";
            string attempt = "";
            while (password != attempt)
            {
                Console.Write("Enter the password: ");
                attempt = Console.ReadLine();
                if (attempt == password)
                {
                    break;
                }
                Console.WriteLine("Wrong password!");
            }
            Console.WriteLine("Password accepted!");


        }
    }
}
