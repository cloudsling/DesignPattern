using System;
using System.Threading;
using DecoratorPattern.Interface;
using DecoratorPattern.Model;

namespace DecoratorPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Beverage coffee = new Espresso();
            Beverage.PrintOrder(coffee);

            Beverage withMocha = new DarkRoast();
            withMocha = new Mocha(withMocha);
            Beverage.PrintOrder(withMocha);

            Beverage withAll = new Espresso();
            withAll = new Milk(withAll);
            withAll = new Mocha(withAll);
            withAll = new Mocha(withAll);
            Beverage.PrintOrder(withAll);

            Console.Read();
        }
    }
}