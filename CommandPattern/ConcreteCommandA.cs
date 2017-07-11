using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    class ConcreteCommandA : ICommand
    {
        private Receiver _receiver;

        public ConcreteCommandA(Receiver receiver)
        {
            _receiver = receiver;
        }

        public void Execute()
        {
            _receiver.ActionA();
            // Other Operations
        }

        public void undo()
        {
            throw new NotImplementedException();
        }
    }
}
