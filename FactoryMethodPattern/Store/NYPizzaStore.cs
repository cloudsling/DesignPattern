using System;
using System.Collections.Generic;
using System.Text;
using FactoryMethodPattern.Model;

namespace FactoryMethodPattern.Store
{
    public class NYPizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(string pizzaType)
        {
            Pizza pizza;

            if (pizzaType == "cheese")
            {
                pizza = new NYStyleCheesePizza();
            }
            else if (pizzaType == "clam")
            {
                pizza = new NYStyleClamPizza();
            }
            else // other condition
            {
                pizza = null;
            }

            return pizza;
        }
    }
}
