using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern.Model
{
    public class ChicagoStyleCheesePizza : Pizza
    {
        public ChicagoStyleCheesePizza()
        {
             Name = "Chicago Style Sauce and CheesePizza";
            Dough = "Extra Thin Crust Dough";
            Sauce = "Plum Potato Sauce";

            Toppings.Add("Shredded Mozzarella Cheese");
        }
    }
}
