using System;
using System.Collections.Generic;
using System.Text;
using AbstractFactoryPattern.Interface;
using AbstractFactoryPattern.Model;

namespace AbstractFactoryPattern
{
    class Client
    {
        public void CreateProduct(string item)
        {
            AbstractFactory factory = new ConcreteFactoryA();

            AbstractProductA productA = factory.CreateProductA();
            AbstractProductB productB = factory.CreateProductB();
            
            // Something Others
        }
    }
}
