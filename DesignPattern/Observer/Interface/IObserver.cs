using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Observer.Interface
{
    public interface IObserver
    {
        void Update(bool current, string status);
    }
}
