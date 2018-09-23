using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your first name?");
            string firstName = Console.ReadLine();
            Console.WriteLine("What is your last name?");
            string lastName = Console.ReadLine();
            Console.WriteLine("What is your favorite color?");
            string color = Console.ReadLine();
            color = color.ToUpper();
            Console.WriteLine("Your name is " + firstName + " " + lastName + " and your favorite color is " + color + ".");
            Console.ReadLine();

            StringBuilder text = new StringBuilder();
            text.Append("My name is Blake.");
            text.AppendLine("My last name is McAllister.");
            text.AppendLine("My favorite looney tunes character is Foghorn Leghorn.");
            text.AppendLine("I love to learn to how things work.");
            text.AppendLine("C sharp is fun.");

            Console.WriteLine(text);
            Console.ReadLine();





        }
    }
}
