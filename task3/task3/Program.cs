using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your final mark: ");
            float Mark = float.Parse(Console.ReadLine());
            if (Mark >= 90 && Mark <= 100)
            {
                Console.WriteLine("Your grade is a A+");
            }
            else if (Mark >= 80 && Mark <= 89)
            {
                Console.WriteLine("Your grade is a A");
            }
            else if (Mark >= 70 && Mark <= 79)
            {
                Console.WriteLine("Your grade is a B+");

            }
            else if (Mark >= 60 && Mark <= 69)
            {
                Console.WriteLine("Your grade is a B");
            }
            else if (Mark >= 50 && Mark <= 59)
            {
                Console.WriteLine("Your grade is a C");
            }
            else if (Mark >= 40 && Mark <= 49)
            {
                Console.WriteLine("Your grade is a D");
            }
            else if (Mark >= 50 && Mark <= 59)
            {
                Console.WriteLine("Your grade is a F");
            }
            else
            {
                Console.WriteLine("Their was a problem with the number you entered. ");
            }
            Console.ReadKey();
        }
    }
}
