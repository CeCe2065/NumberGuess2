using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuess2
{
    class Program
    {
        static void Main(string[] args)

        {
            int numberOfTries = 0;
            bool keepGoing = true;
            Random rnd = new Random();
            int randomnumber = rnd.Next(1, 100);

            while (keepGoing)
            {
                //pick a number, display guessed number
                Console.Write("Guess any integer between 1 and 100: ");
                int userentry = 0;
                int.TryParse(Console.ReadLine(), out userentry);

                if (numberOfTries == 5)
                {
                    Console.WriteLine($"You've already tried 5 times. You lose.");
                    Console.ReadKey(); // A break, So you can see it before the application exit.
                    keepGoing = false;
                }

                if (userentry > randomnumber)
                {
                    Console.WriteLine($"You entered {userentry}. That's too high.Try again.");
                    numberOfTries++;
                }

                if (userentry < randomnumber && randomnumber > 0)
                {
                    Console.WriteLine($"You entered {userentry}. That's too low.Try again.");
                    numberOfTries++;
                }

                if (userentry == randomnumber)
                {
                    Console.WriteLine($"You entered {userentry}. That's right.Good job.");
                    numberOfTries++;
                }

                else if (userentry == 0)
                {
                    Console.WriteLine("That is not a valid number.");
                }
            }
        }
    }

}