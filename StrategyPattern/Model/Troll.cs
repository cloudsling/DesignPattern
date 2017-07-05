using System;
using System.Collections.Generic;
using System.Text;
using StrategyPattern.Interface;

namespace StrategyPattern.Model
{
    public class Troll : Character
    {
        public Troll()
        {
            Weapon = new AxeBehavior();
        }
        public override void Fight()
        {
            Weapon.UseWeapon();
            Console.WriteLine("XD");
        }
    }
}
