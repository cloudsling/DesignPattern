using System;
using System.Collections.Generic;
using System.Text;
using FactoryMethodPattern.Model;

namespace FactoryMethodPattern.Store
{
    public class ChicagoPizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(string pizzaType)
        {
            Pizza pizza;

            if (pizzaType == "cheese")
            {
                pizza = new ChicagoStyleCheesePizza();
            }
            else if (pizzaType == "clam")
            {
                pizza = new ChicagoStyleClamPizza();
            }
            else // other condition
            {
                pizza = null;
            }

            return pizza;
        }
    }
}
