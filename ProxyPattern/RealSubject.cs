using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyPattern
{
    class RealSubject : ISubject
    {
        public void Request()
        {
            throw new NotImplementedException();
        }
    }
}
