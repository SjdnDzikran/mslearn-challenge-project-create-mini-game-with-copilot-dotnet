using System;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            bool playAgain = true;
            while (playAgain)
            {
                Console.WriteLine("Choose Rock, Paper, or Scissors:");
                string userChoice = Console.ReadLine().ToLower();
                string[] choices = { "rock", "paper", "scissors" };
                Random rand = new Random();
                string computerChoice = choices[rand.Next(choices.Length)];

                Console.WriteLine($"Computer chose {computerChoice}");

                if (userChoice == computerChoice)
                {
                    Console.WriteLine("It's a tie!");
                }
                else if ((userChoice == "rock" && computerChoice == "scissors") ||
                         (userChoice == "paper" && computerChoice == "rock") ||
                         (userChoice == "scissors" && computerChoice == "paper"))
                {
                    Console.WriteLine("You win!");
                }
                else
                {
                    Console.WriteLine("You lose!");
                }

                Console.WriteLine("Do you want to play again? (yes/no)");
                string playAgainResponse = Console.ReadLine().ToLower();
                playAgain = playAgainResponse == "yes";
            }
        }
    }
}