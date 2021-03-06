﻿namespace ObserverPattern.Interface
{
    public interface ISubject
    {
        void AddObserverToList(IObserver o);

        void RemoveObserverFormList(IObserver o);

        void NotifyAllObservers();
    }
}
