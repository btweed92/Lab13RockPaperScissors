using System;
using System.Collections.Generic;
using System.Text;

namespace Lab13RockPaperScissors
{
    class Player2Random : Player
    {
        Random random = new Random();
        public Player2Random()
        {
            Name = "Rando";
            
        }


        public override Roshambo GenerateRoshambo()
        {
            int r = random.Next(1, 4);
            Enum.TryParse(Enum.GetName(typeof(Roshambo), r), out Roshambo result);
            return result;
        }
    }
}
