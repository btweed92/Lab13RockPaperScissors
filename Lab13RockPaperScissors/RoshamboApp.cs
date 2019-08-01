using System;

namespace Lab13RockPaperScissors
{
    enum Roshambo
    {
        Rock = 1, Paper, Scissors
    }
    class Program
    {

        static void Main(string[] args)
        {


            Console.WriteLine("~~~~~ Welcome to Rock, Paper, Scissors! ~~~~~");
            Console.WriteLine();
            Console.WriteLine("           Would you like to play?           ");
            Console.WriteLine("                  Yes or no?                 ");


            bool go = true;
            while (go)
            {
                string userInput = Console.ReadLine().ToLower();

                if (userInput == "y" || userInput == "yes")
                {
                    Console.WriteLine("      ~~~~~ Awesome, let's play! ~~~~~     ");
                    Console.WriteLine();

                    Play();

                    Console.WriteLine("Would you like to play again?");
                }
                else if (userInput == "n" || userInput == "no")
                {
                    Console.WriteLine("That's alright, have a good day");
                    Console.WriteLine($"You played a total of  ");
                    go = false;
                }
                else
                {
                    Console.WriteLine("That is not a valid input, please try 'Yes', 'y', 'n', or 'No'.");
                }
            }
        }
        public static void Play()
        {
            Player user = new Player3User();

            Console.WriteLine("Please enter your name:");
            user.Name = Console.ReadLine();

            Console.WriteLine("      Please choose an opponent:     ");
            Console.WriteLine("               Rocky                 ");
            Console.WriteLine("           ~~~  OR  ~~~              ");
            Console.WriteLine("               Rando                 ");
            string userVersus = Console.ReadLine().ToLower();

            if (userVersus == "rocky")
            {
                Player1Rocky p1 = new Player1Rocky();
                Roshambo userChoice = user.GenerateRoshambo();
                Roshambo npcChoice = p1.GenerateRoshambo();

                string result = WinLoseTie(userChoice, npcChoice);

                Console.WriteLine($"{user.Name}: {userChoice}");
                Console.WriteLine($"{p1.Name}: {npcChoice}");
                Console.WriteLine(result);
            }
            else if (userVersus == "rando")
            {
                Player2Random p2 = new Player2Random();
                Roshambo userChoice = user.GenerateRoshambo();
                Roshambo npcChoice = p2.GenerateRoshambo();

                string result = WinLoseTie(userChoice, npcChoice);

                Console.WriteLine($"{user.Name}: {userChoice}");
                Console.WriteLine($"{p2.Name}: {npcChoice}");
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Please try again");
            }

        }

        public static string WinLoseTie(Roshambo userChoice, Roshambo npcChoice)
        {
            int numWins = 0;
            int numTies = 0;
            int numLosses = 0;
            int numGames = numWins + numTies + numLosses;

            if (userChoice.Equals(npcChoice))
            {
                return "Tie";
                numTies++;
            }
            else if (userChoice == Roshambo.Rock && npcChoice == Roshambo.Scissors ||
                userChoice == Roshambo.Scissors && npcChoice == Roshambo.Paper || userChoice == Roshambo.Paper && npcChoice == Roshambo.Rock)
            {
                return "Winner";
                numWins++;
            }
            else
            {
                return "Loser";
                numLosses++;
            }
        }
    }
}
