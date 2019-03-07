using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int myNum = 6;
   
            //im asking the user to guess my number 
            Console.WriteLine("Guess my number somewhere between 1 and 10: ");
            int guess = int.Parse(Console.ReadLine());
            // checking if their number and my number is equal
            if (guess == myNum)
            {
                Console.WriteLine("You got it, you have guessed my number congrats.");
            }
            //checking if their number is greater than my number
            else if (guess > myNum)
            {
                Console.WriteLine("Your number you have entered is greater than my number");
            }
            //checking if their number is less than my number
            else
            {
                Console.WriteLine("Your number you have entered is less than my number");
            }
            //making sure the user knows he has completed the task
            Console.WriteLine("Congrats you have finnished task 2, press enter to continue");
            // making sure the program stays open the whole time
            Console.ReadKey();
        }
    }
}
