using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactoryPattern
{
    public class SimplePizzaFactory
    {
        public Pizza CreatePizza(string pizzaType)
        {
            Pizza pizza = null;

            if (pizzaType == "cheese")
            {
                pizza = new CheesePizza();
            }
            else if (pizzaType == "veggie")
            {
                pizza = new VeggiePizza();
            }

            return pizza;
        }
    }
}
