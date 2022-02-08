using System;

// NNumber Guessing game
namespace NumberGuesser {
    // Main Class
    class Program {
        // Entry Point Method
        static void Main(string[] args){
            GetAppInfo();
            GreetUser();
            
            while (true) {
                // Create a new Random object
                Random random = new Random();
                int correctNumber = random.Next(1, 10);
                // Init guess var
                int guess = 0;

                // Ask user for number
                Console.WriteLine("Guess a number between 1 and 10");

                // While guess is not correct
                while (guess != correctNumber)
                    {
                        // Get users input
                        string input = Console.ReadLine();

                        // Make sure its a number
                        if (!int.TryParse(input, out guess))
                        {
                            // Print error message
                            PrintColorMessage(ConsoleColor.Red, "Please use an actual number");

                            // Keep going
                            continue;
                        }

                        // Cast to int and put in guess
                        guess = Int32.Parse(input);

                        // Match guess to correct number
                        if (guess != correctNumber)
                        {
                            // Print error message
                            PrintColorMessage(ConsoleColor.Red, "Wrong number, please try again");
                        }
                    }

                    // Print success message
                    PrintColorMessage(ConsoleColor.Yellow, "CORRECT!! You guessed it!");

                    // Ask to play again
                    Console.WriteLine("Play Again? [Y or N]");

                    // Get answer
                    string answer = Console.ReadLine().ToUpper();

                    if (answer == "Y") {
                        continue;
                    }
                    else if (answer == "N") {
                        return;
                    }
                    else {
                        return;
                    }
                }

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

            // Reset text color
            Console.ResetColor();
        }

        static void GreetUser() {
            // Ask user name
            Console.WriteLine("What is your name?")
             // Get user input
            string input = Console.Readline();

            Console.WriteLine("Hello {0}, let's play a game...", input);
        }
        
        static void PrintColorMessage(ConsoleColor color, string message) {
            // Change Text color
            Console.ForegroundColor = color;

            // App info
            Console.WriteLine(message);

            // Reset text color
            Console.ResetColor();
        }
    }
}