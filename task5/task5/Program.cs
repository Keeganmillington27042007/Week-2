using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    class Program
    {
        static void Main(string[] args)
        {
            //asking user to enter a 4 digit PIN
            Console.WriteLine("Please enter a 4-digit PIN number: ");
            int PIN = int.Parse(Console.ReadLine());
            //if pin is greater than 1000 and pin is less that 9999 the do this
            if (PIN > 1000 && PIN < 9999)
            {
                // re-enter your pin to see if they are equal
                Console.WriteLine("Please re-enter your pin: ");
                int PIN2 = int.Parse(Console.ReadLine());
                //if pin is equal to pin2 do this
                if (PIN == PIN2)
                {
                    Console.WriteLine("Your PIN has been set!");
                }
                //if it does equal the same do this
                else
                {
                    Console.WriteLine("Your PIN numbers do not match, your PIN was not set");
                }
                //display to user
                Console.ReadKey();
            }
        
        }
    }
}
