using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    class Invoker
    {
        private ICommand _command;
        public void SetCommand(ICommand command) => _command = command;

        public void Invoke()
        {
            _command.Execute();
        }
    }
}
