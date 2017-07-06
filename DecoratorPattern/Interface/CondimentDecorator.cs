using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern.Interface
{
    public abstract class CondimentDecorator : Beverage
    {
        public abstract override string Descraption { get; }
    }
}
