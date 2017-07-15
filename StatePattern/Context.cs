using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern
{
    internal class Context
    {
        private IState _stateA;

        private IState _stateB;


        public IState State { get; set; }
        public Context()
        {
            _stateA = new ConcreteStateA();
            _stateB = new ConcreteStateB();
            State = _stateA;
        }

        public void Request()
        {
            State.Handle();
        }
    }
}
