using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyPattern
{
    class Proxy : ISubject
    {
        private ISubject _realSubject;

        public Proxy(ISubject subject)
        {
            _realSubject = subject;
        }
        public void Request()
        {
            throw new NotImplementedException();
        }
    }
}
