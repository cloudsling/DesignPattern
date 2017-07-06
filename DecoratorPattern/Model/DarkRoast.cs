using System;
using System.Collections.Generic;
using System.Text;
using DecoratorPattern.Interface;

namespace DecoratorPattern.Model
{
    public class DarkRoast : Beverage
    {
        public override string Descraption => "Dark Roast";

        public override double Cost()
        {
            return 2.33;
        }
    }
}
