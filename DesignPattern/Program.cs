using System;
using DesignPattern;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ObserverDelegator.DelegateMainMethod();

            Console.Read();
        }
    }
}