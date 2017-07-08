using FactoryMethodPattern.Model;

namespace FactoryMethodPattern.Store
{
    public abstract class PizzaStore
    {
        public abstract Pizza CreatePizza(string pizzaType);

        public Pizza OrderPizza(string pizzaType)
        {
            Pizza pizza = CreatePizza(pizzaType);

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }
    }
}
