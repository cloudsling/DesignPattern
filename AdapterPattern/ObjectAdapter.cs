using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern
{
    internal class ObjectAdapter : ITarget
    {
        private readonly Adaptee _adaptee;

        public ObjectAdapter(Adaptee adaptee)
        {
            _adaptee = adaptee;
        }

        public void Request()
        {
            _adaptee.AdapteeRequest();
        }

        //other implementation
    }
}
