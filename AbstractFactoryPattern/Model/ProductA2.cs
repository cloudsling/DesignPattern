using AbstractFactoryPattern.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern.Model
{
    class ProductA2 : AbstractProductA
    {
        public override void CreateSomething()
        {
            throw new NotImplementedException();
        }
    }
}
