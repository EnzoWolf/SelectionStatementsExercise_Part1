using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionStatementsExercise_Part1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Create a program where the user must guess what your favorite number is: 
             
             * Step 1: Initialize an integer to represent a favorite number and assign a value with a number of your choosing or you can assign a random number to this variable:
                
                var r = new Random();
                var favNumber = r.Next(1,1000);
                
                var userInput = int.Parse(Console.ReadLine());
             
               The following code will allow the user to guess what your favorite number is:
               var userInput = int.Parse(Console.ReadLine());
             
             * Step 2: Create an if-statement that if the guessed number is below the initial value, print out “too low”.
             
             * Step 3: Create an else-if statement that if the number is higher than the initial value, print out “too high”.
             
             * Step 4: Create an else statement that prints out “Nevermind”.
             
             */

            //Initlizaing integer to represet favorite number

            var r = new Random();
            var favNum = r.Next(1, 1000);

            Console.WriteLine("Try to guess my favorite number!");
            var userInput = int.Parse(Console.ReadLine());

            if (userInput < favNum)
            {
                Console.WriteLine($"\r\nToo low! The number was {favNum}.");
            }
            else if (userInput > favNum)
            {
                Console.WriteLine($"\r\nToo high! The number was {favNum}.");
            }
            else if (userInput == favNum)
            {
                Console.WriteLine($"Correct! The number was {favNum}.");
            }
            else Console.WriteLine("\r\nNevermind!");

            Console.ReadLine();
        }
    }
}
