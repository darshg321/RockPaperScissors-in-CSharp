
namespace RockPaperScissors
{
    internal class Program
    {
        static void Main()
        {
            Random rand = new Random();
            string botChoice = "";
            
            Console.WriteLine("Pick Rock, Paper, or Scissors");
            Console.WriteLine("Your Choice: ");
            string userChoice = Console.ReadLine();
            Console.WriteLine($"You picked: {userChoice}");
            
            int randNum = rand.Next(1, 4);
            
            if (randNum == 1)
            {
                botChoice = "Rock";
            }
            else if (randNum == 2)
            {
                botChoice = "Paper";
            }
            else if (randNum == 3)
            {
                botChoice = "Scissors";
            }
            Console.WriteLine($"Bot picked: {botChoice}");

            if (botChoice == userChoice)
            {
                Console.WriteLine("Tie!");
            }
            else if (botChoice == "Rock" && userChoice == "Paper")
            {
                Console.WriteLine("You Win!");
            }
            else if (botChoice == "Rock" && userChoice == "Scissors")
            {
                Console.WriteLine("You Lose!");
            }
            else if (botChoice == "Paper" && userChoice == "Rock")
            {
                Console.WriteLine("You Lose!");
            }
            else if (botChoice == "Paper" && userChoice == "Scissors")
            {
                Console.WriteLine("You Win!");
            }
            else if (botChoice == "Scissors" && userChoice == "Rock")
            {
                Console.WriteLine("You Win!");
            }
            else if (botChoice == "Scissors" && userChoice == "Paper")
            {
                Console.WriteLine("You Lose!");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Invalid Choice!");
                Main();
            }
            Console.WriteLine("Play Again? (Y/N)");
            var playAgain = Console.ReadKey();

            if (playAgain.Key == ConsoleKey.Y)
            {
                Console.Clear();
                Main();
            }
            else
            {
                return;
            }
        }
    }
}