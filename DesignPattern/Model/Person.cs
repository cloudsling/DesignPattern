using System;
using ObserverPattern.Interface;

namespace ObserverPattern.Model
{
    public abstract class Person : IObserver
    {
        public Person(ISubject sub)
        {
            _subject = sub;
            _subject.AddObserverToList(this);
        }
  
        public abstract void Update(bool current, string status);

        public void Work()
        {
            Console.WriteLine(_workStatus);
        }

        public ISubject _subject;
        public string _workStatus;
    }
}
