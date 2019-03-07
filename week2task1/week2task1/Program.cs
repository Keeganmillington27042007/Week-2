using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week2task1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Asking for the user to enter 2 numbers
            Console.WriteLine("Enter your first number: ");
            int Fnum = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your second number: ");
            int Snum = int.Parse(Console.ReadLine());
            //an if statement seeing if both numbers the user has entered are equal to eachother
        if (Fnum == Snum)
            {
                Console.WriteLine("The two numbers that you have entered are both equal.");
            }
            //an if statement seeing if the first number the user has entered is bigger than the second number entered
            else if (Fnum > Snum)
            {
                Console.WriteLine($"The first number entered, {Fnum}, is larger than your second number.");
            }
            //an if statement seeing if the first number the user has entered is smaller than the second number entered
            else
            {
                Console.WriteLine($"The first number entered, {Fnum}, is smaller than your second number.");
            }
           // a statement letting the user know that he has finnished
            Console.WriteLine("You have completed the first stage of the task, press enter to continue.");
            // i used console.readkey to display the code to the user so it doesnt disappear
            Console.ReadKey();
        }
    }
}
