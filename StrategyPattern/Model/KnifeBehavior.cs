using System;
using System.Collections.Generic;
using System.Text;
using StrategyPattern.Interface;

namespace StrategyPattern.Model
{
    public class KnifeBehavior : IKifeBehavior
    {
        public void UseWeapon()
        {
            Console.WriteLine("using knife..............");
        }
    }
}
