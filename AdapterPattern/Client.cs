using System;

namespace AdapterPattern
{
    internal class Client
    {
        internal static void Main(string[] args)
        {
            Adaptee ada = new Adaptee();
            ObjectAdapter adapter = new ObjectAdapter(ada);

            adapter.Request();
        }
    }
}