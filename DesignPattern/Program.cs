using System;

namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
           new ObserverDelegator().DelegateMainMethod();
             
            Console.Read();
        }
    }
}