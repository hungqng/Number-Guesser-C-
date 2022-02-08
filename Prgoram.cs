using System;


// NNumber Guessing game
namespace NumberGuesser {
    // Main Class
    class Program {
        // Entry Point Method
        static void Main(string[] args){
            GetAppInfo();
            GreetUser();

            // Ask users name
            Console.WriteLine("What is your name?");

            // Get user input
            string input = Console.Readline();

            Console.WriteLine("Hello {0}, let's play a game...", input);

            // Create a new Random object
            Random random = new Random();
            int correctNumber = random.Next(1, 10);
            // Init guess var
            int guess = 0;

            // Ask user for number
            Console.WriteLine("Guess a number between 1 and 10");

            // While guess is not correct
            while(guess != correctNumber) {
                // Get users input
                string input = Console.Readline();
                // Make sure its a number
                if(!int.TryParse(input, out guess)){
                    // Change Text color
                    Console.ForegroundColor = ConsoleColor.Red;

                    // Tell user its not a number
                    Console.WriteLine("Please enter a number");

                    // Rset text color
                    Console.ResetColor();

                    continue;
                }
                // Cast to int and put in guess
                guess = Int32.Parse(input);

                // Match guess to correct number
                if(guess != correctNumber) {
                    // Change Text color
                    Console.ForegroundColor = ConsoleColor.Red;

                    // App info
                    Console.WriteLine("Wrong number, please try again");

                    // Rset text color
                    Console.ResetColor();
                }
            }
            // Change Text color
            Console.ForegroundColor = ConsoleColor.Yellow;

            // Tell user it's the right number
            Console.WriteLine("You are correct!!);

            // Rset text color
            Console.ResetColor();

            // Ask to play again
            Console.WriteLine("Would you like to try again? [Y or N]");

            // Get answer
            string answer = Console.ReadLine().ToUpper();

        }
        static void GetAppInfo() {
            // Set app variables
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Hung Nguyen";
            
            // Change Text color
            Console.ForegroundColor = ConsoleColor.Blue;

            // App info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            // Rset text color
            Console.ResetColor();
        }
    }
}