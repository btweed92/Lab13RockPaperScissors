using System;
using System.Collections.Generic;
using System.Text;

namespace Lab13RockPaperScissors
{
    abstract class Player
    {
        protected string name;
        protected Roshambo roshambo;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        

        public Player()
        {
           
        }

        //public Player(string name, string roshamboValue)
        //{
        //    Name = name;
        //    RoshamboValue = roshamboValue;
        //}

        public abstract Roshambo GenerateRoshambo();
    }
}
