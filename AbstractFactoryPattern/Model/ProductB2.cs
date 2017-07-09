using System;
using System.Collections.Generic;
using System.Text;
using AbstractFactoryPattern.Interface;

namespace AbstractFactoryPattern.Model
{
    class ProductB2 : AbstractProductB
    {
        public override void CreateSomething()
        {
            throw new NotImplementedException();
        }
    }
}
