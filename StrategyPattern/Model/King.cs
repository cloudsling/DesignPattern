using System;
using System.Collections.Generic;
using System.Text;
using StrategyPattern.Interface;

namespace StrategyPattern.Model
{
    public class King : Character
    {
        public King()
        {
            SetWeapon(new SwordBehavior());
        }
        public override void Fight()
        {
            Console.WriteLine("I'm the King!!!!");
            Weapon.UseWeapon();
        }
    }
}
