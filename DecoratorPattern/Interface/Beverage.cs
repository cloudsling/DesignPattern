using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern.Interface
{
    public abstract class Beverage
    {
        public abstract string Descraption { get; }

        public abstract double Cost();

        public static void PrintOrder(Beverage beverage)
        {
            Console.WriteLine(beverage.Descraption + "\t" + beverage.Cost());
        }
    }
}
