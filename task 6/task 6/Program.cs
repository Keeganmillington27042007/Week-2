using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("3 letter word palindrome checker.");
            Console.WriteLine("Enter you first letter of palindrome: ");
            string Fletter = Console.ReadLine();
            Console.WriteLine("Enter you second letter of palindrome: ");
            string Sletter = Console.ReadLine();
            Console.WriteLine("Enter you third letter of palindrome: ");
            string Tletter = Console.ReadLine();

            if (Sletter == "a" || Sletter == "e" || Sletter == "i" || Sletter == "o" || Sletter == "u" )
            {
                Console.WriteLine("{0}{1}{2} ");
            }
            else 
            {
                Console.WriteLine("This is nota actual word! ");
            }
            if (Sletter == )
        }
    }
}
