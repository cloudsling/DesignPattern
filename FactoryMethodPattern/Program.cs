using System;
using FactoryMethodPattern.Store;

namespace FactoryMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaStore store = new ChicagoPizzaStore();
            store.OrderPizza("cheese");

            PizzaStore nyStore = new NYPizzaStore();
            nyStore.OrderPizza("clam");

            Console.Read();
        }
    }
}