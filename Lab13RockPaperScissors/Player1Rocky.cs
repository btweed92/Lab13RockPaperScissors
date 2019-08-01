using System;
using System.Collections.Generic;
using System.Text;

namespace Lab13RockPaperScissors
{
    class Player1Rocky : Player
    {
        public Player1Rocky()
        {
            name = "Rocky";
            roshambo = Roshambo.Rock;
        }
        

        public override Roshambo GenerateRoshambo()
        {
            return Roshambo.Rock;
        }
        
    }
}
