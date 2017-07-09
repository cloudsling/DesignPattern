using AbstractFactoryPattern.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern.Model
{
    class ProductA1 : AbstractProductA
    {
        public ProductA1(AbstractFactory factory)
        {
            _factory = factory;
        }

        private AbstractFactory _factory;

        public override void CreateSomething()
        {
            throw new NotImplementedException();
        }
    }
}
