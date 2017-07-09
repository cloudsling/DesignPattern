using AbstractFactoryPattern.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern.Model
{
    class ProductB1 : AbstractProductB
    {
        public override void CreateSomething()
        {
            throw new NotImplementedException();
        }
    }
}
