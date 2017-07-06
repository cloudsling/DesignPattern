using System;
using System.Collections.Generic;
using System.Text;
using DecoratorPattern.Interface;

namespace DecoratorPattern.Model
{
    public class Espresso : Beverage
    {
        public override string Descraption => "Espresso";

        public override double Cost()
        {
            return 1.2;
        }
    }
}
