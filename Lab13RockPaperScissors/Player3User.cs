using System;
using System.Collections.Generic;
using System.Text;

namespace Lab13RockPaperScissors
{
    class Player3User : Player
    {

        public Player3User()
        {
            Name = name;
        }
        public override Roshambo GenerateRoshambo()
        {
            Console.WriteLine("1. Rock");
            Console.WriteLine("2. Paper");
            Console.WriteLine("3. Scissors");
            int userRPS = int.Parse(Console.ReadLine());
            if(userRPS == 1)
            {
               return Roshambo.Rock;
            }
            else if(userRPS == 2)
            {
                return Roshambo.Paper;
            }
            else if(userRPS == 3)
            {
                return Roshambo.Scissors;
            }
            else
            {
                roshambo = (Roshambo)new Random().Next(3);
                return roshambo;
            }
        }
    }
}
