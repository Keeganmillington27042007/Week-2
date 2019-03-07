using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            // asking the user for a number 
            Console.WriteLine("Enter a number: ");
            //converting and storing the number
            int num = int.Parse(Console.ReadLine());
            //if the user number is able to == to devide by 2
            if (num % 2 == 0)
            {
                Console.WriteLine("You number is a even number.");
            }
            else
            {
                Console.WriteLine("you number is an odd number. ");
            }

            Console.WriteLine("Click enter to continue");
            
        }
    }
}
