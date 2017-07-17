using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    internal class ConcreteBuilderB : Builder
    {
        private readonly Product _product = new Product();
        internal override void BuildPartA()
        {
            _product.TypeA = "A2";
        }

        internal override void BuildPartB()
        {

            _product.TypeB = "B2";
        }

        internal override Product GetResult()
        {
            return _product;
        }
    }
}
