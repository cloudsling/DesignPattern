
using DecoratorPattern.Interface;

namespace DecoratorPattern.Model
{
   public class Mocha : CondimentDecorator
   {
       private readonly Beverage _beverage;

       public Mocha(Beverage beverage)
       {
           _beverage = beverage;
       }

       public override string Descraption => _beverage.Descraption + " with Mocha";

       public override double Cost()
       {
           return .8 + _beverage.Cost();
       }
    }
}
