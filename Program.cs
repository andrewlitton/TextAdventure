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
            Console.WriteLine();
            Console.WriteLine("Are you ready for your first question?");
            string response = Console.ReadLine();
            Console.WriteLine();
            if(response == "yes")
            {
                Console.WriteLine("That's the spirit!");
            }
            else
            {
                Console.WriteLine("Don't be an ass! You're playing whether you like it or not.");
            }
            Console.WriteLine();
            Console.WriteLine("Press Enter to continue.");
            Console.ReadLine();
            Console.WriteLine("Here's your first question:");
            Console.WriteLine("(Choose a lower case letter)");
            Console.WriteLine();
            do
            {
                Console.WriteLine("Who won the 2019 Super Bowl?");
                Console.WriteLine("a. Atlanta Falcons");
                Console.WriteLine("b. Oakland Raiders");
                Console.WriteLine("c. New England Patriots");
                Console.WriteLine("d. Tampa Bay Bucs");
                Console.WriteLine();
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
            }
            while (response != "c");
            Console.WriteLine();
            Console.WriteLine("Press Enter to Continue");
            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("Here is your next question:");
            Console.WriteLine("(Choose a lower case letter)");
            Console.WriteLine();
            do
            {
                Console.WriteLine("What is the name of Auburn University's tiger mascot?");
                Console.WriteLine("a. Big Al");
                Console.WriteLine("b. Tiger Paw");
                Console.WriteLine("c. Mike the Tiger");
                Console.WriteLine("d. Aubie");
                Console.WriteLine();
                response = Console.ReadLine();
                if (response != "d")
                {
                    Console.WriteLine("That's Incorrect!");
                    Console.WriteLine("Try again.");
                }
                else
                {
                    Console.WriteLine("DING DING DING! War Eagle! Give yourself a point!");
                }
            }
            while (response != "d");
            Console.WriteLine();
            Console.WriteLine("Press Enter to Continue");
            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("Question number three:");
            Console.WriteLine("(Choose a lower case letter)");
            Console.WriteLine();
            do
            {
                Console.WriteLine("In basketball, how many personal fouls is one player allowed to accumluate before being disqualified from the game?");
                Console.WriteLine("a. Four");
                Console.WriteLine("b. Five");
                Console.WriteLine("c. Six");
                Console.WriteLine("d. Seven");
                Console.WriteLine();
                response = Console.ReadLine();
                if (response != "b")
                {
                    Console.WriteLine("That's Incorrect!");
                    Console.WriteLine("Try again.");
                }
                else
                {
                    Console.WriteLine("Were you an All-American? Give yourself a point!");
                }
            }
            while (response != "b");
            Console.WriteLine();














        }
    }
}
