using System;
using System.Collections.Generic;
using System.Text;
using StrategyPattern.Interface;

namespace StrategyPattern.Model
{
    public class Queen : Character
    { 
        public Queen()
        {
            Weapon = new BowAndArrowBehavior();
        }
    }
}
