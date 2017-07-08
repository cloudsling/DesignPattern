using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactoryPattern
{
    public abstract class Pizza
    {
        public virtual void Cut()
        {
            throw new NotImplementedException();
        }

        public virtual void Prepare()
        {
            throw new NotImplementedException();
        }

        public virtual void Bake()
        {
            throw new NotImplementedException();
        }

        public virtual void Box()
        {
            throw new NotImplementedException();
        }
    }
}
