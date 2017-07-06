using DecoratorPattern.Interface;

namespace DecoratorPattern.Model
{
    public class Milk : CondimentDecorator
    {
        private readonly Beverage _beverage;

        public Milk(Beverage beverage)
        {
            _beverage = beverage;
        }

        public override string Descraption => _beverage.Descraption + " with Milk";

        public override double Cost()
        {
            return .98 + _beverage.Cost();
        }
    }
}
