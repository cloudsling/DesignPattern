using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.Interface
{
    public abstract class Character
    {
        protected IKifeBehavior Weapon;

        public void SetWeapon(IKifeBehavior weapon)
        {
            Weapon = weapon;
        }

        public virtual void Fight()
        {
            Weapon.UseWeapon();
        }
    }
}
