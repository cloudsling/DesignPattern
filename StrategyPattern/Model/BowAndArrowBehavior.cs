using System;
using System.Collections.Generic;
using System.Text;
using StrategyPattern.Interface;

namespace StrategyPattern.Model
{
    public class BowAndArrowBehavior : IKifeBehavior
    {
        public void UseWeapon()
        {
            Console.WriteLine("using Bow and Arrow..............");
        }
    }
}
