using System;

namespace DrewsFirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Let's play trivia!");
            Console.WriteLine("What's your name?");

            string nameResponse = Console.ReadLine();

            Console.WriteLine("Welcome! Nice to meet you," + " " + nameResponse + "!");

            Console.WriteLine("Are you ready for your first question?");

            string response = Console.ReadLine();

            if(response == "yes")
            {
                Console.WriteLine("That's the spirit!");
            }
            else
            {
                Console.WriteLine("What a loser!  You're playing whether you like it or not.");
            }

            Console.WriteLine("Press Enter to continue.");
            Console.ReadLine();

            Console.WriteLine("Here's your first question:");

            Console.WriteLine("Who won the 2019 Super Bowl?");
            Console.WriteLine("a. Atlanta Falcons");
            Console.WriteLine("b. Oakland Raiders");
            Console.WriteLine("c. New England Patriots");
            Console.WriteLine("d. Tampa Bay Bucs");

            response = Console.ReadLine();
            if(response != "c")
            {
                Console.WriteLine("That's Incorrect!");
                Console.WriteLine("Try again.");                
            }
            else
            {
                Console.WriteLine("Wow! You're smart! Give yourself a point!");
            }
            response = Console.ReadLine();
            if (response != "c")
            {
                Console.WriteLine("That's Incorrect!");
                Console.WriteLine("Try again.");
            }
            else
            {
                Console.WriteLine("Wow! You're smart! Give yourself a point!");
            }
            response = Console.ReadLine();
            if (response != "c")
            {
                Console.WriteLine("That's Incorrect!");
                Console.WriteLine("Try again.");
            }
            else
            {
                Console.WriteLine("Wow! You're smart! Give yourself a point!");
            }
            response = Console.ReadLine();
            if (response != "c")
            {
                Console.WriteLine("That's Incorrect!");
                Console.WriteLine("Try again.");
            }
            else
            {
                Console.WriteLine("Wow! You're smart! Give yourself a point!");
            }

            Console.WriteLine("Press Any Key to Continue");
            Console.ReadKey(); 

            Console.WriteLine("Here is your next question:");
            Console.WriteLine("What is the name of Auburn University's tiger mascot?");
            Console.WriteLine("a. Big Al");
            Console.WriteLine("b. Tiger Paw");
            Console.WriteLine("c. Mike the Tiger");
            Console.WriteLine("d. Aubie");

            response = Console.ReadLine();
            if (response != "d")
            {
                Console.WriteLine("That's Incorrect!");
                Console.WriteLine("Try again.");
            }
            else
            {
                Console.WriteLine("Wow! You're smart! Give yourself another point!");
            }
            response = Console.ReadLine();
            if (response != "d")
            {
                Console.WriteLine("That's Incorrect!");
                Console.WriteLine("Try again.");
            }
            else
            {
                Console.WriteLine("Wow! You're smart! Give yourself another point!");
            }
            response = Console.ReadLine();
            if (response != "d")
            {
                Console.WriteLine("That's Incorrect!");
                Console.WriteLine("Try again.");
            }
            else
            {
                Console.WriteLine("Wow! You're smart! Give yourself another point!");
            }
            response = Console.ReadLine();
            if (response != "d")
            {
                Console.WriteLine("That's Incorrect!");
                Console.WriteLine("Try again.");
            }
            else
            {
                Console.WriteLine("Wow! You're smart! Give yourself another point!");
            }

            Console.WriteLine("Press Any Key to Continue");
            response = Console.ReadLine();



        }
    }
}
