using System;
using System.Collections.Generic;
using System.Text;
using StrategyPattern.Interface;

namespace StrategyPattern.Model
{
   public  class Knight : Character
    {
        public Knight()
        {
            Weapon = new KnifeBehavior();
        }
        public override void Fight()
        {
            for (var i = 0; i < 3; i++)
            {
                Weapon.UseWeapon();
            }
        }
    }
}
