using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern.Model
{
    class ChicagoStyleClamPizza : Pizza
    {
        public ChicagoStyleClamPizza()
        {
            Name = "NY Style Sauce and CheesePizza";
            Dough = "Thin Crust Dough";
            Sauce = "Marinara Sauce";

            Toppings.Add("Grated Reggiano Cheese");
        }
    }
}
