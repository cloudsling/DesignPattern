using System;

namespace CommandPattern
{
    internal class Client
    {
        internal static void Main(string[] args)
        {
            Invoker invoker = new Invoker();

            Receiver receiver = new Receiver();
            ICommand command = new ConcreteCommandA(receiver);

            invoker.SetCommand(command);
            invoker.Invoke();

            Console.Read();
        }
    }
}