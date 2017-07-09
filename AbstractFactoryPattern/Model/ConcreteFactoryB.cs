using System;
using System.Collections.Generic;
using System.Text;
using AbstractFactoryPattern.Interface;

namespace AbstractFactoryPattern.Model
{
    class ConcreteFactoryB : AbstractFactory
    {
        public override AbstractProductA CreateProductA()
        {
            // Concrete Create Product A
            throw new NotImplementedException();
        }

        public override AbstractProductB CreateProductB()
        {
            // Concrete Create Product A
            throw new NotImplementedException();
        }
    }
}
