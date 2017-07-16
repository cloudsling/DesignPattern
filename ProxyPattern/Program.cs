using System;

namespace ProxyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ISubject realSubject = new RealSubject();

            Proxy proxy = new Proxy(realSubject);
            proxy.Request();
        }
    }
}