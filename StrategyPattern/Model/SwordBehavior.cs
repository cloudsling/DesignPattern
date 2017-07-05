using System;
using System.Collections.Generic;
using System.Text;
using StrategyPattern.Interface;

namespace StrategyPattern.Model
{
    public class SwordBehavior : IKifeBehavior
    {
        public void UseWeapon()
        {
            Console.WriteLine("using Sword..............");
        }
    }
}
